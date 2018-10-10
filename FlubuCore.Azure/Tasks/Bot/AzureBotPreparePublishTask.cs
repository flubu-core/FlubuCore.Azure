
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotPreparePublishTask : ExternalProcessTaskBase<AzureBotPreparePublishTask>
     {
        
        /// <summary>
        /// Add scripts to your local source code directory to be able to publish back using `az bot publish`.
        /// </summary>
        public AzureBotPreparePublishTask(string name = null ,  string projName = null ,  string resourceGroup = null ,  string slnName = null)
        {
            WithArguments("az bot prepare-publish");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--proj-name");
            if (!string.IsNullOrEmpty(projName))
            {
                 WithArguments(projName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--sln-name");
            if (!string.IsNullOrEmpty(slnName))
            {
                 WithArguments(slnName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The directory to download deployment scripts to.
        /// </summary>
        public AzureBotPreparePublishTask CodeDir(string codeDir = null)
        {
            WithArguments("--code-dir");
            if (!string.IsNullOrEmpty(codeDir))
            {
                 WithArguments(codeDir);
            }

            return this;
        }
     }
}
