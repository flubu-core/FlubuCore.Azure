
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsFsDeleteTask : ExternalProcessTaskBase<AzureDlsFsDeleteTask>
     {
        
        /// <summary>
        /// Delete a file or folder in a Data Lake Store account.
        /// </summary>
        public AzureDlsFsDeleteTask(string account = null ,  string path = null)
        {
            WithArguments("az dls fs delete");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

WithArguments("--path");
            if (!string.IsNullOrEmpty(path))
            {
                 WithArguments(path);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Indicates this should be a recursive delete of the folder.
        /// </summary>
        public AzureDlsFsDeleteTask Recurse(string recurse = null)
        {
            WithArguments("--recurse");
            if (!string.IsNullOrEmpty(recurse))
            {
                 WithArguments(recurse);
            }

            return this;
        }
     }
}
