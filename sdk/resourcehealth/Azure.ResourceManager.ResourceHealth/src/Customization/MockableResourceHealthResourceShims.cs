// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// Backward compatibility mockable methods for ResourceGroup AvailabilityStatus shims.

using System.ComponentModel;
using System.Threading;
using Azure.ResourceManager.ResourceHealth.Models;

namespace Azure.ResourceManager.ResourceHealth.Mocking
{
    public partial class MockableResourceHealthResourceGroupResource
    {
        /// <summary> Lists the current availability status for all the resources in the resource group. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual AsyncPageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatusesByResourceGroupAsync(string filter, string expand, CancellationToken cancellationToken = default)
        {
            AsyncPageable<AvailabilityStatusResource> inner = GetAvailabilityStatusesAsync(filter, expand, cancellationToken);
            return new MappedAsyncPageable<AvailabilityStatusResource, ResourceHealthAvailabilityStatus>(inner, r => ResourceHealthAvailabilityStatus.FromData(r.Data));
        }

        /// <summary> Lists the current availability status for all the resources in the resource group. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual Pageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatusesByResourceGroup(string filter, string expand, CancellationToken cancellationToken = default)
        {
            Pageable<AvailabilityStatusResource> inner = GetAvailabilityStatuses(filter, expand, cancellationToken);
            return new MappedPageable<AvailabilityStatusResource, ResourceHealthAvailabilityStatus>(inner, r => ResourceHealthAvailabilityStatus.FromData(r.Data));
        }
    }
}
