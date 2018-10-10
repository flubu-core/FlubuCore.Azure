
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsFsSetExpiryTask : ExternalProcessTaskBase<AzureDlsFsSetExpiryTask>
     {
        
        /// <summary>
        /// Set the expiration time for a file.
        /// </summary>
        public AzureDlsFsSetExpiryTask(string account = null ,  string expirationTime = null ,  string path = null)
        {
            WithArguments("az dls fs set-expiry");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

WithArguments("--expiration-time");
            if (!string.IsNullOrEmpty(expirationTime))
            {
                 WithArguments(expirationTime);
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
