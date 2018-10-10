
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Alias
{
     public partial class AzureAliasImportTask : ExternalProcessTaskBase<AzureAliasImportTask>
     {
        
        /// <summary>
        /// Import aliases from an INI configuration file or an URL.
        /// </summary>
        public AzureAliasImportTask(string source = null)
        {
            WithArguments("az alias import");
WithArguments("--source");
            if (!string.IsNullOrEmpty(source))
            {
                 WithArguments(source);
            }

        }

        protected override string Description { get; set; }
        
     }
}
