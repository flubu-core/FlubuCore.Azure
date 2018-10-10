
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Lab
{
     public partial class AzureLabGalleryImageTask : ExternalProcessTaskBase<AzureLabGalleryImageTask>
     {
        
        /// <summary>
        /// List Azure Marketplace images allowed for a DevTest Lab.
        /// </summary>
        public AzureLabGalleryImageTask()
        {
            WithArguments("az lab gallery-image");
        }

        protected override string Description { get; set; }
        
     }
}
