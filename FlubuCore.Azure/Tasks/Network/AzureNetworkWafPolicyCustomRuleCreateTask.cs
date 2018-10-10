
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWafPolicyCustomRuleCreateTask : ExternalProcessTaskBase<AzureNetworkWafPolicyCustomRuleCreateTask>
     {
        
        /// <summary>
        /// Create a WAF policy custom rule.
        /// </summary>
        public AzureNetworkWafPolicyCustomRuleCreateTask(string action = null ,  string matchCondition = null ,  string name = null ,  string policyName = null ,  string priority = null ,  string resourceGroup = null ,  string ruleType = null)
        {
            WithArguments("az network waf-policy custom-rule create");
WithArguments("--action");
            if (!string.IsNullOrEmpty(action))
            {
                 WithArguments(action);
            }

WithArguments("--match-condition");
            if (!string.IsNullOrEmpty(matchCondition))
            {
                 WithArguments(matchCondition);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--policy-name");
            if (!string.IsNullOrEmpty(policyName))
            {
                 WithArguments(policyName);
            }

WithArguments("--priority");
            if (!string.IsNullOrEmpty(priority))
            {
                 WithArguments(priority);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--rule-type");
            if (!string.IsNullOrEmpty(ruleType))
            {
                 WithArguments(ruleType);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Rate limit duration in minutes.
        /// </summary>
        public AzureNetworkWafPolicyCustomRuleCreateTask RateLimitDuration(string rateLimitDuration = null)
        {
            WithArguments("--rate-limit-duration");
            if (!string.IsNullOrEmpty(rateLimitDuration))
            {
                 WithArguments(rateLimitDuration);
            }

            return this;
        }

        /// <summary>
        /// Rate limit threshold.
        /// </summary>
        public AzureNetworkWafPolicyCustomRuleCreateTask RateLimitThreshold(string rateLimitThreshold = null)
        {
            WithArguments("--rate-limit-threshold");
            if (!string.IsNullOrEmpty(rateLimitThreshold))
            {
                 WithArguments(rateLimitThreshold);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of transforms to apply.
        /// </summary>
        public AzureNetworkWafPolicyCustomRuleCreateTask Transforms(string transforms = null)
        {
            WithArguments("--transforms");
            if (!string.IsNullOrEmpty(transforms))
            {
                 WithArguments(transforms);
            }

            return this;
        }
     }
}
