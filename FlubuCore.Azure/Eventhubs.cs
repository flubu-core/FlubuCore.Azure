
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Eventhubs;

namespace FlubuCore.Azure
{
    public class Eventhubs
    {
        
        
            public AzureEventhubsEventhubTask EventhubsEventhub()
            {
                return new AzureEventhubsEventhubTask();
            }

            public AzureEventhubsEventhubCreateTask EventhubsEventhubCreate(string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureEventhubsEventhubCreateTask(name,  namespaceName,  resourceGroup);
            }

            public AzureEventhubsEventhubDeleteTask EventhubsEventhubDelete(string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureEventhubsEventhubDeleteTask(name,  namespaceName,  resourceGroup);
            }

            public AzureEventhubsEventhubUpdateTask EventhubsEventhubUpdate(string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureEventhubsEventhubUpdateTask(name,  namespaceName,  resourceGroup);
            }

            public AzureEventhubsGeorecoveryAliasTask EventhubsGeorecoveryAlias()
            {
                return new AzureEventhubsGeorecoveryAliasTask();
            }

            public AzureEventhubsGeorecoveryAliasBreakPairTask EventhubsGeorecoveryAliasBreakPair(string alias ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureEventhubsGeorecoveryAliasBreakPairTask(alias,  namespaceName,  resourceGroup);
            }

            public AzureEventhubsGeorecoveryAliasDeleteTask EventhubsGeorecoveryAliasDelete(string alias ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureEventhubsGeorecoveryAliasDeleteTask(alias,  namespaceName,  resourceGroup);
            }

            public AzureEventhubsGeorecoveryAliasExistsTask EventhubsGeorecoveryAliasExists(string alias ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureEventhubsGeorecoveryAliasExistsTask(alias,  namespaceName,  resourceGroup);
            }

            public AzureEventhubsGeorecoveryAliasFailOverTask EventhubsGeorecoveryAliasFailOver(string alias ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureEventhubsGeorecoveryAliasFailOverTask(alias,  namespaceName,  resourceGroup);
            }

            public AzureEventhubsGeorecoveryAliasSetTask EventhubsGeorecoveryAliasSet(string alias ,  string namespaceName ,  string partnerNamespace ,  string resourceGroup)
            {
                return new AzureEventhubsGeorecoveryAliasSetTask(alias,  namespaceName,  partnerNamespace,  resourceGroup);
            }

            public AzureEventhubsNamespaceTask EventhubsNamespace()
            {
                return new AzureEventhubsNamespaceTask();
            }

            public AzureEventhubsNamespaceCreateTask EventhubsNamespaceCreate(string name ,  string resourceGroup)
            {
                return new AzureEventhubsNamespaceCreateTask(name,  resourceGroup);
            }

            public AzureEventhubsNamespaceDeleteTask EventhubsNamespaceDelete(string name ,  string resourceGroup)
            {
                return new AzureEventhubsNamespaceDeleteTask(name,  resourceGroup);
            }

            public AzureEventhubsNamespaceExistsTask EventhubsNamespaceExists(string name)
            {
                return new AzureEventhubsNamespaceExistsTask(name);
            }

            public AzureEventhubsNamespaceUpdateTask EventhubsNamespaceUpdate(string name ,  string resourceGroup)
            {
                return new AzureEventhubsNamespaceUpdateTask(name,  resourceGroup);
            }

            public AzureEventhubsEventhubAuthorizationRuleTask EventhubsEventhubAuthorizationRule()
            {
                return new AzureEventhubsEventhubAuthorizationRuleTask();
            }

            public AzureEventhubsEventhubAuthorizationRuleCreateTask EventhubsEventhubAuthorizationRuleCreate(string eventhubName ,  string name ,  string namespaceName ,  string resourceGroup ,  string rights)
            {
                return new AzureEventhubsEventhubAuthorizationRuleCreateTask(eventhubName,  name,  namespaceName,  resourceGroup,  rights);
            }

            public AzureEventhubsEventhubAuthorizationRuleDeleteTask EventhubsEventhubAuthorizationRuleDelete(string eventhubName ,  string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureEventhubsEventhubAuthorizationRuleDeleteTask(eventhubName,  name,  namespaceName,  resourceGroup);
            }

            public AzureEventhubsEventhubAuthorizationRuleUpdateTask EventhubsEventhubAuthorizationRuleUpdate(string eventhubName ,  string name ,  string namespaceName ,  string resourceGroup ,  string rights)
            {
                return new AzureEventhubsEventhubAuthorizationRuleUpdateTask(eventhubName,  name,  namespaceName,  resourceGroup,  rights);
            }

            public AzureEventhubsEventhubConsumerGroupTask EventhubsEventhubConsumerGroup()
            {
                return new AzureEventhubsEventhubConsumerGroupTask();
            }

            public AzureEventhubsEventhubConsumerGroupCreateTask EventhubsEventhubConsumerGroupCreate(string eventhubName ,  string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureEventhubsEventhubConsumerGroupCreateTask(eventhubName,  name,  namespaceName,  resourceGroup);
            }

            public AzureEventhubsEventhubConsumerGroupDeleteTask EventhubsEventhubConsumerGroupDelete(string eventhubName ,  string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureEventhubsEventhubConsumerGroupDeleteTask(eventhubName,  name,  namespaceName,  resourceGroup);
            }

            public AzureEventhubsEventhubConsumerGroupUpdateTask EventhubsEventhubConsumerGroupUpdate(string eventhubName ,  string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureEventhubsEventhubConsumerGroupUpdateTask(eventhubName,  name,  namespaceName,  resourceGroup);
            }

            public AzureEventhubsEventhubAuthorizationRuleKeysTask EventhubsEventhubAuthorizationRuleKeys()
            {
                return new AzureEventhubsEventhubAuthorizationRuleKeysTask();
            }

            public AzureEventhubsEventhubAuthorizationRuleKeysRenewTask EventhubsEventhubAuthorizationRuleKeysRenew(string eventhubName ,  string key ,  string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureEventhubsEventhubAuthorizationRuleKeysRenewTask(eventhubName,  key,  name,  namespaceName,  resourceGroup);
            }

            public AzureEventhubsGeorecoveryAliasAuthorizationRuleTask EventhubsGeorecoveryAliasAuthorizationRule()
            {
                return new AzureEventhubsGeorecoveryAliasAuthorizationRuleTask();
            }

            public AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysTask EventhubsGeorecoveryAliasAuthorizationRuleKeys()
            {
                return new AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysTask();
            }

            public AzureEventhubsNamespaceAuthorizationRuleTask EventhubsNamespaceAuthorizationRule()
            {
                return new AzureEventhubsNamespaceAuthorizationRuleTask();
            }

            public AzureEventhubsNamespaceAuthorizationRuleCreateTask EventhubsNamespaceAuthorizationRuleCreate(string name ,  string namespaceName ,  string resourceGroup ,  string rights)
            {
                return new AzureEventhubsNamespaceAuthorizationRuleCreateTask(name,  namespaceName,  resourceGroup,  rights);
            }

            public AzureEventhubsNamespaceAuthorizationRuleDeleteTask EventhubsNamespaceAuthorizationRuleDelete(string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureEventhubsNamespaceAuthorizationRuleDeleteTask(name,  namespaceName,  resourceGroup);
            }

            public AzureEventhubsNamespaceAuthorizationRuleUpdateTask EventhubsNamespaceAuthorizationRuleUpdate(string name ,  string namespaceName ,  string resourceGroup ,  string rights)
            {
                return new AzureEventhubsNamespaceAuthorizationRuleUpdateTask(name,  namespaceName,  resourceGroup,  rights);
            }

            public AzureEventhubsNamespaceAuthorizationRuleKeysTask EventhubsNamespaceAuthorizationRuleKeys()
            {
                return new AzureEventhubsNamespaceAuthorizationRuleKeysTask();
            }

            public AzureEventhubsNamespaceAuthorizationRuleKeysRenewTask EventhubsNamespaceAuthorizationRuleKeysRenew(string key ,  string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureEventhubsNamespaceAuthorizationRuleKeysRenewTask(key,  name,  namespaceName,  resourceGroup);
            }
        
    }
}

