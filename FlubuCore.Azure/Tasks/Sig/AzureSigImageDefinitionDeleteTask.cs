
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sig
{
     public partial class AzureSigImageDefinitionDeleteTask : ExternalProcessTaskBase<AzureSigImageDefinitionDeleteTask>
     {
        
        /// <summary>
        /// Delete a gallery image.
        /// </summary>
        public AzureSigImageDefinitionDeleteTask(string galleryImageDefinition = null ,  string galleryName = null ,  string resourceGroup = null)
        {
            WithArguments("az sig image-definition delete");
WithArguments("--gallery-image-definition");
            if (!string.IsNullOrEmpty(galleryImageDefinition))
            {
                 WithArguments(galleryImageDefinition);
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
