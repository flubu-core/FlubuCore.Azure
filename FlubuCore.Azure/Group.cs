
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Group;

namespace FlubuCore.Azure
{
    public class Group
    {
        
        
            public AzureGroupCreateTask GroupCreate(string location ,  string name)
            {
                return new AzureGroupCreateTask(location,  name);
            }

            public AzureGroupDeleteTask GroupDelete(string name)
            {
                return new AzureGroupDeleteTask(name);
            }

            public AzureGroupExistsTask GroupExists(string name)
            {
                return new AzureGroupExistsTask(name);
            }

            public AzureGroupExportTask GroupExport(string name)
            {
                return new AzureGroupExportTask(name);
            }

            public AzureGroupUpdateTask GroupUpdate(string name)
            {
                return new AzureGroupUpdateTask(name);
            }

            public AzureGroupWaitTask GroupWait(string name)
            {
                return new AzureGroupWaitTask(name);
            }

            public AzureGroupDeploymentTask GroupDeployment()
            {
                return new AzureGroupDeploymentTask();
            }

            public AzureGroupDeploymentCreateTask GroupDeploymentCreate(string resourceGroup)
            {
                return new AzureGroupDeploymentCreateTask(resourceGroup);
            }

            public AzureGroupDeploymentDeleteTask GroupDeploymentDelete(string name ,  string resourceGroup)
            {
                return new AzureGroupDeploymentDeleteTask(name,  resourceGroup);
            }

            public AzureGroupDeploymentExportTask GroupDeploymentExport(string name ,  string resourceGroup)
            {
                return new AzureGroupDeploymentExportTask(name,  resourceGroup);
            }

            public AzureGroupDeploymentValidateTask GroupDeploymentValidate(string resourceGroup)
            {
                return new AzureGroupDeploymentValidateTask(resourceGroup);
            }

            public AzureGroupDeploymentWaitTask GroupDeploymentWait(string name ,  string resourceGroup)
            {
                return new AzureGroupDeploymentWaitTask(name,  resourceGroup);
            }

            public AzureGroupLockTask GroupLock()
            {
                return new AzureGroupLockTask();
            }

            public AzureGroupLockCreateTask GroupLockCreate(string lockType ,  string name ,  string resourceGroup)
            {
                return new AzureGroupLockCreateTask(lockType,  name,  resourceGroup);
            }

            public AzureGroupLockDeleteTask GroupLockDelete()
            {
                return new AzureGroupLockDeleteTask();
            }

            public AzureGroupLockUpdateTask GroupLockUpdate()
            {
                return new AzureGroupLockUpdateTask();
            }

            public AzureGroupDeploymentOperationTask GroupDeploymentOperation()
            {
                return new AzureGroupDeploymentOperationTask();
            }
        
    }
}

