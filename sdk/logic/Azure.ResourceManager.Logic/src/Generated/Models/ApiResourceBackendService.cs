// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The API backend service. </summary>
    internal partial class ApiResourceBackendService
    {
        /// <summary> Initializes a new instance of ApiResourceBackendService. </summary>
        internal ApiResourceBackendService()
        {
        }

        /// <summary> Initializes a new instance of ApiResourceBackendService. </summary>
        /// <param name="serviceUri"> The service URL. </param>
        internal ApiResourceBackendService(Uri serviceUri)
        {
            ServiceUri = serviceUri;
        }

        /// <summary> The service URL. </summary>
        public Uri ServiceUri { get; }
    }
}
