using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Actions
{
    [JsonObject]
    internal class SendDtmfAction : Action
    {
        [JsonProperty("send_dtmf")]
        SendDtmfActionProperties properties;

        public SendDtmfAction(string digits, string url)
        {
            properties = new SendDtmfActionProperties();
            properties.digits = digits;
            properties.url = url;
        }

        private class SendDtmfActionProperties
        {
            [JsonProperty("digits")]
            internal string digits;
            [JsonProperty("url")]
            internal string url;
        }
    }
}
