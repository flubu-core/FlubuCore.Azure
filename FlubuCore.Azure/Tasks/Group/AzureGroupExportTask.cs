
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Group
{
     public partial class AzureGroupExportTask : ExternalProcessTaskBase<AzureGroupExportTask>
     {
        
        /// <summary>
        /// Captures a resource group as a template.
        /// </summary>
        public AzureGroupExportTask(string name = null)
        {
            WithArguments("az group export");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Export template with comments.
        /// </summary>
        public AzureGroupExportTask IncludeComments(string includeComments = null)
        {
            WithArguments("--include-comments");
            if (!string.IsNullOrEmpty(includeComments))
            {
                 WithArguments(includeComments);
            }

            return this;
        }

        /// <summary>
        /// Export template parameter with default value.
        /// </summary>
        public AzureGroupExportTask IncludeParameterDefaultValue(string includeParameterDefaultValue = null)
        {
            WithArguments("--include-parameter-default-value");
            if (!string.IsNullOrEmpty(includeParameterDefaultValue))
            {
                 WithArguments(includeParameterDefaultValue);
            }

            return this;
        }
     }
}
