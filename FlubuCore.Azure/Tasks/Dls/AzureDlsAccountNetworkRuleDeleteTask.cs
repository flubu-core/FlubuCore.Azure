
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsAccountNetworkRuleDeleteTask : ExternalProcessTaskBase<AzureDlsAccountNetworkRuleDeleteTask>
     {
        
        /// <summary>
        /// Deletes a virtual network rule in a Data Lake Store account.
        /// </summary>
        public AzureDlsAccountNetworkRuleDeleteTask(string accountName = null ,  string name = null)
        {
            WithArguments("az dls account network-rule delete");
WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureDlsAccountNetworkRuleDeleteTask ResourceGroup(string resourceGroup = null)
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
