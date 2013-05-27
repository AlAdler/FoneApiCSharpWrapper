using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Actions
{
    [JsonObject]
    internal class RedirectAction : Action
    {
        [JsonProperty("redirect")]
        RedirctActionProperties properties;

        internal RedirectAction(string location)
        {
            properties = new RedirctActionProperties();
            properties.location = location;
        }

        private class RedirctActionProperties
        {
            [JsonProperty("location", Required = Required.Always)]
            internal string location;
        }
    }
}
