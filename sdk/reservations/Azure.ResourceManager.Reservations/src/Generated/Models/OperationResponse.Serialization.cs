// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class OperationResponse
    {
        internal static OperationResponse DeserializeOperationResponse(JsonElement element)
        {
            Optional<string> name = default;
            Optional<bool> isDataAction = default;
            Optional<OperationDisplay> display = default;
            Optional<string> origin = default;
            Optional<BinaryData> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDataAction"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isDataAction = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("display"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    display = OperationDisplay.DeserializeOperationDisplay(property.Value);
                    continue;
                }
                if (property.NameEquals("origin"))
                {
                    origin = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    properties = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new OperationResponse(name.Value, Optional.ToNullable(isDataAction), display.Value, origin.Value, properties.Value);
        }
    }
}
