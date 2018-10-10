
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Dla;

namespace FlubuCore.Azure
{
    public class Dla
    {
        
        
            public AzureDlaAccountTask DlaAccount()
            {
                return new AzureDlaAccountTask();
            }

            public AzureDlaAccountCreateTask DlaAccountCreate(string account ,  string defaultDataLakeStore)
            {
                return new AzureDlaAccountCreateTask(account,  defaultDataLakeStore);
            }

            public AzureDlaAccountDeleteTask DlaAccountDelete(string account)
            {
                return new AzureDlaAccountDeleteTask(account);
            }

            public AzureDlaAccountUpdateTask DlaAccountUpdate(string account)
            {
                return new AzureDlaAccountUpdateTask(account);
            }

            public AzureDlaCatalogTask DlaCatalog()
            {
                return new AzureDlaCatalogTask();
            }

            public AzureDlaJobTask DlaJob()
            {
                return new AzureDlaJobTask();
            }

            public AzureDlaJobCancelTask DlaJobCancel(string account ,  string jobIdentity)
            {
                return new AzureDlaJobCancelTask(account,  jobIdentity);
            }

            public AzureDlaJobSubmitTask DlaJobSubmit(string account ,  string jobName ,  string script)
            {
                return new AzureDlaJobSubmitTask(account,  jobName,  script);
            }

            public AzureDlaJobWaitTask DlaJobWait(string account ,  string jobId)
            {
                return new AzureDlaJobWaitTask(account,  jobId);
            }

            public AzureDlaAccountBlobStorageTask DlaAccountBlobStorage()
            {
                return new AzureDlaAccountBlobStorageTask();
            }

            public AzureDlaAccountBlobStorageAddTask DlaAccountBlobStorageAdd(string accessKey ,  string account ,  string storageAccountName)
            {
                return new AzureDlaAccountBlobStorageAddTask(accessKey,  account,  storageAccountName);
            }

            public AzureDlaAccountBlobStorageDeleteTask DlaAccountBlobStorageDelete(string account ,  string storageAccountName)
            {
                return new AzureDlaAccountBlobStorageDeleteTask(account,  storageAccountName);
            }

            public AzureDlaAccountBlobStorageUpdateTask DlaAccountBlobStorageUpdate(string accessKey ,  string account ,  string storageAccountName)
            {
                return new AzureDlaAccountBlobStorageUpdateTask(accessKey,  account,  storageAccountName);
            }

            public AzureDlaAccountComputePolicyTask DlaAccountComputePolicy()
            {
                return new AzureDlaAccountComputePolicyTask();
            }

            public AzureDlaAccountComputePolicyCreateTask DlaAccountComputePolicyCreate(string account ,  string computePolicyName ,  string objectId ,  string objectType)
            {
                return new AzureDlaAccountComputePolicyCreateTask(account,  computePolicyName,  objectId,  objectType);
            }

            public AzureDlaAccountComputePolicyDeleteTask DlaAccountComputePolicyDelete(string account ,  string computePolicyName)
            {
                return new AzureDlaAccountComputePolicyDeleteTask(account,  computePolicyName);
            }

            public AzureDlaAccountComputePolicyUpdateTask DlaAccountComputePolicyUpdate(string account ,  string computePolicyName)
            {
                return new AzureDlaAccountComputePolicyUpdateTask(account,  computePolicyName);
            }

            public AzureDlaAccountDataLakeStoreTask DlaAccountDataLakeStore()
            {
                return new AzureDlaAccountDataLakeStoreTask();
            }

            public AzureDlaAccountDataLakeStoreAddTask DlaAccountDataLakeStoreAdd(string account ,  string dataLakeStoreAccountName)
            {
                return new AzureDlaAccountDataLakeStoreAddTask(account,  dataLakeStoreAccountName);
            }

            public AzureDlaAccountDataLakeStoreDeleteTask DlaAccountDataLakeStoreDelete(string account ,  string dataLakeStoreAccountName)
            {
                return new AzureDlaAccountDataLakeStoreDeleteTask(account,  dataLakeStoreAccountName);
            }

            public AzureDlaAccountFirewallTask DlaAccountFirewall()
            {
                return new AzureDlaAccountFirewallTask();
            }

            public AzureDlaAccountFirewallCreateTask DlaAccountFirewallCreate(string account ,  string endIpAddress ,  string firewallRuleName ,  string startIpAddress)
            {
                return new AzureDlaAccountFirewallCreateTask(account,  endIpAddress,  firewallRuleName,  startIpAddress);
            }

            public AzureDlaAccountFirewallDeleteTask DlaAccountFirewallDelete(string account ,  string firewallRuleName)
            {
                return new AzureDlaAccountFirewallDeleteTask(account,  firewallRuleName);
            }

            public AzureDlaAccountFirewallUpdateTask DlaAccountFirewallUpdate(string account ,  string firewallRuleName)
            {
                return new AzureDlaAccountFirewallUpdateTask(account,  firewallRuleName);
            }

            public AzureDlaCatalogAssemblyTask DlaCatalogAssembly()
            {
                return new AzureDlaCatalogAssemblyTask();
            }

            public AzureDlaCatalogCredentialTask DlaCatalogCredential()
            {
                return new AzureDlaCatalogCredentialTask();
            }

            public AzureDlaCatalogCredentialCreateTask DlaCatalogCredentialCreate(string account ,  string credentialName ,  string databaseName ,  string uri ,  string userName)
            {
                return new AzureDlaCatalogCredentialCreateTask(account,  credentialName,  databaseName,  uri,  userName);
            }

            public AzureDlaCatalogCredentialDeleteTask DlaCatalogCredentialDelete(string account ,  string credentialName ,  string databaseName)
            {
                return new AzureDlaCatalogCredentialDeleteTask(account,  credentialName,  databaseName);
            }

            public AzureDlaCatalogCredentialUpdateTask DlaCatalogCredentialUpdate(string account ,  string credentialName ,  string databaseName ,  string uri ,  string userName)
            {
                return new AzureDlaCatalogCredentialUpdateTask(account,  credentialName,  databaseName,  uri,  userName);
            }

            public AzureDlaCatalogDatabaseTask DlaCatalogDatabase()
            {
                return new AzureDlaCatalogDatabaseTask();
            }

            public AzureDlaCatalogExternalDataSourceTask DlaCatalogExternalDataSource()
            {
                return new AzureDlaCatalogExternalDataSourceTask();
            }

            public AzureDlaCatalogPackageTask DlaCatalogPackage()
            {
                return new AzureDlaCatalogPackageTask();
            }

            public AzureDlaCatalogProcedureTask DlaCatalogProcedure()
            {
                return new AzureDlaCatalogProcedureTask();
            }

            public AzureDlaCatalogSchemaTask DlaCatalogSchema()
            {
                return new AzureDlaCatalogSchemaTask();
            }

            public AzureDlaCatalogTablePartitionTask DlaCatalogTablePartition()
            {
                return new AzureDlaCatalogTablePartitionTask();
            }

            public AzureDlaCatalogTableStatsTask DlaCatalogTableStats()
            {
                return new AzureDlaCatalogTableStatsTask();
            }

            public AzureDlaCatalogTableTypeTask DlaCatalogTableType()
            {
                return new AzureDlaCatalogTableTypeTask();
            }

            public AzureDlaCatalogTableTask DlaCatalogTable()
            {
                return new AzureDlaCatalogTableTask();
            }

            public AzureDlaCatalogTvfTask DlaCatalogTvf()
            {
                return new AzureDlaCatalogTvfTask();
            }

            public AzureDlaCatalogViewTask DlaCatalogView()
            {
                return new AzureDlaCatalogViewTask();
            }

            public AzureDlaJobPipelineTask DlaJobPipeline()
            {
                return new AzureDlaJobPipelineTask();
            }

            public AzureDlaJobRecurrenceTask DlaJobRecurrence()
            {
                return new AzureDlaJobRecurrenceTask();
            }
        
    }
}

