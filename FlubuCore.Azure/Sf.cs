
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Sf;

namespace FlubuCore.Azure
{
    public class Sf
    {
        
        
            public AzureSfApplicationTask SfApplication()
            {
                return new AzureSfApplicationTask();
            }

            public AzureSfClusterTask SfCluster()
            {
                return new AzureSfClusterTask();
            }

            public AzureSfClusterCreateTask SfClusterCreate(string location ,  string resourceGroup)
            {
                return new AzureSfClusterCreateTask(location,  resourceGroup);
            }

            public AzureSfApplicationCertificateTask SfApplicationCertificate()
            {
                return new AzureSfApplicationCertificateTask();
            }

            public AzureSfApplicationCertificateAddTask SfApplicationCertificateAdd(string clusterName ,  string resourceGroup)
            {
                return new AzureSfApplicationCertificateAddTask(clusterName,  resourceGroup);
            }

            public AzureSfClusterCertificateTask SfClusterCertificate()
            {
                return new AzureSfClusterCertificateTask();
            }

            public AzureSfClusterCertificateAddTask SfClusterCertificateAdd(string clusterName ,  string resourceGroup)
            {
                return new AzureSfClusterCertificateAddTask(clusterName,  resourceGroup);
            }

            public AzureSfClusterCertificateRemoveTask SfClusterCertificateRemove(string clusterName ,  string resourceGroup ,  string thumbprint)
            {
                return new AzureSfClusterCertificateRemoveTask(clusterName,  resourceGroup,  thumbprint);
            }

            public AzureSfClusterClientCertificateTask SfClusterClientCertificate()
            {
                return new AzureSfClusterClientCertificateTask();
            }

            public AzureSfClusterClientCertificateAddTask SfClusterClientCertificateAdd(string clusterName ,  string resourceGroup)
            {
                return new AzureSfClusterClientCertificateAddTask(clusterName,  resourceGroup);
            }

            public AzureSfClusterClientCertificateRemoveTask SfClusterClientCertificateRemove(string clusterName ,  string resourceGroup)
            {
                return new AzureSfClusterClientCertificateRemoveTask(clusterName,  resourceGroup);
            }

            public AzureSfClusterDurabilityTask SfClusterDurability()
            {
                return new AzureSfClusterDurabilityTask();
            }

            public AzureSfClusterDurabilityUpdateTask SfClusterDurabilityUpdate(string clusterName ,  string durabilityLevel ,  string nodeType ,  string resourceGroup)
            {
                return new AzureSfClusterDurabilityUpdateTask(clusterName,  durabilityLevel,  nodeType,  resourceGroup);
            }

            public AzureSfClusterNodeTypeTask SfClusterNodeType()
            {
                return new AzureSfClusterNodeTypeTask();
            }

            public AzureSfClusterNodeTypeAddTask SfClusterNodeTypeAdd(string capacity ,  string clusterName ,  string nodeType ,  string resourceGroup ,  string vmPassword ,  string vmUserName)
            {
                return new AzureSfClusterNodeTypeAddTask(capacity,  clusterName,  nodeType,  resourceGroup,  vmPassword,  vmUserName);
            }

            public AzureSfClusterNodeTask SfClusterNode()
            {
                return new AzureSfClusterNodeTask();
            }

            public AzureSfClusterNodeAddTask SfClusterNodeAdd(string clusterName ,  string nodeType ,  string numberOfNodesToAdd ,  string resourceGroup)
            {
                return new AzureSfClusterNodeAddTask(clusterName,  nodeType,  numberOfNodesToAdd,  resourceGroup);
            }

            public AzureSfClusterNodeRemoveTask SfClusterNodeRemove(string clusterName ,  string nodeType ,  string numberOfNodesToRemove ,  string resourceGroup)
            {
                return new AzureSfClusterNodeRemoveTask(clusterName,  nodeType,  numberOfNodesToRemove,  resourceGroup);
            }

            public AzureSfClusterReliabilityTask SfClusterReliability()
            {
                return new AzureSfClusterReliabilityTask();
            }

            public AzureSfClusterReliabilityUpdateTask SfClusterReliabilityUpdate(string clusterName ,  string reliabilityLevel ,  string resourceGroup)
            {
                return new AzureSfClusterReliabilityUpdateTask(clusterName,  reliabilityLevel,  resourceGroup);
            }

            public AzureSfClusterSettingTask SfClusterSetting()
            {
                return new AzureSfClusterSettingTask();
            }

            public AzureSfClusterSettingRemoveTask SfClusterSettingRemove(string clusterName ,  string resourceGroup)
            {
                return new AzureSfClusterSettingRemoveTask(clusterName,  resourceGroup);
            }

            public AzureSfClusterSettingSetTask SfClusterSettingSet(string clusterName ,  string resourceGroup)
            {
                return new AzureSfClusterSettingSetTask(clusterName,  resourceGroup);
            }

            public AzureSfClusterUpgradeTypeTask SfClusterUpgradeType()
            {
                return new AzureSfClusterUpgradeTypeTask();
            }

            public AzureSfClusterUpgradeTypeSetTask SfClusterUpgradeTypeSet(string clusterName ,  string resourceGroup ,  string upgradeMode)
            {
                return new AzureSfClusterUpgradeTypeSetTask(clusterName,  resourceGroup,  upgradeMode);
            }
        
    }
}

