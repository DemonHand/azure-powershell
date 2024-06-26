// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Extensions;

    /// <summary>Represents the properties of the Dns Resource Reference Result.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.Dns.DoNotFormat]
    public partial class DnsResourceReferenceResult :
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReferenceResult,
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReferenceResultInternal
    {

        /// <summary>
        /// The result of dns resource reference request. A list of dns resource references for each of the azure resource in the
        /// request
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReference[] DnsResourceReference { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReferenceResultPropertiesInternal)Property).DnsResourceReference; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReferenceResultPropertiesInternal)Property).DnsResourceReference = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReferenceResultProperties Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReferenceResultInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.DnsResourceReferenceResultProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReferenceResultProperties _property;

        /// <summary>
        /// The result of dns resource reference request. Returns a list of dns resource references for each of the azure resource
        /// in the request.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReferenceResultProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.DnsResourceReferenceResultProperties()); set => this._property = value; }

        /// <summary>Creates an new <see cref="DnsResourceReferenceResult" /> instance.</summary>
        public DnsResourceReferenceResult()
        {

        }
    }
    /// Represents the properties of the Dns Resource Reference Result.
    public partial interface IDnsResourceReferenceResult :
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The result of dns resource reference request. A list of dns resource references for each of the azure resource in the
        /// request
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The result of dns resource reference request. A list of dns resource references for each of the azure resource in the request",
        SerializedName = @"dnsResourceReferences",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReference) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReference[] DnsResourceReference { get; set; }

    }
    /// Represents the properties of the Dns Resource Reference Result.
    internal partial interface IDnsResourceReferenceResultInternal

    {
        /// <summary>
        /// The result of dns resource reference request. A list of dns resource references for each of the azure resource in the
        /// request
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReference[] DnsResourceReference { get; set; }
        /// <summary>
        /// The result of dns resource reference request. Returns a list of dns resource references for each of the azure resource
        /// in the request.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IDnsResourceReferenceResultProperties Property { get; set; }

    }
}