
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Managedapp
{
     public partial class AzureManagedappDefinitionCreateTask : ExternalProcessTaskBase<AzureManagedappDefinitionCreateTask>
     {
        
        /// <summary>
        /// Create a managed application definition.
        /// </summary>
        public AzureManagedappDefinitionCreateTask(string authorizations = null ,  string displayName = null ,  string lockLevel = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az managedapp definition create");
WithArguments("--authorizations");
            if (!string.IsNullOrEmpty(authorizations))
            {
                 WithArguments(authorizations);
            }

WithArguments("--display-name");
            if (!string.IsNullOrEmpty(displayName))
            {
                 WithArguments(displayName);
            }

WithArguments("--lock-level");
            if (!string.IsNullOrEmpty(lockLevel))
            {
                 WithArguments(lockLevel);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The managed application definition create ui definition.
        /// </summary>
        public AzureManagedappDefinitionCreateTask CreateUiDefinition(string createUiDefinition = null)
        {
            WithArguments("--create-ui-definition");
            if (!string.IsNullOrEmpty(createUiDefinition))
            {
                 WithArguments(createUiDefinition);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureManagedappDefinitionCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// The managed application definition main template.
        /// </summary>
        public AzureManagedappDefinitionCreateTask MainTemplate(string mainTemplate = null)
        {
            WithArguments("--main-template");
            if (!string.IsNullOrEmpty(mainTemplate))
            {
                 WithArguments(mainTemplate);
            }

            return this;
        }

        /// <summary>
        /// The managed application definition package file uri.
        /// </summary>
        public AzureManagedappDefinitionCreateTask PackageFileUri(string packageFileUri = null)
        {
            WithArguments("--package-file-uri");
            if (!string.IsNullOrEmpty(packageFileUri))
            {
                 WithArguments(packageFileUri);
            }

            return this;
        }

        /// <summary>
        /// Tags in 'a=b c' format.
        /// </summary>
        public AzureManagedappDefinitionCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }
     }
}
