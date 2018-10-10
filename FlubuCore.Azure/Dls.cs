
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Dls;

namespace FlubuCore.Azure
{
    public class Dls
    {
        
        
            public AzureDlsAccountTask DlsAccount()
            {
                return new AzureDlsAccountTask();
            }

            public AzureDlsAccountCreateTask DlsAccountCreate(string account)
            {
                return new AzureDlsAccountCreateTask(account);
            }

            public AzureDlsAccountDeleteTask DlsAccountDelete(string account)
            {
                return new AzureDlsAccountDeleteTask(account);
            }

            public AzureDlsAccountEnableKeyVaultTask DlsAccountEnableKeyVault(string account)
            {
                return new AzureDlsAccountEnableKeyVaultTask(account);
            }

            public AzureDlsAccountUpdateTask DlsAccountUpdate(string account)
            {
                return new AzureDlsAccountUpdateTask(account);
            }

            public AzureDlsFsTask DlsFs()
            {
                return new AzureDlsFsTask();
            }

            public AzureDlsFsAppendTask DlsFsAppend(string account ,  string content ,  string path)
            {
                return new AzureDlsFsAppendTask(account,  content,  path);
            }

            public AzureDlsFsCreateTask DlsFsCreate(string account ,  string path)
            {
                return new AzureDlsFsCreateTask(account,  path);
            }

            public AzureDlsFsDeleteTask DlsFsDelete(string account ,  string path)
            {
                return new AzureDlsFsDeleteTask(account,  path);
            }

            public AzureDlsFsDownloadTask DlsFsDownload(string account ,  string destinationPath ,  string sourcePath)
            {
                return new AzureDlsFsDownloadTask(account,  destinationPath,  sourcePath);
            }

            public AzureDlsFsJoinTask DlsFsJoin(string account ,  string destinationPath ,  string sourcePaths)
            {
                return new AzureDlsFsJoinTask(account,  destinationPath,  sourcePaths);
            }

            public AzureDlsFsMoveTask DlsFsMove(string account ,  string destinationPath ,  string sourcePath)
            {
                return new AzureDlsFsMoveTask(account,  destinationPath,  sourcePath);
            }

            public AzureDlsFsPreviewTask DlsFsPreview(string account ,  string path)
            {
                return new AzureDlsFsPreviewTask(account,  path);
            }

            public AzureDlsFsRemoveExpiryTask DlsFsRemoveExpiry(string account ,  string path)
            {
                return new AzureDlsFsRemoveExpiryTask(account,  path);
            }

            public AzureDlsFsSetExpiryTask DlsFsSetExpiry(string account ,  string expirationTime ,  string path)
            {
                return new AzureDlsFsSetExpiryTask(account,  expirationTime,  path);
            }

            public AzureDlsFsTestTask DlsFsTest(string account ,  string path)
            {
                return new AzureDlsFsTestTask(account,  path);
            }

            public AzureDlsFsUploadTask DlsFsUpload(string account ,  string destinationPath ,  string sourcePath)
            {
                return new AzureDlsFsUploadTask(account,  destinationPath,  sourcePath);
            }

            public AzureDlsAccountFirewallTask DlsAccountFirewall()
            {
                return new AzureDlsAccountFirewallTask();
            }

            public AzureDlsAccountFirewallCreateTask DlsAccountFirewallCreate(string account ,  string endIpAddress ,  string firewallRuleName ,  string startIpAddress)
            {
                return new AzureDlsAccountFirewallCreateTask(account,  endIpAddress,  firewallRuleName,  startIpAddress);
            }

            public AzureDlsAccountFirewallDeleteTask DlsAccountFirewallDelete(string account ,  string firewallRuleName)
            {
                return new AzureDlsAccountFirewallDeleteTask(account,  firewallRuleName);
            }

            public AzureDlsAccountFirewallUpdateTask DlsAccountFirewallUpdate(string account ,  string firewallRuleName)
            {
                return new AzureDlsAccountFirewallUpdateTask(account,  firewallRuleName);
            }

            public AzureDlsAccountNetworkRuleTask DlsAccountNetworkRule()
            {
                return new AzureDlsAccountNetworkRuleTask();
            }

            public AzureDlsAccountNetworkRuleCreateTask DlsAccountNetworkRuleCreate(string accountName ,  string name ,  string subnet)
            {
                return new AzureDlsAccountNetworkRuleCreateTask(accountName,  name,  subnet);
            }

            public AzureDlsAccountNetworkRuleDeleteTask DlsAccountNetworkRuleDelete(string accountName ,  string name)
            {
                return new AzureDlsAccountNetworkRuleDeleteTask(accountName,  name);
            }

            public AzureDlsAccountNetworkRuleUpdateTask DlsAccountNetworkRuleUpdate(string accountName ,  string name ,  string subnet)
            {
                return new AzureDlsAccountNetworkRuleUpdateTask(accountName,  name,  subnet);
            }

            public AzureDlsAccountTrustedProviderTask DlsAccountTrustedProvider()
            {
                return new AzureDlsAccountTrustedProviderTask();
            }

            public AzureDlsAccountTrustedProviderCreateTask DlsAccountTrustedProviderCreate(string account ,  string idProvider ,  string trustedIdProviderName)
            {
                return new AzureDlsAccountTrustedProviderCreateTask(account,  idProvider,  trustedIdProviderName);
            }

            public AzureDlsAccountTrustedProviderDeleteTask DlsAccountTrustedProviderDelete(string account ,  string trustedIdProviderName)
            {
                return new AzureDlsAccountTrustedProviderDeleteTask(account,  trustedIdProviderName);
            }

            public AzureDlsAccountTrustedProviderUpdateTask DlsAccountTrustedProviderUpdate(string account ,  string trustedIdProviderName)
            {
                return new AzureDlsAccountTrustedProviderUpdateTask(account,  trustedIdProviderName);
            }

            public AzureDlsFsAccessTask DlsFsAccess()
            {
                return new AzureDlsFsAccessTask();
            }

            public AzureDlsFsAccessRemoveAllTask DlsFsAccessRemoveAll(string account ,  string path)
            {
                return new AzureDlsFsAccessRemoveAllTask(account,  path);
            }

            public AzureDlsFsAccessRemoveEntryTask DlsFsAccessRemoveEntry(string account ,  string aclSpec ,  string path)
            {
                return new AzureDlsFsAccessRemoveEntryTask(account,  aclSpec,  path);
            }

            public AzureDlsFsAccessSetTask DlsFsAccessSet(string account ,  string aclSpec ,  string path)
            {
                return new AzureDlsFsAccessSetTask(account,  aclSpec,  path);
            }

            public AzureDlsFsAccessSetEntryTask DlsFsAccessSetEntry(string account ,  string aclSpec ,  string path)
            {
                return new AzureDlsFsAccessSetEntryTask(account,  aclSpec,  path);
            }

            public AzureDlsFsAccessSetOwnerTask DlsFsAccessSetOwner(string account ,  string path)
            {
                return new AzureDlsFsAccessSetOwnerTask(account,  path);
            }

            public AzureDlsFsAccessSetPermissionTask DlsFsAccessSetPermission(string account ,  string path ,  string permission)
            {
                return new AzureDlsFsAccessSetPermissionTask(account,  path,  permission);
            }
        
    }
}

