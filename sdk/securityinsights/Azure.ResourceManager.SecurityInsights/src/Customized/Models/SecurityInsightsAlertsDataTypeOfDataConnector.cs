// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    //Add it due to api compat check of public/internal ctor in 2024-01-01-preview version
    public partial class SecurityInsightsAlertsDataTypeOfDataConnector
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsAlertsDataTypeOfDataConnector"/> for deserialization. </summary>
        public SecurityInsightsAlertsDataTypeOfDataConnector()
        {
        }

        /// <summary>
        /// Convenience constructor to wrap the inner state directly.
        /// Works around AutoRest code gen bug with nested DataType wrappers.
        /// </summary>
        internal SecurityInsightsAlertsDataTypeOfDataConnector(SecurityInsightsDataTypeConnectionState state)
            : this(new DataConnectorDataTypeCommon(state))
        {
        }
    }
}
