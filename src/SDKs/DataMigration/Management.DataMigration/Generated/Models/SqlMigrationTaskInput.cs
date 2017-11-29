// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Base class for migration task input
    /// </summary>
    public partial class SqlMigrationTaskInput
    {
        /// <summary>
        /// Initializes a new instance of the SqlMigrationTaskInput class.
        /// </summary>
        public SqlMigrationTaskInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlMigrationTaskInput class.
        /// </summary>
        /// <param name="sourceConnectionInfo">Information for connecting to
        /// source</param>
        /// <param name="targetConnectionInfo">Information for connecting to
        /// target</param>
        public SqlMigrationTaskInput(SqlConnectionInfo sourceConnectionInfo, SqlConnectionInfo targetConnectionInfo)
        {
            SourceConnectionInfo = sourceConnectionInfo;
            TargetConnectionInfo = targetConnectionInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets information for connecting to source
        /// </summary>
        [JsonProperty(PropertyName = "sourceConnectionInfo")]
        public SqlConnectionInfo SourceConnectionInfo { get; set; }

        /// <summary>
        /// Gets or sets information for connecting to target
        /// </summary>
        [JsonProperty(PropertyName = "targetConnectionInfo")]
        public SqlConnectionInfo TargetConnectionInfo { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SourceConnectionInfo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceConnectionInfo");
            }
            if (TargetConnectionInfo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetConnectionInfo");
            }
            if (SourceConnectionInfo != null)
            {
                SourceConnectionInfo.Validate();
            }
            if (TargetConnectionInfo != null)
            {
                TargetConnectionInfo.Validate();
            }
        }
    }
}