
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Sig;

namespace FlubuCore.Azure
{
    public class Sig
    {
        
        
            public AzureSigCreateTask SigCreate(string galleryName ,  string resourceGroup)
            {
                return new AzureSigCreateTask(galleryName,  resourceGroup);
            }

            public AzureSigDeleteTask SigDelete(string galleryName ,  string resourceGroup)
            {
                return new AzureSigDeleteTask(galleryName,  resourceGroup);
            }

            public AzureSigUpdateTask SigUpdate(string gallery ,  string galleryName ,  string resourceGroup)
            {
                return new AzureSigUpdateTask(gallery,  galleryName,  resourceGroup);
            }

            public AzureSigImageDefinitionTask SigImageDefinition()
            {
                return new AzureSigImageDefinitionTask();
            }

            public AzureSigImageDefinitionCreateTask SigImageDefinitionCreate(string galleryImageDefinition ,  string galleryName ,  string offer ,  string osType ,  string publisher ,  string resourceGroup ,  string sku)
            {
                return new AzureSigImageDefinitionCreateTask(galleryImageDefinition,  galleryName,  offer,  osType,  publisher,  resourceGroup,  sku);
            }

            public AzureSigImageDefinitionDeleteTask SigImageDefinitionDelete(string galleryImageDefinition ,  string galleryName ,  string resourceGroup)
            {
                return new AzureSigImageDefinitionDeleteTask(galleryImageDefinition,  galleryName,  resourceGroup);
            }

            public AzureSigImageDefinitionUpdateTask SigImageDefinitionUpdate(string galleryImage ,  string galleryImageDefinition ,  string galleryName ,  string resourceGroup)
            {
                return new AzureSigImageDefinitionUpdateTask(galleryImage,  galleryImageDefinition,  galleryName,  resourceGroup);
            }

            public AzureSigImageVersionTask SigImageVersion()
            {
                return new AzureSigImageVersionTask();
            }

            public AzureSigImageVersionCreateTask SigImageVersionCreate(string galleryImageDefinition ,  string galleryImageVersion ,  string galleryName ,  string managedImage ,  string resourceGroup)
            {
                return new AzureSigImageVersionCreateTask(galleryImageDefinition,  galleryImageVersion,  galleryName,  managedImage,  resourceGroup);
            }

            public AzureSigImageVersionDeleteTask SigImageVersionDelete(string galleryImageDefinition ,  string galleryImageVersion ,  string galleryName ,  string resourceGroup)
            {
                return new AzureSigImageVersionDeleteTask(galleryImageDefinition,  galleryImageVersion,  galleryName,  resourceGroup);
            }

            public AzureSigImageVersionUpdateTask SigImageVersionUpdate(string galleryImageDefinition ,  string galleryImageVersion ,  string galleryImageVersionName ,  string galleryName ,  string resourceGroup)
            {
                return new AzureSigImageVersionUpdateTask(galleryImageDefinition,  galleryImageVersion,  galleryImageVersionName,  galleryName,  resourceGroup);
            }
        
    }
}

