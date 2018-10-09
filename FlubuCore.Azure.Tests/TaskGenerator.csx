#r ".\..\lib\YamlDotNet.dll"
#r ".\..\lib\Newtonsoft.Json.dll"
#r ".\..\lib\FlubuCore.TaskGenerator.dll"
#r ".\..\lib\FlubuCore.Azure.dll"
var reader = new FlubuCore.Azure.AzureReader();
var azureItems = reader.Read();
var parser = new FlubuCore.Azure.AzureParser();
var tasks = parser.Parse(azureItems);
var generator = new FlubuCore.Azure.AzureTaskGenerator(Context);
generator.GenerateTasks(tasks);