
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dms
{
     public partial class AzureDmsCheckNameTask : ExternalProcessTaskBase<AzureDmsCheckNameTask>
     {
        
        /// <summary>
        /// Check if a given DMS instance name is available in a given region as well as the name's validity.
        /// </summary>
        public AzureDmsCheckNameTask(string location = null ,  string name = null)
        {
            WithArguments("az dms check-name");
WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
