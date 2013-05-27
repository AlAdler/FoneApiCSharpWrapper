using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Actions
{
    [JsonObject]
    internal class HangupAction : Action
    {
        [JsonProperty("hangup")]
        private object properties;

        internal HangupAction()
        {
            properties = new object();
        }
    }
}
