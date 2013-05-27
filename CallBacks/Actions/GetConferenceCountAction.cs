using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Actions
{
    internal class GetConferenceCountAction : Action
    {
        [JsonProperty("get_conference_count")]
        private GetConferenceCountActionProperties properties;

        internal GetConferenceCountAction(string room, string url)
        {
            properties = new GetConferenceCountActionProperties();
            properties.room = room;
            properties.url = url;
        }

        [JsonObject]
        private class GetConferenceCountActionProperties
        {   
            [JsonProperty("room", Required = Required.Always)]
            internal string room;
            [JsonProperty("url", Required = Required.Always)]
            internal string url;
        }
    }
}
