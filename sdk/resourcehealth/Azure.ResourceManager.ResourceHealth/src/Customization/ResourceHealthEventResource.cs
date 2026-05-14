// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.ResourceManager.ResourceHealth
{
    // Rename generated EventResource → ResourceHealthEventResource to match GA SDK.
    [CodeGenType("EventResource")]
    public partial class ResourceHealthEventResource
    {
    }
}
