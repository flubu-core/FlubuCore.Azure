
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Managedapp
{
     public partial class AzureManagedappCreateTask : ExternalProcessTaskBase<AzureManagedappCreateTask>
     {
        
        /// <summary>
        /// Create a managed application.
        /// </summary>
        public AzureManagedappCreateTask(string kind = null ,  string managedRgId = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az managedapp create");
WithArguments("--kind");
            if (!string.IsNullOrEmpty(kind))
            {
                 WithArguments(kind);
            }

WithArguments("--managed-rg-id");
            if (!string.IsNullOrEmpty(managedRgId))
            {
                 WithArguments(managedRgId);
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
        /// The managed application location.
        /// </summary>
        public AzureManagedappCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// The full qualified managed application definition id.
        /// </summary>
        public AzureManagedappCreateTask ManagedappDefinitionId(string managedappDefinitionId = null)
        {
            WithArguments("--managedapp-definition-id");
            if (!string.IsNullOrEmpty(managedappDefinitionId))
            {
                 WithArguments(managedappDefinitionId);
            }

            return this;
        }

        /// <summary>
        /// JSON formatted string or a path to a file with such content.
        /// </summary>
        public AzureManagedappCreateTask Parameters(string parameters = null)
        {
            WithArguments("--parameters");
            if (!string.IsNullOrEmpty(parameters))
            {
                 WithArguments(parameters);
            }

            return this;
        }

        /// <summary>
        /// The managed application package plan name.
        /// </summary>
        public AzureManagedappCreateTask PlanName(string planName = null)
        {
            WithArguments("--plan-name");
            if (!string.IsNullOrEmpty(planName))
            {
                 WithArguments(planName);
            }

            return this;
        }

        /// <summary>
        /// The managed application package plan product.
        /// </summary>
        public AzureManagedappCreateTask PlanProduct(string planProduct = null)
        {
            WithArguments("--plan-product");
            if (!string.IsNullOrEmpty(planProduct))
            {
                 WithArguments(planProduct);
            }

            return this;
        }

        /// <summary>
        /// The managed application package plan publisher.
        /// </summary>
        public AzureManagedappCreateTask PlanPublisher(string planPublisher = null)
        {
            WithArguments("--plan-publisher");
            if (!string.IsNullOrEmpty(planPublisher))
            {
                 WithArguments(planPublisher);
            }

            return this;
        }

        /// <summary>
        /// The managed application package plan version.
        /// </summary>
        public AzureManagedappCreateTask PlanVersion(string planVersion = null)
        {
            WithArguments("--plan-version");
            if (!string.IsNullOrEmpty(planVersion))
            {
                 WithArguments(planVersion);
            }

            return this;
        }

        /// <summary>
        /// Tags in 'a=b c' format.
        /// </summary>
        public AzureManagedappCreateTask Tags(string tags = null)
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
