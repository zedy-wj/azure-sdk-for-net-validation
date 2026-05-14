// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using Azure.Core;
using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.ResourceManager.ResourceHealth.Mocking
{
    // Suppress duplicate accessor methods generated for multi-scope resources (generator bug).
    // Both subscription-scope and tenant-scope operations on the same Event/EventImpactedResource
    // models cause duplicate GetEventResource/GetImpactedResource methods.
    [CodeGenSuppress("GetResourceHealthEventImpactedResource", typeof(ResourceIdentifier))]
    [CodeGenSuppress("GetResourceHealthEventResource", typeof(ResourceIdentifier))]
    public partial class MockableResourceHealthArmClient
    {
    }
}
