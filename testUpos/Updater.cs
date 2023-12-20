using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace testUpos
{
    class Updater
    {
        public static string appCurVer = Assembly.GetExecutingAssembly().GetName().Version.ToString(2);
        public static string appName = AppDomain.CurrentDomain.FriendlyName;
        public static string appPath = Assembly.GetExecutingAssembly().Location;

        public const string checkUpdateFileUrl = @"https://artyvr.github.io/upds/testupos/version.xml";
        public const string updateAvailableMsg = "Доступно обновление {0}, обновить?";
        public const string updateAvailableTitle = "Обновление";
        public const string currentVersionMsg = "У Вас актуальная версия {0}";
        public const string errorGetUpdateMsg = "Ошибка проверки обновления, попробуйте позже";
        public const string testUposTitle = "";
        public const string noInternetMsg = "Интернет отсутствует, либо сервер обновлений не доступен...";
        public const string newVerFileName = "new_testupos_ver.exe";

        public void Cmd(string line)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c {line}",
                WindowStyle = ProcessWindowStyle.Hidden,
            });
        }

        public async Task<string> GetStringFromHttpResponse(string line)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(line);
                return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : null;
            }
        }

        /// <summary>
        /// Проверка обновления
        /// </summary>
        /// <param name="pause">Ожидание перед запуском процесса проверки обновления в милисекундах</param>
        /// <param name="MsgShow">Показать ли сообщение если версия актуальна</param>
        public async void CheckUpdate(int pause, bool MsgShow)
        {

            await Task.Delay(pause);
            using (HttpClient client = new HttpClient())
            {
                if (CheckInternet.RunCheck("github.com"))
                {
                    try
                    {
                        XmlDocument xmlDocument = new XmlDocument();
                        xmlDocument.LoadXml(await GetStringFromHttpResponse(checkUpdateFileUrl));
                        string appUpdVer = xmlDocument.GetElementsByTagName("testupos")[0].InnerText;
                        string appBinLink = xmlDocument.GetElementsByTagName("updurl")[0].InnerText;

                        if (Convert.ToDouble(appCurVer, CultureInfo.InvariantCulture) == Convert.ToDouble(appUpdVer, CultureInfo.InvariantCulture))
                        {
                            if (MsgShow)
                            {
                                MessageBox.Show(string.Format(currentVersionMsg, appCurVer), updateAvailableTitle);
                            }
                            return;
                        }
                        else
                        {
                            if (MessageBox.Show(string.Format(updateAvailableMsg, appUpdVer), updateAvailableTitle, MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                using (var stream = await client.GetStreamAsync(appBinLink))
                                using (var file = new FileStream(newVerFileName, FileMode.CreateNew))
                                    await stream.CopyToAsync(file);
                                Cmd($"taskkill /f /im \"{appName}\" && timeout /t 1 && del \"{appPath}\" && ren {newVerFileName} \"{appName}\" && \"{appPath}\"");
                            }
                        }
                    }
                    catch
                    {
                        if (MsgShow)
                        {
                            MessageBox.Show(errorGetUpdateMsg, testUposTitle);
                        }
                    }
                }
                else
                {
                    if (MsgShow)
                    {
                        MessageBox.Show(noInternetMsg, testUposTitle);
                    }
                }
            }
        }
    }
}
