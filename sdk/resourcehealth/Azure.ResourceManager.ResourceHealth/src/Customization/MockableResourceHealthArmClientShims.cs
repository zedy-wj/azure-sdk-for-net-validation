// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// Backward compatibility mockable methods for ResourceHealthAvailabilityStatus extension shims.

using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.ResourceHealth.Models;

namespace Azure.ResourceManager.ResourceHealth.Mocking
{
    public partial class MockableResourceHealthArmClient
    {
        /// <summary> Lists availability statuses for a resource. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual AsyncPageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatusesAsync(ResourceIdentifier scope, string filter, string expand, CancellationToken cancellationToken = default)
        {
            AsyncPageable<AvailabilityStatusData> inner = GetAllAsync(scope, filter, expand, cancellationToken);
            return new MappedAsyncPageable<AvailabilityStatusData, ResourceHealthAvailabilityStatus>(inner, ResourceHealthAvailabilityStatus.FromData);
        }

        /// <summary> Lists availability statuses for a resource. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual Pageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatuses(ResourceIdentifier scope, string filter, string expand, CancellationToken cancellationToken = default)
        {
            Pageable<AvailabilityStatusData> inner = GetAll(scope, filter, expand, cancellationToken);
            return new MappedPageable<AvailabilityStatusData, ResourceHealthAvailabilityStatus>(inner, ResourceHealthAvailabilityStatus.FromData);
        }

        /// <summary> Lists child resource availability statuses. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual AsyncPageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatusOfChildResourcesAsync(ResourceIdentifier scope, string filter, string expand, CancellationToken cancellationToken = default)
        {
            AsyncPageable<AvailabilityStatusData> inner = GetAllAsync(scope, filter, expand, cancellationToken);
            return new MappedAsyncPageable<AvailabilityStatusData, ResourceHealthAvailabilityStatus>(inner, ResourceHealthAvailabilityStatus.FromData);
        }

        /// <summary> Lists child resource availability statuses. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual Pageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatusOfChildResources(ResourceIdentifier scope, string filter, string expand, CancellationToken cancellationToken = default)
        {
            Pageable<AvailabilityStatusData> inner = GetAll(scope, filter, expand, cancellationToken);
            return new MappedPageable<AvailabilityStatusData, ResourceHealthAvailabilityStatus>(inner, ResourceHealthAvailabilityStatus.FromData);
        }

        /// <summary> Lists historical availability statuses of child resources. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual AsyncPageable<ResourceHealthAvailabilityStatus> GetHistoricalAvailabilityStatusesOfChildResourceAsync(ResourceIdentifier scope, string filter, string expand, CancellationToken cancellationToken = default)
        {
            AsyncPageable<AvailabilityStatusData> inner = GetAllAsync(scope, filter, expand, cancellationToken);
            return new MappedAsyncPageable<AvailabilityStatusData, ResourceHealthAvailabilityStatus>(inner, ResourceHealthAvailabilityStatus.FromData);
        }

        /// <summary> Lists historical availability statuses of child resources. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual Pageable<ResourceHealthAvailabilityStatus> GetHistoricalAvailabilityStatusesOfChildResource(ResourceIdentifier scope, string filter, string expand, CancellationToken cancellationToken = default)
        {
            Pageable<AvailabilityStatusData> inner = GetAll(scope, filter, expand, cancellationToken);
            return new MappedPageable<AvailabilityStatusData, ResourceHealthAvailabilityStatus>(inner, ResourceHealthAvailabilityStatus.FromData);
        }

        /// <summary> Gets current availability status for a single resource. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual async Task<Response<ResourceHealthAvailabilityStatus>> GetAvailabilityStatusAsync(ResourceIdentifier scope, string filter, string expand, CancellationToken cancellationToken = default)
        {
            var resource = GetAvailabilityStatus(scope);
            Response<AvailabilityStatusResource> response = await resource.GetAsync(filter, expand, cancellationToken).ConfigureAwait(false);
            return Response.FromValue(ResourceHealthAvailabilityStatus.FromData(response.Value.Data), response.GetRawResponse());
        }

        /// <summary> Gets current availability status for a single resource. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual Response<ResourceHealthAvailabilityStatus> GetAvailabilityStatus(ResourceIdentifier scope, string filter, string expand, CancellationToken cancellationToken = default)
        {
            var resource = GetAvailabilityStatus(scope);
            Response<AvailabilityStatusResource> response = resource.Get(filter, expand, cancellationToken);
            return Response.FromValue(ResourceHealthAvailabilityStatus.FromData(response.Value.Data), response.GetRawResponse());
        }

        /// <summary> Gets current availability status for a single child resource. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual async Task<Response<ResourceHealthAvailabilityStatus>> GetAvailabilityStatusOfChildResourceAsync(ResourceIdentifier scope, string filter, string expand, CancellationToken cancellationToken = default)
        {
            var resource = GetChildAvailabilityStatus(scope);
            Response<ChildAvailabilityStatusResource> response = await resource.GetAsync(filter, expand, cancellationToken).ConfigureAwait(false);
            return Response.FromValue(ResourceHealthAvailabilityStatus.FromData(response.Value.Data), response.GetRawResponse());
        }

        /// <summary> Gets current availability status for a single child resource. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual Response<ResourceHealthAvailabilityStatus> GetAvailabilityStatusOfChildResource(ResourceIdentifier scope, string filter, string expand, CancellationToken cancellationToken = default)
        {
            var resource = GetChildAvailabilityStatus(scope);
            Response<ChildAvailabilityStatusResource> response = resource.Get(filter, expand, cancellationToken);
            return Response.FromValue(ResourceHealthAvailabilityStatus.FromData(response.Value.Data), response.GetRawResponse());
        }

        /// <summary> Lists health events for a single resource. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual AsyncPageable<ResourceHealthEventData> GetHealthEventsOfSingleResourceAsync(ResourceIdentifier scope, string filter, CancellationToken cancellationToken = default)
        {
            return new HealthEventsBySingleResourceAsyncPageable(Client, scope, filter, cancellationToken);
        }

        /// <summary> Lists health events for a single resource. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual Pageable<ResourceHealthEventData> GetHealthEventsOfSingleResource(ResourceIdentifier scope, string filter, CancellationToken cancellationToken = default)
        {
            return new HealthEventsBySingleResourcePageable(Client, scope, filter, cancellationToken);
        }
    }
}
