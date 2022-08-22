// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;
using System;
using System.Linq;
using System.Reflection;

namespace Google.Ads.Gax.Util
{
    /// <summary>
    /// Utility methods for working with protobuf objects.
    /// </summary>
    public static class ProtobufUtilities
    {
        /// <summary>
        /// Parses an enum from the original protobuf name of the field.
        /// </summary>
        /// <typeparam name="T">Type of the enum to parse into.</typeparam>
        /// <param name="name">The protobuf name.</param>
        /// <returns>The parsed enum.</returns>
        public static T ParseOriginalEnumFieldName<T>(string name)
            where T : Enum
        {
            FieldInfo[] fields = typeof(T).GetFields(BindingFlags.Public |
                BindingFlags.Static);
            foreach (FieldInfo field in fields)
            {
                OriginalNameAttribute originalName = (OriginalNameAttribute)
                   field.GetCustomAttributes(typeof(OriginalNameAttribute),
                       false).FirstOrDefault();
                if (originalName != null && originalName.Name == name)
                {
                    return (T)Enum.Parse(typeof(T), field.Name, true);
                }
            }
            return default(T);
        }

        /// <summary>
        /// Gets the original name of an enum field in case it was renamed for
        /// name style conventions.
        /// </summary>
        /// <returns>The original name, or an empty string if the name cannot be retrieved.</returns>
        public static string GetOriginalEnumFieldName(object obj)
        {
            FieldInfo fi = obj.GetType().GetField(obj.ToString());
            if (fi != null)
            {
                OriginalNameAttribute originalName = (OriginalNameAttribute)
                    fi.GetCustomAttributes(typeof(OriginalNameAttribute),
                        false).FirstOrDefault();
                if (originalName != null)
                {
                    return originalName.Name;
                }
            }
            return "";
        }

        /// <summary>
        /// Parses the failure.
        /// </summary>
        /// <typeparam name="U"></typeparam>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public static U Parse<U>(byte[] data) where U : IMessage<U>, new()
        {
            MessageParser<U> parser = new MessageParser<U>(() => new U());
            return parser.ParseFrom(data);
        }

        /// <summary>
        /// Gets the metadata key name when a type is serialized as bytes.
        /// </summary>
        /// <typeparam name="U">The type.</typeparam>
        /// <returns>The key name.</returns>
        public static string GetBinarySerializationKeyName<U>() where U : IMessage<U>, new()
        {
            return new U().Descriptor.FullName.ToLower() + "-bin";
        }

        /// <summary>
        /// Gets the metadata entry by key.
        /// </summary>
        /// <param name="metadata">The metadata.</param>
        /// <param name="key">The key.</param>
        /// <returns>The entry.</returns>
        public static Metadata.Entry GetEntry(this Metadata metadata, string key)
        {
            return metadata.Where(e => e.Key == key).FirstOrDefault();
        }
    }
}