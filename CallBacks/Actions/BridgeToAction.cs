using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Actions
{
    [JsonObject]
    internal class BridgeToAction : Action
    {
        [JsonProperty("bridge_to")]
        private BridgeToActionProperties properties;

        internal BridgeToAction(string otherCallId, string url, params CustomParam[] customParams)
        {
            properties = new BridgeToActionProperties();
            properties.otherCallId = otherCallId;
            url = Utils.AddCustomParamsToUrl(url, customParams);
            properties.url = url;
        }

        [JsonObject]
        private class BridgeToActionProperties
        {
            [JsonProperty("other_call_id")]
            internal string otherCallId;
            [JsonProperty("url")]
            internal string url;
        }
    }
}
