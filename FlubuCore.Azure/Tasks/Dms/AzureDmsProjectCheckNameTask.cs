
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dms
{
     public partial class AzureDmsProjectCheckNameTask : ExternalProcessTaskBase<AzureDmsProjectCheckNameTask>
     {
        
        /// <summary>
        /// Check if a given Project name is available within a given instance of DMS as well as the name's validity.
        /// </summary>
        public AzureDmsProjectCheckNameTask(string name = null ,  string resourceGroup = null ,  string serviceName = null)
        {
            WithArguments("az dms project check-name");
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

WithArguments("--service-name");
            if (!string.IsNullOrEmpty(serviceName))
            {
                 WithArguments(serviceName);
            }

        }

        protected override string Description { get; set; }
        
     }
}
