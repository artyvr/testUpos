using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testUpos
{
    public partial class HostsTest : Form
    {
        public HostsTest()
        {
            InitializeComponent();
        }

        private void HostsTest_Load(object sender, EventArgs e)
        {
            AddColumnHeader();
            GetListView();
        }

        private List<Hosts> GetHostsPorts()
        {
            return new List<Hosts>
            {
                new Hosts() { Host = "8.8.8.8", Port = 53, Description = "Google DNS" },
                new Hosts() { Host = "77.88.8.8", Port = 53, Description = "Yandex DNS" },

                new Hosts() { Host = "194.54.14.89", Port = 670, Description = "UPOS 1 Транзакции и ключи" },
                new Hosts() { Host = "194.54.14.89", Port = 740, Description = "UPOS 1 Транзакции и ключи" },
                new Hosts() { Host = "194.54.14.89", Port = 666, Description = "UPOS 1 УЗПО" },
                new Hosts() { Host = "194.54.14.89", Port = 650, Description = "UPOS 1 Мониторинг" },
                new Hosts() { Host = "194.54.14.89", Port = 690, Description = "UPOS 1 Выгрузка логов" },

                new Hosts() { Host = "194.54.15.25", Port = 670, Description = "UPOS 1 Транзакции и ключи" },
                new Hosts() { Host = "194.54.15.25", Port = 740, Description = "UPOS 1 Транзакции и ключи" },
                new Hosts() { Host = "194.54.15.25", Port = 666, Description = "UPOS 1 Транзакции и ключи" },
                new Hosts() { Host = "194.54.15.25", Port = 650, Description = "UPOS 1 Мониторинг" },
                new Hosts() { Host = "194.54.15.25", Port = 690, Description = "UPOS 1 Выгрузка логов" },

                new Hosts() { Host = "194.54.14.162", Port = 670, Description = "UPOS 1 Транзакции и ключи" },
                new Hosts() { Host = "194.54.14.162", Port = 740, Description = "UPOS 1 Транзакции и ключи" },
                new Hosts() { Host = "194.54.14.162", Port = 666, Description = "UPOS 1 УЗПО" },
                new Hosts() { Host = "194.54.14.162", Port = 650, Description = "UPOS 1 Мониторинг" },
                new Hosts() { Host = "194.54.14.162", Port = 690, Description = "UPOS 1 Выгрузка логов" },

                new Hosts() { Host = "194.54.14.24", Port = 668, Description = "UPOS 1 Транзакции и ключи" },
                new Hosts() { Host = "194.54.14.24", Port = 666, Description = "UPOS 1 УЗПО" },
                new Hosts() { Host = "194.54.14.24", Port = 650, Description = "UPOS 1 Мониторинг" },

                new Hosts() { Host = "185.157.96.41", Port = 80, Description = "UPOS 2 Транзакции и ключи" },

                new Hosts() { Host = "194.54.14.89", Port = 700, Description = "UPOS 3 Транзакции и ключи" },
                new Hosts() { Host = "194.54.14.89", Port = 666, Description = "UPOS 3 УЗПО" },
                new Hosts() { Host = "194.54.14.89", Port = 650, Description = "UPOS 3 Мониторинг" },
                new Hosts() { Host = "194.54.14.89", Port = 690, Description = "UPOS 3 Выгрузка логов" },

                new Hosts() { Host = "194.54.14.162", Port = 700, Description = "UPOS 3 Транзакции и ключи" },
                new Hosts() { Host = "194.54.14.162", Port = 666, Description = "UPOS 3 УЗПО" },
                new Hosts() { Host = "194.54.14.162", Port = 650, Description = "UPOS 3 Мониторинг" },
                new Hosts() { Host = "194.54.14.162", Port = 690, Description = "UPOS 3 Транзакции и ключи" },

                new Hosts() { Host = "194.54.15.25", Port = 700, Description = "UPOS 3 Транзакции и ключи" },
                new Hosts() { Host = "194.54.15.25", Port = 666, Description = "UPOS 3 УЗПО" },
                new Hosts() { Host = "194.54.15.25", Port = 650, Description = "UPOS 3 Мониторинг" },
                new Hosts() { Host = "194.54.15.25", Port = 690, Description = "UPOS 3 Выгрузка логов" },
            };
        }

        private void AddColumnHeader()
        {
            ColumnHeader host, port, description, availability;
            host = new ColumnHeader();
            port = new ColumnHeader();
            description = new ColumnHeader();
            availability = new ColumnHeader();
            host.Text = "Хост";
            port.Text = "Порт";
            description.Text = "Описание";
            availability.Text = "Доступность";
            hostsPorts.Columns.Add(host);
            hostsPorts.Columns.Add(port);
            hostsPorts.Columns.Add(description);
            hostsPorts.Columns.Add(availability);
        }

        private void ReloadBtn_Click(object sender, EventArgs e) => RunTest();

        private void GetListView()
        {
            foreach (var host in GetHostsPorts())
            {
                ListViewItem item = new ListViewItem(host.Host);
                item.SubItems.Add(host.Port.ToString());
                item.SubItems.Add(host.Description);
                item.SubItems.Add("");
                hostsPorts.Items.Add(item);
            }
            hostsPorts.FullRowSelect = true;
            hostsPorts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private async void RunTest()
        {
            try
            {
                runTestBtn.Enabled = false;
                runTestBtn.Text = "В процессе...";

                foreach (ListViewItem item in hostsPorts.Items)
                {
                    item.SubItems[3].Text = ".......";
                    string result = await HOSTTest(item.SubItems[0].Text, Int32.Parse(item.SubItems[1].Text));
                    item.SubItems[3].Text = result;
                    if (result == "Не доступен")
                    {
                        item.BackColor = Color.IndianRed;
                    }
                    else
                    {
                        item.BackColor = Color.White;
                    }
                }
                hostsPorts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            catch (Exception)
            {

            }
            finally
            {
                runTestBtn.Enabled = true;
                runTestBtn.Text = "Запустить тест";
            }
        }

        private async Task<string> HOSTTest(string host, int port)
        {
            try
            {
                await Task.Delay(3);
                TcpClient tcpClient = new TcpClient();
                var result = tcpClient.BeginConnect(host, port, null, null);
                var success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(2));
                if (success)
                {
                    tcpClient.EndConnect(result);
                    return "Доступен";
                }
                else
                {
                    return "Не доступен";
                }
            }
            catch (SocketException)
            {
                return "Не доступен";
            }
        }

        private class Hosts
        {
            public string Host { get; set; }
            public int Port { get; set; }
            public string Description { get; set; }
        }
    }
}
