
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Extension
{
     public partial class AzureExtensionAddTask : ExternalProcessTaskBase<AzureExtensionAddTask>
     {
        
        /// <summary>
        /// Add an extension.
        /// </summary>
        public AzureExtensionAddTask()
        {
            WithArguments("az extension add");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of extension.
        /// </summary>
        public AzureExtensionAddTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// Filepath or URL to an extension.
        /// </summary>
        public AzureExtensionAddTask Source(string source = null)
        {
            WithArguments("--source");
            if (!string.IsNullOrEmpty(source))
            {
                 WithArguments(source);
            }

            return this;
        }

        /// <summary>
        /// Do not prompt for confirmation.
        /// </summary>
        public AzureExtensionAddTask Yes(string yes = null)
        {
            WithArguments("--yes");
            if (!string.IsNullOrEmpty(yes))
            {
                 WithArguments(yes);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.
        /// </summary>
        public AzureExtensionAddTask PipExtraIndexUrls(string pipExtraIndexUrls = null)
        {
            WithArguments("--pip-extra-index-urls");
            if (!string.IsNullOrEmpty(pipExtraIndexUrls))
            {
                 WithArguments(pipExtraIndexUrls);
            }

            return this;
        }

        /// <summary>
        /// Proxy for pip to use for extension dependencies in the form of [user:passwd@]proxy.server:port.
        /// </summary>
        public AzureExtensionAddTask PipProxy(string pipProxy = null)
        {
            WithArguments("--pip-proxy");
            if (!string.IsNullOrEmpty(pipProxy))
            {
                 WithArguments(pipProxy);
            }

            return this;
        }
     }
}
