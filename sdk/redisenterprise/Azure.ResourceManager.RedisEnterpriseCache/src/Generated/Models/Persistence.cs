// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RedisEnterpriseCache.Models
{
    /// <summary> Persistence-related configuration for the RedisEnterprise database. </summary>
    public partial class Persistence
    {
        /// <summary> Initializes a new instance of Persistence. </summary>
        public Persistence()
        {
        }

        /// <summary> Initializes a new instance of Persistence. </summary>
        /// <param name="aofEnabled"> Sets whether AOF is enabled. </param>
        /// <param name="rdbEnabled"> Sets whether RDB is enabled. </param>
        /// <param name="aofFrequency"> Sets the frequency at which data is written to disk. </param>
        /// <param name="rdbFrequency"> Sets the frequency at which a snapshot of the database is created. </param>
        internal Persistence(bool? aofEnabled, bool? rdbEnabled, AofFrequency? aofFrequency, RdbFrequency? rdbFrequency)
        {
            AofEnabled = aofEnabled;
            RdbEnabled = rdbEnabled;
            AofFrequency = aofFrequency;
            RdbFrequency = rdbFrequency;
        }

        /// <summary> Sets whether AOF is enabled. </summary>
        public bool? AofEnabled { get; set; }
        /// <summary> Sets whether RDB is enabled. </summary>
        public bool? RdbEnabled { get; set; }
        /// <summary> Sets the frequency at which data is written to disk. </summary>
        public AofFrequency? AofFrequency { get; set; }
        /// <summary> Sets the frequency at which a snapshot of the database is created. </summary>
        public RdbFrequency? RdbFrequency { get; set; }
    }
}
