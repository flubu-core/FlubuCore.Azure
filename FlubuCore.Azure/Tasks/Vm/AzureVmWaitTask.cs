
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmWaitTask : ExternalProcessTaskBase<AzureVmWaitTask>
     {
        
        /// <summary>
        /// Place the CLI in a waiting state until a condition of the VM is met.
        /// </summary>
        public AzureVmWaitTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vm wait");
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
        /// Wait until created with 'provisioningState' at 'Succeeded'.
        /// </summary>
        public AzureVmWaitTask Created(string created = null)
        {
            WithArguments("--created");
            if (!string.IsNullOrEmpty(created))
            {
                 WithArguments(created);
            }

            return this;
        }

        /// <summary>
        /// Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].
        /// </summary>
        public AzureVmWaitTask Custom(string custom = null)
        {
            WithArguments("--custom");
            if (!string.IsNullOrEmpty(custom))
            {
                 WithArguments(custom);
            }

            return this;
        }

        /// <summary>
        /// Wait until deleted.
        /// </summary>
        public AzureVmWaitTask Deleted(string deleted = null)
        {
            WithArguments("--deleted");
            if (!string.IsNullOrEmpty(deleted))
            {
                 WithArguments(deleted);
            }

            return this;
        }

        /// <summary>
        /// Wait until the resource exists.
        /// </summary>
        public AzureVmWaitTask Exists(string exists = null)
        {
            WithArguments("--exists");
            if (!string.IsNullOrEmpty(exists))
            {
                 WithArguments(exists);
            }

            return this;
        }

        /// <summary>
        /// Polling interval in seconds.
        /// </summary>
        public AzureVmWaitTask Interval(string interval = null)
        {
            WithArguments("--interval");
            if (!string.IsNullOrEmpty(interval))
            {
                 WithArguments(interval);
            }

            return this;
        }

        /// <summary>
        /// Maximum wait in seconds.
        /// </summary>
        public AzureVmWaitTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }

        /// <summary>
        /// Wait until updated with provisioningState at 'Succeeded'.
        /// </summary>
        public AzureVmWaitTask Updated(string updated = null)
        {
            WithArguments("--updated");
            if (!string.IsNullOrEmpty(updated))
            {
                 WithArguments(updated);
            }

            return this;
        }
     }
}
