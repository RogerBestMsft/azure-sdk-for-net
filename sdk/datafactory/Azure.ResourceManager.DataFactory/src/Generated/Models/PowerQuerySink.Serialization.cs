// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class PowerQuerySink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Script))
            {
                writer.WritePropertyName("script");
                writer.WriteStringValue(Script);
            }
            if (Optional.IsDefined(SchemaLinkedService))
            {
                writer.WritePropertyName("schemaLinkedService");
                writer.WriteObjectValue(SchemaLinkedService);
            }
            if (Optional.IsDefined(RejectedDataLinkedService))
            {
                writer.WritePropertyName("rejectedDataLinkedService");
                writer.WriteObjectValue(RejectedDataLinkedService);
            }
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Dataset))
            {
                writer.WritePropertyName("dataset");
                writer.WriteObjectValue(Dataset);
            }
            if (Optional.IsDefined(LinkedService))
            {
                writer.WritePropertyName("linkedService");
                writer.WriteObjectValue(LinkedService);
            }
            if (Optional.IsDefined(Flowlet))
            {
                writer.WritePropertyName("flowlet");
                writer.WriteObjectValue(Flowlet);
            }
            writer.WriteEndObject();
        }

        internal static PowerQuerySink DeserializePowerQuerySink(JsonElement element)
        {
            Optional<string> script = default;
            Optional<LinkedServiceReference> schemaLinkedService = default;
            Optional<LinkedServiceReference> rejectedDataLinkedService = default;
            string name = default;
            Optional<string> description = default;
            Optional<DatasetReference> dataset = default;
            Optional<LinkedServiceReference> linkedService = default;
            Optional<DataFlowReference> flowlet = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("script"))
                {
                    script = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaLinkedService"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schemaLinkedService = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("rejectedDataLinkedService"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rejectedDataLinkedService = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataset"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dataset = DatasetReference.DeserializeDatasetReference(property.Value);
                    continue;
                }
                if (property.NameEquals("linkedService"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    linkedService = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("flowlet"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    flowlet = DataFlowReference.DeserializeDataFlowReference(property.Value);
                    continue;
                }
            }
            return new PowerQuerySink(name, description.Value, dataset.Value, linkedService.Value, flowlet.Value, schemaLinkedService.Value, rejectedDataLinkedService.Value, script.Value);
        }
    }
}
