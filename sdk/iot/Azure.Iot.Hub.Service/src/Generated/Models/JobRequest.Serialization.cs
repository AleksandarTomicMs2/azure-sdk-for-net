// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    public partial class JobRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (JobId != null)
            {
                writer.WritePropertyName("jobId");
                writer.WriteStringValue(JobId);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type.Value.ToString());
            }
            if (CloudToDeviceMethod != null)
            {
                writer.WritePropertyName("cloudToDeviceMethod");
                writer.WriteObjectValue(CloudToDeviceMethod);
            }
            if (UpdateTwin != null)
            {
                writer.WritePropertyName("updateTwin");
                writer.WriteObjectValue(UpdateTwin);
            }
            if (QueryCondition != null)
            {
                writer.WritePropertyName("queryCondition");
                writer.WriteStringValue(QueryCondition);
            }
            if (StartTime != null)
            {
                writer.WritePropertyName("startTime");
                writer.WriteStringValue(StartTime.Value, "O");
            }
            if (MaxExecutionTimeInSeconds != null)
            {
                writer.WritePropertyName("maxExecutionTimeInSeconds");
                writer.WriteNumberValue(MaxExecutionTimeInSeconds.Value);
            }
            writer.WriteEndObject();
        }
    }
}