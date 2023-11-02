// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Devices.Discovery.Client.Transport.Http.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for IssueChallenge operation.
    /// </summary>
    public partial class DiscoveryRegistrationsIssueChallengeHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DiscoveryRegistrationsIssueChallengeHeaders class.
        /// </summary>
        public DiscoveryRegistrationsIssueChallengeHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DiscoveryRegistrationsIssueChallengeHeaders class.
        /// </summary>
        /// <param name="xMsErrorCode">String error code indicating what went
        /// wrong.</param>
        public DiscoveryRegistrationsIssueChallengeHeaders(string xMsErrorCode = default(string))
        {
            XMsErrorCode = xMsErrorCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets string error code indicating what went wrong.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-error-code")]
        public string XMsErrorCode { get; set; }

    }
}
