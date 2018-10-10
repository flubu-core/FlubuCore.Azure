
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Lab;

namespace FlubuCore.Azure
{
    public class Lab
    {
        
        
            public AzureLabDeleteTask LabDelete(string name ,  string resourceGroup)
            {
                return new AzureLabDeleteTask(name,  resourceGroup);
            }

            public AzureLabGetTask LabGet(string name ,  string resourceGroup)
            {
                return new AzureLabGetTask(name,  resourceGroup);
            }

            public AzureLabArmTemplateTask LabArmTemplate()
            {
                return new AzureLabArmTemplateTask();
            }

            public AzureLabArtifactSourceTask LabArtifactSource()
            {
                return new AzureLabArtifactSourceTask();
            }

            public AzureLabArtifactTask LabArtifact()
            {
                return new AzureLabArtifactTask();
            }

            public AzureLabCustomImageTask LabCustomImage()
            {
                return new AzureLabCustomImageTask();
            }

            public AzureLabCustomImageCreateTask LabCustomImageCreate(string labName ,  string name ,  string osState ,  string osType ,  string resourceGroup ,  string sourceVmId)
            {
                return new AzureLabCustomImageCreateTask(labName,  name,  osState,  osType,  resourceGroup,  sourceVmId);
            }

            public AzureLabCustomImageDeleteTask LabCustomImageDelete(string labName ,  string name ,  string resourceGroup)
            {
                return new AzureLabCustomImageDeleteTask(labName,  name,  resourceGroup);
            }

            public AzureLabEnvironmentTask LabEnvironment()
            {
                return new AzureLabEnvironmentTask();
            }

            public AzureLabEnvironmentCreateTask LabEnvironmentCreate(string armTemplate ,  string labName ,  string name ,  string resourceGroup)
            {
                return new AzureLabEnvironmentCreateTask(armTemplate,  labName,  name,  resourceGroup);
            }

            public AzureLabEnvironmentDeleteTask LabEnvironmentDelete(string labName ,  string name ,  string resourceGroup)
            {
                return new AzureLabEnvironmentDeleteTask(labName,  name,  resourceGroup);
            }

            public AzureLabFormulaTask LabFormula()
            {
                return new AzureLabFormulaTask();
            }

            public AzureLabFormulaDeleteTask LabFormulaDelete(string labName ,  string name ,  string resourceGroup)
            {
                return new AzureLabFormulaDeleteTask(labName,  name,  resourceGroup);
            }

            public AzureLabFormulaExportArtifactsTask LabFormulaExportArtifacts(string labName ,  string name ,  string resourceGroup)
            {
                return new AzureLabFormulaExportArtifactsTask(labName,  name,  resourceGroup);
            }

            public AzureLabGalleryImageTask LabGalleryImage()
            {
                return new AzureLabGalleryImageTask();
            }

            public AzureLabSecretTask LabSecret()
            {
                return new AzureLabSecretTask();
            }

            public AzureLabSecretDeleteTask LabSecretDelete(string labName ,  string name ,  string resourceGroup)
            {
                return new AzureLabSecretDeleteTask(labName,  name,  resourceGroup);
            }

            public AzureLabSecretSetTask LabSecretSet(string labName ,  string name ,  string resourceGroup ,  string value)
            {
                return new AzureLabSecretSetTask(labName,  name,  resourceGroup,  value);
            }

            public AzureLabVmTask LabVm()
            {
                return new AzureLabVmTask();
            }

            public AzureLabVmApplyArtifactsTask LabVmApplyArtifacts(string labName ,  string name ,  string resourceGroup)
            {
                return new AzureLabVmApplyArtifactsTask(labName,  name,  resourceGroup);
            }

            public AzureLabVmClaimTask LabVmClaim()
            {
                return new AzureLabVmClaimTask();
            }

            public AzureLabVmCreateTask LabVmCreate(string labName ,  string name ,  string resourceGroup)
            {
                return new AzureLabVmCreateTask(labName,  name,  resourceGroup);
            }

            public AzureLabVmDeleteTask LabVmDelete(string labName ,  string name ,  string resourceGroup)
            {
                return new AzureLabVmDeleteTask(labName,  name,  resourceGroup);
            }

            public AzureLabVmStartTask LabVmStart(string labName ,  string name ,  string resourceGroup)
            {
                return new AzureLabVmStartTask(labName,  name,  resourceGroup);
            }

            public AzureLabVmStopTask LabVmStop(string labName ,  string name ,  string resourceGroup)
            {
                return new AzureLabVmStopTask(labName,  name,  resourceGroup);
            }

            public AzureLabVnetTask LabVnet()
            {
                return new AzureLabVnetTask();
            }

            public AzureLabVnetGetTask LabVnetGet(string labName ,  string name ,  string resourceGroup)
            {
                return new AzureLabVnetGetTask(labName,  name,  resourceGroup);
            }
        
    }
}

