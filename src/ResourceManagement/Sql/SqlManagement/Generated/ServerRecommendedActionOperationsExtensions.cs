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
using Microsoft.Azure.Management.Sql;
using Microsoft.Azure.Management.Sql.Models;

namespace Microsoft.Azure.Management.Sql
{
    /// <summary>
    /// The Windows Azure SQL Database management API provides a RESTful set of
    /// web services that interact with Windows Azure SQL Database services to
    /// manage your databases. The API enables users to create, retrieve,
    /// update, and delete databases and servers.
    /// </summary>
    public static partial class ServerRecommendedActionOperationsExtensions
    {
        /// <summary>
        /// Returns details of a recommended action.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IServerRecommendedActionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL server.
        /// </param>
        /// <param name='advisorName'>
        /// Required. The name of the Azure SQL Server advisor.
        /// </param>
        /// <param name='recommendedActionName'>
        /// Required. The name of the Azure SQL Server recommended action.
        /// </param>
        /// <returns>
        /// Represents the response to a get recommended action request.
        /// </returns>
        public static RecommendedActionGetResponse Get(this IServerRecommendedActionOperations operations, string resourceGroupName, string serverName, string advisorName, string recommendedActionName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerRecommendedActionOperations)s).GetAsync(resourceGroupName, serverName, advisorName, recommendedActionName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns details of a recommended action.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IServerRecommendedActionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL server.
        /// </param>
        /// <param name='advisorName'>
        /// Required. The name of the Azure SQL Server advisor.
        /// </param>
        /// <param name='recommendedActionName'>
        /// Required. The name of the Azure SQL Server recommended action.
        /// </param>
        /// <returns>
        /// Represents the response to a get recommended action request.
        /// </returns>
        public static Task<RecommendedActionGetResponse> GetAsync(this IServerRecommendedActionOperations operations, string resourceGroupName, string serverName, string advisorName, string recommendedActionName)
        {
            return operations.GetAsync(resourceGroupName, serverName, advisorName, recommendedActionName, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns list of recommended actions for this advisor.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IServerRecommendedActionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL server.
        /// </param>
        /// <param name='advisorName'>
        /// Required. The name of the Azure SQL Server advisor.
        /// </param>
        /// <returns>
        /// Represents the response to a list recommended actions request.
        /// </returns>
        public static RecommendedActionListResponse List(this IServerRecommendedActionOperations operations, string resourceGroupName, string serverName, string advisorName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerRecommendedActionOperations)s).ListAsync(resourceGroupName, serverName, advisorName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns list of recommended actions for this advisor.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IServerRecommendedActionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL server.
        /// </param>
        /// <param name='advisorName'>
        /// Required. The name of the Azure SQL Server advisor.
        /// </param>
        /// <returns>
        /// Represents the response to a list recommended actions request.
        /// </returns>
        public static Task<RecommendedActionListResponse> ListAsync(this IServerRecommendedActionOperations operations, string resourceGroupName, string serverName, string advisorName)
        {
            return operations.ListAsync(resourceGroupName, serverName, advisorName, CancellationToken.None);
        }
        
        /// <summary>
        /// Updates recommended action state.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IServerRecommendedActionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL server.
        /// </param>
        /// <param name='advisorName'>
        /// Required. The name of the Azure SQL Server advisor.
        /// </param>
        /// <param name='recommendedActionName'>
        /// Required. The name of the Azure SQL Server recommended action.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for updating recommended action
        /// state.
        /// </param>
        /// <returns>
        /// Represents the response to an update recommended action request.
        /// </returns>
        public static RecommendedActionUpdateResponse Update(this IServerRecommendedActionOperations operations, string resourceGroupName, string serverName, string advisorName, string recommendedActionName, RecommendedActionUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerRecommendedActionOperations)s).UpdateAsync(resourceGroupName, serverName, advisorName, recommendedActionName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Updates recommended action state.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IServerRecommendedActionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL server.
        /// </param>
        /// <param name='advisorName'>
        /// Required. The name of the Azure SQL Server advisor.
        /// </param>
        /// <param name='recommendedActionName'>
        /// Required. The name of the Azure SQL Server recommended action.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for updating recommended action
        /// state.
        /// </param>
        /// <returns>
        /// Represents the response to an update recommended action request.
        /// </returns>
        public static Task<RecommendedActionUpdateResponse> UpdateAsync(this IServerRecommendedActionOperations operations, string resourceGroupName, string serverName, string advisorName, string recommendedActionName, RecommendedActionUpdateParameters parameters)
        {
            return operations.UpdateAsync(resourceGroupName, serverName, advisorName, recommendedActionName, parameters, CancellationToken.None);
        }
    }
}
