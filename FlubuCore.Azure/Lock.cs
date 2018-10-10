
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Lock;

namespace FlubuCore.Azure
{
    public class Lock
    {
        
        
            public AzureLockCreateTask LockCreate(string lockType ,  string name)
            {
                return new AzureLockCreateTask(lockType,  name);
            }

            public AzureLockDeleteTask LockDelete()
            {
                return new AzureLockDeleteTask();
            }

            public AzureLockUpdateTask LockUpdate()
            {
                return new AzureLockUpdateTask();
            }
        
    }
}

