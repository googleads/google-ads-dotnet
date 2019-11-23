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

using Google.Ads.GoogleAds.Util;

using System.ComponentModel;

namespace Google.Ads.GoogleAds.Config
{
    /// <summary>
    /// A config setting, to be used with <see cref="ConfigBase"/> and derived classes.
    /// </summary>
    public abstract class ConfigSetting
    {
        /// <summary>
        /// Gets the name of the setting.
        /// </summary>
        public string Name
        {
            get; protected set;
        }

        /// <summary>
        /// Tries to parse a value.
        /// </summary>
        /// <param name="valueText">The value text.</param>
        public abstract void TryParse(string valueText);
    }

    /// <summary>
    /// A config setting of a specified type, to be used with <see cref="ConfigBase"/>
    /// and derived classes.
    /// </summary>
    /// <typeparam name="SettingType">The type of the setting.</typeparam>
    public class ConfigSetting<SettingType> : ConfigSetting
    {
        /// <summary>
        /// Gets or sets the value of the setting.
        /// </summary>
        public SettingType Value
        {
            get; set;
        }

        /// <summary>
        /// Gets the default value of the setting.
        /// </summary>
        public SettingType DefaultValue
        {
            get; private set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigSetting{SettingType}"/> class.
        /// </summary>
        /// <param name="name">Name of the setting.</param>
        /// <param name="defaultValue">The default value.</param>
        public ConfigSetting(string name, SettingType defaultValue)
        {
            Name = name;
            DefaultValue = defaultValue;
            Value = defaultValue;
        }

        /// <summary>
        /// Tries to parse a value.
        /// </summary>
        /// <param name="valueText">The value text.</param>
        public override void TryParse(string valueText)
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(SettingType));
            try
            {
                Value = (SettingType) converter.ConvertFromInvariantString(valueText);
            }
            catch
            {
                TraceUtilities.WriteGeneralWarnings(string.Format(
                    ErrorMessages.ConfigSettingParseError, Name, valueText));
            }
        }
    }

    /// <summary>
    /// A specialized config setting class for string type so parsing can be skipped.
    /// </summary>
    public class StringConfigSetting : ConfigSetting<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringConfigSetting"/> class.
        /// </summary>
        /// <param name="name">Name of the setting.</param>
        /// <param name="defaultValue">The default value.</param>
        public StringConfigSetting(string name, string defaultValue) : base(name, defaultValue)
        {
        }

        /// <summary>
        /// Tries to parse a value.
        /// </summary>
        /// <param name="valueText">The value text.</param>
        public override void TryParse(string valueText)
        {
            this.Value = valueText;
        }
    }
}
