// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Net.Http
{
    internal static partial class SystemProxyInfo
    {
        public static IWebProxy Proxy => s_proxy.Value;

        private static readonly Lazy<IWebProxy> s_proxy = new Lazy<IWebProxy>(ConstructSystemProxy);
    }
}
