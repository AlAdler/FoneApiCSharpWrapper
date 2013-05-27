using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks.Actions
{
    [JsonObject]
    internal class AnswerAction : Action
    {
        [JsonProperty("answer")]
        private object properties;

        public AnswerAction()
        {
            properties = new object();
        }
    }
}
