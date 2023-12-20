using System.Collections.Generic;

namespace testUpos
{
    public static class PinPadVendors
    {
        public static Dictionary<string, string> GetVendors()
        {
            return new Dictionary<string, string>()
            {
                { "vid_11ca&PID_0219", "Verifone"},
                { "VID_11CA&PID_0219", "Verifone" },
                { "VID_193A&PID_1000", "Verifone" },
                { "VID_1234&PID_0101", "PAX" },
                { "VID_9908&PID_9030", "PAX CDC mode" },
                { "VID_079B&PID_0028", "Ingenico" },
                { "VID_2FB8", "any"},
                { "VID_0B00", "any"},
                { "VID_0CA6", "any"},
                { "VID_1234", "any"}
            };
        }
    }
}
