
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Resource;

namespace FlubuCore.Azure
{
    public class Resource
    {
        
        
            public AzureResourceCreateTask ResourceCreate(string properties)
            {
                return new AzureResourceCreateTask(properties);
            }

            public AzureResourceDeleteTask ResourceDelete()
            {
                return new AzureResourceDeleteTask();
            }

            public AzureResourceInvokeActionTask ResourceInvokeAction(string action)
            {
                return new AzureResourceInvokeActionTask(action);
            }

            public AzureResourceMoveTask ResourceMove(string destinationGroup ,  string ids)
            {
                return new AzureResourceMoveTask(destinationGroup,  ids);
            }

            public AzureResourceTagTask ResourceTag(string tags)
            {
                return new AzureResourceTagTask(tags);
            }

            public AzureResourceUpdateTask ResourceUpdate()
            {
                return new AzureResourceUpdateTask();
            }

            public AzureResourceLinkTask ResourceLink()
            {
                return new AzureResourceLinkTask();
            }

            public AzureResourceLinkCreateTask ResourceLinkCreate(string linkId ,  string targetId)
            {
                return new AzureResourceLinkCreateTask(linkId,  targetId);
            }

            public AzureResourceLinkDeleteTask ResourceLinkDelete(string linkId)
            {
                return new AzureResourceLinkDeleteTask(linkId);
            }

            public AzureResourceLinkUpdateTask ResourceLinkUpdate(string linkId)
            {
                return new AzureResourceLinkUpdateTask(linkId);
            }

            public AzureResourceLockTask ResourceLock()
            {
                return new AzureResourceLockTask();
            }

            public AzureResourceLockCreateTask ResourceLockCreate(string lockType ,  string name)
            {
                return new AzureResourceLockCreateTask(lockType,  name);
            }

            public AzureResourceLockDeleteTask ResourceLockDelete()
            {
                return new AzureResourceLockDeleteTask();
            }

            public AzureResourceLockUpdateTask ResourceLockUpdate()
            {
                return new AzureResourceLockUpdateTask();
            }
        
    }
}

