
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Backup;

namespace FlubuCore.Azure
{
    public class Backup
    {
        
        
            public AzureBackupContainerTask BackupContainer()
            {
                return new AzureBackupContainerTask();
            }

            public AzureBackupItemTask BackupItem()
            {
                return new AzureBackupItemTask();
            }

            public AzureBackupItemSetPolicyTask BackupItemSetPolicy(string containerName ,  string name ,  string policyName ,  string resourceGroup ,  string vaultName)
            {
                return new AzureBackupItemSetPolicyTask(containerName,  name,  policyName,  resourceGroup,  vaultName);
            }

            public AzureBackupJobTask BackupJob()
            {
                return new AzureBackupJobTask();
            }

            public AzureBackupJobStopTask BackupJobStop(string name ,  string resourceGroup ,  string vaultName)
            {
                return new AzureBackupJobStopTask(name,  resourceGroup,  vaultName);
            }

            public AzureBackupJobWaitTask BackupJobWait(string name ,  string resourceGroup ,  string vaultName)
            {
                return new AzureBackupJobWaitTask(name,  resourceGroup,  vaultName);
            }

            public AzureBackupPolicyTask BackupPolicy()
            {
                return new AzureBackupPolicyTask();
            }

            public AzureBackupPolicyDeleteTask BackupPolicyDelete(string name ,  string resourceGroup ,  string vaultName)
            {
                return new AzureBackupPolicyDeleteTask(name,  resourceGroup,  vaultName);
            }

            public AzureBackupPolicyGetDefaultForVmTask BackupPolicyGetDefaultForVm(string resourceGroup ,  string vaultName)
            {
                return new AzureBackupPolicyGetDefaultForVmTask(resourceGroup,  vaultName);
            }

            public AzureBackupPolicySetTask BackupPolicySet(string policy ,  string resourceGroup ,  string vaultName)
            {
                return new AzureBackupPolicySetTask(policy,  resourceGroup,  vaultName);
            }

            public AzureBackupProtectionTask BackupProtection()
            {
                return new AzureBackupProtectionTask();
            }

            public AzureBackupProtectionBackupNowTask BackupProtectionBackupNow(string containerName ,  string itemName ,  string resourceGroup ,  string retainUntil ,  string vaultName)
            {
                return new AzureBackupProtectionBackupNowTask(containerName,  itemName,  resourceGroup,  retainUntil,  vaultName);
            }

            public AzureBackupProtectionCheckVmTask BackupProtectionCheckVm(string vmId)
            {
                return new AzureBackupProtectionCheckVmTask(vmId);
            }

            public AzureBackupProtectionDisableTask BackupProtectionDisable(string containerName ,  string itemName ,  string resourceGroup ,  string vaultName)
            {
                return new AzureBackupProtectionDisableTask(containerName,  itemName,  resourceGroup,  vaultName);
            }

            public AzureBackupProtectionEnableForVmTask BackupProtectionEnableForVm(string policyName ,  string resourceGroup ,  string vaultName ,  string vm)
            {
                return new AzureBackupProtectionEnableForVmTask(policyName,  resourceGroup,  vaultName,  vm);
            }

            public AzureBackupRecoverypointTask BackupRecoverypoint()
            {
                return new AzureBackupRecoverypointTask();
            }

            public AzureBackupRestoreTask BackupRestore()
            {
                return new AzureBackupRestoreTask();
            }

            public AzureBackupRestoreRestoreDisksTask BackupRestoreRestoreDisks(string containerName ,  string itemName ,  string resourceGroup ,  string rpName ,  string storageAccount ,  string vaultName)
            {
                return new AzureBackupRestoreRestoreDisksTask(containerName,  itemName,  resourceGroup,  rpName,  storageAccount,  vaultName);
            }

            public AzureBackupVaultTask BackupVault()
            {
                return new AzureBackupVaultTask();
            }

            public AzureBackupVaultCreateTask BackupVaultCreate(string location ,  string name ,  string resourceGroup)
            {
                return new AzureBackupVaultCreateTask(location,  name,  resourceGroup);
            }

            public AzureBackupVaultDeleteTask BackupVaultDelete(string name ,  string resourceGroup)
            {
                return new AzureBackupVaultDeleteTask(name,  resourceGroup);
            }

            public AzureBackupRestoreFilesTask BackupRestoreFiles()
            {
                return new AzureBackupRestoreFilesTask();
            }

            public AzureBackupRestoreFilesMountRpTask BackupRestoreFilesMountRp(string containerName ,  string itemName ,  string resourceGroup ,  string rpName ,  string vaultName)
            {
                return new AzureBackupRestoreFilesMountRpTask(containerName,  itemName,  resourceGroup,  rpName,  vaultName);
            }

            public AzureBackupRestoreFilesUnmountRpTask BackupRestoreFilesUnmountRp(string containerName ,  string itemName ,  string resourceGroup ,  string rpName ,  string vaultName)
            {
                return new AzureBackupRestoreFilesUnmountRpTask(containerName,  itemName,  resourceGroup,  rpName,  vaultName);
            }

            public AzureBackupVaultBackupPropertiesTask BackupVaultBackupProperties()
            {
                return new AzureBackupVaultBackupPropertiesTask();
            }

            public AzureBackupVaultBackupPropertiesSetTask BackupVaultBackupPropertiesSet(string backupStorageRedundancy ,  string name ,  string resourceGroup)
            {
                return new AzureBackupVaultBackupPropertiesSetTask(backupStorageRedundancy,  name,  resourceGroup);
            }
        
    }
}

