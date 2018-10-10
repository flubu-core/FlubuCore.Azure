
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Search
{
     public partial class AzureSearchAdminKeyTask : ExternalProcessTaskBase<AzureSearchAdminKeyTask>
     {
        
        /// <summary>
        /// Manage Azure Search admin keys.
        /// </summary>
        public AzureSearchAdminKeyTask()
        {
            WithArguments("az search admin-key");
        }

        protected override string Description { get; set; }
        
     }
}
