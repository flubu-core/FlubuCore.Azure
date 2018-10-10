
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Tag;

namespace FlubuCore.Azure
{
    public class Tag
    {
        
        
            public AzureTagAddValueTask TagAddValue(string name ,  string value)
            {
                return new AzureTagAddValueTask(name,  value);
            }

            public AzureTagCreateTask TagCreate(string name)
            {
                return new AzureTagCreateTask(name);
            }

            public AzureTagDeleteTask TagDelete(string name)
            {
                return new AzureTagDeleteTask(name);
            }

            public AzureTagRemoveValueTask TagRemoveValue(string name ,  string value)
            {
                return new AzureTagRemoveValueTask(name,  value);
            }
        
    }
}

