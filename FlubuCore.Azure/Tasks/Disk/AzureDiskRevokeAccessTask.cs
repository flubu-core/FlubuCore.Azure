
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Disk
{
     public partial class AzureDiskRevokeAccessTask : ExternalProcessTaskBase<AzureDiskRevokeAccessTask>
     {
        
        /// <summary>
        /// Revoke a resource's read access to a managed disk.
        /// </summary>
        public AzureDiskRevokeAccessTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az disk revoke-access");
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
