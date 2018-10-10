
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappDeploymentSourceConfigTask : ExternalProcessTaskBase<AzureWebappDeploymentSourceConfigTask>
     {
        
        /// <summary>
        /// Manage deployment from git or Mercurial repositories.
        /// </summary>
        public AzureWebappDeploymentSourceConfigTask(string name = null ,  string repoUrl = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp deployment source config");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--repo-url");
            if (!string.IsNullOrEmpty(repoUrl))
            {
                 WithArguments(repoUrl);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The branch name of the repository.
        /// </summary>
        public AzureWebappDeploymentSourceConfigTask Branch(string branch = null)
        {
            WithArguments("--branch");
            if (!string.IsNullOrEmpty(branch))
            {
                 WithArguments(branch);
            }

            return this;
        }

        /// <summary>
        /// Git access token required for auto sync.
        /// </summary>
        public AzureWebappDeploymentSourceConfigTask GitToken(string gitToken = null)
        {
            WithArguments("--git-token");
            if (!string.IsNullOrEmpty(gitToken))
            {
                 WithArguments(gitToken);
            }

            return this;
        }

        /// <summary>
        /// Disable automatic sync between source control and web.
        /// </summary>
        public AzureWebappDeploymentSourceConfigTask ManualIntegration(string manualIntegration = null)
        {
            WithArguments("--manual-integration");
            if (!string.IsNullOrEmpty(manualIntegration))
            {
                 WithArguments(manualIntegration);
            }

            return this;
        }

        /// <summary>
        /// Repository type.
        /// </summary>
        public AzureWebappDeploymentSourceConfigTask RepositoryType(string repositoryType = null)
        {
            WithArguments("--repository-type");
            if (!string.IsNullOrEmpty(repositoryType))
            {
                 WithArguments(repositoryType);
            }

            return this;
        }

        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappDeploymentSourceConfigTask Slot(string slot = null)
        {
            WithArguments("--slot");
            if (!string.IsNullOrEmpty(slot))
            {
                 WithArguments(slot);
            }

            return this;
        }

        /// <summary>
        /// Working directory of the application. Default will be root of the repo.
        /// </summary>
        public AzureWebappDeploymentSourceConfigTask AppWorkingDir(string appWorkingDir = null)
        {
            WithArguments("--app-working-dir");
            if (!string.IsNullOrEmpty(appWorkingDir))
            {
                 WithArguments(appWorkingDir);
            }

            return this;
        }

        /// <summary>
        /// To create a new Visual Studio Team Services (VSTS) account if it doesn't exist already.
        /// </summary>
        public AzureWebappDeploymentSourceConfigTask CdAccountCreate(string cdAccountCreate = null)
        {
            WithArguments("--cd-account-create");
            if (!string.IsNullOrEmpty(cdAccountCreate))
            {
                 WithArguments(cdAccountCreate);
            }

            return this;
        }

        /// <summary>
        /// Web application framework you used to develop your app. Default is AspNet.
        /// </summary>
        public AzureWebappDeploymentSourceConfigTask CdAppType(string cdAppType = null)
        {
            WithArguments("--cd-app-type");
            if (!string.IsNullOrEmpty(cdAppType))
            {
                 WithArguments(cdAppType);
            }

            return this;
        }

        /// <summary>
        /// URL of the Visual Studio Team Services (VSTS) project to use for continuous delivery. URL should be in format https://&lt;accountname&gt;.visualstudio.com/&lt;projectname&gt;.
        /// </summary>
        public AzureWebappDeploymentSourceConfigTask CdProjectUrl(string cdProjectUrl = null)
        {
            WithArguments("--cd-project-url");
            if (!string.IsNullOrEmpty(cdProjectUrl))
            {
                 WithArguments(cdProjectUrl);
            }

            return this;
        }

        /// <summary>
        /// Task runner for nodejs. Default is None.
        /// </summary>
        public AzureWebappDeploymentSourceConfigTask NodejsTaskRunner(string nodejsTaskRunner = null)
        {
            WithArguments("--nodejs-task-runner");
            if (!string.IsNullOrEmpty(nodejsTaskRunner))
            {
                 WithArguments(nodejsTaskRunner);
            }

            return this;
        }

        /// <summary>
        /// Password for the private repository.
        /// </summary>
        public AzureWebappDeploymentSourceConfigTask PrivateRepoPassword(string privateRepoPassword = null)
        {
            WithArguments("--private-repo-password");
            if (!string.IsNullOrEmpty(privateRepoPassword))
            {
                 WithArguments(privateRepoPassword);
            }

            return this;
        }

        /// <summary>
        /// Username for the private repository.
        /// </summary>
        public AzureWebappDeploymentSourceConfigTask PrivateRepoUsername(string privateRepoUsername = null)
        {
            WithArguments("--private-repo-username");
            if (!string.IsNullOrEmpty(privateRepoUsername))
            {
                 WithArguments(privateRepoUsername);
            }

            return this;
        }

        /// <summary>
        /// Framework used for Python application. Default is Django.
        /// </summary>
        public AzureWebappDeploymentSourceConfigTask PythonFramework(string pythonFramework = null)
        {
            WithArguments("--python-framework");
            if (!string.IsNullOrEmpty(pythonFramework))
            {
                 WithArguments(pythonFramework);
            }

            return this;
        }

        /// <summary>
        /// Python version used for application. Default is Python 3.5.3 x86.
        /// </summary>
        public AzureWebappDeploymentSourceConfigTask PythonVersion(string pythonVersion = null)
        {
            WithArguments("--python-version");
            if (!string.IsNullOrEmpty(pythonVersion))
            {
                 WithArguments(pythonVersion);
            }

            return this;
        }

        /// <summary>
        /// Name of the slot to be used for deployment and later promote to production. If slot is not available, it will be created. Default: Not configured.
        /// </summary>
        public AzureWebappDeploymentSourceConfigTask SlotSwap(string slotSwap = null)
        {
            WithArguments("--slot-swap");
            if (!string.IsNullOrEmpty(slotSwap))
            {
                 WithArguments(slotSwap);
            }

            return this;
        }

        /// <summary>
        /// Name of the web app to be used for load testing. If web app is not available, it will be created. Default: Disable.
        /// </summary>
        public AzureWebappDeploymentSourceConfigTask Test(string test = null)
        {
            WithArguments("--test");
            if (!string.IsNullOrEmpty(test))
            {
                 WithArguments(test);
            }

            return this;
        }
     }
}
