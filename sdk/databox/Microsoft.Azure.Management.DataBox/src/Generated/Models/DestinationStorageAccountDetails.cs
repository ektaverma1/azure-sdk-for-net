// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details for the destination storage account.
    /// </summary>
    [Newtonsoft.Json.JsonObject("StorageAccount")]
    public partial class DestinationStorageAccountDetails : DestinationAccountDetails
    {
        /// <summary>
        /// Initializes a new instance of the DestinationStorageAccountDetails
        /// class.
        /// </summary>
        public DestinationStorageAccountDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DestinationStorageAccountDetails
        /// class.
        /// </summary>
        /// <param name="storageAccountId">Destination Storage Account Arm
        /// Id.</param>
        /// <param name="accountId">Arm Id of the destination where the data
        /// has to be moved.</param>
        /// <param name="sharePassword">Share password to be shared by all
        /// shares in SA.</param>
        public DestinationStorageAccountDetails(string storageAccountId, string accountId = default(string), string sharePassword = default(string))
            : base(accountId, sharePassword)
        {
            StorageAccountId = storageAccountId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets destination Storage Account Arm Id.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountId")]
        public string StorageAccountId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageAccountId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageAccountId");
            }
        }
    }
}
