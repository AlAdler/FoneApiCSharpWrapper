using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Actions
{
    [JsonObject]
    internal class SleepAction : Action
    {
        [JsonProperty("sleep")]
        private SleepActionProperties properties;

        public SleepAction(int seconds, string url)
        {
            properties = new SleepActionProperties();
            properties.seconds = seconds;
            properties.url = url;
        }

        private class SleepActionProperties
        {
            [JsonProperty("seconds")]
            internal int seconds;
            [JsonProperty("url")]
            internal string url;
        }
    }
}
