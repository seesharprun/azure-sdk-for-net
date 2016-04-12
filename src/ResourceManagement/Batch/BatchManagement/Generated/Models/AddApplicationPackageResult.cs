// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Response to an ApplicationOperations.AddApplicationPackage request.
    /// </summary>
    public partial class AddApplicationPackageResult
    {
        /// <summary>
        /// Initializes a new instance of the AddApplicationPackageResult
        /// class.
        /// </summary>
        public AddApplicationPackageResult() { }

        /// <summary>
        /// Initializes a new instance of the AddApplicationPackageResult
        /// class.
        /// </summary>
        public AddApplicationPackageResult(string id = default(string), string version = default(string), string storageUrl = default(string), DateTime? storageUrlExpiry = default(DateTime?))
        {
            Id = id;
            Version = version;
            StorageUrl = storageUrl;
            StorageUrlExpiry = storageUrlExpiry;
        }

        /// <summary>
        /// The id of the application.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The version of the application.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// The URL to which the application package binary file should be
        /// uploaded.
        /// </summary>
        [JsonProperty(PropertyName = "storageUrl")]
        public string StorageUrl { get; set; }

        /// <summary>
        /// The UTC time at which the storage URL will expire.
        /// </summary>
        [JsonProperty(PropertyName = "storageUrlExpiry")]
        public DateTime? StorageUrlExpiry { get; set; }

    }
}
