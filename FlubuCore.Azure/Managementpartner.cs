
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Managementpartner;

namespace FlubuCore.Azure
{
    public class Managementpartner
    {
        
        
            public AzureManagementpartnerCreateTask ManagementpartnerCreate(string partnerId)
            {
                return new AzureManagementpartnerCreateTask(partnerId);
            }

            public AzureManagementpartnerDeleteTask ManagementpartnerDelete(string partnerId)
            {
                return new AzureManagementpartnerDeleteTask(partnerId);
            }

            public AzureManagementpartnerUpdateTask ManagementpartnerUpdate(string partnerId)
            {
                return new AzureManagementpartnerUpdateTask(partnerId);
            }
        
    }
}

