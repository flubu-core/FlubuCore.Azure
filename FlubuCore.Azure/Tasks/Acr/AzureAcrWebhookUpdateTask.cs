
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrWebhookUpdateTask : ExternalProcessTaskBase<AzureAcrWebhookUpdateTask>
     {
        
        /// <summary>
        /// Update a webhook.
        /// </summary>
        public AzureAcrWebhookUpdateTask(string name = null ,  string registry = null)
        {
            WithArguments("az acr webhook update");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--registry");
            if (!string.IsNullOrEmpty(registry))
            {
                 WithArguments(registry);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Space-separated list of actions that trigger the webhook to post notifications.
        /// </summary>
        public AzureAcrWebhookUpdateTask Actions(string actions = null)
        {
            WithArguments("--actions");
            if (!string.IsNullOrEmpty(actions))
            {
                 WithArguments(actions);
            }

            return this;
        }

        /// <summary>
        /// Space-separated custom headers in 'key[=value]' format that will be added to the webhook notifications. Use "" to clear existing headers.
        /// </summary>
        public AzureAcrWebhookUpdateTask Headers(string headers = null)
        {
            WithArguments("--headers");
            if (!string.IsNullOrEmpty(headers))
            {
                 WithArguments(headers);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureAcrWebhookUpdateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// The scope of repositories where the event can be triggered. For example, 'foo:*' means events for all tags under repository 'foo'. 'foo:bar' means events for 'foo:bar' only. 'foo' is equivalent to 'foo:latest'. Empty means events for all repositories.
        /// </summary>
        public AzureAcrWebhookUpdateTask Scope(string scope = null)
        {
            WithArguments("--scope");
            if (!string.IsNullOrEmpty(scope))
            {
                 WithArguments(scope);
            }

            return this;
        }

        /// <summary>
        /// Indicates whether the webhook is enabled.
        /// </summary>
        public AzureAcrWebhookUpdateTask Status(string status = null)
        {
            WithArguments("--status");
            if (!string.IsNullOrEmpty(status))
            {
                 WithArguments(status);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureAcrWebhookUpdateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// The service URI for the webhook to post notifications.
        /// </summary>
        public AzureAcrWebhookUpdateTask Uri(string uri = null)
        {
            WithArguments("--uri");
            if (!string.IsNullOrEmpty(uri))
            {
                 WithArguments(uri);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureAcrWebhookUpdateTask Add(string add = null)
        {
            WithArguments("--add");
            if (!string.IsNullOrEmpty(add))
            {
                 WithArguments(add);
            }

            return this;
        }

        /// <summary>
        /// When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public AzureAcrWebhookUpdateTask ForceString(string forceString = null)
        {
            WithArguments("--force-string");
            if (!string.IsNullOrEmpty(forceString))
            {
                 WithArguments(forceString);
            }

            return this;
        }

        /// <summary>
        /// Remove a property or an element from a list.  Example: --remove property.list <indexToRemove> OR --remove propertyToRemove.
        /// </summary>
        public AzureAcrWebhookUpdateTask Remove(string remove = null)
        {
            WithArguments("--remove");
            if (!string.IsNullOrEmpty(remove))
            {
                 WithArguments(remove);
            }

            return this;
        }

        /// <summary>
        /// Update an object by specifying a property path and value to set.  Example: --set property1.property2=<value>.
        /// </summary>
        public AzureAcrWebhookUpdateTask Set(string set = null)
        {
            WithArguments("--set");
            if (!string.IsNullOrEmpty(set))
            {
                 WithArguments(set);
            }

            return this;
        }
     }
}
