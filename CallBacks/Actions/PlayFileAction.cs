using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Actions
{
    internal class PlayFileAction : Action
    {
        [JsonProperty("play_file")]
        private PlayFileActionProperties properties;

        internal PlayFileAction(string fileUrl, string url, params CustomParam[] customParams)
        {
            properties = new PlayFileActionProperties();
            properties.fileUrl = fileUrl;
            url = Utils.AddCustomParamsToUrl(url, customParams);
            properties.url = url;
        }

        [JsonObject]
        private class PlayFileActionProperties
        {
            [JsonProperty("file_url", Required = Required.Always)]
            internal string fileUrl;
            [JsonProperty("url", Required = Required.Always)]
            internal string url;
        }
    }
}
