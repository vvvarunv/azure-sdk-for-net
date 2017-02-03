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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    public static partial class DscConfigurationOperationsExtensions
    {
        /// <summary>
        /// Create the configuration identified by configuration name.  (see
        /// http://aka.ms/azureautomationsdk/configurationoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IDscConfigurationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The create or update parameters for configuration.
        /// </param>
        /// <returns>
        /// The response model for the configuration create response.
        /// </returns>
        public static DscConfigurationCreateOrUpdateResponse CreateOrUpdate(this IDscConfigurationOperations operations, string resourceGroupName, string automationAccount, DscConfigurationCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDscConfigurationOperations)s).CreateOrUpdateAsync(resourceGroupName, automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create the configuration identified by configuration name.  (see
        /// http://aka.ms/azureautomationsdk/configurationoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IDscConfigurationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The create or update parameters for configuration.
        /// </param>
        /// <returns>
        /// The response model for the configuration create response.
        /// </returns>
        public static Task<DscConfigurationCreateOrUpdateResponse> CreateOrUpdateAsync(this IDscConfigurationOperations operations, string resourceGroupName, string automationAccount, DscConfigurationCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete the dsc configuration identified by configuration name.
        /// (see http://aka.ms/azureautomationsdk/configurationoperations for
        /// more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IDscConfigurationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='configurationName'>
        /// Required. The configuration name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IDscConfigurationOperations operations, string resourceGroupName, string automationAccount, string configurationName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDscConfigurationOperations)s).DeleteAsync(resourceGroupName, automationAccount, configurationName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete the dsc configuration identified by configuration name.
        /// (see http://aka.ms/azureautomationsdk/configurationoperations for
        /// more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IDscConfigurationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='configurationName'>
        /// Required. The configuration name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IDscConfigurationOperations operations, string resourceGroupName, string automationAccount, string configurationName)
        {
            return operations.DeleteAsync(resourceGroupName, automationAccount, configurationName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the configuration identified by configuration name.  (see
        /// http://aka.ms/azureautomationsdk/configurationoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IDscConfigurationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='configurationName'>
        /// Required. The configuration name.
        /// </param>
        /// <returns>
        /// The response model for the get configuration operation.
        /// </returns>
        public static DscConfigurationGetResponse Get(this IDscConfigurationOperations operations, string resourceGroupName, string automationAccount, string configurationName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDscConfigurationOperations)s).GetAsync(resourceGroupName, automationAccount, configurationName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the configuration identified by configuration name.  (see
        /// http://aka.ms/azureautomationsdk/configurationoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IDscConfigurationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='configurationName'>
        /// Required. The configuration name.
        /// </param>
        /// <returns>
        /// The response model for the get configuration operation.
        /// </returns>
        public static Task<DscConfigurationGetResponse> GetAsync(this IDscConfigurationOperations operations, string resourceGroupName, string automationAccount, string configurationName)
        {
            return operations.GetAsync(resourceGroupName, automationAccount, configurationName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the configuration script identified by configuration name.
        /// (see http://aka.ms/azureautomationsdk/configurationoperations for
        /// more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IDscConfigurationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='configurationName'>
        /// Required. The configuration name.
        /// </param>
        /// <returns>
        /// The response model for the get configuration operation.
        /// </returns>
        public static DscConfigurationGetContentResponse GetContent(this IDscConfigurationOperations operations, string resourceGroupName, string automationAccount, string configurationName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDscConfigurationOperations)s).GetContentAsync(resourceGroupName, automationAccount, configurationName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the configuration script identified by configuration name.
        /// (see http://aka.ms/azureautomationsdk/configurationoperations for
        /// more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IDscConfigurationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='configurationName'>
        /// Required. The configuration name.
        /// </param>
        /// <returns>
        /// The response model for the get configuration operation.
        /// </returns>
        public static Task<DscConfigurationGetContentResponse> GetContentAsync(this IDscConfigurationOperations operations, string resourceGroupName, string automationAccount, string configurationName)
        {
            return operations.GetContentAsync(resourceGroupName, automationAccount, configurationName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve a list of configurations.  (see
        /// http://aka.ms/azureautomationsdk/configurationoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IDscConfigurationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list configuration operation.
        /// </returns>
        public static DscConfigurationListResponse List(this IDscConfigurationOperations operations, string resourceGroupName, string automationAccount)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDscConfigurationOperations)s).ListAsync(resourceGroupName, automationAccount);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a list of configurations.  (see
        /// http://aka.ms/azureautomationsdk/configurationoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IDscConfigurationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list configuration operation.
        /// </returns>
        public static Task<DscConfigurationListResponse> ListAsync(this IDscConfigurationOperations operations, string resourceGroupName, string automationAccount)
        {
            return operations.ListAsync(resourceGroupName, automationAccount, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve next list of configurations.  (see
        /// http://aka.ms/azureautomationsdk/configurationoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IDscConfigurationOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list configuration operation.
        /// </returns>
        public static DscConfigurationListResponse ListNext(this IDscConfigurationOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDscConfigurationOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve next list of configurations.  (see
        /// http://aka.ms/azureautomationsdk/configurationoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IDscConfigurationOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list configuration operation.
        /// </returns>
        public static Task<DscConfigurationListResponse> ListNextAsync(this IDscConfigurationOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
    }
}
