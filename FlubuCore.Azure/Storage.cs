
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Storage;

namespace FlubuCore.Azure
{
    public class Storage
    {
        
        
            public AzureStorageAccountTask StorageAccount()
            {
                return new AzureStorageAccountTask();
            }

            public AzureStorageAccountCreateTask StorageAccountCreate(string name ,  string resourceGroup)
            {
                return new AzureStorageAccountCreateTask(name,  resourceGroup);
            }

            public AzureStorageAccountUpdateTask StorageAccountUpdate(string name)
            {
                return new AzureStorageAccountUpdateTask(name);
            }

            public AzureStorageBlobTask StorageBlob()
            {
                return new AzureStorageBlobTask();
            }

            public AzureStorageAccountManagementPolicyTask StorageAccountManagementPolicy()
            {
                return new AzureStorageAccountManagementPolicyTask();
            }

            public AzureStorageAccountManagementPolicyCreateTask StorageAccountManagementPolicyCreate(string accountName ,  string resourceGroup)
            {
                return new AzureStorageAccountManagementPolicyCreateTask(accountName,  resourceGroup);
            }

            public AzureStorageAccountManagementPolicyDeleteTask StorageAccountManagementPolicyDelete(string accountName ,  string resourceGroup)
            {
                return new AzureStorageAccountManagementPolicyDeleteTask(accountName,  resourceGroup);
            }

            public AzureStorageAccountManagementPolicyUpdateTask StorageAccountManagementPolicyUpdate(string accountName ,  string resourceGroup)
            {
                return new AzureStorageAccountManagementPolicyUpdateTask(accountName,  resourceGroup);
            }

            public AzureStorageBlobServicePropertiesTask StorageBlobServiceProperties()
            {
                return new AzureStorageBlobServicePropertiesTask();
            }

            public AzureStorageBlobServicePropertiesUpdateTask StorageBlobServicePropertiesUpdate()
            {
                return new AzureStorageBlobServicePropertiesUpdateTask();
            }

            public AzureStorageAccountCheckNameTask StorageAccountCheckName(string name)
            {
                return new AzureStorageAccountCheckNameTask(name);
            }

            public AzureStorageAccountDeleteTask StorageAccountDelete(string name)
            {
                return new AzureStorageAccountDeleteTask(name);
            }

            public AzureStorageAccountGenerateSasTask StorageAccountGenerateSas(string expiry ,  string permissions ,  string resourceTypes ,  string services)
            {
                return new AzureStorageAccountGenerateSasTask(expiry,  permissions,  resourceTypes,  services);
            }

            public AzureStorageBlobDeleteTask StorageBlobDelete(string containerName ,  string name)
            {
                return new AzureStorageBlobDeleteTask(containerName,  name);
            }

            public AzureStorageBlobDeleteBatchTask StorageBlobDeleteBatch(string source)
            {
                return new AzureStorageBlobDeleteBatchTask(source);
            }

            public AzureStorageBlobDownloadTask StorageBlobDownload(string containerName ,  string file ,  string name)
            {
                return new AzureStorageBlobDownloadTask(containerName,  file,  name);
            }

            public AzureStorageBlobDownloadBatchTask StorageBlobDownloadBatch(string destination ,  string source)
            {
                return new AzureStorageBlobDownloadBatchTask(destination,  source);
            }

            public AzureStorageBlobExistsTask StorageBlobExists(string containerName ,  string name)
            {
                return new AzureStorageBlobExistsTask(containerName,  name);
            }

            public AzureStorageBlobGenerateSasTask StorageBlobGenerateSas(string containerName ,  string name)
            {
                return new AzureStorageBlobGenerateSasTask(containerName,  name);
            }

            public AzureStorageBlobSetTierTask StorageBlobSetTier(string containerName ,  string name ,  string tier)
            {
                return new AzureStorageBlobSetTierTask(containerName,  name,  tier);
            }

            public AzureStorageBlobSnapshotTask StorageBlobSnapshot(string containerName ,  string name)
            {
                return new AzureStorageBlobSnapshotTask(containerName,  name);
            }

            public AzureStorageBlobUndeleteTask StorageBlobUndelete(string containerName ,  string name)
            {
                return new AzureStorageBlobUndeleteTask(containerName,  name);
            }

            public AzureStorageBlobUpdateTask StorageBlobUpdate(string containerName ,  string name)
            {
                return new AzureStorageBlobUpdateTask(containerName,  name);
            }

            public AzureStorageBlobUploadTask StorageBlobUpload(string containerName ,  string file ,  string name)
            {
                return new AzureStorageBlobUploadTask(containerName,  file,  name);
            }

            public AzureStorageBlobUploadBatchTask StorageBlobUploadBatch(string destination ,  string source)
            {
                return new AzureStorageBlobUploadBatchTask(destination,  source);
            }

            public AzureStorageBlobUrlTask StorageBlobUrl(string containerName ,  string name)
            {
                return new AzureStorageBlobUrlTask(containerName,  name);
            }

            public AzureStorageContainerTask StorageContainer()
            {
                return new AzureStorageContainerTask();
            }

            public AzureStorageContainerCreateTask StorageContainerCreate(string name)
            {
                return new AzureStorageContainerCreateTask(name);
            }

            public AzureStorageContainerDeleteTask StorageContainerDelete(string name)
            {
                return new AzureStorageContainerDeleteTask(name);
            }

            public AzureStorageContainerExistsTask StorageContainerExists(string name)
            {
                return new AzureStorageContainerExistsTask(name);
            }

            public AzureStorageContainerGenerateSasTask StorageContainerGenerateSas(string name)
            {
                return new AzureStorageContainerGenerateSasTask(name);
            }

            public AzureStorageContainerSetPermissionTask StorageContainerSetPermission(string name)
            {
                return new AzureStorageContainerSetPermissionTask(name);
            }

            public AzureStorageCorsTask StorageCors()
            {
                return new AzureStorageCorsTask();
            }

            public AzureStorageCorsAddTask StorageCorsAdd(string methods ,  string origins ,  string services)
            {
                return new AzureStorageCorsAddTask(methods,  origins,  services);
            }

            public AzureStorageCorsClearTask StorageCorsClear(string services)
            {
                return new AzureStorageCorsClearTask(services);
            }

            public AzureStorageDirectoryTask StorageDirectory()
            {
                return new AzureStorageDirectoryTask();
            }

            public AzureStorageDirectoryCreateTask StorageDirectoryCreate(string name ,  string shareName)
            {
                return new AzureStorageDirectoryCreateTask(name,  shareName);
            }

            public AzureStorageDirectoryDeleteTask StorageDirectoryDelete(string name ,  string shareName)
            {
                return new AzureStorageDirectoryDeleteTask(name,  shareName);
            }

            public AzureStorageDirectoryExistsTask StorageDirectoryExists(string name ,  string shareName)
            {
                return new AzureStorageDirectoryExistsTask(name,  shareName);
            }

            public AzureStorageEntityTask StorageEntity()
            {
                return new AzureStorageEntityTask();
            }

            public AzureStorageEntityDeleteTask StorageEntityDelete(string partitionKey ,  string rowKey ,  string tableName)
            {
                return new AzureStorageEntityDeleteTask(partitionKey,  rowKey,  tableName);
            }

            public AzureStorageEntityInsertTask StorageEntityInsert(string entity ,  string tableName)
            {
                return new AzureStorageEntityInsertTask(entity,  tableName);
            }

            public AzureStorageEntityMergeTask StorageEntityMerge(string entity ,  string tableName)
            {
                return new AzureStorageEntityMergeTask(entity,  tableName);
            }

            public AzureStorageEntityQueryTask StorageEntityQuery(string tableName)
            {
                return new AzureStorageEntityQueryTask(tableName);
            }

            public AzureStorageEntityReplaceTask StorageEntityReplace(string entity ,  string tableName)
            {
                return new AzureStorageEntityReplaceTask(entity,  tableName);
            }

            public AzureStorageFileTask StorageFile()
            {
                return new AzureStorageFileTask();
            }

            public AzureStorageFileDeleteTask StorageFileDelete(string path ,  string shareName)
            {
                return new AzureStorageFileDeleteTask(path,  shareName);
            }

            public AzureStorageFileDeleteBatchTask StorageFileDeleteBatch(string source)
            {
                return new AzureStorageFileDeleteBatchTask(source);
            }

            public AzureStorageFileDownloadTask StorageFileDownload(string path ,  string shareName)
            {
                return new AzureStorageFileDownloadTask(path,  shareName);
            }

            public AzureStorageFileDownloadBatchTask StorageFileDownloadBatch(string destination ,  string source)
            {
                return new AzureStorageFileDownloadBatchTask(destination,  source);
            }

            public AzureStorageFileExistsTask StorageFileExists(string path ,  string shareName)
            {
                return new AzureStorageFileExistsTask(path,  shareName);
            }

            public AzureStorageFileGenerateSasTask StorageFileGenerateSas(string path ,  string shareName)
            {
                return new AzureStorageFileGenerateSasTask(path,  shareName);
            }

            public AzureStorageFileResizeTask StorageFileResize(string path ,  string shareName ,  string size)
            {
                return new AzureStorageFileResizeTask(path,  shareName,  size);
            }

            public AzureStorageFileUpdateTask StorageFileUpdate(string path ,  string shareName)
            {
                return new AzureStorageFileUpdateTask(path,  shareName);
            }

            public AzureStorageFileUploadTask StorageFileUpload(string shareName ,  string source)
            {
                return new AzureStorageFileUploadTask(shareName,  source);
            }

            public AzureStorageFileUploadBatchTask StorageFileUploadBatch(string destination ,  string source)
            {
                return new AzureStorageFileUploadBatchTask(destination,  source);
            }

            public AzureStorageFileUrlTask StorageFileUrl(string path ,  string shareName)
            {
                return new AzureStorageFileUrlTask(path,  shareName);
            }

            public AzureStorageLoggingTask StorageLogging()
            {
                return new AzureStorageLoggingTask();
            }

            public AzureStorageLoggingUpdateTask StorageLoggingUpdate(string log ,  string retention ,  string services)
            {
                return new AzureStorageLoggingUpdateTask(log,  retention,  services);
            }

            public AzureStorageMessageTask StorageMessage()
            {
                return new AzureStorageMessageTask();
            }

            public AzureStorageMessageClearTask StorageMessageClear(string queueName)
            {
                return new AzureStorageMessageClearTask(queueName);
            }

            public AzureStorageMessageDeleteTask StorageMessageDelete(string id ,  string popReceipt ,  string queueName)
            {
                return new AzureStorageMessageDeleteTask(id,  popReceipt,  queueName);
            }

            public AzureStorageMessageGetTask StorageMessageGet(string queueName)
            {
                return new AzureStorageMessageGetTask(queueName);
            }

            public AzureStorageMessagePeekTask StorageMessagePeek(string queueName)
            {
                return new AzureStorageMessagePeekTask(queueName);
            }

            public AzureStorageMessagePutTask StorageMessagePut(string content ,  string queueName)
            {
                return new AzureStorageMessagePutTask(content,  queueName);
            }

            public AzureStorageMessageUpdateTask StorageMessageUpdate(string id ,  string popReceipt ,  string queueName ,  string visibilityTimeout)
            {
                return new AzureStorageMessageUpdateTask(id,  popReceipt,  queueName,  visibilityTimeout);
            }

            public AzureStorageMetricsTask StorageMetrics()
            {
                return new AzureStorageMetricsTask();
            }

            public AzureStorageMetricsUpdateTask StorageMetricsUpdate(string retention ,  string services)
            {
                return new AzureStorageMetricsUpdateTask(retention,  services);
            }

            public AzureStorageQueueTask StorageQueue()
            {
                return new AzureStorageQueueTask();
            }

            public AzureStorageQueueCreateTask StorageQueueCreate(string name)
            {
                return new AzureStorageQueueCreateTask(name);
            }

            public AzureStorageQueueDeleteTask StorageQueueDelete(string name)
            {
                return new AzureStorageQueueDeleteTask(name);
            }

            public AzureStorageQueueExistsTask StorageQueueExists(string name)
            {
                return new AzureStorageQueueExistsTask(name);
            }

            public AzureStorageQueueGenerateSasTask StorageQueueGenerateSas(string name)
            {
                return new AzureStorageQueueGenerateSasTask(name);
            }

            public AzureStorageQueueStatsTask StorageQueueStats()
            {
                return new AzureStorageQueueStatsTask();
            }

            public AzureStorageShareTask StorageShare()
            {
                return new AzureStorageShareTask();
            }

            public AzureStorageShareCreateTask StorageShareCreate(string name)
            {
                return new AzureStorageShareCreateTask(name);
            }

            public AzureStorageShareDeleteTask StorageShareDelete(string name)
            {
                return new AzureStorageShareDeleteTask(name);
            }

            public AzureStorageShareExistsTask StorageShareExists(string name)
            {
                return new AzureStorageShareExistsTask(name);
            }

            public AzureStorageShareGenerateSasTask StorageShareGenerateSas(string name)
            {
                return new AzureStorageShareGenerateSasTask(name);
            }

            public AzureStorageShareSnapshotTask StorageShareSnapshot(string name)
            {
                return new AzureStorageShareSnapshotTask(name);
            }

            public AzureStorageShareStatsTask StorageShareStats(string name)
            {
                return new AzureStorageShareStatsTask(name);
            }

            public AzureStorageShareUpdateTask StorageShareUpdate(string name ,  string quota)
            {
                return new AzureStorageShareUpdateTask(name,  quota);
            }

            public AzureStorageTableTask StorageTable()
            {
                return new AzureStorageTableTask();
            }

            public AzureStorageTableCreateTask StorageTableCreate(string name)
            {
                return new AzureStorageTableCreateTask(name);
            }

            public AzureStorageTableDeleteTask StorageTableDelete(string name)
            {
                return new AzureStorageTableDeleteTask(name);
            }

            public AzureStorageTableExistsTask StorageTableExists(string name)
            {
                return new AzureStorageTableExistsTask(name);
            }

            public AzureStorageTableGenerateSasTask StorageTableGenerateSas(string name)
            {
                return new AzureStorageTableGenerateSasTask(name);
            }

            public AzureStorageTableStatsTask StorageTableStats()
            {
                return new AzureStorageTableStatsTask();
            }

            public AzureStorageAccountKeysTask StorageAccountKeys()
            {
                return new AzureStorageAccountKeysTask();
            }

            public AzureStorageAccountKeysRenewTask StorageAccountKeysRenew(string accountName ,  string key)
            {
                return new AzureStorageAccountKeysRenewTask(accountName,  key);
            }

            public AzureStorageAccountNetworkRuleTask StorageAccountNetworkRule()
            {
                return new AzureStorageAccountNetworkRuleTask();
            }

            public AzureStorageAccountNetworkRuleAddTask StorageAccountNetworkRuleAdd(string accountName)
            {
                return new AzureStorageAccountNetworkRuleAddTask(accountName);
            }

            public AzureStorageAccountNetworkRuleRemoveTask StorageAccountNetworkRuleRemove(string accountName)
            {
                return new AzureStorageAccountNetworkRuleRemoveTask(accountName);
            }

            public AzureStorageBlobCopyTask StorageBlobCopy()
            {
                return new AzureStorageBlobCopyTask();
            }

            public AzureStorageBlobCopyCancelTask StorageBlobCopyCancel(string copyId ,  string destinationBlob ,  string destinationContainer)
            {
                return new AzureStorageBlobCopyCancelTask(copyId,  destinationBlob,  destinationContainer);
            }

            public AzureStorageBlobCopyStartTask StorageBlobCopyStart(string destinationBlob ,  string destinationContainer)
            {
                return new AzureStorageBlobCopyStartTask(destinationBlob,  destinationContainer);
            }

            public AzureStorageBlobCopyStartBatchTask StorageBlobCopyStartBatch()
            {
                return new AzureStorageBlobCopyStartBatchTask();
            }

            public AzureStorageBlobIncrementalCopyTask StorageBlobIncrementalCopy()
            {
                return new AzureStorageBlobIncrementalCopyTask();
            }

            public AzureStorageBlobIncrementalCopyCancelTask StorageBlobIncrementalCopyCancel(string containerName ,  string copyId ,  string name)
            {
                return new AzureStorageBlobIncrementalCopyCancelTask(containerName,  copyId,  name);
            }

            public AzureStorageBlobIncrementalCopyStartTask StorageBlobIncrementalCopyStart(string destinationBlob ,  string destinationContainer)
            {
                return new AzureStorageBlobIncrementalCopyStartTask(destinationBlob,  destinationContainer);
            }

            public AzureStorageBlobLeaseTask StorageBlobLease()
            {
                return new AzureStorageBlobLeaseTask();
            }

            public AzureStorageBlobLeaseAcquireTask StorageBlobLeaseAcquire(string blobName ,  string containerName)
            {
                return new AzureStorageBlobLeaseAcquireTask(blobName,  containerName);
            }

            public AzureStorageBlobLeaseBreakTask StorageBlobLeaseBreak(string blobName ,  string containerName)
            {
                return new AzureStorageBlobLeaseBreakTask(blobName,  containerName);
            }

            public AzureStorageBlobLeaseChangeTask StorageBlobLeaseChange(string blobName ,  string containerName ,  string leaseId ,  string proposedLeaseId)
            {
                return new AzureStorageBlobLeaseChangeTask(blobName,  containerName,  leaseId,  proposedLeaseId);
            }

            public AzureStorageBlobLeaseReleaseTask StorageBlobLeaseRelease(string blobName ,  string containerName ,  string leaseId)
            {
                return new AzureStorageBlobLeaseReleaseTask(blobName,  containerName,  leaseId);
            }

            public AzureStorageBlobLeaseRenewTask StorageBlobLeaseRenew(string blobName ,  string containerName ,  string leaseId)
            {
                return new AzureStorageBlobLeaseRenewTask(blobName,  containerName,  leaseId);
            }

            public AzureStorageBlobMetadataTask StorageBlobMetadata()
            {
                return new AzureStorageBlobMetadataTask();
            }

            public AzureStorageBlobMetadataUpdateTask StorageBlobMetadataUpdate(string containerName ,  string name)
            {
                return new AzureStorageBlobMetadataUpdateTask(containerName,  name);
            }

            public AzureStorageBlobServicePropertiesDeletePolicyTask StorageBlobServicePropertiesDeletePolicy()
            {
                return new AzureStorageBlobServicePropertiesDeletePolicyTask();
            }

            public AzureStorageBlobServicePropertiesDeletePolicyUpdateTask StorageBlobServicePropertiesDeletePolicyUpdate()
            {
                return new AzureStorageBlobServicePropertiesDeletePolicyUpdateTask();
            }

            public AzureStorageContainerImmutabilityPolicyTask StorageContainerImmutabilityPolicy()
            {
                return new AzureStorageContainerImmutabilityPolicyTask();
            }

            public AzureStorageContainerImmutabilityPolicyCreateTask StorageContainerImmutabilityPolicyCreate(string accountName ,  string containerName ,  string period)
            {
                return new AzureStorageContainerImmutabilityPolicyCreateTask(accountName,  containerName,  period);
            }

            public AzureStorageContainerImmutabilityPolicyDeleteTask StorageContainerImmutabilityPolicyDelete(string accountName ,  string containerName ,  string ifMatch)
            {
                return new AzureStorageContainerImmutabilityPolicyDeleteTask(accountName,  containerName,  ifMatch);
            }

            public AzureStorageContainerImmutabilityPolicyExtendTask StorageContainerImmutabilityPolicyExtend(string accountName ,  string containerName ,  string period ,  string ifMatch)
            {
                return new AzureStorageContainerImmutabilityPolicyExtendTask(accountName,  containerName,  period,  ifMatch);
            }

            public AzureStorageContainerImmutabilityPolicyLockTask StorageContainerImmutabilityPolicyLock(string accountName ,  string containerName ,  string ifMatch)
            {
                return new AzureStorageContainerImmutabilityPolicyLockTask(accountName,  containerName,  ifMatch);
            }

            public AzureStorageContainerLeaseTask StorageContainerLease()
            {
                return new AzureStorageContainerLeaseTask();
            }

            public AzureStorageContainerLeaseAcquireTask StorageContainerLeaseAcquire(string containerName)
            {
                return new AzureStorageContainerLeaseAcquireTask(containerName);
            }

            public AzureStorageContainerLeaseBreakTask StorageContainerLeaseBreak(string containerName)
            {
                return new AzureStorageContainerLeaseBreakTask(containerName);
            }

            public AzureStorageContainerLeaseChangeTask StorageContainerLeaseChange(string containerName ,  string leaseId ,  string proposedLeaseId)
            {
                return new AzureStorageContainerLeaseChangeTask(containerName,  leaseId,  proposedLeaseId);
            }

            public AzureStorageContainerLeaseReleaseTask StorageContainerLeaseRelease(string containerName ,  string leaseId)
            {
                return new AzureStorageContainerLeaseReleaseTask(containerName,  leaseId);
            }

            public AzureStorageContainerLeaseRenewTask StorageContainerLeaseRenew(string containerName ,  string leaseId)
            {
                return new AzureStorageContainerLeaseRenewTask(containerName,  leaseId);
            }

            public AzureStorageContainerLegalHoldTask StorageContainerLegalHold()
            {
                return new AzureStorageContainerLegalHoldTask();
            }

            public AzureStorageContainerLegalHoldClearTask StorageContainerLegalHoldClear(string accountName ,  string containerName ,  string tags)
            {
                return new AzureStorageContainerLegalHoldClearTask(accountName,  containerName,  tags);
            }

            public AzureStorageContainerLegalHoldSetTask StorageContainerLegalHoldSet(string accountName ,  string containerName ,  string tags)
            {
                return new AzureStorageContainerLegalHoldSetTask(accountName,  containerName,  tags);
            }

            public AzureStorageContainerMetadataTask StorageContainerMetadata()
            {
                return new AzureStorageContainerMetadataTask();
            }

            public AzureStorageContainerMetadataUpdateTask StorageContainerMetadataUpdate(string name)
            {
                return new AzureStorageContainerMetadataUpdateTask(name);
            }

            public AzureStorageContainerPolicyTask StorageContainerPolicy()
            {
                return new AzureStorageContainerPolicyTask();
            }

            public AzureStorageContainerPolicyCreateTask StorageContainerPolicyCreate(string containerName ,  string name)
            {
                return new AzureStorageContainerPolicyCreateTask(containerName,  name);
            }

            public AzureStorageContainerPolicyDeleteTask StorageContainerPolicyDelete(string containerName ,  string name)
            {
                return new AzureStorageContainerPolicyDeleteTask(containerName,  name);
            }

            public AzureStorageContainerPolicyUpdateTask StorageContainerPolicyUpdate(string containerName ,  string name)
            {
                return new AzureStorageContainerPolicyUpdateTask(containerName,  name);
            }

            public AzureStorageDirectoryMetadataTask StorageDirectoryMetadata()
            {
                return new AzureStorageDirectoryMetadataTask();
            }

            public AzureStorageDirectoryMetadataUpdateTask StorageDirectoryMetadataUpdate(string name ,  string shareName)
            {
                return new AzureStorageDirectoryMetadataUpdateTask(name,  shareName);
            }

            public AzureStorageFileCopyTask StorageFileCopy()
            {
                return new AzureStorageFileCopyTask();
            }

            public AzureStorageFileCopyCancelTask StorageFileCopyCancel(string copyId ,  string destinationPath ,  string destinationShare)
            {
                return new AzureStorageFileCopyCancelTask(copyId,  destinationPath,  destinationShare);
            }

            public AzureStorageFileCopyStartTask StorageFileCopyStart(string destinationPath ,  string destinationShare)
            {
                return new AzureStorageFileCopyStartTask(destinationPath,  destinationShare);
            }

            public AzureStorageFileCopyStartBatchTask StorageFileCopyStartBatch()
            {
                return new AzureStorageFileCopyStartBatchTask();
            }

            public AzureStorageFileMetadataTask StorageFileMetadata()
            {
                return new AzureStorageFileMetadataTask();
            }

            public AzureStorageFileMetadataUpdateTask StorageFileMetadataUpdate(string path ,  string shareName)
            {
                return new AzureStorageFileMetadataUpdateTask(path,  shareName);
            }

            public AzureStorageQueueMetadataTask StorageQueueMetadata()
            {
                return new AzureStorageQueueMetadataTask();
            }

            public AzureStorageQueueMetadataUpdateTask StorageQueueMetadataUpdate(string name)
            {
                return new AzureStorageQueueMetadataUpdateTask(name);
            }

            public AzureStorageQueuePolicyTask StorageQueuePolicy()
            {
                return new AzureStorageQueuePolicyTask();
            }

            public AzureStorageQueuePolicyCreateTask StorageQueuePolicyCreate(string name ,  string queueName)
            {
                return new AzureStorageQueuePolicyCreateTask(name,  queueName);
            }

            public AzureStorageQueuePolicyDeleteTask StorageQueuePolicyDelete(string name ,  string queueName)
            {
                return new AzureStorageQueuePolicyDeleteTask(name,  queueName);
            }

            public AzureStorageQueuePolicyUpdateTask StorageQueuePolicyUpdate(string name ,  string queueName)
            {
                return new AzureStorageQueuePolicyUpdateTask(name,  queueName);
            }

            public AzureStorageShareMetadataTask StorageShareMetadata()
            {
                return new AzureStorageShareMetadataTask();
            }

            public AzureStorageShareMetadataUpdateTask StorageShareMetadataUpdate(string name)
            {
                return new AzureStorageShareMetadataUpdateTask(name);
            }

            public AzureStorageSharePolicyTask StorageSharePolicy()
            {
                return new AzureStorageSharePolicyTask();
            }

            public AzureStorageSharePolicyCreateTask StorageSharePolicyCreate(string name ,  string shareName)
            {
                return new AzureStorageSharePolicyCreateTask(name,  shareName);
            }

            public AzureStorageSharePolicyDeleteTask StorageSharePolicyDelete(string name ,  string shareName)
            {
                return new AzureStorageSharePolicyDeleteTask(name,  shareName);
            }

            public AzureStorageSharePolicyUpdateTask StorageSharePolicyUpdate(string name ,  string shareName)
            {
                return new AzureStorageSharePolicyUpdateTask(name,  shareName);
            }

            public AzureStorageTablePolicyTask StorageTablePolicy()
            {
                return new AzureStorageTablePolicyTask();
            }

            public AzureStorageTablePolicyCreateTask StorageTablePolicyCreate(string name ,  string tableName)
            {
                return new AzureStorageTablePolicyCreateTask(name,  tableName);
            }

            public AzureStorageTablePolicyDeleteTask StorageTablePolicyDelete(string name ,  string tableName)
            {
                return new AzureStorageTablePolicyDeleteTask(name,  tableName);
            }

            public AzureStorageTablePolicyUpdateTask StorageTablePolicyUpdate(string name ,  string tableName)
            {
                return new AzureStorageTablePolicyUpdateTask(name,  tableName);
            }
        
    }
}

