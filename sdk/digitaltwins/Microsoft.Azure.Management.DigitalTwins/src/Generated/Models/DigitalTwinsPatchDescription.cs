// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DigitalTwins.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The description of the DigitalTwins service.
    /// </summary>
    public partial class DigitalTwinsPatchDescription
    {
        /// <summary>
        /// Initializes a new instance of the DigitalTwinsPatchDescription
        /// class.
        /// </summary>
        public DigitalTwinsPatchDescription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DigitalTwinsPatchDescription
        /// class.
        /// </summary>
        /// <param name="tags">Instance patch properties</param>
        /// <param name="identity">The managed identity for the
        /// DigitalTwinsInstance.</param>
        /// <param name="properties">Properties for the
        /// DigitalTwinsInstance.</param>
        public DigitalTwinsPatchDescription(IDictionary<string, string> tags = default(IDictionary<string, string>), DigitalTwinsIdentity identity = default(DigitalTwinsIdentity), DigitalTwinsPatchProperties properties = default(DigitalTwinsPatchProperties))
        {
            Tags = tags;
            Identity = identity;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets instance patch properties
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the managed identity for the DigitalTwinsInstance.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public DigitalTwinsIdentity Identity { get; set; }

        /// <summary>
        /// Gets or sets properties for the DigitalTwinsInstance.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public DigitalTwinsPatchProperties Properties { get; set; }

    }
}
