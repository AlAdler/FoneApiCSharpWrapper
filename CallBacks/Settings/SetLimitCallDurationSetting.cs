using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Settings
{
    [JsonObject]
    internal class SetLimitCallDurationSetting : Setting
    {
        [JsonProperty("set_limit_call_duration")]
        private SetLimitCallDurationSettingProperties properties;

        internal SetLimitCallDurationSetting(int seconds)
        {
            properties = new SetLimitCallDurationSettingProperties();
            properties.seconds = seconds;
        }

        [JsonObject]
        private class SetLimitCallDurationSettingProperties
        {
            [JsonProperty("seconds")]
            internal int seconds;
        }
    }
}
