
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsFsCreateTask : ExternalProcessTaskBase<AzureDlsFsCreateTask>
     {
        
        /// <summary>
        /// Creates a file or folder in a Data Lake Store account.
        /// </summary>
        public AzureDlsFsCreateTask(string account = null ,  string path = null)
        {
            WithArguments("az dls fs create");
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
        /// Content for the file to contain upon creation.
        /// </summary>
        public AzureDlsFsCreateTask Content(string content = null)
        {
            WithArguments("--content");
            if (!string.IsNullOrEmpty(content))
            {
                 WithArguments(content);
            }

            return this;
        }

        /// <summary>
        /// Indicates that this new item is a folder and not a file.
        /// </summary>
        public AzureDlsFsCreateTask Folder(string folder = null)
        {
            WithArguments("--folder");
            if (!string.IsNullOrEmpty(folder))
            {
                 WithArguments(folder);
            }

            return this;
        }

        /// <summary>
        /// Indicates that, if the file or folder exists, it should be overwritten.
        /// </summary>
        public AzureDlsFsCreateTask Force(string force = null)
        {
            WithArguments("--force");
            if (!string.IsNullOrEmpty(force))
            {
                 WithArguments(force);
            }

            return this;
        }
     }
}
