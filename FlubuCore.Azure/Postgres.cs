
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Postgres;

namespace FlubuCore.Azure
{
    public class Postgres
    {
        
        
            public AzurePostgresServerTask PostgresServer()
            {
                return new AzurePostgresServerTask();
            }

            public AzurePostgresServerVnetRuleTask PostgresServerVnetRule()
            {
                return new AzurePostgresServerVnetRuleTask();
            }

            public AzurePostgresServerVnetRuleCreateTask PostgresServerVnetRuleCreate(string name ,  string resourceGroup ,  string serverName ,  string subnet)
            {
                return new AzurePostgresServerVnetRuleCreateTask(name,  resourceGroup,  serverName,  subnet);
            }

            public AzurePostgresServerVnetRuleDeleteTask PostgresServerVnetRuleDelete(string name ,  string resourceGroup ,  string serverName)
            {
                return new AzurePostgresServerVnetRuleDeleteTask(name,  resourceGroup,  serverName);
            }

            public AzurePostgresServerVnetRuleUpdateTask PostgresServerVnetRuleUpdate(string name ,  string resourceGroup ,  string serverName ,  string subnet)
            {
                return new AzurePostgresServerVnetRuleUpdateTask(name,  resourceGroup,  serverName,  subnet);
            }

            public AzurePostgresDbTask PostgresDb()
            {
                return new AzurePostgresDbTask();
            }

            public AzurePostgresDbCreateTask PostgresDbCreate(string name ,  string resourceGroup ,  string serverName)
            {
                return new AzurePostgresDbCreateTask(name,  resourceGroup,  serverName);
            }

            public AzurePostgresDbDeleteTask PostgresDbDelete(string name ,  string resourceGroup ,  string serverName)
            {
                return new AzurePostgresDbDeleteTask(name,  resourceGroup,  serverName);
            }

            public AzurePostgresServerLogsTask PostgresServerLogs()
            {
                return new AzurePostgresServerLogsTask();
            }

            public AzurePostgresServerLogsDownloadTask PostgresServerLogsDownload(string name ,  string resourceGroup ,  string serverName)
            {
                return new AzurePostgresServerLogsDownloadTask(name,  resourceGroup,  serverName);
            }

            public AzurePostgresServerCreateTask PostgresServerCreate(string name ,  string resourceGroup ,  string skuName ,  string adminUser)
            {
                return new AzurePostgresServerCreateTask(name,  resourceGroup,  skuName,  adminUser);
            }

            public AzurePostgresServerDeleteTask PostgresServerDelete(string name ,  string resourceGroup)
            {
                return new AzurePostgresServerDeleteTask(name,  resourceGroup);
            }

            public AzurePostgresServerGeorestoreTask PostgresServerGeorestore(string location ,  string name ,  string resourceGroup ,  string sourceServer)
            {
                return new AzurePostgresServerGeorestoreTask(location,  name,  resourceGroup,  sourceServer);
            }

            public AzurePostgresServerRestoreTask PostgresServerRestore(string name ,  string resourceGroup ,  string restorePointInTime ,  string sourceServer)
            {
                return new AzurePostgresServerRestoreTask(name,  resourceGroup,  restorePointInTime,  sourceServer);
            }

            public AzurePostgresServerUpdateTask PostgresServerUpdate(string name ,  string resourceGroup)
            {
                return new AzurePostgresServerUpdateTask(name,  resourceGroup);
            }

            public AzurePostgresServerWaitTask PostgresServerWait(string name ,  string resourceGroup)
            {
                return new AzurePostgresServerWaitTask(name,  resourceGroup);
            }

            public AzurePostgresServerConfigurationTask PostgresServerConfiguration()
            {
                return new AzurePostgresServerConfigurationTask();
            }

            public AzurePostgresServerConfigurationSetTask PostgresServerConfigurationSet(string name ,  string resourceGroup ,  string serverName)
            {
                return new AzurePostgresServerConfigurationSetTask(name,  resourceGroup,  serverName);
            }

            public AzurePostgresServerFirewallRuleTask PostgresServerFirewallRule()
            {
                return new AzurePostgresServerFirewallRuleTask();
            }

            public AzurePostgresServerFirewallRuleCreateTask PostgresServerFirewallRuleCreate(string endIpAddress ,  string name ,  string resourceGroup ,  string serverName ,  string startIpAddress)
            {
                return new AzurePostgresServerFirewallRuleCreateTask(endIpAddress,  name,  resourceGroup,  serverName,  startIpAddress);
            }

            public AzurePostgresServerFirewallRuleDeleteTask PostgresServerFirewallRuleDelete(string name ,  string resourceGroup ,  string serverName)
            {
                return new AzurePostgresServerFirewallRuleDeleteTask(name,  resourceGroup,  serverName);
            }

            public AzurePostgresServerFirewallRuleUpdateTask PostgresServerFirewallRuleUpdate(string name ,  string resourceGroup ,  string serverName)
            {
                return new AzurePostgresServerFirewallRuleUpdateTask(name,  resourceGroup,  serverName);
            }
        
    }
}

