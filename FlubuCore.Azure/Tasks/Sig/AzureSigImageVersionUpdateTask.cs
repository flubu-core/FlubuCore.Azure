
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sig
{
     public partial class AzureSigImageVersionUpdateTask : ExternalProcessTaskBase<AzureSigImageVersionUpdateTask>
     {
        
        /// <summary>
        /// Update a share image version.
        /// </summary>
        public AzureSigImageVersionUpdateTask(string galleryImageDefinition = null ,  string galleryImageVersion = null ,  string galleryImageVersionName = null ,  string galleryName = null ,  string resourceGroup = null)
        {
            WithArguments("az sig image-version update");
WithArguments("--gallery-image-definition");
            if (!string.IsNullOrEmpty(galleryImageDefinition))
            {
                 WithArguments(galleryImageDefinition);
            }

WithArguments("--gallery-image-version");
            if (!string.IsNullOrEmpty(galleryImageVersion))
            {
                 WithArguments(galleryImageVersion);
            }

WithArguments("--gallery-image-version-name");
            if (!string.IsNullOrEmpty(galleryImageVersionName))
            {
                 WithArguments(galleryImageVersionName);
            }

WithArguments("--gallery-name");
            if (!string.IsNullOrEmpty(galleryName))
            {
                 WithArguments(galleryName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureSigImageVersionUpdateTask Add(string add = null)
        {
            WithArguments("--add");
            if (!string.IsNullOrEmpty(add))
            {
                 WithArguments(add);
            }

            return this;
        }

        /// <summary>
        /// When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public AzureSigImageVersionUpdateTask ForceString(string forceString = null)
        {
            WithArguments("--force-string");
            if (!string.IsNullOrEmpty(forceString))
            {
                 WithArguments(forceString);
            }

            return this;
        }

        /// <summary>
        /// Remove a property or an element from a list.  Example: --remove property.list <indexToRemove> OR --remove propertyToRemove.
        /// </summary>
        public AzureSigImageVersionUpdateTask Remove(string remove = null)
        {
            WithArguments("--remove");
            if (!string.IsNullOrEmpty(remove))
            {
                 WithArguments(remove);
            }

            return this;
        }

        /// <summary>
        /// Update an object by specifying a property path and value to set.  Example: --set property1.property2=<value>.
        /// </summary>
        public AzureSigImageVersionUpdateTask Set(string set = null)
        {
            WithArguments("--set");
            if (!string.IsNullOrEmpty(set))
            {
                 WithArguments(set);
            }

            return this;
        }
     }
}
