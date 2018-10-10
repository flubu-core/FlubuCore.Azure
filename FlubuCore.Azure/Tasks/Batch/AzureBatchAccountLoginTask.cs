
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchAccountLoginTask : ExternalProcessTaskBase<AzureBatchAccountLoginTask>
     {
        
        /// <summary>
        /// Log in to a Batch account through Azure Active Directory or Shared Key authentication.
        /// </summary>
        public AzureBatchAccountLoginTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az batch account login");
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
        
        /// <summary>
        /// Using Shared Key authentication, if not specified, it will use Azure Active Directory authentication.
        /// </summary>
        public AzureBatchAccountLoginTask SharedKeyAuth(string sharedKeyAuth = null)
        {
            WithArguments("--shared-key-auth");
            if (!string.IsNullOrEmpty(sharedKeyAuth))
            {
                 WithArguments(sharedKeyAuth);
            }

            return this;
        }

        /// <summary>
        /// Display the credential information for the Batch account.
        /// </summary>
        public AzureBatchAccountLoginTask Show(string show = null)
        {
            WithArguments("--show");
            if (!string.IsNullOrEmpty(show))
            {
                 WithArguments(show);
            }

            return this;
        }
     }
}
