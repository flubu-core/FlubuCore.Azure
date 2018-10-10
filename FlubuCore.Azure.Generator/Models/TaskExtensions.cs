using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlubuCore.Azure.Models
{
    public class TaskExtensions
    {
        public string FileName { get; set; }

        public string ExtensionName { get; set; }
        
        public string Namespace { get; set; }

        public List<string> Usings { get; set; } = new List<string>();

        public List<ExtensionMethod> Methods { get; set; } = new List<ExtensionMethod>();

        public List<TaskExtensions> SubExtensions { get; set; } = new List<TaskExtensions>();
    }

    public class ExtensionMethod
    {
        public string TaskName { get; set; }

        public string MethodName { get; set; }

        public List<TaskGenerator.Models.Parameter> Parameters { get; set; } = new List<TaskGenerator.Models.Parameter>();
    }

}
