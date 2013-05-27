using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Actions
{
    [JsonObject]
    internal class SayNumberAction : Action
    {
        [JsonProperty("say_number")]
        SayNumberActionProperties properties;

        internal SayNumberAction(string number, eVoice voice, eLanguage language)
        {
            properties = new SayNumberActionProperties();
            properties.language = language.ToString();
            properties.voice = voice.ToString();
            properties.number = number;
        }

        private class SayNumberActionProperties
        {
            [JsonProperty("number")]
            internal string number;
            [JsonProperty("voice")]
            internal string voice;
            [JsonProperty("language")]
            internal string language;
        }
    }
}
