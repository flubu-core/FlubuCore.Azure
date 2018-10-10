
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Monitor;

namespace FlubuCore.Azure
{
    public class Monitor
    {
        
        
            public AzureMonitorLogAnalyticsTask MonitorLogAnalytics()
            {
                return new AzureMonitorLogAnalyticsTask();
            }

            public AzureMonitorLogAnalyticsQueryTask MonitorLogAnalyticsQuery(string analyticsQuery ,  string workspace)
            {
                return new AzureMonitorLogAnalyticsQueryTask(analyticsQuery,  workspace);
            }

            public AzureMonitorActionGroupTask MonitorActionGroup()
            {
                return new AzureMonitorActionGroupTask();
            }

            public AzureMonitorActionGroupCreateTask MonitorActionGroupCreate(string name ,  string resourceGroup)
            {
                return new AzureMonitorActionGroupCreateTask(name,  resourceGroup);
            }

            public AzureMonitorActionGroupDeleteTask MonitorActionGroupDelete(string name ,  string resourceGroup)
            {
                return new AzureMonitorActionGroupDeleteTask(name,  resourceGroup);
            }

            public AzureMonitorActionGroupEnableReceiverTask MonitorActionGroupEnableReceiver(string actionGroup ,  string name ,  string resourceGroup)
            {
                return new AzureMonitorActionGroupEnableReceiverTask(actionGroup,  name,  resourceGroup);
            }

            public AzureMonitorActionGroupUpdateTask MonitorActionGroupUpdate(string name ,  string resourceGroup)
            {
                return new AzureMonitorActionGroupUpdateTask(name,  resourceGroup);
            }

            public AzureMonitorActivityLogTask MonitorActivityLog()
            {
                return new AzureMonitorActivityLogTask();
            }

            public AzureMonitorAlertTask MonitorAlert()
            {
                return new AzureMonitorAlertTask();
            }

            public AzureMonitorAlertCreateTask MonitorAlertCreate(string condition ,  string name ,  string target)
            {
                return new AzureMonitorAlertCreateTask(condition,  name,  target);
            }

            public AzureMonitorAlertDeleteTask MonitorAlertDelete(string name ,  string resourceGroup)
            {
                return new AzureMonitorAlertDeleteTask(name,  resourceGroup);
            }

            public AzureMonitorAlertUpdateTask MonitorAlertUpdate(string name)
            {
                return new AzureMonitorAlertUpdateTask(name);
            }

            public AzureMonitorAutoscaleSettingsTask MonitorAutoscaleSettings()
            {
                return new AzureMonitorAutoscaleSettingsTask();
            }

            public AzureMonitorAutoscaleSettingsCreateTask MonitorAutoscaleSettingsCreate(string name ,  string parameters ,  string resourceGroup)
            {
                return new AzureMonitorAutoscaleSettingsCreateTask(name,  parameters,  resourceGroup);
            }

            public AzureMonitorAutoscaleSettingsDeleteTask MonitorAutoscaleSettingsDelete(string name ,  string resourceGroup)
            {
                return new AzureMonitorAutoscaleSettingsDeleteTask(name,  resourceGroup);
            }

            public AzureMonitorAutoscaleSettingsGetParametersTemplateTask MonitorAutoscaleSettingsGetParametersTemplate()
            {
                return new AzureMonitorAutoscaleSettingsGetParametersTemplateTask();
            }

            public AzureMonitorAutoscaleSettingsUpdateTask MonitorAutoscaleSettingsUpdate(string name ,  string resourceGroup)
            {
                return new AzureMonitorAutoscaleSettingsUpdateTask(name,  resourceGroup);
            }

            public AzureMonitorAutoscaleTask MonitorAutoscale()
            {
                return new AzureMonitorAutoscaleTask();
            }

            public AzureMonitorAutoscaleCreateTask MonitorAutoscaleCreate(string count ,  string resource)
            {
                return new AzureMonitorAutoscaleCreateTask(count,  resource);
            }

            public AzureMonitorAutoscaleDeleteTask MonitorAutoscaleDelete(string name ,  string resourceGroup)
            {
                return new AzureMonitorAutoscaleDeleteTask(name,  resourceGroup);
            }

            public AzureMonitorAutoscaleUpdateTask MonitorAutoscaleUpdate(string name ,  string resourceGroup)
            {
                return new AzureMonitorAutoscaleUpdateTask(name,  resourceGroup);
            }

            public AzureMonitorDiagnosticSettingsTask MonitorDiagnosticSettings()
            {
                return new AzureMonitorDiagnosticSettingsTask();
            }

            public AzureMonitorDiagnosticSettingsCreateTask MonitorDiagnosticSettingsCreate(string name ,  string resource)
            {
                return new AzureMonitorDiagnosticSettingsCreateTask(name,  resource);
            }

            public AzureMonitorDiagnosticSettingsDeleteTask MonitorDiagnosticSettingsDelete(string name ,  string resource)
            {
                return new AzureMonitorDiagnosticSettingsDeleteTask(name,  resource);
            }

            public AzureMonitorDiagnosticSettingsUpdateTask MonitorDiagnosticSettingsUpdate(string name ,  string resource)
            {
                return new AzureMonitorDiagnosticSettingsUpdateTask(name,  resource);
            }

            public AzureMonitorLogProfilesTask MonitorLogProfiles()
            {
                return new AzureMonitorLogProfilesTask();
            }

            public AzureMonitorLogProfilesCreateTask MonitorLogProfilesCreate(string categories ,  string location ,  string locations ,  string name ,  string days ,  string enabled)
            {
                return new AzureMonitorLogProfilesCreateTask(categories,  location,  locations,  name,  days,  enabled);
            }

            public AzureMonitorLogProfilesDeleteTask MonitorLogProfilesDelete(string name)
            {
                return new AzureMonitorLogProfilesDeleteTask(name);
            }

            public AzureMonitorLogProfilesUpdateTask MonitorLogProfilesUpdate(string name)
            {
                return new AzureMonitorLogProfilesUpdateTask(name);
            }

            public AzureMonitorMetricsTask MonitorMetrics()
            {
                return new AzureMonitorMetricsTask();
            }

            public AzureMonitorActivityLogAlertTask MonitorActivityLogAlert()
            {
                return new AzureMonitorActivityLogAlertTask();
            }

            public AzureMonitorActivityLogAlertCreateTask MonitorActivityLogAlertCreate(string name ,  string resourceGroup)
            {
                return new AzureMonitorActivityLogAlertCreateTask(name,  resourceGroup);
            }

            public AzureMonitorActivityLogAlertDeleteTask MonitorActivityLogAlertDelete(string name ,  string resourceGroup)
            {
                return new AzureMonitorActivityLogAlertDeleteTask(name,  resourceGroup);
            }

            public AzureMonitorActivityLogAlertUpdateTask MonitorActivityLogAlertUpdate(string name ,  string resourceGroup)
            {
                return new AzureMonitorActivityLogAlertUpdateTask(name,  resourceGroup);
            }

            public AzureMonitorActivityLogAlertActionGroupTask MonitorActivityLogAlertActionGroup()
            {
                return new AzureMonitorActivityLogAlertActionGroupTask();
            }

            public AzureMonitorActivityLogAlertActionGroupAddTask MonitorActivityLogAlertActionGroupAdd(string actionGroup ,  string name ,  string resourceGroup)
            {
                return new AzureMonitorActivityLogAlertActionGroupAddTask(actionGroup,  name,  resourceGroup);
            }

            public AzureMonitorActivityLogAlertActionGroupRemoveTask MonitorActivityLogAlertActionGroupRemove(string actionGroup ,  string name ,  string resourceGroup)
            {
                return new AzureMonitorActivityLogAlertActionGroupRemoveTask(actionGroup,  name,  resourceGroup);
            }

            public AzureMonitorActivityLogAlertScopeTask MonitorActivityLogAlertScope()
            {
                return new AzureMonitorActivityLogAlertScopeTask();
            }

            public AzureMonitorActivityLogAlertScopeAddTask MonitorActivityLogAlertScopeAdd(string name ,  string resourceGroup ,  string scope)
            {
                return new AzureMonitorActivityLogAlertScopeAddTask(name,  resourceGroup,  scope);
            }

            public AzureMonitorActivityLogAlertScopeRemoveTask MonitorActivityLogAlertScopeRemove(string name ,  string resourceGroup ,  string scope)
            {
                return new AzureMonitorActivityLogAlertScopeRemoveTask(name,  resourceGroup,  scope);
            }

            public AzureMonitorAutoscaleProfileTask MonitorAutoscaleProfile()
            {
                return new AzureMonitorAutoscaleProfileTask();
            }

            public AzureMonitorAutoscaleProfileCreateTask MonitorAutoscaleProfileCreate(string autoscaleName ,  string name ,  string resourceGroup ,  string count ,  string timezone)
            {
                return new AzureMonitorAutoscaleProfileCreateTask(autoscaleName,  name,  resourceGroup,  count,  timezone);
            }

            public AzureMonitorAutoscaleProfileDeleteTask MonitorAutoscaleProfileDelete(string autoscaleName ,  string name ,  string resourceGroup)
            {
                return new AzureMonitorAutoscaleProfileDeleteTask(autoscaleName,  name,  resourceGroup);
            }

            public AzureMonitorAutoscaleRuleTask MonitorAutoscaleRule()
            {
                return new AzureMonitorAutoscaleRuleTask();
            }

            public AzureMonitorAutoscaleRuleCopyTask MonitorAutoscaleRuleCopy(string autoscaleName ,  string destSchedule ,  string index ,  string resourceGroup)
            {
                return new AzureMonitorAutoscaleRuleCopyTask(autoscaleName,  destSchedule,  index,  resourceGroup);
            }

            public AzureMonitorAutoscaleRuleCreateTask MonitorAutoscaleRuleCreate(string autoscaleName ,  string condition ,  string scale)
            {
                return new AzureMonitorAutoscaleRuleCreateTask(autoscaleName,  condition,  scale);
            }

            public AzureMonitorAutoscaleRuleDeleteTask MonitorAutoscaleRuleDelete(string autoscaleName ,  string index ,  string resourceGroup)
            {
                return new AzureMonitorAutoscaleRuleDeleteTask(autoscaleName,  index,  resourceGroup);
            }

            public AzureMonitorDiagnosticSettingsCategoriesTask MonitorDiagnosticSettingsCategories()
            {
                return new AzureMonitorDiagnosticSettingsCategoriesTask();
            }

            public AzureMonitorMetricsAlertTask MonitorMetricsAlert()
            {
                return new AzureMonitorMetricsAlertTask();
            }

            public AzureMonitorMetricsAlertCreateTask MonitorMetricsAlertCreate(string condition ,  string name ,  string resourceGroup ,  string scopes)
            {
                return new AzureMonitorMetricsAlertCreateTask(condition,  name,  resourceGroup,  scopes);
            }

            public AzureMonitorMetricsAlertDeleteTask MonitorMetricsAlertDelete(string name ,  string resourceGroup)
            {
                return new AzureMonitorMetricsAlertDeleteTask(name,  resourceGroup);
            }

            public AzureMonitorMetricsAlertUpdateTask MonitorMetricsAlertUpdate(string name ,  string resourceGroup)
            {
                return new AzureMonitorMetricsAlertUpdateTask(name,  resourceGroup);
            }
        
    }
}

