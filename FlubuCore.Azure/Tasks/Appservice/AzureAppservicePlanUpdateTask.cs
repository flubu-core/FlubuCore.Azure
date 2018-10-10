
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Appservice
{
     public partial class AzureAppservicePlanUpdateTask : ExternalProcessTaskBase<AzureAppservicePlanUpdateTask>
     {
        
        /// <summary>
        /// Update an app service plan.
        /// </summary>
        public AzureAppservicePlanUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az appservice plan update");
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
        /// The name of the admin web app.
        /// </summary>
        public AzureAppservicePlanUpdateTask AdminSiteName(string adminSiteName = null)
        {
            WithArguments("--admin-site-name");
            if (!string.IsNullOrEmpty(adminSiteName))
            {
                 WithArguments(adminSiteName);
            }

            return this;
        }

        /// <summary>
        /// Number of workers to be allocated.
        /// </summary>
        public AzureAppservicePlanUpdateTask NumberOfWorkers(string numberOfWorkers = null)
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
        public AzureAppservicePlanUpdateTask Sku(string sku = null)
        {
            WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureAppservicePlanUpdateTask Add(string add = null)
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
        public AzureAppservicePlanUpdateTask ForceString(string forceString = null)
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
        public AzureAppservicePlanUpdateTask Remove(string remove = null)
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
        public AzureAppservicePlanUpdateTask Set(string set = null)
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
