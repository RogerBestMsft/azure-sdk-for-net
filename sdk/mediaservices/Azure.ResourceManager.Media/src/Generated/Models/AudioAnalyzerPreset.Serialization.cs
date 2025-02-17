// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class AudioAnalyzerPreset : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AudioLanguage))
            {
                writer.WritePropertyName("audioLanguage");
                writer.WriteStringValue(AudioLanguage);
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode");
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ExperimentalOptions))
            {
                writer.WritePropertyName("experimentalOptions");
                writer.WriteStartObject();
                foreach (var item in ExperimentalOptions)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WriteEndObject();
        }

        internal static AudioAnalyzerPreset DeserializeAudioAnalyzerPreset(JsonElement element)
        {
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.VideoAnalyzerPreset": return VideoAnalyzerPreset.DeserializeVideoAnalyzerPreset(element);
                }
            }
            Optional<string> audioLanguage = default;
            Optional<AudioAnalysisMode> mode = default;
            Optional<IDictionary<string, string>> experimentalOptions = default;
            string odataType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("audioLanguage"))
                {
                    audioLanguage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mode = new AudioAnalysisMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("experimentalOptions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    experimentalOptions = dictionary;
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
            }
            return new AudioAnalyzerPreset(odataType, audioLanguage.Value, Optional.ToNullable(mode), Optional.ToDictionary(experimentalOptions));
        }
    }
}
