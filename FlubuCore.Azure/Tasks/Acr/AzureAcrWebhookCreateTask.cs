
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrWebhookCreateTask : ExternalProcessTaskBase<AzureAcrWebhookCreateTask>
     {
        
        /// <summary>
        /// Create a webhook for an Azure Container Registry.
        /// </summary>
        public AzureAcrWebhookCreateTask(string actions = null ,  string name = null ,  string registry = null ,  string uri = null)
        {
            WithArguments("az acr webhook create");
WithArguments("--actions");
            if (!string.IsNullOrEmpty(actions))
            {
                 WithArguments(actions);
            }

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

WithArguments("--uri");
            if (!string.IsNullOrEmpty(uri))
            {
                 WithArguments(uri);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Space-separated custom headers in 'key[=value]' format that will be added to the webhook notifications. Use "" to clear existing headers.
        /// </summary>
        public AzureAcrWebhookCreateTask Headers(string headers = null)
        {
            WithArguments("--headers");
            if (!string.IsNullOrEmpty(headers))
            {
                 WithArguments(headers);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureAcrWebhookCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureAcrWebhookCreateTask ResourceGroup(string resourceGroup = null)
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
        public AzureAcrWebhookCreateTask Scope(string scope = null)
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
        public AzureAcrWebhookCreateTask Status(string status = null)
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
        public AzureAcrWebhookCreateTask Tags(string tags = null)
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
