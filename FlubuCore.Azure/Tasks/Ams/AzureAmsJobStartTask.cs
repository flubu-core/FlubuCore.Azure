
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsJobStartTask : ExternalProcessTaskBase<AzureAmsJobStartTask>
     {
        
        /// <summary>
        /// Start a job.
        /// </summary>
        public AzureAmsJobStartTask(string accountName = null ,  string name = null ,  string outputAssetNames = null ,  string resourceGroup = null ,  string transformName = null)
        {
            WithArguments("az ams job start");
WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--output-asset-names");
            if (!string.IsNullOrEmpty(outputAssetNames))
            {
                 WithArguments(outputAssetNames);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--transform-name");
            if (!string.IsNullOrEmpty(transformName))
            {
                 WithArguments(transformName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Space-separated list of files. It can be used to tell the service to only use the files specified from the input asset.
        /// </summary>
        public AzureAmsJobStartTask Files(string files = null)
        {
            WithArguments("--files");
            if (!string.IsNullOrEmpty(files))
            {
                 WithArguments(files);
            }

            return this;
        }

        /// <summary>
        /// The priority with which the job should be processed.
        /// </summary>
        public AzureAmsJobStartTask Priority(string priority = null)
        {
            WithArguments("--priority");
            if (!string.IsNullOrEmpty(priority))
            {
                 WithArguments(priority);
            }

            return this;
        }

        /// <summary>
        /// The name of the input asset.
        /// </summary>
        public AzureAmsJobStartTask InputAssetName(string inputAssetName = null)
        {
            WithArguments("--input-asset-name");
            if (!string.IsNullOrEmpty(inputAssetName))
            {
                 WithArguments(inputAssetName);
            }

            return this;
        }

        /// <summary>
        /// Base uri for http job input. It will be concatenated with provided file names. If no base uri is given, then the provided file list is assumed to be fully qualified uris.
        /// </summary>
        public AzureAmsJobStartTask BaseUri(string baseUri = null)
        {
            WithArguments("--base-uri");
            if (!string.IsNullOrEmpty(baseUri))
            {
                 WithArguments(baseUri);
            }

            return this;
        }
     }
}
