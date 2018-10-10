
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Vm;

namespace FlubuCore.Azure
{
    public class Vm
    {
        
        
            public AzureVmCaptureTask VmCapture(string name ,  string resourceGroup ,  string vhdNamePrefix)
            {
                return new AzureVmCaptureTask(name,  resourceGroup,  vhdNamePrefix);
            }

            public AzureVmConvertTask VmConvert(string name ,  string resourceGroup)
            {
                return new AzureVmConvertTask(name,  resourceGroup);
            }

            public AzureVmCreateTask VmCreate(string name ,  string resourceGroup)
            {
                return new AzureVmCreateTask(name,  resourceGroup);
            }

            public AzureVmDeallocateTask VmDeallocate(string name ,  string resourceGroup)
            {
                return new AzureVmDeallocateTask(name,  resourceGroup);
            }

            public AzureVmDeleteTask VmDelete(string name ,  string resourceGroup)
            {
                return new AzureVmDeleteTask(name,  resourceGroup);
            }

            public AzureVmGeneralizeTask VmGeneralize(string name ,  string resourceGroup)
            {
                return new AzureVmGeneralizeTask(name,  resourceGroup);
            }

            public AzureVmGetInstanceViewTask VmGetInstanceView(string name ,  string resourceGroup)
            {
                return new AzureVmGetInstanceViewTask(name,  resourceGroup);
            }

            public AzureVmOpenPortTask VmOpenPort(string name ,  string port ,  string resourceGroup)
            {
                return new AzureVmOpenPortTask(name,  port,  resourceGroup);
            }

            public AzureVmPerformMaintenanceTask VmPerformMaintenance(string name ,  string resourceGroup)
            {
                return new AzureVmPerformMaintenanceTask(name,  resourceGroup);
            }

            public AzureVmRedeployTask VmRedeploy(string name ,  string resourceGroup)
            {
                return new AzureVmRedeployTask(name,  resourceGroup);
            }

            public AzureVmResizeTask VmResize(string name ,  string resourceGroup ,  string size)
            {
                return new AzureVmResizeTask(name,  resourceGroup,  size);
            }

            public AzureVmRestartTask VmRestart(string name ,  string resourceGroup)
            {
                return new AzureVmRestartTask(name,  resourceGroup);
            }

            public AzureVmStartTask VmStart(string name ,  string resourceGroup)
            {
                return new AzureVmStartTask(name,  resourceGroup);
            }

            public AzureVmStopTask VmStop(string name ,  string resourceGroup)
            {
                return new AzureVmStopTask(name,  resourceGroup);
            }

            public AzureVmUpdateTask VmUpdate(string name ,  string resourceGroup)
            {
                return new AzureVmUpdateTask(name,  resourceGroup);
            }

            public AzureVmWaitTask VmWait(string name ,  string resourceGroup)
            {
                return new AzureVmWaitTask(name,  resourceGroup);
            }

            public AzureVmAemTask VmAem()
            {
                return new AzureVmAemTask();
            }

            public AzureVmAemDeleteTask VmAemDelete(string name ,  string resourceGroup)
            {
                return new AzureVmAemDeleteTask(name,  resourceGroup);
            }

            public AzureVmAemSetTask VmAemSet(string name ,  string resourceGroup)
            {
                return new AzureVmAemSetTask(name,  resourceGroup);
            }

            public AzureVmAemVerifyTask VmAemVerify(string name ,  string resourceGroup)
            {
                return new AzureVmAemVerifyTask(name,  resourceGroup);
            }

            public AzureVmAvailabilitySetTask VmAvailabilitySet()
            {
                return new AzureVmAvailabilitySetTask();
            }

            public AzureVmAvailabilitySetConvertTask VmAvailabilitySetConvert(string name ,  string resourceGroup)
            {
                return new AzureVmAvailabilitySetConvertTask(name,  resourceGroup);
            }

            public AzureVmAvailabilitySetCreateTask VmAvailabilitySetCreate(string name ,  string resourceGroup)
            {
                return new AzureVmAvailabilitySetCreateTask(name,  resourceGroup);
            }

            public AzureVmAvailabilitySetDeleteTask VmAvailabilitySetDelete(string name ,  string resourceGroup)
            {
                return new AzureVmAvailabilitySetDeleteTask(name,  resourceGroup);
            }

            public AzureVmAvailabilitySetUpdateTask VmAvailabilitySetUpdate(string name ,  string resourceGroup)
            {
                return new AzureVmAvailabilitySetUpdateTask(name,  resourceGroup);
            }

            public AzureVmBootDiagnosticsTask VmBootDiagnostics()
            {
                return new AzureVmBootDiagnosticsTask();
            }

            public AzureVmBootDiagnosticsDisableTask VmBootDiagnosticsDisable(string name ,  string resourceGroup)
            {
                return new AzureVmBootDiagnosticsDisableTask(name,  resourceGroup);
            }

            public AzureVmBootDiagnosticsEnableTask VmBootDiagnosticsEnable(string name ,  string resourceGroup ,  string storage)
            {
                return new AzureVmBootDiagnosticsEnableTask(name,  resourceGroup,  storage);
            }

            public AzureVmBootDiagnosticsGetBootLogTask VmBootDiagnosticsGetBootLog(string name ,  string resourceGroup)
            {
                return new AzureVmBootDiagnosticsGetBootLogTask(name,  resourceGroup);
            }

            public AzureVmDiagnosticsTask VmDiagnostics()
            {
                return new AzureVmDiagnosticsTask();
            }

            public AzureVmDiagnosticsGetDefaultConfigTask VmDiagnosticsGetDefaultConfig()
            {
                return new AzureVmDiagnosticsGetDefaultConfigTask();
            }

            public AzureVmDiagnosticsSetTask VmDiagnosticsSet(string resourceGroup ,  string settings ,  string vmName)
            {
                return new AzureVmDiagnosticsSetTask(resourceGroup,  settings,  vmName);
            }

            public AzureVmDiskTask VmDisk()
            {
                return new AzureVmDiskTask();
            }

            public AzureVmDiskAttachTask VmDiskAttach(string disk ,  string resourceGroup ,  string vmName)
            {
                return new AzureVmDiskAttachTask(disk,  resourceGroup,  vmName);
            }

            public AzureVmDiskDetachTask VmDiskDetach(string name ,  string resourceGroup ,  string vmName)
            {
                return new AzureVmDiskDetachTask(name,  resourceGroup,  vmName);
            }

            public AzureVmEncryptionTask VmEncryption()
            {
                return new AzureVmEncryptionTask();
            }

            public AzureVmEncryptionDisableTask VmEncryptionDisable(string name ,  string resourceGroup)
            {
                return new AzureVmEncryptionDisableTask(name,  resourceGroup);
            }

            public AzureVmEncryptionEnableTask VmEncryptionEnable(string diskEncryptionKeyvault ,  string name ,  string resourceGroup)
            {
                return new AzureVmEncryptionEnableTask(diskEncryptionKeyvault,  name,  resourceGroup);
            }

            public AzureVmExtensionTask VmExtension()
            {
                return new AzureVmExtensionTask();
            }

            public AzureVmExtensionDeleteTask VmExtensionDelete(string name ,  string resourceGroup ,  string vmName)
            {
                return new AzureVmExtensionDeleteTask(name,  resourceGroup,  vmName);
            }

            public AzureVmExtensionSetTask VmExtensionSet(string name ,  string publisher ,  string resourceGroup ,  string vmName)
            {
                return new AzureVmExtensionSetTask(name,  publisher,  resourceGroup,  vmName);
            }

            public AzureVmExtensionWaitTask VmExtensionWait(string name ,  string resourceGroup ,  string vmName)
            {
                return new AzureVmExtensionWaitTask(name,  resourceGroup,  vmName);
            }

            public AzureVmIdentityTask VmIdentity()
            {
                return new AzureVmIdentityTask();
            }

            public AzureVmIdentityAssignTask VmIdentityAssign(string name ,  string resourceGroup)
            {
                return new AzureVmIdentityAssignTask(name,  resourceGroup);
            }

            public AzureVmIdentityRemoveTask VmIdentityRemove(string name ,  string resourceGroup)
            {
                return new AzureVmIdentityRemoveTask(name,  resourceGroup);
            }

            public AzureVmImageTask VmImage()
            {
                return new AzureVmImageTask();
            }

            public AzureVmImageAcceptTermsTask VmImageAcceptTerms()
            {
                return new AzureVmImageAcceptTermsTask();
            }

            public AzureVmNicTask VmNic()
            {
                return new AzureVmNicTask();
            }

            public AzureVmNicAddTask VmNicAdd(string nics ,  string resourceGroup ,  string vmName)
            {
                return new AzureVmNicAddTask(nics,  resourceGroup,  vmName);
            }

            public AzureVmNicRemoveTask VmNicRemove(string nics ,  string resourceGroup ,  string vmName)
            {
                return new AzureVmNicRemoveTask(nics,  resourceGroup,  vmName);
            }

            public AzureVmNicSetTask VmNicSet(string nics ,  string resourceGroup ,  string vmName)
            {
                return new AzureVmNicSetTask(nics,  resourceGroup,  vmName);
            }

            public AzureVmRunCommandTask VmRunCommand()
            {
                return new AzureVmRunCommandTask();
            }

            public AzureVmRunCommandInvokeTask VmRunCommandInvoke(string commandId ,  string name ,  string resourceGroup)
            {
                return new AzureVmRunCommandInvokeTask(commandId,  name,  resourceGroup);
            }

            public AzureVmSecretTask VmSecret()
            {
                return new AzureVmSecretTask();
            }

            public AzureVmSecretAddTask VmSecretAdd(string certificate ,  string keyvault ,  string name ,  string resourceGroup)
            {
                return new AzureVmSecretAddTask(certificate,  keyvault,  name,  resourceGroup);
            }

            public AzureVmSecretFormatTask VmSecretFormat(string secrets)
            {
                return new AzureVmSecretFormatTask(secrets);
            }

            public AzureVmSecretRemoveTask VmSecretRemove(string keyvault ,  string name ,  string resourceGroup)
            {
                return new AzureVmSecretRemoveTask(keyvault,  name,  resourceGroup);
            }

            public AzureVmUnmanagedDiskTask VmUnmanagedDisk()
            {
                return new AzureVmUnmanagedDiskTask();
            }

            public AzureVmUnmanagedDiskAttachTask VmUnmanagedDiskAttach(string resourceGroup ,  string vmName)
            {
                return new AzureVmUnmanagedDiskAttachTask(resourceGroup,  vmName);
            }

            public AzureVmUnmanagedDiskDetachTask VmUnmanagedDiskDetach(string name ,  string resourceGroup ,  string vmName)
            {
                return new AzureVmUnmanagedDiskDetachTask(name,  resourceGroup,  vmName);
            }

            public AzureVmUserTask VmUser()
            {
                return new AzureVmUserTask();
            }

            public AzureVmUserDeleteTask VmUserDelete(string name ,  string resourceGroup ,  string username)
            {
                return new AzureVmUserDeleteTask(name,  resourceGroup,  username);
            }

            public AzureVmUserResetSshTask VmUserResetSsh(string name ,  string resourceGroup)
            {
                return new AzureVmUserResetSshTask(name,  resourceGroup);
            }

            public AzureVmUserUpdateTask VmUserUpdate(string name ,  string resourceGroup ,  string username)
            {
                return new AzureVmUserUpdateTask(name,  resourceGroup,  username);
            }

            public AzureVmExtensionImageTask VmExtensionImage()
            {
                return new AzureVmExtensionImageTask();
            }
        
    }
}

