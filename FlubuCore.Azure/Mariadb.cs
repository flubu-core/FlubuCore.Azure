
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Mariadb;

namespace FlubuCore.Azure
{
    public class Mariadb
    {
        
        
            public AzureMariadbDbTask MariadbDb()
            {
                return new AzureMariadbDbTask();
            }

            public AzureMariadbDbCreateTask MariadbDbCreate(string name ,  string resourceGroup ,  string serverName)
            {
                return new AzureMariadbDbCreateTask(name,  resourceGroup,  serverName);
            }

            public AzureMariadbDbDeleteTask MariadbDbDelete(string name ,  string resourceGroup ,  string serverName)
            {
                return new AzureMariadbDbDeleteTask(name,  resourceGroup,  serverName);
            }

            public AzureMariadbServerLogsTask MariadbServerLogs()
            {
                return new AzureMariadbServerLogsTask();
            }

            public AzureMariadbServerLogsDownloadTask MariadbServerLogsDownload(string name ,  string resourceGroup ,  string serverName)
            {
                return new AzureMariadbServerLogsDownloadTask(name,  resourceGroup,  serverName);
            }

            public AzureMariadbServerTask MariadbServer()
            {
                return new AzureMariadbServerTask();
            }

            public AzureMariadbServerCreateTask MariadbServerCreate(string name ,  string resourceGroup ,  string skuName ,  string adminUser)
            {
                return new AzureMariadbServerCreateTask(name,  resourceGroup,  skuName,  adminUser);
            }

            public AzureMariadbServerDeleteTask MariadbServerDelete(string name ,  string resourceGroup)
            {
                return new AzureMariadbServerDeleteTask(name,  resourceGroup);
            }

            public AzureMariadbServerGeorestoreTask MariadbServerGeorestore(string location ,  string name ,  string resourceGroup ,  string sourceServer)
            {
                return new AzureMariadbServerGeorestoreTask(location,  name,  resourceGroup,  sourceServer);
            }

            public AzureMariadbServerRestoreTask MariadbServerRestore(string name ,  string resourceGroup ,  string restorePointInTime ,  string sourceServer)
            {
                return new AzureMariadbServerRestoreTask(name,  resourceGroup,  restorePointInTime,  sourceServer);
            }

            public AzureMariadbServerUpdateTask MariadbServerUpdate(string name ,  string resourceGroup)
            {
                return new AzureMariadbServerUpdateTask(name,  resourceGroup);
            }

            public AzureMariadbServerWaitTask MariadbServerWait(string name ,  string resourceGroup)
            {
                return new AzureMariadbServerWaitTask(name,  resourceGroup);
            }

            public AzureMariadbServerConfigurationTask MariadbServerConfiguration()
            {
                return new AzureMariadbServerConfigurationTask();
            }

            public AzureMariadbServerConfigurationSetTask MariadbServerConfigurationSet(string name ,  string resourceGroup ,  string serverName)
            {
                return new AzureMariadbServerConfigurationSetTask(name,  resourceGroup,  serverName);
            }

            public AzureMariadbServerFirewallRuleTask MariadbServerFirewallRule()
            {
                return new AzureMariadbServerFirewallRuleTask();
            }

            public AzureMariadbServerFirewallRuleCreateTask MariadbServerFirewallRuleCreate(string endIpAddress ,  string name ,  string resourceGroup ,  string serverName ,  string startIpAddress)
            {
                return new AzureMariadbServerFirewallRuleCreateTask(endIpAddress,  name,  resourceGroup,  serverName,  startIpAddress);
            }

            public AzureMariadbServerFirewallRuleDeleteTask MariadbServerFirewallRuleDelete(string name ,  string resourceGroup ,  string serverName)
            {
                return new AzureMariadbServerFirewallRuleDeleteTask(name,  resourceGroup,  serverName);
            }

            public AzureMariadbServerFirewallRuleUpdateTask MariadbServerFirewallRuleUpdate(string name ,  string resourceGroup ,  string serverName)
            {
                return new AzureMariadbServerFirewallRuleUpdateTask(name,  resourceGroup,  serverName);
            }
        
    }
}

