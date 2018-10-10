
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlServerTdeKeySetTask : ExternalProcessTaskBase<AzureSqlServerTdeKeySetTask>
     {
        
        /// <summary>
        /// Sets the server's encryption protector.
        /// </summary>
        public AzureSqlServerTdeKeySetTask(string resourceGroup = null ,  string server = null ,  string serverKeyType = null)
        {
            WithArguments("az sql server tde-key set");
WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--server");
            if (!string.IsNullOrEmpty(server))
            {
                 WithArguments(server);
            }

WithArguments("--server-key-type");
            if (!string.IsNullOrEmpty(serverKeyType))
            {
                 WithArguments(serverKeyType);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The Azure Key Vault key identifier of the server key to be made encryption protector.An example key identifier is "<a href="https://YourVaultName.vault.azure.net/keys/YourKeyName/01234567890123456789012345678901">https://YourVaultName.vault.azure.net/keys/YourKeyName/01234567890123456789012345678901</a>".
        /// </summary>
        public AzureSqlServerTdeKeySetTask Kid(string kid = null)
        {
            WithArguments("--kid");
            if (!string.IsNullOrEmpty(kid))
            {
                 WithArguments(kid);
            }

            return this;
        }
     }
}
