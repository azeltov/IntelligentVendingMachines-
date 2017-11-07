/* 
 * apiPredictPurchasePrice
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// StartBatchExecutionResponse
    /// </summary>
    [DataContract]
    public partial class StartBatchExecutionResponse :  IEquatable<StartBatchExecutionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartBatchExecutionResponse" /> class.
        /// </summary>
        /// <param name="BatchExecutionId">Id of the asynchronous execution..</param>
        public StartBatchExecutionResponse(string BatchExecutionId = default(string))
        {
            this.BatchExecutionId = BatchExecutionId;
        }
        
        /// <summary>
        /// Id of the asynchronous execution.
        /// </summary>
        /// <value>Id of the asynchronous execution.</value>
        [DataMember(Name="batchExecutionId", EmitDefaultValue=false)]
        public string BatchExecutionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartBatchExecutionResponse {\n");
            sb.Append("  BatchExecutionId: ").Append(BatchExecutionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as StartBatchExecutionResponse);
        }

        /// <summary>
        /// Returns true if StartBatchExecutionResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of StartBatchExecutionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartBatchExecutionResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BatchExecutionId == other.BatchExecutionId ||
                    this.BatchExecutionId != null &&
                    this.BatchExecutionId.Equals(other.BatchExecutionId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.BatchExecutionId != null)
                    hash = hash * 59 + this.BatchExecutionId.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
