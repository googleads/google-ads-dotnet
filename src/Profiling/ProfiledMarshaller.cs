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
    /// A marshaller that wraps another marshaller and profiles it.
    /// </summary>
    /// <typeparam name="T">The type that the underlying marshaller can serialize or deserialize.
    /// </typeparam>
    internal class ProfiledMarshaller<T>
    {
        /// <summary>
        /// The marshaller that this instance wraps.
        /// </summary>
        private Marshaller<T> wrappedMarshaller;

        /// <summary>
        /// Gets the marshaller.
        /// </summary>
        internal Marshaller<T> Marshaller
        {
            get;
            private set;
        }

        /// <summary>
        /// The time profile for recording time taken by the serialization and deserialization
        /// process.
        /// </summary>
        private TimeProfile timeProfile;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfiledMarshaller{T}"/> class.
        /// </summary>
        /// <param name="marshaller">The marshaller.</param>
        /// <param name="timeProfile">The time profile.</param>
        internal ProfiledMarshaller(Marshaller<T> marshaller, TimeProfile timeProfile)
        {
            this.timeProfile = timeProfile;
            Wrap(marshaller);
        }

        /// <summary>
        /// Wraps the specified marshaller.
        /// </summary>
        /// <param name="marshaller">The marshaller.</param>
        /// <returns></returns>
        private void Wrap(Marshaller<T> marshaller)
        {
            this.wrappedMarshaller = marshaller;
            this.Marshaller = new Marshaller<T>(SerializeWithContext, DeserializeWithContext);
        }

        /// <summary>
        /// Deserializes the specified object.
        /// </summary>
        /// <param name="ctx">The deserialization context.</param>
        /// <returns>The deserialized object.</returns>
        private T DeserializeWithContext(DeserializationContext ctx)
        {
            T retval = default;
            TimeInterval timeTaken = Timer.Benchmark(() => {
                retval = this.wrappedMarshaller.ContextualDeserializer(ctx);
            });
            this.timeProfile.Deserialize.Add(timeTaken);
            return retval;
        }

        /// <summary>
        /// Deserializes the specified object.
        /// </summary>
        /// <param name="arg">The serialized bytes.</param>
        /// <returns>The deserialized object.</returns>
        private T Deserialize(byte[] arg)
        {
            T retval = default;
            TimeInterval timeTaken = Timer.Benchmark(() => {
                retval = this.wrappedMarshaller.Deserializer(arg);
            });
            this.timeProfile.Deserialize.Add(timeTaken);
            return retval;
        }

        /// <summary>
        /// Serializes the specified object.
        /// </summary>
        /// <param name="arg">The object to serialize.</param>
        /// <param name="ctx">The serialization context.</param>
        private void SerializeWithContext(T arg, SerializationContext ctx)
        {
            TimeInterval timeTaken = Timer.Benchmark(() =>
            {
                this.wrappedMarshaller.ContextualSerializer(arg, ctx);
            });

            this.timeProfile.Serialize.Start = timeTaken.Start;
            this.timeProfile.Serialize.End = timeTaken.End;
        }

        /// <summary>
        /// Serializes the specified object.
        /// </summary>
        /// <param name="arg">The object to serialize.</param>
        /// <returns>The serialized bytes.</returns>
        private byte[] Serialize(T arg)
        {
            byte[] retval = null;

            TimeInterval timeTaken = Timer.Benchmark(() =>
            {
                retval = this.wrappedMarshaller.Serializer(arg);
            });

            this.timeProfile.Serialize.Start = timeTaken.Start;
            this.timeProfile.Serialize.End = timeTaken.End;
            return retval;
        }
    }
}
