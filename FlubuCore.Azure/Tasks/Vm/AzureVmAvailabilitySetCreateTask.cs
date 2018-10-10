
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmAvailabilitySetCreateTask : ExternalProcessTaskBase<AzureVmAvailabilitySetCreateTask>
     {
        
        /// <summary>
        /// Create an Azure Availability Set.
        /// </summary>
        public AzureVmAvailabilitySetCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vm availability-set create");
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
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureVmAvailabilitySetCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureVmAvailabilitySetCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Fault Domain count.
        /// </summary>
        public AzureVmAvailabilitySetCreateTask PlatformFaultDomainCount(string platformFaultDomainCount = null)
        {
            WithArguments("--platform-fault-domain-count");
            if (!string.IsNullOrEmpty(platformFaultDomainCount))
            {
                 WithArguments(platformFaultDomainCount);
            }

            return this;
        }

        /// <summary>
        /// Update Domain count. If unspecified, server picks the most optimal number like 5. For the latest defaults see <a href="https://docs.microsoft.com/en-us/rest/api/compute/availabilitysets/availabilitysets-create">https://docs.microsoft.com/en-us/rest/api/compute/availabilitysets/availabilitysets-create</a>.
        /// </summary>
        public AzureVmAvailabilitySetCreateTask PlatformUpdateDomainCount(string platformUpdateDomainCount = null)
        {
            WithArguments("--platform-update-domain-count");
            if (!string.IsNullOrEmpty(platformUpdateDomainCount))
            {
                 WithArguments(platformUpdateDomainCount);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureVmAvailabilitySetCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Contained VMs should use unmanaged disks.
        /// </summary>
        public AzureVmAvailabilitySetCreateTask Unmanaged(string unmanaged = null)
        {
            WithArguments("--unmanaged");
            if (!string.IsNullOrEmpty(unmanaged))
            {
                 WithArguments(unmanaged);
            }

            return this;
        }

        /// <summary>
        /// Generate and validate the ARM template without creating any resources.
        /// </summary>
        public AzureVmAvailabilitySetCreateTask Validate(string validate = null)
        {
            WithArguments("--validate");
            if (!string.IsNullOrEmpty(validate))
            {
                 WithArguments(validate);
            }

            return this;
        }
     }
}
