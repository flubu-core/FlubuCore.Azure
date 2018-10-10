
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sig
{
     public partial class AzureSigImageDefinitionTask : ExternalProcessTaskBase<AzureSigImageDefinitionTask>
     {
        
        /// <summary>
        /// Create an image definition.
        /// </summary>
        public AzureSigImageDefinitionTask()
        {
            WithArguments("az sig image-definition");
        }

        protected override string Description { get; set; }
        
     }
}
