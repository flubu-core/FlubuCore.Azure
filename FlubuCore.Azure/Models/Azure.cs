using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FlubuCore.Azure.Models
{
    /// <summary>
    /// This file was generated!
    /// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
    /// using FlubuCore.Azure.Models;
    /// var azure = Azure.FromJson(jsonString);
    /// </summary>
    public partial class Azure
    {
        [JsonProperty("items")]
        public Item[] Items { get; set; }

        [JsonProperty("commands")]
        public Command[] Commands { get; set; }

        [JsonProperty("globalParameters")]
        public GlobalParameter[] GlobalParameters { get; set; }

        [JsonProperty("doc_source_url_repo")]
        public Uri DocSourceUrlRepo { get; set; }

        [JsonProperty("doc_source_url_path")]
        public string DocSourceUrlPath { get; set; }

        [JsonProperty("original_content_git_url")]
        public Uri OriginalContentGitUrl { get; set; }

        [JsonProperty("gitcommit")]
        public Uri Gitcommit { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("ms.date")]
        public string MsDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public partial class Command
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public partial class GlobalParameter
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("defaultValue", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }

        [JsonProperty("parameterValueGroup", NullValueHandling = NullValueHandling.Ignore)]
        public string ParameterValueGroup { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("langs")]
        public Lang[] Langs { get; set; }

        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Children { get; set; }

        [JsonProperty("examples", NullValueHandling = NullValueHandling.Ignore)]
        public Example[] Examples { get; set; }

        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public Parameter[] Parameters { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public Source Source { get; set; }
    }

    public partial class Example
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("syntax")]
        public Syntax Syntax { get; set; }
    }

    public partial class Syntax
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public partial class Parameter
    {
        [JsonProperty("isRequired", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public bool? IsRequired { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("parameterValueGroup", NullValueHandling = NullValueHandling.Ignore)]
        public string ParameterValueGroup { get; set; }

        [JsonProperty("defaultValue", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }
    }

    public partial class Source
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("remote")]
        public Remote Remote { get; set; }
    }

    public partial class Remote
    {
        [JsonProperty("branch")]
        public Branch Branch { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("repo")]
        public Uri Repo { get; set; }
    }

    public enum Lang { Azurecli };

    public enum Branch { Master };

    public partial class Azure
    {
        public static Azure FromJson(string json) => JsonConvert.DeserializeObject<Azure>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Azure self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                LangConverter.Singleton,
                BranchConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class LangConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Lang) || t == typeof(Lang?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "azurecli")
            {
                return Lang.Azurecli;
            }
            throw new Exception("Cannot unmarshal type Lang");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Lang)untypedValue;
            if (value == Lang.Azurecli)
            {
                serializer.Serialize(writer, "azurecli");
                return;
            }
            throw new Exception("Cannot marshal type Lang");
        }

        public static readonly LangConverter Singleton = new LangConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(bool) || t == typeof(bool?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            bool b;
            if (Boolean.TryParse(value, out b))
            {
                return b;
            }
            throw new Exception("Cannot unmarshal type bool");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (bool)untypedValue;
            var boolString = value ? "true" : "false";
            serializer.Serialize(writer, boolString);
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class BranchConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Branch) || t == typeof(Branch?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "master")
            {
                return Branch.Master;
            }
            throw new Exception("Cannot unmarshal type Branch");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Branch)untypedValue;
            if (value == Branch.Master)
            {
                serializer.Serialize(writer, "master");
                return;
            }
            throw new Exception("Cannot marshal type Branch");
        }

        public static readonly BranchConverter Singleton = new BranchConverter();
    }
}
