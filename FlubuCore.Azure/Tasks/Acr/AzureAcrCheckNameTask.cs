
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrCheckNameTask : ExternalProcessTaskBase<AzureAcrCheckNameTask>
     {
        
        /// <summary>
        /// Checks if an Azure Container Registry name is valid and available for use.
        /// </summary>
        public AzureAcrCheckNameTask(string name = null)
        {
            WithArguments("az acr check-name");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
