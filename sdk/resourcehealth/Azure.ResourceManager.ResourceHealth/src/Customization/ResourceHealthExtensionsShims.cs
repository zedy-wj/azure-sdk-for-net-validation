// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// Backward compatibility shims: map old GA extension method names to new generated names.

using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.ResourceHealth.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ResourceHealth
{
    public static partial class ResourceHealthExtensions
    {
        /// <summary> Gets the collection of ResourceHealthEvents for the subscription. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource"/> instance the method will execute against. </param>
        /// <returns> An object representing collection of ResourceHealthEvents and their operations. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static ResourceHealthEventCollection GetResourceHealthEvents(this SubscriptionResource subscriptionResource)
        {
            return GetMockableResourceHealthSubscriptionResource(subscriptionResource).GetResourceHealthEvents();
        }

        /// <summary> Gets a specific service health event in the subscription. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource"/> instance the method will execute against. </param>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ForwardsClientCalls]
        public static async Task<Response<ResourceHealthEventResource>> GetResourceHealthEventAsync(this SubscriptionResource subscriptionResource, string eventTrackingId, string filter = default, string queryStartTime = default, CancellationToken cancellationToken = default)
        {
            return await GetMockableResourceHealthSubscriptionResource(subscriptionResource).GetResourceHealthEventAsync(eventTrackingId, filter, queryStartTime, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets a specific service health event in the subscription. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource"/> instance the method will execute against. </param>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ForwardsClientCalls]
        public static Response<ResourceHealthEventResource> GetResourceHealthEvent(this SubscriptionResource subscriptionResource, string eventTrackingId, string filter = default, string queryStartTime = default, CancellationToken cancellationToken = default)
        {
            return GetMockableResourceHealthSubscriptionResource(subscriptionResource).GetResourceHealthEvent(eventTrackingId, filter, queryStartTime, cancellationToken);
        }
    }
}
