
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Appservice;

namespace FlubuCore.Azure
{
    public class Appservice
    {
        
        
            public AzureAppservicePlanTask AppservicePlan()
            {
                return new AzureAppservicePlanTask();
            }

            public AzureAppservicePlanCreateTask AppservicePlanCreate(string name ,  string resourceGroup)
            {
                return new AzureAppservicePlanCreateTask(name,  resourceGroup);
            }

            public AzureAppservicePlanDeleteTask AppservicePlanDelete(string name ,  string resourceGroup)
            {
                return new AzureAppservicePlanDeleteTask(name,  resourceGroup);
            }

            public AzureAppservicePlanUpdateTask AppservicePlanUpdate(string name ,  string resourceGroup)
            {
                return new AzureAppservicePlanUpdateTask(name,  resourceGroup);
            }
        
    }
}

