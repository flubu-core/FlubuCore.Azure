
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Hanainstance;

namespace FlubuCore.Azure
{
    public class Hanainstance
    {
        
        
            public AzureHanainstanceRestartTask HanainstanceRestart(string instanceName ,  string resourceGroup)
            {
                return new AzureHanainstanceRestartTask(instanceName,  resourceGroup);
            }
        
    }
}

