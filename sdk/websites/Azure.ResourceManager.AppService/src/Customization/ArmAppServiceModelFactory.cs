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
        public static AppCertificateData AppCertificateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string password, string friendlyName, string subjectName, IEnumerable<string> hostNames, byte[] pfxBlob, string siteName, string selfLink, string issuer, DateTimeOffset? issueOn, DateTimeOffset? expireOn, string thumbprintString, bool? isValid, byte[] cerBlob, string publicKeyHash, HostingEnvironmentProfile hostingEnvironmentProfile, ResourceIdentifier keyVaultId, string keyVaultSecretName, KeyVaultSecretStatus? keyVaultSecretStatus, ResourceIdentifier serverFarmId, string canonicalName, string domainValidationMethod, string kind)
        {
            return AppCertificateData(
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
                domainValidationMethod);
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
        public static ApiKeyVaultReferenceData ApiKeyVaultReferenceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string reference, ResolveStatus? status, string vaultName, string secretName, string secretVersion, ManagedServiceIdentity identity, string details, ConfigReferenceSource? source, string activeVersion, string kind)
        {
            return ApiKeyVaultReferenceData(
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
                activeVersion);
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
        public static AppServiceCertificateData AppServiceCertificateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ResourceIdentifier keyVaultId, string keyVaultSecretName, KeyVaultSecretStatus? provisioningState, string kind)
        {
            return AppServiceCertificateData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                kind,
                keyVaultId,
                keyVaultSecretName,
                provisioningState);
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
        public static AppServiceCertificateOrderData AppServiceCertificateOrderData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IDictionary<string, AppServiceCertificateProperties> certificates, string distinguishedName, string domainVerificationToken, int? validityInYears, int? keySize, CertificateProductType? productType, bool? isAutoRenew, ProvisioningState? provisioningState, CertificateOrderStatus? status, AppServiceCertificateDetails signedCertificate, string csr, AppServiceCertificateDetails intermediate, AppServiceCertificateDetails root, string serialNumber, DateTimeOffset? lastCertificateIssuedOn, DateTimeOffset? expireOn, bool? isPrivateKeyExternal, IEnumerable<AppServiceCertificateNotRenewableReason> appServiceCertificateNotRenewableReasons, DateTimeOffset? nextAutoRenewTimeStamp, CertificateOrderContact contact, string kind)
        {
            return AppServiceCertificateOrderData(
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
                contact);
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
        public static AppServiceEnvironmentAddressResult AppServiceEnvironmentAddressResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IPAddress serviceIPAddress, IPAddress internalIPAddress, IEnumerable<IPAddress> outboundIPAddresses, IEnumerable<VirtualIPMapping> virtualIPMappings, string kind)
        {
            return AppServiceEnvironmentAddressResult(
                id,
                name,
                resourceType,
                systemData,
                kind,
                serviceIPAddress,
                internalIPAddress,
                outboundIPAddresses?.ToList(),
                virtualIPMappings?.ToList());
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
        public static AppServiceSourceControlData AppServiceSourceControlData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string token, string tokenSecret, string refreshToken, DateTimeOffset? expireOn, string kind)
        {
            return AppServiceSourceControlData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                token,
                tokenSecret,
                refreshToken,
                expireOn);
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
        public static AppServiceVirtualNetworkData AppServiceVirtualNetworkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier vnetResourceId, string certThumbprintString, string certBlob, IEnumerable<AppServiceVirtualNetworkRoute> routes, bool? isResyncRequired, string dnsServers, bool? isSwift, string kind)
        {
            return AppServiceVirtualNetworkData(
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
                isSwift);
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
        public static AppServiceVirtualNetworkGatewayData AppServiceVirtualNetworkGatewayData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string vnetName, Uri vpnPackageUri, string kind)
        {
            return AppServiceVirtualNetworkGatewayData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                vnetName,
                vpnPackageUri);
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
        public static AppServiceVirtualNetworkRoute AppServiceVirtualNetworkRoute(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string startAddress, string endAddress, AppServiceVirtualNetworkRouteType? routeType, string kind)
        {
            return AppServiceVirtualNetworkRoute(
                id,
                name,
                resourceType,
                systemData,
                kind,
                startAddress,
                endAddress,
                routeType);
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
        public static AseV3NetworkingConfigurationData AseV3NetworkingConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IEnumerable<IPAddress> windowsOutboundIPAddresses, IEnumerable<IPAddress> linuxOutboundIPAddresses, IEnumerable<IPAddress> externalInboundIPAddresses, IEnumerable<IPAddress> internalInboundIPAddresses, bool? allowNewPrivateEndpointConnections, bool? isFtpEnabled, bool? isRemoteDebugEnabled, string inboundIPAddressOverride, string kind)
        {
            return AseV3NetworkingConfigurationData(
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
                inboundIPAddressOverride);
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
        public static ContinuousWebJobData ContinuousWebJobData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ContinuousWebJobStatus? status, string detailedStatus, Uri logUri, string runCommand, Uri uri, Uri extraInfoUri, WebJobType? webJobType, string error, bool? isUsingSdk, IDictionary<string, BinaryData> settings, string kind)
        {
            return ContinuousWebJobData(
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
                settings);
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
        public static CsmDeploymentStatus CsmDeploymentStatus(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string deploymentId, DeploymentBuildStatus? status, int? numberOfInstancesInProgress, int? numberOfInstancesSuccessful, int? numberOfInstancesFailed, IEnumerable<string> failedInstancesLogs, IEnumerable<ResponseError> errors, string kind)
        {
            return CsmDeploymentStatus(
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
                errors?.ToList());
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
        public static CsmPublishingCredentialsPoliciesEntityData CsmPublishingCredentialsPoliciesEntityData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? allow, string kind)
        {
            return CsmPublishingCredentialsPoliciesEntityData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                allow);
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
        public static CustomDnsSuffixConfigurationData CustomDnsSuffixConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, CustomDnsSuffixProvisioningState? provisioningState, string provisioningDetails, string dnsSuffix, Uri certificateUri, string keyVaultReferenceIdentity, string kind)
        {
            return CustomDnsSuffixConfigurationData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                provisioningState,
                provisioningDetails,
                dnsSuffix,
                certificateUri,
                keyVaultReferenceIdentity);
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
        public static DeletedSiteData DeletedSiteData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? deletedSiteId, string deletedTimestamp, string subscription, string resourceGroup, string deletedSiteName, string slot, string kindPropertiesKind, string geoRegionName, string kind)
        {
            return DeletedSiteData(
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
                geoRegionName);
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
        public static DetectorDefinitionResourceData DetectorDefinitionResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, string description, double? rank, bool? isEnabled, string kind)
        {
            return DetectorDefinitionResourceData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                displayName,
                description,
                rank,
                isEnabled);
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
        public static FunctionEnvelopeData FunctionEnvelopeData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string functionAppId, string scriptRootPathHref, string scriptHref, string configHref, string testDataHref, string secretsFileHref, string href, BinaryData config, IDictionary<string, string> files, string testData, string invokeUrlTemplate, string language, bool? isDisabled, string kind)
        {
            return FunctionEnvelopeData(
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
                isDisabled);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.HostNameBindingData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="siteName"> App Service app name. </param>
        /// <param name="domainId"> Fully qualified ARM domain resource URI. </param>
        /// <param name="azureResourceName"> Azure resource name. </param>
        /// <param name="azureResourceType"> Azure resource type. </param>
        /// <param name="customHostNameDnsRecordType"> Custom DNS record type. </param>
        /// <param name="hostNameType"> Hostname type. </param>
        /// <param name="sslState"> SSL type. </param>
        /// <param name="thumbprintString"> SSL certificate thumbprint. </param>
        /// <param name="virtualIP"> Virtual IP address assigned to the hostname if IP based SSL is enabled. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.HostNameBindingData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static HostNameBindingData HostNameBindingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string siteName, string domainId, string azureResourceName, AppServiceResourceType? azureResourceType, CustomHostNameDnsRecordType? customHostNameDnsRecordType, AppServiceHostNameType? hostNameType, HostNameBindingSslState? sslState, string thumbprintString, string virtualIP, string kind)
        {
            return HostNameBindingData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                siteName,
                domainId,
                azureResourceName,
                azureResourceType,
                customHostNameDnsRecordType,
                hostNameType,
                sslState,
                thumbprintString,
                virtualIP);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.HybridConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="serviceBusNamespace"> The name of the Service Bus namespace. </param>
        /// <param name="relayName"> The name of the Service Bus relay. </param>
        /// <param name="relayArmId"> The ARM URI to the Service Bus relay. </param>
        /// <param name="hostname"> The hostname of the endpoint. </param>
        /// <param name="port"> The port of the endpoint. </param>
        /// <param name="sendKeyName"> The name of the Service Bus key which has Send permissions. This is used to authenticate to Service Bus. </param>
        /// <param name="sendKeyValue">
        /// The value of the Service Bus key. This is used to authenticate to Service Bus. In ARM this key will not be returned
        /// normally, use the POST /listKeys API instead.
        /// </param>
        /// <param name="serviceBusSuffix"> The suffix for the service bus endpoint. By default this is .servicebus.windows.net. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.HybridConnectionData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static HybridConnectionData HybridConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string serviceBusNamespace, string relayName, ResourceIdentifier relayArmId, string hostname, int? port, string sendKeyName, string sendKeyValue, string serviceBusSuffix, string kind)
        {
            return HybridConnectionData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                serviceBusNamespace,
                relayName,
                relayArmId,
                hostname,
                port,
                sendKeyName,
                sendKeyValue,
                serviceBusSuffix);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.HybridConnectionLimitData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="current"> The current number of Hybrid Connections. </param>
        /// <param name="maximum"> The maximum number of Hybrid Connections allowed. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.HybridConnectionLimitData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static HybridConnectionLimitData HybridConnectionLimitData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? current, int? maximum, string kind)
        {
            return HybridConnectionLimitData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                current,
                maximum);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.KubeEnvironmentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> Extended Location. </param>
        /// <param name="provisioningState"> Provisioning state of the Kubernetes Environment. </param>
        /// <param name="deploymentErrors"> Any errors that occurred during deployment or deployment validation. </param>
        /// <param name="isInternalLoadBalancerEnabled"> Only visible within Vnet/Subnet. </param>
        /// <param name="defaultDomain"> Default Domain Name for the cluster. </param>
        /// <param name="staticIP"> Static IP of the KubeEnvironment. </param>
        /// <param name="environmentType"> Type of Kubernetes Environment. Only supported for Container App Environments with value as Managed. </param>
        /// <param name="arcConfiguration">
        /// Cluster configuration which determines the ARC cluster
        /// components types. Eg: Choosing between BuildService kind,
        /// FrontEnd Service ArtifactsStorageType etc.
        /// </param>
        /// <param name="appLogsConfiguration">
        /// Cluster configuration which enables the log daemon to export
        /// app logs to a destination. Currently only "log-analytics" is
        /// supported
        /// </param>
        /// <param name="containerAppsConfiguration"> Cluster configuration for Container Apps Environments to configure Dapr Instrumentation Key and VNET Configuration. </param>
        /// <param name="aksResourceId"></param>
        /// <param name="kind"> Kind of resource. If the resource is an app, you can refer to https://github.com/Azure/app-service-linux-docs/blob/master/Things_You_Should_Know/kind_property.md#app-service-resource-kind-reference for details supported values for kind. </param>
        /// <returns> A new <see cref="AppService.KubeEnvironmentData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static KubeEnvironmentData KubeEnvironmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, KubeEnvironmentProvisioningState? provisioningState, string deploymentErrors, bool? isInternalLoadBalancerEnabled, string defaultDomain, string staticIP, string environmentType, ArcConfiguration arcConfiguration, AppLogsConfiguration appLogsConfiguration, ContainerAppsConfiguration containerAppsConfiguration, ResourceIdentifier aksResourceId, string kind)
        {
            return KubeEnvironmentData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                extendedLocation,
                kind,
                provisioningState,
                deploymentErrors,
                isInternalLoadBalancerEnabled,
                defaultDomain,
                staticIP,
                environmentType,
                arcConfiguration,
                appLogsConfiguration,
                containerAppsConfiguration,
                aksResourceId);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.MigrateMySqlStatusData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="migrationOperationStatus"> Status of the migration task. </param>
        /// <param name="operationId"> Operation ID for the migration task. </param>
        /// <param name="isLocalMySqlEnabled"> True if the web app has in app MySql enabled. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.MigrateMySqlStatusData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static MigrateMySqlStatusData MigrateMySqlStatusData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AppServiceOperationStatus? migrationOperationStatus, string operationId, bool? isLocalMySqlEnabled, string kind)
        {
            return MigrateMySqlStatusData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                migrationOperationStatus,
                operationId,
                isLocalMySqlEnabled);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.MSDeployStatusData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="deployer"> Username of deployer. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="startOn"> Start time of deploy operation. </param>
        /// <param name="endOn"> End time of deploy operation. </param>
        /// <param name="isComplete"> Whether the deployment operation has completed. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.MSDeployStatusData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static MSDeployStatusData MSDeployStatusData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string deployer, MSDeployProvisioningState? provisioningState, DateTimeOffset? startOn, DateTimeOffset? endOn, bool? isComplete, string kind)
        {
            return MSDeployStatusData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                deployer,
                provisioningState,
                startOn,
                endOn,
                isComplete);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.NetworkFeatureData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="virtualNetworkName"> The Virtual Network name. </param>
        /// <param name="virtualNetworkConnection"> The Virtual Network summary view. </param>
        /// <param name="hybridConnections"> The Hybrid Connections summary view. </param>
        /// <param name="hybridConnectionsV2"> The Hybrid Connection V2 (Service Bus) view. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.NetworkFeatureData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static NetworkFeatureData NetworkFeatureData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string virtualNetworkName, AppServiceVirtualNetworkProperties virtualNetworkConnection, IEnumerable<RelayServiceConnectionEntityData> hybridConnections, IEnumerable<HybridConnectionData> hybridConnectionsV2, string kind)
        {
            return NetworkFeatureData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                virtualNetworkName,
                virtualNetworkConnection,
                hybridConnections?.ToList(),
                hybridConnectionsV2?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="AppService.PrivateAccessData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="isEnabled"> Whether private access is enabled or not. </param>
        /// <param name="virtualNetworks"> The Virtual Networks (and subnets) allowed to access the site privately. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.PrivateAccessData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static PrivateAccessData PrivateAccessData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? isEnabled, IEnumerable<PrivateAccessVirtualNetwork> virtualNetworks, string kind)
        {
            return PrivateAccessData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                isEnabled,
                virtualNetworks?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="AppService.ProcessInfoData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identifier"> ARM Identifier for deployment. </param>
        /// <param name="deploymentName"> Deployment name. </param>
        /// <param name="href"> HRef URI. </param>
        /// <param name="minidump"> Minidump URI. </param>
        /// <param name="isProfileRunning"> Is profile running?. </param>
        /// <param name="isIisProfileRunning"> Is the IIS Profile running?. </param>
        /// <param name="iisProfileTimeoutInSeconds"> IIS Profile timeout (seconds). </param>
        /// <param name="parent"> Parent process. </param>
        /// <param name="children"> Child process list. </param>
        /// <param name="processThreads"> Thread list. </param>
        /// <param name="openFileHandles"> List of open files. </param>
        /// <param name="modules"> List of modules. </param>
        /// <param name="fileName"> File name of this process. </param>
        /// <param name="commandLine"> Command line. </param>
        /// <param name="userName"> User name. </param>
        /// <param name="handleCount"> Handle count. </param>
        /// <param name="moduleCount"> Module count. </param>
        /// <param name="threadCount"> Thread count. </param>
        /// <param name="startOn"> Start time. </param>
        /// <param name="totalCpuTime"> Total CPU time. </param>
        /// <param name="userCpuTime"> User CPU time. </param>
        /// <param name="privilegedCpuTime"> Privileged CPU time. </param>
        /// <param name="workingSet"> Working set. </param>
        /// <param name="peakWorkingSet"> Peak working set. </param>
        /// <param name="privateMemory"> Private memory size. </param>
        /// <param name="virtualMemory"> Virtual memory size. </param>
        /// <param name="peakVirtualMemory"> Peak virtual memory usage. </param>
        /// <param name="pagedSystemMemory"> Paged system memory. </param>
        /// <param name="nonPagedSystemMemory"> Non-paged system memory. </param>
        /// <param name="pagedMemory"> Paged memory. </param>
        /// <param name="peakPagedMemory"> Peak paged memory. </param>
        /// <param name="timeStamp"> Time stamp. </param>
        /// <param name="environmentVariables"> List of environment variables. </param>
        /// <param name="isScmSite"> Is this the SCM site?. </param>
        /// <param name="isWebjob"> Is this a Web Job?. </param>
        /// <param name="description"> Description of process. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.ProcessInfoData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static ProcessInfoData ProcessInfoData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? identifier, string deploymentName, string href, string minidump, bool? isProfileRunning, bool? isIisProfileRunning, double? iisProfileTimeoutInSeconds, string parent, IEnumerable<string> children, IEnumerable<WebAppProcessThreadProperties> processThreads, IEnumerable<string> openFileHandles, IEnumerable<ProcessModuleInfoData> modules, string fileName, string commandLine, string userName, int? handleCount, int? moduleCount, int? threadCount, DateTimeOffset? startOn, string totalCpuTime, string userCpuTime, string privilegedCpuTime, long? workingSet, long? peakWorkingSet, long? privateMemory, long? virtualMemory, long? peakVirtualMemory, long? pagedSystemMemory, long? nonPagedSystemMemory, long? pagedMemory, long? peakPagedMemory, DateTimeOffset? timeStamp, IDictionary<string, string> environmentVariables, bool? isScmSite, bool? isWebjob, string description, string kind)
        {
            return ProcessInfoData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                identifier,
                deploymentName,
                href,
                minidump,
                isProfileRunning,
                isIisProfileRunning,
                iisProfileTimeoutInSeconds,
                parent,
                children?.ToList(),
                processThreads?.ToList(),
                openFileHandles?.ToList(),
                modules?.ToList(),
                fileName,
                commandLine,
                userName,
                handleCount,
                moduleCount,
                threadCount,
                startOn,
                totalCpuTime,
                userCpuTime,
                privilegedCpuTime,
                workingSet,
                peakWorkingSet,
                privateMemory,
                virtualMemory,
                peakVirtualMemory,
                pagedSystemMemory,
                nonPagedSystemMemory,
                pagedMemory,
                peakPagedMemory,
                timeStamp,
                environmentVariables,
                isScmSite,
                isWebjob,
                description);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.ProcessModuleInfoData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="baseAddress"> Base address. Used as module identifier in ARM resource URI. </param>
        /// <param name="fileName"> File name. </param>
        /// <param name="href"> HRef URI. </param>
        /// <param name="filePath"> File path. </param>
        /// <param name="moduleMemorySize"> Module memory size. </param>
        /// <param name="fileVersion"> File version. </param>
        /// <param name="fileDescription"> File description. </param>
        /// <param name="product"> Product name. </param>
        /// <param name="productVersion"> Product version. </param>
        /// <param name="isDebug"> Is debug?. </param>
        /// <param name="language"> Module language (locale). </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.ProcessModuleInfoData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static ProcessModuleInfoData ProcessModuleInfoData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string baseAddress, string fileName, string href, string filePath, int? moduleMemorySize, string fileVersion, string fileDescription, string product, string productVersion, bool? isDebug, string language, string kind)
        {
            return ProcessModuleInfoData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                baseAddress,
                fileName,
                href,
                filePath,
                moduleMemorySize,
                fileVersion,
                fileDescription,
                product,
                productVersion,
                isDebug,
                language);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.PublicCertificateData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="blob"> Public Certificate byte array. </param>
        /// <param name="publicCertificateLocation"> Public Certificate Location. </param>
        /// <param name="thumbprintString"> Certificate Thumbprint. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.PublicCertificateData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static PublicCertificateData PublicCertificateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, byte[] blob, PublicCertificateLocation? publicCertificateLocation, string thumbprintString, string kind)
        {
            return PublicCertificateData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                blob,
                publicCertificateLocation,
                thumbprintString);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.PublishingUserData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="publishingUserName"> Username used for publishing. </param>
        /// <param name="publishingPassword"> Password used for publishing. </param>
        /// <param name="publishingPasswordHash"> Password hash used for publishing. </param>
        /// <param name="publishingPasswordHashSalt"> Password hash salt used for publishing. </param>
        /// <param name="scmUri"> Url of SCM site. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.PublishingUserData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static PublishingUserData PublishingUserData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string publishingUserName, string publishingPassword, string publishingPasswordHash, string publishingPasswordHashSalt, Uri scmUri, string kind)
        {
            return PublishingUserData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                publishingUserName,
                publishingPassword,
                publishingPasswordHash,
                publishingPasswordHashSalt,
                scmUri);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.RecommendationRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="recommendationName"> Unique name of the rule. </param>
        /// <param name="displayName"> UI friendly name of the rule. </param>
        /// <param name="message"> Localized name of the rule (Good for UI). </param>
        /// <param name="recommendationId">
        /// Recommendation ID of an associated recommendation object tied to the rule, if exists.
        /// If such an object doesn't exist, it is set to null.
        /// </param>
        /// <param name="description"> Localized detailed description of the rule. </param>
        /// <param name="actionName"> Name of action that is recommended by this rule in string. </param>
        /// <param name="level"> Level of impact indicating how critical this rule is. </param>
        /// <param name="channels"> List of available channels that this rule applies. </param>
        /// <param name="categoryTags"> The list of category tags that this recommendation rule belongs to. </param>
        /// <param name="isDynamic"> True if this is associated with a dynamically added rule. </param>
        /// <param name="extensionName"> Extension name of the portal if exists. Applicable to dynamic rule only. </param>
        /// <param name="bladeName"> Deep link to a blade on the portal. Applicable to dynamic rule only. </param>
        /// <param name="forwardLink"> Forward link to an external document associated with the rule. Applicable to dynamic rule only. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.RecommendationRuleData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static RecommendationRuleData RecommendationRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string recommendationName, string displayName, string message, Guid? recommendationId, string description, string actionName, NotificationLevel? level, RecommendationChannel? channels, IEnumerable<string> categoryTags, bool? isDynamic, string extensionName, string bladeName, string forwardLink, string kind)
        {
            return RecommendationRuleData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                recommendationName,
                displayName,
                message,
                recommendationId,
                description,
                actionName,
                level,
                channels,
                categoryTags?.ToList(),
                isDynamic,
                extensionName,
                bladeName,
                forwardLink);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.RelayServiceConnectionEntityData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="entityName"></param>
        /// <param name="entityConnectionString"></param>
        /// <param name="resourceConnectionString"></param>
        /// <param name="hostname"></param>
        /// <param name="port"></param>
        /// <param name="biztalkUri"></param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.RelayServiceConnectionEntityData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static RelayServiceConnectionEntityData RelayServiceConnectionEntityData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string entityName, string entityConnectionString, string resourceConnectionString, string hostname, int? port, Uri biztalkUri, string kind)
        {
            return RelayServiceConnectionEntityData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                entityName,
                entityConnectionString,
                resourceConnectionString,
                hostname,
                port,
                biztalkUri);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.RemotePrivateEndpointConnectionARMResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"></param>
        /// <param name="privateEndpointId"> PrivateEndpoint of a remote private endpoint connection. </param>
        /// <param name="privateLinkServiceConnectionState"> The state of a private link connection. </param>
        /// <param name="ipAddresses"> Private IPAddresses mapped to the remote private endpoint. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.RemotePrivateEndpointConnectionARMResourceData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static RemotePrivateEndpointConnectionARMResourceData RemotePrivateEndpointConnectionARMResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string provisioningState, ResourceIdentifier privateEndpointId, PrivateLinkConnectionState privateLinkServiceConnectionState, IEnumerable<IPAddress> ipAddresses, string kind)
        {
            return  RemotePrivateEndpointConnectionARMResourceData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                provisioningState,
                privateEndpointId,
                privateLinkServiceConnectionState,
                ipAddresses?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="AppService.ResourceHealthMetadataData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="category"> The category that the resource matches in the RHC Policy File. </param>
        /// <param name="isSignalAvailable"> Is there a health signal for the resource. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.ResourceHealthMetadataData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static ResourceHealthMetadataData ResourceHealthMetadataData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string category, bool? isSignalAvailable, string kind)
        {
            return ResourceHealthMetadataData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                category,
                isSignalAvailable);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SiteAuthSettingsV2"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="platform"> The configuration settings of the platform of App Service Authentication/Authorization. </param>
        /// <param name="globalValidation"> The configuration settings that determines the validation flow of users using App Service Authentication/Authorization. </param>
        /// <param name="identityProviders"> The configuration settings of each of the identity providers used to configure App Service Authentication/Authorization. </param>
        /// <param name="login"> The configuration settings of the login flow of users using App Service Authentication/Authorization. </param>
        /// <param name="httpSettings"> The configuration settings of the HTTP requests for authentication and authorization requests made against App Service Authentication/Authorization. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="Models.SiteAuthSettingsV2"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static SiteAuthSettingsV2 SiteAuthSettingsV2(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AuthPlatform platform, GlobalValidation globalValidation, AppServiceIdentityProviders identityProviders, WebAppLoginInfo login, AppServiceHttpSettings httpSettings, string kind)
        {
            return SiteAuthSettingsV2(
                id,
                name,
                resourceType,
                systemData,
                kind,
                platform,
                globalValidation,
                identityProviders,
                login,
                httpSettings);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.SiteExtensionInfoData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="extensionId"> Site extension ID. </param>
        /// <param name="title"></param>
        /// <param name="extensionType"> Site extension type. </param>
        /// <param name="summary"> Summary description. </param>
        /// <param name="description"> Detailed description. </param>
        /// <param name="version"> Version information. </param>
        /// <param name="extensionUri"> Extension URL. </param>
        /// <param name="projectUri"> Project URL. </param>
        /// <param name="iconUri"> Icon URL. </param>
        /// <param name="licenseUri"> License URL. </param>
        /// <param name="feedUri"> Feed URL. </param>
        /// <param name="authors"> List of authors. </param>
        /// <param name="installerCommandLineParams"> Installer command line parameters. </param>
        /// <param name="publishedOn"> Published timestamp. </param>
        /// <param name="downloadCount"> Count of downloads. </param>
        /// <param name="localIsLatestVersion"> &lt;code&gt;true&lt;/code&gt; if the local version is the latest version; &lt;code&gt;false&lt;/code&gt; otherwise. </param>
        /// <param name="localPath"> Local path. </param>
        /// <param name="installedOn"> Installed timestamp. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="comment"> Site Extension comment. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.SiteExtensionInfoData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static SiteExtensionInfoData SiteExtensionInfoData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string extensionId, string title, SiteExtensionType? extensionType, string summary, string description, string version, Uri extensionUri, Uri projectUri, Uri iconUri, Uri licenseUri, Uri feedUri, IEnumerable<string> authors, string installerCommandLineParams, DateTimeOffset? publishedOn, int? downloadCount, bool? localIsLatestVersion, string localPath, DateTimeOffset? installedOn, string provisioningState, string comment, string kind)
        {
            return SiteExtensionInfoData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                extensionId,
                title,
                extensionType,
                summary,
                description,
                version,
                extensionUri,
                projectUri,
                iconUri,
                licenseUri,
                feedUri,
                authors?.ToList(),
                installerCommandLineParams,
                publishedOn,
                downloadCount,
                localIsLatestVersion,
                localPath,
                installedOn,
                provisioningState,
                comment);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.SiteLogsConfigData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="applicationLogs"> Application logs configuration. </param>
        /// <param name="httpLogs"> HTTP logs configuration. </param>
        /// <param name="isFailedRequestsTracingEnabled"> Failed requests tracing configuration. </param>
        /// <param name="isDetailedErrorMessagesEnabled"> Detailed error messages configuration. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.SiteLogsConfigData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static SiteLogsConfigData SiteLogsConfigData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ApplicationLogsConfig applicationLogs, AppServiceHttpLogsConfig httpLogs, bool? isFailedRequestsTracingEnabled, bool? isDetailedErrorMessagesEnabled, string kind)
        {
            return SiteLogsConfigData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                applicationLogs,
                httpLogs,
                isFailedRequestsTracingEnabled,
                isDetailedErrorMessagesEnabled);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.SiteSourceControlData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="repoUri"> Repository or source control URL. </param>
        /// <param name="branch"> Name of branch to use for deployment. </param>
        /// <param name="isManualIntegration"> &lt;code&gt;true&lt;/code&gt; to limit to manual integration; &lt;code&gt;false&lt;/code&gt; to enable continuous integration (which configures webhooks into online repos like GitHub). </param>
        /// <param name="isGitHubAction"> &lt;code&gt;true&lt;/code&gt; if this is deployed via GitHub action. </param>
        /// <param name="isDeploymentRollbackEnabled"> &lt;code&gt;true&lt;/code&gt; to enable deployment rollback; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isMercurial"> &lt;code&gt;true&lt;/code&gt; for a Mercurial repository; &lt;code&gt;false&lt;/code&gt; for a Git repository. </param>
        /// <param name="gitHubActionConfiguration"> If GitHub Action is selected, than the associated configuration. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.SiteSourceControlData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static SiteSourceControlData SiteSourceControlData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Uri repoUri, string branch, bool? isManualIntegration, bool? isGitHubAction, bool? isDeploymentRollbackEnabled, bool? isMercurial, GitHubActionConfiguration gitHubActionConfiguration, string kind)
        {
            return SiteSourceControlData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                repoUri,
                branch,
                isManualIntegration,
                isGitHubAction,
                isDeploymentRollbackEnabled,
                isMercurial,
                gitHubActionConfiguration);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.SlotConfigNamesResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="connectionStringNames"> List of connection string names. </param>
        /// <param name="appSettingNames"> List of application settings names. </param>
        /// <param name="azureStorageConfigNames"> List of external Azure storage account identifiers. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.SlotConfigNamesResourceData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static SlotConfigNamesResourceData SlotConfigNamesResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IEnumerable<string> connectionStringNames, IEnumerable<string> appSettingNames, IEnumerable<string> azureStorageConfigNames, string kind)
        {
            return SlotConfigNamesResourceData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                connectionStringNames?.ToList(),
                appSettingNames?.ToList(),
                azureStorageConfigNames?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="AppService.StaticSiteBasicAuthPropertyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="password"> The password for basic auth. </param>
        /// <param name="secretUri"> Url to the secret in Key Vault. </param>
        /// <param name="applicableEnvironmentsMode"> State indicating if basic auth is enabled and for what environments it is active. </param>
        /// <param name="environments"> The list of enabled environments for Basic Auth if ApplicableEnvironmentsMode is set to SpecifiedEnvironments. </param>
        /// <param name="secretState"> State indicating if basic auth has a secret and what type it is. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.StaticSiteBasicAuthPropertyData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static StaticSiteBasicAuthPropertyData StaticSiteBasicAuthPropertyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string password, Uri secretUri, string applicableEnvironmentsMode, IEnumerable<string> environments, string secretState, string kind)
        {
            return StaticSiteBasicAuthPropertyData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                password,
                secretUri,
                applicableEnvironmentsMode,
                environments?.ToList(),
                secretState);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.StaticSiteBuildData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="buildId"> An identifier for the static site build. </param>
        /// <param name="sourceBranch"> The source branch. </param>
        /// <param name="pullRequestTitle"> The title of a pull request that a static site build is related to. </param>
        /// <param name="hostname"> The hostname for a static site build. </param>
        /// <param name="createdOn"> When this build was created. </param>
        /// <param name="lastUpdatedOn"> When this build was updated. </param>
        /// <param name="status"> The status of the static site build. </param>
        /// <param name="userProvidedFunctionApps"> User provided function apps registered with the static site build. </param>
        /// <param name="linkedBackends"> Backends linked to the static side build. </param>
        /// <param name="databaseConnections"> Database connections for the static site build. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.StaticSiteBuildData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static StaticSiteBuildData StaticSiteBuildData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string buildId, string sourceBranch, string pullRequestTitle, string hostname, DateTimeOffset? createdOn, DateTimeOffset? lastUpdatedOn, StaticSiteBuildStatus? status, IEnumerable<StaticSiteUserProvidedFunctionAppData> userProvidedFunctionApps, IEnumerable<StaticSiteLinkedBackendInfo> linkedBackends, IEnumerable<StaticSiteDatabaseConnectionOverview> databaseConnections, string kind)
        {
            return StaticSiteBuildData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                buildId,
                sourceBranch,
                pullRequestTitle,
                hostname,
                createdOn,
                lastUpdatedOn,
                status,
                userProvidedFunctionApps?.ToList(),
                linkedBackends?.ToList(),
                databaseConnections?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="AppService.StaticSiteCustomDomainOverviewData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="domainName"> The domain name for the static site custom domain. </param>
        /// <param name="createdOn"> The date and time on which the custom domain was created for the static site. </param>
        /// <param name="status"> The status of the custom domain. </param>
        /// <param name="validationToken"> The TXT record validation token. </param>
        /// <param name="errorMessage"></param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.StaticSiteCustomDomainOverviewData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static StaticSiteCustomDomainOverviewData StaticSiteCustomDomainOverviewData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string domainName, DateTimeOffset? createdOn, CustomDomainStatus? status, string validationToken, string errorMessage, string kind)
        {
            return StaticSiteCustomDomainOverviewData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                domainName,
                createdOn,
                status,
                validationToken,
                errorMessage);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.StaticSiteData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Description of a SKU for a scalable resource. </param>
        /// <param name="identity"> Managed service identity. </param>
        /// <param name="defaultHostname"> The default autogenerated hostname for the static site. </param>
        /// <param name="repositoryUri"> URL for the repository of the static site. </param>
        /// <param name="branch"> The target branch in the repository. </param>
        /// <param name="customDomains"> The custom domains associated with this static site. </param>
        /// <param name="repositoryToken"> A user's github repository token. This is used to setup the Github Actions workflow file and API secrets. </param>
        /// <param name="buildProperties"> Build properties to configure on the repository. </param>
        /// <param name="privateEndpointConnections"> Private endpoint connections. </param>
        /// <param name="stagingEnvironmentPolicy"> State indicating whether staging environments are allowed or not allowed for a static web app. </param>
        /// <param name="allowConfigFileUpdates"> &lt;code&gt;false&lt;/code&gt; if config file is locked for this static web app; otherwise, &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="templateProperties"> Template options for generating a new repository. </param>
        /// <param name="contentDistributionEndpoint"> The content distribution endpoint for the static site. </param>
        /// <param name="keyVaultReferenceIdentity"> Identity to use for Key Vault Reference authentication. </param>
        /// <param name="userProvidedFunctionApps"> User provided function apps registered with the static site. </param>
        /// <param name="linkedBackends"> Backends linked to the static side. </param>
        /// <param name="provider"> The provider that submitted the last deployment to the primary environment of the static site. </param>
        /// <param name="enterpriseGradeCdnStatus"> State indicating the status of the enterprise grade CDN serving traffic to the static web app. </param>
        /// <param name="publicNetworkAccess"> State indicating whether public traffic are allowed or not for a static web app. Allowed Values: 'Enabled', 'Disabled' or an empty string. </param>
        /// <param name="databaseConnections"> Database connections for the static site. </param>
        /// <param name="kind"> Kind of resource. If the resource is an app, you can refer to https://github.com/Azure/app-service-linux-docs/blob/master/Things_You_Should_Know/kind_property.md#app-service-resource-kind-reference for details supported values for kind. </param>
        /// <returns> A new <see cref="AppService.StaticSiteData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static StaticSiteData StaticSiteData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, AppServiceSkuDescription sku, ManagedServiceIdentity identity, string defaultHostname, Uri repositoryUri, string branch, IEnumerable<string> customDomains, string repositoryToken, StaticSiteBuildProperties buildProperties, IEnumerable<ResponseMessageEnvelopeRemotePrivateEndpointConnection> privateEndpointConnections, StagingEnvironmentPolicy? stagingEnvironmentPolicy, bool? allowConfigFileUpdates, StaticSiteTemplate templateProperties, string contentDistributionEndpoint, string keyVaultReferenceIdentity, IEnumerable<StaticSiteUserProvidedFunctionAppData> userProvidedFunctionApps, IEnumerable<StaticSiteLinkedBackendInfo> linkedBackends, string provider, EnterpriseGradeCdnStatus? enterpriseGradeCdnStatus, string publicNetworkAccess, IEnumerable<StaticSiteDatabaseConnectionOverview> databaseConnections, string kind)
        {
            return StaticSiteData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                kind,
                sku,
                identity,
                defaultHostname,
                repositoryUri,
                branch,
                customDomains?.ToList(),
                repositoryToken,
                buildProperties,
                privateEndpointConnections?.ToList(),
                stagingEnvironmentPolicy,
                allowConfigFileUpdates,
                templateProperties,
                contentDistributionEndpoint,
                keyVaultReferenceIdentity,
                userProvidedFunctionApps?.ToList(),
                linkedBackends?.ToList(),
                provider,
                enterpriseGradeCdnStatus,
                publicNetworkAccess,
                databaseConnections?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="AppService.StaticSiteDatabaseConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="resourceId"> The resource id of the database. </param>
        /// <param name="connectionIdentity"> If present, the identity is used in conjunction with connection string to connect to the database. Use of the system-assigned managed identity is indicated with the string 'SystemAssigned', while use of a user-assigned managed identity is indicated with the resource id of the managed identity resource. </param>
        /// <param name="connectionString"> The connection string to use to connect to the database. </param>
        /// <param name="region"> The region of the database resource. </param>
        /// <param name="configurationFiles"> A list of configuration files associated with this database connection. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.StaticSiteDatabaseConnectionData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static StaticSiteDatabaseConnectionData StaticSiteDatabaseConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier resourceId, string connectionIdentity, string connectionString, string region, IEnumerable<StaticSiteDatabaseConnectionConfigurationFileOverview> configurationFiles, string kind)
        {
            return StaticSiteDatabaseConnectionData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                resourceId,
                connectionIdentity,
                connectionString,
                region,
                configurationFiles?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="AppService.StaticSiteLinkedBackendData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="backendResourceId"> The resource id of the backend linked to the static site. </param>
        /// <param name="region"> The region of the backend linked to the static site. </param>
        /// <param name="createdOn"> The date and time on which the backend was linked to the static site. </param>
        /// <param name="provisioningState"> The provisioning state of the linking process. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.StaticSiteLinkedBackendData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static StaticSiteLinkedBackendData StaticSiteLinkedBackendData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier backendResourceId, string region, DateTimeOffset? createdOn, string provisioningState, string kind)
        {
            return StaticSiteLinkedBackendData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                backendResourceId,
                region,
                createdOn,
                provisioningState);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.StaticSiteUserProvidedFunctionAppData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="functionAppResourceId"> The resource id of the function app registered with the static site. </param>
        /// <param name="functionAppRegion"> The region of the function app registered with the static site. </param>
        /// <param name="createdOn"> The date and time on which the function app was registered with the static site. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.StaticSiteUserProvidedFunctionAppData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static StaticSiteUserProvidedFunctionAppData StaticSiteUserProvidedFunctionAppData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier functionAppResourceId, string functionAppRegion, DateTimeOffset? createdOn, string kind)
        {
            return StaticSiteUserProvidedFunctionAppData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                functionAppResourceId,
                functionAppRegion,
                createdOn);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.SwiftVirtualNetworkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="subnetResourceId"> The Virtual Network subnet's resource ID. This is the subnet that this Web App will join. This subnet must have a delegation to Microsoft.Web/serverFarms defined first. </param>
        /// <param name="isSwiftSupported"> A flag that specifies if the scale unit this Web App is on supports Swift integration. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.SwiftVirtualNetworkData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static SwiftVirtualNetworkData SwiftVirtualNetworkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier subnetResourceId, bool? isSwiftSupported, string kind)
        {
            return SwiftVirtualNetworkData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                subnetResourceId,
                isSwiftSupported);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.TopLevelDomainData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="isDomainPrivacySupported"> If &lt;code&gt;true&lt;/code&gt;, then the top level domain supports domain privacy; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.TopLevelDomainData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static TopLevelDomainData TopLevelDomainData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? isDomainPrivacySupported, string kind)
        {
            return TopLevelDomainData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                isDomainPrivacySupported);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.TriggeredJobHistoryData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="runs"> List of triggered web job runs. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.TriggeredJobHistoryData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static TriggeredJobHistoryData TriggeredJobHistoryData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IEnumerable<TriggeredJobRun> runs, string kind)
        {
            return TriggeredJobHistoryData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                runs?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="AppService.TriggeredWebJobData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="latestRun"> Latest job run information. </param>
        /// <param name="historyUri"> History URL. </param>
        /// <param name="schedulerLogsUri"> Scheduler Logs URL. </param>
        /// <param name="runCommand"> Run command. </param>
        /// <param name="uri"> Job URL. </param>
        /// <param name="extraInfoUri"> Extra Info URL. </param>
        /// <param name="webJobType"> Job type. </param>
        /// <param name="error"> Error information. </param>
        /// <param name="isUsingSdk"> Using SDK?. </param>
        /// <param name="publicNetworkAccess"> Property to allow or block all public traffic. Allowed Values: 'Enabled', 'Disabled' or an empty string. </param>
        /// <param name="isStorageAccountRequired"> Checks if Customer provided storage account is required. </param>
        /// <param name="settings"> Job settings. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.TriggeredWebJobData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static TriggeredWebJobData TriggeredWebJobData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, TriggeredJobRun latestRun, Uri historyUri, Uri schedulerLogsUri, string runCommand, Uri uri, Uri extraInfoUri, WebJobType? webJobType, string error, bool? isUsingSdk, string publicNetworkAccess, bool? isStorageAccountRequired, IDictionary<string, BinaryData> settings, string kind)
        {
            return TriggeredWebJobData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                latestRun,
                historyUri,
                schedulerLogsUri,
                runCommand,
                uri,
                extraInfoUri,
                webJobType,
                error,
                isUsingSdk,
                publicNetworkAccess,
                isStorageAccountRequired,
                settings);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.WebAppBackupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="backupId"> Id of the backup. </param>
        /// <param name="storageAccountUri"> SAS URL for the storage account container which contains this backup. </param>
        /// <param name="blobName"> Name of the blob which contains data for this backup. </param>
        /// <param name="backupName"> Name of this backup. </param>
        /// <param name="status"> Backup status. </param>
        /// <param name="sizeInBytes"> Size of the backup in bytes. </param>
        /// <param name="createdOn"> Timestamp of the backup creation. </param>
        /// <param name="log"> Details regarding this backup. Might contain an error message. </param>
        /// <param name="databases"> List of databases included in the backup. </param>
        /// <param name="isScheduled"> True if this backup has been created due to a schedule being triggered. </param>
        /// <param name="lastRestoreOn"> Timestamp of a last restore operation which used this backup. </param>
        /// <param name="finishedOn"> Timestamp when this backup finished. </param>
        /// <param name="correlationId"> Unique correlation identifier. Please use this along with the timestamp while communicating with Azure support. </param>
        /// <param name="websiteSizeInBytes"> Size of the original web app which has been backed up. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.WebAppBackupData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static WebAppBackupData WebAppBackupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? backupId, Uri storageAccountUri, string blobName, string backupName, WebAppBackupStatus? status, long? sizeInBytes, DateTimeOffset? createdOn, string log, IEnumerable<AppServiceDatabaseBackupSetting> databases, bool? isScheduled, DateTimeOffset? lastRestoreOn, DateTimeOffset? finishedOn, string correlationId, long? websiteSizeInBytes, string kind)
        {
            return WebAppBackupData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                backupId,
                storageAccountUri,
                blobName,
                backupName,
                status,
                sizeInBytes,
                createdOn,
                log,
                databases?.ToList(),
                isScheduled,
                lastRestoreOn,
                finishedOn,
                correlationId,
                websiteSizeInBytes);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.WebAppDeploymentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="status"> Deployment status. </param>
        /// <param name="message"> Details about deployment status. </param>
        /// <param name="author"> Who authored the deployment. </param>
        /// <param name="deployer"> Who performed the deployment. </param>
        /// <param name="authorEmail"> Author email. </param>
        /// <param name="startOn"> Start time. </param>
        /// <param name="endOn"> End time. </param>
        /// <param name="isActive"> True if deployment is currently active, false if completed and null if not started. </param>
        /// <param name="details"> Details on deployment. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.WebAppDeploymentData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static WebAppDeploymentData WebAppDeploymentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? status, string message, string author, string deployer, string authorEmail, DateTimeOffset? startOn, DateTimeOffset? endOn, bool? isActive, string details, string kind)
        {
            return WebAppDeploymentData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                status,
                message,
                author,
                deployer,
                authorEmail,
                startOn,
                endOn,
                isActive,
                details);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.WebJobData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="runCommand"> Run command. </param>
        /// <param name="uri"> Job URL. </param>
        /// <param name="extraInfoUri"> Extra Info URL. </param>
        /// <param name="webJobType"> Job type. </param>
        /// <param name="error"> Error information. </param>
        /// <param name="isUsingSdk"> Using SDK?. </param>
        /// <param name="settings"> Job settings. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.WebJobData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static WebJobData WebJobData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string runCommand, Uri uri, Uri extraInfoUri, WebJobType? webJobType, string error, bool? isUsingSdk, IDictionary<string, BinaryData> settings, string kind)
        {
            return WebJobData(
                id,
                name,
                resourceType,
                systemData,
                kind,
                runCommand,
                uri,
                extraInfoUri,
                webJobType,
                error,
                isUsingSdk,
                settings);
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
        /// <param name="outboundVnetRouting"> Property to configure various outbound traffic routing options over virtual network for a site. </param>
        /// <param name="siteConfig"> Configuration of an App Service app. This property is not returned in response to normal create and read requests since it may contain sensitive information. </param>
        /// <param name="functionAppConfig"> Configuration specific of the Azure Function app. </param>
        /// <param name="daprConfig"> Dapr configuration of the app. </param>
        /// <param name="workloadProfileName"> Workload profile name for function app to execute on. </param>
        /// <param name="resourceConfig"> Function app resource requirements. </param>
        /// <param name="trafficManagerHostNames"> Azure Traffic Manager hostnames associated with the app. Read-only. </param>
        /// <param name="isScmSiteAlsoStopped"> &lt;code&gt;true&lt;/code&gt; to stop SCM (KUDU) site when the app is stopped; otherwise, &lt;code&gt;false&lt;/code&gt;. The default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="targetSwapSlot"> Specifies which deployment slot this app will swap into. Read-only. </param>
        /// <param name="hostingEnvironmentProfile"> App Service Environment to use for the app. </param>
        /// <param name="isClientAffinityEnabled"> &lt;code&gt;true&lt;/code&gt; to enable client affinity; &lt;code&gt;false&lt;/code&gt; to stop sending session affinity cookies, which route client requests in the same session to the same instance. Default is &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="isClientAffinityPartitioningEnabled"> &lt;code&gt;true&lt;/code&gt; to enable client affinity partitioning using CHIPS cookies, this will add the &lt;code&gt;partitioned&lt;/code&gt; property to the affinity cookies; &lt;code&gt;false&lt;/code&gt; to stop sending partitioned affinity cookies. Default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isClientAffinityProxyEnabled"> &lt;code&gt;true&lt;/code&gt; to override client affinity cookie domain with X-Forwarded-Host request header. &lt;code&gt;false&lt;/code&gt; to use default domain. Default is &lt;code&gt;false&lt;/code&gt;. </param>
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
        /// <param name="isSshEnabled"> Whether to enable ssh access. </param>
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
        public static WebSiteData WebSiteData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, ExtendedLocation extendedLocation, string state, IEnumerable<string> hostNames, string repositorySiteName, AppServiceUsageState? usageState, bool? isEnabled, IEnumerable<string> enabledHostNames, WebSiteAvailabilityState? availabilityState, IEnumerable<HostNameSslState> hostNameSslStates, ResourceIdentifier appServicePlanId, bool? isReserved, bool? isXenon, bool? isHyperV, DateTimeOffset? lastModifiedTimeUtc, SiteDnsConfig dnsConfiguration, OutboundVnetRouting outboundVnetRouting, SiteConfigProperties siteConfig, FunctionAppConfig functionAppConfig, AppDaprConfig daprConfig, string workloadProfileName, FunctionAppResourceConfig resourceConfig, IEnumerable<string> trafficManagerHostNames, bool? isScmSiteAlsoStopped, string targetSwapSlot, HostingEnvironmentProfile hostingEnvironmentProfile, bool? isClientAffinityEnabled, bool? isClientAffinityPartitioningEnabled, bool? isClientAffinityProxyEnabled, bool? isClientCertEnabled, ClientCertMode? clientCertMode, string clientCertExclusionPaths, AppServiceIPMode? ipMode, bool? isEndToEndEncryptionEnabled, bool? isSshEnabled, bool? isHostNameDisabled, string customDomainVerificationId, string outboundIPAddresses, string possibleOutboundIPAddresses, int? containerSize, int? dailyMemoryTimeQuota, DateTimeOffset? suspendOn, int? maxNumberOfWorkers, CloningInfo cloningInfo, string resourceGroup, bool? isDefaultContainer, string defaultHostName, SlotSwapStatus slotSwapStatus, bool? isHttpsOnly, RedundancyMode? redundancyMode, Guid? inProgressOperationId, string publicNetworkAccess, bool? isStorageAccountRequired, string keyVaultReferenceIdentity, AutoGeneratedDomainNameLabelScope? autoGeneratedDomainNameLabelScope, ResourceIdentifier virtualNetworkSubnetId, string managedEnvironmentId, string sku, string kind)
        {
            return WebSiteData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                identity,
                extendedLocation,
                kind,
                state,
                hostNames?.ToList(),
                repositorySiteName,
                usageState,
                isEnabled,
                enabledHostNames?.ToList(),
                availabilityState,
                hostNameSslStates?.ToList(),
                appServicePlanId,
                isReserved,
                isXenon,
                isHyperV,
                lastModifiedTimeUtc,
                dnsConfiguration,
                outboundVnetRouting,
                siteConfig,
                functionAppConfig,
                daprConfig,
                workloadProfileName,
                resourceConfig,
                trafficManagerHostNames?.ToList(),
                isScmSiteAlsoStopped,
                targetSwapSlot,
                hostingEnvironmentProfile,
                isClientAffinityEnabled,
                isClientAffinityPartitioningEnabled,
                isClientAffinityProxyEnabled,
                isClientCertEnabled,
                clientCertMode,
                clientCertExclusionPaths,
                ipMode,
                isEndToEndEncryptionEnabled,
                isSshEnabled,
                isHostNameDisabled,
                customDomainVerificationId,
                outboundIPAddresses,
                possibleOutboundIPAddresses,
                containerSize,
                dailyMemoryTimeQuota,
                suspendOn,
                maxNumberOfWorkers,
                cloningInfo,
                resourceGroup,
                isDefaultContainer,
                defaultHostName,
                slotSwapStatus,
                isHttpsOnly,
                redundancyMode,
                inProgressOperationId,
                publicNetworkAccess,
                isStorageAccountRequired,
                keyVaultReferenceIdentity,
                autoGeneratedDomainNameLabelScope,
                virtualNetworkSubnetId,
                managedEnvironmentId,
                sku);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.WorkflowEnvelopeData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The resource kind. </param>
        /// <param name="location"> The resource location. </param>
        /// <param name="properties"> Additional workflow properties. </param>
        /// <returns> A new <see cref="AppService.WorkflowEnvelopeData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static WorkflowEnvelopeData WorkflowEnvelopeData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, AzureLocation? location, WorkflowEnvelopeProperties properties)
        {
            return WorkflowEnvelopeData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                kind,
                location);
        }

        /// <summary> Initializes a new instance of <see cref="Models.WorkflowHealth"/>. </summary>
        /// <param name="state"> Gets or sets the workflow health state. </param>
        /// <param name="error"> Gets or sets the workflow error. </param>
        /// <returns> A new <see cref="Models.WorkflowHealth"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static WorkflowHealth WorkflowHealth(WorkflowHealthState state, ResponseError error)
        {
            return WorkflowHealth(state, error);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.AppServiceDomainData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="contactAdmin"> Administrative contact. </param>
        /// <param name="contactBilling"> Billing contact. </param>
        /// <param name="contactRegistrant"> Registrant contact. </param>
        /// <param name="contactTech"> Technical contact. </param>
        /// <param name="registrationStatus"> Domain registration status. </param>
        /// <param name="provisioningState"> Domain provisioning state. </param>
        /// <param name="nameServers"> Name servers. </param>
        /// <param name="isDomainPrivacyEnabled"> &lt;code&gt;true&lt;/code&gt; if domain privacy is enabled for this domain; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="createdOn"> Domain creation timestamp. </param>
        /// <param name="expireOn"> Domain expiration timestamp. </param>
        /// <param name="lastRenewedOn"> Timestamp when the domain was renewed last time. </param>
        /// <param name="isAutoRenew"> &lt;code&gt;true&lt;/code&gt; if the domain should be automatically renewed; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isDnsRecordManagementReady">
        /// &lt;code&gt;true&lt;/code&gt; if Azure can assign this domain to App Service apps; otherwise, &lt;code&gt;false&lt;/code&gt;. This value will be &lt;code&gt;true&lt;/code&gt; if domain registration status is active and
        ///  it is hosted on name servers Azure has programmatic access to.
        /// </param>
        /// <param name="managedHostNames"> All hostnames derived from the domain and assigned to Azure resources. </param>
        /// <param name="consent"> Legal agreement consent. </param>
        /// <param name="domainNotRenewableReasons"> Reasons why domain is not renewable. </param>
        /// <param name="dnsType"> Current DNS type. </param>
        /// <param name="dnsZoneId"> Azure DNS Zone to use. </param>
        /// <param name="targetDnsType"> Target DNS type (would be used for migration). </param>
        /// <param name="authCode"></param>
        /// <param name="kind"> Kind of resource. If the resource is an app, you can refer to https://github.com/Azure/app-service-linux-docs/blob/master/Things_You_Should_Know/kind_property.md#app-service-resource-kind-reference for details supported values for kind. </param>
        /// <returns> A new <see cref="AppService.AppServiceDomainData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static AppServiceDomainData AppServiceDomainData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, RegistrationContactInfo contactAdmin, RegistrationContactInfo contactBilling, RegistrationContactInfo contactRegistrant, RegistrationContactInfo contactTech, AppServiceDomainStatus? registrationStatus, ProvisioningState? provisioningState, IEnumerable<string> nameServers, bool? isDomainPrivacyEnabled, DateTimeOffset? createdOn, DateTimeOffset? expireOn, DateTimeOffset? lastRenewedOn, bool? isAutoRenew, bool? isDnsRecordManagementReady, IEnumerable<AppServiceHostName> managedHostNames, DomainPurchaseConsent consent, IEnumerable<DomainNotRenewableReason> domainNotRenewableReasons, AppServiceDnsType? dnsType, string dnsZoneId, AppServiceDnsType? targetDnsType, string authCode, string kind)
        {
            return AppServiceDomainData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                kind,
                contactAdmin,
                contactBilling,
                contactRegistrant,
                contactTech,
                registrationStatus,
                provisioningState,
                nameServers?.ToList(),
                isDomainPrivacyEnabled,
                createdOn,
                expireOn,
                lastRenewedOn,
                isAutoRenew,
                isDnsRecordManagementReady,
                managedHostNames?.ToList(),
                consent,
                domainNotRenewableReasons?.ToList(),
                dnsType,
                dnsZoneId,
                targetDnsType,
                authCode);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.AppServiceEnvironmentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Provisioning state of the App Service Environment. </param>
        /// <param name="status"> Current status of the App Service Environment. </param>
        /// <param name="virtualNetwork"> Description of the Virtual Network. </param>
        /// <param name="internalLoadBalancingMode"> Specifies which endpoints to serve internally in the Virtual Network for the App Service Environment. </param>
        /// <param name="multiSize"> Front-end VM size, e.g. "Medium", "Large". </param>
        /// <param name="multiRoleCount"> Number of front-end instances. </param>
        /// <param name="ipSslAddressCount"> Number of IP SSL addresses reserved for the App Service Environment. </param>
        /// <param name="dnsSuffix"> DNS suffix of the App Service Environment. </param>
        /// <param name="maximumNumberOfMachines"> Maximum number of VMs in the App Service Environment. </param>
        /// <param name="frontEndScaleFactor"> Scale factor for front-ends. </param>
        /// <param name="isSuspended">
        /// &lt;code&gt;true&lt;/code&gt; if the App Service Environment is suspended; otherwise, &lt;code&gt;false&lt;/code&gt;. The environment can be suspended, e.g. when the management endpoint is no longer available
        ///  (most likely because NSG blocked the incoming traffic).
        /// </param>
        /// <param name="clusterSettings"> Custom settings for changing the behavior of the App Service Environment. </param>
        /// <param name="userWhitelistedIPRanges"> User added ip ranges to whitelist on ASE db. </param>
        /// <param name="hasLinuxWorkers"> Flag that displays whether an ASE has linux workers or not. </param>
        /// <param name="upgradePreference"> Upgrade Preference. </param>
        /// <param name="dedicatedHostCount"> Dedicated Host Count. </param>
        /// <param name="isZoneRedundant"> Whether or not this App Service Environment is zone-redundant. </param>
        /// <param name="customDnsSuffixConfiguration"> Full view of the custom domain suffix configuration for ASEv3. </param>
        /// <param name="networkingConfiguration"> Full view of networking configuration for an ASE. </param>
        /// <param name="upgradeAvailability"> Whether an upgrade is available for this App Service Environment. </param>
        /// <param name="kind"> Kind of resource. If the resource is an app, you can refer to https://github.com/Azure/app-service-linux-docs/blob/master/Things_You_Should_Know/kind_property.md#app-service-resource-kind-reference for details supported values for kind. </param>
        /// <returns> A new <see cref="AppService.AppServiceEnvironmentData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static AppServiceEnvironmentData AppServiceEnvironmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ProvisioningState? provisioningState, HostingEnvironmentStatus? status, AppServiceVirtualNetworkProfile virtualNetwork, LoadBalancingMode? internalLoadBalancingMode, string multiSize, int? multiRoleCount, int? ipSslAddressCount, string dnsSuffix, int? maximumNumberOfMachines, int? frontEndScaleFactor, bool? isSuspended, IEnumerable<AppServiceNameValuePair> clusterSettings, IEnumerable<string> userWhitelistedIPRanges, bool? hasLinuxWorkers, AppServiceEnvironmentUpgradePreference? upgradePreference, int? dedicatedHostCount, bool? isZoneRedundant, CustomDnsSuffixConfigurationData customDnsSuffixConfiguration, AseV3NetworkingConfigurationData networkingConfiguration, AppServiceEnvironmentUpgradeAvailability? upgradeAvailability, string kind)
        {
            return AppServiceEnvironmentData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                kind,
                provisioningState,
                status,
                virtualNetwork,
                internalLoadBalancingMode,
                multiSize,
                multiRoleCount,
                ipSslAddressCount,
                dnsSuffix,
                maximumNumberOfMachines,
                frontEndScaleFactor,
                isSuspended,
                clusterSettings?.ToList(),
                userWhitelistedIPRanges?.ToList(),
                hasLinuxWorkers,
                upgradePreference,
                dedicatedHostCount,
                isZoneRedundant,
                customDnsSuffixConfiguration,
                networkingConfiguration,
                upgradeAvailability);
        }

        /// <summary> Initializes a new instance of <see cref="AppService.AppServiceWorkerPoolData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sku"> Description of a SKU for a scalable resource. </param>
        /// <param name="workerSizeId"> Worker size ID for referencing this worker pool. </param>
        /// <param name="computeMode"> Shared or dedicated app hosting. </param>
        /// <param name="workerSize"> VM size of the worker pool instances. </param>
        /// <param name="workerCount"> Number of instances in the worker pool. </param>
        /// <param name="instanceNames"> Names of all instances in the worker pool (read only). </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <returns> A new <see cref="AppService.AppServiceWorkerPoolData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static AppServiceWorkerPoolData AppServiceWorkerPoolData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AppServiceSkuDescription sku, int? workerSizeId, ComputeModeOption? computeMode, string workerSize, int? workerCount, IEnumerable<string> instanceNames, string kind)
        {
            return AppServiceWorkerPoolData(
                id,
                name,
                resourceType,
                systemData,
                sku,
                kind,
                workerSizeId,
                computeMode,
                workerSize,
                workerCount,
                instanceNames?.ToList());
        }
    }
}
