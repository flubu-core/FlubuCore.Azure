
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaJobSubmitTask : ExternalProcessTaskBase<AzureDlaJobSubmitTask>
     {
        
        /// <summary>
        /// Submit a job to a Data Lake Analytics account.
        /// </summary>
        public AzureDlaJobSubmitTask(string account = null ,  string jobName = null ,  string script = null)
        {
            WithArguments("az dla job submit");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

WithArguments("--job-name");
            if (!string.IsNullOrEmpty(jobName))
            {
                 WithArguments(jobName);
            }

WithArguments("--script");
            if (!string.IsNullOrEmpty(script))
            {
                 WithArguments(script);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Indicates the type of compilation to be done on this job. Valid values are: 'Semantic' (Only performs semantic checks and necessary sanity checks), 'Full' (full compilation) and 'SingleBox' (Full compilation performed locally).
        /// </summary>
        public AzureDlaJobSubmitTask CompileMode(string compileMode = null)
        {
            WithArguments("--compile-mode");
            if (!string.IsNullOrEmpty(compileMode))
            {
                 WithArguments(compileMode);
            }

            return this;
        }

        /// <summary>
        /// Indicates that the submission should only build the job and not execute if set to true.
        /// </summary>
        public AzureDlaJobSubmitTask CompileOnly(string compileOnly = null)
        {
            WithArguments("--compile-only");
            if (!string.IsNullOrEmpty(compileOnly))
            {
                 WithArguments(compileOnly);
            }

            return this;
        }

        /// <summary>
        /// The degree of parallelism for the job.
        /// </summary>
        public AzureDlaJobSubmitTask DegreeOfParallelism(string degreeOfParallelism = null)
        {
            WithArguments("--degree-of-parallelism");
            if (!string.IsNullOrEmpty(degreeOfParallelism))
            {
                 WithArguments(degreeOfParallelism);
            }

            return this;
        }

        public AzureDlaJobSubmitTask PipelineId(string pipelineId = null)
        {
            WithArguments("--pipeline-id");
            if (!string.IsNullOrEmpty(pipelineId))
            {
                 WithArguments(pipelineId);
            }

            return this;
        }

        public AzureDlaJobSubmitTask PipelineName(string pipelineName = null)
        {
            WithArguments("--pipeline-name");
            if (!string.IsNullOrEmpty(pipelineName))
            {
                 WithArguments(pipelineName);
            }

            return this;
        }

        public AzureDlaJobSubmitTask PipelineUri(string pipelineUri = null)
        {
            WithArguments("--pipeline-uri");
            if (!string.IsNullOrEmpty(pipelineUri))
            {
                 WithArguments(pipelineUri);
            }

            return this;
        }

        /// <summary>
        /// The priority of the job.
        /// </summary>
        public AzureDlaJobSubmitTask Priority(string priority = null)
        {
            WithArguments("--priority");
            if (!string.IsNullOrEmpty(priority))
            {
                 WithArguments(priority);
            }

            return this;
        }

        public AzureDlaJobSubmitTask RecurrenceId(string recurrenceId = null)
        {
            WithArguments("--recurrence-id");
            if (!string.IsNullOrEmpty(recurrenceId))
            {
                 WithArguments(recurrenceId);
            }

            return this;
        }

        public AzureDlaJobSubmitTask RecurrenceName(string recurrenceName = null)
        {
            WithArguments("--recurrence-name");
            if (!string.IsNullOrEmpty(recurrenceName))
            {
                 WithArguments(recurrenceName);
            }

            return this;
        }

        public AzureDlaJobSubmitTask RunId(string runId = null)
        {
            WithArguments("--run-id");
            if (!string.IsNullOrEmpty(runId))
            {
                 WithArguments(runId);
            }

            return this;
        }

        /// <summary>
        /// The runtime version to use.
        /// </summary>
        public AzureDlaJobSubmitTask RuntimeVersion(string runtimeVersion = null)
        {
            WithArguments("--runtime-version");
            if (!string.IsNullOrEmpty(runtimeVersion))
            {
                 WithArguments(runtimeVersion);
            }

            return this;
        }
     }
}
