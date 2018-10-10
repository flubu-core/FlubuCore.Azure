
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Deployment;

namespace FlubuCore.Azure
{
    public class Deployment
    {
        
        
            public AzureDeploymentCreateTask DeploymentCreate(string location)
            {
                return new AzureDeploymentCreateTask(location);
            }

            public AzureDeploymentDeleteTask DeploymentDelete(string name)
            {
                return new AzureDeploymentDeleteTask(name);
            }

            public AzureDeploymentExportTask DeploymentExport(string name)
            {
                return new AzureDeploymentExportTask(name);
            }

            public AzureDeploymentValidateTask DeploymentValidate(string location)
            {
                return new AzureDeploymentValidateTask(location);
            }

            public AzureDeploymentWaitTask DeploymentWait(string name)
            {
                return new AzureDeploymentWaitTask(name);
            }

            public AzureDeploymentOperationTask DeploymentOperation()
            {
                return new AzureDeploymentOperationTask();
            }
        
    }
}

