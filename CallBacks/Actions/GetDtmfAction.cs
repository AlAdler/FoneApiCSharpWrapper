using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Actions
{
    [JsonObject]
    internal class GetDtmfAction : Action
    {
        [JsonProperty("get_dtmf")]
        private GetDtmfProperties properties;

        internal GetDtmfAction(int maxLength, string terminationKey, int timeout, string url)
        {
            properties = new GetDtmfProperties();
            properties.maxLength = maxLength;
            properties.terminationKey = terminationKey;
            properties.timeout = timeout;
            properties.url = url;
        }

        [JsonObject]
        private class GetDtmfProperties
        {
            [JsonProperty("max_length")]
            internal int maxLength;
            [JsonProperty("termination_key")]
            internal string terminationKey;
            [JsonProperty("timeout")]
            internal int timeout;
            [JsonProperty("url")]
            internal string url;
        }
    }
}
