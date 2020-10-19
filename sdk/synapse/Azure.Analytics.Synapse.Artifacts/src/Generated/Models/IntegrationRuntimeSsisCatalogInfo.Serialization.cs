// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class IntegrationRuntimeSsisCatalogInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CatalogServerEndpoint))
            {
                writer.WritePropertyName("catalogServerEndpoint");
                writer.WriteStringValue(CatalogServerEndpoint);
            }
            if (Optional.IsDefined(CatalogAdminUserName))
            {
                writer.WritePropertyName("catalogAdminUserName");
                writer.WriteStringValue(CatalogAdminUserName);
            }
            if (Optional.IsDefined(CatalogAdminPassword))
            {
                writer.WritePropertyName("catalogAdminPassword");
                writer.WriteObjectValue(CatalogAdminPassword);
            }
            if (Optional.IsDefined(CatalogPricingTier))
            {
                writer.WritePropertyName("catalogPricingTier");
                writer.WriteStringValue(CatalogPricingTier.Value.ToString());
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static IntegrationRuntimeSsisCatalogInfo DeserializeIntegrationRuntimeSsisCatalogInfo(JsonElement element)
        {
            Optional<string> catalogServerEndpoint = default;
            Optional<string> catalogAdminUserName = default;
            Optional<SecureString> catalogAdminPassword = default;
            Optional<IntegrationRuntimeSsisCatalogPricingTier> catalogPricingTier = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("catalogServerEndpoint"))
                {
                    catalogServerEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("catalogAdminUserName"))
                {
                    catalogAdminUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("catalogAdminPassword"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    catalogAdminPassword = SecureString.DeserializeSecureString(property.Value);
                    continue;
                }
                if (property.NameEquals("catalogPricingTier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    catalogPricingTier = new IntegrationRuntimeSsisCatalogPricingTier(property.Value.GetString());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new IntegrationRuntimeSsisCatalogInfo(catalogServerEndpoint.Value, catalogAdminUserName.Value, catalogAdminPassword.Value, Optional.ToNullable(catalogPricingTier), additionalProperties);
        }
    }
}