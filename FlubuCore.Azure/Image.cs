
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Image;

namespace FlubuCore.Azure
{
    public class Image
    {
        
        
            public AzureImageCreateTask ImageCreate(string name ,  string resourceGroup ,  string source)
            {
                return new AzureImageCreateTask(name,  resourceGroup,  source);
            }

            public AzureImageDeleteTask ImageDelete(string name ,  string resourceGroup)
            {
                return new AzureImageDeleteTask(name,  resourceGroup);
            }

            public AzureImageCopyTask ImageCopy(string sourceObjectName ,  string sourceResourceGroup ,  string targetLocation ,  string targetResourceGroup)
            {
                return new AzureImageCopyTask(sourceObjectName,  sourceResourceGroup,  targetLocation,  targetResourceGroup);
            }
        
    }
}

