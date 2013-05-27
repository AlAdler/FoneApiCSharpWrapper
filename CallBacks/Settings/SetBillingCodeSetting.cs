using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Settings
{
    [JsonObject]
    internal class SetBillingCodeSetting : Setting
    {
        [JsonProperty("set_billing_code")]
        private SetBillingCodeSettingProperties properties;

        internal SetBillingCodeSetting(string billingCode)
        {
            properties = new SetBillingCodeSettingProperties();
            properties.billingCode = billingCode;
        }

        [JsonObject]
        private class SetBillingCodeSettingProperties
        {
            [JsonProperty("billing_code")]
            internal string billingCode;
        }
    }
}
