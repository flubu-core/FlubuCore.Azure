
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Relay;

namespace FlubuCore.Azure
{
    public class Relay
    {
        
        
            public AzureRelayHycoTask RelayHyco()
            {
                return new AzureRelayHycoTask();
            }

            public AzureRelayHycoCreateTask RelayHycoCreate(string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureRelayHycoCreateTask(name,  namespaceName,  resourceGroup);
            }

            public AzureRelayHycoDeleteTask RelayHycoDelete(string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureRelayHycoDeleteTask(name,  namespaceName,  resourceGroup);
            }

            public AzureRelayHycoUpdateTask RelayHycoUpdate(string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureRelayHycoUpdateTask(name,  namespaceName,  resourceGroup);
            }

            public AzureRelayNamespaceTask RelayNamespace()
            {
                return new AzureRelayNamespaceTask();
            }

            public AzureRelayNamespaceCreateTask RelayNamespaceCreate(string name ,  string resourceGroup)
            {
                return new AzureRelayNamespaceCreateTask(name,  resourceGroup);
            }

            public AzureRelayNamespaceDeleteTask RelayNamespaceDelete(string name ,  string resourceGroup)
            {
                return new AzureRelayNamespaceDeleteTask(name,  resourceGroup);
            }

            public AzureRelayNamespaceExistsTask RelayNamespaceExists(string name)
            {
                return new AzureRelayNamespaceExistsTask(name);
            }

            public AzureRelayNamespaceUpdateTask RelayNamespaceUpdate(string name ,  string resourceGroup)
            {
                return new AzureRelayNamespaceUpdateTask(name,  resourceGroup);
            }

            public AzureRelayWcfrelayTask RelayWcfrelay()
            {
                return new AzureRelayWcfrelayTask();
            }

            public AzureRelayWcfrelayCreateTask RelayWcfrelayCreate(string name ,  string namespaceName ,  string relayType ,  string resourceGroup)
            {
                return new AzureRelayWcfrelayCreateTask(name,  namespaceName,  relayType,  resourceGroup);
            }

            public AzureRelayWcfrelayDeleteTask RelayWcfrelayDelete(string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureRelayWcfrelayDeleteTask(name,  namespaceName,  resourceGroup);
            }

            public AzureRelayWcfrelayUpdateTask RelayWcfrelayUpdate(string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureRelayWcfrelayUpdateTask(name,  namespaceName,  resourceGroup);
            }

            public AzureRelayHycoAuthorizationRuleTask RelayHycoAuthorizationRule()
            {
                return new AzureRelayHycoAuthorizationRuleTask();
            }

            public AzureRelayHycoAuthorizationRuleCreateTask RelayHycoAuthorizationRuleCreate(string hybridConnectionName ,  string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureRelayHycoAuthorizationRuleCreateTask(hybridConnectionName,  name,  namespaceName,  resourceGroup);
            }

            public AzureRelayHycoAuthorizationRuleDeleteTask RelayHycoAuthorizationRuleDelete(string hybridConnectionName ,  string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureRelayHycoAuthorizationRuleDeleteTask(hybridConnectionName,  name,  namespaceName,  resourceGroup);
            }

            public AzureRelayHycoAuthorizationRuleUpdateTask RelayHycoAuthorizationRuleUpdate(string hybridConnectionName ,  string name ,  string namespaceName ,  string resourceGroup ,  string rights)
            {
                return new AzureRelayHycoAuthorizationRuleUpdateTask(hybridConnectionName,  name,  namespaceName,  resourceGroup,  rights);
            }

            public AzureRelayHycoAuthorizationRuleKeysTask RelayHycoAuthorizationRuleKeys()
            {
                return new AzureRelayHycoAuthorizationRuleKeysTask();
            }

            public AzureRelayHycoAuthorizationRuleKeysRenewTask RelayHycoAuthorizationRuleKeysRenew(string hybridConnectionName ,  string key ,  string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureRelayHycoAuthorizationRuleKeysRenewTask(hybridConnectionName,  key,  name,  namespaceName,  resourceGroup);
            }

            public AzureRelayNamespaceAuthorizationRuleTask RelayNamespaceAuthorizationRule()
            {
                return new AzureRelayNamespaceAuthorizationRuleTask();
            }

            public AzureRelayNamespaceAuthorizationRuleCreateTask RelayNamespaceAuthorizationRuleCreate(string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureRelayNamespaceAuthorizationRuleCreateTask(name,  namespaceName,  resourceGroup);
            }

            public AzureRelayNamespaceAuthorizationRuleDeleteTask RelayNamespaceAuthorizationRuleDelete(string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureRelayNamespaceAuthorizationRuleDeleteTask(name,  namespaceName,  resourceGroup);
            }

            public AzureRelayNamespaceAuthorizationRuleUpdateTask RelayNamespaceAuthorizationRuleUpdate(string name ,  string namespaceName ,  string resourceGroup ,  string rights)
            {
                return new AzureRelayNamespaceAuthorizationRuleUpdateTask(name,  namespaceName,  resourceGroup,  rights);
            }

            public AzureRelayNamespaceAuthorizationRuleKeysTask RelayNamespaceAuthorizationRuleKeys()
            {
                return new AzureRelayNamespaceAuthorizationRuleKeysTask();
            }

            public AzureRelayNamespaceAuthorizationRuleKeysRenewTask RelayNamespaceAuthorizationRuleKeysRenew(string key ,  string name ,  string namespaceName ,  string resourceGroup)
            {
                return new AzureRelayNamespaceAuthorizationRuleKeysRenewTask(key,  name,  namespaceName,  resourceGroup);
            }

            public AzureRelayWcfrelayAuthorizationRuleTask RelayWcfrelayAuthorizationRule()
            {
                return new AzureRelayWcfrelayAuthorizationRuleTask();
            }

            public AzureRelayWcfrelayAuthorizationRuleCreateTask RelayWcfrelayAuthorizationRuleCreate(string name ,  string namespaceName ,  string relayName ,  string resourceGroup)
            {
                return new AzureRelayWcfrelayAuthorizationRuleCreateTask(name,  namespaceName,  relayName,  resourceGroup);
            }

            public AzureRelayWcfrelayAuthorizationRuleDeleteTask RelayWcfrelayAuthorizationRuleDelete(string name ,  string namespaceName ,  string relayName ,  string resourceGroup)
            {
                return new AzureRelayWcfrelayAuthorizationRuleDeleteTask(name,  namespaceName,  relayName,  resourceGroup);
            }

            public AzureRelayWcfrelayAuthorizationRuleUpdateTask RelayWcfrelayAuthorizationRuleUpdate(string name ,  string namespaceName ,  string relayName ,  string resourceGroup ,  string rights)
            {
                return new AzureRelayWcfrelayAuthorizationRuleUpdateTask(name,  namespaceName,  relayName,  resourceGroup,  rights);
            }

            public AzureRelayWcfrelayAuthorizationRuleKeysTask RelayWcfrelayAuthorizationRuleKeys()
            {
                return new AzureRelayWcfrelayAuthorizationRuleKeysTask();
            }

            public AzureRelayWcfrelayAuthorizationRuleKeysRenewTask RelayWcfrelayAuthorizationRuleKeysRenew(string key ,  string name ,  string namespaceName ,  string relayName ,  string resourceGroup)
            {
                return new AzureRelayWcfrelayAuthorizationRuleKeysRenewTask(key,  name,  namespaceName,  relayName,  resourceGroup);
            }
        
    }
}

