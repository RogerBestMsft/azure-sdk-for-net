// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class AmlComputeProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType");
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize");
                writer.WriteStringValue(VmSize);
            }
            if (Optional.IsDefined(VmPriority))
            {
                writer.WritePropertyName("vmPriority");
                writer.WriteStringValue(VmPriority.Value.ToString());
            }
            if (Optional.IsDefined(VirtualMachineImage))
            {
                if (VirtualMachineImage != null)
                {
                    writer.WritePropertyName("virtualMachineImage");
                    writer.WriteObjectValue(VirtualMachineImage);
                }
                else
                {
                    writer.WriteNull("virtualMachineImage");
                }
            }
            if (Optional.IsDefined(IsolatedNetwork))
            {
                writer.WritePropertyName("isolatedNetwork");
                writer.WriteBooleanValue(IsolatedNetwork.Value);
            }
            if (Optional.IsDefined(ScaleSettings))
            {
                writer.WritePropertyName("scaleSettings");
                writer.WriteObjectValue(ScaleSettings);
            }
            if (Optional.IsDefined(UserAccountCredentials))
            {
                writer.WritePropertyName("userAccountCredentials");
                writer.WriteObjectValue(UserAccountCredentials);
            }
            if (Optional.IsDefined(Subnet))
            {
                if (Subnet != null)
                {
                    writer.WritePropertyName("subnet");
                    writer.WriteObjectValue(Subnet);
                }
                else
                {
                    writer.WriteNull("subnet");
                }
            }
            if (Optional.IsDefined(RemoteLoginPortPublicAccess))
            {
                writer.WritePropertyName("remoteLoginPortPublicAccess");
                writer.WriteStringValue(RemoteLoginPortPublicAccess.Value.ToString());
            }
            if (Optional.IsDefined(EnableNodePublicIP))
            {
                writer.WritePropertyName("enableNodePublicIp");
                writer.WriteBooleanValue(EnableNodePublicIP.Value);
            }
            if (Optional.IsCollectionDefined(PropertyBag))
            {
                writer.WritePropertyName("propertyBag");
                writer.WriteStartObject();
                foreach (var item in PropertyBag)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static AmlComputeProperties DeserializeAmlComputeProperties(JsonElement element)
        {
            Optional<OSType> osType = default;
            Optional<string> vmSize = default;
            Optional<VmPriority> vmPriority = default;
            Optional<VirtualMachineImage> virtualMachineImage = default;
            Optional<bool> isolatedNetwork = default;
            Optional<ScaleSettings> scaleSettings = default;
            Optional<UserAccountCredentials> userAccountCredentials = default;
            Optional<ResourceId> subnet = default;
            Optional<RemoteLoginPortPublicAccess> remoteLoginPortPublicAccess = default;
            Optional<AllocationState> allocationState = default;
            Optional<DateTimeOffset> allocationStateTransitionTime = default;
            Optional<IReadOnlyList<ErrorResponse>> errors = default;
            Optional<int> currentNodeCount = default;
            Optional<int> targetNodeCount = default;
            Optional<NodeStateCounts> nodeStateCounts = default;
            Optional<bool> enableNodePublicIP = default;
            Optional<IDictionary<string, BinaryData>> propertyBag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    osType = new OSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmSize"))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmPriority"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    vmPriority = new VmPriority(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualMachineImage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        virtualMachineImage = null;
                        continue;
                    }
                    virtualMachineImage = VirtualMachineImage.DeserializeVirtualMachineImage(property.Value);
                    continue;
                }
                if (property.NameEquals("isolatedNetwork"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isolatedNetwork = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("scaleSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scaleSettings = ScaleSettings.DeserializeScaleSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("userAccountCredentials"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    userAccountCredentials = UserAccountCredentials.DeserializeUserAccountCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("subnet"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        subnet = null;
                        continue;
                    }
                    subnet = ResourceId.DeserializeResourceId(property.Value);
                    continue;
                }
                if (property.NameEquals("remoteLoginPortPublicAccess"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    remoteLoginPortPublicAccess = new RemoteLoginPortPublicAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allocationState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    allocationState = new AllocationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allocationStateTransitionTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    allocationStateTransitionTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        errors = null;
                        continue;
                    }
                    List<ErrorResponse> array = new List<ErrorResponse>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ErrorResponse.DeserializeErrorResponse(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("currentNodeCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    currentNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("targetNodeCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nodeStateCounts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nodeStateCounts = NodeStateCounts.DeserializeNodeStateCounts(property.Value);
                    continue;
                }
                if (property.NameEquals("enableNodePublicIp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableNodePublicIP = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("propertyBag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                    }
                    propertyBag = dictionary;
                    continue;
                }
            }
            return new AmlComputeProperties(Optional.ToNullable(osType), vmSize.Value, Optional.ToNullable(vmPriority), virtualMachineImage.Value, Optional.ToNullable(isolatedNetwork), scaleSettings.Value, userAccountCredentials.Value, subnet.Value, Optional.ToNullable(remoteLoginPortPublicAccess), Optional.ToNullable(allocationState), Optional.ToNullable(allocationStateTransitionTime), Optional.ToList(errors), Optional.ToNullable(currentNodeCount), Optional.ToNullable(targetNodeCount), nodeStateCounts.Value, Optional.ToNullable(enableNodePublicIP), Optional.ToDictionary(propertyBag));
        }
    }
}
