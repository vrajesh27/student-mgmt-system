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
    public partial class Height : IEquatable<Height>
    { 
        /// <summary>
        /// The height of the student. 
        /// </summary>
        /// <value>The height of the student. </value>
        [Required]
        [DataMember(Name="value")]
        public float? Value { get; set; }
        /// <summary>
        /// The unit of height measurement. 
        /// </summary>
        /// <value>The unit of height measurement. </value>
        public enum UnitEnum
        { 
            /// <summary>
            /// Enum CentimetersEnum for centimeters
            /// </summary>
            [EnumMember(Value = "centimeters")]
            CentimetersEnum = 1,
            
            /// <summary>
            /// Enum FtEnum for ft
            /// </summary>
            [EnumMember(Value = "ft")]
            FtEnum = 2,
            
            /// <summary>
            /// Enum InchesEnum for inches
            /// </summary>
            [EnumMember(Value = "inches")]
            InchesEnum = 3
        }

        /// <summary>
        /// The unit of height measurement. 
        /// </summary>
        /// <value>The unit of height measurement. </value>
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
            sb.Append("class Height {\n");
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
            return obj.GetType() == GetType() && Equals((Height)obj);
        }

        /// <summary>
        /// Returns true if Height instances are equal
        /// </summary>
        /// <param name="other">Instance of Height to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Height other)
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

        public static bool operator ==(Height left, Height right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Height left, Height right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
