
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Batchai;

namespace FlubuCore.Azure
{
    public class Batchai
    {
        
        
            public AzureBatchaiClusterTask BatchaiCluster()
            {
                return new AzureBatchaiClusterTask();
            }

            public AzureBatchaiClusterAutoScaleTask BatchaiClusterAutoScale(string max ,  string min ,  string name ,  string resourceGroup ,  string workspace)
            {
                return new AzureBatchaiClusterAutoScaleTask(max,  min,  name,  resourceGroup,  workspace);
            }

            public AzureBatchaiClusterCreateTask BatchaiClusterCreate(string name ,  string resourceGroup ,  string workspace)
            {
                return new AzureBatchaiClusterCreateTask(name,  resourceGroup,  workspace);
            }

            public AzureBatchaiClusterDeleteTask BatchaiClusterDelete(string name ,  string resourceGroup ,  string workspace)
            {
                return new AzureBatchaiClusterDeleteTask(name,  resourceGroup,  workspace);
            }

            public AzureBatchaiClusterResizeTask BatchaiClusterResize(string name ,  string resourceGroup ,  string target ,  string workspace)
            {
                return new AzureBatchaiClusterResizeTask(name,  resourceGroup,  target,  workspace);
            }

            public AzureBatchaiExperimentTask BatchaiExperiment()
            {
                return new AzureBatchaiExperimentTask();
            }

            public AzureBatchaiExperimentCreateTask BatchaiExperimentCreate(string name ,  string resourceGroup ,  string workspace)
            {
                return new AzureBatchaiExperimentCreateTask(name,  resourceGroup,  workspace);
            }

            public AzureBatchaiExperimentDeleteTask BatchaiExperimentDelete(string name ,  string resourceGroup ,  string workspace)
            {
                return new AzureBatchaiExperimentDeleteTask(name,  resourceGroup,  workspace);
            }

            public AzureBatchaiFileServerTask BatchaiFileServer()
            {
                return new AzureBatchaiFileServerTask();
            }

            public AzureBatchaiFileServerCreateTask BatchaiFileServerCreate(string name ,  string resourceGroup ,  string workspace)
            {
                return new AzureBatchaiFileServerCreateTask(name,  resourceGroup,  workspace);
            }

            public AzureBatchaiFileServerDeleteTask BatchaiFileServerDelete(string name ,  string resourceGroup ,  string workspace)
            {
                return new AzureBatchaiFileServerDeleteTask(name,  resourceGroup,  workspace);
            }

            public AzureBatchaiJobTask BatchaiJob()
            {
                return new AzureBatchaiJobTask();
            }

            public AzureBatchaiJobCreateTask BatchaiJobCreate(string cluster ,  string configFile ,  string experiment ,  string name ,  string resourceGroup ,  string workspace)
            {
                return new AzureBatchaiJobCreateTask(cluster,  configFile,  experiment,  name,  resourceGroup,  workspace);
            }

            public AzureBatchaiJobDeleteTask BatchaiJobDelete(string experiment ,  string name ,  string resourceGroup ,  string workspace)
            {
                return new AzureBatchaiJobDeleteTask(experiment,  name,  resourceGroup,  workspace);
            }

            public AzureBatchaiJobTerminateTask BatchaiJobTerminate(string experiment ,  string name ,  string resourceGroup ,  string workspace)
            {
                return new AzureBatchaiJobTerminateTask(experiment,  name,  resourceGroup,  workspace);
            }

            public AzureBatchaiJobWaitTask BatchaiJobWait(string experiment ,  string name ,  string resourceGroup ,  string workspace)
            {
                return new AzureBatchaiJobWaitTask(experiment,  name,  resourceGroup,  workspace);
            }

            public AzureBatchaiWorkspaceTask BatchaiWorkspace()
            {
                return new AzureBatchaiWorkspaceTask();
            }

            public AzureBatchaiWorkspaceCreateTask BatchaiWorkspaceCreate(string resourceGroup ,  string workspace)
            {
                return new AzureBatchaiWorkspaceCreateTask(resourceGroup,  workspace);
            }

            public AzureBatchaiWorkspaceDeleteTask BatchaiWorkspaceDelete(string resourceGroup ,  string workspace)
            {
                return new AzureBatchaiWorkspaceDeleteTask(resourceGroup,  workspace);
            }

            public AzureBatchaiClusterFileTask BatchaiClusterFile()
            {
                return new AzureBatchaiClusterFileTask();
            }

            public AzureBatchaiClusterNodeTask BatchaiClusterNode()
            {
                return new AzureBatchaiClusterNodeTask();
            }

            public AzureBatchaiClusterNodeExecTask BatchaiClusterNodeExec(string cluster ,  string resourceGroup ,  string workspace)
            {
                return new AzureBatchaiClusterNodeExecTask(cluster,  resourceGroup,  workspace);
            }

            public AzureBatchaiJobFileTask BatchaiJobFile()
            {
                return new AzureBatchaiJobFileTask();
            }

            public AzureBatchaiJobFileStreamTask BatchaiJobFileStream(string experiment ,  string fileName ,  string job ,  string resourceGroup ,  string workspace)
            {
                return new AzureBatchaiJobFileStreamTask(experiment,  fileName,  job,  resourceGroup,  workspace);
            }

            public AzureBatchaiJobNodeTask BatchaiJobNode()
            {
                return new AzureBatchaiJobNodeTask();
            }

            public AzureBatchaiJobNodeExecTask BatchaiJobNodeExec(string experiment ,  string job ,  string resourceGroup ,  string workspace)
            {
                return new AzureBatchaiJobNodeExecTask(experiment,  job,  resourceGroup,  workspace);
            }
        
    }
}

