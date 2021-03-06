// Copyright 2014-2019 Datalust and contributors. 
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

namespace Seq.Api.Model.Events
{
    /// <summary>
    /// A name/value property associated with an event.
    /// </summary>
    //  Note, this duplicates InputAppliedPropertyPart.
    public class EventPropertyPart
    {
        /// <summary>
        /// Construct an <see cref="EventPropertyPart"/>.
        /// </summary>
        /// <param name="name">The property name (required).</param>
        /// <param name="value">The property value, or <c>null</c>.</param>
        public EventPropertyPart(string name, object value)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Value = value;
        }

        /// <summary>
        /// The property name (required).
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The property value, or <c>null</c>.
        /// </summary>
        public object Value { get; }
    }
}
