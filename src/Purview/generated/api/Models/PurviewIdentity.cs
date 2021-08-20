// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    public partial class PurviewIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.IPurviewIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.IPurviewIdentityInternal
    {

        /// <summary>Backing field for <see cref="AccountName" /> property.</summary>
        private string _accountName;

        /// <summary>The name of the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string AccountName { get => this._accountName; set => this._accountName = value; }

        /// <summary>Backing field for <see cref="GroupId" /> property.</summary>
        private string _groupId;

        /// <summary>The group identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string GroupId { get => this._groupId; set => this._groupId = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="PrivateEndpointConnectionName" /> property.</summary>
        private string _privateEndpointConnectionName;

        /// <summary>Name of the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string PrivateEndpointConnectionName { get => this._privateEndpointConnectionName; set => this._privateEndpointConnectionName = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The resource group name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The subscription identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="PurviewIdentity" /> instance.</summary>
        public PurviewIdentity()
        {

        }
    }
    public partial interface IPurviewIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>The name of the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the account.",
        SerializedName = @"accountName",
        PossibleTypes = new [] { typeof(string) })]
        string AccountName { get; set; }
        /// <summary>The group identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The group identifier.",
        SerializedName = @"groupId",
        PossibleTypes = new [] { typeof(string) })]
        string GroupId { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Name of the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the private endpoint connection.",
        SerializedName = @"privateEndpointConnectionName",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateEndpointConnectionName { get; set; }
        /// <summary>The resource group name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource group name.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>The subscription identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The subscription identifier",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    internal partial interface IPurviewIdentityInternal

    {
        /// <summary>The name of the account.</summary>
        string AccountName { get; set; }
        /// <summary>The group identifier.</summary>
        string GroupId { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>Name of the private endpoint connection.</summary>
        string PrivateEndpointConnectionName { get; set; }
        /// <summary>The resource group name.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>The subscription identifier</summary>
        string SubscriptionId { get; set; }

    }
}