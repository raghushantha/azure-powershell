// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using System.Linq;

    /// <summary>
    /// Statistics related to replication for storage account&#39;s Blob, Table, Queue
    /// and File services. It is only available when geo-redundant replication is
    /// enabled for the storage account.
    /// </summary>
    public partial class GeoReplicationStats
    {
        /// <summary>
        /// Initializes a new instance of the GeoReplicationStats class.
        /// </summary>
        public GeoReplicationStats()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GeoReplicationStats class.
        /// </summary>

        /// <param name="status">The status of the secondary location. Possible values are: - Live:
        /// Indicates that the secondary location is active and operational. -
        /// Bootstrap: Indicates initial synchronization from the primary location to
        /// the secondary location is in progress.This typically occurs when
        /// replication is first enabled. - Unavailable: Indicates that the secondary
        /// location is temporarily unavailable.
        /// Possible values include: 'Live', 'Bootstrap', 'Unavailable'</param>

        /// <param name="lastSyncTime">All primary writes preceding this UTC date/time value are guaranteed to be
        /// available for read operations. Primary writes following this point in time
        /// may or may not be available for reads. Element may be default value if
        /// value of LastSyncTime is not available, this can happen if secondary is
        /// offline or we are in bootstrap.
        /// </param>

        /// <param name="canFailover">A boolean flag which indicates whether or not account failover is supported
        /// for the account.
        /// </param>

        /// <param name="canPlannedFailover">A boolean flag which indicates whether or not planned account failover is
        /// supported for the account.
        /// </param>

        /// <param name="postFailoverRedundancy">The redundancy type of the account after an account failover is performed.
        /// Possible values include: 'Standard_LRS', 'Standard_ZRS'</param>

        /// <param name="postPlannedFailoverRedundancy">The redundancy type of the account after a planned account failover is
        /// performed.
        /// Possible values include: 'Standard_GRS', 'Standard_GZRS', 'Standard_RAGRS',
        /// 'Standard_RAGZRS'</param>
        public GeoReplicationStats(string status = default(string), System.DateTime? lastSyncTime = default(System.DateTime?), bool? canFailover = default(bool?), bool? canPlannedFailover = default(bool?), string postFailoverRedundancy = default(string), string postPlannedFailoverRedundancy = default(string))

        {
            this.Status = status;
            this.LastSyncTime = lastSyncTime;
            this.CanFailover = canFailover;
            this.CanPlannedFailover = canPlannedFailover;
            this.PostFailoverRedundancy = postFailoverRedundancy;
            this.PostPlannedFailoverRedundancy = postPlannedFailoverRedundancy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the status of the secondary location. Possible values are: - Live:
        /// Indicates that the secondary location is active and operational. -
        /// Bootstrap: Indicates initial synchronization from the primary location to
        /// the secondary location is in progress.This typically occurs when
        /// replication is first enabled. - Unavailable: Indicates that the secondary
        /// location is temporarily unavailable. Possible values include: &#39;Live&#39;, &#39;Bootstrap&#39;, &#39;Unavailable&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status {get; private set; }

        /// <summary>
        /// Gets all primary writes preceding this UTC date/time value are guaranteed
        /// to be available for read operations. Primary writes following this point in
        /// time may or may not be available for reads. Element may be default value if
        /// value of LastSyncTime is not available, this can happen if secondary is
        /// offline or we are in bootstrap.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastSyncTime")]
        public System.DateTime? LastSyncTime {get; private set; }

        /// <summary>
        /// Gets a boolean flag which indicates whether or not account failover is
        /// supported for the account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "canFailover")]
        public bool? CanFailover {get; private set; }

        /// <summary>
        /// Gets a boolean flag which indicates whether or not planned account failover
        /// is supported for the account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "canPlannedFailover")]
        public bool? CanPlannedFailover {get; private set; }

        /// <summary>
        /// Gets the redundancy type of the account after an account failover is
        /// performed. Possible values include: &#39;Standard_LRS&#39;, &#39;Standard_ZRS&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "postFailoverRedundancy")]
        public string PostFailoverRedundancy {get; private set; }

        /// <summary>
        /// Gets the redundancy type of the account after a planned account failover is
        /// performed. Possible values include: &#39;Standard_GRS&#39;, &#39;Standard_GZRS&#39;, &#39;Standard_RAGRS&#39;, &#39;Standard_RAGZRS&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "postPlannedFailoverRedundancy")]
        public string PostPlannedFailoverRedundancy {get; private set; }
    }
}