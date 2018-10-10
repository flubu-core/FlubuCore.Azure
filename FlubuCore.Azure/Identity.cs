
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Identity;

namespace FlubuCore.Azure
{
    public class Identity
    {
        
        
            public AzureIdentityCreateTask IdentityCreate(string name ,  string resourceGroup)
            {
                return new AzureIdentityCreateTask(name,  resourceGroup);
            }

            public AzureIdentityDeleteTask IdentityDelete(string name ,  string resourceGroup)
            {
                return new AzureIdentityDeleteTask(name,  resourceGroup);
            }
        
    }
}

