
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Aks;

namespace FlubuCore.Azure
{
    public class Aks
    {
        
        
            public AzureAksBrowseTask AksBrowse(string name ,  string resourceGroup)
            {
                return new AzureAksBrowseTask(name,  resourceGroup);
            }

            public AzureAksCreateTask AksCreate(string name ,  string resourceGroup)
            {
                return new AzureAksCreateTask(name,  resourceGroup);
            }

            public AzureAksDeleteTask AksDelete(string name ,  string resourceGroup)
            {
                return new AzureAksDeleteTask(name,  resourceGroup);
            }

            public AzureAksDisableAddonsTask AksDisableAddons(string addons ,  string name ,  string resourceGroup)
            {
                return new AzureAksDisableAddonsTask(addons,  name,  resourceGroup);
            }

            public AzureAksEnableAddonsTask AksEnableAddons(string addons ,  string name ,  string resourceGroup)
            {
                return new AzureAksEnableAddonsTask(addons,  name,  resourceGroup);
            }

            public AzureAksGetCredentialsTask AksGetCredentials(string name ,  string resourceGroup)
            {
                return new AzureAksGetCredentialsTask(name,  resourceGroup);
            }

            public AzureAksGetUpgradesTask AksGetUpgrades(string name ,  string resourceGroup)
            {
                return new AzureAksGetUpgradesTask(name,  resourceGroup);
            }

            public AzureAksGetVersionsTask AksGetVersions(string location)
            {
                return new AzureAksGetVersionsTask(location);
            }

            public AzureAksInstallCliTask AksInstallCli()
            {
                return new AzureAksInstallCliTask();
            }

            public AzureAksInstallConnectorTask AksInstallConnector(string name ,  string resourceGroup)
            {
                return new AzureAksInstallConnectorTask(name,  resourceGroup);
            }

            public AzureAksRemoveConnectorTask AksRemoveConnector(string name ,  string resourceGroup)
            {
                return new AzureAksRemoveConnectorTask(name,  resourceGroup);
            }

            public AzureAksRemoveDevSpacesTask AksRemoveDevSpaces(string name ,  string resourceGroup)
            {
                return new AzureAksRemoveDevSpacesTask(name,  resourceGroup);
            }

            public AzureAksScaleTask AksScale(string name ,  string nodeCount ,  string resourceGroup)
            {
                return new AzureAksScaleTask(name,  nodeCount,  resourceGroup);
            }

            public AzureAksUpgradeTask AksUpgrade(string kubernetesVersion ,  string name ,  string resourceGroup)
            {
                return new AzureAksUpgradeTask(kubernetesVersion,  name,  resourceGroup);
            }

            public AzureAksUpgradeConnectorTask AksUpgradeConnector(string name ,  string resourceGroup)
            {
                return new AzureAksUpgradeConnectorTask(name,  resourceGroup);
            }

            public AzureAksUseDevSpacesTask AksUseDevSpaces(string name ,  string resourceGroup)
            {
                return new AzureAksUseDevSpacesTask(name,  resourceGroup);
            }

            public AzureAksWaitTask AksWait(string name ,  string resourceGroup)
            {
                return new AzureAksWaitTask(name,  resourceGroup);
            }
        
    }
}

