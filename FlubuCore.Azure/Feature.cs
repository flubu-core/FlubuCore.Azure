
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Feature;

namespace FlubuCore.Azure
{
    public class Feature
    {
        
        
            public AzureFeatureRegisterTask FeatureRegister(string name ,  string @namespace)
            {
                return new AzureFeatureRegisterTask(name,  @namespace);
            }
        
    }
}

