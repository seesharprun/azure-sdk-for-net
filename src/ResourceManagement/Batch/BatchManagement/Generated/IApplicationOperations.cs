// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// ApplicationOperations operations.
    /// </summary>
    public partial interface IApplicationOperations
    {
        /// <summary>
        /// Activates the specified application package.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='id'>
        /// The id of the application.
        /// </param>
        /// <param name='version'>
        /// The version of the application to activate.
        /// </param>
        /// <param name='parameters'>
        /// The parameters for the request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> ActivateApplicationPackageWithHttpMessagesAsync(string resourceGroupName, string accountName, string id, string version, ActivateApplicationPackageParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Adds an application to the specified Batch account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='applicationId'>
        /// The id of the application.
        /// </param>
        /// <param name='parameters'>
        /// The parameters for the request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> AddApplicationWithHttpMessagesAsync(string resourceGroupName, string accountName, string applicationId, AddApplicationParameters parameters = default(AddApplicationParameters), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='applicationId'>
        /// The id of the application.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> DeleteApplicationWithHttpMessagesAsync(string resourceGroupName, string accountName, string applicationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets information about the specified application.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='applicationId'>
        /// The id of the application.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Application>> GetApplicationWithHttpMessagesAsync(string resourceGroupName, string accountName, string applicationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates settings for the specified application.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='applicationId'>
        /// The id of the application.
        /// </param>
        /// <param name='parameters'>
        /// The parameters for the request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> UpdateApplicationWithHttpMessagesAsync(string resourceGroupName, string accountName, string applicationId, UpdateApplicationParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates an application package record.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='applicationId'>
        /// The id of the application.
        /// </param>
        /// <param name='version'>
        /// The version of the application.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<AddApplicationPackageResult>> AddApplicationPackageWithHttpMessagesAsync(string resourceGroupName, string accountName, string applicationId, string version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an application package record and the binary file.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='applicationId'>
        /// The id of the application.
        /// </param>
        /// <param name='version'>
        /// The version of the application to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> DeleteApplicationPackageWithHttpMessagesAsync(string resourceGroupName, string accountName, string applicationId, string version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets information about the specified application package.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='applicationId'>
        /// The id of the application.
        /// </param>
        /// <param name='version'>
        /// The version of the application.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<GetApplicationPackageResult>> GetApplicationPackageWithHttpMessagesAsync(string resourceGroupName, string accountName, string applicationId, string version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all of the applications in the specified account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='maxresults'>
        /// The maximum number of items to return in the response.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ListApplicationsResult>> ListWithHttpMessagesAsync(string resourceGroupName, string accountName, int? maxresults = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
