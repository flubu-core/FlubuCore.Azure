
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Snapshot;

namespace FlubuCore.Azure
{
    public class Snapshot
    {
        
        
            public AzureSnapshotCreateTask SnapshotCreate(string name ,  string resourceGroup)
            {
                return new AzureSnapshotCreateTask(name,  resourceGroup);
            }

            public AzureSnapshotDeleteTask SnapshotDelete(string name ,  string resourceGroup)
            {
                return new AzureSnapshotDeleteTask(name,  resourceGroup);
            }

            public AzureSnapshotGrantAccessTask SnapshotGrantAccess(string durationInSeconds ,  string name ,  string resourceGroup)
            {
                return new AzureSnapshotGrantAccessTask(durationInSeconds,  name,  resourceGroup);
            }

            public AzureSnapshotRevokeAccessTask SnapshotRevokeAccess(string name ,  string resourceGroup)
            {
                return new AzureSnapshotRevokeAccessTask(name,  resourceGroup);
            }

            public AzureSnapshotUpdateTask SnapshotUpdate(string name ,  string resourceGroup)
            {
                return new AzureSnapshotUpdateTask(name,  resourceGroup);
            }
        
    }
}

