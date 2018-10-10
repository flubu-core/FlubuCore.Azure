
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfClusterSettingRemoveTask : ExternalProcessTaskBase<AzureSfClusterSettingRemoveTask>
     {
        
        /// <summary>
        /// Remove settings from a cluster.
        /// </summary>
        public AzureSfClusterSettingRemoveTask(string clusterName = null ,  string resourceGroup = null)
        {
            WithArguments("az sf cluster setting remove");
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
        public AzureSfClusterSettingRemoveTask Parameter(string parameter = null)
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
        public AzureSfClusterSettingRemoveTask Section(string section = null)
        {
            WithArguments("--section");
            if (!string.IsNullOrEmpty(section))
            {
                 WithArguments(section);
            }

            return this;
        }

        /// <summary>
        /// JSON encoded parameters configuration. Use @{file} to load from a file. For example: [{"section": "NamingService","parameter": "MaxOperationTimeout"}].
        /// </summary>
        public AzureSfClusterSettingRemoveTask SettingsSectionDescription(string settingsSectionDescription = null)
        {
            WithArguments("--settings-section-description");
            if (!string.IsNullOrEmpty(settingsSectionDescription))
            {
                 WithArguments(settingsSectionDescription);
            }

            return this;
        }
     }
}
