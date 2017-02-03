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

namespace Microsoft.Azure.Graph.RBAC.Models
{
    /// <summary>
    /// Active Directory group information
    /// </summary>
    public partial class Group
    {
        private string _displayName;
        
        /// <summary>
        /// Optional. Gets or sets group display name
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }
        
        private string _mail;
        
        /// <summary>
        /// Optional. Gets or sets mail field
        /// </summary>
        public string Mail
        {
            get { return this._mail; }
            set { this._mail = value; }
        }
        
        private string _objectId;
        
        /// <summary>
        /// Optional. Gets or sets object Id
        /// </summary>
        public string ObjectId
        {
            get { return this._objectId; }
            set { this._objectId = value; }
        }
        
        private string _objectType;
        
        /// <summary>
        /// Optional. Gets or sets object type
        /// </summary>
        public string ObjectType
        {
            get { return this._objectType; }
            set { this._objectType = value; }
        }
        
        private bool? _securityEnabled;
        
        /// <summary>
        /// Optional. Gets or sets security enabled field
        /// </summary>
        public bool? SecurityEnabled
        {
            get { return this._securityEnabled; }
            set { this._securityEnabled = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Group class.
        /// </summary>
        public Group()
        {
        }
    }
}
