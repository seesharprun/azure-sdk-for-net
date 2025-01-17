// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.EventHubs;

/// <summary>
/// EventHubsPrivateEndpointConnection.
/// </summary>
public partial class EventHubsPrivateEndpointConnection : ProvisionableResource
{
    /// <summary>
    /// The PrivateEndpointConnection name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Details about the state of the connection.
    /// </summary>
    public BicepValue<EventHubsPrivateLinkServiceConnectionState> ConnectionState { get => _connectionState; set => _connectionState.Assign(value); }
    private readonly BicepValue<EventHubsPrivateLinkServiceConnectionState> _connectionState;

    /// <summary>
    /// Gets or sets Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> PrivateEndpointId { get => _privateEndpointId; set => _privateEndpointId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _privateEndpointId;

    /// <summary>
    /// Provisioning state of the Private Endpoint Connection.
    /// </summary>
    public BicepValue<EventHubsPrivateEndpointConnectionProvisioningState> ProvisioningState { get => _provisioningState; set => _provisioningState.Assign(value); }
    private readonly BicepValue<EventHubsPrivateEndpointConnectionProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The geo-location where the resource lives.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent EventHubsNamespace.
    /// </summary>
    public EventHubsNamespace? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<EventHubsNamespace> _parent;

    /// <summary>
    /// Creates a new EventHubsPrivateEndpointConnection.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EventHubsPrivateEndpointConnection
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EventHubsPrivateEndpointConnection.</param>
    public EventHubsPrivateEndpointConnection(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.EventHub/namespaces/privateEndpointConnections", resourceVersion ?? "2024-01-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _connectionState = BicepValue<EventHubsPrivateLinkServiceConnectionState>.DefineProperty(this, "ConnectionState", ["properties", "privateLinkServiceConnectionState"]);
        _privateEndpointId = BicepValue<ResourceIdentifier>.DefineProperty(this, "PrivateEndpointId", ["properties", "privateEndpoint", "id"]);
        _provisioningState = BicepValue<EventHubsPrivateEndpointConnectionProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<EventHubsNamespace>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported EventHubsPrivateEndpointConnection resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-01-01.
        /// </summary>
        public static readonly string V2024_01_01 = "2024-01-01";

        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";
    }

    /// <summary>
    /// Creates a reference to an existing EventHubsPrivateEndpointConnection.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EventHubsPrivateEndpointConnection
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EventHubsPrivateEndpointConnection.</param>
    /// <returns>The existing EventHubsPrivateEndpointConnection resource.</returns>
    public static EventHubsPrivateEndpointConnection FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
