
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFrontDoorLoadBalancingCreateTask : ExternalProcessTaskBase<AzureNetworkFrontDoorLoadBalancingCreateTask>
     {
        
        /// <summary>
        /// Create FrontDoor load-balancing settings.
        /// </summary>
        public AzureNetworkFrontDoorLoadBalancingCreateTask(string frontDoorName = null ,  string name = null ,  string resourceGroup = null ,  string sampleSize = null ,  string successfulSamplesRequired = null)
        {
            WithArguments("az network front-door load-balancing create");
WithArguments("--front-door-name");
            if (!string.IsNullOrEmpty(frontDoorName))
            {
                 WithArguments(frontDoorName);
            }

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

WithArguments("--sample-size");
            if (!string.IsNullOrEmpty(sampleSize))
            {
                 WithArguments(sampleSize);
            }

WithArguments("--successful-samples-required");
            if (!string.IsNullOrEmpty(successfulSamplesRequired))
            {
                 WithArguments(successfulSamplesRequired);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The additional latency in milliseconds for probes to fall in the lowest latency bucket.
        /// </summary>
        public AzureNetworkFrontDoorLoadBalancingCreateTask AdditionalLatency(string additionalLatency = null)
        {
            WithArguments("--additional-latency");
            if (!string.IsNullOrEmpty(additionalLatency))
            {
                 WithArguments(additionalLatency);
            }

            return this;
        }
     }
}
