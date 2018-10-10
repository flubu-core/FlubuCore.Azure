
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Container;

namespace FlubuCore.Azure
{
    public class Container
    {
        
        
            public AzureContainerAttachTask ContainerAttach(string name ,  string resourceGroup)
            {
                return new AzureContainerAttachTask(name,  resourceGroup);
            }

            public AzureContainerCreateTask ContainerCreate(string resourceGroup)
            {
                return new AzureContainerCreateTask(resourceGroup);
            }

            public AzureContainerDeleteTask ContainerDelete(string name ,  string resourceGroup)
            {
                return new AzureContainerDeleteTask(name,  resourceGroup);
            }

            public AzureContainerExecTask ContainerExec(string execCommand ,  string name ,  string resourceGroup)
            {
                return new AzureContainerExecTask(execCommand,  name,  resourceGroup);
            }

            public AzureContainerExportTask ContainerExport(string file ,  string name ,  string resourceGroup)
            {
                return new AzureContainerExportTask(file,  name,  resourceGroup);
            }

            public AzureContainerLogsTask ContainerLogs(string name ,  string resourceGroup)
            {
                return new AzureContainerLogsTask(name,  resourceGroup);
            }

            public AzureContainerRestartTask ContainerRestart(string name ,  string resourceGroup)
            {
                return new AzureContainerRestartTask(name,  resourceGroup);
            }

            public AzureContainerStopTask ContainerStop(string name ,  string resourceGroup)
            {
                return new AzureContainerStopTask(name,  resourceGroup);
            }
        
    }
}

