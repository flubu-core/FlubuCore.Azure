
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cloud
{
     public partial class AzureCloudSetTask : ExternalProcessTaskBase<AzureCloudSetTask>
     {
        
        /// <summary>
        /// Set the active cloud.
        /// </summary>
        public AzureCloudSetTask(string name = null)
        {
            WithArguments("az cloud set");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Profile to use for this cloud.
        /// </summary>
        public AzureCloudSetTask Profile(string profile = null)
        {
            WithArguments("--profile");
            if (!string.IsNullOrEmpty(profile))
            {
                 WithArguments(profile);
            }

            return this;
        }
     }
}
