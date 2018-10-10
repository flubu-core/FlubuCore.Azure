
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlMidbRestoreTask : ExternalProcessTaskBase<AzureSqlMidbRestoreTask>
     {
        
        /// <summary>
        /// Restore a managed database.
        /// </summary>
        public AzureSqlMidbRestoreTask(string destName = null ,  string managedInstance = null ,  string name = null ,  string resourceGroup = null ,  string time = null)
        {
            WithArguments("az sql midb restore");
WithArguments("--dest-name");
            if (!string.IsNullOrEmpty(destName))
            {
                 WithArguments(destName);
            }

WithArguments("--managed-instance");
            if (!string.IsNullOrEmpty(managedInstance))
            {
                 WithArguments(managedInstance);
            }

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

WithArguments("--time");
            if (!string.IsNullOrEmpty(time))
            {
                 WithArguments(time);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of the managed instance to restore managed database to. This can be same managed instance, or another managed instance on same subscription. When not specified it defaults to source managed instance.
        /// </summary>
        public AzureSqlMidbRestoreTask DestMi(string destMi = null)
        {
            WithArguments("--dest-mi");
            if (!string.IsNullOrEmpty(destMi))
            {
                 WithArguments(destMi);
            }

            return this;
        }

        /// <summary>
        /// Name of the resource group of the managed instance to restore managed database to. When not specified it defaults to source resource group.
        /// </summary>
        public AzureSqlMidbRestoreTask DestResourceGroup(string destResourceGroup = null)
        {
            WithArguments("--dest-resource-group");
            if (!string.IsNullOrEmpty(destResourceGroup))
            {
                 WithArguments(destResourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureSqlMidbRestoreTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }
     }
}
