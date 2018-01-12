// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Person.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Person : Entity
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// The person's display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets given name.
        /// The person's given name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "givenName", Required = Newtonsoft.Json.Required.Default)]
        public string GivenName { get; set; }
    
        /// <summary>
        /// Gets or sets surname.
        /// The person's surname.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "surname", Required = Newtonsoft.Json.Required.Default)]
        public string Surname { get; set; }
    
        /// <summary>
        /// Gets or sets birthday.
        /// The person's birthday.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "birthday", Required = Newtonsoft.Json.Required.Default)]
        public string Birthday { get; set; }
    
        /// <summary>
        /// Gets or sets person notes.
        /// Free-form notes that the the user has taken about this person.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "personNotes", Required = Newtonsoft.Json.Required.Default)]
        public string PersonNotes { get; set; }
    
        /// <summary>
        /// Gets or sets is favorite.
        /// true if the user has flagged this person as a favorite.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isFavorite", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsFavorite { get; set; }
    
        /// <summary>
        /// Gets or sets scored email addresses.
        /// The person's email addresses.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scoredEmailAddresses", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ScoredEmailAddress> ScoredEmailAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets phones.
        /// The person's phone numbers.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "phones", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Phone> Phones { get; set; }
    
        /// <summary>
        /// Gets or sets postal addresses.
        /// The person's addresses.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "postalAddresses", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Location> PostalAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets websites.
        /// The person's websites.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "websites", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Website> Websites { get; set; }
    
        /// <summary>
        /// Gets or sets job title.
        /// The person's job title.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "jobTitle", Required = Newtonsoft.Json.Required.Default)]
        public string JobTitle { get; set; }
    
        /// <summary>
        /// Gets or sets company name.
        /// The name of the person's company.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "companyName", Required = Newtonsoft.Json.Required.Default)]
        public string CompanyName { get; set; }
    
        /// <summary>
        /// Gets or sets yomi company.
        /// The phonetic Japanese name of the person's company.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "yomiCompany", Required = Newtonsoft.Json.Required.Default)]
        public string YomiCompany { get; set; }
    
        /// <summary>
        /// Gets or sets department.
        /// The person's department.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "department", Required = Newtonsoft.Json.Required.Default)]
        public string Department { get; set; }
    
        /// <summary>
        /// Gets or sets office location.
        /// The location of the person's office.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "officeLocation", Required = Newtonsoft.Json.Required.Default)]
        public string OfficeLocation { get; set; }
    
        /// <summary>
        /// Gets or sets profession.
        /// The person's profession.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "profession", Required = Newtonsoft.Json.Required.Default)]
        public string Profession { get; set; }
    
        /// <summary>
        /// Gets or sets person type.
        /// The type of person.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "personType", Required = Newtonsoft.Json.Required.Default)]
        public PersonType PersonType { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// The user principal name (UPN) of the person. The UPN is an Internet-style login name for the person based on the Internet standard RFC 822. By convention, this should map to the person's email name. The general format is alias@domain.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets im address.
        /// The instant message voice over IP (VOIP) session initiation protocol (SIP) address for the user. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "imAddress", Required = Newtonsoft.Json.Required.Default)]
        public string ImAddress { get; set; }
    
    }
}

