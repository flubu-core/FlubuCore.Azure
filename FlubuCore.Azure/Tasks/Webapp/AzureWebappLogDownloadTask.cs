
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappLogDownloadTask : ExternalProcessTaskBase<AzureWebappLogDownloadTask>
     {
        
        /// <summary>
        /// Download a web app's log history as a zip file.
        /// </summary>
        public AzureWebappLogDownloadTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp log download");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The downloaded zipped log file path.
        /// </summary>
        public AzureWebappLogDownloadTask LogFile(string logFile = null)
        {
            WithArguments("--log-file");
            if (!string.IsNullOrEmpty(logFile))
            {
                 WithArguments(logFile);
            }

            return this;
        }

        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappLogDownloadTask Slot(string slot = null)
        {
            WithArguments("--slot");
            if (!string.IsNullOrEmpty(slot))
            {
                 WithArguments(slot);
            }

            return this;
        }
     }
}
