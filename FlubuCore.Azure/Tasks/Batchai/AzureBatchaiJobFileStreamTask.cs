
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batchai
{
     public partial class AzureBatchaiJobFileStreamTask : ExternalProcessTaskBase<AzureBatchaiJobFileStreamTask>
     {
        
        /// <summary>
        /// Stream the content of a file (similar to 'tail -f').
        /// </summary>
        public AzureBatchaiJobFileStreamTask(string experiment = null ,  string fileName = null ,  string job = null ,  string resourceGroup = null ,  string workspace = null)
        {
            WithArguments("az batchai job file stream");
WithArguments("--experiment");
            if (!string.IsNullOrEmpty(experiment))
            {
                 WithArguments(experiment);
            }

WithArguments("--file-name");
            if (!string.IsNullOrEmpty(fileName))
            {
                 WithArguments(fileName);
            }

WithArguments("--job");
            if (!string.IsNullOrEmpty(job))
            {
                 WithArguments(job);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--workspace");
            if (!string.IsNullOrEmpty(workspace))
            {
                 WithArguments(workspace);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The Id of the job's output directory (as specified by "id" element in outputDirectories collection in the job create parameters).
        /// </summary>
        public AzureBatchaiJobFileStreamTask OutputDirectoryId(string outputDirectoryId = null)
        {
            WithArguments("--output-directory-id");
            if (!string.IsNullOrEmpty(outputDirectoryId))
            {
                 WithArguments(outputDirectoryId);
            }

            return this;
        }

        /// <summary>
        /// Relative path in the given output directory.
        /// </summary>
        public AzureBatchaiJobFileStreamTask Path(string path = null)
        {
            WithArguments("--path");
            if (!string.IsNullOrEmpty(path))
            {
                 WithArguments(path);
            }

            return this;
        }
     }
}
