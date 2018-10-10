
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batchai
{
     public partial class AzureBatchaiJobNodeExecTask : ExternalProcessTaskBase<AzureBatchaiJobNodeExecTask>
     {
        
        /// <summary>
        /// Executes a command line on a cluster's node used to execute the job with optional ports forwarding.
        /// </summary>
        public AzureBatchaiJobNodeExecTask(string experiment = null ,  string job = null ,  string resourceGroup = null ,  string workspace = null)
        {
            WithArguments("az batchai job node exec");
WithArguments("--experiment");
            if (!string.IsNullOrEmpty(experiment))
            {
                 WithArguments(experiment);
            }

WithArguments("--job");
            if (!string.IsNullOrEmpty(job))
            {
                 WithArguments(job);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--workspace");
            if (!string.IsNullOrEmpty(workspace))
            {
                 WithArguments(workspace);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Specifies that connections to the given TCP port or Unix socket on the local (client) host are to be forwarded to the given host and port, or Unix socket, on the remote side. e.g. -L 8080:localhost:8080.
        /// </summary>
        public AzureBatchaiJobNodeExecTask Address(string address = null)
        {
            WithArguments("--address");
            if (!string.IsNullOrEmpty(address))
            {
                 WithArguments(address);
            }

            return this;
        }

        /// <summary>
        /// Optional command line to be executed on the node. If not provided, the command will perform ports forwarding only.
        /// </summary>
        public AzureBatchaiJobNodeExecTask Exec(string exec = null)
        {
            WithArguments("--exec");
            if (!string.IsNullOrEmpty(exec))
            {
                 WithArguments(exec);
            }

            return this;
        }

        /// <summary>
        /// ID of the node to forward the ports to. If not provided, the command will be executed on the first available node.
        /// </summary>
        public AzureBatchaiJobNodeExecTask NodeId(string nodeId = null)
        {
            WithArguments("--node-id");
            if (!string.IsNullOrEmpty(nodeId))
            {
                 WithArguments(nodeId);
            }

            return this;
        }

        /// <summary>
        /// Optional password to establish SSH connection.
        /// </summary>
        public AzureBatchaiJobNodeExecTask Password(string password = null)
        {
            WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
            }

            return this;
        }

        /// <summary>
        /// Optional SSH private key path to establish SSH connection. If omitted, the default SSH private key will be used.
        /// </summary>
        public AzureBatchaiJobNodeExecTask SshPrivateKey(string sshPrivateKey = null)
        {
            WithArguments("--ssh-private-key");
            if (!string.IsNullOrEmpty(sshPrivateKey))
            {
                 WithArguments(sshPrivateKey);
            }

            return this;
        }
     }
}
