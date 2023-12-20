using System.Net;

namespace testUpos
{
    internal class CheckInternet
    {
        public static bool RunCheck(string url)
        {
            try
            {
                Dns.GetHostEntry(url);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
