
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Graph;

namespace FlubuCore.Azure
{
    public class Graph
    {
        
        
            public AzureGraphQueryTask GraphQuery(string graphQuery)
            {
                return new AzureGraphQueryTask(graphQuery);
            }
        
    }
}

