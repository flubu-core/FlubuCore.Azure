
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsFsAccessRemoveAllTask : ExternalProcessTaskBase<AzureDlsFsAccessRemoveAllTask>
     {
        
        /// <summary>
        /// Remove the access control list for a file or folder.
        /// </summary>
        public AzureDlsFsAccessRemoveAllTask(string account = null ,  string path = null)
        {
            WithArguments("az dls fs access remove-all");
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
        /// A switch that, if specified, indicates that the remove ACL operation should remove the default ACL of the folder. Otherwise the regular ACL is removed.
        /// </summary>
        public AzureDlsFsAccessRemoveAllTask DefaultAcl(string defaultAcl = null)
        {
            WithArguments("--default-acl");
            if (!string.IsNullOrEmpty(defaultAcl))
            {
                 WithArguments(defaultAcl);
            }

            return this;
        }
     }
}
