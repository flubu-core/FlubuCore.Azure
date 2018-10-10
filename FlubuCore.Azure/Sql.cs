
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Sql;

namespace FlubuCore.Azure
{
    public class Sql
    {
        
        
            public AzureSqlDbTask SqlDb()
            {
                return new AzureSqlDbTask();
            }

            public AzureSqlDbCopyTask SqlDbCopy(string destName ,  string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlDbCopyTask(destName,  name,  resourceGroup,  server);
            }

            public AzureSqlDbCreateTask SqlDbCreate(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlDbCreateTask(name,  resourceGroup,  server);
            }

            public AzureSqlDbDeleteTask SqlDbDelete(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlDbDeleteTask(name,  resourceGroup,  server);
            }

            public AzureSqlDbExportTask SqlDbExport(string adminPassword ,  string adminUser ,  string name ,  string resourceGroup ,  string server ,  string storageKey ,  string storageKeyType ,  string storageUri)
            {
                return new AzureSqlDbExportTask(adminPassword,  adminUser,  name,  resourceGroup,  server,  storageKey,  storageKeyType,  storageUri);
            }

            public AzureSqlDbImportTask SqlDbImport(string adminPassword ,  string adminUser ,  string name ,  string resourceGroup ,  string server ,  string storageKey ,  string storageKeyType ,  string storageUri)
            {
                return new AzureSqlDbImportTask(adminPassword,  adminUser,  name,  resourceGroup,  server,  storageKey,  storageKeyType,  storageUri);
            }

            public AzureSqlDbRenameTask SqlDbRename(string name ,  string newName ,  string resourceGroup ,  string server)
            {
                return new AzureSqlDbRenameTask(name,  newName,  resourceGroup,  server);
            }

            public AzureSqlDbRestoreTask SqlDbRestore(string destName ,  string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlDbRestoreTask(destName,  name,  resourceGroup,  server);
            }

            public AzureSqlDbUpdateTask SqlDbUpdate(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlDbUpdateTask(name,  resourceGroup,  server);
            }

            public AzureSqlDwTask SqlDw()
            {
                return new AzureSqlDwTask();
            }

            public AzureSqlDwCreateTask SqlDwCreate(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlDwCreateTask(name,  resourceGroup,  server);
            }

            public AzureSqlDwDeleteTask SqlDwDelete(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlDwDeleteTask(name,  resourceGroup,  server);
            }

            public AzureSqlDwPauseTask SqlDwPause(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlDwPauseTask(name,  resourceGroup,  server);
            }

            public AzureSqlDwResumeTask SqlDwResume(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlDwResumeTask(name,  resourceGroup,  server);
            }

            public AzureSqlDwUpdateTask SqlDwUpdate(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlDwUpdateTask(name,  resourceGroup,  server);
            }

            public AzureSqlElasticPoolTask SqlElasticPool()
            {
                return new AzureSqlElasticPoolTask();
            }

            public AzureSqlElasticPoolCreateTask SqlElasticPoolCreate(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlElasticPoolCreateTask(name,  resourceGroup,  server);
            }

            public AzureSqlElasticPoolDeleteTask SqlElasticPoolDelete(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlElasticPoolDeleteTask(name,  resourceGroup,  server);
            }

            public AzureSqlElasticPoolUpdateTask SqlElasticPoolUpdate(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlElasticPoolUpdateTask(name,  resourceGroup,  server);
            }

            public AzureSqlFailoverGroupTask SqlFailoverGroup()
            {
                return new AzureSqlFailoverGroupTask();
            }

            public AzureSqlFailoverGroupCreateTask SqlFailoverGroupCreate(string name ,  string partnerServer ,  string resourceGroup ,  string server)
            {
                return new AzureSqlFailoverGroupCreateTask(name,  partnerServer,  resourceGroup,  server);
            }

            public AzureSqlFailoverGroupDeleteTask SqlFailoverGroupDelete(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlFailoverGroupDeleteTask(name,  resourceGroup,  server);
            }

            public AzureSqlFailoverGroupSetPrimaryTask SqlFailoverGroupSetPrimary(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlFailoverGroupSetPrimaryTask(name,  resourceGroup,  server);
            }

            public AzureSqlFailoverGroupUpdateTask SqlFailoverGroupUpdate(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlFailoverGroupUpdateTask(name,  resourceGroup,  server);
            }

            public AzureSqlMiTask SqlMi()
            {
                return new AzureSqlMiTask();
            }

            public AzureSqlMiCreateTask SqlMiCreate(string adminPassword ,  string adminUser ,  string location ,  string name ,  string resourceGroup ,  string subnet)
            {
                return new AzureSqlMiCreateTask(adminPassword,  adminUser,  location,  name,  resourceGroup,  subnet);
            }

            public AzureSqlMiDeleteTask SqlMiDelete(string name ,  string resourceGroup)
            {
                return new AzureSqlMiDeleteTask(name,  resourceGroup);
            }

            public AzureSqlMiUpdateTask SqlMiUpdate(string name ,  string resourceGroup)
            {
                return new AzureSqlMiUpdateTask(name,  resourceGroup);
            }

            public AzureSqlMidbTask SqlMidb()
            {
                return new AzureSqlMidbTask();
            }

            public AzureSqlMidbCreateTask SqlMidbCreate(string managedInstance ,  string name ,  string resourceGroup)
            {
                return new AzureSqlMidbCreateTask(managedInstance,  name,  resourceGroup);
            }

            public AzureSqlMidbDeleteTask SqlMidbDelete(string managedInstance ,  string name ,  string resourceGroup)
            {
                return new AzureSqlMidbDeleteTask(managedInstance,  name,  resourceGroup);
            }

            public AzureSqlMidbRestoreTask SqlMidbRestore(string destName ,  string managedInstance ,  string name ,  string resourceGroup ,  string time)
            {
                return new AzureSqlMidbRestoreTask(destName,  managedInstance,  name,  resourceGroup,  time);
            }

            public AzureSqlServerTask SqlServer()
            {
                return new AzureSqlServerTask();
            }

            public AzureSqlServerCreateTask SqlServerCreate(string adminPassword ,  string adminUser ,  string location ,  string name ,  string resourceGroup)
            {
                return new AzureSqlServerCreateTask(adminPassword,  adminUser,  location,  name,  resourceGroup);
            }

            public AzureSqlServerDeleteTask SqlServerDelete(string name ,  string resourceGroup)
            {
                return new AzureSqlServerDeleteTask(name,  resourceGroup);
            }

            public AzureSqlServerUpdateTask SqlServerUpdate(string name ,  string resourceGroup)
            {
                return new AzureSqlServerUpdateTask(name,  resourceGroup);
            }

            public AzureSqlDbAuditPolicyTask SqlDbAuditPolicy()
            {
                return new AzureSqlDbAuditPolicyTask();
            }

            public AzureSqlDbAuditPolicyUpdateTask SqlDbAuditPolicyUpdate(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlDbAuditPolicyUpdateTask(name,  resourceGroup,  server);
            }

            public AzureSqlDbOpTask SqlDbOp()
            {
                return new AzureSqlDbOpTask();
            }

            public AzureSqlDbOpCancelTask SqlDbOpCancel(string database ,  string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlDbOpCancelTask(database,  name,  resourceGroup,  server);
            }

            public AzureSqlDbReplicaTask SqlDbReplica()
            {
                return new AzureSqlDbReplicaTask();
            }

            public AzureSqlDbReplicaCreateTask SqlDbReplicaCreate(string name ,  string partnerServer ,  string resourceGroup ,  string server)
            {
                return new AzureSqlDbReplicaCreateTask(name,  partnerServer,  resourceGroup,  server);
            }

            public AzureSqlDbReplicaDeleteLinkTask SqlDbReplicaDeleteLink(string name ,  string partnerServer ,  string resourceGroup ,  string server)
            {
                return new AzureSqlDbReplicaDeleteLinkTask(name,  partnerServer,  resourceGroup,  server);
            }

            public AzureSqlDbReplicaSetPrimaryTask SqlDbReplicaSetPrimary(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlDbReplicaSetPrimaryTask(name,  resourceGroup,  server);
            }

            public AzureSqlDbTdeTask SqlDbTde()
            {
                return new AzureSqlDbTdeTask();
            }

            public AzureSqlDbTdeSetTask SqlDbTdeSet(string database ,  string resourceGroup ,  string server ,  string status)
            {
                return new AzureSqlDbTdeSetTask(database,  resourceGroup,  server,  status);
            }

            public AzureSqlDbThreatPolicyTask SqlDbThreatPolicy()
            {
                return new AzureSqlDbThreatPolicyTask();
            }

            public AzureSqlDbThreatPolicyUpdateTask SqlDbThreatPolicyUpdate(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlDbThreatPolicyUpdateTask(name,  resourceGroup,  server);
            }

            public AzureSqlElasticPoolOpTask SqlElasticPoolOp()
            {
                return new AzureSqlElasticPoolOpTask();
            }

            public AzureSqlElasticPoolOpCancelTask SqlElasticPoolOpCancel(string elasticPool ,  string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlElasticPoolOpCancelTask(elasticPool,  name,  resourceGroup,  server);
            }

            public AzureSqlServerAdAdminTask SqlServerAdAdmin()
            {
                return new AzureSqlServerAdAdminTask();
            }

            public AzureSqlServerAdAdminCreateTask SqlServerAdAdminCreate(string displayName ,  string objectId ,  string resourceGroup ,  string server)
            {
                return new AzureSqlServerAdAdminCreateTask(displayName,  objectId,  resourceGroup,  server);
            }

            public AzureSqlServerAdAdminDeleteTask SqlServerAdAdminDelete(string resourceGroup ,  string server)
            {
                return new AzureSqlServerAdAdminDeleteTask(resourceGroup,  server);
            }

            public AzureSqlServerAdAdminUpdateTask SqlServerAdAdminUpdate(string resourceGroup ,  string server)
            {
                return new AzureSqlServerAdAdminUpdateTask(resourceGroup,  server);
            }

            public AzureSqlServerConnPolicyTask SqlServerConnPolicy()
            {
                return new AzureSqlServerConnPolicyTask();
            }

            public AzureSqlServerConnPolicyUpdateTask SqlServerConnPolicyUpdate(string connectionType ,  string resourceGroup ,  string server)
            {
                return new AzureSqlServerConnPolicyUpdateTask(connectionType,  resourceGroup,  server);
            }

            public AzureSqlServerDnsAliasTask SqlServerDnsAlias()
            {
                return new AzureSqlServerDnsAliasTask();
            }

            public AzureSqlServerDnsAliasCreateTask SqlServerDnsAliasCreate(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlServerDnsAliasCreateTask(name,  resourceGroup,  server);
            }

            public AzureSqlServerDnsAliasDeleteTask SqlServerDnsAliasDelete(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlServerDnsAliasDeleteTask(name,  resourceGroup,  server);
            }

            public AzureSqlServerDnsAliasSetTask SqlServerDnsAliasSet(string name ,  string originalServer ,  string resourceGroup ,  string server)
            {
                return new AzureSqlServerDnsAliasSetTask(name,  originalServer,  resourceGroup,  server);
            }

            public AzureSqlServerFirewallRuleTask SqlServerFirewallRule()
            {
                return new AzureSqlServerFirewallRuleTask();
            }

            public AzureSqlServerFirewallRuleCreateTask SqlServerFirewallRuleCreate(string endIpAddress ,  string name ,  string resourceGroup ,  string server ,  string startIpAddress)
            {
                return new AzureSqlServerFirewallRuleCreateTask(endIpAddress,  name,  resourceGroup,  server,  startIpAddress);
            }

            public AzureSqlServerFirewallRuleDeleteTask SqlServerFirewallRuleDelete(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlServerFirewallRuleDeleteTask(name,  resourceGroup,  server);
            }

            public AzureSqlServerFirewallRuleUpdateTask SqlServerFirewallRuleUpdate(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlServerFirewallRuleUpdateTask(name,  resourceGroup,  server);
            }

            public AzureSqlServerKeyTask SqlServerKey()
            {
                return new AzureSqlServerKeyTask();
            }

            public AzureSqlServerKeyCreateTask SqlServerKeyCreate(string kid ,  string resourceGroup ,  string server)
            {
                return new AzureSqlServerKeyCreateTask(kid,  resourceGroup,  server);
            }

            public AzureSqlServerKeyDeleteTask SqlServerKeyDelete(string kid ,  string resourceGroup ,  string server)
            {
                return new AzureSqlServerKeyDeleteTask(kid,  resourceGroup,  server);
            }

            public AzureSqlServerTdeKeyTask SqlServerTdeKey()
            {
                return new AzureSqlServerTdeKeyTask();
            }

            public AzureSqlServerTdeKeySetTask SqlServerTdeKeySet(string resourceGroup ,  string server ,  string serverKeyType)
            {
                return new AzureSqlServerTdeKeySetTask(resourceGroup,  server,  serverKeyType);
            }

            public AzureSqlServerVnetRuleTask SqlServerVnetRule()
            {
                return new AzureSqlServerVnetRuleTask();
            }

            public AzureSqlServerVnetRuleCreateTask SqlServerVnetRuleCreate(string name ,  string resourceGroup ,  string server ,  string subnet)
            {
                return new AzureSqlServerVnetRuleCreateTask(name,  resourceGroup,  server,  subnet);
            }

            public AzureSqlServerVnetRuleDeleteTask SqlServerVnetRuleDelete(string name ,  string resourceGroup ,  string server)
            {
                return new AzureSqlServerVnetRuleDeleteTask(name,  resourceGroup,  server);
            }

            public AzureSqlServerVnetRuleUpdateTask SqlServerVnetRuleUpdate(string name ,  string resourceGroup ,  string server ,  string subnet)
            {
                return new AzureSqlServerVnetRuleUpdateTask(name,  resourceGroup,  server,  subnet);
            }
        
    }
}

