
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWafPolicySetManagedRulesetTask : ExternalProcessTaskBase<AzureNetworkWafPolicySetManagedRulesetTask>
     {
        
        /// <summary>
        /// Configure Azure-managed ruleset.
        /// </summary>
        public AzureNetworkWafPolicySetManagedRulesetTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network waf-policy set-managed-ruleset");
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
        /// Action for overriden rulesets.
        /// </summary>
        public AzureNetworkWafPolicySetManagedRulesetTask Action(string action = null)
        {
            WithArguments("--action");
            if (!string.IsNullOrEmpty(action))
            {
                 WithArguments(action);
            }

            return this;
        }

        /// <summary>
        /// Disable managed ruleset override.
        /// </summary>
        public AzureNetworkWafPolicySetManagedRulesetTask Disable(string disable = null)
        {
            WithArguments("--disable");
            if (!string.IsNullOrEmpty(disable))
            {
                 WithArguments(disable);
            }

            return this;
        }

        /// <summary>
        /// Name of the ruleset to override.
        /// </summary>
        public AzureNetworkWafPolicySetManagedRulesetTask Override(string @override = null)
        {
            WithArguments("--override");
            if (!string.IsNullOrEmpty(@override))
            {
                 WithArguments(@override);
            }

            return this;
        }

        /// <summary>
        /// Rule priority.
        /// </summary>
        public AzureNetworkWafPolicySetManagedRulesetTask Priority(string priority = null)
        {
            WithArguments("--priority");
            if (!string.IsNullOrEmpty(priority))
            {
                 WithArguments(priority);
            }

            return this;
        }

        /// <summary>
        /// Rule set version.
        /// </summary>
        public AzureNetworkWafPolicySetManagedRulesetTask Version(string version = null)
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
