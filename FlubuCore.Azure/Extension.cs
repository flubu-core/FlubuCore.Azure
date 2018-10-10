
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Extension;

namespace FlubuCore.Azure
{
    public class Extension
    {
        
        
            public AzureExtensionAddTask ExtensionAdd()
            {
                return new AzureExtensionAddTask();
            }

            public AzureExtensionRemoveTask ExtensionRemove(string name)
            {
                return new AzureExtensionRemoveTask(name);
            }

            public AzureExtensionUpdateTask ExtensionUpdate(string name)
            {
                return new AzureExtensionUpdateTask(name);
            }
        
    }
}

