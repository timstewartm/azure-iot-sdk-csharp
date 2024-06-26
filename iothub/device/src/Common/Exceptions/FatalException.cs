// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Microsoft.Azure.Devices.Client.Exceptions
{
    [Serializable]
    [SuppressMessage(FxCop.Category.Design, "CA1064:ExceptionsShouldBePublic", Justification = "CSDMain Bug 43142")]
    internal class FatalException : Exception
    {
        public FatalException()
        {
        }

        public FatalException(string message)
            : base(message)
        {
        }

        public FatalException(string message, Exception innerException)
            : base(message, innerException)
        {
            // This can't throw something like ArgumentException because that would be worse than
            // throwing the fatal exception that was requested.
            Fx.Assert(innerException == null || !Fx.IsFatal(innerException), "FatalException can't be used to wrap fatal exceptions.");
        }

#if NET8_0_OR_GREATER
    [Obsolete(DiagnosticId = "SYSLIB0051")]
#endif
        protected FatalException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
