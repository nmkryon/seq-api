﻿// Copyright 2014-2019 Datalust and contributors. 
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

namespace Seq.Api.Model.AppInstances
{
    /// <summary>
    /// Metrics describing an <see cref="AppInstanceEntity"/>.
    /// </summary>
    public class AppInstanceMetricsPart
    {
        /// <summary>
        /// The number of events that reached the app in the past minute.
        /// </summary>
        public int ReceivedEventsPerMinute { get; set; }

        /// <summary>
        /// The number of diagnostic events raised by the app in the past minute.
        /// </summary>
        /// <remarks>This does not include the events received by an input app.</remarks>
        public int EmittedEventsPerMinute { get; set; }

        /// <summary>
        /// The size, in bytes, of the app process working set.
        /// </summary>
        public long ProcessWorkingSetBytes { get; set; }

        /// <summary>
        /// If the app process is running, <c>true</c>; otherwise, <c>false</c>.
        /// </summary>
        public bool IsRunning { get; set; }
    }
}
