// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// Backward compatibility: restore IReadOnlyList<T> return types for collection properties.

using System.Collections.Generic;
using Azure.ResourceManager.ResourceHealth.Models;
using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.ResourceManager.ResourceHealth
{
    [CodeGenSuppress("ApplicableScenarios")]
    [CodeGenSuppress("SupportedValues")]
    [CodeGenSuppress("DependsOn")]
    public partial class ResourceHealthMetadataEntityData
    {
        /// <summary> The list of scenarios applicable to this metadata entity. </summary>
        public IReadOnlyList<MetadataEntityScenario> ApplicableScenarios => Properties?.ApplicableScenarios as IReadOnlyList<MetadataEntityScenario>;

        /// <summary> The list of supported values. </summary>
        public IReadOnlyList<MetadataSupportedValueDetail> SupportedValues => Properties?.SupportedValues as IReadOnlyList<MetadataSupportedValueDetail>;

        /// <summary> The list of keys on which this entity depends on. </summary>
        public IReadOnlyList<string> DependsOn => Properties?.DependsOn as IReadOnlyList<string>;
    }
}
