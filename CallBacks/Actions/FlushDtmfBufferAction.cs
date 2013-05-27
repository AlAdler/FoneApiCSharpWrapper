using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Actions
{
    [JsonObject]
    internal class FlushDtmfBufferAction : Action
    {
        [JsonProperty("flush_dtmf_buffer")]
        private object properties;

        public FlushDtmfBufferAction()
        {
            properties = new object();
        }
    }
}
