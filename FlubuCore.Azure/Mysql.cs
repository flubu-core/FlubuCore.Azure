
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Mysql;

namespace FlubuCore.Azure
{
    public class Mysql
    {
        
        
            public AzureMysqlServerTask MysqlServer()
            {
                return new AzureMysqlServerTask();
            }

            public AzureMysqlServerVnetRuleTask MysqlServerVnetRule()
            {
                return new AzureMysqlServerVnetRuleTask();
            }

            public AzureMysqlServerVnetRuleCreateTask MysqlServerVnetRuleCreate(string name ,  string resourceGroup ,  string serverName ,  string subnet)
            {
                return new AzureMysqlServerVnetRuleCreateTask(name,  resourceGroup,  serverName,  subnet);
            }

            public AzureMysqlServerVnetRuleDeleteTask MysqlServerVnetRuleDelete(string name ,  string resourceGroup ,  string serverName)
            {
                return new AzureMysqlServerVnetRuleDeleteTask(name,  resourceGroup,  serverName);
            }

            public AzureMysqlServerVnetRuleUpdateTask MysqlServerVnetRuleUpdate(string name ,  string resourceGroup ,  string serverName ,  string subnet)
            {
                return new AzureMysqlServerVnetRuleUpdateTask(name,  resourceGroup,  serverName,  subnet);
            }

            public AzureMysqlDbTask MysqlDb()
            {
                return new AzureMysqlDbTask();
            }

            public AzureMysqlDbCreateTask MysqlDbCreate(string name ,  string resourceGroup ,  string serverName)
            {
                return new AzureMysqlDbCreateTask(name,  resourceGroup,  serverName);
            }

            public AzureMysqlDbDeleteTask MysqlDbDelete(string name ,  string resourceGroup ,  string serverName)
            {
                return new AzureMysqlDbDeleteTask(name,  resourceGroup,  serverName);
            }

            public AzureMysqlServerLogsTask MysqlServerLogs()
            {
                return new AzureMysqlServerLogsTask();
            }

            public AzureMysqlServerLogsDownloadTask MysqlServerLogsDownload(string name ,  string resourceGroup ,  string serverName)
            {
                return new AzureMysqlServerLogsDownloadTask(name,  resourceGroup,  serverName);
            }

            public AzureMysqlServerCreateTask MysqlServerCreate(string name ,  string resourceGroup ,  string skuName ,  string adminUser)
            {
                return new AzureMysqlServerCreateTask(name,  resourceGroup,  skuName,  adminUser);
            }

            public AzureMysqlServerDeleteTask MysqlServerDelete(string name ,  string resourceGroup)
            {
                return new AzureMysqlServerDeleteTask(name,  resourceGroup);
            }

            public AzureMysqlServerGeorestoreTask MysqlServerGeorestore(string location ,  string name ,  string resourceGroup ,  string sourceServer)
            {
                return new AzureMysqlServerGeorestoreTask(location,  name,  resourceGroup,  sourceServer);
            }

            public AzureMysqlServerRestoreTask MysqlServerRestore(string name ,  string resourceGroup ,  string restorePointInTime ,  string sourceServer)
            {
                return new AzureMysqlServerRestoreTask(name,  resourceGroup,  restorePointInTime,  sourceServer);
            }

            public AzureMysqlServerUpdateTask MysqlServerUpdate(string name ,  string resourceGroup)
            {
                return new AzureMysqlServerUpdateTask(name,  resourceGroup);
            }

            public AzureMysqlServerWaitTask MysqlServerWait(string name ,  string resourceGroup)
            {
                return new AzureMysqlServerWaitTask(name,  resourceGroup);
            }

            public AzureMysqlServerConfigurationTask MysqlServerConfiguration()
            {
                return new AzureMysqlServerConfigurationTask();
            }

            public AzureMysqlServerConfigurationSetTask MysqlServerConfigurationSet(string name ,  string resourceGroup ,  string serverName)
            {
                return new AzureMysqlServerConfigurationSetTask(name,  resourceGroup,  serverName);
            }

            public AzureMysqlServerFirewallRuleTask MysqlServerFirewallRule()
            {
                return new AzureMysqlServerFirewallRuleTask();
            }

            public AzureMysqlServerFirewallRuleCreateTask MysqlServerFirewallRuleCreate(string endIpAddress ,  string name ,  string resourceGroup ,  string serverName ,  string startIpAddress)
            {
                return new AzureMysqlServerFirewallRuleCreateTask(endIpAddress,  name,  resourceGroup,  serverName,  startIpAddress);
            }

            public AzureMysqlServerFirewallRuleDeleteTask MysqlServerFirewallRuleDelete(string name ,  string resourceGroup ,  string serverName)
            {
                return new AzureMysqlServerFirewallRuleDeleteTask(name,  resourceGroup,  serverName);
            }

            public AzureMysqlServerFirewallRuleUpdateTask MysqlServerFirewallRuleUpdate(string name ,  string resourceGroup ,  string serverName)
            {
                return new AzureMysqlServerFirewallRuleUpdateTask(name,  resourceGroup,  serverName);
            }
        
    }
}

