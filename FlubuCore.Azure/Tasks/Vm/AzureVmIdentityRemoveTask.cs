
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmIdentityRemoveTask : ExternalProcessTaskBase<AzureVmIdentityRemoveTask>
     {
        
        /// <summary>
        /// (PREVIEW) Remove managed service identities from a VM.
        /// </summary>
        public AzureVmIdentityRemoveTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vm identity remove");
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
        /// Space-separated identities to remove. Use '[system]' to refer system assigned identity.
        /// </summary>
        public AzureVmIdentityRemoveTask Identities(string identities = null)
        {
            WithArguments("--identities");
            if (!string.IsNullOrEmpty(identities))
            {
                 WithArguments(identities);
            }

            return this;
        }
     }
}
