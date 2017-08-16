// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Azure;
    using Management;
    using Logic;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The callback url.
    /// </summary>
    public partial class CallbackUrl
    {
        /// <summary>
        /// Initializes a new instance of the CallbackUrl class.
        /// </summary>
        public CallbackUrl() { }

        /// <summary>
        /// Initializes a new instance of the CallbackUrl class.
        /// </summary>
        /// <param name="value">The URL value.</param>
        public CallbackUrl(string value = default(string))
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets the URL value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
