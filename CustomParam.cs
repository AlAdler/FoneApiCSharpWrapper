﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoneApiWrapper
{
    public class CustomParam
    {
        public CustomParam(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }
        public string Value { get; set; }
    }
}
