// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Media
{
    /// <summary>
    /// A class representing a collection of <see cref="LiveOutputResource" /> and their operations.
    /// Each <see cref="LiveOutputResource" /> in the collection will belong to the same instance of <see cref="LiveEventResource" />.
    /// To get a <see cref="LiveOutputCollection" /> instance call the GetLiveOutputs method from an instance of <see cref="LiveEventResource" />.
    /// </summary>
    public partial class LiveOutputCollection : ArmCollection, IEnumerable<LiveOutputResource>, IAsyncEnumerable<LiveOutputResource>
    {
        private readonly ClientDiagnostics _liveOutputClientDiagnostics;
        private readonly LiveOutputsRestOperations _liveOutputRestClient;

        /// <summary> Initializes a new instance of the <see cref="LiveOutputCollection"/> class for mocking. </summary>
        protected LiveOutputCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LiveOutputCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LiveOutputCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _liveOutputClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Media", LiveOutputResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LiveOutputResource.ResourceType, out string liveOutputApiVersion);
            _liveOutputRestClient = new LiveOutputsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, liveOutputApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LiveEventResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LiveEventResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new live output.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents/{liveEventName}/liveOutputs/{liveOutputName}
        /// Operation Id: LiveOutputs_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="liveOutputName"> The name of the live output. </param>
        /// <param name="data"> Live Output properties needed for creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="liveOutputName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="liveOutputName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LiveOutputResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string liveOutputName, LiveOutputData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(liveOutputName, nameof(liveOutputName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _liveOutputClientDiagnostics.CreateScope("LiveOutputCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _liveOutputRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, liveOutputName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MediaArmOperation<LiveOutputResource>(new LiveOutputOperationSource(Client), _liveOutputClientDiagnostics, Pipeline, _liveOutputRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, liveOutputName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a new live output.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents/{liveEventName}/liveOutputs/{liveOutputName}
        /// Operation Id: LiveOutputs_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="liveOutputName"> The name of the live output. </param>
        /// <param name="data"> Live Output properties needed for creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="liveOutputName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="liveOutputName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LiveOutputResource> CreateOrUpdate(WaitUntil waitUntil, string liveOutputName, LiveOutputData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(liveOutputName, nameof(liveOutputName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _liveOutputClientDiagnostics.CreateScope("LiveOutputCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _liveOutputRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, liveOutputName, data, cancellationToken);
                var operation = new MediaArmOperation<LiveOutputResource>(new LiveOutputOperationSource(Client), _liveOutputClientDiagnostics, Pipeline, _liveOutputRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, liveOutputName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a live output.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents/{liveEventName}/liveOutputs/{liveOutputName}
        /// Operation Id: LiveOutputs_Get
        /// </summary>
        /// <param name="liveOutputName"> The name of the live output. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="liveOutputName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="liveOutputName"/> is null. </exception>
        public virtual async Task<Response<LiveOutputResource>> GetAsync(string liveOutputName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(liveOutputName, nameof(liveOutputName));

            using var scope = _liveOutputClientDiagnostics.CreateScope("LiveOutputCollection.Get");
            scope.Start();
            try
            {
                var response = await _liveOutputRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, liveOutputName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LiveOutputResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a live output.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents/{liveEventName}/liveOutputs/{liveOutputName}
        /// Operation Id: LiveOutputs_Get
        /// </summary>
        /// <param name="liveOutputName"> The name of the live output. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="liveOutputName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="liveOutputName"/> is null. </exception>
        public virtual Response<LiveOutputResource> Get(string liveOutputName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(liveOutputName, nameof(liveOutputName));

            using var scope = _liveOutputClientDiagnostics.CreateScope("LiveOutputCollection.Get");
            scope.Start();
            try
            {
                var response = _liveOutputRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, liveOutputName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LiveOutputResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the live outputs of a live event.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents/{liveEventName}/liveOutputs
        /// Operation Id: LiveOutputs_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LiveOutputResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LiveOutputResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<LiveOutputResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _liveOutputClientDiagnostics.CreateScope("LiveOutputCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _liveOutputRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LiveOutputResource(Client, value)), response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<LiveOutputResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _liveOutputClientDiagnostics.CreateScope("LiveOutputCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _liveOutputRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LiveOutputResource(Client, value)), response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists the live outputs of a live event.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents/{liveEventName}/liveOutputs
        /// Operation Id: LiveOutputs_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LiveOutputResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LiveOutputResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<LiveOutputResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _liveOutputClientDiagnostics.CreateScope("LiveOutputCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _liveOutputRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LiveOutputResource(Client, value)), response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<LiveOutputResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _liveOutputClientDiagnostics.CreateScope("LiveOutputCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _liveOutputRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LiveOutputResource(Client, value)), response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents/{liveEventName}/liveOutputs/{liveOutputName}
        /// Operation Id: LiveOutputs_Get
        /// </summary>
        /// <param name="liveOutputName"> The name of the live output. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="liveOutputName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="liveOutputName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string liveOutputName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(liveOutputName, nameof(liveOutputName));

            using var scope = _liveOutputClientDiagnostics.CreateScope("LiveOutputCollection.Exists");
            scope.Start();
            try
            {
                var response = await _liveOutputRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, liveOutputName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents/{liveEventName}/liveOutputs/{liveOutputName}
        /// Operation Id: LiveOutputs_Get
        /// </summary>
        /// <param name="liveOutputName"> The name of the live output. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="liveOutputName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="liveOutputName"/> is null. </exception>
        public virtual Response<bool> Exists(string liveOutputName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(liveOutputName, nameof(liveOutputName));

            using var scope = _liveOutputClientDiagnostics.CreateScope("LiveOutputCollection.Exists");
            scope.Start();
            try
            {
                var response = _liveOutputRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, liveOutputName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LiveOutputResource> IEnumerable<LiveOutputResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LiveOutputResource> IAsyncEnumerable<LiveOutputResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
