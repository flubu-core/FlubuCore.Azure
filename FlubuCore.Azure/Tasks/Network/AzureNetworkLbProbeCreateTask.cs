
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLbProbeCreateTask : ExternalProcessTaskBase<AzureNetworkLbProbeCreateTask>
     {
        
        /// <summary>
        /// Create a probe.
        /// </summary>
        public AzureNetworkLbProbeCreateTask(string lbName = null ,  string name = null ,  string port = null ,  string protocol = null ,  string resourceGroup = null)
        {
            WithArguments("az network lb probe create");
WithArguments("--lb-name");
            if (!string.IsNullOrEmpty(lbName))
            {
                 WithArguments(lbName);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--port");
            if (!string.IsNullOrEmpty(port))
            {
                 WithArguments(port);
            }

WithArguments("--protocol");
            if (!string.IsNullOrEmpty(protocol))
            {
                 WithArguments(protocol);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Probing time interval in seconds.
        /// </summary>
        public AzureNetworkLbProbeCreateTask Interval(string interval = null)
        {
            WithArguments("--interval");
            if (!string.IsNullOrEmpty(interval))
            {
                 WithArguments(interval);
            }

            return this;
        }

        /// <summary>
        /// The endpoint to interrogate (http only).
        /// </summary>
        public AzureNetworkLbProbeCreateTask Path(string path = null)
        {
            WithArguments("--path");
            if (!string.IsNullOrEmpty(path))
            {
                 WithArguments(path);
            }

            return this;
        }

        /// <summary>
        /// The number of consecutive probe failures before an instance is deemed unhealthy.
        /// </summary>
        public AzureNetworkLbProbeCreateTask Threshold(string threshold = null)
        {
            WithArguments("--threshold");
            if (!string.IsNullOrEmpty(threshold))
            {
                 WithArguments(threshold);
            }

            return this;
        }
     }
}
