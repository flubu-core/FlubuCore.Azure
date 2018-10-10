
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmImageAcceptTermsTask : ExternalProcessTaskBase<AzureVmImageAcceptTermsTask>
     {
        
        /// <summary>
        /// Accept Azure Marketplace term so that the image can be used to create VMs.
        /// </summary>
        public AzureVmImageAcceptTermsTask()
        {
            WithArguments("az vm image accept-terms");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Image offer.
        /// </summary>
        public AzureVmImageAcceptTermsTask Offer(string offer = null)
        {
            WithArguments("--offer");
            if (!string.IsNullOrEmpty(offer))
            {
                 WithArguments(offer);
            }

            return this;
        }

        /// <summary>
        /// Image billing plan.
        /// </summary>
        public AzureVmImageAcceptTermsTask Plan(string plan = null)
        {
            WithArguments("--plan");
            if (!string.IsNullOrEmpty(plan))
            {
                 WithArguments(plan);
            }

            return this;
        }

        /// <summary>
        /// Image publisher.
        /// </summary>
        public AzureVmImageAcceptTermsTask Publisher(string publisher = null)
        {
            WithArguments("--publisher");
            if (!string.IsNullOrEmpty(publisher))
            {
                 WithArguments(publisher);
            }

            return this;
        }

        /// <summary>
        /// URN, in format of 'publisher:offer:sku:version'. If specified, other argument values can be omitted.
        /// </summary>
        public AzureVmImageAcceptTermsTask Urn(string urn = null)
        {
            WithArguments("--urn");
            if (!string.IsNullOrEmpty(urn))
            {
                 WithArguments(urn);
            }

            return this;
        }
     }
}
