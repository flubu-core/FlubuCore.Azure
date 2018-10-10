
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Signalr;

namespace FlubuCore.Azure
{
    public class Signalr
    {
        
        
            public AzureSignalrCreateTask SignalrCreate(string name ,  string resourceGroup ,  string sku)
            {
                return new AzureSignalrCreateTask(name,  resourceGroup,  sku);
            }

            public AzureSignalrDeleteTask SignalrDelete(string name ,  string resourceGroup)
            {
                return new AzureSignalrDeleteTask(name,  resourceGroup);
            }

            public AzureSignalrKeyTask SignalrKey()
            {
                return new AzureSignalrKeyTask();
            }

            public AzureSignalrKeyRenewTask SignalrKeyRenew(string keyType ,  string name ,  string resourceGroup)
            {
                return new AzureSignalrKeyRenewTask(keyType,  name,  resourceGroup);
            }
        
    }
}

