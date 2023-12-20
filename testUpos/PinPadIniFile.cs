using IniParser;
using IniParser.Model;
using System.Text;

namespace testUpos
{
    internal class PinPadIniFile
    {
        public const string pinpanCom = "ComPort";

        public static IniData GetIniFile(string iniFilePath)
        {
            FileIniDataParser parser = new FileIniDataParser();
            IniData data = parser.ReadFile(iniFilePath, Encoding.Default);
            return data;
        }

        public static void WriteIniFile(string iniFilePath, string value)
        {
            FileIniDataParser parser = new FileIniDataParser();
            IniData data = parser.ReadFile(iniFilePath, Encoding.Default);
            data.Global[pinpanCom] = value;
            parser.WriteFile(iniFilePath, data, Encoding.Default);

        }

        public static string GetIniValue(string iniFilePath) => GetIniFile(iniFilePath).Global[pinpanCom];

    }
}
