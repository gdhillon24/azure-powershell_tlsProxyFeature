// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20221227
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Extensions;

    /// <summary>Describes Extension Metadata properties</summary>
    public partial class ExtensionValueProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20221227.IExtensionValueProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20221227.IExtensionValuePropertiesInternal
    {

        /// <summary>Backing field for <see cref="ExtensionType" /> property.</summary>
        private string _extensionType;

        /// <summary>The type of the Extension being received.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string ExtensionType { get => this._extensionType; }

        /// <summary>Internal Acessors for ExtensionType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20221227.IExtensionValuePropertiesInternal.ExtensionType { get => this._extensionType; set { {_extensionType = value;} } }

        /// <summary>Internal Acessors for Publisher</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20221227.IExtensionValuePropertiesInternal.Publisher { get => this._publisher; set { {_publisher = value;} } }

        /// <summary>Internal Acessors for Version</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20221227.IExtensionValuePropertiesInternal.Version { get => this._version; set { {_version = value;} } }

        /// <summary>Backing field for <see cref="Publisher" /> property.</summary>
        private string _publisher;

        /// <summary>The publisher of the Extension being received.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string Publisher { get => this._publisher; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>The version of the Extension being received.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string Version { get => this._version; }

        /// <summary>Creates an new <see cref="ExtensionValueProperties" /> instance.</summary>
        public ExtensionValueProperties()
        {

        }
    }
    /// Describes Extension Metadata properties
    public partial interface IExtensionValueProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IJsonSerializable
    {
        /// <summary>The type of the Extension being received.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of the Extension being received.",
        SerializedName = @"extensionType",
        PossibleTypes = new [] { typeof(string) })]
        string ExtensionType { get;  }
        /// <summary>The publisher of the Extension being received.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The publisher of the Extension being received.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string Publisher { get;  }
        /// <summary>The version of the Extension being received.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The version of the Extension being received.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get;  }

    }
    /// Describes Extension Metadata properties
    internal partial interface IExtensionValuePropertiesInternal

    {
        /// <summary>The type of the Extension being received.</summary>
        string ExtensionType { get; set; }
        /// <summary>The publisher of the Extension being received.</summary>
        string Publisher { get; set; }
        /// <summary>The version of the Extension being received.</summary>
        string Version { get; set; }

    }
}