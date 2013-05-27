using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Actions
{
    internal class PlayAndGetDtmfAction : Action
    {
        [JsonProperty("play_and_get_dtmf")]
        private PlayAndGetDtmfActionProperties properties;

        internal PlayAndGetDtmfAction(string fileUrl, string url, int maxLength, int timeout, string terminationKey)
        {
            properties = new PlayAndGetDtmfActionProperties();
            properties.fileUrl = fileUrl;
            properties.url = url;
            properties.maxLength = maxLength;
            properties.terminationKey = terminationKey;
            properties.timeout = timeout;
        }

        [JsonObject]
        private class PlayAndGetDtmfActionProperties
        {
            [JsonProperty("file_url", Required = Required.Always)]
            internal string fileUrl;
            [JsonProperty("url", Required = Required.Always)]
            internal string url;
            [JsonProperty("max_length")]
            internal int maxLength;
            [JsonProperty("termination_key")]
            internal string terminationKey;
            [JsonProperty("timeout")]
            internal int timeout;
        }
    }
}
