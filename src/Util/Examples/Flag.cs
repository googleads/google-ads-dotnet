// Copyright 2018 Google LLC
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using SystemType = System.Type;


namespace Google.Ads.GoogleAds.Examples
{
    /// <summary>
    /// Base class for a command line flag.
    /// </summary>
    internal abstract class Flag
    {
        /// <summary>
        /// Gets the flag prototype.
        /// </summary>
        internal string Prototype
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the flag description.
        /// </summary>
        internal string Description
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a value indicating whether this flag is repeatable.
        /// </summary>
        internal bool IsRepeatable
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Flag"/> class.
        /// </summary>
        /// <param name="prototype">The flag prototype. This takes the form "--flagName="</param>
        /// <param name="description">The flag description.</param>
        /// <param name="isRepeatable">if set to <c>true</c>, this flag is repeatable, so you can
        /// repeat --flagName=value multiple times.</param>
        internal Flag(string prototype, string description, bool isRepeatable)
        {
            this.Prototype = prototype;
            this.Description = description;
            this.IsRepeatable = isRepeatable;
        }

        /// <summary>
        /// Gets the value of the flag if the flag is non-repeatable.
        /// </summary>
        internal abstract object Value
        {
            get;
        }

        /// <summary>
        /// Gets the values of the flag if the flag is repeatable.
        /// </summary>
        internal abstract Array Values
        {
            get;
        }

        /// <summary>
        /// Resets the flag.
        /// </summary>
        internal abstract void Reset();

        /// <summary>
        /// Parse a flag value.
        /// </summary>
        /// <param name="flagValue">The flag value.</param>
        internal abstract void Parse(string flagValue);
    }

    /// <summary>
    /// A command line flag.
    /// </summary>
    /// <typeparam name="T">The flag type.</typeparam>
    internal class Flag<T> : Flag
    {
        /// <summary>
        /// The typed value for the flag.
        /// </summary>
        private List<T> typedValue = new List<T>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Flag{T}"/> class which is non-repeatable.
        /// </summary>
        /// <param name="prototype">The flag prototype.</param>
        /// <param name="description">The flag description.</param>
        internal Flag(string prototype, string description) : this(prototype, description, false)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Flag{T}"/> class which may be repeatable.
        /// </summary>
        /// <param name="prototype">The flag prototype.</param>
        /// <param name="description">The flag description.</param>
        /// <param name="isRepeatable">if set to <c>true</c> this flag is repeatable.</param>
        public Flag(string prototype, string description, bool isRepeatable)
            : base(prototype, description, isRepeatable) { }

        /// <summary>
        /// Resets this flag.
        /// </summary>
        internal override void Reset()
        {
            typedValue.Clear();
        }

        /// <summary>
        /// Gets the value if this flag is non-repeatable.
        /// </summary>
        internal override object Value
        {
            get
            {
                if (IsRepeatable)
                {
                    throw new InvalidOperationException(
                        "This is a repeatable flag, use Values property instead.");
                }
                else
                {
                    return typedValue.Count > 0 ? typedValue[0] : default(T);
                }
            }
        }

        /// <summary>
        /// Gets the values if this flag is repeatable.
        /// </summary>
        internal override Array Values
        {
            get
            {
                if (!IsRepeatable)
                {
                    throw new InvalidOperationException(
                        "This is a non-repeatable flag, use Value property instead.");
                }
                else
                {
                    return typedValue.ToArray();
                }
            }
        }

        /// <summary>
        /// Parse a value.
        /// </summary>
        /// <param name="flagValue">The flag value.</param>
        internal override void Parse(string flagValue)
        {
            if (!IsRepeatable && typedValue.Count > 0)
            {
                throw new ArgumentException(
                    string.Format("Found repeated value for non-repeatable flag: {0}.",
                        this.Prototype));
            }

            TypeConverter typeConverter = TypeDescriptor.GetConverter(typeof(T));
            try
            {
                typedValue.Add((T) typeConverter.ConvertFromString(flagValue));
            }
            catch (Exception e)
            {
                throw new ArgumentException($"Failed to parse flag : {this.Prototype}.", e);
            }
        }
    }

    /// <summary>
    /// A utility class to help with command line parsing.
    /// </summary>
    internal class Flags
    {
        /// <summary>
        /// Parses the specified arguments into a list of flags..
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <param name="flags">The flags.</param>
        public static void Parse(IEnumerable<string> args, Flag[] flags)
        {
            Dictionary<string, Flag> flagMap = new Dictionary<string, Flag>();
            flags.ToList().ForEach(delegate (Flag f)
            {
                flagMap.Add(f.Prototype, f);
            });

            foreach (string arg in args)
            {
                int index = arg.IndexOf('=');
                if (index == -1 || index == arg.Length)
                {
                    throw new ArgumentException($"Malformed command line parameter: {arg}.");
                }

                string flagName = arg.Substring(0, index + 1);
                string flagValue = arg.Substring(index + 1);
                if (flagMap.ContainsKey(flagName))
                {
                    Flag flag = flagMap[flagName];
                    flag.Parse(flagValue);
                }
                else
                {
                    throw new ArgumentException($"Unknown command line parameter: {arg}.");
                }
            }
        }

        /// <summary>
        /// Creates a flag from the parameter information.
        /// </summary>
        /// <param name="parameterInfo">The parameter information.</param>
        /// <returns>The flag.</returns>
        internal static Flag FromParameterInfo(ParameterInfo parameterInfo)
        {
            SystemType flagType = null;
            string prototype = $"--{parameterInfo.Name}=";
            bool isRepeatable = false;
            string description = "";

            if (parameterInfo.ParameterType.IsArray)
            {
                isRepeatable = true;
                flagType = parameterInfo.ParameterType.GetElementType();
            } else
            {
                isRepeatable = false;
                flagType = parameterInfo.ParameterType;

            }

            SystemType typeToCreate = typeof(Flag<>).MakeGenericType(flagType);
            return (Flag) Activator.CreateInstance(typeToCreate, prototype, description,
                isRepeatable);
        }
    }
}
