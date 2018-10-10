
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Acr;

namespace FlubuCore.Azure
{
    public class Acr
    {
        
        
            public AzureAcrBuildTask AcrBuild(string registry)
            {
                return new AzureAcrBuildTask(registry);
            }

            public AzureAcrCheckNameTask AcrCheckName(string name)
            {
                return new AzureAcrCheckNameTask(name);
            }

            public AzureAcrCreateTask AcrCreate(string name ,  string resourceGroup ,  string sku)
            {
                return new AzureAcrCreateTask(name,  resourceGroup,  sku);
            }

            public AzureAcrDeleteTask AcrDelete(string name)
            {
                return new AzureAcrDeleteTask(name);
            }

            public AzureAcrImportTask AcrImport(string name ,  string source)
            {
                return new AzureAcrImportTask(name,  source);
            }

            public AzureAcrLoginTask AcrLogin(string name)
            {
                return new AzureAcrLoginTask(name);
            }

            public AzureAcrRunTask AcrRun(string registry)
            {
                return new AzureAcrRunTask(registry);
            }

            public AzureAcrUpdateTask AcrUpdate(string name)
            {
                return new AzureAcrUpdateTask(name);
            }

            public AzureAcrBuildTaskTask AcrBuildTask()
            {
                return new AzureAcrBuildTaskTask();
            }

            public AzureAcrBuildTaskCreateTask AcrBuildTaskCreate(string context ,  string gitAccessToken ,  string image ,  string name ,  string registry)
            {
                return new AzureAcrBuildTaskCreateTask(context,  gitAccessToken,  image,  name,  registry);
            }

            public AzureAcrBuildTaskDeleteTask AcrBuildTaskDelete(string name ,  string registry)
            {
                return new AzureAcrBuildTaskDeleteTask(name,  registry);
            }

            public AzureAcrBuildTaskLogsTask AcrBuildTaskLogs(string registry)
            {
                return new AzureAcrBuildTaskLogsTask(registry);
            }

            public AzureAcrBuildTaskRunTask AcrBuildTaskRun(string name ,  string registry)
            {
                return new AzureAcrBuildTaskRunTask(name,  registry);
            }

            public AzureAcrBuildTaskUpdateTask AcrBuildTaskUpdate(string name ,  string registry)
            {
                return new AzureAcrBuildTaskUpdateTask(name,  registry);
            }

            public AzureAcrBuildTaskUpdateBuildTask AcrBuildTaskUpdateBuild(string buildId ,  string registry)
            {
                return new AzureAcrBuildTaskUpdateBuildTask(buildId,  registry);
            }

            public AzureAcrConfigTask AcrConfig()
            {
                return new AzureAcrConfigTask();
            }

            public AzureAcrCredentialTask AcrCredential()
            {
                return new AzureAcrCredentialTask();
            }

            public AzureAcrCredentialRenewTask AcrCredentialRenew(string name ,  string passwordName)
            {
                return new AzureAcrCredentialRenewTask(name,  passwordName);
            }

            public AzureAcrHelmTask AcrHelm()
            {
                return new AzureAcrHelmTask();
            }

            public AzureAcrHelmDeleteTask AcrHelmDelete(string name)
            {
                return new AzureAcrHelmDeleteTask(name);
            }

            public AzureAcrHelmPushTask AcrHelmPush(string name)
            {
                return new AzureAcrHelmPushTask(name);
            }

            public AzureAcrReplicationTask AcrReplication()
            {
                return new AzureAcrReplicationTask();
            }

            public AzureAcrReplicationCreateTask AcrReplicationCreate(string location ,  string registry)
            {
                return new AzureAcrReplicationCreateTask(location,  registry);
            }

            public AzureAcrReplicationDeleteTask AcrReplicationDelete(string name ,  string registry)
            {
                return new AzureAcrReplicationDeleteTask(name,  registry);
            }

            public AzureAcrReplicationUpdateTask AcrReplicationUpdate(string name ,  string registry)
            {
                return new AzureAcrReplicationUpdateTask(name,  registry);
            }

            public AzureAcrRepositoryTask AcrRepository()
            {
                return new AzureAcrRepositoryTask();
            }

            public AzureAcrRepositoryDeleteTask AcrRepositoryDelete(string name)
            {
                return new AzureAcrRepositoryDeleteTask(name);
            }

            public AzureAcrRepositoryUntagTask AcrRepositoryUntag(string image ,  string name)
            {
                return new AzureAcrRepositoryUntagTask(image,  name);
            }

            public AzureAcrRepositoryUpdateTask AcrRepositoryUpdate(string name)
            {
                return new AzureAcrRepositoryUpdateTask(name);
            }

            public AzureAcrTaskTask AcrTask()
            {
                return new AzureAcrTaskTask();
            }

            public AzureAcrTaskCancelRunTask AcrTaskCancelRun(string registry ,  string runId)
            {
                return new AzureAcrTaskCancelRunTask(registry,  runId);
            }

            public AzureAcrTaskCreateTask AcrTaskCreate(string context ,  string file ,  string name ,  string registry)
            {
                return new AzureAcrTaskCreateTask(context,  file,  name,  registry);
            }

            public AzureAcrTaskDeleteTask AcrTaskDelete(string name ,  string registry)
            {
                return new AzureAcrTaskDeleteTask(name,  registry);
            }

            public AzureAcrTaskLogsTask AcrTaskLogs(string registry)
            {
                return new AzureAcrTaskLogsTask(registry);
            }

            public AzureAcrTaskRunTask AcrTaskRun(string name ,  string registry)
            {
                return new AzureAcrTaskRunTask(name,  registry);
            }

            public AzureAcrTaskUpdateTask AcrTaskUpdate(string name ,  string registry)
            {
                return new AzureAcrTaskUpdateTask(name,  registry);
            }

            public AzureAcrTaskUpdateRunTask AcrTaskUpdateRun(string registry ,  string runId)
            {
                return new AzureAcrTaskUpdateRunTask(registry,  runId);
            }

            public AzureAcrWebhookTask AcrWebhook()
            {
                return new AzureAcrWebhookTask();
            }

            public AzureAcrWebhookCreateTask AcrWebhookCreate(string actions ,  string name ,  string registry ,  string uri)
            {
                return new AzureAcrWebhookCreateTask(actions,  name,  registry,  uri);
            }

            public AzureAcrWebhookDeleteTask AcrWebhookDelete(string name ,  string registry)
            {
                return new AzureAcrWebhookDeleteTask(name,  registry);
            }

            public AzureAcrWebhookGetConfigTask AcrWebhookGetConfig(string name ,  string registry)
            {
                return new AzureAcrWebhookGetConfigTask(name,  registry);
            }

            public AzureAcrWebhookPingTask AcrWebhookPing(string name ,  string registry)
            {
                return new AzureAcrWebhookPingTask(name,  registry);
            }

            public AzureAcrWebhookUpdateTask AcrWebhookUpdate(string name ,  string registry)
            {
                return new AzureAcrWebhookUpdateTask(name,  registry);
            }

            public AzureAcrConfigContentTrustTask AcrConfigContentTrust()
            {
                return new AzureAcrConfigContentTrustTask();
            }

            public AzureAcrConfigContentTrustUpdateTask AcrConfigContentTrustUpdate(string name)
            {
                return new AzureAcrConfigContentTrustUpdateTask(name);
            }

            public AzureAcrHelmRepoTask AcrHelmRepo()
            {
                return new AzureAcrHelmRepoTask();
            }

            public AzureAcrHelmRepoAddTask AcrHelmRepoAdd(string name)
            {
                return new AzureAcrHelmRepoAddTask(name);
            }
        
    }
}

