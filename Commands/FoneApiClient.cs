using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Net;

namespace FoneApiWrapper.Commands
{
    public class FoneApiClient
    {
        private RestSharp.RestClient restClient;
        private const string DIAL_RESOURCE = "dial//";
        private const string HANGUP_RESOURCE = "hangup//";

        private static class DialParams
        {
            internal const string DEST_TYPE = "dest_type";
            internal const string DEST = "dest";
            internal const string URL = "url";
            internal const string APP_ID = "app_id";
            internal const string FALLBACK_URL = "fallback_url";
            internal const string DIAL_TIMEOUT = "dial_timeout";
            internal const string CALLER_ID_NUM = "caller_id_num";
            internal const string CALLER_ID_NAME = "caller_id_name";
            internal const string DELAY = "delay";
            internal const string TRUNK = "trunk";
        }

        private static class HangupParams
        {
            internal const string CALL_ID = "call_id";
        }

        public FoneApiClient(string urlBase, string fapiKey, string fapiSecret)
        {
            restClient = new RestSharp.RestClient(urlBase);
            restClient.Authenticator = new RestSharp.HttpBasicAuthenticator(fapiKey, fapiSecret);
        }

        /// <summary>
        ///     Generate a call.
        /// </summary>
        /// <param name="destinationType">Type of destination can be one of the following: number – dial normal phone number, ip – dial to an external ip</param>
        /// <param name="destination">Destination number or ip destination</param>
        /// <param name="url">Url to send events to</param>
        /// <param name="appId">Application ID</param>
        /// <param name="fallbackUrl">Optional - Url to call in case ‘url’ fails</param>
        /// <param name="dialTimeout">Optional - Timeout for answer on this dial. Default: 30</param>
        /// <param name="callerIdNum">Optional - Caller ID number. Default: anonymous</param>
        /// <param name="callerIdName">Optional - Caller id name. Default: anonymous</param>
        /// <param name="delay">Optional - Delay in seconds before switch will originate the call. Default: none</param>
        /// <returns></returns>
        public CommandResponse Dial(
            eDialDestinationType destinationType, 
            string destination, 
            string url, 
            int appId,
            string fallbackUrl,
            int? dialTimeout,
            string callerIdNum,
            string callerIdName,
            int? delay,
            string trunk,
            params CustomParam[] customParams)
        {
            RestSharp.RestRequest request = new RestSharp.RestRequest(RestSharp.Method.GET);
            request.Resource = DIAL_RESOURCE;
            request.AddParameter(DialParams.DEST_TYPE, destinationType.ToString());
            request.AddParameter(DialParams.DEST, destination);
            url = Utils.AddCustomParamsToUrl(url, customParams);
            request.AddParameter(DialParams.URL, url);
            request.AddParameter(DialParams.APP_ID, appId);
            request.AddParameter(DialParams.TRUNK, trunk);
            if (!string.IsNullOrEmpty(fallbackUrl))
            {
                fallbackUrl = Utils.AddCustomParamsToUrl(fallbackUrl, customParams);
                request.AddParameter(DialParams.FALLBACK_URL, fallbackUrl);
            }
            if (dialTimeout.HasValue)
            {
                request.AddParameter(DialParams.DIAL_TIMEOUT, dialTimeout.Value);
            }
            if (!string.IsNullOrEmpty(callerIdNum))
            {
                request.AddParameter(DialParams.CALLER_ID_NUM, callerIdNum);
            }
            if (!string.IsNullOrEmpty(callerIdName))
            {
                request.AddParameter(DialParams.CALLER_ID_NAME, callerIdName);
            }
            if (delay.HasValue)
            {
                request.AddParameter(DialParams.DELAY, delay.Value);
            }
            CommandResponse retVal = null;
            try
            {
                RestSharp.RestResponse response = (RestSharp.RestResponse)restClient.Execute(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    retVal = JsonConvert.DeserializeObject<CommandResponse>(response.Content);
                }
                else
                {
                    //TODO: Add Log entry
                    retVal = new CommandResponse();
                    retVal.callId = null;
                    retVal.errorMsg = response.Content;
                    retVal.status = -10;
                }
            }
            catch (WebException exc)
            {
                //TODO: Add Log entry
                retVal = new CommandResponse();
                retVal.callId = null;
                retVal.errorMsg = exc.Message;
                retVal.status = -20;
            }
            return retVal;
        }

        public CommandResponse Hangup(string callId)
        {
            CommandResponse retVal = null;
            RestSharp.RestRequest request = new RestSharp.RestRequest(RestSharp.Method.GET);
            request.Resource = HANGUP_RESOURCE;
            request.AddParameter(HangupParams.CALL_ID, callId);
            try
            {
                RestSharp.RestResponse response = (RestSharp.RestResponse)restClient.Execute(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    retVal = JsonConvert.DeserializeObject<CommandResponse>(response.Content);
                }
                else
                {
                    //TODO: Add Log entry
                    retVal = new CommandResponse();
                    retVal.callId = callId;
                    retVal.status = -10;
                    retVal.errorMsg = response.Content;
                }
            }
            catch (WebException exc)
            {
                //TODO: Add Log entry
                retVal = new CommandResponse();
                retVal.callId = callId;
                retVal.status = -20;
                retVal.errorMsg = exc.Message;
            }
            return retVal;
        }
    }
}
