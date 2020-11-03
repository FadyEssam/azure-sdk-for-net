// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Intrusion detection signatures specification states.
    /// </summary>
    public partial class FirewallPolicyIntrusionDetectionSignatureSpecification
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FirewallPolicyIntrusionDetectionSignatureSpecification class.
        /// </summary>
        public FirewallPolicyIntrusionDetectionSignatureSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// FirewallPolicyIntrusionDetectionSignatureSpecification class.
        /// </summary>
        /// <param name="id">Signature id.</param>
        /// <param name="mode">The signature state. Possible values include:
        /// 'Off', 'Alert', 'Deny'</param>
        public FirewallPolicyIntrusionDetectionSignatureSpecification(string id = default(string), string mode = default(string))
        {
            Id = id;
            Mode = mode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets signature id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the signature state. Possible values include: 'Off',
        /// 'Alert', 'Deny'
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

    }
}