
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Cloud;

namespace FlubuCore.Azure
{
    public class Cloud
    {
        
        
            public AzureCloudRegisterTask CloudRegister(string name)
            {
                return new AzureCloudRegisterTask(name);
            }

            public AzureCloudSetTask CloudSet(string name)
            {
                return new AzureCloudSetTask(name);
            }

            public AzureCloudUnregisterTask CloudUnregister(string name)
            {
                return new AzureCloudUnregisterTask(name);
            }

            public AzureCloudUpdateTask CloudUpdate()
            {
                return new AzureCloudUpdateTask();
            }
        
    }
}

