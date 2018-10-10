
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Alias
{
     public partial class AzureAliasExportTask : ExternalProcessTaskBase<AzureAliasExportTask>
     {
        
        /// <summary>
        /// Export all registered aliases to a given path, as an INI configuration file. If no export path is specified, the alias configuration file is exported to the current working directory.
        /// </summary>
        public AzureAliasExportTask()
        {
            WithArguments("az alias export");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Space-separated aliases excluded from export.
        /// </summary>
        public AzureAliasExportTask Exclude(string exclude = null)
        {
            WithArguments("--exclude");
            if (!string.IsNullOrEmpty(exclude))
            {
                 WithArguments(exclude);
            }

            return this;
        }

        /// <summary>
        /// The path of the alias configuration file to export to.
        /// </summary>
        public AzureAliasExportTask Path(string path = null)
        {
            WithArguments("--path");
            if (!string.IsNullOrEmpty(path))
            {
                 WithArguments(path);
            }

            return this;
        }
     }
}
