// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.ResourceManager.ResourceHealth
{
    // Rename generated ImpactedResourceCollection → ResourceHealthEventImpactedResourceCollection to match GA SDK.
    [CodeGenType("ImpactedResourceCollection")]
    public partial class ResourceHealthEventImpactedResourceCollection
    {
    }
}
