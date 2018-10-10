
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappDeploymentUserSetTask : ExternalProcessTaskBase<AzureFunctionappDeploymentUserSetTask>
     {
        
        /// <summary>
        /// Update deployment credentials.
        /// </summary>
        public AzureFunctionappDeploymentUserSetTask(string userName = null)
        {
            WithArguments("az functionapp deployment user set");
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
        public AzureFunctionappDeploymentUserSetTask Password(string password = null)
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
