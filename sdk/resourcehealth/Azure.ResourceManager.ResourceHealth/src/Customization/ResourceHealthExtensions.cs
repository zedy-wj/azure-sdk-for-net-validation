// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager;
using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.ResourceManager.ResourceHealth
{
    // Suppress duplicate accessor methods generated for multi-scope resources (generator bug).
    [CodeGenSuppress("GetResourceHealthEventImpactedResource", typeof(ArmClient), typeof(ResourceIdentifier))]
    [CodeGenSuppress("GetResourceHealthEventResource", typeof(ArmClient), typeof(ResourceIdentifier))]
    public static partial class ResourceHealthExtensions
    {
    }
}
