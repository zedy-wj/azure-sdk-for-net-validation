// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// Backward compatibility: rename generated collection class to match GA SDK name.

using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.ResourceManager.ResourceHealth
{
    /// <summary> A class representing a collection of TenantResourceHealthEventImpactedResource resources and their operations. </summary>
    [CodeGenType("TenantEventImpactedResourceCollection")]
    public partial class TenantResourceHealthEventImpactedResourceCollection
    {
    }
}
