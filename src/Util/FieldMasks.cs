// Copyright 2018, Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

using System;
using System.Collections;
using System.Linq;

namespace Google.Ads.GoogleAds.Util
{
    /// <summary>
    /// Utility methods for working with field paths.
    /// </summary>
    public static class FieldMasks
    {
        /// <summary>
        /// Constructs a fieldmask object that captures the list of all set fields of an object.
        /// </summary>
        /// <param name="modified">The modified object.</param>
        /// <returns>A fieldmask object that captures the list of all set fields.</returns>
        public static FieldMask AllSetFieldsOf<T>(IMessage<T> modified)
            where T : class, IMessage<T>
        {
            IMessage<T> original = (IMessage<T>) modified.Descriptor.Parser.ParseFrom(new byte[] { });
            return FromChanges(original, modified);
        }

        /// <summary>
        /// Compares two messages, constructing a field mask to express the difference between them.
        /// </summary>
        /// <param name="modified">The modified object.</param>
        /// <param name="original">The original object.</param>
        /// <returns>A fieldmask object that captures the changes.</returns>
        public static FieldMask FromChanges<T>(IMessage<T> original, IMessage<T> modified)
                where T : class, IMessage<T>
        {
            // TODO: Permit null parameters? What would we return?
            GaxPreconditions.CheckNotNull(modified, nameof(modified));

            FieldMask mask = new FieldMask();
            CompareField(mask, "", original, modified);
            return mask;
        }

        /// <summary>
        /// Compares a given field for two messages, and captures the differences between them.
        /// </summary>
        /// <param name="mask">The fieldmask to store the differences to.</param>
        /// <param name="fieldName">The field name to compare.</param>
        /// <param name="original">The original value of the field.</param>
        /// <param name="modified">The modified value of the field.</param>
        private static void CompareField(FieldMask mask, string fieldName, IMessage original,
            IMessage modified)
        {
            var descriptor = modified.Descriptor;
            foreach (var childField in descriptor.Fields.InFieldNumberOrder())
            {
                string childFieldName = GetFullFieldName(fieldName, childField);
                var originalChildValue = childField.Accessor.GetValue(original);
                var modifiedChildValue = childField.Accessor.GetValue(modified);
                if (childField.IsRepeated)
                {
                    if (!Equals(originalChildValue, modifiedChildValue))
                    {
                        mask.Paths.Add(childFieldName);
                    }
                }
                else
                {
                    switch (childField.FieldType)
                    {
                        case FieldType.Message:
                            if (!Equals(originalChildValue, modifiedChildValue))
                            {
                                // For wrapper types, just emit the field name.
                                if (IsWrapperType(childField.MessageType))
                                {
                                    mask.Paths.Add(childFieldName);
                                }
                                else if (originalChildValue == null)
                                {
                                    // New value? Emit the field names for all known fields in the message,
                                    // recursing for nested messages.
                                    AddNewFields(mask, childFieldName, (IMessage) modifiedChildValue);
                                }
                                else if (modifiedChildValue == null)
                                {
                                    // Just emit the deleted field name
                                    mask.Paths.Add(childFieldName);
                                }
                                else
                                {
                                    CompareField(mask, childFieldName, (IMessage) originalChildValue,
                                        (IMessage) modifiedChildValue);
                                }
                            }
                            break;

                        case FieldType.Group:
                            throw new NotSupportedException("Groups are not supported in proto3");
                        default: // Primitives
                            if (childField.HasPresence)
                            {
                                // Presence fields should be handled based on whether the field has
                                // value.
                                bool originalChildHasValue = childField.Accessor.HasValue(original);
                                bool modifiedChildHasValue = childField.Accessor.HasValue(modified);

                                // Both fields have value, but the values don't match.
                                if (originalChildHasValue && modifiedChildHasValue &&
                                    !Equals(originalChildValue, modifiedChildValue))
                                {
                                    mask.Paths.Add(childFieldName);
                                }
                                else if (originalChildHasValue || modifiedChildHasValue)
                                {
                                    // Only one of the fields have value.
                                    mask.Paths.Add(childFieldName);
                                }
                            }
                            else if (!Equals(originalChildValue, modifiedChildValue))
                            {
                                mask.Paths.Add(childFieldName);
                            }
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Gets the field value.
        /// </summary>
        /// <param name="fieldMaskPath">The field mask path.</param>
        /// <param name="entity">The entity to retrieve values from.</param>
        /// <returns>The </returns>
        /// <exception cref="ArgumentException">Thrown if the path cannot be recursed further.
        /// </exception>
        public static object GetFieldValue(string fieldMaskPath, IMessage entity)
        {
            string[] fieldMaskParts = fieldMaskPath.Split('.');
            int currentFieldIndex = 0;
            IMessage currentEntity = entity;
            bool fieldMatchFound = false;
            while (currentFieldIndex < fieldMaskParts.Length)
            {
                fieldMatchFound = false;
                if (currentEntity == null)
                {
                    string currentPath = string.Join(".",
                        fieldMaskParts.Take(currentFieldIndex + 1));
                    throw new ArgumentException($"Cannot get field value. {currentPath} is null.");
                }
                var descriptor = currentEntity.Descriptor;
                foreach (var childField in descriptor.Fields.InFieldNumberOrder())
                {
                    if (childField.Name != fieldMaskParts[currentFieldIndex])
                    {
                        continue;
                    }
                    fieldMatchFound = true;
                    var childValue = childField.Accessor.GetValue(currentEntity);

                    if (!childField.IsRepeated && childField.FieldType == FieldType.Message &&
                        childValue is IMessage)
                    {
                        // we can recurse.
                        currentFieldIndex++;
                        currentEntity = childValue as IMessage;
                        break;
                    }
                    else if (childField.IsRepeated && childValue is IList)
                    {
                        if (currentFieldIndex + 1 == fieldMaskParts.Length)
                        {
                            return childValue;
                        }
                        else
                        {
                            string currentPath = string.Join(".",
                                fieldMaskParts.Take(currentFieldIndex + 1));
                            throw new ArgumentException($"Cannot retrieve field value. A " +
                                $"repeated field was encountered after navigating " +
                                $"{fieldMaskPath} upto {currentPath}.");
                        }
                    }
                    else
                    {
                        if (currentFieldIndex + 1 == fieldMaskParts.Length)
                        {
                            // we cannot recurse any longer.
                            return childValue;
                        }
                        else
                        {
                            string currentPath = string.Join(".",
                                fieldMaskParts.Take(currentFieldIndex + 1));
                            throw new ArgumentException($"Cannot retrieve field value. A " +
                                $"non-IMessage field was encountered after navigating " +
                                $"{fieldMaskPath} upto {currentPath}.");
                        }
                    }
                }
                if (!fieldMatchFound)
                {
                    string currentPath = string.Join(".",
                        fieldMaskParts.Take(currentFieldIndex + 1));
                    throw new ArgumentException($"Cannot retrieve field value. A " +
                        $"matching field was not found after navigating the " +
                        $"{fieldMaskPath} upto {currentPath}.");
                }
            }
            return currentEntity;
        }

        /// <summary>
        /// Gets the full name of the field.
        /// </summary>
        /// <param name="parentFieldName">The parent field name.</param>
        /// <param name="field">The field for which full name should be evaluated.</param>
        /// <returns>The full name of the field.</returns>
        private static string GetFullFieldName(string parentFieldName, FieldDescriptor field) =>
            parentFieldName == "" ? field.Name : $"{parentFieldName}.{field.Name}";

        /// <summary>
        /// Recursively adds field names for a new message. Repeated fields, primitive fields and
        /// unpopulated single message fields are included just by name; populated single message
        /// fields are processed recursively, only including leaf nodes.
        /// </summary>
        /// <param name="fieldName">The current field.</param>
        /// <param name="mask">The fieldmask that keeps track of changes.</param>
        /// <param name="message">The message for which new fieldmasks are generated.</param>
        private static void AddNewFields(FieldMask mask, string fieldName, IMessage message)
        {
            var descriptor = message.Descriptor;
            foreach (var field in descriptor.Fields.InFieldNumberOrder())
            {
                string name = GetFullFieldName(fieldName, field);
                object value = field.Accessor.GetValue(message);

                if (field.IsRepeated)
                {
                    if (value is IList && (value as IList).Count > 0)
                    {
                        // Generate fieldmask for a repeated field only if there's at least one
                        // element in the list. Also, don't recurse, since fieldmask doesn't
                        // support index notation.
                        mask.Paths.Add(name);
                    }
                }
                else
                {
                    if (field.FieldType == FieldType.Message)
                    {
                        // For single message fields, recurse if there's a value; otherwise just add the
                        // field name.
                        if (value != null)
                        {
                            AddNewFields(mask, name, (IMessage) value);
                        }
                        else
                        {
                            mask.Paths.Add(name);
                        }
                    }
                    else if (field.HasPresence)
                    {
                        // The presence fields should first be checked for HasValue.
                        if (field.Accessor.HasValue(message))
                        {
                            mask.Paths.Add(name);
                        }
                    }
                    else if (IsBasicType(field.FieldType))
                    {
                        // Add a field mask only if there is a non-default value.
                        var defaultValue = GetDefaultValue(field.FieldType);
                        if (defaultValue != value)
                        {
                            mask.Paths.Add(name);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Determines whether a field is basic type or not.
        /// </summary>
        /// <param name="type">The type.</param>
        private static bool IsBasicType(FieldType type)
        {
            switch (type)
            {
                case FieldType.Double:
                case FieldType.Float:
                case FieldType.Int64:
                case FieldType.UInt64:
                case FieldType.Int32:
                case FieldType.Fixed64:
                case FieldType.Fixed32:
                case FieldType.Bool:
                case FieldType.String:
                case FieldType.Bytes:
                case FieldType.UInt32:
                case FieldType.SFixed32:
                case FieldType.SFixed64:
                case FieldType.SInt32:
                case FieldType.SInt64:
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Gets the default value for a type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The default value.</returns>
        private static object GetDefaultValue(FieldType type)
        {
            switch (type)
            {
                case FieldType.Double:
                case FieldType.Float:
                    return 0D;
                case FieldType.Int64:
                case FieldType.UInt64:
                case FieldType.Fixed64:
                case FieldType.Fixed32:
                case FieldType.SFixed32:
                case FieldType.SFixed64:
                case FieldType.SInt64:
                    return 0L;
                case FieldType.Int32:
                case FieldType.UInt32:
                case FieldType.SInt32:
                    return 0;
                case FieldType.Bool:
                    return false;
                case FieldType.String:
                    return "";
                case FieldType.Bytes:
                    return ByteString.Empty;
                default:
                    return null;
            }
        }

        /// <summary>
        /// Determines whether the specified message descriptor is a wrapper type or not.
        /// </summary>
        /// <param name="descriptor">The message descriptor.</param>
        /// <returns>True if the message descriptor is a wrapper type, false otherwise.</returns>
        private static bool IsWrapperType(MessageDescriptor descriptor)
        {
            return descriptor.File.Package == "google.protobuf" &&
                descriptor.File.Name == "google/protobuf/wrappers.proto";
        }
    }
}
