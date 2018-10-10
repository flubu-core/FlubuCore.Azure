
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdUserDeleteTask : ExternalProcessTaskBase<AzureAdUserDeleteTask>
     {
        
        /// <summary>
        /// Delete a user.
        /// </summary>
        public AzureAdUserDeleteTask(string upnOrObjectId = null)
        {
            WithArguments("az ad user delete");
WithArguments("--upn-or-object-id");
            if (!string.IsNullOrEmpty(upnOrObjectId))
            {
                 WithArguments(upnOrObjectId);
            }

        }

        protected override string Description { get; set; }
        
     }
}
