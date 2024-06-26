// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Devices.Provisioning.Client.Transport.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An object containing more specific information about the error. As per
    /// Microsoft One API guidelines -
    /// https://github.com/Microsoft/api-guidelines/blob/vNext/Guidelines.md#7102-error-condition-responses.
    /// </summary>
    public partial class AzureCoreFoundationsInnerError
    {
        /// <summary>
        /// Initializes a new instance of the AzureCoreFoundationsInnerError
        /// class.
        /// </summary>
        public AzureCoreFoundationsInnerError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureCoreFoundationsInnerError
        /// class.
        /// </summary>
        /// <param name="code">One of a server-defined set of error
        /// codes.</param>
        /// <param name="innererror">Inner error.</param>
        public AzureCoreFoundationsInnerError(string code = default(string), AzureCoreFoundationsInnerError innererror = default(AzureCoreFoundationsInnerError))
        {
            Code = code;
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
        /// Gets or sets inner error.
        /// </summary>
        [JsonProperty(PropertyName = "innererror")]
        public AzureCoreFoundationsInnerError Innererror { get; set; }

    }
}
