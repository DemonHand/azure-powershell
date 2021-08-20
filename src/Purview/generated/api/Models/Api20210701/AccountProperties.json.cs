namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>The account properties</summary>
    public partial class AccountProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonObject into a new instance of <see cref="AccountProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AccountProperties(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_cloudConnector = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonObject>("cloudConnectors"), out var __jsonCloudConnectors) ? Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.CloudConnectors.FromJson(__jsonCloudConnectors) : CloudConnector;}
            {_endpoint = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonObject>("endpoints"), out var __jsonEndpoints) ? Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.AccountEndpoints.FromJson(__jsonEndpoints) : Endpoint;}
            {_managedResource = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonObject>("managedResources"), out var __jsonManagedResources) ? Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ManagedResources.FromJson(__jsonManagedResources) : ManagedResource;}
            {_createdAt = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonString>("createdAt"), out var __jsonCreatedAt) ? global::System.DateTime.TryParse((string)__jsonCreatedAt, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonCreatedAtValue) ? __jsonCreatedAtValue : CreatedAt : CreatedAt;}
            {_createdBy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonString>("createdBy"), out var __jsonCreatedBy) ? (string)__jsonCreatedBy : (string)CreatedBy;}
            {_createdByObjectId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonString>("createdByObjectId"), out var __jsonCreatedByObjectId) ? (string)__jsonCreatedByObjectId : (string)CreatedByObjectId;}
            {_friendlyName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonString>("friendlyName"), out var __jsonFriendlyName) ? (string)__jsonFriendlyName : (string)FriendlyName;}
            {_managedResourceGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonString>("managedResourceGroupName"), out var __jsonManagedResourceGroupName) ? (string)__jsonManagedResourceGroupName : (string)ManagedResourceGroupName;}
            {_privateEndpointConnection = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonArray>("privateEndpointConnections"), out var __jsonPrivateEndpointConnections) ? If( __jsonPrivateEndpointConnections as Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection) (Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.PrivateEndpointConnection.FromJson(__u) )) ))() : null : PrivateEndpointConnection;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_publicNetworkAccess = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonString>("publicNetworkAccess"), out var __jsonPublicNetworkAccess) ? (string)__jsonPublicNetworkAccess : (string)PublicNetworkAccess;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonObject json ? new AccountProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AccountProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AccountProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._cloudConnector ? (Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonNode) this._cloudConnector.ToJson(null,serializationMode) : null, "cloudConnectors" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._endpoint ? (Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonNode) this._endpoint.ToJson(null,serializationMode) : null, "endpoints" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._managedResource ? (Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonNode) this._managedResource.ToJson(null,serializationMode) : null, "managedResources" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._createdAt ? (Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonString(this._createdAt?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "createdAt" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._createdBy)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonString(this._createdBy.ToString()) : null, "createdBy" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._createdByObjectId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonString(this._createdByObjectId.ToString()) : null, "createdByObjectId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._friendlyName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonString(this._friendlyName.ToString()) : null, "friendlyName" ,container.Add );
            }
            AddIf( null != (((object)this._managedResourceGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonString(this._managedResourceGroupName.ToString()) : null, "managedResourceGroupName" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._privateEndpointConnection)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.XNodeArray();
                    foreach( var __x in this._privateEndpointConnection )
                    {
                        AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                    }
                    container.Add("privateEndpointConnections",__w);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AddIf( null != (((object)this._publicNetworkAccess)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Json.JsonString(this._publicNetworkAccess.ToString()) : null, "publicNetworkAccess" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}