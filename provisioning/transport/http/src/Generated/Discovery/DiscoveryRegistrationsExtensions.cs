// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Devices.Discovery.Client.Transport.Http
{
    using Microsoft.Rest;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DiscoveryRegistrations.
    /// </summary>
    public static partial class DiscoveryRegistrationsExtensions
    {
        /// <summary>
        /// Get Onboarding Information.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='apiVersion'>
        /// The API version to use for this operation.
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name="token">
        /// Authentication token
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<BootstrapResponse> GetOnboardingInfoAsync(this IDiscoveryRegistrations operations, string apiVersion, BootstrapRequest body, string token, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetOnboardingInfoWithHttpMessagesAsync(apiVersion, body, new TokenCredentials(token), null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Issue TPM Challenge. Will return an encrypted nonce, that can be used to
            /// sign a SAS Token for the GetOnboardingInfo request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Challenge> IssueChallengeAsync(this IDiscoveryRegistrations operations, string apiVersion, ChallengeRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.IssueChallengeWithHttpMessagesAsync(apiVersion, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
