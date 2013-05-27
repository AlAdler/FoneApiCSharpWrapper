using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoneApiWrapper.CallBacks
{
    public class ArgsTypes
    {
        public const string FAPI_EVENT = "fapi_event";
        public const string FAPI_DESCRIPTION = "fapi_description";
        public const string FAPI_CALL_ID = "fapi_call_id";
        public const string FAPI_HANGUP_CAUSE = "fapi_hangup_cause";
        public const string FAPI_APP_ID = "fapi_app_id";
        public const string FAPI_CALL_SOURCE_ADDRESS = "fapi_call_source_address";
        public const string FAPI_DID_NUMBER = "fapi_did_number";
        public const string FAPI_CALLER_ID_NUMBER = "fapi_caller_id_number";
        public const string FAPI_RECORDING_URL = "fapi_recording_url";
        public const string FAPI_CALL_DURATION = "fapi_call_duration";
    }

    public class EventTypes
    {
        public const string HANGUP = "hangup";
        public const string CALL_ANSWERED = "call_answered";
        public const string INCOMING_CALL = "incoming_call";
        public const string PLAY_FILE_COMPLETE = "play_file_complete";
        public const string STOP_RECORD_COMPLETE = "stop_record_complete";
        public const string BRIDGE_END = "bridge_end";
    }

    public class HangupCauses
    {
        public const string NORMAL_CLEARING = "NORMAL_CLEARING";
        public const string USER_BUSY = "USER_BUSY";
        public const string ORIGINATOR_CANCEL = "ORIGINATOR_CANCEL";
        public const string NORMAL_UNSPECIFIED = "NORMAL_UNSPECIFIED";
    }
}
