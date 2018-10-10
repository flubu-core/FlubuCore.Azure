
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureSigTask : ExternalProcessTaskBase<AzureSigTask>
     {
        
        /// <summary>
        /// Manage shared image gallery.
        /// </summary>
        public AzureSigTask()
        {
            WithArguments("az sig");
        }

        protected override string Description { get; set; }
        
     }
}
