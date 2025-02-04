// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Extensions;

    /// <summary>Deploy SAP Infrastructure Details.</summary>
    public partial class InfrastructureConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IInfrastructureConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IInfrastructureConfigurationInternal
    {

        /// <summary>Backing field for <see cref="AppResourceGroup" /> property.</summary>
        private string _appResourceGroup;

        /// <summary>The application resource group where SAP system resources will be deployed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public string AppResourceGroup { get => this._appResourceGroup; set => this._appResourceGroup = value; }

        /// <summary>Backing field for <see cref="DeploymentType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapDeploymentType _deploymentType;

        /// <summary>The type of SAP deployment, single server or Three tier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapDeploymentType DeploymentType { get => this._deploymentType; set => this._deploymentType = value; }

        /// <summary>Creates an new <see cref="InfrastructureConfiguration" /> instance.</summary>
        public InfrastructureConfiguration()
        {

        }
    }
    /// Deploy SAP Infrastructure Details.
    public partial interface IInfrastructureConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.IJsonSerializable
    {
        /// <summary>The application resource group where SAP system resources will be deployed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The application resource group where SAP system resources will be deployed.",
        SerializedName = @"appResourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string AppResourceGroup { get; set; }
        /// <summary>The type of SAP deployment, single server or Three tier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The type of SAP deployment, single server or Three tier.",
        SerializedName = @"deploymentType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapDeploymentType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapDeploymentType DeploymentType { get; set; }

    }
    /// Deploy SAP Infrastructure Details.
    internal partial interface IInfrastructureConfigurationInternal

    {
        /// <summary>The application resource group where SAP system resources will be deployed.</summary>
        string AppResourceGroup { get; set; }
        /// <summary>The type of SAP deployment, single server or Three tier.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapDeploymentType DeploymentType { get; set; }

    }
}