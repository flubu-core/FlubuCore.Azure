
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Ad;

namespace FlubuCore.Azure
{
    public class Ad
    {
        
        
            public AzureAdAppTask AdApp()
            {
                return new AzureAdAppTask();
            }

            public AzureAdAppCreateTask AdAppCreate(string displayName)
            {
                return new AzureAdAppCreateTask(displayName);
            }

            public AzureAdAppDeleteTask AdAppDelete(string id)
            {
                return new AzureAdAppDeleteTask(id);
            }

            public AzureAdAppUpdateTask AdAppUpdate(string id)
            {
                return new AzureAdAppUpdateTask(id);
            }

            public AzureAdGroupTask AdGroup()
            {
                return new AzureAdGroupTask();
            }

            public AzureAdGroupCreateTask AdGroupCreate(string displayName ,  string mailNickname)
            {
                return new AzureAdGroupCreateTask(displayName,  mailNickname);
            }

            public AzureAdGroupDeleteTask AdGroupDelete(string group)
            {
                return new AzureAdGroupDeleteTask(group);
            }

            public AzureAdGroupGetMemberGroupsTask AdGroupGetMemberGroups(string group)
            {
                return new AzureAdGroupGetMemberGroupsTask(group);
            }

            public AzureAdSpTask AdSp()
            {
                return new AzureAdSpTask();
            }

            public AzureAdSpCreateTask AdSpCreate(string id)
            {
                return new AzureAdSpCreateTask(id);
            }

            public AzureAdSpCreateForRbacTask AdSpCreateForRbac()
            {
                return new AzureAdSpCreateForRbacTask();
            }

            public AzureAdSpDeleteTask AdSpDelete(string id)
            {
                return new AzureAdSpDeleteTask(id);
            }

            public AzureAdUserTask AdUser()
            {
                return new AzureAdUserTask();
            }

            public AzureAdUserCreateTask AdUserCreate(string displayName ,  string password ,  string userPrincipalName)
            {
                return new AzureAdUserCreateTask(displayName,  password,  userPrincipalName);
            }

            public AzureAdUserDeleteTask AdUserDelete(string upnOrObjectId)
            {
                return new AzureAdUserDeleteTask(upnOrObjectId);
            }

            public AzureAdUserGetMemberGroupsTask AdUserGetMemberGroups(string upnOrObjectId)
            {
                return new AzureAdUserGetMemberGroupsTask(upnOrObjectId);
            }

            public AzureAdGroupMemberTask AdGroupMember()
            {
                return new AzureAdGroupMemberTask();
            }

            public AzureAdGroupMemberAddTask AdGroupMemberAdd(string group ,  string memberId)
            {
                return new AzureAdGroupMemberAddTask(group,  memberId);
            }

            public AzureAdGroupMemberCheckTask AdGroupMemberCheck(string group ,  string memberId)
            {
                return new AzureAdGroupMemberCheckTask(group,  memberId);
            }

            public AzureAdGroupMemberRemoveTask AdGroupMemberRemove(string group ,  string memberId)
            {
                return new AzureAdGroupMemberRemoveTask(group,  memberId);
            }

            public AzureAdSpCredentialTask AdSpCredential()
            {
                return new AzureAdSpCredentialTask();
            }

            public AzureAdSpCredentialDeleteTask AdSpCredentialDelete(string id ,  string keyId)
            {
                return new AzureAdSpCredentialDeleteTask(id,  keyId);
            }

            public AzureAdSpCredentialResetTask AdSpCredentialReset(string name)
            {
                return new AzureAdSpCredentialResetTask(name);
            }
        
    }
}

