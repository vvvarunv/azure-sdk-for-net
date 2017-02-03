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
using Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Management.Network.Models
{
    /// <summary>
    /// Network security rule
    /// </summary>
    public partial class SecurityRule : ChildResource
    {
        private string _access;
        
        /// <summary>
        /// Required. Gets or sets network traffic is allowed or denied.
        /// Possible values are “Allow” and “Deny”
        /// </summary>
        public string Access
        {
            get { return this._access; }
            set { this._access = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. Gets or sets a description for this rule. Restricted to
        /// 140 chars.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _destinationAddressPrefix;
        
        /// <summary>
        /// Required. Gets or sets destination address prefix. CIDR or source
        /// IP range. Asterix “*” can also be used to match all source IPs.
        /// Default tags such as ‘VirtualNetwork’, ‘AzureLoadBalancer’ and
        /// ‘Internet’ can also be used.
        /// </summary>
        public string DestinationAddressPrefix
        {
            get { return this._destinationAddressPrefix; }
            set { this._destinationAddressPrefix = value; }
        }
        
        private string _destinationPortRange;
        
        /// <summary>
        /// Optional. Gets or sets Destination Port or Range. Integer or range
        /// between 0 and 65535. Asterix “*” can also be used to match all
        /// ports.
        /// </summary>
        public string DestinationPortRange
        {
            get { return this._destinationPortRange; }
            set { this._destinationPortRange = value; }
        }
        
        private string _direction;
        
        /// <summary>
        /// Required. Gets or sets the direction of the rule.InBound or
        /// Outbound. The direction specifies if rule will be evaluated on
        /// incoming or outcoming traffic.
        /// </summary>
        public string Direction
        {
            get { return this._direction; }
            set { this._direction = value; }
        }
        
        private int _priority;
        
        /// <summary>
        /// Optional. Gets or sets the priority of the rule. The value can be
        /// between 100 and 4096. The priority number must be unique for each
        /// rule in the collection. The lower the priority number, the higher
        /// the priority of the rule.
        /// </summary>
        public int Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }
        
        private string _protocol;
        
        /// <summary>
        /// Required. Gets or sets Network protocol this rule applies to. Can
        /// be Tcp, Udp or All(*).
        /// </summary>
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. Gets or sets Provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private string _sourceAddressPrefix;
        
        /// <summary>
        /// Required. Gets or sets source address prefix. CIDR or source IP
        /// range. Asterix “*” can also be used to match all source IPs.
        /// Default tags such as ‘VirtualNetwork’, ‘AzureLoadBalancer’ and
        /// ‘Internet’ can also be used. If this is an ingress rule, specifies
        /// where network traffic originates from.
        /// </summary>
        public string SourceAddressPrefix
        {
            get { return this._sourceAddressPrefix; }
            set { this._sourceAddressPrefix = value; }
        }
        
        private string _sourcePortRange;
        
        /// <summary>
        /// Optional. Gets or sets Source Port or Range. Integer or range
        /// between 0 and 65535. Asterix “*” can also be used to match all
        /// ports.
        /// </summary>
        public string SourcePortRange
        {
            get { return this._sourcePortRange; }
            set { this._sourcePortRange = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SecurityRule class.
        /// </summary>
        public SecurityRule()
        {
        }
    }
}
