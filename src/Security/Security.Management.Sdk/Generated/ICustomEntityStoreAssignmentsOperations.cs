// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// CustomEntityStoreAssignmentsOperations operations.
    /// </summary>
    public partial interface ICustomEntityStoreAssignmentsOperations
    {
        /// <summary>
        /// Gets a single custom entity store assignment by name for the provided subscription and resource group.
        /// </summary>
        /// <remarks>
        /// Gets a single custom entity store assignment by name for the provided subscription and resource group.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user&#39;s subscription. The name is case insensitive.
        /// </param>
        /// <param name='customEntityStoreAssignmentName'>
        /// Name of the custom entity store assignment. Generated name is GUID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<CustomEntityStoreAssignment>> GetWithHttpMessagesAsync(string resourceGroupName, string customEntityStoreAssignmentName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Creates a custom entity store assignment for the provided subscription, if not already exists.
        /// </summary>
        /// <remarks>
        /// Creates a custom entity store assignment for the provided subscription, if not already exists.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user&#39;s subscription. The name is case insensitive.
        /// </param>
        /// <param name='customEntityStoreAssignmentName'>
        /// Name of the custom entity store assignment. Generated name is GUID.
        /// </param>
        /// <param name='principal'>
        /// The principal assigned with entity store. If not provided, will use caller principal. Format of principal is: [AAD type]=[PrincipalObjectId];[TenantId]
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<CustomEntityStoreAssignment>> CreateWithHttpMessagesAsync(string resourceGroupName, string customEntityStoreAssignmentName, string principal = default(string), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete a custom entity store assignment by name for a provided subscription
        /// </summary>
        /// <remarks>
        /// Delete a custom entity store assignment by name for a provided subscription
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user&#39;s subscription. The name is case insensitive.
        /// </param>
        /// <param name='customEntityStoreAssignmentName'>
        /// Name of the custom entity store assignment. Generated name is GUID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string customEntityStoreAssignmentName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List custom entity store assignments by a provided subscription and resource group
        /// </summary>
        /// <remarks>
        /// List custom entity store assignments by a provided subscription and resource group
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user&#39;s subscription. The name is case insensitive.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<CustomEntityStoreAssignment>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List custom entity store assignments by provided subscription
        /// </summary>
        /// <remarks>
        /// List custom entity store assignments by provided subscription
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<CustomEntityStoreAssignment>>> ListBySubscriptionWithHttpMessagesAsync(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List custom entity store assignments by a provided subscription and resource group
        /// </summary>
        /// <remarks>
        /// List custom entity store assignments by a provided subscription and resource group
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<CustomEntityStoreAssignment>>> ListByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List custom entity store assignments by provided subscription
        /// </summary>
        /// <remarks>
        /// List custom entity store assignments by provided subscription
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<CustomEntityStoreAssignment>>> ListBySubscriptionNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}