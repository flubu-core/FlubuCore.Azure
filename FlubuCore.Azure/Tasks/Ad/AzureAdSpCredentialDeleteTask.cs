
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdSpCredentialDeleteTask : ExternalProcessTaskBase<AzureAdSpCredentialDeleteTask>
     {
        
        /// <summary>
        /// Delete a service principal's credential.
        /// </summary>
        public AzureAdSpCredentialDeleteTask(string id = null ,  string keyId = null)
        {
            WithArguments("az ad sp credential delete");
WithArguments("--id");
            if (!string.IsNullOrEmpty(id))
            {
                 WithArguments(id);
            }

WithArguments("--key-id");
            if (!string.IsNullOrEmpty(keyId))
            {
                 WithArguments(keyId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// A certificate based credential.
        /// </summary>
        public AzureAdSpCredentialDeleteTask Cert(string cert = null)
        {
            WithArguments("--cert");
            if (!string.IsNullOrEmpty(cert))
            {
                 WithArguments(cert);
            }

            return this;
        }
     }
}
