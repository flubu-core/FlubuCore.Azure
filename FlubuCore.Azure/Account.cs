
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Account;

namespace FlubuCore.Azure
{
    public class Account
    {
        
        
            public AzureAccountClearTask AccountClear()
            {
                return new AzureAccountClearTask();
            }

            public AzureAccountGetAccessTokenTask AccountGetAccessToken()
            {
                return new AzureAccountGetAccessTokenTask();
            }

            public AzureAccountSetTask AccountSet(string subscription)
            {
                return new AzureAccountSetTask(subscription);
            }

            public AzureAccountLockTask AccountLock()
            {
                return new AzureAccountLockTask();
            }

            public AzureAccountLockCreateTask AccountLockCreate(string lockType ,  string name)
            {
                return new AzureAccountLockCreateTask(lockType,  name);
            }

            public AzureAccountLockDeleteTask AccountLockDelete()
            {
                return new AzureAccountLockDeleteTask();
            }

            public AzureAccountLockUpdateTask AccountLockUpdate()
            {
                return new AzureAccountLockUpdateTask();
            }

            public AzureAccountManagementGroupTask AccountManagementGroup()
            {
                return new AzureAccountManagementGroupTask();
            }

            public AzureAccountManagementGroupCreateTask AccountManagementGroupCreate(string name)
            {
                return new AzureAccountManagementGroupCreateTask(name);
            }

            public AzureAccountManagementGroupDeleteTask AccountManagementGroupDelete(string name)
            {
                return new AzureAccountManagementGroupDeleteTask(name);
            }

            public AzureAccountManagementGroupUpdateTask AccountManagementGroupUpdate(string name)
            {
                return new AzureAccountManagementGroupUpdateTask(name);
            }

            public AzureAccountManagementGroupSubscriptionTask AccountManagementGroupSubscription()
            {
                return new AzureAccountManagementGroupSubscriptionTask();
            }

            public AzureAccountManagementGroupSubscriptionAddTask AccountManagementGroupSubscriptionAdd(string name ,  string subscription)
            {
                return new AzureAccountManagementGroupSubscriptionAddTask(name,  subscription);
            }

            public AzureAccountManagementGroupSubscriptionRemoveTask AccountManagementGroupSubscriptionRemove(string name ,  string subscription)
            {
                return new AzureAccountManagementGroupSubscriptionRemoveTask(name,  subscription);
            }

            public AzureAccountCreateTask AccountCreate(string enrollmentAccountName ,  string offerType)
            {
                return new AzureAccountCreateTask(enrollmentAccountName,  offerType);
            }
        
    }
}

