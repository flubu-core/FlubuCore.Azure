
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsFsRemoveExpiryTask : ExternalProcessTaskBase<AzureDlsFsRemoveExpiryTask>
     {
        
        /// <summary>
        /// Remove the expiration time for a file.
        /// </summary>
        public AzureDlsFsRemoveExpiryTask(string account = null ,  string path = null)
        {
            WithArguments("az dls fs remove-expiry");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

WithArguments("--path");
            if (!string.IsNullOrEmpty(path))
            {
                 WithArguments(path);
            }

        }

        protected override string Description { get; set; }
        
     }
}
