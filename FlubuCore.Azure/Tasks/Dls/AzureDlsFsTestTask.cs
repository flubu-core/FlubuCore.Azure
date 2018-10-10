
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsFsTestTask : ExternalProcessTaskBase<AzureDlsFsTestTask>
     {
        
        /// <summary>
        /// Test for the existence of a file or folder in a Data Lake Store account.
        /// </summary>
        public AzureDlsFsTestTask(string account = null ,  string path = null)
        {
            WithArguments("az dls fs test");
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
        
     }
}
