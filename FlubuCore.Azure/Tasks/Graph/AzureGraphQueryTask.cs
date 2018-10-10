
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Graph
{
     public partial class AzureGraphQueryTask : ExternalProcessTaskBase<AzureGraphQueryTask>
     {
        
        /// <summary>
        /// Query the resources managed by Azure Resource Manager.
        /// </summary>
        public AzureGraphQueryTask(string graphQuery = null)
        {
            WithArguments("az graph query");
WithArguments("--graph-query");
            if (!string.IsNullOrEmpty(graphQuery))
            {
                 WithArguments(graphQuery);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The maximum number of objects to return. Accepted range: 1-5000.
        /// </summary>
        public AzureGraphQueryTask First(string first = null)
        {
            WithArguments("--first");
            if (!string.IsNullOrEmpty(first))
            {
                 WithArguments(first);
            }

            return this;
        }

        /// <summary>
        /// Ignores the first N objects and then gets the remaining objects.
        /// </summary>
        public AzureGraphQueryTask Skip(string skip = null)
        {
            WithArguments("--skip");
            if (!string.IsNullOrEmpty(skip))
            {
                 WithArguments(skip);
            }

            return this;
        }

        /// <summary>
        /// List of subscriptions to run query against. By default all accessible subscriptions are queried.
        /// </summary>
        public AzureGraphQueryTask Subscriptions(string subscriptions = null)
        {
            WithArguments("--subscriptions");
            if (!string.IsNullOrEmpty(subscriptions))
            {
                 WithArguments(subscriptions);
            }

            return this;
        }
     }
}
