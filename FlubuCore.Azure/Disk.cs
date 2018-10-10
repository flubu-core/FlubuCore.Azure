
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Disk;

namespace FlubuCore.Azure
{
    public class Disk
    {
        
        
            public AzureDiskCreateTask DiskCreate(string name ,  string resourceGroup)
            {
                return new AzureDiskCreateTask(name,  resourceGroup);
            }

            public AzureDiskDeleteTask DiskDelete(string name ,  string resourceGroup)
            {
                return new AzureDiskDeleteTask(name,  resourceGroup);
            }

            public AzureDiskGrantAccessTask DiskGrantAccess(string durationInSeconds ,  string name ,  string resourceGroup)
            {
                return new AzureDiskGrantAccessTask(durationInSeconds,  name,  resourceGroup);
            }

            public AzureDiskRevokeAccessTask DiskRevokeAccess(string name ,  string resourceGroup)
            {
                return new AzureDiskRevokeAccessTask(name,  resourceGroup);
            }

            public AzureDiskUpdateTask DiskUpdate(string name ,  string resourceGroup)
            {
                return new AzureDiskUpdateTask(name,  resourceGroup);
            }

            public AzureDiskWaitTask DiskWait(string name ,  string resourceGroup)
            {
                return new AzureDiskWaitTask(name,  resourceGroup);
            }
        
    }
}

