
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mysql
{
     public partial class AzureMysqlServerWaitTask : ExternalProcessTaskBase<AzureMysqlServerWaitTask>
     {
        
        /// <summary>
        /// Wait for server to satisfy certain conditions.
        /// </summary>
        public AzureMysqlServerWaitTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az mysql server wait");
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
        /// Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].
        /// </summary>
        public AzureMysqlServerWaitTask Custom(string custom = null)
        {
            WithArguments("--custom");
            if (!string.IsNullOrEmpty(custom))
            {
                 WithArguments(custom);
            }

            return this;
        }

        /// <summary>
        /// Wait until the resource exists.
        /// </summary>
        public AzureMysqlServerWaitTask Exists(string exists = null)
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
        public AzureMysqlServerWaitTask Interval(string interval = null)
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
        public AzureMysqlServerWaitTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }
     }
}
