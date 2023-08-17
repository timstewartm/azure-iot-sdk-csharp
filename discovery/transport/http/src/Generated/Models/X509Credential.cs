// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Devices.Discovery.Client.Transport.Http.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// X.509 Credential Type.
    /// </summary>
    [Newtonsoft.Json.JsonObject("X509")]
    public partial class X509Credential : Credential
    {
        /// <summary>
        /// Initializes a new instance of the X509Credential class.
        /// </summary>
        public X509Credential()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the X509Credential class.
        /// </summary>
        /// <param name="x509">X.509 certificate value.</param>
        public X509Credential(string x509)
        {
            X509 = x509;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets X.509 certificate value.
        /// </summary>
        [JsonProperty(PropertyName = "x509")]
        public string X509 { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (X509 == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "X509");
            }
        }
    }
}