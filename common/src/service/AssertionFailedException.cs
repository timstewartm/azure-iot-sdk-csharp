// Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license. See LICENSE file in the project root
// for full license information.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Microsoft.Azure.Devices.Common
{
    [SuppressMessage(FxCop.Category.Design, FxCop.Rule.ExceptionsShouldBePublic, Justification = "This exception should not be seen by end users.", Scope = "Type", Target = "Microsoft.Azure.Devices.Common.AssertionFailedException")]
    [Serializable]
    internal class AssertionFailedException : Exception
    {
        /// <summary>
        /// Empty constructor for serialization
        /// </summary>
        public AssertionFailedException()
        {
        }

        public AssertionFailedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public AssertionFailedException(string description)
            : base(CommonResources.GetString(CommonResources.ShipAssertExceptionMessage, description))
        {
        }
    }
}
