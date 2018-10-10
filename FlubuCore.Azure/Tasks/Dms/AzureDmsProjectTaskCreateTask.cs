
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dms
{
     public partial class AzureDmsProjectTaskCreateTask : ExternalProcessTaskBase<AzureDmsProjectTaskCreateTask>
     {
        
        /// <summary>
        /// Create and start a migration Task.
        /// </summary>
        public AzureDmsProjectTaskCreateTask(string databaseOptionsJson = null ,  string name = null ,  string projectName = null ,  string resourceGroup = null ,  string serviceName = null ,  string sourceConnectionJson = null ,  string targetConnectionJson = null)
        {
            WithArguments("az dms project task create");
WithArguments("--database-options-json");
            if (!string.IsNullOrEmpty(databaseOptionsJson))
            {
                 WithArguments(databaseOptionsJson);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--project-name");
            if (!string.IsNullOrEmpty(projectName))
            {
                 WithArguments(projectName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--service-name");
            if (!string.IsNullOrEmpty(serviceName))
            {
                 WithArguments(serviceName);
            }

WithArguments("--source-connection-json");
            if (!string.IsNullOrEmpty(sourceConnectionJson))
            {
                 WithArguments(sourceConnectionJson);
            }

WithArguments("--target-connection-json");
            if (!string.IsNullOrEmpty(targetConnectionJson))
            {
                 WithArguments(targetConnectionJson);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Whether to perform a checksum based data integrity validation between source and target for the selected database and tables.
        /// </summary>
        public AzureDmsProjectTaskCreateTask EnableDataIntegrityValidation(string enableDataIntegrityValidation = null)
        {
            WithArguments("--enable-data-integrity-validation");
            if (!string.IsNullOrEmpty(enableDataIntegrityValidation))
            {
                 WithArguments(enableDataIntegrityValidation);
            }

            return this;
        }

        /// <summary>
        /// Whether to perform a quick and intelligent query analysis by retrieving queries from the source database and executing them in the target. The result will have execution statistics for executions in source and target databases for the extracted queries.
        /// </summary>
        public AzureDmsProjectTaskCreateTask EnableQueryAnalysisValidation(string enableQueryAnalysisValidation = null)
        {
            WithArguments("--enable-query-analysis-validation");
            if (!string.IsNullOrEmpty(enableQueryAnalysisValidation))
            {
                 WithArguments(enableQueryAnalysisValidation);
            }

            return this;
        }

        /// <summary>
        /// Whether to compare the schema information between source and target.
        /// </summary>
        public AzureDmsProjectTaskCreateTask EnableSchemaValidation(string enableSchemaValidation = null)
        {
            WithArguments("--enable-schema-validation");
            if (!string.IsNullOrEmpty(enableSchemaValidation))
            {
                 WithArguments(enableSchemaValidation);
            }

            return this;
        }
     }
}
