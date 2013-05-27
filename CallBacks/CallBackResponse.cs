using System.Collections.Generic;
using FoneApiWrapper.CallBacks.Actions;
using FoneApiWrapper.CallBacks.Settings;
using Newtonsoft.Json;

namespace FoneApiWrapper.CallBacks
{
    [JsonObject]
    public class CallBackResponse
    {
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        private List<Actions.Action> actions;
        [JsonProperty("settings", NullValueHandling = NullValueHandling.Ignore)]
        private List<Setting> settings;

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public CallBackResponse(string billingCode, string errorReportUrl)
        {
            actions = new List<Actions.Action>();
            settings = new List<Setting>();
            SetBillingCode(billingCode);
            SetErrorReportUrl(errorReportUrl);
        }

        public CallBackResponse(string errorReportUrl, int limitCallDurationSeconds)
        {
            actions = new List<Actions.Action>();
            settings = new List<Setting>();
            SetErrorReportUrl(errorReportUrl);
            SetLimitCallDuration(limitCallDurationSeconds);
        }

        public CallBackResponse(string billingCode, string errorReportUrl, int limitCallDurationSeconds)
        {
            actions = new List<Actions.Action>();
            settings = new List<Setting>();
            SetBillingCode(billingCode);
            SetErrorReportUrl(errorReportUrl);
            SetLimitCallDuration(limitCallDurationSeconds);
        }

        public CallBackResponse(string errorReportUrl)
        {
            actions = new List<Actions.Action>();
            settings = new List<Setting>();
            SetErrorReportUrl(errorReportUrl);
        }

        public CallBackResponse(int limitCallDurationSeconds)
        {
            actions = new List<Actions.Action>();
            settings = new List<Setting>();
            SetLimitCallDuration(limitCallDurationSeconds);
        }

        public CallBackResponse()
        {
            actions = new List<Actions.Action>();
        }

        public void Redirect(string location)
        {
            RedirectAction redirectAction = new RedirectAction(location);
            actions.Add(redirectAction);
        }

        public void SendDtmf(string digits, string url)
        {
            SendDtmfAction sendDtmfAction = new SendDtmfAction(digits, url);
            actions.Add(sendDtmfAction);
        }

        public void FlushDtmfBuffer()
        {
            FlushDtmfBufferAction flushDtmfBufferAction = new FlushDtmfBufferAction();
            actions.Add(flushDtmfBufferAction);
        }

        public void Sleep(int seconds, string url)
        {
            SleepAction sleepAction = new SleepAction(seconds, url);
            actions.Add(sleepAction);
        }

        public void Say(string text, eVoice voice, eLanguage language)
        {
            SayAction sayAction = new SayAction(text, voice, language);
            actions.Add(sayAction);
        }

        public void SayDigits(string digits, eVoice voice, eLanguage language)
        {
            SayDigitsAction sayDigitsAction = new SayDigitsAction(digits, voice, language);
            actions.Add(sayDigitsAction);
        }

        public void SayNumber(string number, eVoice voice, eLanguage language)
        {
            SayNumberAction sayNumberAction = new SayNumberAction(number, voice, language);
            actions.Add(sayNumberAction);
        }

        public void Hangup()
        {
            HangupAction hangupAction = new HangupAction();
            actions.Add(hangupAction);
        }

        public void InstantRecord(int? maxDurationSeconds, int? silenceTimeoutSeconds, bool? playBeep, string terminationKey, string url)
        {
            InstantRecordAction instantRecordAction = new InstantRecordAction(maxDurationSeconds, silenceTimeoutSeconds, playBeep, terminationKey, url);
            actions.Add(instantRecordAction);
        }

        public void Dial(string numbers, string callerId, string url, bool record, params CustomParam[] customParams)
        {
            DialAction dialAction = new DialAction(numbers, callerId, url, record, customParams);
            actions.Add(dialAction);
        }

        public void GetDtmf(int maxLength, string terminationKey, int timeout, string url)
        {
            GetDtmfAction dtmfAction = new GetDtmfAction(maxLength, terminationKey, timeout, url);
            actions.Add(dtmfAction);
        }

        public void Conference(string room)
        {
            ConferenceAction confAction = new ConferenceAction(room);
            actions.Add(confAction);
        }

        public void GetConferenceCount(string room, string url)
        {
            GetConferenceCountAction getConfCountAction = new GetConferenceCountAction(room, url);
            actions.Add(getConfCountAction);
        }

        public void RecordStart()
        {
            RecordStartAction recordStartAction = new RecordStartAction();
            actions.Add(recordStartAction);
        }

        public void Answer()
        {
            AnswerAction answerAction = new AnswerAction();
            actions.Add(answerAction);
        }

        public void RecordStop(string url, params CustomParam[] customParams)
        {
            RecordStopAction recordStopAction = new RecordStopAction(url, customParams);
            actions.Add(recordStopAction);
        }

        public void PlayFile(string fileUrl, string url, params CustomParam[] customParams)
        {
            PlayFileAction playFileAction = new PlayFileAction(fileUrl, url, customParams);
            actions.Add(playFileAction);
        }

        public void PlayAndGetDtmf(string fileUrl, string url, int maxLength, string terminationKey, int timeout)
        {
            PlayAndGetDtmfAction playAndGetDtmfAction = new PlayAndGetDtmfAction(fileUrl, url, maxLength, timeout, terminationKey);
            actions.Add(playAndGetDtmfAction);
        }

        public void BridgeTo(string otherCallId, string url, params CustomParam[] customParams)
        {
            BridgeToAction bridgeToAction = new BridgeToAction(otherCallId, url, customParams);
            actions.Add(bridgeToAction);
        }

        public void SetBillingCode(string billingCode)
        {
            foreach (var item in settings)
            {
                if (item is SetBillingCodeSetting)
                {
                    settings.Remove(item);
                    break;
                }
            }
            SetBillingCodeSetting setBillingCodeSetting = new SetBillingCodeSetting(billingCode);
            settings.Add(setBillingCodeSetting);
        }

        public void SetErrorReportUrl(string url)
        {
            foreach (var item in settings)
            {
                if (item is SetErrorReportUrlSetting)
                {
                    settings.Remove(item);
                    break;
                }
            }
            SetErrorReportUrlSetting setErrorUrlSetting = new SetErrorReportUrlSetting(url);
            settings.Add(setErrorUrlSetting);
        }

        public void SetLimitCallDuration(int seconds)
        {
            foreach (var item in settings)
            {
                if (item is SetLimitCallDurationSetting)
                {
                    settings.Remove(item);
                    break;
                }
            }
            SetLimitCallDurationSetting limitCallSetting = new SetLimitCallDurationSetting(seconds);
            settings.Add(limitCallSetting);
        }
    }
}
