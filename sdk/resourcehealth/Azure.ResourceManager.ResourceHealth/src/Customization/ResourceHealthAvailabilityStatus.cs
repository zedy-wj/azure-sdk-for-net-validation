// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// Backward compatibility shim: preserves the old ResourceHealthAvailabilityStatus type from GA 1.0.0.
// The new generated SDK uses AvailabilityStatusData instead.

using System;
using System.ClientModel.Primitives;
using System.ComponentModel;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> availabilityStatus of a resource. </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class ResourceHealthAvailabilityStatus : ResourceData, IJsonModel<ResourceHealthAvailabilityStatus>, IPersistableModel<ResourceHealthAvailabilityStatus>
    {
        private readonly AzureLocation? _location;
        private readonly ResourceHealthAvailabilityStatusProperties _properties;

        /// <summary> Initializes a new instance of ResourceHealthAvailabilityStatus. </summary>
        internal ResourceHealthAvailabilityStatus()
        {
        }

        internal ResourceHealthAvailabilityStatus(AvailabilityStatusData data)
        {
            if (data == null)
                return;

            _location = string.IsNullOrEmpty(data.Location) ? (AzureLocation?)null : new AzureLocation(data.Location);
            _properties = data.Properties;
        }

        /// <summary> Azure Resource Manager geo location of the resource. </summary>
        public AzureLocation? Location => _location;

        /// <summary> Properties of availability state. </summary>
        public ResourceHealthAvailabilityStatusProperties Properties => _properties;

        internal static ResourceHealthAvailabilityStatus FromData(AvailabilityStatusData data)
        {
            if (data == null)
                return null;
            return new ResourceHealthAvailabilityStatus(data);
        }

        ResourceHealthAvailabilityStatus IJsonModel<ResourceHealthAvailabilityStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            using var document = JsonDocument.ParseValue(ref reader);
            var data = AvailabilityStatusData.DeserializeAvailabilityStatusData(document.RootElement, options);
            return FromData(data);
        }

        void IJsonModel<ResourceHealthAvailabilityStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        ResourceHealthAvailabilityStatus IPersistableModel<ResourceHealthAvailabilityStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            using var document = JsonDocument.Parse(data);
            var statusData = AvailabilityStatusData.DeserializeAvailabilityStatusData(document.RootElement, options);
            return FromData(statusData);
        }

        string IPersistableModel<ResourceHealthAvailabilityStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        BinaryData IPersistableModel<ResourceHealthAvailabilityStatus>.Write(ModelReaderWriterOptions options)
        {
            return BinaryData.FromString("{}");
        }
    }
}
