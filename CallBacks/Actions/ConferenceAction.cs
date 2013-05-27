using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Actions
{
    [JsonObject]
    internal class ConferenceAction : Action
    {
        [JsonProperty("conference")]
        private ConferenceActionProperties properties;

        internal ConferenceAction(string room)
        {
            properties = new ConferenceActionProperties();
            properties.room = room;
        }

        [JsonObject]
        private class ConferenceActionProperties
        {   
            [JsonProperty("room", Required = Required.Always)]
            internal string room;
        }
    }
}
