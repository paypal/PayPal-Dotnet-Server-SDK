// <copyright file="Name.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PaypalServerSdk.Standard;
using PaypalServerSdk.Standard.Utilities;

namespace PaypalServerSdk.Standard.Models
{
    /// <summary>
    /// Name.
    /// </summary>
    public class Name
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Name"/> class.
        /// </summary>
        public Name()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Name"/> class.
        /// </summary>
        /// <param name="givenName">given_name.</param>
        /// <param name="surname">surname.</param>
        public Name(
            string givenName = null,
            string surname = null)
        {
            this.GivenName = givenName;
            this.Surname = surname;
        }

        /// <summary>
        /// When the party is a person, the party's given, or first, name.
        /// </summary>
        [JsonProperty("given_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GivenName { get; set; }

        /// <summary>
        /// When the party is a person, the party's surname or family name. Also known as the last name. Required when the party is a person. Use also to store multiple surnames including the matronymic, or mother's, surname.
        /// </summary>
        [JsonProperty("surname", NullValueHandling = NullValueHandling.Ignore)]
        public string Surname { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Name : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is Name other &&                ((this.GivenName == null && other.GivenName == null) || (this.GivenName?.Equals(other.GivenName) == true)) &&
                ((this.Surname == null && other.Surname == null) || (this.Surname?.Equals(other.Surname) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.GivenName = {(this.GivenName == null ? "null" : this.GivenName)}");
            toStringOutput.Add($"this.Surname = {(this.Surname == null ? "null" : this.Surname)}");
        }
    }
}