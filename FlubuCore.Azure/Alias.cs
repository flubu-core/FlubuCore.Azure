
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Alias;

namespace FlubuCore.Azure
{
    public class Alias
    {
        
        
            public AzureAliasCreateTask AliasCreate(string command ,  string name)
            {
                return new AzureAliasCreateTask(command,  name);
            }

            public AzureAliasExportTask AliasExport()
            {
                return new AzureAliasExportTask();
            }

            public AzureAliasImportTask AliasImport(string source)
            {
                return new AzureAliasImportTask(source);
            }

            public AzureAliasRemoveTask AliasRemove(string name)
            {
                return new AzureAliasRemoveTask(name);
            }

            public AzureAliasRemoveAllTask AliasRemoveAll()
            {
                return new AzureAliasRemoveAllTask();
            }
        
    }
}

