
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdAppUpdateTask : ExternalProcessTaskBase<AzureAdAppUpdateTask>
     {
        
        /// <summary>
        /// Update an application.
        /// </summary>
        public AzureAdAppUpdateTask(string id = null)
        {
            WithArguments("az ad app update");
WithArguments("--id");
            if (!string.IsNullOrEmpty(id))
            {
                 WithArguments(id);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The application can be used from any Azure AD tenants.
        /// </summary>
        public AzureAdAppUpdateTask AvailableToOtherTenants(string availableToOtherTenants = null)
        {
            WithArguments("--available-to-other-tenants");
            if (!string.IsNullOrEmpty(availableToOtherTenants))
            {
                 WithArguments(availableToOtherTenants);
            }

            return this;
        }

        /// <summary>
        /// The display name of the application.
        /// </summary>
        public AzureAdAppUpdateTask DisplayName(string displayName = null)
        {
            WithArguments("--display-name");
            if (!string.IsNullOrEmpty(displayName))
            {
                 WithArguments(displayName);
            }

            return this;
        }

        /// <summary>
        /// Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.
        /// </summary>
        public AzureAdAppUpdateTask EndDate(string endDate = null)
        {
            WithArguments("--end-date");
            if (!string.IsNullOrEmpty(endDate))
            {
                 WithArguments(endDate);
            }

            return this;
        }

        /// <summary>
        /// The url where users can sign in and use your app.
        /// </summary>
        public AzureAdAppUpdateTask Homepage(string homepage = null)
        {
            WithArguments("--homepage");
            if (!string.IsNullOrEmpty(homepage))
            {
                 WithArguments(homepage);
            }

            return this;
        }

        /// <summary>
        /// Space-separated unique URIs that Azure AD can use for this app.
        /// </summary>
        public AzureAdAppUpdateTask IdentifierUris(string identifierUris = null)
        {
            WithArguments("--identifier-uris");
            if (!string.IsNullOrEmpty(identifierUris))
            {
                 WithArguments(identifierUris);
            }

            return this;
        }

        /// <summary>
        /// The type of the key credentials associated with the application.
        /// </summary>
        public AzureAdAppUpdateTask KeyType(string keyType = null)
        {
            WithArguments("--key-type");
            if (!string.IsNullOrEmpty(keyType))
            {
                 WithArguments(keyType);
            }

            return this;
        }

        /// <summary>
        /// The usage of the key credentials associated with the application.
        /// </summary>
        public AzureAdAppUpdateTask KeyUsage(string keyUsage = null)
        {
            WithArguments("--key-usage");
            if (!string.IsNullOrEmpty(keyUsage))
            {
                 WithArguments(keyUsage);
            }

            return this;
        }

        /// <summary>
        /// The value for the key credentials associated with the application.
        /// </summary>
        public AzureAdAppUpdateTask KeyValue(string keyValue = null)
        {
            WithArguments("--key-value");
            if (!string.IsNullOrEmpty(keyValue))
            {
                 WithArguments(keyValue);
            }

            return this;
        }

        /// <summary>
        /// Whether to allow implicit grant flow for OAuth2.
        /// </summary>
        public AzureAdAppUpdateTask Oauth2AllowImplicitFlow(string oauth2AllowImplicitFlow = null)
        {
            WithArguments("--oauth2-allow-implicit-flow");
            if (!string.IsNullOrEmpty(oauth2AllowImplicitFlow))
            {
                 WithArguments(oauth2AllowImplicitFlow);
            }

            return this;
        }

        /// <summary>
        /// App password, aka 'client secret'.
        /// </summary>
        public AzureAdAppUpdateTask Password(string password = null)
        {
            WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
            }

            return this;
        }

        /// <summary>
        /// Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.
        /// </summary>
        public AzureAdAppUpdateTask ReplyUrls(string replyUrls = null)
        {
            WithArguments("--reply-urls");
            if (!string.IsNullOrEmpty(replyUrls))
            {
                 WithArguments(replyUrls);
            }

            return this;
        }

        /// <summary>
        /// Resource scopes and roles the application requires access to. Should be in manifest json format. See examples below for details.
        /// </summary>
        public AzureAdAppUpdateTask RequiredResourceAccesses(string requiredResourceAccesses = null)
        {
            WithArguments("--required-resource-accesses");
            if (!string.IsNullOrEmpty(requiredResourceAccesses))
            {
                 WithArguments(requiredResourceAccesses);
            }

            return this;
        }

        /// <summary>
        /// Date or datetime at which credentials become valid(e.g. '2017-01-01T01:00:00+00:00' or '2017-01-01'). Default value is current time.
        /// </summary>
        public AzureAdAppUpdateTask StartDate(string startDate = null)
        {
            WithArguments("--start-date");
            if (!string.IsNullOrEmpty(startDate))
            {
                 WithArguments(startDate);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureAdAppUpdateTask Add(string add = null)
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
        public AzureAdAppUpdateTask ForceString(string forceString = null)
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
        public AzureAdAppUpdateTask Remove(string remove = null)
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
        public AzureAdAppUpdateTask Set(string set = null)
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
