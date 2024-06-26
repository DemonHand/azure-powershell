// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Extensions;

    /// <summary>Defines the network interface ip settings.</summary>
    public partial class NicIPSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.INicIPSettings,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.INicIPSettingsInternal
    {

        /// <summary>Backing field for <see cref="AllocationMethod" /> property.</summary>
        private string _allocationMethod;

        /// <summary>Gets or sets the nic allocation method.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PropertyOrigin.Owned)]
        public string AllocationMethod { get => this._allocationMethod; set => this._allocationMethod = value; }

        /// <summary>Backing field for <see cref="DnsServer" /> property.</summary>
        private System.Collections.Generic.List<string> _dnsServer;

        /// <summary>Gets or sets the dns servers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> DnsServer { get => this._dnsServer; set => this._dnsServer = value; }

        /// <summary>Backing field for <see cref="Gateway" /> property.</summary>
        private System.Collections.Generic.List<string> _gateway;

        /// <summary>Gets or sets the gateway.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Gateway { get => this._gateway; set => this._gateway = value; }

        /// <summary>Backing field for <see cref="IPAddress" /> property.</summary>
        private string _iPAddress;

        /// <summary>Gets or sets the ip address for the nic.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PropertyOrigin.Owned)]
        public string IPAddress { get => this._iPAddress; set => this._iPAddress = value; }

        /// <summary>Backing field for <see cref="IPAddressInfo" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.INicIPAddressSettings> _iPAddressInfo;

        /// <summary>
        /// Gets or sets the IP address information being reported for this NIC. This contains the same IPv4 information above plus
        /// IPV6 information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.INicIPAddressSettings> IPAddressInfo { get => this._iPAddressInfo; }

        /// <summary>Internal Acessors for IPAddressInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.INicIPAddressSettings> Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.INicIPSettingsInternal.IPAddressInfo { get => this._iPAddressInfo; set { {_iPAddressInfo = value;} } }

        /// <summary>Internal Acessors for PrimaryWinsServer</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.INicIPSettingsInternal.PrimaryWinsServer { get => this._primaryWinsServer; set { {_primaryWinsServer = value;} } }

        /// <summary>Internal Acessors for SecondaryWinsServer</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.INicIPSettingsInternal.SecondaryWinsServer { get => this._secondaryWinsServer; set { {_secondaryWinsServer = value;} } }

        /// <summary>Backing field for <see cref="PrimaryWinsServer" /> property.</summary>
        private string _primaryWinsServer;

        /// <summary>Gets or sets the primary server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PropertyOrigin.Owned)]
        public string PrimaryWinsServer { get => this._primaryWinsServer; }

        /// <summary>Backing field for <see cref="SecondaryWinsServer" /> property.</summary>
        private string _secondaryWinsServer;

        /// <summary>Gets or sets the secondary server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PropertyOrigin.Owned)]
        public string SecondaryWinsServer { get => this._secondaryWinsServer; }

        /// <summary>Backing field for <see cref="SubnetMask" /> property.</summary>
        private string _subnetMask;

        /// <summary>Gets or sets the mask.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PropertyOrigin.Owned)]
        public string SubnetMask { get => this._subnetMask; set => this._subnetMask = value; }

        /// <summary>Creates an new <see cref="NicIPSettings" /> instance.</summary>
        public NicIPSettings()
        {

        }
    }
    /// Defines the network interface ip settings.
    public partial interface INicIPSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the nic allocation method.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the nic allocation method.",
        SerializedName = @"allocationMethod",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PSArgumentCompleterAttribute("unset", "dynamic", "static", "linklayer", "random", "other")]
        string AllocationMethod { get; set; }
        /// <summary>Gets or sets the dns servers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the dns servers.",
        SerializedName = @"dnsServers",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> DnsServer { get; set; }
        /// <summary>Gets or sets the gateway.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the gateway.",
        SerializedName = @"gateway",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Gateway { get; set; }
        /// <summary>Gets or sets the ip address for the nic.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the ip address for the nic.",
        SerializedName = @"ipAddress",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddress { get; set; }
        /// <summary>
        /// Gets or sets the IP address information being reported for this NIC. This contains the same IPv4 information above plus
        /// IPV6 information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the IP address information being reported for this NIC. This contains the same IPv4 information above plus IPV6 information.",
        SerializedName = @"ipAddressInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.INicIPAddressSettings) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.INicIPAddressSettings> IPAddressInfo { get;  }
        /// <summary>Gets or sets the primary server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the primary server.",
        SerializedName = @"primaryWinsServer",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryWinsServer { get;  }
        /// <summary>Gets or sets the secondary server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the secondary server.",
        SerializedName = @"secondaryWinsServer",
        PossibleTypes = new [] { typeof(string) })]
        string SecondaryWinsServer { get;  }
        /// <summary>Gets or sets the mask.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the mask.",
        SerializedName = @"subnetMask",
        PossibleTypes = new [] { typeof(string) })]
        string SubnetMask { get; set; }

    }
    /// Defines the network interface ip settings.
    internal partial interface INicIPSettingsInternal

    {
        /// <summary>Gets or sets the nic allocation method.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PSArgumentCompleterAttribute("unset", "dynamic", "static", "linklayer", "random", "other")]
        string AllocationMethod { get; set; }
        /// <summary>Gets or sets the dns servers.</summary>
        System.Collections.Generic.List<string> DnsServer { get; set; }
        /// <summary>Gets or sets the gateway.</summary>
        System.Collections.Generic.List<string> Gateway { get; set; }
        /// <summary>Gets or sets the ip address for the nic.</summary>
        string IPAddress { get; set; }
        /// <summary>
        /// Gets or sets the IP address information being reported for this NIC. This contains the same IPv4 information above plus
        /// IPV6 information.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.INicIPAddressSettings> IPAddressInfo { get; set; }
        /// <summary>Gets or sets the primary server.</summary>
        string PrimaryWinsServer { get; set; }
        /// <summary>Gets or sets the secondary server.</summary>
        string SecondaryWinsServer { get; set; }
        /// <summary>Gets or sets the mask.</summary>
        string SubnetMask { get; set; }

    }
}