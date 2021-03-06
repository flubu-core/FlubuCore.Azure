
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfClusterSettingSetTask : ExternalProcessTaskBase<AzureSfClusterSettingSetTask>
     {
        
        /// <summary>
        /// Update the settings of a cluster.
        /// </summary>
        public AzureSfClusterSettingSetTask(string clusterName = null ,  string resourceGroup = null)
        {
            WithArguments("az sf cluster setting set");
WithArguments("--cluster-name");
            if (!string.IsNullOrEmpty(clusterName))
            {
                 WithArguments(clusterName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Parameter name.
        /// </summary>
        public AzureSfClusterSettingSetTask Parameter(string parameter = null)
        {
            WithArguments("--parameter");
            if (!string.IsNullOrEmpty(parameter))
            {
                 WithArguments(parameter);
            }

            return this;
        }

        /// <summary>
        /// Section name.
        /// </summary>
        public AzureSfClusterSettingSetTask Section(string section = null)
        {
            WithArguments("--section");
            if (!string.IsNullOrEmpty(section))
            {
                 WithArguments(section);
            }

            return this;
        }

        /// <summary>
        /// JSON encoded parameters configuration. Use @{file} to load from a file. For example: [{"section": "NamingService","parameter": "MaxOperationTimeout","value": 1000},{"section": "MaxFileOperationTimeout","parameter": "Max2","value": 1000].
        /// </summary>
        public AzureSfClusterSettingSetTask SettingsSectionDescription(string settingsSectionDescription = null)
        {
            WithArguments("--settings-section-description");
            if (!string.IsNullOrEmpty(settingsSectionDescription))
            {
                 WithArguments(settingsSectionDescription);
            }

            return this;
        }

        /// <summary>
        /// Specify the value.
        /// </summary>
        public AzureSfClusterSettingSetTask Value(string value = null)
        {
            WithArguments("--value");
            if (!string.IsNullOrEmpty(value))
            {
                 WithArguments(value);
            }

            return this;
        }
     }
}
