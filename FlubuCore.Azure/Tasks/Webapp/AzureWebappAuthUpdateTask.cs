
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappAuthUpdateTask : ExternalProcessTaskBase<AzureWebappAuthUpdateTask>
     {
        
        /// <summary>
        /// Update the authentication settings for the webapp.
        /// </summary>
        public AzureWebappAuthUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp auth update");
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
        
        public AzureWebappAuthUpdateTask Action(string action = null)
        {
            WithArguments("--action");
            if (!string.IsNullOrEmpty(action))
            {
                 WithArguments(action);
            }

            return this;
        }

        /// <summary>
        /// One or more urls (space-delimited).
        /// </summary>
        public AzureWebappAuthUpdateTask AllowedExternalRedirectUrls(string allowedExternalRedirectUrls = null)
        {
            WithArguments("--allowed-external-redirect-urls");
            if (!string.IsNullOrEmpty(allowedExternalRedirectUrls))
            {
                 WithArguments(allowedExternalRedirectUrls);
            }

            return this;
        }

        public AzureWebappAuthUpdateTask Enabled(string enabled = null)
        {
            WithArguments("--enabled");
            if (!string.IsNullOrEmpty(enabled))
            {
                 WithArguments(enabled);
            }

            return this;
        }

        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappAuthUpdateTask Slot(string slot = null)
        {
            WithArguments("--slot");
            if (!string.IsNullOrEmpty(slot))
            {
                 WithArguments(slot);
            }

            return this;
        }

        /// <summary>
        /// Hours, must be formattable into a float.
        /// </summary>
        public AzureWebappAuthUpdateTask TokenRefreshExtensionHours(string tokenRefreshExtensionHours = null)
        {
            WithArguments("--token-refresh-extension-hours");
            if (!string.IsNullOrEmpty(tokenRefreshExtensionHours))
            {
                 WithArguments(tokenRefreshExtensionHours);
            }

            return this;
        }

        /// <summary>
        /// Use App Service Token Store.
        /// </summary>
        public AzureWebappAuthUpdateTask TokenStore(string tokenStore = null)
        {
            WithArguments("--token-store");
            if (!string.IsNullOrEmpty(tokenStore))
            {
                 WithArguments(tokenStore);
            }

            return this;
        }

        /// <summary>
        /// One or more token audiences (space-delimited).
        /// </summary>
        public AzureWebappAuthUpdateTask AadAllowedTokenAudiences(string aadAllowedTokenAudiences = null)
        {
            WithArguments("--aad-allowed-token-audiences");
            if (!string.IsNullOrEmpty(aadAllowedTokenAudiences))
            {
                 WithArguments(aadAllowedTokenAudiences);
            }

            return this;
        }

        /// <summary>
        /// Application ID to integrate AAD organization account Sign-in into your web app.
        /// </summary>
        public AzureWebappAuthUpdateTask AadClientId(string aadClientId = null)
        {
            WithArguments("--aad-client-id");
            if (!string.IsNullOrEmpty(aadClientId))
            {
                 WithArguments(aadClientId);
            }

            return this;
        }

        /// <summary>
        /// AAD application secret.
        /// </summary>
        public AzureWebappAuthUpdateTask AadClientSecret(string aadClientSecret = null)
        {
            WithArguments("--aad-client-secret");
            if (!string.IsNullOrEmpty(aadClientSecret))
            {
                 WithArguments(aadClientSecret);
            }

            return this;
        }

        /// <summary>
        /// This url can be found in the JSON output returned from your active directory endpoint using your tenantID. The endpoint can be queried from 'az cloud show' at "endpoints.activeDirectory". The tenantID can be found using 'az account show'. Get the "issuer" from the JSON at <active directory endpoint>/<tenantId>/.well-known/openid-configuration.
        /// </summary>
        public AzureWebappAuthUpdateTask AadTokenIssuerUrl(string aadTokenIssuerUrl = null)
        {
            WithArguments("--aad-token-issuer-url");
            if (!string.IsNullOrEmpty(aadTokenIssuerUrl))
            {
                 WithArguments(aadTokenIssuerUrl);
            }

            return this;
        }

        /// <summary>
        /// Application ID to integrate Facebook Sign-in into your web app.
        /// </summary>
        public AzureWebappAuthUpdateTask FacebookAppId(string facebookAppId = null)
        {
            WithArguments("--facebook-app-id");
            if (!string.IsNullOrEmpty(facebookAppId))
            {
                 WithArguments(facebookAppId);
            }

            return this;
        }

        /// <summary>
        /// Facebook Application client secret.
        /// </summary>
        public AzureWebappAuthUpdateTask FacebookAppSecret(string facebookAppSecret = null)
        {
            WithArguments("--facebook-app-secret");
            if (!string.IsNullOrEmpty(facebookAppSecret))
            {
                 WithArguments(facebookAppSecret);
            }

            return this;
        }

        /// <summary>
        /// One or more facebook authentication scopes (space-delimited).
        /// </summary>
        public AzureWebappAuthUpdateTask FacebookOauthScopes(string facebookOauthScopes = null)
        {
            WithArguments("--facebook-oauth-scopes");
            if (!string.IsNullOrEmpty(facebookOauthScopes))
            {
                 WithArguments(facebookOauthScopes);
            }

            return this;
        }

        /// <summary>
        /// Application ID to integrate Google Sign-in into your web app.
        /// </summary>
        public AzureWebappAuthUpdateTask GoogleClientId(string googleClientId = null)
        {
            WithArguments("--google-client-id");
            if (!string.IsNullOrEmpty(googleClientId))
            {
                 WithArguments(googleClientId);
            }

            return this;
        }

        /// <summary>
        /// Google Application client secret.
        /// </summary>
        public AzureWebappAuthUpdateTask GoogleClientSecret(string googleClientSecret = null)
        {
            WithArguments("--google-client-secret");
            if (!string.IsNullOrEmpty(googleClientSecret))
            {
                 WithArguments(googleClientSecret);
            }

            return this;
        }

        /// <summary>
        /// One or more Google authentication scopes (space-delimited).
        /// </summary>
        public AzureWebappAuthUpdateTask GoogleOauthScopes(string googleOauthScopes = null)
        {
            WithArguments("--google-oauth-scopes");
            if (!string.IsNullOrEmpty(googleOauthScopes))
            {
                 WithArguments(googleOauthScopes);
            }

            return this;
        }

        /// <summary>
        /// AAD V2 Application ID to integrate Microsoft account Sign-in into your web app.
        /// </summary>
        public AzureWebappAuthUpdateTask MicrosoftAccountClientId(string microsoftAccountClientId = null)
        {
            WithArguments("--microsoft-account-client-id");
            if (!string.IsNullOrEmpty(microsoftAccountClientId))
            {
                 WithArguments(microsoftAccountClientId);
            }

            return this;
        }

        /// <summary>
        /// AAD V2 Application client secret.
        /// </summary>
        public AzureWebappAuthUpdateTask MicrosoftAccountClientSecret(string microsoftAccountClientSecret = null)
        {
            WithArguments("--microsoft-account-client-secret");
            if (!string.IsNullOrEmpty(microsoftAccountClientSecret))
            {
                 WithArguments(microsoftAccountClientSecret);
            }

            return this;
        }

        /// <summary>
        /// One or more Microsoft authentification scopes (space-delimited).
        /// </summary>
        public AzureWebappAuthUpdateTask MicrosoftAccountOauthScopes(string microsoftAccountOauthScopes = null)
        {
            WithArguments("--microsoft-account-oauth-scopes");
            if (!string.IsNullOrEmpty(microsoftAccountOauthScopes))
            {
                 WithArguments(microsoftAccountOauthScopes);
            }

            return this;
        }

        /// <summary>
        /// Application ID to integrate Twitter Sign-in into your web app.
        /// </summary>
        public AzureWebappAuthUpdateTask TwitterConsumerKey(string twitterConsumerKey = null)
        {
            WithArguments("--twitter-consumer-key");
            if (!string.IsNullOrEmpty(twitterConsumerKey))
            {
                 WithArguments(twitterConsumerKey);
            }

            return this;
        }

        /// <summary>
        /// Twitter Application client secret.
        /// </summary>
        public AzureWebappAuthUpdateTask TwitterConsumerSecret(string twitterConsumerSecret = null)
        {
            WithArguments("--twitter-consumer-secret");
            if (!string.IsNullOrEmpty(twitterConsumerSecret))
            {
                 WithArguments(twitterConsumerSecret);
            }

            return this;
        }
     }
}
