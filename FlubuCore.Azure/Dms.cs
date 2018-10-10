
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Dms;

namespace FlubuCore.Azure
{
    public class Dms
    {
        
        
            public AzureDmsCheckNameTask DmsCheckName(string location ,  string name)
            {
                return new AzureDmsCheckNameTask(location,  name);
            }

            public AzureDmsCheckStatusTask DmsCheckStatus(string name ,  string resourceGroup)
            {
                return new AzureDmsCheckStatusTask(name,  resourceGroup);
            }

            public AzureDmsCreateTask DmsCreate(string location ,  string name ,  string resourceGroup ,  string skuName ,  string subnet)
            {
                return new AzureDmsCreateTask(location,  name,  resourceGroup,  skuName,  subnet);
            }

            public AzureDmsDeleteTask DmsDelete(string name ,  string resourceGroup)
            {
                return new AzureDmsDeleteTask(name,  resourceGroup);
            }

            public AzureDmsStartTask DmsStart(string name ,  string resourceGroup)
            {
                return new AzureDmsStartTask(name,  resourceGroup);
            }

            public AzureDmsStopTask DmsStop(string name ,  string resourceGroup)
            {
                return new AzureDmsStopTask(name,  resourceGroup);
            }

            public AzureDmsWaitTask DmsWait(string name ,  string resourceGroup)
            {
                return new AzureDmsWaitTask(name,  resourceGroup);
            }

            public AzureDmsProjectTask DmsProject()
            {
                return new AzureDmsProjectTask();
            }

            public AzureDmsProjectCheckNameTask DmsProjectCheckName(string name ,  string resourceGroup ,  string serviceName)
            {
                return new AzureDmsProjectCheckNameTask(name,  resourceGroup,  serviceName);
            }

            public AzureDmsProjectCreateTask DmsProjectCreate(string location ,  string name ,  string resourceGroup ,  string serviceName ,  string sourcePlatform ,  string targetPlatform)
            {
                return new AzureDmsProjectCreateTask(location,  name,  resourceGroup,  serviceName,  sourcePlatform,  targetPlatform);
            }

            public AzureDmsProjectDeleteTask DmsProjectDelete(string name ,  string resourceGroup ,  string serviceName)
            {
                return new AzureDmsProjectDeleteTask(name,  resourceGroup,  serviceName);
            }

            public AzureDmsProjectTaskTask DmsProjectTask()
            {
                return new AzureDmsProjectTaskTask();
            }

            public AzureDmsProjectTaskCancelTask DmsProjectTaskCancel(string name ,  string projectName ,  string resourceGroup ,  string serviceName)
            {
                return new AzureDmsProjectTaskCancelTask(name,  projectName,  resourceGroup,  serviceName);
            }

            public AzureDmsProjectTaskCheckNameTask DmsProjectTaskCheckName(string name ,  string projectName ,  string resourceGroup ,  string serviceName)
            {
                return new AzureDmsProjectTaskCheckNameTask(name,  projectName,  resourceGroup,  serviceName);
            }

            public AzureDmsProjectTaskCreateTask DmsProjectTaskCreate(string databaseOptionsJson ,  string name ,  string projectName ,  string resourceGroup ,  string serviceName ,  string sourceConnectionJson ,  string targetConnectionJson)
            {
                return new AzureDmsProjectTaskCreateTask(databaseOptionsJson,  name,  projectName,  resourceGroup,  serviceName,  sourceConnectionJson,  targetConnectionJson);
            }

            public AzureDmsProjectTaskDeleteTask DmsProjectTaskDelete(string name ,  string projectName ,  string resourceGroup ,  string serviceName)
            {
                return new AzureDmsProjectTaskDeleteTask(name,  projectName,  resourceGroup,  serviceName);
            }

            public AzureDmsProjectTaskCutoverTask DmsProjectTaskCutover(string databaseName ,  string name ,  string projectName ,  string resourceGroup ,  string serviceName)
            {
                return new AzureDmsProjectTaskCutoverTask(databaseName,  name,  projectName,  resourceGroup,  serviceName);
            }
        
    }
}

