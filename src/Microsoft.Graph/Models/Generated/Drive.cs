// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    using Newtonsoft.Json;

    /// <summary>
    /// The type Drive.
    /// </summary>
    [DataContract]
    public partial class Drive : Entity
    {
    
        /// <summary>
        /// Gets or sets drive type.
        /// </summary>
        [DataMember(Name = "driveType", EmitDefaultValue = false, IsRequired = false)]
        public string DriveType { get; set; }
    
        /// <summary>
        /// Gets or sets owner.
        /// </summary>
        [DataMember(Name = "owner", EmitDefaultValue = false, IsRequired = false)]
        public IdentitySet Owner { get; set; }
    
        /// <summary>
        /// Gets or sets quota.
        /// </summary>
        [DataMember(Name = "quota", EmitDefaultValue = false, IsRequired = false)]
        public Quota Quota { get; set; }
    
        /// <summary>
        /// Gets or sets items.
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false, IsRequired = false)]
        public IDriveItemsCollectionPage Items { get; set; }
    
        /// <summary>
        /// Gets or sets special.
        /// </summary>
        [DataMember(Name = "special", EmitDefaultValue = false, IsRequired = false)]
        public IDriveSpecialCollectionPage Special { get; set; }
    
        /// <summary>
        /// Gets or sets root.
        /// </summary>
        [DataMember(Name = "root", EmitDefaultValue = false, IsRequired = false)]
        public DriveItem Root { get; set; }
    
    }
}
