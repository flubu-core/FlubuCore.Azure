
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Maps
{
     public partial class AzureMapsAccountCreateTask : ExternalProcessTaskBase<AzureMapsAccountCreateTask>
     {
        
        /// <summary>
        /// Create a maps account.
        /// </summary>
        public AzureMapsAccountCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az maps account create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Accept the Terms of Service, and do not prompt for confirmation.
        /// </summary>
        public AzureMapsAccountCreateTask AcceptTos(string acceptTos = null)
        {
            WithArguments("--accept-tos");
            if (!string.IsNullOrEmpty(acceptTos))
            {
                 WithArguments(acceptTos);
            }

            return this;
        }

        /// <summary>
        /// The name of the SKU.
        /// </summary>
        public AzureMapsAccountCreateTask Sku(string sku = null)
        {
            WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureMapsAccountCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }
     }
}
