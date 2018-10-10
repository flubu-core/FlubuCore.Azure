
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Vmss;

namespace FlubuCore.Azure
{
    public class Vmss
    {
        
        
            public AzureVmssCreateTask VmssCreate(string image ,  string name ,  string resourceGroup)
            {
                return new AzureVmssCreateTask(image,  name,  resourceGroup);
            }

            public AzureVmssDeallocateTask VmssDeallocate(string name ,  string resourceGroup)
            {
                return new AzureVmssDeallocateTask(name,  resourceGroup);
            }

            public AzureVmssDeleteTask VmssDelete(string name ,  string resourceGroup)
            {
                return new AzureVmssDeleteTask(name,  resourceGroup);
            }

            public AzureVmssDeleteInstancesTask VmssDeleteInstances(string instanceIds ,  string name ,  string resourceGroup)
            {
                return new AzureVmssDeleteInstancesTask(instanceIds,  name,  resourceGroup);
            }

            public AzureVmssGetInstanceViewTask VmssGetInstanceView(string name ,  string resourceGroup)
            {
                return new AzureVmssGetInstanceViewTask(name,  resourceGroup);
            }

            public AzureVmssPerformMaintenanceTask VmssPerformMaintenance(string name ,  string resourceGroup)
            {
                return new AzureVmssPerformMaintenanceTask(name,  resourceGroup);
            }

            public AzureVmssReimageTask VmssReimage(string name ,  string resourceGroup)
            {
                return new AzureVmssReimageTask(name,  resourceGroup);
            }

            public AzureVmssRestartTask VmssRestart(string name ,  string resourceGroup)
            {
                return new AzureVmssRestartTask(name,  resourceGroup);
            }

            public AzureVmssScaleTask VmssScale(string name ,  string newCapacity ,  string resourceGroup)
            {
                return new AzureVmssScaleTask(name,  newCapacity,  resourceGroup);
            }

            public AzureVmssStartTask VmssStart(string name ,  string resourceGroup)
            {
                return new AzureVmssStartTask(name,  resourceGroup);
            }

            public AzureVmssStopTask VmssStop(string name ,  string resourceGroup)
            {
                return new AzureVmssStopTask(name,  resourceGroup);
            }

            public AzureVmssUpdateTask VmssUpdate(string name ,  string resourceGroup)
            {
                return new AzureVmssUpdateTask(name,  resourceGroup);
            }

            public AzureVmssUpdateInstancesTask VmssUpdateInstances(string instanceIds ,  string name ,  string resourceGroup)
            {
                return new AzureVmssUpdateInstancesTask(instanceIds,  name,  resourceGroup);
            }

            public AzureVmssWaitTask VmssWait(string name ,  string resourceGroup)
            {
                return new AzureVmssWaitTask(name,  resourceGroup);
            }

            public AzureVmssDiagnosticsTask VmssDiagnostics()
            {
                return new AzureVmssDiagnosticsTask();
            }

            public AzureVmssDiagnosticsGetDefaultConfigTask VmssDiagnosticsGetDefaultConfig()
            {
                return new AzureVmssDiagnosticsGetDefaultConfigTask();
            }

            public AzureVmssDiagnosticsSetTask VmssDiagnosticsSet(string resourceGroup ,  string settings ,  string vmssName)
            {
                return new AzureVmssDiagnosticsSetTask(resourceGroup,  settings,  vmssName);
            }

            public AzureVmssDiskTask VmssDisk()
            {
                return new AzureVmssDiskTask();
            }

            public AzureVmssDiskAttachTask VmssDiskAttach(string name ,  string resourceGroup)
            {
                return new AzureVmssDiskAttachTask(name,  resourceGroup);
            }

            public AzureVmssDiskDetachTask VmssDiskDetach(string lun ,  string name ,  string resourceGroup)
            {
                return new AzureVmssDiskDetachTask(lun,  name,  resourceGroup);
            }

            public AzureVmssEncryptionTask VmssEncryption()
            {
                return new AzureVmssEncryptionTask();
            }

            public AzureVmssEncryptionDisableTask VmssEncryptionDisable(string name ,  string resourceGroup)
            {
                return new AzureVmssEncryptionDisableTask(name,  resourceGroup);
            }

            public AzureVmssEncryptionEnableTask VmssEncryptionEnable(string diskEncryptionKeyvault ,  string name ,  string resourceGroup)
            {
                return new AzureVmssEncryptionEnableTask(diskEncryptionKeyvault,  name,  resourceGroup);
            }

            public AzureVmssExtensionTask VmssExtension()
            {
                return new AzureVmssExtensionTask();
            }

            public AzureVmssExtensionDeleteTask VmssExtensionDelete(string name ,  string resourceGroup ,  string vmssName)
            {
                return new AzureVmssExtensionDeleteTask(name,  resourceGroup,  vmssName);
            }

            public AzureVmssExtensionSetTask VmssExtensionSet(string name ,  string publisher ,  string resourceGroup ,  string vmssName)
            {
                return new AzureVmssExtensionSetTask(name,  publisher,  resourceGroup,  vmssName);
            }

            public AzureVmssIdentityTask VmssIdentity()
            {
                return new AzureVmssIdentityTask();
            }

            public AzureVmssIdentityAssignTask VmssIdentityAssign(string name ,  string resourceGroup)
            {
                return new AzureVmssIdentityAssignTask(name,  resourceGroup);
            }

            public AzureVmssIdentityRemoveTask VmssIdentityRemove(string name ,  string resourceGroup)
            {
                return new AzureVmssIdentityRemoveTask(name,  resourceGroup);
            }

            public AzureVmssNicTask VmssNic()
            {
                return new AzureVmssNicTask();
            }

            public AzureVmssRollingUpgradeTask VmssRollingUpgrade()
            {
                return new AzureVmssRollingUpgradeTask();
            }

            public AzureVmssRollingUpgradeCancelTask VmssRollingUpgradeCancel(string name ,  string resourceGroup)
            {
                return new AzureVmssRollingUpgradeCancelTask(name,  resourceGroup);
            }

            public AzureVmssRollingUpgradeGetLatestTask VmssRollingUpgradeGetLatest(string name ,  string resourceGroup)
            {
                return new AzureVmssRollingUpgradeGetLatestTask(name,  resourceGroup);
            }

            public AzureVmssRollingUpgradeStartTask VmssRollingUpgradeStart(string name ,  string resourceGroup)
            {
                return new AzureVmssRollingUpgradeStartTask(name,  resourceGroup);
            }

            public AzureVmssExtensionImageTask VmssExtensionImage()
            {
                return new AzureVmssExtensionImageTask();
            }
        
    }
}

