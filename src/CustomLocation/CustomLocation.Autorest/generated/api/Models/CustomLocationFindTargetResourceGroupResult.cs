// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Extensions;

    /// <summary>The Find Target Resource Group operation response.</summary>
    public partial class CustomLocationFindTargetResourceGroupResult :
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.ICustomLocationFindTargetResourceGroupResult,
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.ICustomLocationFindTargetResourceGroupResultInternal
    {

        /// <summary>Backing field for <see cref="MatchedResourceSyncRule" /> property.</summary>
        private string _matchedResourceSyncRule;

        /// <summary>
        /// The matching resource sync rule is the particular resource sync rule that matched the match expressions and labels and
        /// had lowest priority. This is the rule responsible for mapping the target resource to the target resource group.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Owned)]
        public string MatchedResourceSyncRule { get => this._matchedResourceSyncRule; }

        /// <summary>Internal Acessors for MatchedResourceSyncRule</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.ICustomLocationFindTargetResourceGroupResultInternal.MatchedResourceSyncRule { get => this._matchedResourceSyncRule; set { {_matchedResourceSyncRule = value;} } }

        /// <summary>Internal Acessors for TargetResourceGroup</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.ICustomLocationFindTargetResourceGroupResultInternal.TargetResourceGroup { get => this._targetResourceGroup; set { {_targetResourceGroup = value;} } }

        /// <summary>Backing field for <see cref="TargetResourceGroup" /> property.</summary>
        private string _targetResourceGroup;

        /// <summary>
        /// The target resource group of matching resource sync rule. The labels from the request will be used to find out matching
        /// resource sync rule against the selector property of the resource sync rule. The one with highest priority will be returned
        /// if there are multiple matching rules.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Owned)]
        public string TargetResourceGroup { get => this._targetResourceGroup; }

        /// <summary>
        /// Creates an new <see cref="CustomLocationFindTargetResourceGroupResult" /> instance.
        /// </summary>
        public CustomLocationFindTargetResourceGroupResult()
        {

        }
    }
    /// The Find Target Resource Group operation response.
    public partial interface ICustomLocationFindTargetResourceGroupResult :
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The matching resource sync rule is the particular resource sync rule that matched the match expressions and labels and
        /// had lowest priority. This is the rule responsible for mapping the target resource to the target resource group.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The matching resource sync rule is the particular resource sync rule that matched the match expressions and labels and had lowest priority. This is the rule responsible for mapping the target resource to the target resource group.",
        SerializedName = @"matchedResourceSyncRule",
        PossibleTypes = new [] { typeof(string) })]
        string MatchedResourceSyncRule { get;  }
        /// <summary>
        /// The target resource group of matching resource sync rule. The labels from the request will be used to find out matching
        /// resource sync rule against the selector property of the resource sync rule. The one with highest priority will be returned
        /// if there are multiple matching rules.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The target resource group of matching resource sync rule. The labels from the request will be used to find out matching resource sync rule against the selector property of the resource sync rule. The one with highest priority will be returned if there are multiple matching rules.",
        SerializedName = @"targetResourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string TargetResourceGroup { get;  }

    }
    /// The Find Target Resource Group operation response.
    internal partial interface ICustomLocationFindTargetResourceGroupResultInternal

    {
        /// <summary>
        /// The matching resource sync rule is the particular resource sync rule that matched the match expressions and labels and
        /// had lowest priority. This is the rule responsible for mapping the target resource to the target resource group.
        /// </summary>
        string MatchedResourceSyncRule { get; set; }
        /// <summary>
        /// The target resource group of matching resource sync rule. The labels from the request will be used to find out matching
        /// resource sync rule against the selector property of the resource sync rule. The one with highest priority will be returned
        /// if there are multiple matching rules.
        /// </summary>
        string TargetResourceGroup { get; set; }

    }
}