// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.SignalR;

/// <summary>
/// SignalRSharedPrivateLink.
/// </summary>
public partial class SignalRSharedPrivateLink : ProvisionableResource
{
    /// <summary>
    /// The name of the shared private link resource.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The group id from the provider of resource the shared private link
    /// resource is for.
    /// </summary>
    public BicepValue<string> GroupId { get => _groupId; set => _groupId.Assign(value); }
    private readonly BicepValue<string> _groupId;

    /// <summary>
    /// The resource id of the resource the shared private link resource is for.
    /// </summary>
    public BicepValue<ResourceIdentifier> PrivateLinkResourceId { get => _privateLinkResourceId; set => _privateLinkResourceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _privateLinkResourceId;

    /// <summary>
    /// The request message for requesting approval of the shared private link
    /// resource.
    /// </summary>
    public BicepValue<string> RequestMessage { get => _requestMessage; set => _requestMessage.Assign(value); }
    private readonly BicepValue<string> _requestMessage;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Provisioning state of the resource.
    /// </summary>
    public BicepValue<SignalRProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<SignalRProvisioningState> _provisioningState;

    /// <summary>
    /// Status of the shared private link resource.
    /// </summary>
    public BicepValue<SignalRSharedPrivateLinkResourceStatus> Status { get => _status; }
    private readonly BicepValue<SignalRSharedPrivateLinkResourceStatus> _status;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent SignalRService.
    /// </summary>
    public SignalRService? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<SignalRService> _parent;

    /// <summary>
    /// Creates a new SignalRSharedPrivateLink.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SignalRSharedPrivateLink resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SignalRSharedPrivateLink.</param>
    public SignalRSharedPrivateLink(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.SignalRService/signalR/sharedPrivateLinkResources", resourceVersion ?? "2024-03-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _groupId = BicepValue<string>.DefineProperty(this, "GroupId", ["properties", "groupId"]);
        _privateLinkResourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "PrivateLinkResourceId", ["properties", "privateLinkResourceId"]);
        _requestMessage = BicepValue<string>.DefineProperty(this, "RequestMessage", ["properties", "requestMessage"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<SignalRProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _status = BicepValue<SignalRSharedPrivateLinkResourceStatus>.DefineProperty(this, "Status", ["properties", "status"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<SignalRService>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SignalRSharedPrivateLink resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-03-01.
        /// </summary>
        public static readonly string V2024_03_01 = "2024-03-01";

        /// <summary>
        /// 2023-02-01.
        /// </summary>
        public static readonly string V2023_02_01 = "2023-02-01";

        /// <summary>
        /// 2022-02-01.
        /// </summary>
        public static readonly string V2022_02_01 = "2022-02-01";

        /// <summary>
        /// 2021-10-01.
        /// </summary>
        public static readonly string V2021_10_01 = "2021-10-01";

        /// <summary>
        /// 2020-05-01.
        /// </summary>
        public static readonly string V2020_05_01 = "2020-05-01";

        /// <summary>
        /// 2018-10-01.
        /// </summary>
        public static readonly string V2018_10_01 = "2018-10-01";
    }

    /// <summary>
    /// Creates a reference to an existing SignalRSharedPrivateLink.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SignalRSharedPrivateLink resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SignalRSharedPrivateLink.</param>
    /// <returns>The existing SignalRSharedPrivateLink resource.</returns>
    public static SignalRSharedPrivateLink FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
