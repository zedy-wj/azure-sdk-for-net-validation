// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// Backward compatibility shims: AvailabilityStatus extension methods from GA 1.0.0.
// These delegate through the mockable classes for proper mocking support.

using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.ResourceHealth.Mocking;
using Azure.ResourceManager.ResourceHealth.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ResourceHealth
{
    public static partial class ResourceHealthExtensions
    {
        /// <summary> Lists the historical availability statuses for a single resource. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static AsyncPageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatusesAsync(this ArmClient client, ResourceIdentifier scope, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));
            return GetMockableResourceHealthArmClient(client).GetAvailabilityStatusesAsync(scope, filter, expand, cancellationToken);
        }

        /// <summary> Lists the historical availability statuses for a single resource. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Pageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatuses(this ArmClient client, ResourceIdentifier scope, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));
            return GetMockableResourceHealthArmClient(client).GetAvailabilityStatuses(scope, filter, expand, cancellationToken);
        }

        /// <summary> Lists the current availability status for all the resources in the resource group. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static AsyncPageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatusesByResourceGroupAsync(this ResourceGroupResource resourceGroupResource, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));
            return GetMockableResourceHealthResourceGroupResource(resourceGroupResource).GetAvailabilityStatusesByResourceGroupAsync(filter, expand, cancellationToken);
        }

        /// <summary> Lists the current availability status for all the resources in the resource group. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Pageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatusesByResourceGroup(this ResourceGroupResource resourceGroupResource, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));
            return GetMockableResourceHealthResourceGroupResource(resourceGroupResource).GetAvailabilityStatusesByResourceGroup(filter, expand, cancellationToken);
        }

        /// <summary> Lists the current availability status for all the resources in the subscription. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static AsyncPageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatusesBySubscriptionAsync(this SubscriptionResource subscriptionResource, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));
            return GetMockableResourceHealthSubscriptionResource(subscriptionResource).GetAvailabilityStatusesBySubscriptionAsync(filter, expand, cancellationToken);
        }

        /// <summary> Lists the current availability status for all the resources in the subscription. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Pageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatusesBySubscription(this SubscriptionResource subscriptionResource, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));
            return GetMockableResourceHealthSubscriptionResource(subscriptionResource).GetAvailabilityStatusesBySubscription(filter, expand, cancellationToken);
        }

        /// <summary> Lists the child resources' availability statuses. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static AsyncPageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatusOfChildResourcesAsync(this ArmClient client, ResourceIdentifier scope, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));
            return GetMockableResourceHealthArmClient(client).GetAvailabilityStatusOfChildResourcesAsync(scope, filter, expand, cancellationToken);
        }

        /// <summary> Lists the child resources' availability statuses. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Pageable<ResourceHealthAvailabilityStatus> GetAvailabilityStatusOfChildResources(this ArmClient client, ResourceIdentifier scope, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));
            return GetMockableResourceHealthArmClient(client).GetAvailabilityStatusOfChildResources(scope, filter, expand, cancellationToken);
        }

        /// <summary> Lists the historical availability statuses of child resources. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static AsyncPageable<ResourceHealthAvailabilityStatus> GetHistoricalAvailabilityStatusesOfChildResourceAsync(this ArmClient client, ResourceIdentifier scope, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));
            return GetMockableResourceHealthArmClient(client).GetHistoricalAvailabilityStatusesOfChildResourceAsync(scope, filter, expand, cancellationToken);
        }

        /// <summary> Lists the historical availability statuses of child resources. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Pageable<ResourceHealthAvailabilityStatus> GetHistoricalAvailabilityStatusesOfChildResource(this ArmClient client, ResourceIdentifier scope, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));
            return GetMockableResourceHealthArmClient(client).GetHistoricalAvailabilityStatusesOfChildResource(scope, filter, expand, cancellationToken);
        }

        /// <summary> Gets current availability status for a single resource. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ForwardsClientCalls]
        public static async Task<Response<ResourceHealthAvailabilityStatus>> GetAvailabilityStatusAsync(this ArmClient client, ResourceIdentifier scope, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));
            return await GetMockableResourceHealthArmClient(client).GetAvailabilityStatusAsync(scope, filter, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets current availability status for a single resource. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ForwardsClientCalls]
        public static Response<ResourceHealthAvailabilityStatus> GetAvailabilityStatus(this ArmClient client, ResourceIdentifier scope, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));
            return GetMockableResourceHealthArmClient(client).GetAvailabilityStatus(scope, filter, expand, cancellationToken);
        }

        /// <summary> Gets current availability status for a single child resource. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ForwardsClientCalls]
        public static async Task<Response<ResourceHealthAvailabilityStatus>> GetAvailabilityStatusOfChildResourceAsync(this ArmClient client, ResourceIdentifier scope, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));
            return await GetMockableResourceHealthArmClient(client).GetAvailabilityStatusOfChildResourceAsync(scope, filter, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets current availability status for a single child resource. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ForwardsClientCalls]
        public static Response<ResourceHealthAvailabilityStatus> GetAvailabilityStatusOfChildResource(this ArmClient client, ResourceIdentifier scope, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));
            return GetMockableResourceHealthArmClient(client).GetAvailabilityStatusOfChildResource(scope, filter, expand, cancellationToken);
        }

        /// <summary> Lists health events for a single resource. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static AsyncPageable<ResourceHealthEventData> GetHealthEventsOfSingleResourceAsync(this ArmClient client, ResourceIdentifier scope, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));
            return GetMockableResourceHealthArmClient(client).GetHealthEventsOfSingleResourceAsync(scope, filter, cancellationToken);
        }

        /// <summary> Lists health events for a single resource. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Pageable<ResourceHealthEventData> GetHealthEventsOfSingleResource(this ArmClient client, ResourceIdentifier scope, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));
            return GetMockableResourceHealthArmClient(client).GetHealthEventsOfSingleResource(scope, filter, cancellationToken);
        }
    }
}
