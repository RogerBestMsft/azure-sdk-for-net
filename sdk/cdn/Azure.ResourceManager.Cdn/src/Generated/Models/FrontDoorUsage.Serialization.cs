// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class FrontDoorUsage
    {
        internal static FrontDoorUsage DeserializeFrontDoorUsage(JsonElement element)
        {
            Optional<ResourceIdentifier> id = default;
            FrontDoorUsageUnit unit = default;
            long currentValue = default;
            long limit = default;
            FrontDoorUsageResourceName name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    unit = new FrontDoorUsageUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("currentValue"))
                {
                    currentValue = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("limit"))
                {
                    limit = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = FrontDoorUsageResourceName.DeserializeFrontDoorUsageResourceName(property.Value);
                    continue;
                }
            }
            return new FrontDoorUsage(id.Value, unit, currentValue, limit, name);
        }
    }
}
