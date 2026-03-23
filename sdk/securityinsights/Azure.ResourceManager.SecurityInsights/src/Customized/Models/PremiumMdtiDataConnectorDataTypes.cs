// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    internal partial class PremiumMdtiDataConnectorDataTypes
    {
        /// <summary>
        /// Convenience constructor to wrap the inner state directly.
        /// Works around AutoRest code gen bug with nested DataType wrappers.
        /// </summary>
        internal PremiumMdtiDataConnectorDataTypes(SecurityInsightsDataTypeConnectionState state)
            : this(new PremiumMdtiDataConnectorDataTypesConnector(state))
        {
        }
    }
}
