// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Insights.Models
{
    /// <summary>
    /// Represents the display name in a specific locale.
    /// </summary>
    public partial class LocalizedString
    {
        private string _locale;
        
        /// <summary>
        /// Optional. Gets or sets the locale to use when displaying the
        /// counter name.
        /// </summary>
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }
        
        private string _value;
        
        /// <summary>
        /// Optional. Gets or sets the display name for the counter.
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the LocalizedString class.
        /// </summary>
        public LocalizedString()
        {
        }
    }
}
