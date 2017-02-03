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
using Microsoft.Azure;
using Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Management.Network.Models
{
    /// <summary>
    /// If the resource provide needs to return an error to any operation, it
    /// should return the appropriate HTTP error code and a message body as
    /// can be seen below.The message should be localized per the
    /// Accept-Language header specified in the original request such thatit
    /// could be directly be exposed to users
    /// </summary>
    public partial class ResourceProviderErrorResponse : AzureOperationResponse
    {
        private Error _error;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public Error Error
        {
            get { return this._error; }
            set { this._error = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ResourceProviderErrorResponse
        /// class.
        /// </summary>
        public ResourceProviderErrorResponse()
        {
        }
    }
}
