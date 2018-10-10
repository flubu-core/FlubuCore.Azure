
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappUpdateTask : ExternalProcessTaskBase<AzureWebappUpdateTask>
     {
        
        /// <summary>
        /// Update a web app.
        /// </summary>
        public AzureWebappUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp update");
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
        /// Enables sending session affinity cookies.
        /// </summary>
        public AzureWebappUpdateTask ClientAffinityEnabled(string clientAffinityEnabled = null)
        {
            WithArguments("--client-affinity-enabled");
            if (!string.IsNullOrEmpty(clientAffinityEnabled))
            {
                 WithArguments(clientAffinityEnabled);
            }

            return this;
        }

        /// <summary>
        /// If true, web app hostname is force registered with DNS.
        /// </summary>
        public AzureWebappUpdateTask ForceDnsRegistration(string forceDnsRegistration = null)
        {
            WithArguments("--force-dns-registration");
            if (!string.IsNullOrEmpty(forceDnsRegistration))
            {
                 WithArguments(forceDnsRegistration);
            }

            return this;
        }

        /// <summary>
        /// Redirect all traffic made to an app using HTTP to HTTPS.
        /// </summary>
        public AzureWebappUpdateTask HttpsOnly(string httpsOnly = null)
        {
            WithArguments("--https-only");
            if (!string.IsNullOrEmpty(httpsOnly))
            {
                 WithArguments(httpsOnly);
            }

            return this;
        }

        /// <summary>
        /// If true, custom (non *.azurewebsites.net) domains associated with web app are not verified.
        /// </summary>
        public AzureWebappUpdateTask SkipCustomDomainVerification(string skipCustomDomainVerification = null)
        {
            WithArguments("--skip-custom-domain-verification");
            if (!string.IsNullOrEmpty(skipCustomDomainVerification))
            {
                 WithArguments(skipCustomDomainVerification);
            }

            return this;
        }

        /// <summary>
        /// If true web app hostname is not registered with DNS on creation.
        /// </summary>
        public AzureWebappUpdateTask SkipDnsRegistration(string skipDnsRegistration = null)
        {
            WithArguments("--skip-dns-registration");
            if (!string.IsNullOrEmpty(skipDnsRegistration))
            {
                 WithArguments(skipDnsRegistration);
            }

            return this;
        }

        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappUpdateTask Slot(string slot = null)
        {
            WithArguments("--slot");
            if (!string.IsNullOrEmpty(slot))
            {
                 WithArguments(slot);
            }

            return this;
        }

        /// <summary>
        /// Time to live in seconds for web app's default domain name.
        /// </summary>
        public AzureWebappUpdateTask TtlInSeconds(string ttlInSeconds = null)
        {
            WithArguments("--ttl-in-seconds");
            if (!string.IsNullOrEmpty(ttlInSeconds))
            {
                 WithArguments(ttlInSeconds);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureWebappUpdateTask Add(string add = null)
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
        public AzureWebappUpdateTask ForceString(string forceString = null)
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
        public AzureWebappUpdateTask Remove(string remove = null)
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
        public AzureWebappUpdateTask Set(string set = null)
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
