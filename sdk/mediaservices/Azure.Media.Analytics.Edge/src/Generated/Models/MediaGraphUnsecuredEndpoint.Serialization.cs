// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.Analytics.Edge.Models
{
    public partial class MediaGraphUnsecuredEndpoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials");
                writer.WriteObjectValue(Credentials);
            }
            writer.WritePropertyName("url");
            writer.WriteStringValue(Url);
            writer.WriteEndObject();
        }

        internal static MediaGraphUnsecuredEndpoint DeserializeMediaGraphUnsecuredEndpoint(JsonElement element)
        {
            string type = default;
            Optional<MediaGraphCredentials> credentials = default;
            string url = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credentials"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    credentials = MediaGraphCredentials.DeserializeMediaGraphCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("url"))
                {
                    url = property.Value.GetString();
                    continue;
                }
            }
            return new MediaGraphUnsecuredEndpoint(type, credentials.Value, url);
        }
    }
}