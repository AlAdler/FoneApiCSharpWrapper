using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Settings
{
    [JsonObject]
    internal class SetErrorReportUrlSetting : Setting
    {
        [JsonProperty("set_error_report_url")]
        private SetErrorReportUrlSettingProperties properties;

        internal SetErrorReportUrlSetting(string url)
        {
            properties = new SetErrorReportUrlSettingProperties();
            properties.url = url;
        }

        [JsonObject]
        private class SetErrorReportUrlSettingProperties
        {
            [JsonProperty("url")]
            internal string url;
        }
    }
}
