
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappDeletedRestoreTask : ExternalProcessTaskBase<AzureWebappDeletedRestoreTask>
     {
        
        /// <summary>
        /// Restore a deleted web app.
        /// </summary>
        public AzureWebappDeletedRestoreTask(string deletedId = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp deleted restore");
WithArguments("--deleted-id");
            if (!string.IsNullOrEmpty(deletedId))
            {
                 WithArguments(deletedId);
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

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Restore only deleted files without web app settings.
        /// </summary>
        public AzureWebappDeletedRestoreTask RestoreContentOnly(string restoreContentOnly = null)
        {
            WithArguments("--restore-content-only");
            if (!string.IsNullOrEmpty(restoreContentOnly))
            {
                 WithArguments(restoreContentOnly);
            }

            return this;
        }

        /// <summary>
        /// Slot to restore the deleted content to.
        /// </summary>
        public AzureWebappDeletedRestoreTask Slot(string slot = null)
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
