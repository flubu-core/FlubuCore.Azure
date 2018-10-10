
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsFsAccessSetTask : ExternalProcessTaskBase<AzureDlsFsAccessSetTask>
     {
        
        /// <summary>
        /// Replace the existing access control list for a file or folder.
        /// </summary>
        public AzureDlsFsAccessSetTask(string account = null ,  string aclSpec = null ,  string path = null)
        {
            WithArguments("az dls fs access set");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

WithArguments("--acl-spec");
            if (!string.IsNullOrEmpty(aclSpec))
            {
                 WithArguments(aclSpec);
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
