// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Devices.Discovery.Client.Transport.Http.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The error object.
    /// </summary>
    public partial class AzureCoreFoundationsError
    {
        /// <summary>
        /// Initializes a new instance of the AzureCoreFoundationsError class.
        /// </summary>
        public AzureCoreFoundationsError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureCoreFoundationsError class.
        /// </summary>
        /// <param name="code">One of a server-defined set of error
        /// codes.</param>
        /// <param name="message">A human-readable representation of the
        /// error.</param>
        /// <param name="target">The target of the error.</param>
        /// <param name="details">An array of details about specific errors
        /// that led to this reported error.</param>
        /// <param name="innererror">An object containing more specific
        /// information than the current object about the error.</param>
        public AzureCoreFoundationsError(string code, string message, string target = default(string), IList<AzureCoreFoundationsError> details = default(IList<AzureCoreFoundationsError>), AzureCoreFoundationsInnerError innererror = default(AzureCoreFoundationsInnerError))
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            Innererror = innererror;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets one of a server-defined set of error codes.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets a human-readable representation of the error.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the target of the error.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets an array of details about specific errors that led to
        /// this reported error.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<AzureCoreFoundationsError> Details { get; set; }

        /// <summary>
        /// Gets or sets an object containing more specific information than
        /// the current object about the error.
        /// </summary>
        [JsonProperty(PropertyName = "innererror")]
        public AzureCoreFoundationsInnerError Innererror { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Code == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Code");
            }
            if (Message == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Message");
            }
            if (Details != null)
            {
                foreach (var element in Details)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
