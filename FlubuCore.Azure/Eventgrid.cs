
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Eventgrid;

namespace FlubuCore.Azure
{
    public class Eventgrid
    {
        
        
            public AzureEventgridEventSubscriptionTask EventgridEventSubscription()
            {
                return new AzureEventgridEventSubscriptionTask();
            }

            public AzureEventgridEventSubscriptionCreateTask EventgridEventSubscriptionCreate(string endpoint ,  string name)
            {
                return new AzureEventgridEventSubscriptionCreateTask(endpoint,  name);
            }

            public AzureEventgridEventSubscriptionDeleteTask EventgridEventSubscriptionDelete(string name)
            {
                return new AzureEventgridEventSubscriptionDeleteTask(name);
            }

            public AzureEventgridEventSubscriptionUpdateTask EventgridEventSubscriptionUpdate(string name)
            {
                return new AzureEventgridEventSubscriptionUpdateTask(name);
            }

            public AzureEventgridTopicTypeTask EventgridTopicType()
            {
                return new AzureEventgridTopicTypeTask();
            }

            public AzureEventgridTopicTask EventgridTopic()
            {
                return new AzureEventgridTopicTask();
            }

            public AzureEventgridTopicCreateTask EventgridTopicCreate(string location ,  string name ,  string resourceGroup)
            {
                return new AzureEventgridTopicCreateTask(location,  name,  resourceGroup);
            }

            public AzureEventgridTopicDeleteTask EventgridTopicDelete(string name ,  string resourceGroup)
            {
                return new AzureEventgridTopicDeleteTask(name,  resourceGroup);
            }

            public AzureEventgridTopicUpdateTask EventgridTopicUpdate(string name ,  string resourceGroup)
            {
                return new AzureEventgridTopicUpdateTask(name,  resourceGroup);
            }

            public AzureEventgridTopicKeyTask EventgridTopicKey()
            {
                return new AzureEventgridTopicKeyTask();
            }

            public AzureEventgridTopicKeyRegenerateTask EventgridTopicKeyRegenerate(string keyName ,  string name ,  string resourceGroup)
            {
                return new AzureEventgridTopicKeyRegenerateTask(keyName,  name,  resourceGroup);
            }
        
    }
}

