
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sig
{
     public partial class AzureSigImageVersionTask : ExternalProcessTaskBase<AzureSigImageVersionTask>
     {
        
        /// <summary>
        /// Create a new version from an image defintion.
        /// </summary>
        public AzureSigImageVersionTask()
        {
            WithArguments("az sig image-version");
        }

        protected override string Description { get; set; }
        
     }
}
