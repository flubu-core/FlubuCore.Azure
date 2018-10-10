
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Policy
{
     public partial class AzurePolicyStateSummarizeTask : ExternalProcessTaskBase<AzurePolicyStateSummarizeTask>
     {
        
        /// <summary>
        /// Summarize policy compliance states.
        /// </summary>
        public AzurePolicyStateSummarizeTask()
        {
            WithArguments("az policy state summarize");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Filter expression using OData notation.
        /// </summary>
        public AzurePolicyStateSummarizeTask Filter(string filter = null)
        {
            WithArguments("--filter");
            if (!string.IsNullOrEmpty(filter))
            {
                 WithArguments(filter);
            }

            return this;
        }

        /// <summary>
        /// ISO 8601 formatted timestamp specifying the start time of the interval to query.
        /// </summary>
        public AzurePolicyStateSummarizeTask From(string from = null)
        {
            WithArguments("--from");
            if (!string.IsNullOrEmpty(from))
            {
                 WithArguments(from);
            }

            return this;
        }

        /// <summary>
        /// ISO 8601 formatted timestamp specifying the end time of the interval to query.
        /// </summary>
        public AzurePolicyStateSummarizeTask To(string to = null)
        {
            WithArguments("--to");
            if (!string.IsNullOrEmpty(to))
            {
                 WithArguments(to);
            }

            return this;
        }

        /// <summary>
        /// Maximum number of records to return.
        /// </summary>
        public AzurePolicyStateSummarizeTask Top(string top = null)
        {
            WithArguments("--top");
            if (!string.IsNullOrEmpty(top))
            {
                 WithArguments(top);
            }

            return this;
        }

        /// <summary>
        /// Provider namespace (Ex: Microsoft.Provider).
        /// </summary>
        public AzurePolicyStateSummarizeTask Namespace(string @namespace = null)
        {
            WithArguments("--namespace");
            if (!string.IsNullOrEmpty(@namespace))
            {
                 WithArguments(@namespace);
            }

            return this;
        }

        /// <summary>
        /// The parent path (Ex: resA/myA/resB/myB).
        /// </summary>
        public AzurePolicyStateSummarizeTask Parent(string parent = null)
        {
            WithArguments("--parent");
            if (!string.IsNullOrEmpty(parent))
            {
                 WithArguments(parent);
            }

            return this;
        }

        /// <summary>
        /// Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.
        /// </summary>
        public AzurePolicyStateSummarizeTask Resource(string resource = null)
        {
            WithArguments("--resource");
            if (!string.IsNullOrEmpty(resource))
            {
                 WithArguments(resource);
            }

            return this;
        }

        /// <summary>
        /// Resource type (Ex: resC).
        /// </summary>
        public AzurePolicyStateSummarizeTask ResourceType(string resourceType = null)
        {
            WithArguments("--resource-type");
            if (!string.IsNullOrEmpty(resourceType))
            {
                 WithArguments(resourceType);
            }

            return this;
        }

        /// <summary>
        /// Name of management group.
        /// </summary>
        public AzurePolicyStateSummarizeTask ManagementGroup(string managementGroup = null)
        {
            WithArguments("--management-group");
            if (!string.IsNullOrEmpty(managementGroup))
            {
                 WithArguments(managementGroup);
            }

            return this;
        }

        /// <summary>
        /// Name of policy assignment.
        /// </summary>
        public AzurePolicyStateSummarizeTask PolicyAssignment(string policyAssignment = null)
        {
            WithArguments("--policy-assignment");
            if (!string.IsNullOrEmpty(policyAssignment))
            {
                 WithArguments(policyAssignment);
            }

            return this;
        }

        /// <summary>
        /// Name of policy definition.
        /// </summary>
        public AzurePolicyStateSummarizeTask PolicyDefinition(string policyDefinition = null)
        {
            WithArguments("--policy-definition");
            if (!string.IsNullOrEmpty(policyDefinition))
            {
                 WithArguments(policyDefinition);
            }

            return this;
        }

        /// <summary>
        /// Name of policy set definition.
        /// </summary>
        public AzurePolicyStateSummarizeTask PolicySetDefinition(string policySetDefinition = null)
        {
            WithArguments("--policy-set-definition");
            if (!string.IsNullOrEmpty(policySetDefinition))
            {
                 WithArguments(policySetDefinition);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzurePolicyStateSummarizeTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }
     }
}
