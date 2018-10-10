
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sig
{
     public partial class AzureSigDeleteTask : ExternalProcessTaskBase<AzureSigDeleteTask>
     {
        
        /// <summary>
        /// Delete a gallery.
        /// </summary>
        public AzureSigDeleteTask(string galleryName = null ,  string resourceGroup = null)
        {
            WithArguments("az sig delete");
WithArguments("--gallery-name");
            if (!string.IsNullOrEmpty(galleryName))
            {
                 WithArguments(galleryName);
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
