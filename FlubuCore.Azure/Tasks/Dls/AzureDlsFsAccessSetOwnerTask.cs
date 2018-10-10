
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsFsAccessSetOwnerTask : ExternalProcessTaskBase<AzureDlsFsAccessSetOwnerTask>
     {
        
        /// <summary>
        /// Set the owner information for a file or folder in a Data Lake Store account.
        /// </summary>
        public AzureDlsFsAccessSetOwnerTask(string account = null ,  string path = null)
        {
            WithArguments("az dls fs access set-owner");
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
        /// The group Azure Active Directory object ID or user principal name to set as the owning group.
        /// </summary>
        public AzureDlsFsAccessSetOwnerTask Group(string group = null)
        {
            WithArguments("--group");
            if (!string.IsNullOrEmpty(group))
            {
                 WithArguments(group);
            }

            return this;
        }

        /// <summary>
        /// The user Azure Active Directory object ID or user principal name to set as the owner.
        /// </summary>
        public AzureDlsFsAccessSetOwnerTask Owner(string owner = null)
        {
            WithArguments("--owner");
            if (!string.IsNullOrEmpty(owner))
            {
                 WithArguments(owner);
            }

            return this;
        }
     }
}
