
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Image
{
     public partial class AzureImageDeleteTask : ExternalProcessTaskBase<AzureImageDeleteTask>
     {
        
        /// <summary>
        /// Deletes an Image.
        /// </summary>
        public AzureImageDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az image delete");
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
        
     }
}
