// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Represents the mode the indexer is executing in. </summary>
    public readonly partial struct IndexingMode : IEquatable<IndexingMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IndexingMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IndexingMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllDocumentsValue = "indexingAllDocs";
        private const string ResetDocumentsValue = "indexingResetDocs";
        /// <summary> Determines if two <see cref="IndexingMode"/> values are the same. </summary>
        public static bool operator ==(IndexingMode left, IndexingMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IndexingMode"/> values are not the same. </summary>
        public static bool operator !=(IndexingMode left, IndexingMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IndexingMode"/>. </summary>
        public static implicit operator IndexingMode(string value) => new IndexingMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IndexingMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IndexingMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
