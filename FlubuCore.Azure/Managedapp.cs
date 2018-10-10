
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Managedapp;

namespace FlubuCore.Azure
{
    public class Managedapp
    {
        
        
            public AzureManagedappCreateTask ManagedappCreate(string kind ,  string managedRgId ,  string name ,  string resourceGroup)
            {
                return new AzureManagedappCreateTask(kind,  managedRgId,  name,  resourceGroup);
            }

            public AzureManagedappDeleteTask ManagedappDelete(string name ,  string resourceGroup)
            {
                return new AzureManagedappDeleteTask(name,  resourceGroup);
            }

            public AzureManagedappDefinitionTask ManagedappDefinition()
            {
                return new AzureManagedappDefinitionTask();
            }

            public AzureManagedappDefinitionCreateTask ManagedappDefinitionCreate(string authorizations ,  string displayName ,  string lockLevel ,  string name ,  string resourceGroup)
            {
                return new AzureManagedappDefinitionCreateTask(authorizations,  displayName,  lockLevel,  name,  resourceGroup);
            }

            public AzureManagedappDefinitionDeleteTask ManagedappDefinitionDelete(string name ,  string resourceGroup)
            {
                return new AzureManagedappDefinitionDeleteTask(name,  resourceGroup);
            }
        
    }
}

