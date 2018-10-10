
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Ams;

namespace FlubuCore.Azure
{
    public class Ams
    {
        
        
            public AzureAmsAccountTask AmsAccount()
            {
                return new AzureAmsAccountTask();
            }

            public AzureAmsAccountCreateTask AmsAccountCreate(string name ,  string resourceGroup ,  string storageAccount)
            {
                return new AzureAmsAccountCreateTask(name,  resourceGroup,  storageAccount);
            }

            public AzureAmsAccountDeleteTask AmsAccountDelete(string name ,  string resourceGroup)
            {
                return new AzureAmsAccountDeleteTask(name,  resourceGroup);
            }

            public AzureAmsAccountUpdateTask AmsAccountUpdate(string name ,  string resourceGroup)
            {
                return new AzureAmsAccountUpdateTask(name,  resourceGroup);
            }

            public AzureAmsAssetTask AmsAsset()
            {
                return new AzureAmsAssetTask();
            }

            public AzureAmsAssetCreateTask AmsAssetCreate(string accountName ,  string name ,  string resourceGroup)
            {
                return new AzureAmsAssetCreateTask(accountName,  name,  resourceGroup);
            }

            public AzureAmsAssetDeleteTask AmsAssetDelete(string accountName ,  string name ,  string resourceGroup)
            {
                return new AzureAmsAssetDeleteTask(accountName,  name,  resourceGroup);
            }

            public AzureAmsAssetGetSasUrlsTask AmsAssetGetSasUrls(string accountName ,  string name ,  string resourceGroup)
            {
                return new AzureAmsAssetGetSasUrlsTask(accountName,  name,  resourceGroup);
            }

            public AzureAmsAssetUpdateTask AmsAssetUpdate(string accountName ,  string name ,  string resourceGroup)
            {
                return new AzureAmsAssetUpdateTask(accountName,  name,  resourceGroup);
            }

            public AzureAmsJobTask AmsJob()
            {
                return new AzureAmsJobTask();
            }

            public AzureAmsJobCancelTask AmsJobCancel(string accountName ,  string name ,  string resourceGroup ,  string transformName)
            {
                return new AzureAmsJobCancelTask(accountName,  name,  resourceGroup,  transformName);
            }

            public AzureAmsJobDeleteTask AmsJobDelete(string accountName ,  string name ,  string resourceGroup ,  string transformName)
            {
                return new AzureAmsJobDeleteTask(accountName,  name,  resourceGroup,  transformName);
            }

            public AzureAmsJobStartTask AmsJobStart(string accountName ,  string name ,  string outputAssetNames ,  string resourceGroup ,  string transformName)
            {
                return new AzureAmsJobStartTask(accountName,  name,  outputAssetNames,  resourceGroup,  transformName);
            }

            public AzureAmsStreamingTask AmsStreaming()
            {
                return new AzureAmsStreamingTask();
            }

            public AzureAmsTransformTask AmsTransform()
            {
                return new AzureAmsTransformTask();
            }

            public AzureAmsTransformCreateTask AmsTransformCreate(string accountName ,  string name ,  string presetNames ,  string resourceGroup)
            {
                return new AzureAmsTransformCreateTask(accountName,  name,  presetNames,  resourceGroup);
            }

            public AzureAmsTransformDeleteTask AmsTransformDelete(string accountName ,  string name ,  string resourceGroup)
            {
                return new AzureAmsTransformDeleteTask(accountName,  name,  resourceGroup);
            }

            public AzureAmsTransformUpdateTask AmsTransformUpdate(string accountName ,  string name ,  string resourceGroup)
            {
                return new AzureAmsTransformUpdateTask(accountName,  name,  resourceGroup);
            }

            public AzureAmsAccountSpTask AmsAccountSp()
            {
                return new AzureAmsAccountSpTask();
            }

            public AzureAmsAccountSpCreateTask AmsAccountSpCreate(string accountName ,  string resourceGroup)
            {
                return new AzureAmsAccountSpCreateTask(accountName,  resourceGroup);
            }

            public AzureAmsAccountSpResetCredentialsTask AmsAccountSpResetCredentials(string accountName ,  string resourceGroup)
            {
                return new AzureAmsAccountSpResetCredentialsTask(accountName,  resourceGroup);
            }

            public AzureAmsAccountStorageTask AmsAccountStorage()
            {
                return new AzureAmsAccountStorageTask();
            }

            public AzureAmsAccountStorageAddTask AmsAccountStorageAdd(string accountName ,  string name ,  string resourceGroup)
            {
                return new AzureAmsAccountStorageAddTask(accountName,  name,  resourceGroup);
            }

            public AzureAmsAccountStorageRemoveTask AmsAccountStorageRemove(string accountName ,  string name ,  string resourceGroup)
            {
                return new AzureAmsAccountStorageRemoveTask(accountName,  name,  resourceGroup);
            }

            public AzureAmsStreamingEndpointTask AmsStreamingEndpoint()
            {
                return new AzureAmsStreamingEndpointTask();
            }

            public AzureAmsStreamingEndpointStartTask AmsStreamingEndpointStart(string accountName ,  string resourceGroup ,  string streamingEndpointName)
            {
                return new AzureAmsStreamingEndpointStartTask(accountName,  resourceGroup,  streamingEndpointName);
            }

            public AzureAmsStreamingEndpointStopTask AmsStreamingEndpointStop(string accountName ,  string resourceGroup ,  string streamingEndpointName)
            {
                return new AzureAmsStreamingEndpointStopTask(accountName,  resourceGroup,  streamingEndpointName);
            }

            public AzureAmsStreamingLocatorTask AmsStreamingLocator()
            {
                return new AzureAmsStreamingLocatorTask();
            }

            public AzureAmsStreamingLocatorCreateTask AmsStreamingLocatorCreate(string accountName ,  string assetName ,  string name ,  string resourceGroup ,  string streamingPolicyName)
            {
                return new AzureAmsStreamingLocatorCreateTask(accountName,  assetName,  name,  resourceGroup,  streamingPolicyName);
            }

            public AzureAmsStreamingLocatorDeleteTask AmsStreamingLocatorDelete(string accountName ,  string name ,  string resourceGroup)
            {
                return new AzureAmsStreamingLocatorDeleteTask(accountName,  name,  resourceGroup);
            }

            public AzureAmsStreamingLocatorGetPathsTask AmsStreamingLocatorGetPaths(string accountName ,  string name ,  string resourceGroup)
            {
                return new AzureAmsStreamingLocatorGetPathsTask(accountName,  name,  resourceGroup);
            }

            public AzureAmsStreamingPolicyTask AmsStreamingPolicy()
            {
                return new AzureAmsStreamingPolicyTask();
            }

            public AzureAmsStreamingPolicyCreateTask AmsStreamingPolicyCreate(string accountName ,  string name ,  string resourceGroup)
            {
                return new AzureAmsStreamingPolicyCreateTask(accountName,  name,  resourceGroup);
            }

            public AzureAmsStreamingPolicyDeleteTask AmsStreamingPolicyDelete(string accountName ,  string name ,  string resourceGroup)
            {
                return new AzureAmsStreamingPolicyDeleteTask(accountName,  name,  resourceGroup);
            }

            public AzureAmsTransformOutputTask AmsTransformOutput()
            {
                return new AzureAmsTransformOutputTask();
            }

            public AzureAmsTransformOutputAddTask AmsTransformOutputAdd(string accountName ,  string name ,  string presetNames ,  string resourceGroup)
            {
                return new AzureAmsTransformOutputAddTask(accountName,  name,  presetNames,  resourceGroup);
            }

            public AzureAmsTransformOutputRemoveTask AmsTransformOutputRemove(string accountName ,  string name ,  string presetNames ,  string resourceGroup)
            {
                return new AzureAmsTransformOutputRemoveTask(accountName,  name,  presetNames,  resourceGroup);
            }
        
    }
}

