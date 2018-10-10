
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Extension
{
     public partial class AzureExtensionUpdateTask : ExternalProcessTaskBase<AzureExtensionUpdateTask>
     {
        
        /// <summary>
        /// Update an extension.
        /// </summary>
        public AzureExtensionUpdateTask(string name = null)
        {
            WithArguments("az extension update");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.
        /// </summary>
        public AzureExtensionUpdateTask PipExtraIndexUrls(string pipExtraIndexUrls = null)
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
        public AzureExtensionUpdateTask PipProxy(string pipProxy = null)
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
