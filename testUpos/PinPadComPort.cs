using System.Linq;
using System.Management;
using System.Text.RegularExpressions;

namespace testUpos
{
    internal class PinPadComPort
    {
        public const string deviceChangeEventQuery = "SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2 or EventType = 3";
        public const string PnPCOMPortsQuery = "SELECT HardwareID,name,Manufacturer,Caption FROM Win32_PnPEntity WHERE ClassGuid=\"{4d36e978-e325-11ce-bfc1-08002be10318}\"";

        public static ManagementObjectSearcher GetPnPDev() => new ManagementObjectSearcher("root\\CIMV2", PnPCOMPortsQuery);

        public static string GetPinPadDev()
        {
            try
            {
                using (ManagementObjectSearcher searcher = GetPnPDev())
                {
                    if (searcher != null)
                    {
                        foreach (ManagementObject obj in searcher.Get().Cast<ManagementObject>())
                        {
                            foreach (var id in PinPadVendors.GetVendors())
                            {
                                if (((string[])obj["HardwareID"])[0].Contains(id.Key))
                                {
                                    return obj["Caption"].ToString();
                                }
                            }
                        }
                    }
                }
                return string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string GetComPortNum()
        {
            Regex regex = new Regex(@"COM[\d]+");
            Match matches = regex.Match(GetPinPadDev());
            string comNum = matches.ToString().Replace("COM", string.Empty).Trim();
            return comNum;
        }

    }

}

