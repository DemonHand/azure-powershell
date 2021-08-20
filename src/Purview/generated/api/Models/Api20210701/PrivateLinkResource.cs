namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>A privately linkable resource.</summary>
    public partial class PrivateLinkResource :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResource,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourceInternal
    {

        /// <summary>The private link resource group identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string GroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourcePropertiesInternal)Property).GroupId; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The private link resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for GroupId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourceInternal.GroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourcePropertiesInternal)Property).GroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourcePropertiesInternal)Property).GroupId = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourceInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourceInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourceProperties Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.PrivateLinkResourceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for RequiredMember</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourceInternal.RequiredMember { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourcePropertiesInternal)Property).RequiredMember; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourcePropertiesInternal)Property).RequiredMember = value; }

        /// <summary>Internal Acessors for RequiredZoneName</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourceInternal.RequiredZoneName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourcePropertiesInternal)Property).RequiredZoneName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourcePropertiesInternal)Property).RequiredZoneName = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourceInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The private link resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourceProperties _property;

        /// <summary>The private link resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.PrivateLinkResourceProperties()); }

        /// <summary>
        /// This translates to how many Private IPs should be created for each privately linkable resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string[] RequiredMember { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourcePropertiesInternal)Property).RequiredMember; }

        /// <summary>The required zone names for private link resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string[] RequiredZoneName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourcePropertiesInternal)Property).RequiredZoneName; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/").Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/").Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The private link resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="PrivateLinkResource" /> instance.</summary>
        public PrivateLinkResource()
        {

        }
    }
    /// A privately linkable resource.
    public partial interface IPrivateLinkResource :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>The private link resource group identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The private link resource group identifier.",
        SerializedName = @"groupId",
        PossibleTypes = new [] { typeof(string) })]
        string GroupId { get;  }
        /// <summary>The private link resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The private link resource identifier.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The private link resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The private link resource name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>
        /// This translates to how many Private IPs should be created for each privately linkable resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"This translates to how many Private IPs should be created for each privately linkable resource.",
        SerializedName = @"requiredMembers",
        PossibleTypes = new [] { typeof(string) })]
        string[] RequiredMember { get;  }
        /// <summary>The required zone names for private link resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The required zone names for private link resource.",
        SerializedName = @"requiredZoneNames",
        PossibleTypes = new [] { typeof(string) })]
        string[] RequiredZoneName { get;  }
        /// <summary>The private link resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The private link resource type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// A privately linkable resource.
    internal partial interface IPrivateLinkResourceInternal

    {
        /// <summary>The private link resource group identifier.</summary>
        string GroupId { get; set; }
        /// <summary>The private link resource identifier.</summary>
        string Id { get; set; }
        /// <summary>The private link resource name.</summary>
        string Name { get; set; }
        /// <summary>The private link resource properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourceProperties Property { get; set; }
        /// <summary>
        /// This translates to how many Private IPs should be created for each privately linkable resource.
        /// </summary>
        string[] RequiredMember { get; set; }
        /// <summary>The required zone names for private link resource.</summary>
        string[] RequiredZoneName { get; set; }
        /// <summary>The private link resource type.</summary>
        string Type { get; set; }

    }
}