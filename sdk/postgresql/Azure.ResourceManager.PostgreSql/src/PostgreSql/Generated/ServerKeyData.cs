// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PostgreSql.Models;

namespace Azure.ResourceManager.PostgreSql
{
    /// <summary> A class representing the ServerKey data model. </summary>
    public partial class ServerKeyData : ResourceData
    {
        /// <summary> Initializes a new instance of ServerKeyData. </summary>
        public ServerKeyData()
        {
        }

        /// <summary> Initializes a new instance of ServerKeyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of encryption protector used to protect the key. </param>
        /// <param name="serverKeyType"> The key type like &apos;AzureKeyVault&apos;. </param>
        /// <param name="uri"> The URI of the key. </param>
        /// <param name="creationOn"> The key creation date. </param>
        internal ServerKeyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, ServerKeyType? serverKeyType, Uri uri, DateTimeOffset? creationOn) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            ServerKeyType = serverKeyType;
            Uri = uri;
            CreationOn = creationOn;
        }

        /// <summary> Kind of encryption protector used to protect the key. </summary>
        public string Kind { get; }
        /// <summary> The key type like &apos;AzureKeyVault&apos;. </summary>
        public ServerKeyType? ServerKeyType { get; set; }
        /// <summary> The URI of the key. </summary>
        public Uri Uri { get; set; }
        /// <summary> The key creation date. </summary>
        public DateTimeOffset? CreationOn { get; }
    }
}
