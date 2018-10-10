
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotAuthsettingCreateTask : ExternalProcessTaskBase<AzureBotAuthsettingCreateTask>
     {
        
        /// <summary>
        /// Create an OAuth connection setting on a bot.
        /// </summary>
        public AzureBotAuthsettingCreateTask(string clientId = null ,  string clientSecret = null ,  string name = null ,  string providerScopeString = null ,  string resourceGroup = null ,  string service = null ,  string settingName = null)
        {
            WithArguments("az bot authsetting create");
WithArguments("--client-id");
            if (!string.IsNullOrEmpty(clientId))
            {
                 WithArguments(clientId);
            }

WithArguments("--client-secret");
            if (!string.IsNullOrEmpty(clientSecret))
            {
                 WithArguments(clientSecret);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--provider-scope-string");
            if (!string.IsNullOrEmpty(providerScopeString))
            {
                 WithArguments(providerScopeString);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--service");
            if (!string.IsNullOrEmpty(service))
            {
                 WithArguments(service);
            }

WithArguments("--setting-name");
            if (!string.IsNullOrEmpty(settingName))
            {
                 WithArguments(settingName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Parameter values for service provider parameters. Usage: --parameters key=value key1=value1.
        /// </summary>
        public AzureBotAuthsettingCreateTask Parameters(string parameters = null)
        {
            WithArguments("--parameters");
            if (!string.IsNullOrEmpty(parameters))
            {
                 WithArguments(parameters);
            }

            return this;
        }
     }
}
