using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoneApiWrapper
{
    internal class Utils
    {
        private const string QUESTION_MARK = "?";
        private const string AND_SIGN = "&";
        private const string EQUALS_SIGN = "=";

        public static string AddCustomParamsToUrl(string url, CustomParam[] customParams)
        {
            string retVal = url;
            if (!string.IsNullOrEmpty(retVal) && customParams.Length > 0)
            {
                StringBuilder builder = new StringBuilder(retVal);
                for (int i = 0; i < customParams.Length; i++)
                {
                    if (i == 0)
                    {
                        builder.Append(QUESTION_MARK);
                    }
                    else
                    {
                        builder.Append(AND_SIGN);
                    }
                    builder.Append(customParams[i].Key).Append(EQUALS_SIGN).Append(customParams[i].Value);
                }
                retVal = builder.ToString();
            }
            return retVal;
        }
    }
}
