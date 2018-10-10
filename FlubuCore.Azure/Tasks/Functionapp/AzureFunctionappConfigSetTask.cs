
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappConfigSetTask : ExternalProcessTaskBase<AzureFunctionappConfigSetTask>
     {
        
        /// <summary>
        /// Set the web app's configuration.
        /// </summary>
        public AzureFunctionappConfigSetTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az functionapp config set");
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
        /// Ensure webapp gets loaded all the time, rather unloaded after been idle. Recommended when you have continuous web jobs running.
        /// </summary>
        public AzureFunctionappConfigSetTask AlwaysOn(string alwaysOn = null)
        {
            WithArguments("--always-on");
            if (!string.IsNullOrEmpty(alwaysOn))
            {
                 WithArguments(alwaysOn);
            }

            return this;
        }

        /// <summary>
        /// Enable or disable auto heal.
        /// </summary>
        public AzureFunctionappConfigSetTask AutoHealEnabled(string autoHealEnabled = null)
        {
            WithArguments("--auto-heal-enabled");
            if (!string.IsNullOrEmpty(autoHealEnabled))
            {
                 WithArguments(autoHealEnabled);
            }

            return this;
        }

        /// <summary>
        /// Set the Ftps state value for an app. Default value is 'AllAllowed'.
        /// </summary>
        public AzureFunctionappConfigSetTask FtpsState(string ftpsState = null)
        {
            WithArguments("--ftps-state");
            if (!string.IsNullOrEmpty(ftpsState))
            {
                 WithArguments(ftpsState);
            }

            return this;
        }

        /// <summary>
        /// Configures a web site to allow clients to connect over http2.0.
        /// </summary>
        public AzureFunctionappConfigSetTask Http20Enabled(string http20Enabled = null)
        {
            WithArguments("--http20-enabled");
            if (!string.IsNullOrEmpty(http20Enabled))
            {
                 WithArguments(http20Enabled);
            }

            return this;
        }

        /// <summary>
        /// The java container, e.g., Tomcat, Jetty.
        /// </summary>
        public AzureFunctionappConfigSetTask JavaContainer(string javaContainer = null)
        {
            WithArguments("--java-container");
            if (!string.IsNullOrEmpty(javaContainer))
            {
                 WithArguments(javaContainer);
            }

            return this;
        }

        /// <summary>
        /// The version of the java container, e.g., '8.0.23' for Tomcat.
        /// </summary>
        public AzureFunctionappConfigSetTask JavaContainerVersion(string javaContainerVersion = null)
        {
            WithArguments("--java-container-version");
            if (!string.IsNullOrEmpty(javaContainerVersion))
            {
                 WithArguments(javaContainerVersion);
            }

            return this;
        }

        /// <summary>
        /// The version used to run your web app if using Java, e.g., '1.7' for Java 7, '1.8' for Java 8.
        /// </summary>
        public AzureFunctionappConfigSetTask JavaVersion(string javaVersion = null)
        {
            WithArguments("--java-version");
            if (!string.IsNullOrEmpty(javaVersion))
            {
                 WithArguments(javaVersion);
            }

            return this;
        }

        /// <summary>
        /// The runtime stack used for your linux-based webapp, e.g., "RUBY|2.3", "NODE|6.6", "PHP|5.6", "DOTNETCORE|1.1.0". See <a href="https://aka.ms/linux-stacks">https://aka.ms/linux-stacks</a> for more info.
        /// </summary>
        public AzureFunctionappConfigSetTask LinuxFxVersion(string linuxFxVersion = null)
        {
            WithArguments("--linux-fx-version");
            if (!string.IsNullOrEmpty(linuxFxVersion))
            {
                 WithArguments(linuxFxVersion);
            }

            return this;
        }

        /// <summary>
        /// The minimum version of TLS required for SSL requests, e.g., '1.0', '1.1', '1.2'.
        /// </summary>
        public AzureFunctionappConfigSetTask MinTlsVersion(string minTlsVersion = null)
        {
            WithArguments("--min-tls-version");
            if (!string.IsNullOrEmpty(minTlsVersion))
            {
                 WithArguments(minTlsVersion);
            }

            return this;
        }

        /// <summary>
        /// The version used to run your web app if using .NET Framework, e.g., 'v4.0' for .NET 4.6 and 'v3.0' for .NET 3.5.
        /// </summary>
        public AzureFunctionappConfigSetTask NetFrameworkVersion(string netFrameworkVersion = null)
        {
            WithArguments("--net-framework-version");
            if (!string.IsNullOrEmpty(netFrameworkVersion))
            {
                 WithArguments(netFrameworkVersion);
            }

            return this;
        }

        /// <summary>
        /// The version used to run your web app if using PHP, e.g., 5.5, 5.6, 7.0.
        /// </summary>
        public AzureFunctionappConfigSetTask PhpVersion(string phpVersion = null)
        {
            WithArguments("--php-version");
            if (!string.IsNullOrEmpty(phpVersion))
            {
                 WithArguments(phpVersion);
            }

            return this;
        }

        /// <summary>
        /// The version used to run your web app if using Python, e.g., 2.7, 3.4.
        /// </summary>
        public AzureFunctionappConfigSetTask PythonVersion(string pythonVersion = null)
        {
            WithArguments("--python-version");
            if (!string.IsNullOrEmpty(pythonVersion))
            {
                 WithArguments(pythonVersion);
            }

            return this;
        }

        /// <summary>
        /// Enable or disable remote debugging.
        /// </summary>
        public AzureFunctionappConfigSetTask RemoteDebuggingEnabled(string remoteDebuggingEnabled = null)
        {
            WithArguments("--remote-debugging-enabled");
            if (!string.IsNullOrEmpty(remoteDebuggingEnabled))
            {
                 WithArguments(remoteDebuggingEnabled);
            }

            return this;
        }

        /// <summary>
        /// The startup file for linux hosted web apps, e.g. 'process.json' for Node.js web.
        /// </summary>
        public AzureFunctionappConfigSetTask StartupFile(string startupFile = null)
        {
            WithArguments("--startup-file");
            if (!string.IsNullOrEmpty(startupFile))
            {
                 WithArguments(startupFile);
            }

            return this;
        }

        /// <summary>
        /// Use 32 bits worker process or not.
        /// </summary>
        public AzureFunctionappConfigSetTask Use32bitWorkerProcess(string use32bitWorkerProcess = null)
        {
            WithArguments("--use-32bit-worker-process");
            if (!string.IsNullOrEmpty(use32bitWorkerProcess))
            {
                 WithArguments(use32bitWorkerProcess);
            }

            return this;
        }

        /// <summary>
        /// Enable or disable web sockets.
        /// </summary>
        public AzureFunctionappConfigSetTask WebSocketsEnabled(string webSocketsEnabled = null)
        {
            WithArguments("--web-sockets-enabled");
            if (!string.IsNullOrEmpty(webSocketsEnabled))
            {
                 WithArguments(webSocketsEnabled);
            }

            return this;
        }
     }
}
