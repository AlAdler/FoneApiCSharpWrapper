using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Actions
{
    [JsonObject]
    internal class SayAction : Action
    {
        [JsonProperty("say")]
        private SayProperties properties;

        internal SayAction(string text, eVoice voice, eLanguage language)
        {
            properties = new SayProperties();
            properties.language = language.ToString();
            properties.text = text;
            properties.voice = voice.ToString();
        }

        [JsonObject]
        private class SayProperties
        {
            [JsonProperty("voice")]
            internal string voice;
            [JsonProperty("text")]
            internal string text;
            [JsonProperty("language")]
            internal string language;
        }
    }
}
