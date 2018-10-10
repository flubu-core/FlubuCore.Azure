
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappDeploymentUserSetTask : ExternalProcessTaskBase<AzureWebappDeploymentUserSetTask>
     {
        
        /// <summary>
        /// Update deployment credentials.
        /// </summary>
        public AzureWebappDeploymentUserSetTask(string userName = null)
        {
            WithArguments("az webapp deployment user set");
WithArguments("--user-name");
            if (!string.IsNullOrEmpty(userName))
            {
                 WithArguments(userName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Password, will prompt if not specified.
        /// </summary>
        public AzureWebappDeploymentUserSetTask Password(string password = null)
        {
            WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
            }

            return this;
        }
     }
}
