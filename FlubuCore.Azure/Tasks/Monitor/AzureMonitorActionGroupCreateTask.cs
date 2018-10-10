
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorActionGroupCreateTask : ExternalProcessTaskBase<AzureMonitorActionGroupCreateTask>
     {
        
        /// <summary>
        /// Create a new action group.
        /// </summary>
        public AzureMonitorActionGroupCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az monitor action-group create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The short name of the action group.
        /// </summary>
        public AzureMonitorActionGroupCreateTask ShortName(string shortName = null)
        {
            WithArguments("--short-name");
            if (!string.IsNullOrEmpty(shortName))
            {
                 WithArguments(shortName);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureMonitorActionGroupCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Add receivers to the action group during the creation.
        /// </summary>
        public AzureMonitorActionGroupCreateTask Action(string action = null)
        {
            WithArguments("--action");
            if (!string.IsNullOrEmpty(action))
            {
                 WithArguments(action);
            }

            return this;
        }
     }
}
