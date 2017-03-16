// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Azure;
    using Management;
    using Compute;
    using Fluent;
    using Rest;
    using Rest.Azure;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Create or update availability set parameters.
    /// </summary>
    [JsonTransformation]
    public partial class AvailabilitySetInner : Microsoft.Azure.Management.Resource.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the AvailabilitySetInner class.
        /// </summary>
        public AvailabilitySetInner() { }

        /// <summary>
        /// Initializes a new instance of the AvailabilitySetInner class.
        /// </summary>
        /// <param name="platformUpdateDomainCount">Update Domain
        /// count.</param>
        /// <param name="platformFaultDomainCount">Fault Domain count.</param>
        /// <param name="virtualMachines">A list of references to all virtual
        /// machines in the availability set.</param>
        /// <param name="statuses">The resource status information.</param>
        /// <param name="managed">If the availability set supports managed
        /// disks.</param>
        /// <param name="sku">Sku of the availability set</param>
        public AvailabilitySetInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), int? platformUpdateDomainCount = default(int?), int? platformFaultDomainCount = default(int?), IList<Microsoft.Azure.Management.Resource.Fluent.SubResource> virtualMachines = default(IList<Microsoft.Azure.Management.Resource.Fluent.SubResource>), IList<InstanceViewStatus> statuses = default(IList<InstanceViewStatus>), bool? managed = default(bool?), Sku sku = default(Sku))
            : base(location, id, name, type, tags)
        {
            PlatformUpdateDomainCount = platformUpdateDomainCount;
            PlatformFaultDomainCount = platformFaultDomainCount;
            VirtualMachines = virtualMachines;
            Statuses = statuses;
            Managed = managed;
            Sku = sku;
        }

        /// <summary>
        /// Gets or sets update Domain count.
        /// </summary>
        [JsonProperty(PropertyName = "properties.platformUpdateDomainCount")]
        public int? PlatformUpdateDomainCount { get; set; }

        /// <summary>
        /// Gets or sets fault Domain count.
        /// </summary>
        [JsonProperty(PropertyName = "properties.platformFaultDomainCount")]
        public int? PlatformFaultDomainCount { get; set; }

        /// <summary>
        /// Gets or sets a list of references to all virtual machines in the
        /// availability set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualMachines")]
        public IList<Microsoft.Azure.Management.Resource.Fluent.SubResource> VirtualMachines { get; set; }

        /// <summary>
        /// Gets the resource status information.
        /// </summary>
        [JsonProperty(PropertyName = "properties.statuses")]
        public IList<InstanceViewStatus> Statuses { get; protected set; }

        /// <summary>
        /// Gets or sets if the availability set supports managed disks.
        /// </summary>
        [JsonProperty(PropertyName = "properties.managed")]
        public bool? Managed { get; set; }

        /// <summary>
        /// Gets or sets sku of the availability set
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

    }
}
