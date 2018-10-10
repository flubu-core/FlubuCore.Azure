
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Policy;

namespace FlubuCore.Azure
{
    public class Policy
    {
        
        
            public AzurePolicyAssignmentTask PolicyAssignment()
            {
                return new AzurePolicyAssignmentTask();
            }

            public AzurePolicyAssignmentCreateTask PolicyAssignmentCreate()
            {
                return new AzurePolicyAssignmentCreateTask();
            }

            public AzurePolicyAssignmentDeleteTask PolicyAssignmentDelete(string name)
            {
                return new AzurePolicyAssignmentDeleteTask(name);
            }

            public AzurePolicyDefinitionTask PolicyDefinition()
            {
                return new AzurePolicyDefinitionTask();
            }

            public AzurePolicyDefinitionCreateTask PolicyDefinitionCreate(string name)
            {
                return new AzurePolicyDefinitionCreateTask(name);
            }

            public AzurePolicyDefinitionDeleteTask PolicyDefinitionDelete(string name)
            {
                return new AzurePolicyDefinitionDeleteTask(name);
            }

            public AzurePolicyDefinitionUpdateTask PolicyDefinitionUpdate(string name)
            {
                return new AzurePolicyDefinitionUpdateTask(name);
            }

            public AzurePolicyEventTask PolicyEvent()
            {
                return new AzurePolicyEventTask();
            }

            public AzurePolicySetDefinitionTask PolicySetDefinition()
            {
                return new AzurePolicySetDefinitionTask();
            }

            public AzurePolicySetDefinitionCreateTask PolicySetDefinitionCreate(string definitions ,  string name)
            {
                return new AzurePolicySetDefinitionCreateTask(definitions,  name);
            }

            public AzurePolicySetDefinitionDeleteTask PolicySetDefinitionDelete(string name)
            {
                return new AzurePolicySetDefinitionDeleteTask(name);
            }

            public AzurePolicySetDefinitionUpdateTask PolicySetDefinitionUpdate(string name)
            {
                return new AzurePolicySetDefinitionUpdateTask(name);
            }

            public AzurePolicyStateTask PolicyState()
            {
                return new AzurePolicyStateTask();
            }

            public AzurePolicyStateSummarizeTask PolicyStateSummarize()
            {
                return new AzurePolicyStateSummarizeTask();
            }
        
    }
}

