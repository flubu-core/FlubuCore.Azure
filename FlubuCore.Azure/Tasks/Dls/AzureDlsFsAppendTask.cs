
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsFsAppendTask : ExternalProcessTaskBase<AzureDlsFsAppendTask>
     {
        
        /// <summary>
        /// Append content to a file in a Data Lake Store account.
        /// </summary>
        public AzureDlsFsAppendTask(string account = null ,  string content = null ,  string path = null)
        {
            WithArguments("az dls fs append");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

WithArguments("--content");
            if (!string.IsNullOrEmpty(content))
            {
                 WithArguments(content);
            }

WithArguments("--path");
            if (!string.IsNullOrEmpty(path))
            {
                 WithArguments(path);
            }

        }

        protected override string Description { get; set; }
        
     }
}
