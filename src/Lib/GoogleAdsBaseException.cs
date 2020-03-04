using Google.Protobuf;
using Grpc.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace Google.Ads.GoogleAds.Lib
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Grpc.Core.RpcException" />
    public abstract class GoogleAdsBaseException : RpcException
    {
        /// <summary>
        /// Gets the request ID.
        /// </summary>
        public string RequestId
        {
            get;
            protected set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAdsBaseException{T}"/> class.
        /// </summary>
        /// <param name="status">Resulting status of a call.</param>
        /// <param name="message">The exception message.</param>
        protected GoogleAdsBaseException(Status status, string message) : base(status, message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAdsBaseException{T}"/> class.
        /// </summary>
        /// <param name="status">Resulting status of a call.</param>
        /// <param name="trailers">Response trailing metadata.</param>
        protected GoogleAdsBaseException(Status status, Metadata trailers) : base(status, trailers)
        {
        }

        /// <summary>
        /// Parses the failure.
        /// </summary>
        /// <typeparam name="U"></typeparam>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        protected U ParseFailure<U>(byte[] data) where U : IMessage<U>
        {
            MessageParser<U> parser = (MessageParser<U>) typeof(U)
                .GetProperty("Parser", BindingFlags.Public | BindingFlags.Static)
                .GetValue(null);

            return parser.ParseFrom(data);
        }

        /// <summary>
        /// Gets the name of the version from type name.
        /// </summary>
        /// <param name="type">The class type.</param>
        /// <returns></returns>
        internal static string GetFailureKeyFromTypeName(System.Type type)
        {
            string version = type.FullName
                .Replace("Google.Ads.GoogleAds.", "")
                .Replace(".Errors.GoogleAdsException", "").ToLower();

            return string.Format(MetadataKeyNames.FailureKeyTemplate, version);
        }
    }

    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Grpc.Core.RpcException" />
    public abstract class GoogleAdsBaseException<T> : GoogleAdsBaseException where T : IMessage<T>
    {
        /// <summary>
        /// Gets the Google Ads failure details.
        /// </summary>
        public T Failure
        {
            get;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAdsBaseException{T}"/> class.
        /// </summary>
        /// <param name="status">Resulting status of a call.</param>
        /// <param name="message">The exception message.</param>
        protected GoogleAdsBaseException(Status status, string message) : base(status, message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAdsBaseException{T}"/> class.
        /// </summary>
        /// <param name="status">Resulting status of a call.</param>
        /// <param name="trailers">Response trailing metadata.</param>
        protected GoogleAdsBaseException(Status status, Metadata trailers) : base(status, trailers)
        {
            foreach (Metadata.Entry entry in trailers)
            {
                if (entry.Key == MetadataKeyNames.RequestId)
                {
                    RequestId = entry.Value;
                }
                else if (entry.Key.EndsWith(MetadataKeyNames.FailureKeySuffix))
                {
                    Failure = ParseFailure<T>(entry.ValueBytes);
                }
            }
        }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            JObject jsonObject = new JObject(
                new JProperty("StatusCode", this.StatusCode),
                new JProperty("Details", this.Status.Detail),
                new JProperty("RequestId", this.RequestId)
            );

            if (this.Failure != null)
            {
                jsonObject.Add(new JProperty("Failure", JObject.Parse(
                    JsonFormatter.ToDiagnosticString(this.Failure))));
            }

            return JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
        }
    }
}
