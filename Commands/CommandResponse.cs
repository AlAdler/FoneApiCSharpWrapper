using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace FoneApiWrapper.Commands
{
    [JsonObject]
    public class CommandResponse
    {
        [JsonProperty("status")]
        public int status;
        [JsonProperty("call_id")]
        public string callId;
        [JsonProperty("error_msg")]
        public string errorMsg;
    }
}
