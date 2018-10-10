
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Batch;

namespace FlubuCore.Azure
{
    public class Batch
    {
        
        
            public AzureBatchAccountTask BatchAccount()
            {
                return new AzureBatchAccountTask();
            }

            public AzureBatchAccountCreateTask BatchAccountCreate(string location ,  string name ,  string resourceGroup)
            {
                return new AzureBatchAccountCreateTask(location,  name,  resourceGroup);
            }

            public AzureBatchAccountDeleteTask BatchAccountDelete(string name ,  string resourceGroup)
            {
                return new AzureBatchAccountDeleteTask(name,  resourceGroup);
            }

            public AzureBatchAccountLoginTask BatchAccountLogin(string name ,  string resourceGroup)
            {
                return new AzureBatchAccountLoginTask(name,  resourceGroup);
            }

            public AzureBatchAccountSetTask BatchAccountSet(string name ,  string resourceGroup)
            {
                return new AzureBatchAccountSetTask(name,  resourceGroup);
            }

            public AzureBatchApplicationTask BatchApplication()
            {
                return new AzureBatchApplicationTask();
            }

            public AzureBatchApplicationCreateTask BatchApplicationCreate(string applicationId ,  string name ,  string resourceGroup)
            {
                return new AzureBatchApplicationCreateTask(applicationId,  name,  resourceGroup);
            }

            public AzureBatchApplicationDeleteTask BatchApplicationDelete(string applicationId ,  string name ,  string resourceGroup)
            {
                return new AzureBatchApplicationDeleteTask(applicationId,  name,  resourceGroup);
            }

            public AzureBatchApplicationSetTask BatchApplicationSet(string applicationId ,  string name ,  string resourceGroup)
            {
                return new AzureBatchApplicationSetTask(applicationId,  name,  resourceGroup);
            }

            public AzureBatchCertificateTask BatchCertificate()
            {
                return new AzureBatchCertificateTask();
            }

            public AzureBatchCertificateCreateTask BatchCertificateCreate(string certificateFile ,  string thumbprint)
            {
                return new AzureBatchCertificateCreateTask(certificateFile,  thumbprint);
            }

            public AzureBatchCertificateDeleteTask BatchCertificateDelete(string thumbprint)
            {
                return new AzureBatchCertificateDeleteTask(thumbprint);
            }

            public AzureBatchJobScheduleTask BatchJobSchedule()
            {
                return new AzureBatchJobScheduleTask();
            }

            public AzureBatchJobScheduleCreateTask BatchJobScheduleCreate()
            {
                return new AzureBatchJobScheduleCreateTask();
            }

            public AzureBatchJobScheduleDeleteTask BatchJobScheduleDelete(string jobScheduleId)
            {
                return new AzureBatchJobScheduleDeleteTask(jobScheduleId);
            }

            public AzureBatchJobScheduleDisableTask BatchJobScheduleDisable(string jobScheduleId)
            {
                return new AzureBatchJobScheduleDisableTask(jobScheduleId);
            }

            public AzureBatchJobScheduleEnableTask BatchJobScheduleEnable(string jobScheduleId)
            {
                return new AzureBatchJobScheduleEnableTask(jobScheduleId);
            }

            public AzureBatchJobScheduleResetTask BatchJobScheduleReset(string jobScheduleId)
            {
                return new AzureBatchJobScheduleResetTask(jobScheduleId);
            }

            public AzureBatchJobScheduleSetTask BatchJobScheduleSet(string jobScheduleId)
            {
                return new AzureBatchJobScheduleSetTask(jobScheduleId);
            }

            public AzureBatchJobScheduleStopTask BatchJobScheduleStop(string jobScheduleId)
            {
                return new AzureBatchJobScheduleStopTask(jobScheduleId);
            }

            public AzureBatchJobTask BatchJob()
            {
                return new AzureBatchJobTask();
            }

            public AzureBatchJobCreateTask BatchJobCreate()
            {
                return new AzureBatchJobCreateTask();
            }

            public AzureBatchJobDeleteTask BatchJobDelete(string jobId)
            {
                return new AzureBatchJobDeleteTask(jobId);
            }

            public AzureBatchJobDisableTask BatchJobDisable(string jobId)
            {
                return new AzureBatchJobDisableTask(jobId);
            }

            public AzureBatchJobEnableTask BatchJobEnable(string jobId)
            {
                return new AzureBatchJobEnableTask(jobId);
            }

            public AzureBatchJobResetTask BatchJobReset(string jobId)
            {
                return new AzureBatchJobResetTask(jobId);
            }

            public AzureBatchJobSetTask BatchJobSet(string jobId)
            {
                return new AzureBatchJobSetTask(jobId);
            }

            public AzureBatchJobStopTask BatchJobStop(string jobId)
            {
                return new AzureBatchJobStopTask(jobId);
            }

            public AzureBatchLocationTask BatchLocation()
            {
                return new AzureBatchLocationTask();
            }

            public AzureBatchNodeTask BatchNode()
            {
                return new AzureBatchNodeTask();
            }

            public AzureBatchNodeDeleteTask BatchNodeDelete(string poolId)
            {
                return new AzureBatchNodeDeleteTask(poolId);
            }

            public AzureBatchNodeRebootTask BatchNodeReboot(string nodeId ,  string poolId)
            {
                return new AzureBatchNodeRebootTask(nodeId,  poolId);
            }

            public AzureBatchNodeReimageTask BatchNodeReimage(string nodeId ,  string poolId)
            {
                return new AzureBatchNodeReimageTask(nodeId,  poolId);
            }

            public AzureBatchPoolTask BatchPool()
            {
                return new AzureBatchPoolTask();
            }

            public AzureBatchPoolCreateTask BatchPoolCreate()
            {
                return new AzureBatchPoolCreateTask();
            }

            public AzureBatchPoolDeleteTask BatchPoolDelete(string poolId)
            {
                return new AzureBatchPoolDeleteTask(poolId);
            }

            public AzureBatchPoolResetTask BatchPoolReset(string poolId)
            {
                return new AzureBatchPoolResetTask(poolId);
            }

            public AzureBatchPoolResizeTask BatchPoolResize(string poolId)
            {
                return new AzureBatchPoolResizeTask(poolId);
            }

            public AzureBatchPoolSetTask BatchPoolSet(string poolId)
            {
                return new AzureBatchPoolSetTask(poolId);
            }

            public AzureBatchTaskTask BatchTask()
            {
                return new AzureBatchTaskTask();
            }

            public AzureBatchTaskCreateTask BatchTaskCreate(string jobId)
            {
                return new AzureBatchTaskCreateTask(jobId);
            }

            public AzureBatchTaskDeleteTask BatchTaskDelete(string jobId ,  string taskId)
            {
                return new AzureBatchTaskDeleteTask(jobId,  taskId);
            }

            public AzureBatchTaskReactivateTask BatchTaskReactivate(string jobId ,  string taskId)
            {
                return new AzureBatchTaskReactivateTask(jobId,  taskId);
            }

            public AzureBatchTaskResetTask BatchTaskReset(string jobId ,  string taskId)
            {
                return new AzureBatchTaskResetTask(jobId,  taskId);
            }

            public AzureBatchTaskStopTask BatchTaskStop(string jobId ,  string taskId)
            {
                return new AzureBatchTaskStopTask(jobId,  taskId);
            }

            public AzureBatchAccountAutostorageKeysTask BatchAccountAutostorageKeys()
            {
                return new AzureBatchAccountAutostorageKeysTask();
            }

            public AzureBatchAccountAutostorageKeysSyncTask BatchAccountAutostorageKeysSync(string name ,  string resourceGroup)
            {
                return new AzureBatchAccountAutostorageKeysSyncTask(name,  resourceGroup);
            }

            public AzureBatchAccountKeysTask BatchAccountKeys()
            {
                return new AzureBatchAccountKeysTask();
            }

            public AzureBatchAccountKeysRenewTask BatchAccountKeysRenew(string keyName ,  string name ,  string resourceGroup)
            {
                return new AzureBatchAccountKeysRenewTask(keyName,  name,  resourceGroup);
            }

            public AzureBatchApplicationPackageTask BatchApplicationPackage()
            {
                return new AzureBatchApplicationPackageTask();
            }

            public AzureBatchApplicationPackageActivateTask BatchApplicationPackageActivate(string applicationId ,  string format ,  string name ,  string resourceGroup ,  string version)
            {
                return new AzureBatchApplicationPackageActivateTask(applicationId,  format,  name,  resourceGroup,  version);
            }

            public AzureBatchApplicationPackageCreateTask BatchApplicationPackageCreate(string applicationId ,  string name ,  string packageFile ,  string resourceGroup ,  string version)
            {
                return new AzureBatchApplicationPackageCreateTask(applicationId,  name,  packageFile,  resourceGroup,  version);
            }

            public AzureBatchApplicationPackageDeleteTask BatchApplicationPackageDelete(string applicationId ,  string name ,  string resourceGroup ,  string version)
            {
                return new AzureBatchApplicationPackageDeleteTask(applicationId,  name,  resourceGroup,  version);
            }

            public AzureBatchApplicationSummaryTask BatchApplicationSummary()
            {
                return new AzureBatchApplicationSummaryTask();
            }

            public AzureBatchJobAllStatisticsTask BatchJobAllStatistics()
            {
                return new AzureBatchJobAllStatisticsTask();
            }

            public AzureBatchJobPrepReleaseStatusTask BatchJobPrepReleaseStatus()
            {
                return new AzureBatchJobPrepReleaseStatusTask();
            }

            public AzureBatchJobTaskCountsTask BatchJobTaskCounts()
            {
                return new AzureBatchJobTaskCountsTask();
            }

            public AzureBatchLocationQuotasTask BatchLocationQuotas()
            {
                return new AzureBatchLocationQuotasTask();
            }

            public AzureBatchNodeFileTask BatchNodeFile()
            {
                return new AzureBatchNodeFileTask();
            }

            public AzureBatchNodeFileDeleteTask BatchNodeFileDelete(string filePath ,  string nodeId ,  string poolId)
            {
                return new AzureBatchNodeFileDeleteTask(filePath,  nodeId,  poolId);
            }

            public AzureBatchNodeFileDownloadTask BatchNodeFileDownload(string destination ,  string filePath ,  string nodeId ,  string poolId)
            {
                return new AzureBatchNodeFileDownloadTask(destination,  filePath,  nodeId,  poolId);
            }

            public AzureBatchNodeRemoteDesktopTask BatchNodeRemoteDesktop()
            {
                return new AzureBatchNodeRemoteDesktopTask();
            }

            public AzureBatchNodeRemoteDesktopDownloadTask BatchNodeRemoteDesktopDownload(string destination ,  string nodeId ,  string poolId)
            {
                return new AzureBatchNodeRemoteDesktopDownloadTask(destination,  nodeId,  poolId);
            }

            public AzureBatchNodeRemoteLoginSettingsTask BatchNodeRemoteLoginSettings()
            {
                return new AzureBatchNodeRemoteLoginSettingsTask();
            }

            public AzureBatchNodeSchedulingTask BatchNodeScheduling()
            {
                return new AzureBatchNodeSchedulingTask();
            }

            public AzureBatchNodeSchedulingDisableTask BatchNodeSchedulingDisable(string nodeId ,  string poolId)
            {
                return new AzureBatchNodeSchedulingDisableTask(nodeId,  poolId);
            }

            public AzureBatchNodeSchedulingEnableTask BatchNodeSchedulingEnable(string nodeId ,  string poolId)
            {
                return new AzureBatchNodeSchedulingEnableTask(nodeId,  poolId);
            }

            public AzureBatchNodeServiceLogsTask BatchNodeServiceLogs()
            {
                return new AzureBatchNodeServiceLogsTask();
            }

            public AzureBatchNodeServiceLogsUploadTask BatchNodeServiceLogsUpload(string nodeId ,  string poolId)
            {
                return new AzureBatchNodeServiceLogsUploadTask(nodeId,  poolId);
            }

            public AzureBatchNodeUserTask BatchNodeUser()
            {
                return new AzureBatchNodeUserTask();
            }

            public AzureBatchNodeUserCreateTask BatchNodeUserCreate(string nodeId ,  string poolId)
            {
                return new AzureBatchNodeUserCreateTask(nodeId,  poolId);
            }

            public AzureBatchNodeUserDeleteTask BatchNodeUserDelete(string nodeId ,  string poolId ,  string userName)
            {
                return new AzureBatchNodeUserDeleteTask(nodeId,  poolId,  userName);
            }

            public AzureBatchNodeUserResetTask BatchNodeUserReset(string nodeId ,  string poolId ,  string userName)
            {
                return new AzureBatchNodeUserResetTask(nodeId,  poolId,  userName);
            }

            public AzureBatchPoolAllStatisticsTask BatchPoolAllStatistics()
            {
                return new AzureBatchPoolAllStatisticsTask();
            }

            public AzureBatchPoolAutoscaleTask BatchPoolAutoscale()
            {
                return new AzureBatchPoolAutoscaleTask();
            }

            public AzureBatchPoolAutoscaleDisableTask BatchPoolAutoscaleDisable(string poolId)
            {
                return new AzureBatchPoolAutoscaleDisableTask(poolId);
            }

            public AzureBatchPoolAutoscaleEnableTask BatchPoolAutoscaleEnable(string poolId)
            {
                return new AzureBatchPoolAutoscaleEnableTask(poolId);
            }

            public AzureBatchPoolAutoscaleEvaluateTask BatchPoolAutoscaleEvaluate(string autoScaleFormula ,  string poolId)
            {
                return new AzureBatchPoolAutoscaleEvaluateTask(autoScaleFormula,  poolId);
            }

            public AzureBatchPoolNodeAgentSkusTask BatchPoolNodeAgentSkus()
            {
                return new AzureBatchPoolNodeAgentSkusTask();
            }

            public AzureBatchPoolNodeCountsTask BatchPoolNodeCounts()
            {
                return new AzureBatchPoolNodeCountsTask();
            }

            public AzureBatchPoolOsTask BatchPoolOs()
            {
                return new AzureBatchPoolOsTask();
            }

            public AzureBatchPoolOsUpgradeTask BatchPoolOsUpgrade(string poolId ,  string targetOsVersion)
            {
                return new AzureBatchPoolOsUpgradeTask(poolId,  targetOsVersion);
            }

            public AzureBatchPoolUsageMetricsTask BatchPoolUsageMetrics()
            {
                return new AzureBatchPoolUsageMetricsTask();
            }

            public AzureBatchTaskFileTask BatchTaskFile()
            {
                return new AzureBatchTaskFileTask();
            }

            public AzureBatchTaskFileDeleteTask BatchTaskFileDelete(string filePath ,  string jobId ,  string taskId)
            {
                return new AzureBatchTaskFileDeleteTask(filePath,  jobId,  taskId);
            }

            public AzureBatchTaskFileDownloadTask BatchTaskFileDownload(string destination ,  string filePath ,  string jobId ,  string taskId)
            {
                return new AzureBatchTaskFileDownloadTask(destination,  filePath,  jobId,  taskId);
            }

            public AzureBatchTaskSubtaskTask BatchTaskSubtask()
            {
                return new AzureBatchTaskSubtaskTask();
            }

            public AzureBatchFileTask BatchFile()
            {
                return new AzureBatchFileTask();
            }

            public AzureBatchFileDownloadTask BatchFileDownload(string fileGroup ,  string localPath)
            {
                return new AzureBatchFileDownloadTask(fileGroup,  localPath);
            }

            public AzureBatchFileUploadTask BatchFileUpload(string fileGroup ,  string localPath)
            {
                return new AzureBatchFileUploadTask(fileGroup,  localPath);
            }
        
    }
}

