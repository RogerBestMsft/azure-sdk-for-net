// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The Elastic Pool performance level capability. </summary>
    public partial class ElasticPoolPerformanceLevelCapability
    {
        /// <summary> Initializes a new instance of ElasticPoolPerformanceLevelCapability. </summary>
        internal ElasticPoolPerformanceLevelCapability()
        {
            SupportedLicenseTypes = new ChangeTrackingList<LicenseTypeCapability>();
            SupportedMaxSizes = new ChangeTrackingList<MaxSizeRangeCapability>();
            SupportedPerDatabaseMaxSizes = new ChangeTrackingList<MaxSizeRangeCapability>();
            SupportedPerDatabaseMaxPerformanceLevels = new ChangeTrackingList<ElasticPoolPerDatabaseMaxPerformanceLevelCapability>();
            SupportedMaintenanceConfigurations = new ChangeTrackingList<MaintenanceConfigurationCapability>();
        }

        /// <summary> Initializes a new instance of ElasticPoolPerformanceLevelCapability. </summary>
        /// <param name="performanceLevel"> The performance level for the pool. </param>
        /// <param name="sku"> The sku. </param>
        /// <param name="supportedLicenseTypes"> List of supported license types. </param>
        /// <param name="maxDatabaseCount"> The maximum number of databases supported. </param>
        /// <param name="includedMaxSize"> The included (free) max size for this performance level. </param>
        /// <param name="supportedMaxSizes"> The list of supported max sizes. </param>
        /// <param name="supportedPerDatabaseMaxSizes"> The list of supported per database max sizes. </param>
        /// <param name="supportedPerDatabaseMaxPerformanceLevels"> The list of supported per database max performance levels. </param>
        /// <param name="isZoneRedundant"> Whether or not zone redundancy is supported for the performance level. </param>
        /// <param name="supportedMaintenanceConfigurations"> List of supported maintenance configurations. </param>
        /// <param name="status"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        internal ElasticPoolPerformanceLevelCapability(PerformanceLevelCapability performanceLevel, SqlSku sku, IReadOnlyList<LicenseTypeCapability> supportedLicenseTypes, int? maxDatabaseCount, MaxSizeCapability includedMaxSize, IReadOnlyList<MaxSizeRangeCapability> supportedMaxSizes, IReadOnlyList<MaxSizeRangeCapability> supportedPerDatabaseMaxSizes, IReadOnlyList<ElasticPoolPerDatabaseMaxPerformanceLevelCapability> supportedPerDatabaseMaxPerformanceLevels, bool? isZoneRedundant, IReadOnlyList<MaintenanceConfigurationCapability> supportedMaintenanceConfigurations, CapabilityStatus? status, string reason)
        {
            PerformanceLevel = performanceLevel;
            Sku = sku;
            SupportedLicenseTypes = supportedLicenseTypes;
            MaxDatabaseCount = maxDatabaseCount;
            IncludedMaxSize = includedMaxSize;
            SupportedMaxSizes = supportedMaxSizes;
            SupportedPerDatabaseMaxSizes = supportedPerDatabaseMaxSizes;
            SupportedPerDatabaseMaxPerformanceLevels = supportedPerDatabaseMaxPerformanceLevels;
            IsZoneRedundant = isZoneRedundant;
            SupportedMaintenanceConfigurations = supportedMaintenanceConfigurations;
            Status = status;
            Reason = reason;
        }

        /// <summary> The performance level for the pool. </summary>
        public PerformanceLevelCapability PerformanceLevel { get; }
        /// <summary> The sku. </summary>
        public SqlSku Sku { get; }
        /// <summary> List of supported license types. </summary>
        public IReadOnlyList<LicenseTypeCapability> SupportedLicenseTypes { get; }
        /// <summary> The maximum number of databases supported. </summary>
        public int? MaxDatabaseCount { get; }
        /// <summary> The included (free) max size for this performance level. </summary>
        public MaxSizeCapability IncludedMaxSize { get; }
        /// <summary> The list of supported max sizes. </summary>
        public IReadOnlyList<MaxSizeRangeCapability> SupportedMaxSizes { get; }
        /// <summary> The list of supported per database max sizes. </summary>
        public IReadOnlyList<MaxSizeRangeCapability> SupportedPerDatabaseMaxSizes { get; }
        /// <summary> The list of supported per database max performance levels. </summary>
        public IReadOnlyList<ElasticPoolPerDatabaseMaxPerformanceLevelCapability> SupportedPerDatabaseMaxPerformanceLevels { get; }
        /// <summary> Whether or not zone redundancy is supported for the performance level. </summary>
        public bool? IsZoneRedundant { get; }
        /// <summary> List of supported maintenance configurations. </summary>
        public IReadOnlyList<MaintenanceConfigurationCapability> SupportedMaintenanceConfigurations { get; }
        /// <summary> The status of the capability. </summary>
        public CapabilityStatus? Status { get; }
        /// <summary> The reason for the capability not being available. </summary>
        public string Reason { get; }
    }
}
