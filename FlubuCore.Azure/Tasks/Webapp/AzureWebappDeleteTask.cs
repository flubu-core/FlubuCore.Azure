
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappDeleteTask : ExternalProcessTaskBase<AzureWebappDeleteTask>
     {
        
        /// <summary>
        /// Delete a web app.
        /// </summary>
        public AzureWebappDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp delete");
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
        /// Keep DNS registration.
        /// </summary>
        public AzureWebappDeleteTask KeepDnsRegistration(string keepDnsRegistration = null)
        {
            WithArguments("--keep-dns-registration");
            if (!string.IsNullOrEmpty(keepDnsRegistration))
            {
                 WithArguments(keepDnsRegistration);
            }

            return this;
        }

        /// <summary>
        /// Keep empty app service plan.
        /// </summary>
        public AzureWebappDeleteTask KeepEmptyPlan(string keepEmptyPlan = null)
        {
            WithArguments("--keep-empty-plan");
            if (!string.IsNullOrEmpty(keepEmptyPlan))
            {
                 WithArguments(keepEmptyPlan);
            }

            return this;
        }

        /// <summary>
        /// Keep app metrics.
        /// </summary>
        public AzureWebappDeleteTask KeepMetrics(string keepMetrics = null)
        {
            WithArguments("--keep-metrics");
            if (!string.IsNullOrEmpty(keepMetrics))
            {
                 WithArguments(keepMetrics);
            }

            return this;
        }

        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappDeleteTask Slot(string slot = null)
        {
            WithArguments("--slot");
            if (!string.IsNullOrEmpty(slot))
            {
                 WithArguments(slot);
            }

            return this;
        }
     }
}
