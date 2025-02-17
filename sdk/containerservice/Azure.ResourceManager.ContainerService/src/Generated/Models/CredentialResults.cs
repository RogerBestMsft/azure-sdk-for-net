// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The list credential result response. </summary>
    public partial class CredentialResults
    {
        /// <summary> Initializes a new instance of CredentialResults. </summary>
        internal CredentialResults()
        {
            Kubeconfigs = new ChangeTrackingList<CredentialResult>();
        }

        /// <summary> Initializes a new instance of CredentialResults. </summary>
        /// <param name="kubeconfigs"> Base64-encoded Kubernetes configuration file. </param>
        internal CredentialResults(IReadOnlyList<CredentialResult> kubeconfigs)
        {
            Kubeconfigs = kubeconfigs;
        }

        /// <summary> Base64-encoded Kubernetes configuration file. </summary>
        public IReadOnlyList<CredentialResult> Kubeconfigs { get; }
    }
}
