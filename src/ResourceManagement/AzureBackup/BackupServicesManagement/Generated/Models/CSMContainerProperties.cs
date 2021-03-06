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

namespace Microsoft.Azure.Management.BackupServices.Models
{
    /// <summary>
    /// The definition of CSMContainerProperties.
    /// </summary>
    public partial class CSMContainerProperties
    {
        private string _containerType;
        
        /// <summary>
        /// Optional. Container Type
        /// </summary>
        public string ContainerType
        {
            get { return this._containerType; }
            set { this._containerType = value; }
        }
        
        private string _friendlyName;
        
        /// <summary>
        /// Optional. Container Friendly Name
        /// </summary>
        public string FriendlyName
        {
            get { return this._friendlyName; }
            set { this._friendlyName = value; }
        }
        
        private string _healthStatus;
        
        /// <summary>
        /// Optional. Container Health Status
        /// </summary>
        public string HealthStatus
        {
            get { return this._healthStatus; }
            set { this._healthStatus = value; }
        }
        
        private string _parentContainerId;
        
        /// <summary>
        /// Optional. Parent Container Id
        /// </summary>
        public string ParentContainerId
        {
            get { return this._parentContainerId; }
            set { this._parentContainerId = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Optional. Container Registration Status
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the CSMContainerProperties class.
        /// </summary>
        public CSMContainerProperties()
        {
        }
    }
}
