// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class AnomalyAlertConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(CrossMetricsOperator))
            {
                writer.WritePropertyName("crossMetricsOperator");
                writer.WriteStringValue(CrossMetricsOperator.Value.ToString());
            }
            writer.WritePropertyName("hookIds");
            writer.WriteStartArray();
            foreach (var item in IdsOfHooksToAlert)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("metricAlertingConfigurations");
            writer.WriteStartArray();
            foreach (var item in MetricAlertConfigurations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static AnomalyAlertConfiguration DeserializeAnomalyAlertConfiguration(JsonElement element)
        {
            Optional<string> anomalyAlertingConfigurationId = default;
            string name = default;
            Optional<string> description = default;
            Optional<MetricAnomalyAlertConfigurationsOperator> crossMetricsOperator = default;
            IList<string> hookIds = default;
            IList<MetricAnomalyAlertConfiguration> metricAlertingConfigurations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("anomalyAlertingConfigurationId"))
                {
                    anomalyAlertingConfigurationId = property.Value.GetString();
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
                if (property.NameEquals("crossMetricsOperator"))
                {
                    crossMetricsOperator = new MetricAnomalyAlertConfigurationsOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hookIds"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    hookIds = array;
                    continue;
                }
                if (property.NameEquals("metricAlertingConfigurations"))
                {
                    List<MetricAnomalyAlertConfiguration> array = new List<MetricAnomalyAlertConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricAnomalyAlertConfiguration.DeserializeMetricAnomalyAlertConfiguration(item));
                    }
                    metricAlertingConfigurations = array;
                    continue;
                }
            }
            return new AnomalyAlertConfiguration(anomalyAlertingConfigurationId.Value, name, description.Value, Optional.ToNullable(crossMetricsOperator), hookIds, metricAlertingConfigurations);
        }
    }
}