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
    /// Parameters for an ApplicationOperations.ActivateApplicationPackage
    /// request.
    /// </summary>
    public partial class ActivateApplicationPackageParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ActivateApplicationPackageParameters class.
        /// </summary>
        public ActivateApplicationPackageParameters() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ActivateApplicationPackageParameters class.
        /// </summary>
        public ActivateApplicationPackageParameters(string format)
        {
            Format = format;
        }

        /// <summary>
        /// The format of the application package binary file.
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public string Format { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Format == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Format");
            }
        }
    }
}
