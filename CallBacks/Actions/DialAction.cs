using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Actions
{
    [JsonObject]
    internal class DialAction : Action
    {
        [JsonProperty("dial")]
        private DialProperties properties;

        internal DialAction(string numbers, string callerId, string url, bool record, params CustomParam[] customParams)
        {
            properties = new DialProperties();
            properties.numbers = numbers;
            properties.callerId = callerId;
            url = Utils.AddCustomParamsToUrl(url, customParams);
            properties.url = url;
            properties.record = record;
        }

        [JsonObject]
        private class DialProperties
        {
            [JsonProperty("numbers")]
            internal string numbers;
            [JsonProperty("url")]
            internal string url;         
            [JsonProperty("caller_id", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            internal string callerId;
            [JsonProperty("record", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]            
            internal bool record;
        }
    }
}
