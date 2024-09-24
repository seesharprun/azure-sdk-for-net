// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class VectorQuery : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(KNearestNeighborsCount))
            {
                writer.WritePropertyName("k"u8);
                writer.WriteNumberValue(KNearestNeighborsCount.Value);
            }
            if (Optional.IsDefined(FieldsRaw))
            {
                writer.WritePropertyName("fields"u8);
                writer.WriteStringValue(FieldsRaw);
            }
            if (Optional.IsDefined(Exhaustive))
            {
                writer.WritePropertyName("exhaustive"u8);
                writer.WriteBooleanValue(Exhaustive.Value);
            }
            if (Optional.IsDefined(Oversampling))
            {
                writer.WritePropertyName("oversampling"u8);
                writer.WriteNumberValue(Oversampling.Value);
            }
            if (Optional.IsDefined(Weight))
            {
                writer.WritePropertyName("weight"u8);
                writer.WriteNumberValue(Weight.Value);
            }
            if (Optional.IsDefined(Threshold))
            {
                writer.WritePropertyName("threshold"u8);
                writer.WriteObjectValue(Threshold);
            }
            if (Optional.IsDefined(FilterOverride))
            {
                writer.WritePropertyName("filterOverride"u8);
                writer.WriteStringValue(FilterOverride);
            }
            writer.WriteEndObject();
        }

        internal static VectorQuery DeserializeVectorQuery(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "imageBinary": return VectorizableImageBinaryQuery.DeserializeVectorizableImageBinaryQuery(element);
                    case "imageUrl": return VectorizableImageUrlQuery.DeserializeVectorizableImageUrlQuery(element);
                    case "text": return VectorizableTextQuery.DeserializeVectorizableTextQuery(element);
                    case "vector": return VectorizedQuery.DeserializeVectorizedQuery(element);
                }
            }
            return UnknownVectorQuery.DeserializeUnknownVectorQuery(element);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static VectorQuery FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeVectorQuery(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
