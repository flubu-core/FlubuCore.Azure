
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Keyvault;

namespace FlubuCore.Azure
{
    public class Keyvault
    {
        
        
            public AzureKeyvaultCreateTask KeyvaultCreate(string name ,  string resourceGroup)
            {
                return new AzureKeyvaultCreateTask(name,  resourceGroup);
            }

            public AzureKeyvaultDeleteTask KeyvaultDelete(string name)
            {
                return new AzureKeyvaultDeleteTask(name);
            }

            public AzureKeyvaultDeletePolicyTask KeyvaultDeletePolicy(string name)
            {
                return new AzureKeyvaultDeletePolicyTask(name);
            }

            public AzureKeyvaultPurgeTask KeyvaultPurge(string location ,  string name)
            {
                return new AzureKeyvaultPurgeTask(location,  name);
            }

            public AzureKeyvaultRecoverTask KeyvaultRecover(string location ,  string name)
            {
                return new AzureKeyvaultRecoverTask(location,  name);
            }

            public AzureKeyvaultSetPolicyTask KeyvaultSetPolicy(string name)
            {
                return new AzureKeyvaultSetPolicyTask(name);
            }

            public AzureKeyvaultUpdateTask KeyvaultUpdate(string name)
            {
                return new AzureKeyvaultUpdateTask(name);
            }

            public AzureKeyvaultCertificateTask KeyvaultCertificate()
            {
                return new AzureKeyvaultCertificateTask();
            }

            public AzureKeyvaultCertificateCreateTask KeyvaultCertificateCreate(string policy ,  string name ,  string vaultName)
            {
                return new AzureKeyvaultCertificateCreateTask(policy,  name,  vaultName);
            }

            public AzureKeyvaultCertificateDeleteTask KeyvaultCertificateDelete()
            {
                return new AzureKeyvaultCertificateDeleteTask();
            }

            public AzureKeyvaultCertificateDownloadTask KeyvaultCertificateDownload(string file)
            {
                return new AzureKeyvaultCertificateDownloadTask(file);
            }

            public AzureKeyvaultCertificateGetDefaultPolicyTask KeyvaultCertificateGetDefaultPolicy()
            {
                return new AzureKeyvaultCertificateGetDefaultPolicyTask();
            }

            public AzureKeyvaultCertificateImportTask KeyvaultCertificateImport(string file ,  string name ,  string vaultName)
            {
                return new AzureKeyvaultCertificateImportTask(file,  name,  vaultName);
            }

            public AzureKeyvaultCertificatePurgeTask KeyvaultCertificatePurge()
            {
                return new AzureKeyvaultCertificatePurgeTask();
            }

            public AzureKeyvaultCertificateRecoverTask KeyvaultCertificateRecover()
            {
                return new AzureKeyvaultCertificateRecoverTask();
            }

            public AzureKeyvaultCertificateSetAttributesTask KeyvaultCertificateSetAttributes()
            {
                return new AzureKeyvaultCertificateSetAttributesTask();
            }

            public AzureKeyvaultKeyTask KeyvaultKey()
            {
                return new AzureKeyvaultKeyTask();
            }

            public AzureKeyvaultKeyBackupTask KeyvaultKeyBackup(string file)
            {
                return new AzureKeyvaultKeyBackupTask(file);
            }

            public AzureKeyvaultKeyCreateTask KeyvaultKeyCreate(string name ,  string vaultName)
            {
                return new AzureKeyvaultKeyCreateTask(name,  vaultName);
            }

            public AzureKeyvaultKeyDeleteTask KeyvaultKeyDelete()
            {
                return new AzureKeyvaultKeyDeleteTask();
            }

            public AzureKeyvaultKeyImportTask KeyvaultKeyImport(string name ,  string vaultName)
            {
                return new AzureKeyvaultKeyImportTask(name,  vaultName);
            }

            public AzureKeyvaultKeyPurgeTask KeyvaultKeyPurge()
            {
                return new AzureKeyvaultKeyPurgeTask();
            }

            public AzureKeyvaultKeyRecoverTask KeyvaultKeyRecover()
            {
                return new AzureKeyvaultKeyRecoverTask();
            }

            public AzureKeyvaultKeyRestoreTask KeyvaultKeyRestore(string file ,  string vaultName)
            {
                return new AzureKeyvaultKeyRestoreTask(file,  vaultName);
            }

            public AzureKeyvaultKeySetAttributesTask KeyvaultKeySetAttributes()
            {
                return new AzureKeyvaultKeySetAttributesTask();
            }

            public AzureKeyvaultNetworkRuleTask KeyvaultNetworkRule()
            {
                return new AzureKeyvaultNetworkRuleTask();
            }

            public AzureKeyvaultNetworkRuleAddTask KeyvaultNetworkRuleAdd(string name)
            {
                return new AzureKeyvaultNetworkRuleAddTask(name);
            }

            public AzureKeyvaultNetworkRuleRemoveTask KeyvaultNetworkRuleRemove(string name)
            {
                return new AzureKeyvaultNetworkRuleRemoveTask(name);
            }

            public AzureKeyvaultSecretTask KeyvaultSecret()
            {
                return new AzureKeyvaultSecretTask();
            }

            public AzureKeyvaultSecretBackupTask KeyvaultSecretBackup(string filePath)
            {
                return new AzureKeyvaultSecretBackupTask(filePath);
            }

            public AzureKeyvaultSecretDeleteTask KeyvaultSecretDelete()
            {
                return new AzureKeyvaultSecretDeleteTask();
            }

            public AzureKeyvaultSecretDownloadTask KeyvaultSecretDownload(string file)
            {
                return new AzureKeyvaultSecretDownloadTask(file);
            }

            public AzureKeyvaultSecretPurgeTask KeyvaultSecretPurge()
            {
                return new AzureKeyvaultSecretPurgeTask();
            }

            public AzureKeyvaultSecretRecoverTask KeyvaultSecretRecover()
            {
                return new AzureKeyvaultSecretRecoverTask();
            }

            public AzureKeyvaultSecretRestoreTask KeyvaultSecretRestore(string filePath ,  string vaultName)
            {
                return new AzureKeyvaultSecretRestoreTask(filePath,  vaultName);
            }

            public AzureKeyvaultSecretSetTask KeyvaultSecretSet(string name ,  string vaultName)
            {
                return new AzureKeyvaultSecretSetTask(name,  vaultName);
            }

            public AzureKeyvaultSecretSetAttributesTask KeyvaultSecretSetAttributes()
            {
                return new AzureKeyvaultSecretSetAttributesTask();
            }

            public AzureKeyvaultStorageTask KeyvaultStorage()
            {
                return new AzureKeyvaultStorageTask();
            }

            public AzureKeyvaultStorageAddTask KeyvaultStorageAdd(string activeKeyName ,  string resourceId ,  string name ,  string vaultName)
            {
                return new AzureKeyvaultStorageAddTask(activeKeyName,  resourceId,  name,  vaultName);
            }

            public AzureKeyvaultStorageBackupTask KeyvaultStorageBackup(string file)
            {
                return new AzureKeyvaultStorageBackupTask(file);
            }

            public AzureKeyvaultStoragePurgeTask KeyvaultStoragePurge(string name ,  string vaultName)
            {
                return new AzureKeyvaultStoragePurgeTask(name,  vaultName);
            }

            public AzureKeyvaultStorageRecoverTask KeyvaultStorageRecover(string name ,  string vaultName)
            {
                return new AzureKeyvaultStorageRecoverTask(name,  vaultName);
            }

            public AzureKeyvaultStorageRegenerateKeyTask KeyvaultStorageRegenerateKey(string keyName)
            {
                return new AzureKeyvaultStorageRegenerateKeyTask(keyName);
            }

            public AzureKeyvaultStorageRemoveTask KeyvaultStorageRemove()
            {
                return new AzureKeyvaultStorageRemoveTask();
            }

            public AzureKeyvaultStorageRestoreTask KeyvaultStorageRestore(string filePath ,  string vaultName)
            {
                return new AzureKeyvaultStorageRestoreTask(filePath,  vaultName);
            }

            public AzureKeyvaultStorageUpdateTask KeyvaultStorageUpdate()
            {
                return new AzureKeyvaultStorageUpdateTask();
            }

            public AzureKeyvaultCertificateContactTask KeyvaultCertificateContact()
            {
                return new AzureKeyvaultCertificateContactTask();
            }

            public AzureKeyvaultCertificateContactAddTask KeyvaultCertificateContactAdd(string email ,  string vaultName)
            {
                return new AzureKeyvaultCertificateContactAddTask(email,  vaultName);
            }

            public AzureKeyvaultCertificateContactDeleteTask KeyvaultCertificateContactDelete(string email ,  string vaultName)
            {
                return new AzureKeyvaultCertificateContactDeleteTask(email,  vaultName);
            }

            public AzureKeyvaultCertificateIssuerTask KeyvaultCertificateIssuer()
            {
                return new AzureKeyvaultCertificateIssuerTask();
            }

            public AzureKeyvaultCertificateIssuerCreateTask KeyvaultCertificateIssuerCreate(string issuerName ,  string providerName ,  string vaultName)
            {
                return new AzureKeyvaultCertificateIssuerCreateTask(issuerName,  providerName,  vaultName);
            }

            public AzureKeyvaultCertificateIssuerDeleteTask KeyvaultCertificateIssuerDelete(string issuerName ,  string vaultName)
            {
                return new AzureKeyvaultCertificateIssuerDeleteTask(issuerName,  vaultName);
            }

            public AzureKeyvaultCertificateIssuerUpdateTask KeyvaultCertificateIssuerUpdate(string issuerName ,  string vaultName)
            {
                return new AzureKeyvaultCertificateIssuerUpdateTask(issuerName,  vaultName);
            }

            public AzureKeyvaultCertificatePendingTask KeyvaultCertificatePending()
            {
                return new AzureKeyvaultCertificatePendingTask();
            }

            public AzureKeyvaultCertificatePendingDeleteTask KeyvaultCertificatePendingDelete(string name ,  string vaultName)
            {
                return new AzureKeyvaultCertificatePendingDeleteTask(name,  vaultName);
            }

            public AzureKeyvaultCertificatePendingMergeTask KeyvaultCertificatePendingMerge(string file ,  string name ,  string vaultName)
            {
                return new AzureKeyvaultCertificatePendingMergeTask(file,  name,  vaultName);
            }

            public AzureKeyvaultCertificateIssuerAdminTask KeyvaultCertificateIssuerAdmin()
            {
                return new AzureKeyvaultCertificateIssuerAdminTask();
            }

            public AzureKeyvaultCertificateIssuerAdminAddTask KeyvaultCertificateIssuerAdminAdd(string email ,  string issuerName ,  string vaultName)
            {
                return new AzureKeyvaultCertificateIssuerAdminAddTask(email,  issuerName,  vaultName);
            }

            public AzureKeyvaultCertificateIssuerAdminDeleteTask KeyvaultCertificateIssuerAdminDelete(string email ,  string issuerName ,  string vaultName)
            {
                return new AzureKeyvaultCertificateIssuerAdminDeleteTask(email,  issuerName,  vaultName);
            }

            public AzureKeyvaultStorageSasDefinitionTask KeyvaultStorageSasDefinition()
            {
                return new AzureKeyvaultStorageSasDefinitionTask();
            }

            public AzureKeyvaultStorageSasDefinitionCreateTask KeyvaultStorageSasDefinitionCreate(string sasType ,  string templateUri ,  string validityPeriod ,  string accountName ,  string name ,  string vaultName)
            {
                return new AzureKeyvaultStorageSasDefinitionCreateTask(sasType,  templateUri,  validityPeriod,  accountName,  name,  vaultName);
            }

            public AzureKeyvaultStorageSasDefinitionDeleteTask KeyvaultStorageSasDefinitionDelete()
            {
                return new AzureKeyvaultStorageSasDefinitionDeleteTask();
            }

            public AzureKeyvaultStorageSasDefinitionRecoverTask KeyvaultStorageSasDefinitionRecover(string accountName ,  string name ,  string vaultName)
            {
                return new AzureKeyvaultStorageSasDefinitionRecoverTask(accountName,  name,  vaultName);
            }

            public AzureKeyvaultStorageSasDefinitionUpdateTask KeyvaultStorageSasDefinitionUpdate()
            {
                return new AzureKeyvaultStorageSasDefinitionUpdateTask();
            }
        
    }
}

