// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Devices.Provisioning.Client.Transport
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Certificates operations.
    /// </summary>
    public partial interface ICertificates
    {
        /// <summary>
        /// Issue an operational X.509 certificate for the device.
        /// </summary>
        /// <param name='apiVersion'>
        /// The API version to use for this operation.
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='clientRequestId'>
        /// An opaque, globally-unique, client-generated string identifier for
        /// the request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AzureCoreFoundationsErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<CertificateResponse,CertificatesIssueCertHeaders>> IssueCertWithHttpMessagesAsync(string apiVersion, CertificateRequest body, System.Guid? clientRequestId = default(System.Guid?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
