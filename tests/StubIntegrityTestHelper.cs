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
using System.Reflection;

using SystemType = System.Type;

namespace Google.Ads.GoogleAds.Tests
{
    /// <summary>
    /// Utility class that provides functionality to test the integrity of
    /// generated stub code for various API services.
    /// </summary>
    public class StubIntegrityTestHelper
    {
        /// <summary>
        /// The callback to be called when the <see cref="EnumerateServices"/> method
        /// finds a matching service signature.
        /// </summary>
        /// <param name="serviceSignature">The service signature.</param>
        public delegate void EnumerateServiceCallback(object serviceSignature);

        /// <summary>
        /// The callback to be called when the <see cref="EnumerateEnumFields"/> method
        /// finds a matching service signature.
        /// </summary>
        /// <param name="hashedFieldName">The field name in a hashed format
        /// (typename_fieldname).</param>
        /// <param name="enumValue">The enum value.</param>
        public delegate void EnumerateEnumFieldsCallback(string hashedFieldName, int enumValue);

        /// <summary>
        /// Enumerates the services supported in a Ads Service.
        /// </summary>
        /// <typeparam name="ServiceType">The Ads service being tested
        /// (e.g. <see cref="Services"/>)</typeparam>
        /// <param name="onServiceFound">The callback to be called when a matching
        /// service is found.</param>
        public static void EnumerateServices<ServiceType>(EnumerateServiceCallback onServiceFound)
        {
            SystemType serviceType = typeof(ServiceType);

            // All the supported service types are defined as nested classes within the
            // service type. Each of the nested type has multiple ServiceTemplate entries,
            // one per supported service. This allows user to create a service like:
            //
            // var campaignService = user.GetService(Services.V0.ReportingService);
            SystemType[] versionTypes = serviceType.GetNestedTypes();

            foreach (SystemType versionType in versionTypes)
            {
                FieldInfo[] serviceFields = versionType.GetFields
                    (BindingFlags.Static | BindingFlags.Public);
                foreach (FieldInfo fieldInfo in serviceFields)
                {
                    onServiceFound(fieldInfo.GetValue(null));
                }
            }
        }

        /// <summary>
        /// Enumerates the enum fields and values under a given root namespace.
        /// </summary>
        /// <typeparam name="ServiceType"></typeparam>
        /// <param name="rootNameSpace">The root name space.</param>
        /// <param name="onEnumFieldDeclarationFound">The callback to be called when
        /// a matching enumeration field is found.</param>
        public static void EnumerateEnumFields<ServiceType>(string rootNameSpace,
            EnumerateEnumFieldsCallback onEnumFieldDeclarationFound)
        {
            // Find all supported versions.
            SystemType serviceType = typeof(ServiceType);
            SystemType[] versionTypes = serviceType.GetNestedTypes();

            ISet<string> rootEnums = new HashSet<string>();

            // Find out the namespace for each supported API version.
            foreach (SystemType versionType in versionTypes)
            {
                string typeName = versionType.Name;
                string namespaceName = rootNameSpace + typeName;
                rootEnums.Add(namespaceName);
            }

            // Enumerate all types in the client library.
            foreach (SystemType declaredType in serviceType.Assembly.GetTypes())
            {
                // If this is an enumeration within a namespace that corresponds to a
                // supported API version then process further.
                if (rootEnums.Contains(declaredType.Namespace) && declaredType.IsEnum)
                {
                    Array values = declaredType.GetEnumValues();

                    foreach (object value in values)
                    {
                        string enumName = declaredType.GetEnumName(value);

                        // Generate a unique name as EnumTypeName.EnumFieldName.
                        string hashedName = declaredType.Name + "." + enumName;
                        int enumValue = (int) value;

                        onEnumFieldDeclarationFound(hashedName, enumValue);
                    }
                }
            }
        }
    }
}
