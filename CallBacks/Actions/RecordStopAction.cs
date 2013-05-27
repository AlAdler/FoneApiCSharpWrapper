using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Actions
{
    internal class RecordStopAction : Action
    {
        [JsonProperty("record_stop")]
        private RecordStopActionProperties properties;

        public RecordStopAction(string url, params CustomParam[] customParams)
        {
            properties = new RecordStopActionProperties();
            url = Utils.AddCustomParamsToUrl(url, customParams);
            properties.url = url;
        }

        [JsonObject]
        private class RecordStopActionProperties
        {
            [JsonProperty("url")]
            internal string url;
        }
    }
}
