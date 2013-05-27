using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Actions
{
    [JsonObject]
    internal class SayDigitsAction : Action
    {
        [JsonProperty("say_digits")]
        SayDigitsActionProperties properties;

        internal SayDigitsAction(string digits, eVoice voice, eLanguage language)
        {
            properties = new SayDigitsActionProperties();
            properties.digits = digits;
            properties.language = language.ToString();
            properties.voice = voice.ToString();
        }

        private class SayDigitsActionProperties
        {
            [JsonProperty("digits")]
            internal string digits;
            [JsonProperty("language")]
            internal string language;
            [JsonProperty("voice")]
            internal string voice;
        }
    }
}
