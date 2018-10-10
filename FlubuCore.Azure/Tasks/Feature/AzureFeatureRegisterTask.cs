
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Feature
{
     public partial class AzureFeatureRegisterTask : ExternalProcessTaskBase<AzureFeatureRegisterTask>
     {
        
        /// <summary>
        /// Register a preview feature.
        /// </summary>
        public AzureFeatureRegisterTask(string name = null ,  string @namespace = null)
        {
            WithArguments("az feature register");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--namespace");
            if (!string.IsNullOrEmpty(@namespace))
            {
                 WithArguments(@namespace);
            }

        }

        protected override string Description { get; set; }
        
     }
}
