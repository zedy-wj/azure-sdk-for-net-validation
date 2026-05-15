// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// Backward compatibility: restore IReadOnlyList<T> for Info, ResourceIdentifier for TargetResourceId,
// and ResourceType? for TargetResourceType.

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ResourceHealth.Models;
using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.ResourceManager.ResourceHealth
{
    [CodeGenSuppress("Info")]
    [CodeGenSuppress("TargetResourceId")]
    [CodeGenSuppress("TargetResourceType")]
    public partial class ResourceHealthEventImpactedResourceData
    {
        /// <summary> Additional information. </summary>
        public IReadOnlyList<ResourceHealthKeyValueItem> Info => Properties?.Info as IReadOnlyList<ResourceHealthKeyValueItem>;

        /// <summary> Identity for resource within Microsoft cloud. </summary>
        public ResourceIdentifier TargetResourceId => Properties is null ? default : (Properties.TargetResourceId is null ? default : new ResourceIdentifier(Properties.TargetResourceId));

        /// <summary> Resource type within Microsoft cloud. </summary>
        public ResourceType? TargetResourceType => Properties is null ? default : (Properties.TargetResourceType is null ? default : new ResourceType(Properties.TargetResourceType));
    }
}
