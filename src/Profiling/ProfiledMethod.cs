// Copyright 2020 Google LLC
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

using Grpc.Core;
using System;

namespace Google.Ads.GoogleAds.Profiling
{
    /// <summary>
    /// A method that wraps over another method for profiling purposes.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    internal class ProfiledMethod<TRequest, TResponse>
    {
        /// <summary>
        /// The profiled request marshaller.
        /// </summary>
        private ProfiledMarshaller<TRequest> requestMarshaller;

        /// <summary>
        /// The profiled response marshaller.
        /// </summary>
        private ProfiledMarshaller<TResponse> responseMarshaller;

        /// <summary>
        /// The wrapped method.
        /// </summary>
        private Method<TRequest, TResponse> wrappedMethod;

        /// <summary>
        /// The time profile for recording time taken by the serialization and deserialization
        /// process, as well as the method details.
        /// </summary>
        private TimeProfile timeProfile = new TimeProfile();

        /// <summary>
        /// Gets the method.
        /// </summary>
        internal Method<TRequest, TResponse> Method
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfiledMethod{TRequest, TResponse}"/>
        /// class.
        /// </summary>
        /// <param name="method">The method to wrap over.</param>
        /// <param name="enableProfiling">A flag to determine whether to enable profiling or not.
        /// </param>
        internal ProfiledMethod(Method<TRequest, TResponse> method, bool enableProfiling)
        {
            if (enableProfiling)
            {
                Wrap(method);
            }
            else
            {
                this.Method = method;
            }
        }

        internal bool IsAsync
        {
            get;
        }

        /// <summary>
        /// Sets the status checker, that can be used to check if the method call is complete
        /// or not.
        /// </summary>
        /// <param name="statusCallback">The status callback.</param>
        internal void SetStatusChecker(Func<Status> statusCallback)
        {
            timeProfile.SetStatusChecker(statusCallback);
        }

        internal void SetMetadataChecker(Func<Metadata> getTrailers)
        {
            timeProfile.SetMetadataChecker(getTrailers);
        }

        /// <summary>
        /// Wraps the specified method.
        /// </summary>
        /// <param name="method">The method to be wrapped.</param>
        private void Wrap(Method<TRequest, TResponse> method)
        {
            this.wrappedMethod = method;
            this.requestMarshaller = new ProfiledMarshaller<TRequest>(
                method.RequestMarshaller, timeProfile);
            this.responseMarshaller = new ProfiledMarshaller<TResponse>(
                method.ResponseMarshaller, timeProfile);
            timeProfile.ServiceName = method.ServiceName;
            timeProfile.MethodName = method.Name;
            this.Method = new Method<TRequest, TResponse>(method.Type, method.ServiceName,
                method.Name, this.requestMarshaller.Marshaller,
                this.responseMarshaller.Marshaller);
            ProfileTracker.Instance.AddProfile(timeProfile);
        }
    }
}
