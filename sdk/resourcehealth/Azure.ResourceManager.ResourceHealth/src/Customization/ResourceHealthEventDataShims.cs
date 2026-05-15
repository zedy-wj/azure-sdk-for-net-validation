// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// Backward compatibility: restore IReadOnlyList<T> return types for collection properties.

using System.Collections.Generic;
using Azure.ResourceManager.ResourceHealth.Models;
using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.ResourceManager.ResourceHealth
{
    [CodeGenSuppress("Faqs")]
    [CodeGenSuppress("Impact")]
    [CodeGenSuppress("Links")]
    public partial class ResourceHealthEventData
    {
        /// <summary> Frequently asked questions for the service health event. </summary>
        public IReadOnlyList<ResourceHealthEventFaq> Faqs => Properties?.Faqs as IReadOnlyList<ResourceHealthEventFaq>;

        /// <summary> List services impacted by the service health event. </summary>
        public IReadOnlyList<ResourceHealthEventImpact> Impact => Properties?.Impact as IReadOnlyList<ResourceHealthEventImpact>;

        /// <summary> Useful links of event. </summary>
        public IReadOnlyList<ResourceHealthEventLink> Links => Properties?.Links as IReadOnlyList<ResourceHealthEventLink>;
    }
}
