using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace FlubuCore.Azure
{
    public class AzureReader
    {
        public List<Models.Azure> Read(string directory = "docs")
        {
            var files = Directory.GetFiles(directory, "*.yml", SearchOption.AllDirectories);

            List<string> Ymls = new List<string>();
            List<object> YmlObjects = new List<object>();
            foreach (var file in files)
            {
                if (file.EndsWith("Toc.yml", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                Ymls.Add(File.ReadAllText(file));
            }
            
            var deserializer = new Deserializer();

            foreach (var yml in Ymls)
            {
                var ret = new StringReader (yml);
                YmlObjects.Add(deserializer.Deserialize(ret));
            }

            Newtonsoft.Json.JsonSerializer js = new Newtonsoft.Json.JsonSerializer();
            List<Models.Azure> azures = new List<Models.Azure>();
            foreach (var ymlObject in YmlObjects)
            {
                var w = new StringWriter();
                js.Serialize(w, ymlObject);
                string jsonText = w.ToString();
                azures.Add(Models.Azure.FromJson(jsonText));
            }

            return azures;
        }
    }
}
