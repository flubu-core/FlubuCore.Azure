
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappUpTask : ExternalProcessTaskBase<AzureWebappUpTask>
     {
        
        /// <summary>
        /// Experimental command to create and deploy a web app. Current supports includes Node on Linux & .NET Core, ASP.NET, staticHtml on Windows.
        /// </summary>
        public AzureWebappUpTask(string name = null)
        {
            WithArguments("az webapp up");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Shows summary of the create and deploy operation instead of executing it.
        /// </summary>
        public AzureWebappUpTask Dryrun(string dryrun = null)
        {
            WithArguments("--dryrun");
            if (!string.IsNullOrEmpty(dryrun))
            {
                 WithArguments(dryrun);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureWebappUpTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }
     }
}
