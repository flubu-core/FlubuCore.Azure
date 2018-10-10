
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Mesh;

namespace FlubuCore.Azure
{
    public class Mesh
    {
        
        
            public AzureMeshAppTask MeshApp()
            {
                return new AzureMeshAppTask();
            }

            public AzureMeshAppDeleteTask MeshAppDelete(string name ,  string resourceGroup)
            {
                return new AzureMeshAppDeleteTask(name,  resourceGroup);
            }

            public AzureMeshCodePackageLogTask MeshCodePackageLog()
            {
                return new AzureMeshCodePackageLogTask();
            }

            public AzureMeshCodePackageLogGetTask MeshCodePackageLogGet(string appName ,  string codePackageName ,  string replicaName ,  string resourceGroup ,  string serviceName)
            {
                return new AzureMeshCodePackageLogGetTask(appName,  codePackageName,  replicaName,  resourceGroup,  serviceName);
            }

            public AzureMeshDeploymentTask MeshDeployment()
            {
                return new AzureMeshDeploymentTask();
            }

            public AzureMeshDeploymentCreateTask MeshDeploymentCreate(string resourceGroup)
            {
                return new AzureMeshDeploymentCreateTask(resourceGroup);
            }

            public AzureMeshNetworkTask MeshNetwork()
            {
                return new AzureMeshNetworkTask();
            }

            public AzureMeshNetworkDeleteTask MeshNetworkDelete(string name ,  string resourceGroup)
            {
                return new AzureMeshNetworkDeleteTask(name,  resourceGroup);
            }

            public AzureMeshServiceReplicaTask MeshServiceReplica()
            {
                return new AzureMeshServiceReplicaTask();
            }

            public AzureMeshServiceTask MeshService()
            {
                return new AzureMeshServiceTask();
            }

            public AzureMeshVolumeTask MeshVolume()
            {
                return new AzureMeshVolumeTask();
            }

            public AzureMeshVolumeCreateTask MeshVolumeCreate(string location ,  string name ,  string resourceGroup)
            {
                return new AzureMeshVolumeCreateTask(location,  name,  resourceGroup);
            }

            public AzureMeshVolumeDeleteTask MeshVolumeDelete(string name ,  string resourceGroup)
            {
                return new AzureMeshVolumeDeleteTask(name,  resourceGroup);
            }
        
    }
}

