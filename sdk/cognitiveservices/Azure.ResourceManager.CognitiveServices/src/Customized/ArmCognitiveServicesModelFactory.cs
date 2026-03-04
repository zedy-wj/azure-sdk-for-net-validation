// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmCognitiveServicesModelFactory
    {
        /// <summary> (Deprecated) Initializes a new instance of <see cref="Models.CognitiveServicesAccountProperties"/>. </summary>
        public static CognitiveServicesAccountProperties CognitiveServicesAccountProperties(ServiceAccountProvisioningState? provisioningState = null, string endpoint = null, IEnumerable<CognitiveServicesSkuCapability> capabilities = null, bool? isMigrated = null, string migrationToken = null, CognitiveServicesSkuChangeInfo skuChangeInfo = null, string customSubDomainName = null, CognitiveServicesNetworkRuleSet networkAcls = null, ServiceAccountEncryptionProperties encryption = null, IEnumerable<ServiceAccountUserOwnedStorage> userOwnedStorage = null, UserOwnedAmlWorkspace amlWorkspace = null, IEnumerable<CognitiveServicesPrivateEndpointConnectionData> privateEndpointConnections = null, ServiceAccountPublicNetworkAccess? publicNetworkAccess = null, ServiceAccountApiProperties apiProperties = null, DateTimeOffset? createdOn = null, ServiceAccountCallRateLimit callRateLimit = null, bool? enableDynamicThrottling = null, bool? storedCompletionsDisabled = null, ServiceAccountQuotaLimit quotaLimit = null, bool? restrictOutboundNetworkAccess = null, IEnumerable<string> allowedFqdnList = null, bool? disableLocalAuth = null, IReadOnlyDictionary<string, string> endpoints = null, bool? restore = null, DateTimeOffset? deletedOn = null, string scheduledPurgeDate = null, CognitiveServicesMultiRegionSettings locations = null, IEnumerable<CommitmentPlanAssociation> commitmentPlanAssociations = null, AbusePenalty abusePenalty = null, RaiMonitorConfig raiMonitorConfig = null, AIFoundryNetworkInjection aiFoundryNetworkInjection = null, bool? allowProjectManagement = null, string defaultProject = null, IEnumerable<string> associatedProjects = null)
        {
            capabilities ??= new List<CognitiveServicesSkuCapability>();
            userOwnedStorage ??= new List<ServiceAccountUserOwnedStorage>();
            privateEndpointConnections ??= new List<CognitiveServicesPrivateEndpointConnectionData>();
            allowedFqdnList ??= new List<string>();
            endpoints ??= new Dictionary<string, string>();
            commitmentPlanAssociations ??= new List<CommitmentPlanAssociation>();
            associatedProjects ??= new List<string>();

            List<AIFoundryNetworkInjection> aiFoundryNetworkInjections = new List<AIFoundryNetworkInjection>();
            if (aiFoundryNetworkInjection != null)
            {
                aiFoundryNetworkInjections.Add(aiFoundryNetworkInjection);
            }

            return new CognitiveServicesAccountProperties(
                provisioningState,
                endpoint,
                capabilities?.ToList(),
                isMigrated,
                migrationToken,
                skuChangeInfo,
                customSubDomainName,
                networkAcls,
                encryption,
                userOwnedStorage?.ToList(),
                amlWorkspace,
                privateEndpointConnections?.ToList(),
                publicNetworkAccess,
                apiProperties,
                createdOn,
                callRateLimit,
                enableDynamicThrottling,
                storedCompletionsDisabled,
                quotaLimit,
                restrictOutboundNetworkAccess,
                allowedFqdnList?.ToList(),
                disableLocalAuth,
                endpoints,
                restore,
                deletedOn,
                scheduledPurgeDate,
                locations,
                commitmentPlanAssociations?.ToList(),
                abusePenalty,
                raiMonitorConfig,
                aiFoundryNetworkInjections?.ToList(),
                allowProjectManagement,
                defaultProject,
                associatedProjects?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServices.CognitiveServicesAccountData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="kind"> The Kind of the resource. </param>
        /// <param name="sku"> The resource model definition representing SKU. </param>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="properties"> Properties of Cognitive Services account. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <returns> A new <see cref="CognitiveServices.CognitiveServicesAccountData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static CognitiveServicesAccountData CognitiveServicesAccountData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string kind, CognitiveServicesSku sku, ManagedServiceIdentity identity, CognitiveServicesAccountProperties properties, ETag? etag)
        {
            return CognitiveServicesAccountData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                properties,
                etag,
                kind,
                sku,
                identity);
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServices.CognitiveServicesAccountDeploymentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sku"> The resource model definition representing SKU. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="properties"> Properties of Cognitive Services account deployment. </param>
        /// <returns> A new <see cref="CognitiveServices.CognitiveServicesAccountDeploymentData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static CognitiveServicesAccountDeploymentData CognitiveServicesAccountDeploymentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, CognitiveServicesSku sku = null, ETag? etag = null, IDictionary<string, string> tags = null, CognitiveServicesAccountDeploymentProperties properties = null)
        {
            return CognitiveServicesAccountDeploymentData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                sku,
                etag,
                tags);
        }

        /// <summary> Initializes a new instance of <see cref="T:Azure.ResourceManager.CognitiveServices.CognitiveServicesAccountDeploymentData" />. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sku"> The resource model definition representing SKU. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="properties"> Properties of Cognitive Services account deployment. </param>
        /// <returns> A new <see cref="T:Azure.ResourceManager.CognitiveServices.CognitiveServicesAccountDeploymentData" /> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static CognitiveServicesAccountDeploymentData CognitiveServicesAccountDeploymentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, CognitiveServicesSku sku, ETag? etag, CognitiveServicesAccountDeploymentProperties properties)
        {
            return CognitiveServicesAccountDeploymentData(id, name, resourceType, systemData, properties, sku, etag, tags: default);
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServices.CognitiveServicesEncryptionScopeData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="properties"> Properties of Cognitive Services EncryptionScope. </param>
        /// <returns> A new <see cref="CognitiveServices.CognitiveServicesEncryptionScopeData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static CognitiveServicesEncryptionScopeData CognitiveServicesEncryptionScopeData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, IDictionary<string, string> tags, CognitiveServicesEncryptionScopeProperties properties)
        {
            return CognitiveServicesEncryptionScopeData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                etag,
                tags);
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServices.CognitiveServicesPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The location of the private endpoint connection. </param>
        /// <param name="privateEndpointId"> The resource of private end point. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        /// <param name="groupIds"> The private link resource group ids. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <returns> A new <see cref="CognitiveServices.CognitiveServicesPrivateEndpointConnectionData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static CognitiveServicesPrivateEndpointConnectionData CognitiveServicesPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, ResourceIdentifier privateEndpointId, CognitiveServicesPrivateLinkServiceConnectionState connectionState, CognitiveServicesPrivateEndpointConnectionProvisioningState? provisioningState, IEnumerable<string> groupIds, ETag? etag)
        {
            return CognitiveServicesPrivateEndpointConnectionData(
                id,
                name,
                resourceType,
                systemData,
                etag,
                location,
                privateEndpointId,
                connectionState,
                provisioningState,
                groupIds?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServices.CognitiveServicesProjectData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="properties"> Properties of Cognitive Services project. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <returns> A new <see cref="CognitiveServices.CognitiveServicesProjectData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static CognitiveServicesProjectData CognitiveServicesProjectData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, CognitiveServicesProjectProperties properties, ETag? etag)
        {
            return CognitiveServicesProjectData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                properties,
                etag,
                identity);
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServices.CommitmentPlanData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="kind"> The Kind of the resource. </param>
        /// <param name="sku"> The resource model definition representing SKU. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="properties"> Properties of Cognitive Services account commitment plan. </param>
        /// <returns> A new <see cref="CognitiveServices.CommitmentPlanData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static CommitmentPlanData CommitmentPlanData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, string kind, CognitiveServicesSku sku, IDictionary<string, string> tags, AzureLocation? location, CommitmentPlanProperties properties)
        {
            return CommitmentPlanData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                tags,
                location,
                etag,
                kind,
                sku);
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServices.RaiBlocklistData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="raiBlocklistDescription"> Properties of Cognitive Services RaiBlocklist. </param>
        /// <returns> A new <see cref="CognitiveServices.RaiBlocklistData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static RaiBlocklistData RaiBlocklistData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, IDictionary<string, string> tags, string raiBlocklistDescription)
        {
            return RaiBlocklistData(
                id,
                name,
                resourceType,
                systemData,
                raiBlocklistDescription,
                etag,
                tags);
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServices.RaiBlocklistItemData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="properties"> Properties of Cognitive Services RaiBlocklist Item. </param>
        /// <returns> A new <see cref="CognitiveServices.RaiBlocklistItemData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static RaiBlocklistItemData RaiBlocklistItemData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, IDictionary<string, string> tags, RaiBlocklistItemProperties properties)
        {
            return RaiBlocklistItemData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                etag,
                tags);
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServices.RaiPolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="properties"> Properties of Cognitive Services RaiPolicy. </param>
        /// <returns> A new <see cref="CognitiveServices.RaiPolicyData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static RaiPolicyData RaiPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, IDictionary<string, string> tags, RaiPolicyProperties properties)
        {
            return RaiPolicyData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                etag,
                tags);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CognitiveServicesAccountProperties"/>. </summary>
        /// <param name="provisioningState"> Gets the status of the cognitive services account at the time the operation was called. </param>
        /// <param name="endpoint"> Endpoint of the created account. </param>
        /// <param name="capabilities"> Gets the capabilities of the cognitive services account. Each item indicates the capability of a specific feature. The values are read-only and for reference only. </param>
        /// <param name="isMigrated"> If the resource is migrated from an existing key. </param>
        /// <param name="migrationToken"> Resource migration token. </param>
        /// <param name="skuChangeInfo"> Sku change info of account. </param>
        /// <param name="customSubDomainName"> Optional subdomain name used for token-based authentication. </param>
        /// <param name="networkAcls"> A collection of rules governing the accessibility from specific network locations. </param>
        /// <param name="encryption"> The encryption properties for this resource. </param>
        /// <param name="userOwnedStorage"> The storage accounts for this resource. </param>
        /// <param name="amlWorkspace"> The user owned AML account properties. </param>
        /// <param name="privateEndpointConnections"> The private endpoint connection associated with the Cognitive Services account. </param>
        /// <param name="publicNetworkAccess"> Whether or not public endpoint access is allowed for this account. </param>
        /// <param name="apiProperties"> The api properties for special APIs. </param>
        /// <param name="createdOn"> Gets the date of cognitive services account creation. </param>
        /// <param name="callRateLimit"> The call rate limit Cognitive Services account. </param>
        /// <param name="enableDynamicThrottling"> The flag to enable dynamic throttling. </param>
        /// <param name="quotaLimit"></param>
        /// <param name="restrictOutboundNetworkAccess"></param>
        /// <param name="allowedFqdnList"></param>
        /// <param name="disableLocalAuth"></param>
        /// <param name="endpoints"> Dictionary of &lt;string&gt;. </param>
        /// <param name="restore"></param>
        /// <param name="deletedOn"> The deletion date, only available for deleted account. </param>
        /// <param name="scheduledPurgeDate"> The scheduled purge date, only available for deleted account. </param>
        /// <param name="locations"> The multiregion settings of Cognitive Services account. </param>
        /// <param name="commitmentPlanAssociations"> The commitment plan associations of Cognitive Services account. </param>
        /// <param name="abusePenalty"> The abuse penalty. </param>
        /// <param name="raiMonitorConfig"> Cognitive Services Rai Monitor Config. </param>
        /// <param name="aiFoundryNetworkInjections"></param>
        /// <param name="allowProjectManagement"> Specifies whether this resource support project management as child resources, used as containers for access management, data isolation and cost in AI Foundry. </param>
        /// <param name="defaultProject"> Specifies the project, by project name, that is targeted when data plane endpoints are called without a project parameter. </param>
        /// <param name="associatedProjects"> Specifies the projects, by project name, that are associated with this resource. </param>
        /// <returns> A new <see cref="Models.CognitiveServicesAccountProperties"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static CognitiveServicesAccountProperties CognitiveServicesAccountProperties(ServiceAccountProvisioningState? provisioningState, string endpoint, IEnumerable<CognitiveServicesSkuCapability> capabilities, bool? isMigrated, string migrationToken, CognitiveServicesSkuChangeInfo skuChangeInfo, string customSubDomainName, CognitiveServicesNetworkRuleSet networkAcls, ServiceAccountEncryptionProperties encryption, IEnumerable<ServiceAccountUserOwnedStorage> userOwnedStorage, UserOwnedAmlWorkspace amlWorkspace, IEnumerable<CognitiveServicesPrivateEndpointConnectionData> privateEndpointConnections, ServiceAccountPublicNetworkAccess? publicNetworkAccess, ServiceAccountApiProperties apiProperties, DateTimeOffset? createdOn, ServiceAccountCallRateLimit callRateLimit, bool? enableDynamicThrottling, ServiceAccountQuotaLimit quotaLimit, bool? restrictOutboundNetworkAccess, IEnumerable<string> allowedFqdnList, bool? disableLocalAuth, IReadOnlyDictionary<string, string> endpoints, bool? restore, DateTimeOffset? deletedOn, string scheduledPurgeDate, CognitiveServicesMultiRegionSettings locations, IEnumerable<CommitmentPlanAssociation> commitmentPlanAssociations, AbusePenalty abusePenalty, RaiMonitorConfig raiMonitorConfig, AIFoundryNetworkInjection aiFoundryNetworkInjections, bool? allowProjectManagement, string defaultProject, IEnumerable<string> associatedProjects)
        {
            return CognitiveServicesAccountProperties(
                provisioningState,
                endpoint,
                capabilities?.ToList(),
                isMigrated,
                migrationToken,
                skuChangeInfo,
                customSubDomainName,
                networkAcls,
                encryption,
                userOwnedStorage?.ToList(),
                amlWorkspace,
                privateEndpointConnections?.ToList(),
                publicNetworkAccess,
                apiProperties,
                createdOn,
                callRateLimit,
                enableDynamicThrottling,
                default,
                quotaLimit,
                restrictOutboundNetworkAccess,
                allowedFqdnList?.ToList(),
                disableLocalAuth,
                endpoints,
                restore,
                deletedOn,
                scheduledPurgeDate,
                locations,
                commitmentPlanAssociations?.ToList(),
                abusePenalty,
                raiMonitorConfig,
                aiFoundryNetworkInjections,
                allowProjectManagement,
                defaultProject,
                associatedProjects?.ToList());
        }
    }
}
