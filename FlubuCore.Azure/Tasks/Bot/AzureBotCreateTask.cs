
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Bot
{
     public partial class AzureBotCreateTask : ExternalProcessTaskBase<AzureBotCreateTask>
     {
        
        /// <summary>
        /// Create a new bot.
        /// </summary>
        public AzureBotCreateTask(string kind = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az bot create");
WithArguments("--kind");
            if (!string.IsNullOrEmpty(kind))
            {
                 WithArguments(kind);
            }

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
        /// The Microsoft account ID (MSA ID) to be used with the bot.
        /// </summary>
        public AzureBotCreateTask Appid(string appid = null)
        {
            WithArguments("--appid");
            if (!string.IsNullOrEmpty(appid))
            {
                 WithArguments(appid);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureBotCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// The Microsoft account (MSA) password for the bot.
        /// </summary>
        public AzureBotCreateTask Password(string password = null)
        {
            WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureBotCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// The description of the bot.
        /// </summary>
        //public AzureBotCreateTask Description(string description = null)
        //{
        //    WithArguments("--description");
        //    if (!string.IsNullOrEmpty(description))
        //    {
        //         WithArguments(description);
        //    }

        //    return this;
        //}

        /// <summary>
        /// The display name of the bot. If not specified, defaults to the name of the bot.
        /// </summary>
        public AzureBotCreateTask DisplayName(string displayName = null)
        {
            WithArguments("--display-name");
            if (!string.IsNullOrEmpty(displayName))
            {
                 WithArguments(displayName);
            }

            return this;
        }

        /// <summary>
        /// The messaging endpoint of the bot.
        /// </summary>
        public AzureBotCreateTask Endpoint(string endpoint = null)
        {
            WithArguments("--endpoint");
            if (!string.IsNullOrEmpty(endpoint))
            {
                 WithArguments(endpoint);
            }

            return this;
        }

        /// <summary>
        /// The Sku of the bot.
        /// </summary>
        public AzureBotCreateTask Sku(string sku = null)
        {
            WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

            return this;
        }

        /// <summary>
        /// The location for the app insights to be used with the bot.
        /// </summary>
        public AzureBotCreateTask InsightsLocation(string insightsLocation = null)
        {
            WithArguments("--insights-location");
            if (!string.IsNullOrEmpty(insightsLocation))
            {
                 WithArguments(insightsLocation);
            }

            return this;
        }

        /// <summary>
        /// The language to be used to create the bot.
        /// </summary>
        public AzureBotCreateTask Lang(string lang = null)
        {
            WithArguments("--lang");
            if (!string.IsNullOrEmpty(lang))
            {
                 WithArguments(lang);
            }

            return this;
        }

        /// <summary>
        /// Storage account name to be used with the bot. If not provided, a new account will be created.
        /// </summary>
        public AzureBotCreateTask Storage(string storage = null)
        {
            WithArguments("--storage");
            if (!string.IsNullOrEmpty(storage))
            {
                 WithArguments(storage);
            }

            return this;
        }

        /// <summary>
        /// The Microsoft Bot Builder SDK version to be used to create the bot.
        /// </summary>
        public AzureBotCreateTask Version(string version = null)
        {
            WithArguments("--version");
            if (!string.IsNullOrEmpty(version))
            {
                 WithArguments(version);
            }

            return this;
        }
     }
}
