
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdGroupCreateTask : ExternalProcessTaskBase<AzureAdGroupCreateTask>
     {
        
        /// <summary>
        /// Create a group in the directory.
        /// </summary>
        public AzureAdGroupCreateTask(string displayName = null ,  string mailNickname = null)
        {
            WithArguments("az ad group create");
WithArguments("--display-name");
            if (!string.IsNullOrEmpty(displayName))
            {
                 WithArguments(displayName);
            }

WithArguments("--mail-nickname");
            if (!string.IsNullOrEmpty(mailNickname))
            {
                 WithArguments(mailNickname);
            }

        }

        protected override string Description { get; set; }
        
     }
}
