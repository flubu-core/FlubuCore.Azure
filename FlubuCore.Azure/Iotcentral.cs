
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Iotcentral;

namespace FlubuCore.Azure
{
    public class Iotcentral
    {
        
        
            public AzureIotcentralAppTask IotcentralApp()
            {
                return new AzureIotcentralAppTask();
            }

            public AzureIotcentralAppCreateTask IotcentralAppCreate(string name ,  string resourceGroup ,  string subdomain)
            {
                return new AzureIotcentralAppCreateTask(name,  resourceGroup,  subdomain);
            }

            public AzureIotcentralAppDeleteTask IotcentralAppDelete(string name ,  string resourceGroup)
            {
                return new AzureIotcentralAppDeleteTask(name,  resourceGroup);
            }

            public AzureIotcentralAppUpdateTask IotcentralAppUpdate(string name ,  string resourceGroup)
            {
                return new AzureIotcentralAppUpdateTask(name,  resourceGroup);
            }
        
    }
}

