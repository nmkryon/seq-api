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

namespace Seq.Api.Model.Users
{
    /// <summary>
    /// A entry to include in a user's search history.
    /// </summary>
    public class SearchHistoryItemPart
    {
        /// <summary>
        /// The filter entered by the user into the filter bar.
        /// </summary>
        public string Search { get; set; }

        /// <summary>
        /// Status to apply to the search history item.
        /// </summary>
        public SearchHistoryItemStatus Status { get; set; }
    }
}
