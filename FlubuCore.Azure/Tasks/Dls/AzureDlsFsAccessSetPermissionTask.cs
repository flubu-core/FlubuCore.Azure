
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsFsAccessSetPermissionTask : ExternalProcessTaskBase<AzureDlsFsAccessSetPermissionTask>
     {
        
        /// <summary>
        /// Set the permissions for a file or folder in a Data Lake Store account.
        /// </summary>
        public AzureDlsFsAccessSetPermissionTask(string account = null ,  string path = null ,  string permission = null)
        {
            WithArguments("az dls fs access set-permission");
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

WithArguments("--permission");
            if (!string.IsNullOrEmpty(permission))
            {
                 WithArguments(permission);
            }

        }

        protected override string Description { get; set; }
        
     }
}
