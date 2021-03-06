// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for IntegrationServiceEnvironmentNetworkHealthOperations.
    /// </summary>
    public static partial class IntegrationServiceEnvironmentNetworkHealthOperationsExtensions
    {
            /// <summary>
            /// Gets the integration service environment network health.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The resource group.
            /// </param>
            /// <param name='integrationServiceEnvironmentName'>
            /// The integration service environment name.
            /// </param>
            public static IDictionary<string, IntegrationServiceEnvironmentSubnetNetworkHealth> Get(this IIntegrationServiceEnvironmentNetworkHealthOperations operations, string resourceGroup, string integrationServiceEnvironmentName)
            {
                return operations.GetAsync(resourceGroup, integrationServiceEnvironmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the integration service environment network health.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The resource group.
            /// </param>
            /// <param name='integrationServiceEnvironmentName'>
            /// The integration service environment name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IDictionary<string, IntegrationServiceEnvironmentSubnetNetworkHealth>> GetAsync(this IIntegrationServiceEnvironmentNetworkHealthOperations operations, string resourceGroup, string integrationServiceEnvironmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroup, integrationServiceEnvironmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
