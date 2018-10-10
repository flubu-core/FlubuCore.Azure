
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Disk
{
     public partial class AzureDiskGrantAccessTask : ExternalProcessTaskBase<AzureDiskGrantAccessTask>
     {
        
        /// <summary>
        /// Grant a resource read access to a managed disk.
        /// </summary>
        public AzureDiskGrantAccessTask(string durationInSeconds = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az disk grant-access");
WithArguments("--duration-in-seconds");
            if (!string.IsNullOrEmpty(durationInSeconds))
            {
                 WithArguments(durationInSeconds);
            }

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

        }

        protected override string Description { get; set; }
        
     }
}
