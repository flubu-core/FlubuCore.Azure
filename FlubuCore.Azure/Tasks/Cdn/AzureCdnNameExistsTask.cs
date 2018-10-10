
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cdn
{
     public partial class AzureCdnNameExistsTask : ExternalProcessTaskBase<AzureCdnNameExistsTask>
     {
        
        /// <summary>
        /// Check the availability of a resource name.
        /// </summary>
        public AzureCdnNameExistsTask(string name = null)
        {
            WithArguments("az cdn name-exists");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
