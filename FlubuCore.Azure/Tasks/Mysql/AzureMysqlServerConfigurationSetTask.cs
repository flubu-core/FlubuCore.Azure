
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mysql
{
     public partial class AzureMysqlServerConfigurationSetTask : ExternalProcessTaskBase<AzureMysqlServerConfigurationSetTask>
     {
        
        /// <summary>
        /// Update the configuration of a server.
        /// </summary>
        public AzureMysqlServerConfigurationSetTask(string name = null ,  string resourceGroup = null ,  string serverName = null)
        {
            WithArguments("az mysql server configuration set");
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

WithArguments("--server-name");
            if (!string.IsNullOrEmpty(serverName))
            {
                 WithArguments(serverName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Value of the configuration. If not provided, configuration value will be set to default.
        /// </summary>
        public AzureMysqlServerConfigurationSetTask Value(string value = null)
        {
            WithArguments("--value");
            if (!string.IsNullOrEmpty(value))
            {
                 WithArguments(value);
            }

            return this;
        }
     }
}
