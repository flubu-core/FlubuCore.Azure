
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusMigrationStartTask : ExternalProcessTaskBase<AzureServicebusMigrationStartTask>
     {
        
        /// <summary>
        /// Create and Start Service Bus Migration of Standard to Premium namespace.
        /// </summary>
        public AzureServicebusMigrationStartTask(string name = null ,  string postMigrationName = null ,  string resourceGroup = null ,  string targetNamespace = null)
        {
            WithArguments("az servicebus migration start");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--post-migration-name");
            if (!string.IsNullOrEmpty(postMigrationName))
            {
                 WithArguments(postMigrationName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--target-namespace");
            if (!string.IsNullOrEmpty(targetNamespace))
            {
                 WithArguments(targetNamespace);
            }

        }

        protected override string Description { get; set; }
        
     }
}
