using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;
using NJsonSchema.Generation;
using NJsonSchema.Yaml;
using Xunit;
using YamlDotNet.Serialization;

namespace FlubuCore.Azure.Tests
{
    public class AzureModelTests
    {
        [Fact]
        public async Task FromYaml()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetAsync("https://raw.githubusercontent.com/Azure/azure-docs-cli-python/9113bf87/latest/docs-ref-autogen/vmss.yml");

            var ret = new StringReader (await response.Content.ReadAsStringAsync());
            var deserializer = new Deserializer();
            object yamlObject = deserializer.Deserialize(ret);

            // now convert the object to JSON. Simple!
            Newtonsoft.Json.JsonSerializer js = new Newtonsoft.Json.JsonSerializer();
           
            var w = new StringWriter();
            js.Serialize(w, yamlObject);
            string jsonText = w.ToString();

             var azure = FlubuCore.Azure.Models.Azure.FromJson(jsonText);
            Assert.NotNull(azure);
        }
    }
}
