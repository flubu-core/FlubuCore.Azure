
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Lab
{
     public partial class AzureLabSecretSetTask : ExternalProcessTaskBase<AzureLabSecretSetTask>
     {
        
        /// <summary>
        /// Set a secret for a lab.
        /// </summary>
        public AzureLabSecretSetTask(string labName = null ,  string name = null ,  string resourceGroup = null ,  string value = null)
        {
            WithArguments("az lab secret set");
WithArguments("--lab-name");
            if (!string.IsNullOrEmpty(labName))
            {
                 WithArguments(labName);
            }

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

WithArguments("--value");
            if (!string.IsNullOrEmpty(value))
            {
                 WithArguments(value);
            }

        }

        protected override string Description { get; set; }
        
     }
}
