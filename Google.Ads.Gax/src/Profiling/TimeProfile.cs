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

using Google.Ads.Gax.Lib;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Google.Ads.Gax.Profiling
{
    /// <summary>
    /// Represents a time profile.
    /// </summary>
    internal class TimeProfile
    {
        /// <summary>
        /// The status checker, to check if the underlying API call is complete.
        /// </summary>
        private Func<Status> statusChecker;

        /// <summary>
        /// The trailign metadata checker, to retrieve the request ID.
        /// </summary>
        private Func<Metadata> getTrailers;

        /// <summary>
        /// ID of this time profile.
        /// </summary>
        internal Guid ID
        {
            get;
        } = Guid.NewGuid();

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data
        /// structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="p">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance;
        ///   otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object p)
        {
            // If parameter is null, return false.
            if (Object.ReferenceEquals(p, null))
            {
                return false;
            }

            // Optimization for a common success case.
            if (Object.ReferenceEquals(this, p))
            {
                return true;
            }

            // If run-time types are not exactly the same, return false.
            if (this.GetType() != p.GetType())
            {
                return false;
            }

            return this.ID == (p as TimeProfile).ID;
        }

        /// <summary>
        /// Gets or sets the name of the service.
        /// </summary>
        internal string ServiceName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the method.
        /// </summary>
        /// <value>
        /// The name of the method.
        /// </value>
        internal string MethodName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the time taken for the serialization portion of this profile.
        /// </summary>
        internal TimeInterval Serialize
        {
            get;
        } = new TimeInterval();

        /// <summary>
        /// Gets the time taken for the deserialization portion of this profile.
        /// </summary>
        internal List<TimeInterval> Deserialize
        {
            get;
        } = new List<TimeInterval>();

        /// <summary>
        /// Gets the time taken for the first RPC and Network overhead. You can subtract the time
        /// taken for the RPC from the server logs.
        /// </summary>
        internal TimeInterval RPCAndNetwork
        {
            get
            {
                return new TimeInterval()
                {
                    Start = Serialize.End,
                    End = Deserialize.First().Start
                };
            }
        }

        /// <summary>
        /// Gets the serialize span.
        /// </summary>
        internal TimeSpan PagingNetworkOverhead
        {
            get
            {
                TimeSpan span = new TimeSpan();
                for (int i = 0; i < Deserialize.Count - 1; i++)
                {
                    span += (Deserialize[i + 1].Start - Deserialize[i].End);
                }
                return span;
            }
        }

        /// <summary>
        /// Gets the serialization overhead.
        /// </summary>
        internal TimeSpan SerializeOverhead
        {
            get
            {
                return Serialize.Duration;
            }
        }

        /// <summary>
        /// Gets the deserialization overhead.
        /// </summary>
        internal TimeSpan DeserializeOverhead
        {
            get
            {
                TimeSpan span = new TimeSpan();
                for (int i = 0; i < Deserialize.Count; i++)
                {
                    span += Deserialize[i].Duration;
                }
                return span;
            }
        }

        /// <summary>
        /// Gets the time taken for the End-To-End call.
        /// </summary>
        /// <remarks>This is calculated as End time of last Deserialize entry - Start time of
        /// Serialize Entry.</remarks>
        internal TimeInterval E2E
        {
            get
            {
                TimeInterval end = (Deserialize.Count > 0) ? Deserialize.Last() : Serialize;
                return new TimeInterval()
                {
                    Start = Serialize.Start,
                    End = end.End
                };
            }
        }

        /// <summary>
        /// Sets the status checker.
        /// </summary>
        /// <param name="statusChecker">The status checker.</param>
        internal void SetStatusChecker(Func<Status> statusChecker)
        {
            this.statusChecker = statusChecker;
        }

        /// <summary>
        /// Sets the metadata checker.
        /// </summary>
        /// <param name="getTrailers">The trailing metdata checker.</param>
        internal void SetMetadataChecker(Func<Metadata> getTrailers)
        {
            this.getTrailers = getTrailers;
        }

        /// <summary>
        /// Gets the request identifier associated with this API call.
        /// </summary>
        /// <returns>The request ID.</returns>
        internal string GetRequestId()
        {
            Metadata trailers = this.getTrailers();
            AdsResponseMetadata respHeaders = new AdsResponseMetadata(trailers);
            return respHeaders.RequestId;
        }

        /// <summary>
        /// Wait for the API call to complete.
        /// </summary>
        private void WaitForCompletion()
        {
            if (statusChecker == null)
            {
                throw new InvalidOperationException("Status checker is not set.");
            }
            while (true)
            {
                try
                {
                    statusChecker();
                    return;
                }
                catch
                {
                    Thread.Sleep(100);
                }
            }
        }

        /// <summary>
        /// Gets a debug string.
        /// </summary>
        /// <returns>
        /// A Debug string.
        /// </returns>
        internal string GetDebugString()
        {
            WaitForCompletion();
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Method: {ServiceName}::{MethodName}");
            builder.AppendLine($"Request ID: {GetRequestId()}");
            builder.AppendLine($"E2E: Start: {E2E.Start}, End: {E2E.End}, " +
                $"Diff: {E2E.Duration.TotalMilliseconds} ms.");
            builder.AppendLine($"  - RPC+Network: Start: {RPCAndNetwork.Start}, " +
                $"End: {RPCAndNetwork.End}, Diff: {RPCAndNetwork.Duration.TotalMilliseconds} ms.");
            builder.AppendLine($"  - Serialize: {SerializeOverhead.TotalMilliseconds} ms.");
            builder.AppendLine($"  - Deserialize: {DeserializeOverhead.TotalMilliseconds} ms.");
            return builder.ToString();
        }
    }
}
