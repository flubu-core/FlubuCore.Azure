
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureRedisTask : ExternalProcessTaskBase<AzureRedisTask>
     {
        
        /// <summary>
        /// Manage dedicated Redis caches for your Azure applications.
        /// </summary>
        public AzureRedisTask()
        {
            WithArguments("az redis");
        }

        protected override string Description { get; set; }
        
     }
}
