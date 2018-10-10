
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsAssetCreateTask : ExternalProcessTaskBase<AzureAmsAssetCreateTask>
     {
        
        /// <summary>
        /// Create an asset.
        /// </summary>
        public AzureAmsAssetCreateTask(string accountName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az ams asset create");
WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
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

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The alternate id of the asset.
        /// </summary>
        public AzureAmsAssetCreateTask AlternateId(string alternateId = null)
        {
            WithArguments("--alternate-id");
            if (!string.IsNullOrEmpty(alternateId))
            {
                 WithArguments(alternateId);
            }

            return this;
        }
     }
}
