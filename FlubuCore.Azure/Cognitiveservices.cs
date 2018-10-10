
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Cognitiveservices;

namespace FlubuCore.Azure
{
    public class Cognitiveservices
    {
        
        
            public AzureCognitiveservicesAccountTask CognitiveservicesAccount()
            {
                return new AzureCognitiveservicesAccountTask();
            }

            public AzureCognitiveservicesAccountCreateTask CognitiveservicesAccountCreate(string kind ,  string location ,  string name ,  string resourceGroup ,  string sku)
            {
                return new AzureCognitiveservicesAccountCreateTask(kind,  location,  name,  resourceGroup,  sku);
            }

            public AzureCognitiveservicesAccountDeleteTask CognitiveservicesAccountDelete(string name ,  string resourceGroup)
            {
                return new AzureCognitiveservicesAccountDeleteTask(name,  resourceGroup);
            }

            public AzureCognitiveservicesAccountUpdateTask CognitiveservicesAccountUpdate(string name ,  string resourceGroup)
            {
                return new AzureCognitiveservicesAccountUpdateTask(name,  resourceGroup);
            }

            public AzureCognitiveservicesAccountKeysTask CognitiveservicesAccountKeys()
            {
                return new AzureCognitiveservicesAccountKeysTask();
            }

            public AzureCognitiveservicesAccountKeysRegenerateTask CognitiveservicesAccountKeysRegenerate(string keyName ,  string name ,  string resourceGroup)
            {
                return new AzureCognitiveservicesAccountKeysRegenerateTask(keyName,  name,  resourceGroup);
            }
        
    }
}

