
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sig
{
     public partial class AzureSigImageVersionDeleteTask : ExternalProcessTaskBase<AzureSigImageVersionDeleteTask>
     {
        
        /// <summary>
        /// Delete a gallery image version.
        /// </summary>
        public AzureSigImageVersionDeleteTask(string galleryImageDefinition = null ,  string galleryImageVersion = null ,  string galleryName = null ,  string resourceGroup = null)
        {
            WithArguments("az sig image-version delete");
WithArguments("--gallery-image-definition");
            if (!string.IsNullOrEmpty(galleryImageDefinition))
            {
                 WithArguments(galleryImageDefinition);
            }

WithArguments("--gallery-image-version");
            if (!string.IsNullOrEmpty(galleryImageVersion))
            {
                 WithArguments(galleryImageVersion);
            }

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
