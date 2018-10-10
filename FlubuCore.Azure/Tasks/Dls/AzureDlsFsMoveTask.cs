
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsFsMoveTask : ExternalProcessTaskBase<AzureDlsFsMoveTask>
     {
        
        /// <summary>
        /// Move a file or folder in a Data Lake Store account.
        /// </summary>
        public AzureDlsFsMoveTask(string account = null ,  string destinationPath = null ,  string sourcePath = null)
        {
            WithArguments("az dls fs move");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

WithArguments("--destination-path");
            if (!string.IsNullOrEmpty(destinationPath))
            {
                 WithArguments(destinationPath);
            }

WithArguments("--source-path");
            if (!string.IsNullOrEmpty(sourcePath))
            {
                 WithArguments(sourcePath);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Indicates that, if the destination file or folder already exists, it should be overwritten and replaced with the file or folder being moved.
        /// </summary>
        public AzureDlsFsMoveTask Force(string force = null)
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
