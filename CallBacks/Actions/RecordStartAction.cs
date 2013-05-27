using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Actions
{
    [JsonObject]
    internal class RecordStartAction : Action
    {
        [JsonProperty("record_start")]
        private object properties;

        public RecordStartAction()
        {
            properties = new object();
        }
    }
}
