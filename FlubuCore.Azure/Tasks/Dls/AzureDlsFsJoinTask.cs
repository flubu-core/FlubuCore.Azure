
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsFsJoinTask : ExternalProcessTaskBase<AzureDlsFsJoinTask>
     {
        
        /// <summary>
        /// Join files in a Data Lake Store account into one file.
        /// </summary>
        public AzureDlsFsJoinTask(string account = null ,  string destinationPath = null ,  string sourcePaths = null)
        {
            WithArguments("az dls fs join");
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

WithArguments("--source-paths");
            if (!string.IsNullOrEmpty(sourcePaths))
            {
                 WithArguments(sourcePaths);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Indicates that, if the destination file already exists, it should be overwritten.
        /// </summary>
        public AzureDlsFsJoinTask Force(string force = null)
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
