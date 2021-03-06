// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Static sites user roles invitation link resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StaticSiteUserInvitationResponseResource : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// StaticSiteUserInvitationResponseResource class.
        /// </summary>
        public StaticSiteUserInvitationResponseResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// StaticSiteUserInvitationResponseResource class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="expiresOn">The expiration time of the
        /// invitation</param>
        /// <param name="invitationUrl">The url for the invitation link</param>
        public StaticSiteUserInvitationResponseResource(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), System.DateTime? expiresOn = default(System.DateTime?), string invitationUrl = default(string))
            : base(id, name, kind, type)
        {
            ExpiresOn = expiresOn;
            InvitationUrl = invitationUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the expiration time of the invitation
        /// </summary>
        [JsonProperty(PropertyName = "properties.expiresOn")]
        public System.DateTime? ExpiresOn { get; private set; }

        /// <summary>
        /// Gets the url for the invitation link
        /// </summary>
        [JsonProperty(PropertyName = "properties.invitationUrl")]
        public string InvitationUrl { get; private set; }

    }
}
