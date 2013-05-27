using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Actions
{
    internal class InstantRecordAction : Action
    {
        [JsonProperty("instant_record")]
        InstantRecordActionProperties properties;

        internal InstantRecordAction(int? maxDurationSeconds, int? silenceTimeoutSeconds, bool? playBeep, string terminationKey, string url)
        {
            properties = new InstantRecordActionProperties();
            properties.maxDuration = maxDurationSeconds.HasValue ? maxDurationSeconds.Value : 60;
            properties.silenceTimeout = silenceTimeoutSeconds.HasValue ? silenceTimeoutSeconds.Value : 15;
            properties.playBeep = playBeep.HasValue ? playBeep.Value : true;
            properties.terminationKey = string.IsNullOrEmpty(terminationKey) ? null : terminationKey;
            properties.url = url;
        }

        private class InstantRecordActionProperties
        {
            [JsonProperty("max_duration")]
            internal int maxDuration;
            [JsonProperty("silence_timeout")]
            internal int silenceTimeout;
            [JsonProperty("play_beep")]
            internal bool playBeep;
            [JsonProperty("termination_key", DefaultValueHandling = DefaultValueHandling.Ignore)]
            internal string terminationKey;
            [JsonProperty("url")]
            internal string url;
        }
    }
}
