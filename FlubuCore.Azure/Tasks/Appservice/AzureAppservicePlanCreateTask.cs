
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Appservice
{
     public partial class AzureAppservicePlanCreateTask : ExternalProcessTaskBase<AzureAppservicePlanCreateTask>
     {
        
        /// <summary>
        /// Create an app service plan.
        /// </summary>
        public AzureAppservicePlanCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az appservice plan create");
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
        /// Host webapp on Linux worker.
        /// </summary>
        public AzureAppservicePlanCreateTask IsLinux(string isLinux = null)
        {
            WithArguments("--is-linux");
            if (!string.IsNullOrEmpty(isLinux))
            {
                 WithArguments(isLinux);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureAppservicePlanCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Number of workers to be allocated.
        /// </summary>
        public AzureAppservicePlanCreateTask NumberOfWorkers(string numberOfWorkers = null)
        {
            WithArguments("--number-of-workers");
            if (!string.IsNullOrEmpty(numberOfWorkers))
            {
                 WithArguments(numberOfWorkers);
            }

            return this;
        }

        /// <summary>
        /// The pricing tiers, e.g., F1(Free), D1(Shared), B1(Basic Small), B2(Basic Medium), B3(Basic Large), S1(Standard Small), P1(Premium Small), P1V2(Premium V2 Small) etc.
        /// </summary>
        public AzureAppservicePlanCreateTask Sku(string sku = null)
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
        public AzureAppservicePlanCreateTask Tags(string tags = null)
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
