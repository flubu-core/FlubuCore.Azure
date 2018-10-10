
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaJobRecurrenceTask : ExternalProcessTaskBase<AzureDlaJobRecurrenceTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Analytics job recurrences.
        /// </summary>
        public AzureDlaJobRecurrenceTask()
        {
            WithArguments("az dla job recurrence");
        }

        protected override string Description { get; set; }
        
     }
}
