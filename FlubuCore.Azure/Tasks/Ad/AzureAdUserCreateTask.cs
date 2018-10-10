
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdUserCreateTask : ExternalProcessTaskBase<AzureAdUserCreateTask>
     {
        
        /// <summary>
        /// Request parameters for creating a new work or school account user.
        /// </summary>
        public AzureAdUserCreateTask(string displayName = null ,  string password = null ,  string userPrincipalName = null)
        {
            WithArguments("az ad user create");
WithArguments("--display-name");
            if (!string.IsNullOrEmpty(displayName))
            {
                 WithArguments(displayName);
            }

WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
            }

WithArguments("--user-principal-name");
            if (!string.IsNullOrEmpty(userPrincipalName))
            {
                 WithArguments(userPrincipalName);
            }

        }

        protected override string Description { get; set; }
        
        public AzureAdUserCreateTask ForceChangePasswordNextLogin(string forceChangePasswordNextLogin = null)
        {
            WithArguments("--force-change-password-next-login");
            if (!string.IsNullOrEmpty(forceChangePasswordNextLogin))
            {
                 WithArguments(forceChangePasswordNextLogin);
            }

            return this;
        }

        /// <summary>
        /// This must be specified if you are using a federated domain for the user's userPrincipalName (UPN) property when creating a new user account. It is used to associate an on-premises Active Directory user account with their Azure AD user object.
        /// </summary>
        public AzureAdUserCreateTask ImmutableId(string immutableId = null)
        {
            WithArguments("--immutable-id");
            if (!string.IsNullOrEmpty(immutableId))
            {
                 WithArguments(immutableId);
            }

            return this;
        }

        /// <summary>
        /// Mail alias. Defaults to user principal name.
        /// </summary>
        public AzureAdUserCreateTask MailNickname(string mailNickname = null)
        {
            WithArguments("--mail-nickname");
            if (!string.IsNullOrEmpty(mailNickname))
            {
                 WithArguments(mailNickname);
            }

            return this;
        }
     }
}
