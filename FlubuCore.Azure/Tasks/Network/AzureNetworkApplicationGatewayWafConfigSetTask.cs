
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayWafConfigSetTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayWafConfigSetTask>
     {
        
        /// <summary>
        /// Update the firewall configuration of a web application.
        /// </summary>
        public AzureNetworkApplicationGatewayWafConfigSetTask(string enabled = null ,  string gatewayName = null ,  string resourceGroup = null)
        {
            WithArguments("az network application-gateway waf-config set");
WithArguments("--enabled");
            if (!string.IsNullOrEmpty(enabled))
            {
                 WithArguments(enabled);
            }

WithArguments("--gateway-name");
            if (!string.IsNullOrEmpty(gatewayName))
            {
                 WithArguments(gatewayName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Space-separated list of rule groups to disable. To disable individual rules, use `--disabled-rules`.
        /// </summary>
        public AzureNetworkApplicationGatewayWafConfigSetTask DisabledRuleGroups(string disabledRuleGroups = null)
        {
            WithArguments("--disabled-rule-groups");
            if (!string.IsNullOrEmpty(disabledRuleGroups))
            {
                 WithArguments(disabledRuleGroups);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of rule IDs to disable.
        /// </summary>
        public AzureNetworkApplicationGatewayWafConfigSetTask DisabledRules(string disabledRules = null)
        {
            WithArguments("--disabled-rules");
            if (!string.IsNullOrEmpty(disabledRules))
            {
                 WithArguments(disabledRules);
            }

            return this;
        }

        /// <summary>
        /// Web application firewall mode.
        /// </summary>
        public AzureNetworkApplicationGatewayWafConfigSetTask FirewallMode(string firewallMode = null)
        {
            WithArguments("--firewall-mode");
            if (!string.IsNullOrEmpty(firewallMode))
            {
                 WithArguments(firewallMode);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkApplicationGatewayWafConfigSetTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Rule set type.
        /// </summary>
        public AzureNetworkApplicationGatewayWafConfigSetTask RuleSetType(string ruleSetType = null)
        {
            WithArguments("--rule-set-type");
            if (!string.IsNullOrEmpty(ruleSetType))
            {
                 WithArguments(ruleSetType);
            }

            return this;
        }

        /// <summary>
        /// Rule set version.
        /// </summary>
        public AzureNetworkApplicationGatewayWafConfigSetTask RuleSetVersion(string ruleSetVersion = null)
        {
            WithArguments("--rule-set-version");
            if (!string.IsNullOrEmpty(ruleSetVersion))
            {
                 WithArguments(ruleSetVersion);
            }

            return this;
        }
     }
}
