
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Acs;

namespace FlubuCore.Azure
{
    public class Acs
    {
        
        
            public AzureAcsBrowseTask AcsBrowse(string name ,  string resourceGroup)
            {
                return new AzureAcsBrowseTask(name,  resourceGroup);
            }

            public AzureAcsCreateTask AcsCreate(string name ,  string resourceGroup)
            {
                return new AzureAcsCreateTask(name,  resourceGroup);
            }

            public AzureAcsDeleteTask AcsDelete(string name ,  string resourceGroup)
            {
                return new AzureAcsDeleteTask(name,  resourceGroup);
            }

            public AzureAcsScaleTask AcsScale(string name ,  string newAgentCount ,  string resourceGroup)
            {
                return new AzureAcsScaleTask(name,  newAgentCount,  resourceGroup);
            }

            public AzureAcsWaitTask AcsWait(string name ,  string resourceGroup)
            {
                return new AzureAcsWaitTask(name,  resourceGroup);
            }

            public AzureAcsDcosTask AcsDcos()
            {
                return new AzureAcsDcosTask();
            }

            public AzureAcsDcosBrowseTask AcsDcosBrowse(string name ,  string resourceGroup)
            {
                return new AzureAcsDcosBrowseTask(name,  resourceGroup);
            }

            public AzureAcsDcosInstallCliTask AcsDcosInstallCli()
            {
                return new AzureAcsDcosInstallCliTask();
            }

            public AzureAcsKubernetesTask AcsKubernetes()
            {
                return new AzureAcsKubernetesTask();
            }

            public AzureAcsKubernetesBrowseTask AcsKubernetesBrowse(string name ,  string resourceGroup)
            {
                return new AzureAcsKubernetesBrowseTask(name,  resourceGroup);
            }

            public AzureAcsKubernetesGetCredentialsTask AcsKubernetesGetCredentials(string name ,  string resourceGroup)
            {
                return new AzureAcsKubernetesGetCredentialsTask(name,  resourceGroup);
            }

            public AzureAcsKubernetesInstallCliTask AcsKubernetesInstallCli()
            {
                return new AzureAcsKubernetesInstallCliTask();
            }
        
    }
}

