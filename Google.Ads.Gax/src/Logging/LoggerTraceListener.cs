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


using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using LogLevel = Microsoft.Extensions.Logging.LogLevel;

namespace Google.Ads.Gax.Logging
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="System.Diagnostics.TraceListener" />
    public class LoggerTraceListener : TraceListener
    {
        private readonly ILogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggerTraceListener"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public LoggerTraceListener(ILogger logger)
        {
            this.logger = logger;
        }

        /// <inheritdoc/>
        public override void Write(string message)
        {
            logger.LogInformation(message);
        }

        /// <inheritdoc/>
        public override void WriteLine(string message)
        {
            logger.LogInformation(message);
        }

        /// <inheritdoc/>
        public override void WriteLine(string message, string category)
        {
            logger.LogInformation(category + ": " + message);
        }

        /// <summary>
        /// Maps a <see cref="TraceEventType"/> to <see cref="LogLevel"/>.
        /// </summary>
        /// <param name="eventType">Trace event type.</param>
        /// <returns>The log level.</returns>
        public static LogLevel MapLevel(TraceEventType eventType)
        {
            switch (eventType)
            {
                case TraceEventType.Verbose:
                    return LogLevel.Debug;

                case TraceEventType.Information:
                    return LogLevel.Information;

                case TraceEventType.Critical:
                    return LogLevel.Critical;

                case TraceEventType.Error:
                    return LogLevel.Error;

                case TraceEventType.Warning:
                    return LogLevel.Warning;

                default:
                    return LogLevel.Trace;
            }
        }

        /// <inheritdoc/>
        public override void TraceEvent(TraceEventCache eventCache, string source,
            TraceEventType eventType, int id, string format, params object[] args)
        {
            TraceEvent(eventCache, source, eventType, id, string.Format(format, args));
        }
        /// <inheritdoc/>
        public override void TraceEvent(TraceEventCache eventCache, string source,
            TraceEventType eventType, int id)
        {
            TraceEvent(eventCache, source, eventType, id, String.Empty);
        }

        /// <inheritdoc/>
        public override void TraceEvent(TraceEventCache eventCache, string source,
            TraceEventType eventType, int id, string message)
        {
            logger.Log(MapLevel(eventType), id, message);
        }
    }
}