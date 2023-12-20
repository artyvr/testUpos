using System.Collections.Generic;

namespace testUpos
{
    public static class UposHosts
    {
        public class Host
        {
            public string IP { get; set; }
            public int Port { get; set; }
            public string Description { get; set; }
        }

        public static List<Host> GetHosts()
        {
            List<Host> hosts = new List<Host>()
            {
                new Host(){ IP = "8.8.8.8", Port = 53, Description = "Google DNS"},
                new Host(){ IP = "194.54.14.89", Port = 670, Description = "UPOS 1.0 Основной"},
                new Host(){ IP = "194.54.14.89", Port = 666, Description = "UPOS 1.0 Основной"},
                new Host(){ IP = "194.54.14.89", Port = 650, Description = "UPOS 1.0 Основной"},
                new Host(){ IP = "194.54.14.89", Port = 690, Description = "UPOS 1.0 Основной"},
                new Host(){ IP = "194.54.14.162", Port = 670, Description = "UPOS 1.0 Резервный"},
                new Host(){ IP = "194.54.14.162", Port = 666, Description = "UPOS 1.0 Резервный"},
                new Host(){ IP = "194.54.14.162", Port = 650, Description = "UPOS 1.0 Резервный"},
                new Host(){ IP = "194.54.14.162", Port = 690, Description = "UPOS 1.0 Резервный"},
                new Host(){ IP = "194.54.15.25", Port = 670, Description = "UPOS 1.0 Основной"},
                new Host(){ IP = "194.54.15.25", Port = 666, Description = "UPOS 1.0 Основной"},
                new Host(){ IP = "194.54.15.25", Port = 650, Description = "UPOS 1.0 Основной"},
                new Host(){ IP = "194.54.15.25", Port = 690, Description = "UPOS 1.0 Основной"},
                new Host(){ IP = "185.157.96.41", Port = 80, Description = "Сервер обновлений/U2"},
                new Host(){ IP = "185.157.96.24", Port = 80, Description = "UPOS 2.0"},
                new Host(){ IP = "194.54.15.98", Port = 80, Description = "UPOS 2.0"},
            };
            return hosts;
        }
    }
}

