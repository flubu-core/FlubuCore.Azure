
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Role;

namespace FlubuCore.Azure
{
    public class Role
    {
        
        
            public AzureRoleAssignmentTask RoleAssignment()
            {
                return new AzureRoleAssignmentTask();
            }

            public AzureRoleAssignmentCreateTask RoleAssignmentCreate(string role)
            {
                return new AzureRoleAssignmentCreateTask(role);
            }

            public AzureRoleAssignmentDeleteTask RoleAssignmentDelete()
            {
                return new AzureRoleAssignmentDeleteTask();
            }

            public AzureRoleDefinitionTask RoleDefinition()
            {
                return new AzureRoleDefinitionTask();
            }

            public AzureRoleDefinitionCreateTask RoleDefinitionCreate(string roleDefinition)
            {
                return new AzureRoleDefinitionCreateTask(roleDefinition);
            }

            public AzureRoleDefinitionDeleteTask RoleDefinitionDelete(string name)
            {
                return new AzureRoleDefinitionDeleteTask(name);
            }

            public AzureRoleDefinitionUpdateTask RoleDefinitionUpdate(string roleDefinition)
            {
                return new AzureRoleDefinitionUpdateTask(roleDefinition);
            }
        
    }
}

