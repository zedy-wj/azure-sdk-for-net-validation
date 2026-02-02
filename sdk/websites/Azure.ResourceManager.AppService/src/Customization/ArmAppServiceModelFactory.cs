// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmAppServiceModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.ResourceNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Resource name to verify. </param>
        /// <param name="resourceType"> Resource type used for verification. </param>
        /// <param name="isFqdn"> Is fully qualified domain name. </param>
        /// <param name="environmentId"> Azure Resource Manager ID of the customer's selected Container Apps Environment on which to host the Function app. This must be of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.App/managedEnvironments/{managedEnvironmentName}. </param>
        /// <returns> A new <see cref="Models.ResourceNameAvailabilityContent"/> instance for mocking. </returns>
        public static ResourceNameAvailabilityContent ResourceNameAvailabilityContent(string name, CheckNameResourceType resourceType, bool? isFqdn, string environmentId)
        {
            return new ResourceNameAvailabilityContent(name, resourceType, isFqdn, environmentId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ResourceNameAvailability"/>. </summary>
        /// <param name="isNameAvailable"> &lt;code&gt;true&lt;/code&gt; indicates name is valid and available. &lt;code&gt;false&lt;/code&gt; indicates the name is invalid, unavailable, or both. </param>
        /// <param name="reason"> &lt;code&gt;Invalid&lt;/code&gt; indicates the name provided does not match Azure App Service naming requirements. &lt;code&gt;AlreadyExists&lt;/code&gt; indicates that the name is already in use and is therefore unavailable. </param>
        /// <param name="message"> If reason == invalid, provide the user with the reason why the given name is invalid, and provide the resource naming requirements so that the user can select a valid name. If reason == AlreadyExists, explain that resource name is already in use, and direct them to select a different name. </param>
        /// <returns> A new <see cref="Models.ResourceNameAvailability"/> instance for mocking. </returns>
        public static ResourceNameAvailability ResourceNameAvailability(bool? isNameAvailable, InAvailabilityReasonType? reason, string message)
        {
            return new ResourceNameAvailability(isNameAvailable, reason, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.WebSiteData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Managed service identity. </param>
        /// <param name="extendedLocation"> Extended Location. </param>
        /// <param name="state"> Current state of the app. </param>
        /// <param name="hostNames"> Hostnames associated with the app. </param>
        /// <param name="repositorySiteName"> Name of the repository site. </param>
        /// <param name="usageState"> State indicating whether the app has exceeded its quota usage. Read-only. </param>
        /// <param name="isEnabled"> &lt;code&gt;true&lt;/code&gt; if the app is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. Setting this value to false disables the app (takes the app offline). </param>
        /// <param name="enabledHostNames">
        /// Enabled hostnames for the app.Hostnames need to be assigned (see HostNames) AND enabled. Otherwise,
        /// the app is not served on those hostnames.
        /// </param>
        /// <param name="availabilityState"> Management information availability state for the app. </param>
        /// <param name="hostNameSslStates"> Hostname SSL states are used to manage the SSL bindings for app's hostnames. </param>
        /// <param name="appServicePlanId"> Resource ID of the associated App Service plan, formatted as: "/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}". </param>
        /// <param name="isReserved"> &lt;code&gt;true&lt;/code&gt; if reserved; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isXenon"> Obsolete: Hyper-V sandbox. </param>
        /// <param name="isHyperV"> Hyper-V sandbox. </param>
        /// <param name="lastModifiedTimeUtc"> Last time the app was modified, in UTC. Read-only. </param>
        /// <param name="dnsConfiguration"> Property to configure various DNS related settings for a site. </param>
        /// <param name="isVnetRouteAllEnabled"> Virtual Network Route All enabled. This causes all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied. </param>
        /// <param name="isVnetImagePullEnabled"> To enable pulling image over Virtual Network. </param>
        /// <param name="isVnetContentShareEnabled"> To enable accessing content over virtual network. </param>
        /// <param name="isVnetBackupRestoreEnabled"> To enable Backup and Restore operations over virtual network. </param>
        /// <param name="siteConfig"> Configuration of the app. </param>
        /// <param name="functionAppConfig"> Configuration specific of the Azure Function app. </param>
        /// <param name="daprConfig"> Dapr configuration of the app. </param>
        /// <param name="workloadProfileName"> Workload profile name for function app to execute on. </param>
        /// <param name="resourceConfig"> Function app resource requirements. </param>
        /// <param name="trafficManagerHostNames"> Azure Traffic Manager hostnames associated with the app. Read-only. </param>
        /// <param name="isScmSiteAlsoStopped"> &lt;code&gt;true&lt;/code&gt; to stop SCM (KUDU) site when the app is stopped; otherwise, &lt;code&gt;false&lt;/code&gt;. The default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="targetSwapSlot"> Specifies which deployment slot this app will swap into. Read-only. </param>
        /// <param name="hostingEnvironmentProfile"> App Service Environment to use for the app. </param>
        /// <param name="isClientAffinityEnabled"> &lt;code&gt;true&lt;/code&gt; to enable client affinity; &lt;code&gt;false&lt;/code&gt; to stop sending session affinity cookies, which route client requests in the same session to the same instance. Default is &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="isClientCertEnabled"> &lt;code&gt;true&lt;/code&gt; to enable client certificate authentication (TLS mutual authentication); otherwise, &lt;code&gt;false&lt;/code&gt;. Default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="clientCertMode">
        /// This composes with ClientCertEnabled setting.
        /// - ClientCertEnabled: false means ClientCert is ignored.
        /// - ClientCertEnabled: true and ClientCertMode: Required means ClientCert is required.
        /// - ClientCertEnabled: true and ClientCertMode: Optional means ClientCert is optional or accepted.
        /// </param>
        /// <param name="clientCertExclusionPaths"> client certificate authentication comma-separated exclusion paths. </param>
        /// <param name="ipMode"> Specifies the IP mode of the app. </param>
        /// <param name="isEndToEndEncryptionEnabled"> Whether to use end to end encryption between the FrontEnd and the Worker. </param>
        /// <param name="isHostNameDisabled">
        /// &lt;code&gt;true&lt;/code&gt; to disable the public hostnames of the app; otherwise, &lt;code&gt;false&lt;/code&gt;.
        ///  If &lt;code&gt;true&lt;/code&gt;, the app is only accessible via API management process.
        /// </param>
        /// <param name="customDomainVerificationId"> Unique identifier that verifies the custom domains assigned to the app. Customer will add this id to a txt record for verification. </param>
        /// <param name="outboundIPAddresses"> List of IP addresses that the app uses for outbound connections (e.g. database access). Includes VIPs from tenants that site can be hosted with current settings. Read-only. </param>
        /// <param name="possibleOutboundIPAddresses"> List of IP addresses that the app uses for outbound connections (e.g. database access). Includes VIPs from all tenants except dataComponent. Read-only. </param>
        /// <param name="containerSize"> Size of the function container. </param>
        /// <param name="dailyMemoryTimeQuota"> Maximum allowed daily memory-time quota (applicable on dynamic apps only). </param>
        /// <param name="suspendOn"> App suspended till in case memory-time quota is exceeded. </param>
        /// <param name="maxNumberOfWorkers">
        /// Maximum number of workers.
        /// This only applies to Functions container.
        /// </param>
        /// <param name="cloningInfo"> If specified during app creation, the app is cloned from a source app. </param>
        /// <param name="resourceGroup"> Name of the resource group the app belongs to. Read-only. </param>
        /// <param name="isDefaultContainer"> &lt;code&gt;true&lt;/code&gt; if the app is a default container; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="defaultHostName"> Default hostname of the app. Read-only. </param>
        /// <param name="slotSwapStatus"> Status of the last deployment slot swap operation. </param>
        /// <param name="isHttpsOnly">
        /// HttpsOnly: configures a web site to accept only https requests. Issues redirect for
        /// http requests
        /// </param>
        /// <param name="redundancyMode"> Site redundancy mode. </param>
        /// <param name="inProgressOperationId"> Specifies an operation id if this site has a pending operation. </param>
        /// <param name="publicNetworkAccess"> Property to allow or block all public traffic. Allowed Values: 'Enabled', 'Disabled' or an empty string. </param>
        /// <param name="isStorageAccountRequired"> Checks if Customer provided storage account is required. </param>
        /// <param name="keyVaultReferenceIdentity"> Identity to use for Key Vault Reference authentication. </param>
        /// <param name="autoGeneratedDomainNameLabelScope"> Specifies the scope of uniqueness for the default hostname during resource creation. </param>
        /// <param name="virtualNetworkSubnetId">
        /// Azure Resource Manager ID of the Virtual network and subnet to be joined by Regional VNET Integration.
        /// This must be of the form /subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}
        /// </param>
        /// <param name="managedEnvironmentId"> Azure Resource Manager ID of the customer's selected Managed Environment on which to host this app. This must be of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.App/managedEnvironments/{managedEnvironmentName}. </param>
        /// <param name="sku"> Current SKU of application based on associated App Service Plan. Some valid SKU values are Free, Shared, Basic, Dynamic, FlexConsumption, Standard, Premium, PremiumV2, PremiumV3, Isolated, IsolatedV2. </param>
        /// <param name="kind"> Kind of resource. If the resource is an app, you can refer to https://github.com/Azure/app-service-linux-docs/blob/master/Things_You_Should_Know/kind_property.md#app-service-resource-kind-reference for details supported values for kind. </param>
        /// <returns> A new <see cref="AppService.WebSiteData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static WebSiteData WebSiteData(ResourceIdentifier id, string name, ResourceType resourceType, ResourceManager.Models.SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, ExtendedLocation extendedLocation, string state, IEnumerable<string> hostNames, string repositorySiteName, AppServiceUsageState? usageState, bool? isEnabled, IEnumerable<string> enabledHostNames, WebSiteAvailabilityState? availabilityState, IEnumerable<HostNameSslState> hostNameSslStates, ResourceIdentifier appServicePlanId, bool? isReserved, bool? isXenon, bool? isHyperV, DateTimeOffset? lastModifiedTimeUtc, SiteDnsConfig dnsConfiguration, bool? isVnetRouteAllEnabled, bool? isVnetImagePullEnabled, bool? isVnetContentShareEnabled, bool? isVnetBackupRestoreEnabled, SiteConfigProperties siteConfig, FunctionAppConfig functionAppConfig, AppDaprConfig daprConfig, string workloadProfileName, FunctionAppResourceConfig resourceConfig, IEnumerable<string> trafficManagerHostNames, bool? isScmSiteAlsoStopped, string targetSwapSlot, HostingEnvironmentProfile hostingEnvironmentProfile, bool? isClientAffinityEnabled, bool? isClientCertEnabled, ClientCertMode? clientCertMode, string clientCertExclusionPaths, AppServiceIPMode? ipMode, bool? isEndToEndEncryptionEnabled, bool? isHostNameDisabled, string customDomainVerificationId, string outboundIPAddresses, string possibleOutboundIPAddresses, int? containerSize, int? dailyMemoryTimeQuota, DateTimeOffset? suspendOn, int? maxNumberOfWorkers, CloningInfo cloningInfo, string resourceGroup, bool? isDefaultContainer, string defaultHostName, SlotSwapStatus slotSwapStatus, bool? isHttpsOnly, RedundancyMode? redundancyMode, Guid? inProgressOperationId, string publicNetworkAccess, bool? isStorageAccountRequired, string keyVaultReferenceIdentity, AutoGeneratedDomainNameLabelScope? autoGeneratedDomainNameLabelScope, ResourceIdentifier virtualNetworkSubnetId, string managedEnvironmentId, string sku, string kind)
            => WebSiteData(id, name, resourceType, systemData, tags, location, identity, extendedLocation, kind, state, hostNames, repositorySiteName, usageState,
                            isEnabled, enabledHostNames, availabilityState, hostNameSslStates, appServicePlanId, isReserved, isXenon, isHyperV, lastModifiedTimeUtc, dnsConfiguration,
                            new OutboundVnetRouting() { IsAllTrafficEnabled = isVnetRouteAllEnabled, IsContentShareTrafficEnabled = isVnetContentShareEnabled, IsImagePullTrafficEnabled = isVnetImagePullEnabled, IsBackupRestoreTrafficEnabled = isVnetBackupRestoreEnabled },
                            siteConfig, functionAppConfig, daprConfig, workloadProfileName, resourceConfig, trafficManagerHostNames, isScmSiteAlsoStopped, targetSwapSlot,
                            hostingEnvironmentProfile, isClientAffinityEnabled, null, null, isClientCertEnabled, clientCertMode, clientCertExclusionPaths,
                            ipMode, isEndToEndEncryptionEnabled, null, isHostNameDisabled, customDomainVerificationId, outboundIPAddresses, possibleOutboundIPAddresses, containerSize, dailyMemoryTimeQuota, suspendOn,
                            maxNumberOfWorkers, cloningInfo, resourceGroup, isDefaultContainer, defaultHostName, slotSwapStatus, isHttpsOnly, redundancyMode, inProgressOperationId, publicNetworkAccess,
                            isStorageAccountRequired, keyVaultReferenceIdentity, autoGeneratedDomainNameLabelScope, virtualNetworkSubnetId, managedEnvironmentId, sku);

        /// <summary> Initializes a new instance of <see cref="T:Azure.ResourceManager.AppService.WebSiteData" />. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Managed service identity. </param>
        /// <param name="extendedLocation"> Extended Location. </param>
        /// <param name="state"> Current state of the app. </param>
        /// <param name="hostNames"> Hostnames associated with the app. </param>
        /// <param name="repositorySiteName"> Name of the repository site. </param>
        /// <param name="usageState"> State indicating whether the app has exceeded its quota usage. Read-only. </param>
        /// <param name="isEnabled"> &lt;code&gt;true&lt;/code&gt; if the app is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. Setting this value to false disables the app (takes the app offline). </param>
        /// <param name="enabledHostNames">
        /// Enabled hostnames for the app.Hostnames need to be assigned (see HostNames) AND enabled. Otherwise,
        /// the app is not served on those hostnames.
        /// </param>
        /// <param name="availabilityState"> Management information availability state for the app. </param>
        /// <param name="hostNameSslStates"> Hostname SSL states are used to manage the SSL bindings for app's hostnames. </param>
        /// <param name="appServicePlanId"> Resource ID of the associated App Service plan, formatted as: "/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}". </param>
        /// <param name="isReserved"> &lt;code&gt;true&lt;/code&gt; if reserved; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isXenon"> Obsolete: Hyper-V sandbox. </param>
        /// <param name="isHyperV"> Hyper-V sandbox. </param>
        /// <param name="lastModifiedTimeUtc"> Last time the app was modified, in UTC. Read-only. </param>
        /// <param name="dnsConfiguration"> Property to configure various DNS related settings for a site. </param>
        /// <param name="isVnetRouteAllEnabled"> Virtual Network Route All enabled. This causes all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied. </param>
        /// <param name="isVnetImagePullEnabled"> To enable pulling image over Virtual Network. </param>
        /// <param name="isVnetContentShareEnabled"> To enable accessing content over virtual network. </param>
        /// <param name="isVnetBackupRestoreEnabled"> To enable Backup and Restore operations over virtual network. </param>
        /// <param name="siteConfig"> Configuration of the app. </param>
        /// <param name="functionAppConfig"> Configuration specific of the Azure Function app. </param>
        /// <param name="daprConfig"> Dapr configuration of the app. </param>
        /// <param name="workloadProfileName"> Workload profile name for function app to execute on. </param>
        /// <param name="resourceConfig"> Function app resource requirements. </param>
        /// <param name="trafficManagerHostNames"> Azure Traffic Manager hostnames associated with the app. Read-only. </param>
        /// <param name="isScmSiteAlsoStopped"> &lt;code&gt;true&lt;/code&gt; to stop SCM (KUDU) site when the app is stopped; otherwise, &lt;code&gt;false&lt;/code&gt;. The default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="targetSwapSlot"> Specifies which deployment slot this app will swap into. Read-only. </param>
        /// <param name="hostingEnvironmentProfile"> App Service Environment to use for the app. </param>
        /// <param name="isClientAffinityEnabled"> &lt;code&gt;true&lt;/code&gt; to enable client affinity; &lt;code&gt;false&lt;/code&gt; to stop sending session affinity cookies, which route client requests in the same session to the same instance. Default is &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="isClientCertEnabled"> &lt;code&gt;true&lt;/code&gt; to enable client certificate authentication (TLS mutual authentication); otherwise, &lt;code&gt;false&lt;/code&gt;. Default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="clientCertMode">
        /// This composes with ClientCertEnabled setting.
        /// - ClientCertEnabled: false means ClientCert is ignored.
        /// - ClientCertEnabled: true and ClientCertMode: Required means ClientCert is required.
        /// - ClientCertEnabled: true and ClientCertMode: Optional means ClientCert is optional or accepted.
        /// </param>
        /// <param name="clientCertExclusionPaths"> client certificate authentication comma-separated exclusion paths. </param>
        /// <param name="isHostNameDisabled">
        /// &lt;code&gt;true&lt;/code&gt; to disable the public hostnames of the app; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// If &lt;code&gt;true&lt;/code&gt;, the app is only accessible via API management process.
        /// </param>
        /// <param name="customDomainVerificationId"> Unique identifier that verifies the custom domains assigned to the app. Customer will add this id to a txt record for verification. </param>
        /// <param name="outboundIPAddresses"> List of IP addresses that the app uses for outbound connections (e.g. database access). Includes VIPs from tenants that site can be hosted with current settings. Read-only. </param>
        /// <param name="possibleOutboundIPAddresses"> List of IP addresses that the app uses for outbound connections (e.g. database access). Includes VIPs from all tenants except dataComponent. Read-only. </param>
        /// <param name="containerSize"> Size of the function container. </param>
        /// <param name="dailyMemoryTimeQuota"> Maximum allowed daily memory-time quota (applicable on dynamic apps only). </param>
        /// <param name="suspendOn"> App suspended till in case memory-time quota is exceeded. </param>
        /// <param name="maxNumberOfWorkers">
        /// Maximum number of workers.
        /// This only applies to Functions container.
        /// </param>
        /// <param name="cloningInfo"> If specified during app creation, the app is cloned from a source app. </param>
        /// <param name="resourceGroup"> Name of the resource group the app belongs to. Read-only. </param>
        /// <param name="isDefaultContainer"> &lt;code&gt;true&lt;/code&gt; if the app is a default container; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="defaultHostName"> Default hostname of the app. Read-only. </param>
        /// <param name="slotSwapStatus"> Status of the last deployment slot swap operation. </param>
        /// <param name="isHttpsOnly">
        /// HttpsOnly: configures a web site to accept only https requests. Issues redirect for
        /// http requests
        /// </param>
        /// <param name="redundancyMode"> Site redundancy mode. </param>
        /// <param name="inProgressOperationId"> Specifies an operation id if this site has a pending operation. </param>
        /// <param name="publicNetworkAccess"> Property to allow or block all public traffic. Allowed Values: 'Enabled', 'Disabled' or an empty string. </param>
        /// <param name="isStorageAccountRequired"> Checks if Customer provided storage account is required. </param>
        /// <param name="keyVaultReferenceIdentity"> Identity to use for Key Vault Reference authentication. </param>
        /// <param name="virtualNetworkSubnetId">
        /// Azure Resource Manager ID of the Virtual network and subnet to be joined by Regional VNET Integration.
        /// This must be of the form /subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}
        /// </param>
        /// <param name="managedEnvironmentId"> Azure Resource Manager ID of the customer's selected Managed Environment on which to host this app. This must be of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.App/managedEnvironments/{managedEnvironmentName}. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="T:Azure.ResourceManager.AppService.WebSiteData" /> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static WebSiteData WebSiteData(ResourceIdentifier id, string name, ResourceType resourceType, ResourceManager.Models.SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, ExtendedLocation extendedLocation, string state, IEnumerable<string> hostNames, string repositorySiteName, AppServiceUsageState? usageState, bool? isEnabled, IEnumerable<string> enabledHostNames, WebSiteAvailabilityState? availabilityState, IEnumerable<HostNameSslState> hostNameSslStates, ResourceIdentifier appServicePlanId, bool? isReserved, bool? isXenon, bool? isHyperV, DateTimeOffset? lastModifiedTimeUtc, SiteDnsConfig dnsConfiguration, bool? isVnetRouteAllEnabled, bool? isVnetImagePullEnabled, bool? isVnetContentShareEnabled, bool? isVnetBackupRestoreEnabled, SiteConfigProperties siteConfig, FunctionAppConfig functionAppConfig, AppDaprConfig daprConfig, string workloadProfileName, FunctionAppResourceConfig resourceConfig, IEnumerable<string> trafficManagerHostNames, bool? isScmSiteAlsoStopped, string targetSwapSlot, HostingEnvironmentProfile hostingEnvironmentProfile, bool? isClientAffinityEnabled, bool? isClientCertEnabled, ClientCertMode? clientCertMode, string clientCertExclusionPaths, bool? isHostNameDisabled, string customDomainVerificationId, string outboundIPAddresses, string possibleOutboundIPAddresses, int? containerSize, int? dailyMemoryTimeQuota, DateTimeOffset? suspendOn, int? maxNumberOfWorkers, CloningInfo cloningInfo, string resourceGroup, bool? isDefaultContainer, string defaultHostName, SlotSwapStatus slotSwapStatus, bool? isHttpsOnly, RedundancyMode? redundancyMode, Guid? inProgressOperationId, string publicNetworkAccess, bool? isStorageAccountRequired, string keyVaultReferenceIdentity, ResourceIdentifier virtualNetworkSubnetId, string managedEnvironmentId, string kind)
        {
            return WebSiteData(id: id, name: name, resourceType: resourceType, systemData: systemData, tags: tags, location: location, identity: identity, extendedLocation: extendedLocation, state: state, hostNames: hostNames, repositorySiteName: repositorySiteName, usageState: usageState, isEnabled: isEnabled, enabledHostNames: enabledHostNames, availabilityState: availabilityState, hostNameSslStates: hostNameSslStates, appServicePlanId: appServicePlanId, isReserved: isReserved, isXenon: isXenon, isHyperV: isHyperV, lastModifiedTimeUtc: lastModifiedTimeUtc, dnsConfiguration: dnsConfiguration, isVnetRouteAllEnabled: isVnetRouteAllEnabled, isVnetImagePullEnabled: isVnetImagePullEnabled, isVnetContentShareEnabled: isVnetContentShareEnabled, isVnetBackupRestoreEnabled: isVnetBackupRestoreEnabled, siteConfig: siteConfig, functionAppConfig: functionAppConfig, daprConfig: daprConfig, workloadProfileName: workloadProfileName, resourceConfig: resourceConfig, trafficManagerHostNames: trafficManagerHostNames, isScmSiteAlsoStopped: isScmSiteAlsoStopped, targetSwapSlot: targetSwapSlot, hostingEnvironmentProfile: hostingEnvironmentProfile, isClientAffinityEnabled: isClientAffinityEnabled, isClientCertEnabled: isClientCertEnabled, clientCertMode: clientCertMode, clientCertExclusionPaths: clientCertExclusionPaths, ipMode: default, isEndToEndEncryptionEnabled: default, isHostNameDisabled: isHostNameDisabled, customDomainVerificationId: customDomainVerificationId, outboundIPAddresses: outboundIPAddresses, possibleOutboundIPAddresses: possibleOutboundIPAddresses, containerSize: containerSize, dailyMemoryTimeQuota: dailyMemoryTimeQuota, suspendOn: suspendOn, maxNumberOfWorkers: maxNumberOfWorkers, cloningInfo: cloningInfo, resourceGroup: resourceGroup, isDefaultContainer: isDefaultContainer, defaultHostName: defaultHostName, slotSwapStatus: slotSwapStatus, isHttpsOnly: isHttpsOnly, redundancyMode: redundancyMode, inProgressOperationId: inProgressOperationId, publicNetworkAccess: publicNetworkAccess, isStorageAccountRequired: isStorageAccountRequired, keyVaultReferenceIdentity: keyVaultReferenceIdentity, autoGeneratedDomainNameLabelScope: default, virtualNetworkSubnetId: virtualNetworkSubnetId, managedEnvironmentId: managedEnvironmentId, sku: default, kind: kind);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.AppCertificateData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="password"> Certificate password. </param>
        /// <param name="friendlyName"> Friendly name of the certificate. </param>
        /// <param name="subjectName"> Subject name of the certificate. </param>
        /// <param name="hostNames"> Host names the certificate applies to. </param>
        /// <param name="pfxBlob"> Pfx blob. </param>
        /// <param name="siteName"> App name. </param>
        /// <param name="selfLink"> Self link. </param>
        /// <param name="issuer"> Certificate issuer. </param>
        /// <param name="issueOn"> Certificate issue Date. </param>
        /// <param name="expireOn"> Certificate expiration date. </param>
        /// <param name="thumbprintString"> Certificate thumbprint. </param>
        /// <param name="isValid"> Is the certificate valid?. </param>
        /// <param name="cerBlob"> Raw bytes of .cer file. </param>
        /// <param name="publicKeyHash"> Public key hash. </param>
        /// <param name="hostingEnvironmentProfile"> Specification for the App Service Environment to use for the certificate. </param>
        /// <param name="keyVaultId"> Azure Key Vault Csm resource Id. </param>
        /// <param name="keyVaultSecretName"> Azure Key Vault secret name. </param>
        /// <param name="keyVaultSecretStatus"> Status of the Key Vault secret. </param>
        /// <param name="serverFarmId"> Resource ID of the associated App Service plan. </param>
        /// <param name="canonicalName"> CNAME of the certificate to be issued via free certificate. </param>
        /// <param name="domainValidationMethod"> Method of domain validation for free cert. </param>
        /// <param name="kind"> Kind of resource. If the resource is an app, you can refer to https://github.com/Azure/app-service-linux-docs/blob/master/Things_You_Should_Know/kind_property.md#app-service-resource-kind-reference for details supported values for kind. </param>
        /// <returns> A new <see cref="AppService.AppCertificateData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static AppCertificateData AppCertificateData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string password = null, string friendlyName = null, string subjectName = null, IEnumerable<string> hostNames = null, byte[] pfxBlob = null, string siteName = null, string selfLink = null, string issuer = null, DateTimeOffset? issueOn = null, DateTimeOffset? expireOn = null, string thumbprintString = null, bool? isValid = null, byte[] cerBlob = null, string publicKeyHash = null, HostingEnvironmentProfile hostingEnvironmentProfile = null, ResourceIdentifier keyVaultId = null, string keyVaultSecretName = null, KeyVaultSecretStatus? keyVaultSecretStatus = null, ResourceIdentifier serverFarmId = null, string canonicalName = null, string domainValidationMethod = null, string kind = null)
        {
            tags ??= new Dictionary<string, string>();
            hostNames ??= new List<string>();

            return new AppCertificateData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                kind,
                password,
                friendlyName,
                subjectName,
                hostNames?.ToList(),
                pfxBlob,
                siteName,
                selfLink,
                issuer,
                issueOn,
                expireOn,
                thumbprintString,
                isValid,
                cerBlob,
                publicKeyHash,
                hostingEnvironmentProfile,
                keyVaultId,
                keyVaultSecretName,
                keyVaultSecretStatus,
                serverFarmId,
                canonicalName,
                domainValidationMethod,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.ApiKeyVaultReferenceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="reference"></param>
        /// <param name="status"></param>
        /// <param name="vaultName"></param>
        /// <param name="secretName"></param>
        /// <param name="secretVersion"></param>
        /// <param name="identity"> Managed service identity. </param>
        /// <param name="details"></param>
        /// <param name="source"></param>
        /// <param name="activeVersion"></param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.ApiKeyVaultReferenceData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static ApiKeyVaultReferenceData ApiKeyVaultReferenceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string reference = null, ResolveStatus? status = null, string vaultName = null, string secretName = null, string secretVersion = null, ManagedServiceIdentity identity = null, string details = null, ConfigReferenceSource? source = null, string activeVersion = null, string kind = null)
        {
            return new ApiKeyVaultReferenceData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                reference,
                status,
                vaultName,
                secretName,
                secretVersion,
                identity,
                details,
                source,
                activeVersion,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.AppServiceCertificateData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="keyVaultId"> Key Vault resource Id. </param>
        /// <param name="keyVaultSecretName"> Key Vault secret name. </param>
        /// <param name="provisioningState"> Status of the Key Vault secret. </param>
        /// <param name="kind"> Kind of resource. If the resource is an app, you can refer to https://github.com/Azure/app-service-linux-docs/blob/master/Things_You_Should_Know/kind_property.md#app-service-resource-kind-reference for details supported values for kind. </param>
        /// <returns> A new <see cref="AppService.AppServiceCertificateData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static AppServiceCertificateData AppServiceCertificateData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ResourceIdentifier keyVaultId = null, string keyVaultSecretName = null, KeyVaultSecretStatus? provisioningState = null, string kind = null)
        {
            tags ??= new Dictionary<string, string>();

            return new AppServiceCertificateData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                kind,
                keyVaultId,
                keyVaultSecretName,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.AppServiceCertificateOrderData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="certificates"> State of the Key Vault secret. </param>
        /// <param name="distinguishedName"> Certificate distinguished name. </param>
        /// <param name="domainVerificationToken"> Domain verification token. </param>
        /// <param name="validityInYears"> Duration in years (must be 1). </param>
        /// <param name="keySize"> Certificate key size. </param>
        /// <param name="productType"> Certificate product type. </param>
        /// <param name="isAutoRenew"> &lt;code&gt;true&lt;/code&gt; if the certificate should be automatically renewed when it expires; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="provisioningState"> Status of certificate order. </param>
        /// <param name="status"> Current order status. </param>
        /// <param name="signedCertificate"> Signed certificate. </param>
        /// <param name="csr"> Last CSR that was created for this order. </param>
        /// <param name="intermediate"> Intermediate certificate. </param>
        /// <param name="root"> Root certificate. </param>
        /// <param name="serialNumber"> Current serial number of the certificate. </param>
        /// <param name="lastCertificateIssuedOn"> Certificate last issuance time. </param>
        /// <param name="expireOn"> Certificate expiration time. </param>
        /// <param name="isPrivateKeyExternal"> &lt;code&gt;true&lt;/code&gt; if private key is external; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="appServiceCertificateNotRenewableReasons"> Reasons why App Service Certificate is not renewable at the current moment. </param>
        /// <param name="nextAutoRenewTimeStamp"> Time stamp when the certificate would be auto renewed next. </param>
        /// <param name="contact"> Contact info. </param>
        /// <param name="kind"> Kind of resource. If the resource is an app, you can refer to https://github.com/Azure/app-service-linux-docs/blob/master/Things_You_Should_Know/kind_property.md#app-service-resource-kind-reference for details supported values for kind. </param>
        /// <returns> A new <see cref="AppService.AppServiceCertificateOrderData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static AppServiceCertificateOrderData AppServiceCertificateOrderData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, IDictionary<string, AppServiceCertificateProperties> certificates = null, string distinguishedName = null, string domainVerificationToken = null, int? validityInYears = null, int? keySize = null, CertificateProductType? productType = null, bool? isAutoRenew = null, ProvisioningState? provisioningState = null, CertificateOrderStatus? status = null, AppServiceCertificateDetails signedCertificate = null, string csr = null, AppServiceCertificateDetails intermediate = null, AppServiceCertificateDetails root = null, string serialNumber = null, DateTimeOffset? lastCertificateIssuedOn = null, DateTimeOffset? expireOn = null, bool? isPrivateKeyExternal = null, IEnumerable<AppServiceCertificateNotRenewableReason> appServiceCertificateNotRenewableReasons = null, DateTimeOffset? nextAutoRenewTimeStamp = null, CertificateOrderContact contact = null, string kind = null)
        {
            tags ??= new Dictionary<string, string>();
            certificates ??= new Dictionary<string, AppServiceCertificateProperties>();
            appServiceCertificateNotRenewableReasons ??= new List<AppServiceCertificateNotRenewableReason>();

            return new AppServiceCertificateOrderData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                kind,
                certificates,
                distinguishedName,
                domainVerificationToken,
                validityInYears,
                keySize,
                productType,
                isAutoRenew,
                provisioningState,
                status,
                signedCertificate,
                csr,
                intermediate,
                root,
                serialNumber,
                lastCertificateIssuedOn,
                expireOn,
                isPrivateKeyExternal,
                appServiceCertificateNotRenewableReasons?.ToList(),
                nextAutoRenewTimeStamp,
                contact,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.AppServiceDetectorData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="metadata"> metadata for the detector. </param>
        /// <param name="dataset"> Data Set. </param>
        /// <param name="status"> Indicates status of the most severe insight. </param>
        /// <param name="dataProvidersMetadata"> Additional configuration for different data providers to be used by the UI. </param>
        /// <param name="suggestedUtterances"> Suggested utterances where the detector can be applicable. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.AppServiceDetectorData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static AppServiceDetectorData AppServiceDetectorData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DetectorInfo metadata = null, IEnumerable<DiagnosticDataset> dataset = null, AppServiceStatusInfo status = null, IEnumerable<DataProviderMetadata> dataProvidersMetadata = null, QueryUtterancesResults suggestedUtterances = null, string kind = null)
        {
            dataset ??= new List<DiagnosticDataset>();
            dataProvidersMetadata ??= new List<DataProviderMetadata>();

            return new AppServiceDetectorData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                metadata,
                dataset?.ToList(),
                status,
                dataProvidersMetadata?.ToList(),
                suggestedUtterances,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.AppServiceEnvironmentAddressResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="serviceIPAddress"> Main public virtual IP. </param>
        /// <param name="internalIPAddress"> Virtual Network internal IP address of the App Service Environment if it is in internal load-balancing mode. </param>
        /// <param name="outboundIPAddresses"> IP addresses appearing on outbound connections. </param>
        /// <param name="virtualIPMappings"> Additional virtual IPs. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="Models.AppServiceEnvironmentAddressResult"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static AppServiceEnvironmentAddressResult AppServiceEnvironmentAddressResult(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IPAddress serviceIPAddress = null, IPAddress internalIPAddress = null, IEnumerable<IPAddress> outboundIPAddresses = null, IEnumerable<VirtualIPMapping> virtualIPMappings = null, string kind = null)
        {
            outboundIPAddresses ??= new List<IPAddress>();
            virtualIPMappings ??= new List<VirtualIPMapping>();

            return new AppServiceEnvironmentAddressResult(
                id,
                name,
                resourceType,
                systemData,
                kind,
                serviceIPAddress,
                internalIPAddress,
                outboundIPAddresses?.ToList(),
                virtualIPMappings?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.AppServiceSourceControlData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="token"> OAuth access token. </param>
        /// <param name="tokenSecret"> OAuth access token secret. </param>
        /// <param name="refreshToken"> OAuth refresh token. </param>
        /// <param name="expireOn"> OAuth token expiration. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.AppServiceSourceControlData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static AppServiceSourceControlData AppServiceSourceControlData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string token = null, string tokenSecret = null, string refreshToken = null, DateTimeOffset? expireOn = null, string kind = null)
        {
            return new AppServiceSourceControlData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                token,
                tokenSecret,
                refreshToken,
                expireOn,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.AppServiceVirtualNetworkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="vnetResourceId"> The Virtual Network's resource ID. </param>
        /// <param name="certThumbprintString"> The client certificate thumbprint. </param>
        /// <param name="certBlob">
        /// A certificate file (.cer) blob containing the public key of the private key used to authenticate a
        /// Point-To-Site VPN connection.
        /// </param>
        /// <param name="routes"> The routes that this Virtual Network connection uses. </param>
        /// <param name="isResyncRequired"> &lt;code&gt;true&lt;/code&gt; if a resync is required; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="dnsServers"> DNS servers to be used by this Virtual Network. This should be a comma-separated list of IP addresses. </param>
        /// <param name="isSwift"> Flag that is used to denote if this is VNET injection. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.AppServiceVirtualNetworkData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static AppServiceVirtualNetworkData AppServiceVirtualNetworkData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ResourceIdentifier vnetResourceId = null, string certThumbprintString = null, string certBlob = null, IEnumerable<AppServiceVirtualNetworkRoute> routes = null, bool? isResyncRequired = null, string dnsServers = null, bool? isSwift = null, string kind = null)
        {
            routes ??= new List<AppServiceVirtualNetworkRoute>();

            return new AppServiceVirtualNetworkData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                vnetResourceId,
                certThumbprintString,
                certBlob,
                routes?.ToList(),
                isResyncRequired,
                dnsServers,
                isSwift,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.AppServiceVirtualNetworkGatewayData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="vnetName"> The Virtual Network name. </param>
        /// <param name="vpnPackageUri"> The URI where the VPN package can be downloaded. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.AppServiceVirtualNetworkGatewayData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static AppServiceVirtualNetworkGatewayData AppServiceVirtualNetworkGatewayData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string vnetName = null, Uri vpnPackageUri = null, string kind = null)
        {
            return new AppServiceVirtualNetworkGatewayData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                vnetName,
                vpnPackageUri,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.AppServiceVirtualNetworkRoute"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="startAddress"> The starting address for this route. This may also include a CIDR notation, in which case the end address must not be specified. </param>
        /// <param name="endAddress"> The ending address for this route. If the start address is specified in CIDR notation, this must be omitted. </param>
        /// <param name="routeType">
        /// The type of route this is:
        /// DEFAULT - By default, every app has routes to the local address ranges specified by RFC1918
        /// INHERITED - Routes inherited from the real Virtual Network routes
        /// STATIC - Static route set on the app only
        ///
        /// These values will be used for syncing an app's routes with those from a Virtual Network.
        /// </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="Models.AppServiceVirtualNetworkRoute"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static AppServiceVirtualNetworkRoute AppServiceVirtualNetworkRoute(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string startAddress = null, string endAddress = null, AppServiceVirtualNetworkRouteType? routeType = null, string kind = null)
        {
            return new AppServiceVirtualNetworkRoute(
                id,
                name,
                resourceType,
                systemData,
                kind,
                startAddress,
                endAddress,
                routeType,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.AseV3NetworkingConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="windowsOutboundIPAddresses"></param>
        /// <param name="linuxOutboundIPAddresses"></param>
        /// <param name="externalInboundIPAddresses"></param>
        /// <param name="internalInboundIPAddresses"></param>
        /// <param name="allowNewPrivateEndpointConnections"> Property to enable and disable new private endpoint connection creation on ASE. </param>
        /// <param name="isFtpEnabled"> Property to enable and disable FTP on ASEV3. </param>
        /// <param name="isRemoteDebugEnabled"> Property to enable and disable Remote Debug on ASEV3. </param>
        /// <param name="inboundIPAddressOverride"> Customer provided Inbound IP Address. Only able to be set on Ase create. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.AseV3NetworkingConfigurationData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static AseV3NetworkingConfigurationData AseV3NetworkingConfigurationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IEnumerable<IPAddress> windowsOutboundIPAddresses = null, IEnumerable<IPAddress> linuxOutboundIPAddresses = null, IEnumerable<IPAddress> externalInboundIPAddresses = null, IEnumerable<IPAddress> internalInboundIPAddresses = null, bool? allowNewPrivateEndpointConnections = null, bool? isFtpEnabled = null, bool? isRemoteDebugEnabled = null, string inboundIPAddressOverride = null, string kind = null)
        {
            windowsOutboundIPAddresses ??= new List<IPAddress>();
            linuxOutboundIPAddresses ??= new List<IPAddress>();
            externalInboundIPAddresses ??= new List<IPAddress>();
            internalInboundIPAddresses ??= new List<IPAddress>();

            return new AseV3NetworkingConfigurationData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                windowsOutboundIPAddresses?.ToList(),
                linuxOutboundIPAddresses?.ToList(),
                externalInboundIPAddresses?.ToList(),
                internalInboundIPAddresses?.ToList(),
                allowNewPrivateEndpointConnections,
                isFtpEnabled,
                isRemoteDebugEnabled,
                inboundIPAddressOverride,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.ContinuousWebJobData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="status"> Job status. </param>
        /// <param name="detailedStatus"> Detailed status. </param>
        /// <param name="logUri"> Log URL. </param>
        /// <param name="runCommand"> Run command. </param>
        /// <param name="uri"> Job URL. </param>
        /// <param name="extraInfoUri"> Extra Info URL. </param>
        /// <param name="webJobType"> Job type. </param>
        /// <param name="error"> Error information. </param>
        /// <param name="isUsingSdk"> Using SDK?. </param>
        /// <param name="settings"> Job settings. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.ContinuousWebJobData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static ContinuousWebJobData ContinuousWebJobData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ContinuousWebJobStatus? status = null, string detailedStatus = null, Uri logUri = null, string runCommand = null, Uri uri = null, Uri extraInfoUri = null, WebJobType? webJobType = null, string error = null, bool? isUsingSdk = null, IDictionary<string, BinaryData> settings = null, string kind = null)
        {
            settings ??= new Dictionary<string, BinaryData>();

            return new ContinuousWebJobData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                status,
                detailedStatus,
                logUri,
                runCommand,
                uri,
                extraInfoUri,
                webJobType,
                error,
                isUsingSdk,
                settings,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CsmDeploymentStatus"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="deploymentId"> Deployment operation id. </param>
        /// <param name="status"> Deployment build status. </param>
        /// <param name="numberOfInstancesInProgress"> Number of site instances currently being provisioned. </param>
        /// <param name="numberOfInstancesSuccessful"> Number of site instances provisioned successfully. </param>
        /// <param name="numberOfInstancesFailed"> Number of site instances failed to provision. </param>
        /// <param name="failedInstancesLogs"> List of URLs pointing to logs for instances which failed to provision. </param>
        /// <param name="errors"> List of errors. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="Models.CsmDeploymentStatus"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static CsmDeploymentStatus CsmDeploymentStatus(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string deploymentId = null, DeploymentBuildStatus? status = null, int? numberOfInstancesInProgress = null, int? numberOfInstancesSuccessful = null, int? numberOfInstancesFailed = null, IEnumerable<string> failedInstancesLogs = null, IEnumerable<ResponseError> errors = null, string kind = null)
        {
            failedInstancesLogs ??= new List<string>();
            errors ??= new List<ResponseError>();

            return new CsmDeploymentStatus(
                id,
                name,
                resourceType,
                systemData,
                kind,
                deploymentId,
                status,
                numberOfInstancesInProgress,
                numberOfInstancesSuccessful,
                numberOfInstancesFailed,
                failedInstancesLogs?.ToList(),
                errors?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.CsmPublishingCredentialsPoliciesEntityData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="allow"> &lt;code&gt;true&lt;/code&gt; to allow access to a publishing method; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.CsmPublishingCredentialsPoliciesEntityData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static CsmPublishingCredentialsPoliciesEntityData CsmPublishingCredentialsPoliciesEntityData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, bool? allow = null, string kind = null)
        {
            return new CsmPublishingCredentialsPoliciesEntityData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                allow,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.CustomDnsSuffixConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"></param>
        /// <param name="provisioningDetails"></param>
        /// <param name="dnsSuffix"> The default custom domain suffix to use for all sites deployed on the ASE. </param>
        /// <param name="certificateUri"> The URL referencing the Azure Key Vault certificate secret that should be used as the default SSL/TLS certificate for sites with the custom domain suffix. </param>
        /// <param name="keyVaultReferenceIdentity"> The user-assigned identity to use for resolving the key vault certificate reference. If not specified, the system-assigned ASE identity will be used if available. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.CustomDnsSuffixConfigurationData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static CustomDnsSuffixConfigurationData CustomDnsSuffixConfigurationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, CustomDnsSuffixProvisioningState? provisioningState = null, string provisioningDetails = null, string dnsSuffix = null, Uri certificateUri = null, string keyVaultReferenceIdentity = null, string kind = null)
        {
            return new CustomDnsSuffixConfigurationData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                provisioningState,
                provisioningDetails,
                dnsSuffix,
                certificateUri,
                keyVaultReferenceIdentity,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.DeletedSiteData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="deletedSiteId"> Numeric id for the deleted site. </param>
        /// <param name="deletedTimestamp"> Time in UTC when the app was deleted. </param>
        /// <param name="subscription"> Subscription containing the deleted site. </param>
        /// <param name="resourceGroup"> ResourceGroup that contained the deleted site. </param>
        /// <param name="deletedSiteName"> Name of the deleted site. </param>
        /// <param name="slot"> Slot of the deleted site. </param>
        /// <param name="kindPropertiesKind"> Kind of site that was deleted. </param>
        /// <param name="geoRegionName"> Geo Region of the deleted site. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.DeletedSiteData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static DeletedSiteData DeletedSiteData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, int? deletedSiteId = null, string deletedTimestamp = null, string subscription = null, string resourceGroup = null, string deletedSiteName = null, string slot = null, string kindPropertiesKind = null, string geoRegionName = null, string kind = null)
        {
            return new DeletedSiteData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                deletedSiteId,
                deletedTimestamp,
                subscription,
                resourceGroup,
                deletedSiteName,
                slot,
                kindPropertiesKind,
                geoRegionName,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.DetectorDefinitionResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> Display name of the detector. </param>
        /// <param name="description"> Description of the detector. </param>
        /// <param name="rank"> Detector Rank. </param>
        /// <param name="isEnabled"> Flag representing whether detector is enabled or not. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.DetectorDefinitionResourceData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static DetectorDefinitionResourceData DetectorDefinitionResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string displayName = null, string description = null, double? rank = null, bool? isEnabled = null, string kind = null)
        {
            return new DetectorDefinitionResourceData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                displayName,
                description,
                rank,
                isEnabled,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.FunctionEnvelopeData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="functionAppId"> Function App ID. </param>
        /// <param name="scriptRootPathHref"> Script root path URI. </param>
        /// <param name="scriptHref"> Script URI. </param>
        /// <param name="configHref"> Config URI. </param>
        /// <param name="testDataHref"> Test data URI. </param>
        /// <param name="secretsFileHref"> Secrets file URI. </param>
        /// <param name="href"> Function URI. </param>
        /// <param name="config"> Config information. </param>
        /// <param name="files"> File list. </param>
        /// <param name="testData"> Test data used when testing via the Azure Portal. </param>
        /// <param name="invokeUrlTemplate"> The invocation URL. </param>
        /// <param name="language"> The function language. </param>
        /// <param name="isDisabled"> Gets or sets a value indicating whether the function is disabled. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.FunctionEnvelopeData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static FunctionEnvelopeData FunctionEnvelopeData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string functionAppId = null, string scriptRootPathHref = null, string scriptHref = null, string configHref = null, string testDataHref = null, string secretsFileHref = null, string href = null, BinaryData config = null, IDictionary<string, string> files = null, string testData = null, string invokeUrlTemplate = null, string language = null, bool? isDisabled = null, string kind = null)
        {
            files ??= new Dictionary<string, string>();

            return new FunctionEnvelopeData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                functionAppId,
                scriptRootPathHref,
                scriptHref,
                configHref,
                testDataHref,
                secretsFileHref,
                href,
                config,
                files,
                testData,
                invokeUrlTemplate,
                language,
                isDisabled,
                serializedAdditionalRawData: null);
        }
    }
}
