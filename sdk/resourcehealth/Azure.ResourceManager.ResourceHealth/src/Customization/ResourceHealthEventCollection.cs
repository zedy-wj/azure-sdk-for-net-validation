// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.ResourceManager.ResourceHealth
{
    // Rename generated EventCollection → ResourceHealthEventCollection to match GA SDK.
    [CodeGenType("EventCollection")]
    public partial class ResourceHealthEventCollection
    {
    }
}
