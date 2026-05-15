// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// Backward compatibility: restore IReadOnlyList<T> return types for collection properties.

using System.Collections.Generic;
using Azure.ResourceManager.ResourceHealth.Models;
using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.ResourceManager.ResourceHealth
{
    [CodeGenSuppress("StatusActiveEvents")]
    [CodeGenSuppress("StatusBanners")]
    public partial class ServiceEmergingIssueData
    {
        /// <summary> The list of emerging issues of active event type. </summary>
        public IReadOnlyList<EmergingIssueActiveEventType> StatusActiveEvents => EmergingIssueProperties?.StatusActiveEvents as IReadOnlyList<EmergingIssueActiveEventType>;

        /// <summary> The list of emerging issues of banner type. </summary>
        public IReadOnlyList<EmergingIssueBannerType> StatusBanners => EmergingIssueProperties?.StatusBanners as IReadOnlyList<EmergingIssueBannerType>;
    }
}
