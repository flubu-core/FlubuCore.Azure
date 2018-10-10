
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdAppCreateTask : ExternalProcessTaskBase<AzureAdAppCreateTask>
     {
        
        /// <summary>
        /// Create a web application, web API or native application.
        /// </summary>
        public AzureAdAppCreateTask(string displayName = null)
        {
            WithArguments("az ad app create");
WithArguments("--display-name");
            if (!string.IsNullOrEmpty(displayName))
            {
                 WithArguments(displayName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The application can be used from any Azure AD tenants.
        /// </summary>
        public AzureAdAppCreateTask AvailableToOtherTenants(string availableToOtherTenants = null)
        {
            WithArguments("--available-to-other-tenants");
            if (!string.IsNullOrEmpty(availableToOtherTenants))
            {
                 WithArguments(availableToOtherTenants);
            }

            return this;
        }

        /// <summary>
        /// Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.
        /// </summary>
        public AzureAdAppCreateTask EndDate(string endDate = null)
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
        public AzureAdAppCreateTask Homepage(string homepage = null)
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
        public AzureAdAppCreateTask IdentifierUris(string identifierUris = null)
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
        public AzureAdAppCreateTask KeyType(string keyType = null)
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
        public AzureAdAppCreateTask KeyUsage(string keyUsage = null)
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
        public AzureAdAppCreateTask KeyValue(string keyValue = null)
        {
            WithArguments("--key-value");
            if (!string.IsNullOrEmpty(keyValue))
            {
                 WithArguments(keyValue);
            }

            return this;
        }

        /// <summary>
        /// An application which can be installed on a user's device or computer.
        /// </summary>
        public AzureAdAppCreateTask NativeApp(string nativeApp = null)
        {
            WithArguments("--native-app");
            if (!string.IsNullOrEmpty(nativeApp))
            {
                 WithArguments(nativeApp);
            }

            return this;
        }

        /// <summary>
        /// Whether to allow implicit grant flow for OAuth2.
        /// </summary>
        public AzureAdAppCreateTask Oauth2AllowImplicitFlow(string oauth2AllowImplicitFlow = null)
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
        public AzureAdAppCreateTask Password(string password = null)
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
        public AzureAdAppCreateTask ReplyUrls(string replyUrls = null)
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
        public AzureAdAppCreateTask RequiredResourceAccesses(string requiredResourceAccesses = null)
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
        public AzureAdAppCreateTask StartDate(string startDate = null)
        {
            WithArguments("--start-date");
            if (!string.IsNullOrEmpty(startDate))
            {
                 WithArguments(startDate);
            }

            return this;
        }
     }
}
