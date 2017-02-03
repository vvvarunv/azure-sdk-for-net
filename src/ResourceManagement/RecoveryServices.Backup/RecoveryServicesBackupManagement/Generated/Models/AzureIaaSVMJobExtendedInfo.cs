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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    /// <summary>
    /// Azure IaaS VM workload-specific extended job info class.
    /// </summary>
    public partial class AzureIaaSVMJobExtendedInfo : JobExtendedInfo
    {
        private string _dynamicErrorMessage;
        
        /// <summary>
        /// Optional. Field to hold error message added by owner. This message
        /// is specific to this job. Non localized.
        /// </summary>
        public string DynamicErrorMessage
        {
            get { return this._dynamicErrorMessage; }
            set { this._dynamicErrorMessage = value; }
        }
        
        private double? _progressPercentage;
        
        /// <summary>
        /// Optional. Indicates progress of the job. Null if it hasn't started
        /// or completed.
        /// </summary>
        public double? ProgressPercentage
        {
            get { return this._progressPercentage; }
            set { this._progressPercentage = value; }
        }
        
        private IDictionary<string, string> _propertyBag;
        
        /// <summary>
        /// Optional. Bag of properties which are relevant to this job.
        /// </summary>
        public IDictionary<string, string> PropertyBag
        {
            get { return this._propertyBag; }
            set { this._propertyBag = value; }
        }
        
        private IList<AzureIaaSVMJobTaskDetails> _tasksList;
        
        /// <summary>
        /// Optional. List of tasks generated by this job.
        /// </summary>
        public IList<AzureIaaSVMJobTaskDetails> TasksList
        {
            get { return this._tasksList; }
            set { this._tasksList = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureIaaSVMJobExtendedInfo class.
        /// </summary>
        public AzureIaaSVMJobExtendedInfo()
        {
            this.PropertyBag = new LazyDictionary<string, string>();
            this.TasksList = new LazyList<AzureIaaSVMJobTaskDetails>();
        }
    }
}
