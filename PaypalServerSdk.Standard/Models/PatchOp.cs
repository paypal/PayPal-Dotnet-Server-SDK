// <copyright file="PatchOp.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using PaypalServerSdk.Standard;
using PaypalServerSdk.Standard.Utilities;

namespace PaypalServerSdk.Standard.Models
{
    /// <summary>
    /// PatchOp.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PatchOp
    {
        /// <summary>
        ///Depending on the target location reference, completes one of these functions: The target location is an array index. Inserts a new value into the array at the specified index. The target location is an object parameter that does not already exist. Adds a new parameter to the object. The target location is an object parameter that does exist. Replaces that parameter's value. The value parameter defines the value to add. For more information, see 4.1. add.
        /// Add.
        /// </summary>
        [EnumMember(Value = "add")]
        Add,

        /// <summary>
        ///Removes the value at the target location. For the operation to succeed, the target location must exist. For more information, see 4.2. remove.
        /// Remove.
        /// </summary>
        [EnumMember(Value = "remove")]
        Remove,

        /// <summary>
        ///Replaces the value at the target location with a new value. The operation object must contain a value parameter that defines the replacement value. For the operation to succeed, the target location must exist. For more information, see 4.3. replace.
        /// Replace.
        /// </summary>
        [EnumMember(Value = "replace")]
        Replace,

        /// <summary>
        ///Removes the value at a specified location and adds it to the target location. The operation object must contain a from parameter, which is a string that contains a JSON pointer value that references the location in the target document from which to move the value. For the operation to succeed, the from location must exist. For more information, see 4.4. move.
        /// Move.
        /// </summary>
        [EnumMember(Value = "move")]
        Move,

        /// <summary>
        ///Copies the value at a specified location to the target location. The operation object must contain a from parameter, which is a string that contains a JSON pointer value that references the location in the target document from which to copy the value. For the operation to succeed, the from location must exist. For more information, see 4.5. copy.
        /// Copy.
        /// </summary>
        [EnumMember(Value = "copy")]
        Copy,

        /// <summary>
        ///Tests that a value at the target location is equal to a specified value. The operation object must contain a value parameter that defines the value to compare to the target location's value. For the operation to succeed, the target location must be equal to the value value. For test, equal indicates that the value at the target location and the value that value defines are of the same JSON type. The data type of the value determines how equality is defined: Type Considered equal if both values strings Contain the same number of Unicode characters and their code points are byte-by-byte equal. numbers Are numerically equal. arrays Contain the same number of values, and each value is equal to the value at the corresponding position in the other array, by using these type-specific rules. objects Contain the same number of parameters, and each parameter is equal to a parameter in the other object, by comparing their keys (as strings) and their values (by using these type-specific rules). literals (false, true, and null) Are the same. The comparison is a logical comparison. For example, whitespace between the parameter values of an array is not significant. Also, ordering of the serialization of object parameters is not significant. For more information, see 4.6. test.
        /// Test.
        /// </summary>
        [EnumMember(Value = "test")]
        Test,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}