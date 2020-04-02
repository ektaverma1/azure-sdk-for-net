// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the parameters of ephemeral disk settings that can be
    /// specified for operating system disk. &lt;br&gt;&lt;br&gt; NOTE: The
    /// ephemeral disk settings can only be specified for managed disk.
    /// </summary>
    public partial class DiffDiskSettings
    {
        /// <summary>
        /// Initializes a new instance of the DiffDiskSettings class.
        /// </summary>
        public DiffDiskSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiffDiskSettings class.
        /// </summary>
        /// <param name="option">Specifies the ephemeral disk settings for
        /// operating system disk. Possible values include: 'Local'</param>
        /// <param name="placement">Specifies the ephemeral disk placement for
        /// operating system disk. This property is used to specify Cache disk
        /// or Resource disk for ephemeral OS disk provisioning. By default if
        /// customer does not specify this placement property in the request,
        /// the Ephemeral OS disk will be provisioned using Cache disk.
        /// Possible values include: 'CacheDisk', 'ResourceDisk'</param>
        public DiffDiskSettings(string option = default(string), string placement = default(string))
        {
            Option = option;
            Placement = placement;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the ephemeral disk settings for operating
        /// system disk. Possible values include: 'Local'
        /// </summary>
        [JsonProperty(PropertyName = "option")]
        public string Option { get; set; }

        /// <summary>
        /// Gets or sets specifies the ephemeral disk placement for operating
        /// system disk. This property is used to specify Cache disk or
        /// Resource disk for ephemeral OS disk provisioning. By default if
        /// customer does not specify this placement property in the request,
        /// the Ephemeral OS disk will be provisioned using Cache disk.
        /// Possible values include: 'CacheDisk', 'ResourceDisk'
        /// </summary>
        [JsonProperty(PropertyName = "placement")]
        public string Placement { get; set; }

    }
}
