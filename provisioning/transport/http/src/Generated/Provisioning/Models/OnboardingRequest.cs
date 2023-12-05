// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Devices.Provisioning.Client.Transport.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The onboarding request.
    /// </summary>
    public partial class OnboardingRequest
    {
        /// <summary>
        /// Initializes a new instance of the OnboardingRequest class.
        /// </summary>
        public OnboardingRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OnboardingRequest class.
        /// </summary>
        /// <param name="registrationId">Unique identifier for the device.
        /// Allow lowercase alphanumeric and '-', '.', '_', ':' only. Last
        /// character can only be lowercase alphanumeric or '-'.</param>
        /// <param name="resourceMetadata">Additional resource
        /// metadata.</param>
        public OnboardingRequest(string registrationId, ResourceMetadata resourceMetadata)
        {
            RegistrationId = registrationId;
            ResourceMetadata = resourceMetadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier for the device. Allow lowercase
        /// alphanumeric and '-', '.', '_', ':' only. Last character can only
        /// be lowercase alphanumeric or '-'.
        /// </summary>
        [JsonProperty(PropertyName = "registrationId")]
        public string RegistrationId { get; set; }

        /// <summary>
        /// Gets or sets additional resource metadata.
        /// </summary>
        [JsonProperty(PropertyName = "resourceMetadata")]
        public ResourceMetadata ResourceMetadata { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RegistrationId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RegistrationId");
            }
            if (ResourceMetadata == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceMetadata");
            }
            if (RegistrationId != null)
            {
                if (RegistrationId.Length > 128)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "RegistrationId", 128);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(RegistrationId, "^([a-z0-9-._:]{0,127}[a-z0-9-])$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "RegistrationId", "^([a-z0-9-._:]{0,127}[a-z0-9-])$");
                }
            }
        }
    }
}
