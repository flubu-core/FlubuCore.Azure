
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrTaskDeleteTask : ExternalProcessTaskBase<AzureAcrTaskDeleteTask>
     {
        
        /// <summary>
        /// Delete a task from an Azure Container Registry.
        /// </summary>
        public AzureAcrTaskDeleteTask(string name = null ,  string registry = null)
        {
            WithArguments("az acr task delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--registry");
            if (!string.IsNullOrEmpty(registry))
            {
                 WithArguments(registry);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureAcrTaskDeleteTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }
     }
}
