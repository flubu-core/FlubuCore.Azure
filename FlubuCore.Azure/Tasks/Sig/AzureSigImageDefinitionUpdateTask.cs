
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sig
{
     public partial class AzureSigImageDefinitionUpdateTask : ExternalProcessTaskBase<AzureSigImageDefinitionUpdateTask>
     {
        
        /// <summary>
        /// Update a share image defintiion.
        /// </summary>
        public AzureSigImageDefinitionUpdateTask(string galleryImage = null ,  string galleryImageDefinition = null ,  string galleryName = null ,  string resourceGroup = null)
        {
            WithArguments("az sig image-definition update");
WithArguments("--gallery-image");
            if (!string.IsNullOrEmpty(galleryImage))
            {
                 WithArguments(galleryImage);
            }

WithArguments("--gallery-image-definition");
            if (!string.IsNullOrEmpty(galleryImageDefinition))
            {
                 WithArguments(galleryImageDefinition);
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
        public AzureSigImageDefinitionUpdateTask Add(string add = null)
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
        public AzureSigImageDefinitionUpdateTask ForceString(string forceString = null)
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
        public AzureSigImageDefinitionUpdateTask Remove(string remove = null)
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
        public AzureSigImageDefinitionUpdateTask Set(string set = null)
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
