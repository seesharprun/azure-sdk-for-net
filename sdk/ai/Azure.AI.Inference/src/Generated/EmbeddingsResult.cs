// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Inference
{
    /// <summary>
    /// Representation of the response data from an embeddings request.
    /// Embeddings measure the relatedness of text strings and are commonly used for search, clustering,
    /// recommendations, and other similar scenarios.
    /// </summary>
    public partial class EmbeddingsResult
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EmbeddingsResult"/>. </summary>
        /// <param name="id"> Unique identifier for the embeddings result. </param>
        /// <param name="data"> Embedding values for the prompts submitted in the request. </param>
        /// <param name="usage"> Usage counts for tokens input using the embeddings API. </param>
        /// <param name="model"> The model ID used to generate this result. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="data"/>, <paramref name="usage"/> or <paramref name="model"/> is null. </exception>
        internal EmbeddingsResult(string id, IEnumerable<EmbeddingItem> data, EmbeddingsUsage usage, string model)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(data, nameof(data));
            Argument.AssertNotNull(usage, nameof(usage));
            Argument.AssertNotNull(model, nameof(model));

            Id = id;
            Data = data.ToList();
            Usage = usage;
            Model = model;
        }

        /// <summary> Initializes a new instance of <see cref="EmbeddingsResult"/>. </summary>
        /// <param name="id"> Unique identifier for the embeddings result. </param>
        /// <param name="data"> Embedding values for the prompts submitted in the request. </param>
        /// <param name="usage"> Usage counts for tokens input using the embeddings API. </param>
        /// <param name="model"> The model ID used to generate this result. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EmbeddingsResult(string id, IReadOnlyList<EmbeddingItem> data, EmbeddingsUsage usage, string model, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Data = data;
            Usage = usage;
            Model = model;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EmbeddingsResult"/> for deserialization. </summary>
        internal EmbeddingsResult()
        {
        }

        /// <summary> Unique identifier for the embeddings result. </summary>
        public string Id { get; }
        /// <summary> Embedding values for the prompts submitted in the request. </summary>
        public IReadOnlyList<EmbeddingItem> Data { get; }
        /// <summary> Usage counts for tokens input using the embeddings API. </summary>
        public EmbeddingsUsage Usage { get; }
        /// <summary> The model ID used to generate this result. </summary>
        public string Model { get; }
    }
}
