﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SimpleWAWS.Models
{
    public class BaseTemplate
    {
        [JsonProperty(PropertyName = "dockerContainer")]
        public string DockerContainer { get; set; }

        [JsonProperty(PropertyName="name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName="sprite")]
        public string SpriteName { get; set; }

        [JsonProperty(PropertyName="appService")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AppService AppService { get; set; }

        [JsonProperty(PropertyName = "githubRepo")]
        public string GithubRepo { get; set; }

        public string CreateQueryString()
        {
            return string.Concat("appServiceName=", AppService.ToString(), "&name=", Name, "&autoCreate=true");
        }

        [JsonProperty(PropertyName = "msdeployPackageUrl")]
        public string MSDeployPackageUrl { get; set; }
        [JsonProperty(PropertyName = "isLinux")]
        public bool IsLinux { get { return Name.EndsWith("Web App on Linux"); } }


    }
}