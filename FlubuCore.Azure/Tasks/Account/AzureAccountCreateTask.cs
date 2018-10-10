
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Account
{
     public partial class AzureAccountCreateTask : ExternalProcessTaskBase<AzureAccountCreateTask>
     {
        
        /// <summary>
        /// Create a subscription.
        /// </summary>
        public AzureAccountCreateTask(string enrollmentAccountName = null ,  string offerType = null)
        {
            WithArguments("az account create");
WithArguments("--enrollment-account-name");
            if (!string.IsNullOrEmpty(enrollmentAccountName))
            {
                 WithArguments(enrollmentAccountName);
            }

WithArguments("--offer-type");
            if (!string.IsNullOrEmpty(offerType))
            {
                 WithArguments(offerType);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The display name of the subscription.
        /// </summary>
        public AzureAccountCreateTask DisplayName(string displayName = null)
        {
            WithArguments("--display-name");
            if (!string.IsNullOrEmpty(displayName))
            {
                 WithArguments(displayName);
            }

            return this;
        }

        /// <summary>
        /// The object id(s) of the owner(s) which should be granted access to the new subscription.
        /// </summary>
        public AzureAccountCreateTask OwnerObjectId(string ownerObjectId = null)
        {
            WithArguments("--owner-object-id");
            if (!string.IsNullOrEmpty(ownerObjectId))
            {
                 WithArguments(ownerObjectId);
            }

            return this;
        }

        /// <summary>
        /// The service principal name(s) of the owner(s) which should be granted access to the new subscription.
        /// </summary>
        public AzureAccountCreateTask OwnerSpn(string ownerSpn = null)
        {
            WithArguments("--owner-spn");
            if (!string.IsNullOrEmpty(ownerSpn))
            {
                 WithArguments(ownerSpn);
            }

            return this;
        }

        /// <summary>
        /// The user principal name(s) of owner(s) who should be granted access to the new subscription.
        /// </summary>
        public AzureAccountCreateTask OwnerUpn(string ownerUpn = null)
        {
            WithArguments("--owner-upn");
            if (!string.IsNullOrEmpty(ownerUpn))
            {
                 WithArguments(ownerUpn);
            }

            return this;
        }
     }
}
