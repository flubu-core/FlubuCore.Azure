
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Servicebus;

namespace FlubuCore.Azure
{
    public class Servicebus
    {
        
        
            public AzureServicebusGeorecoveryAliasTask ServicebusGeorecoveryAlias()
            {
                return new AzureServicebusGeorecoveryAliasTask();
            }

            public AzureServicebusGeorecoveryAliasBreakPairTask ServicebusGeorecoveryAliasBreakPair(string alias ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureServicebusGeorecoveryAliasBreakPairTask(alias,  namespaceName,  resourceGroup);
            }

            public AzureServicebusGeorecoveryAliasDeleteTask ServicebusGeorecoveryAliasDelete(string alias ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureServicebusGeorecoveryAliasDeleteTask(alias,  namespaceName,  resourceGroup);
            }

            public AzureServicebusGeorecoveryAliasExistsTask ServicebusGeorecoveryAliasExists(string alias ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureServicebusGeorecoveryAliasExistsTask(alias,  namespaceName,  resourceGroup);
            }

            public AzureServicebusGeorecoveryAliasFailOverTask ServicebusGeorecoveryAliasFailOver(string alias ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureServicebusGeorecoveryAliasFailOverTask(alias,  namespaceName,  resourceGroup);
            }

            public AzureServicebusGeorecoveryAliasSetTask ServicebusGeorecoveryAliasSet(string alias ,  string namespaceName ,  string partnerNamespace ,  string resourceGroup)
            {
                return new AzureServicebusGeorecoveryAliasSetTask(alias,  namespaceName,  partnerNamespace,  resourceGroup);
            }

            public AzureServicebusMigrationTask ServicebusMigration()
            {
                return new AzureServicebusMigrationTask();
            }

            public AzureServicebusMigrationAbortTask ServicebusMigrationAbort(string name ,  string resourceGroup)
            {
                return new AzureServicebusMigrationAbortTask(name,  resourceGroup);
            }

            public AzureServicebusMigrationCompleteTask ServicebusMigrationComplete(string name ,  string resourceGroup)
            {
                return new AzureServicebusMigrationCompleteTask(name,  resourceGroup);
            }

            public AzureServicebusMigrationStartTask ServicebusMigrationStart(string name ,  string postMigrationName ,  string resourceGroup ,  string targetNamespace)
            {
                return new AzureServicebusMigrationStartTask(name,  postMigrationName,  resourceGroup,  targetNamespace);
            }

            public AzureServicebusNamespaceTask ServicebusNamespace()
            {
                return new AzureServicebusNamespaceTask();
            }

            public AzureServicebusNamespaceCreateTask ServicebusNamespaceCreate(string name ,  string resourceGroup)
            {
                return new AzureServicebusNamespaceCreateTask(name,  resourceGroup);
            }

            public AzureServicebusNamespaceDeleteTask ServicebusNamespaceDelete(string name ,  string resourceGroup)
            {
                return new AzureServicebusNamespaceDeleteTask(name,  resourceGroup);
            }

            public AzureServicebusNamespaceExistsTask ServicebusNamespaceExists(string name)
            {
                return new AzureServicebusNamespaceExistsTask(name);
            }

            public AzureServicebusNamespaceUpdateTask ServicebusNamespaceUpdate(string name ,  string resourceGroup)
            {
                return new AzureServicebusNamespaceUpdateTask(name,  resourceGroup);
            }

            public AzureServicebusQueueTask ServicebusQueue()
            {
                return new AzureServicebusQueueTask();
            }

            public AzureServicebusQueueCreateTask ServicebusQueueCreate(string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureServicebusQueueCreateTask(name,  namespaceName,  resourceGroup);
            }

            public AzureServicebusQueueDeleteTask ServicebusQueueDelete(string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureServicebusQueueDeleteTask(name,  namespaceName,  resourceGroup);
            }

            public AzureServicebusQueueUpdateTask ServicebusQueueUpdate(string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureServicebusQueueUpdateTask(name,  namespaceName,  resourceGroup);
            }

            public AzureServicebusTopicTask ServicebusTopic()
            {
                return new AzureServicebusTopicTask();
            }

            public AzureServicebusTopicCreateTask ServicebusTopicCreate(string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureServicebusTopicCreateTask(name,  namespaceName,  resourceGroup);
            }

            public AzureServicebusTopicDeleteTask ServicebusTopicDelete(string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureServicebusTopicDeleteTask(name,  namespaceName,  resourceGroup);
            }

            public AzureServicebusTopicUpdateTask ServicebusTopicUpdate(string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureServicebusTopicUpdateTask(name,  namespaceName,  resourceGroup);
            }

            public AzureServicebusGeorecoveryAliasAuthorizationRuleTask ServicebusGeorecoveryAliasAuthorizationRule()
            {
                return new AzureServicebusGeorecoveryAliasAuthorizationRuleTask();
            }

            public AzureServicebusGeorecoveryAliasAuthorizationRuleKeysTask ServicebusGeorecoveryAliasAuthorizationRuleKeys()
            {
                return new AzureServicebusGeorecoveryAliasAuthorizationRuleKeysTask();
            }

            public AzureServicebusNamespaceAuthorizationRuleTask ServicebusNamespaceAuthorizationRule()
            {
                return new AzureServicebusNamespaceAuthorizationRuleTask();
            }

            public AzureServicebusNamespaceAuthorizationRuleCreateTask ServicebusNamespaceAuthorizationRuleCreate(string name ,  string namespaceName ,  string resourceGroup ,  string rights)
            {
                return new AzureServicebusNamespaceAuthorizationRuleCreateTask(name,  namespaceName,  resourceGroup,  rights);
            }

            public AzureServicebusNamespaceAuthorizationRuleDeleteTask ServicebusNamespaceAuthorizationRuleDelete(string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureServicebusNamespaceAuthorizationRuleDeleteTask(name,  namespaceName,  resourceGroup);
            }

            public AzureServicebusNamespaceAuthorizationRuleUpdateTask ServicebusNamespaceAuthorizationRuleUpdate(string name ,  string namespaceName ,  string resourceGroup ,  string rights)
            {
                return new AzureServicebusNamespaceAuthorizationRuleUpdateTask(name,  namespaceName,  resourceGroup,  rights);
            }

            public AzureServicebusNamespaceAuthorizationRuleKeysTask ServicebusNamespaceAuthorizationRuleKeys()
            {
                return new AzureServicebusNamespaceAuthorizationRuleKeysTask();
            }

            public AzureServicebusNamespaceAuthorizationRuleKeysRenewTask ServicebusNamespaceAuthorizationRuleKeysRenew(string key ,  string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureServicebusNamespaceAuthorizationRuleKeysRenewTask(key,  name,  namespaceName,  resourceGroup);
            }

            public AzureServicebusQueueAuthorizationRuleTask ServicebusQueueAuthorizationRule()
            {
                return new AzureServicebusQueueAuthorizationRuleTask();
            }

            public AzureServicebusQueueAuthorizationRuleCreateTask ServicebusQueueAuthorizationRuleCreate(string name ,  string namespaceName ,  string queueName ,  string resourceGroup ,  string rights)
            {
                return new AzureServicebusQueueAuthorizationRuleCreateTask(name,  namespaceName,  queueName,  resourceGroup,  rights);
            }

            public AzureServicebusQueueAuthorizationRuleDeleteTask ServicebusQueueAuthorizationRuleDelete(string name ,  string namespaceName ,  string queueName ,  string resourceGroup)
            {
                return new AzureServicebusQueueAuthorizationRuleDeleteTask(name,  namespaceName,  queueName,  resourceGroup);
            }

            public AzureServicebusQueueAuthorizationRuleUpdateTask ServicebusQueueAuthorizationRuleUpdate(string name ,  string namespaceName ,  string queueName ,  string resourceGroup ,  string rights)
            {
                return new AzureServicebusQueueAuthorizationRuleUpdateTask(name,  namespaceName,  queueName,  resourceGroup,  rights);
            }

            public AzureServicebusQueueAuthorizationRuleKeysTask ServicebusQueueAuthorizationRuleKeys()
            {
                return new AzureServicebusQueueAuthorizationRuleKeysTask();
            }

            public AzureServicebusQueueAuthorizationRuleKeysRenewTask ServicebusQueueAuthorizationRuleKeysRenew(string key ,  string name ,  string namespaceName ,  string queueName ,  string resourceGroup)
            {
                return new AzureServicebusQueueAuthorizationRuleKeysRenewTask(key,  name,  namespaceName,  queueName,  resourceGroup);
            }

            public AzureServicebusTopicAuthorizationRuleTask ServicebusTopicAuthorizationRule()
            {
                return new AzureServicebusTopicAuthorizationRuleTask();
            }

            public AzureServicebusTopicAuthorizationRuleCreateTask ServicebusTopicAuthorizationRuleCreate(string name ,  string namespaceName ,  string resourceGroup ,  string rights ,  string topicName)
            {
                return new AzureServicebusTopicAuthorizationRuleCreateTask(name,  namespaceName,  resourceGroup,  rights,  topicName);
            }

            public AzureServicebusTopicAuthorizationRuleDeleteTask ServicebusTopicAuthorizationRuleDelete(string name ,  string namespaceName ,  string resourceGroup ,  string topicName)
            {
                return new AzureServicebusTopicAuthorizationRuleDeleteTask(name,  namespaceName,  resourceGroup,  topicName);
            }

            public AzureServicebusTopicAuthorizationRuleUpdateTask ServicebusTopicAuthorizationRuleUpdate(string name ,  string namespaceName ,  string resourceGroup ,  string rights ,  string topicName)
            {
                return new AzureServicebusTopicAuthorizationRuleUpdateTask(name,  namespaceName,  resourceGroup,  rights,  topicName);
            }

            public AzureServicebusTopicSubscriptionTask ServicebusTopicSubscription()
            {
                return new AzureServicebusTopicSubscriptionTask();
            }

            public AzureServicebusTopicSubscriptionCreateTask ServicebusTopicSubscriptionCreate(string name ,  string namespaceName ,  string resourceGroup ,  string topicName)
            {
                return new AzureServicebusTopicSubscriptionCreateTask(name,  namespaceName,  resourceGroup,  topicName);
            }

            public AzureServicebusTopicSubscriptionDeleteTask ServicebusTopicSubscriptionDelete(string name ,  string namespaceName ,  string resourceGroup ,  string topicName)
            {
                return new AzureServicebusTopicSubscriptionDeleteTask(name,  namespaceName,  resourceGroup,  topicName);
            }

            public AzureServicebusTopicSubscriptionUpdateTask ServicebusTopicSubscriptionUpdate(string name ,  string namespaceName ,  string resourceGroup ,  string topicName)
            {
                return new AzureServicebusTopicSubscriptionUpdateTask(name,  namespaceName,  resourceGroup,  topicName);
            }

            public AzureServicebusTopicAuthorizationRuleKeysTask ServicebusTopicAuthorizationRuleKeys()
            {
                return new AzureServicebusTopicAuthorizationRuleKeysTask();
            }

            public AzureServicebusTopicAuthorizationRuleKeysRenewTask ServicebusTopicAuthorizationRuleKeysRenew(string key ,  string name ,  string namespaceName ,  string resourceGroup ,  string topicName)
            {
                return new AzureServicebusTopicAuthorizationRuleKeysRenewTask(key,  name,  namespaceName,  resourceGroup,  topicName);
            }

            public AzureServicebusTopicSubscriptionRuleTask ServicebusTopicSubscriptionRule()
            {
                return new AzureServicebusTopicSubscriptionRuleTask();
            }

            public AzureServicebusTopicSubscriptionRuleCreateTask ServicebusTopicSubscriptionRuleCreate(string name ,  string namespaceName ,  string resourceGroup ,  string subscriptionName ,  string topicName)
            {
                return new AzureServicebusTopicSubscriptionRuleCreateTask(name,  namespaceName,  resourceGroup,  subscriptionName,  topicName);
            }

            public AzureServicebusTopicSubscriptionRuleDeleteTask ServicebusTopicSubscriptionRuleDelete(string name ,  string namespaceName ,  string resourceGroup ,  string subscriptionName ,  string topicName)
            {
                return new AzureServicebusTopicSubscriptionRuleDeleteTask(name,  namespaceName,  resourceGroup,  subscriptionName,  topicName);
            }

            public AzureServicebusTopicSubscriptionRuleUpdateTask ServicebusTopicSubscriptionRuleUpdate(string name ,  string namespaceName ,  string resourceGroup ,  string subscriptionName ,  string topicName)
            {
                return new AzureServicebusTopicSubscriptionRuleUpdateTask(name,  namespaceName,  resourceGroup,  subscriptionName,  topicName);
            }
        
    }
}

