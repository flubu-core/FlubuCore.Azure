
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Disk
{
     public partial class AzureDiskWaitTask : ExternalProcessTaskBase<AzureDiskWaitTask>
     {
        
        /// <summary>
        /// Place the CLI in a waiting state until a condition of a managed disk is met.
        /// </summary>
        public AzureDiskWaitTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az disk wait");
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
        public AzureDiskWaitTask Created(string created = null)
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
        public AzureDiskWaitTask Custom(string custom = null)
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
        public AzureDiskWaitTask Deleted(string deleted = null)
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
        public AzureDiskWaitTask Exists(string exists = null)
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
        public AzureDiskWaitTask Interval(string interval = null)
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
        public AzureDiskWaitTask Timeout(string timeout = null)
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
        public AzureDiskWaitTask Updated(string updated = null)
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
