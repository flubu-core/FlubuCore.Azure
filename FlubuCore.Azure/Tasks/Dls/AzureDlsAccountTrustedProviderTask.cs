
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsAccountTrustedProviderTask : ExternalProcessTaskBase<AzureDlsAccountTrustedProviderTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Store account trusted identity providers.
        /// </summary>
        public AzureDlsAccountTrustedProviderTask()
        {
            WithArguments("az dls account trusted-provider");
        }

        protected override string Description { get; set; }
        
     }
}
