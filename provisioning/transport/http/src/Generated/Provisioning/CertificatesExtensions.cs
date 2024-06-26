// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Devices.Provisioning.Client.Transport
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Certificates.
    /// </summary>
    public static partial class CertificatesExtensions
    {
            /// <summary>
            /// Issue an operational X.509 certificate for the device.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='clientRequestId'>
            /// An opaque, globally-unique, client-generated string identifier for the
            /// request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateResponse> IssueCertAsync(this ICertificates operations, string apiVersion, CertificateRequest body, System.Guid? clientRequestId = default(System.Guid?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.IssueCertWithHttpMessagesAsync(apiVersion, body, clientRequestId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
