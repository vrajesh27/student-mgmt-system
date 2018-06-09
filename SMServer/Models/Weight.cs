/*
 * Student Management Services
 *
 * The student management service(s) for reading student information and managing the grades. 
 *
 * OpenAPI spec version: 1.0.0-SNAPSHOT
 * Contact: vrajesh.27@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Weight : IEquatable<Weight>
    { 
        /// <summary>
        /// The weight of the student. 
        /// </summary>
        /// <value>The weight of the student. </value>
        [Required]
        [DataMember(Name="value")]
        public float? Value { get; set; }
        /// <summary>
        /// The unit of weight measurement. 
        /// </summary>
        /// <value>The unit of weight measurement. </value>
        public enum UnitEnum
        { 
            /// <summary>
            /// Enum KgEnum for kg
            /// </summary>
            [EnumMember(Value = "kg")]
            KgEnum = 1,
            
            /// <summary>
            /// Enum PoundsEnum for pounds
            /// </summary>
            [EnumMember(Value = "pounds")]
            PoundsEnum = 2
        }

        /// <summary>
        /// The unit of weight measurement. 
        /// </summary>
        /// <value>The unit of weight measurement. </value>
        [Required]
        [DataMember(Name="unit")]
        public UnitEnum? Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Weight {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Weight)obj);
        }

        /// <summary>
        /// Returns true if Weight instances are equal
        /// </summary>
        /// <param name="other">Instance of Weight to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Weight other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
                ) && 
                (
                    Unit == other.Unit ||
                    Unit != null &&
                    Unit.Equals(other.Unit)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                    if (Unit != null)
                    hashCode = hashCode * 59 + Unit.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Weight left, Weight right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Weight left, Weight right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
