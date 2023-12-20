using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testUpos
{
    public partial class TestUposForm : Form
    {
        public static string appVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString(2);

        public static string LoadParmPath;
        public static string dllPath;
        public static string pFilePath;

        public static string appTitle = "testUpos ver." + appVersion;

        public const string loadparm = "LoadParm.exe";
        public const string sbrf = "sbrf.dll";
        public const string sbrfcom = "sbrfcom.dll";
        public const string pinpadini = "pinpad.ini";
        public const string checkFile = "p";
        public const string statusFile = "e";



        public const string explorer = "explorer.exe";
        public const string notepad = "notepad.exe";
        public const string deviceManager = "hdwwiz.cpl";
        public const string regsvr = "regsvr32.exe";

        public const string UposPathToolTipText = "Укажите папку с UPOS, либо перетащите её на форму";
        public const string browseBtnToolTipText = "Выбрать директорию с UPOS";
        public const string unregDllBtnToolTipText = "Отменить регистрацию dll";
        public const string openUposDirBtnToolTipText = "Открыть директорию с UPOS";
        public const string getComPortsBtnToolTipText = "Показать COM-порты в системе";
        public const string devicesManagerBtnTipText = "Открыть диспетчер устройств";
        public const string loadParmBtnTollTipText = "Произвольная команда";
        public const string loadParmKeyToolTipText = "Произвольная ключ";
        public const string showReceiptToolTipText = "Показать чек после операции";
        public const string ShowPBtnToolTipText = "Открывает р-файл, можно перетащить файл на кнопку";
        public const string AskAdminPrevCheckBoxToolTipText = "С правами администратора!";
        public const string TestSbrfDllMenuItemToolTipText = "Треуется регистрация sbrf.dll";

        public const string helpBtnTipText = "Справка по ключам loadparm.exe";
        public const string selectReciptFileTitle = "Выбрать фаил чека";

        public const string activationCodeMsg = "Код активации";
        public const string TIDMsg = "TID";
        public const string directoryNotExistMsg = "Директория не существует!";
        public const string notFoundMsg = "не найден...";
        public const string remoteDownloadQuestionMsg = "Выполнить УЗ без кода активации?";
        public const string remoteDownloadMsg = "УЗ";
        public const string enterTIDActivatioCodeMsg = "Введите TID и Код активации!";
        public const string comPortsMissingMsg = "COM-порты отсутствуют";
        public const string pinPadNotConnectedMsg = "pin-pad не подключен или не опознан";
        public const string notAvailableNetworkMsg = "Нет активных сетевых подключений!";
        public const string notAvailableNetworkTitle = "Сеть...";
        public const string emptyKeyMsg = "Запуск loadparm.exe без ключей";

        public const string deviceChangeEventQuery = "SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2 or EventType = 3";
        public const string getCOMPortsQuery = "SELECT HardwareID,name,Manufacturer FROM Win32_PnPEntity WHERE ClassGuid=\"{4d36e978-e325-11ce-bfc1-08002be10318}\"";

        public TestUposForm()
        {
            InitializeComponent();
            Text = appTitle;
            UposPath.Text = Path.GetPathRoot(Environment.SystemDirectory) + "sbrf";
            LoadParmPath = UposPath.Text + @"\LoadParm.exe";
            dllPath = UposPath.Text;
            pFilePath = UposPath.Text + @"\p";
            TID.GotFocus += RemoveText;
            TID.LostFocus += AddText;
            ActivationCode.GotFocus += RemoveText;
            ActivationCode.LostFocus += AddText;
            MsgLabel.Text = "";
            OperationProgress.Visible = false;

            SbrfDllRegCheck();
            SetToolTips();
            UsbWatcher();

        }

        public void SetToolTips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(UposPath, UposPathToolTipText);
            toolTip.SetToolTip(BrowseBtn, browseBtnToolTipText);
            toolTip.SetToolTip(UnregDllBtn, unregDllBtnToolTipText);
            toolTip.SetToolTip(OpenUposDirBtn, openUposDirBtnToolTipText);
            toolTip.SetToolTip(LoadParmBtn, loadParmBtnTollTipText);
            toolTip.SetToolTip(loadParmKey, loadParmKeyToolTipText);
            toolTip.SetToolTip(showReceipt, showReceiptToolTipText);
            toolTip.SetToolTip(GetComPortsBtn, getComPortsBtnToolTipText);
            toolTip.SetToolTip(DevicesManagerBtn, devicesManagerBtnTipText);
            toolTip.SetToolTip(ShowPBtn, ShowPBtnToolTipText);
            toolTip.SetToolTip(AskAdminPrevCheckBox, AskAdminPrevCheckBoxToolTipText);

            loadparmKeysHelpMenuItem.ToolTipText = helpBtnTipText;
            TestSbrfDllMenuItem.ToolTipText = TestSbrfDllMenuItemToolTipText;
        }

        public void SbrfDllRegCheck()
        {
            try
            {
                Activator.CreateInstance(Type.GetTypeFromProgID(Sbrfdll.SbrfDllServer));
                TestSbrfDllMenuItem.Enabled = true;
                AppMsglabel.Text = "";
            }
            catch (ArgumentException)
            {
                TestSbrfDllMenuItem.Enabled = false;
                AppMsglabel.Text = Sbrfdll.NotRegSbrfDllErrorMsg;
            }
        }

        public async void BtnCmdWrapper(object sender, Func<string> action)
        {
            var s = (Button)sender;
            s.Enabled = false;
            var result = await Task.Run(() => action());
            s.Enabled = true;
        }

        public async void UsbWatcher()
        {
            await Task.Run(() =>
            {
                WqlEventQuery insertQuery = new WqlEventQuery(deviceChangeEventQuery);
                ManagementEventWatcher insertWatcher = new ManagementEventWatcher(insertQuery);
                insertWatcher.EventArrived += ShowPinPadDev;
                insertWatcher.Start();
            });
        }

        public static async void KillProcs(string procs) => await Task.Run(() => { foreach (var proc in Process.GetProcessesByName(procs)) { proc.Kill(); } });

        public void RemoveText(object sender, EventArgs e)
        {
            var s = (TextBox)sender;
            if (s.Text == GetPlaceHolderText(s))
            {
                s.Text = "";
                s.ForeColor = Color.Black;
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            var s = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(s.Text))
            {
                s.Text = GetPlaceHolderText(s);
                s.ForeColor = Color.DarkGray;
            }
        }

        public string GetPlaceHolderText(TextBox tb) => tb.Name == TIDMsg ? TIDMsg : activationCodeMsg;

        public void Cmd(string line, string v = "") => Process.Start(new ProcessStartInfo { Verb = v, FileName = "cmd", Arguments = $"/c {line}", WindowStyle = ProcessWindowStyle.Hidden }).WaitForExit();

        async void BtnCmd(object sender, string line, bool showp = false, string v = "")
        {
            OperationProgress.Visible = true;
            Button btn = (Button)sender;
            btn.Enabled = false;
            await Task.Run(() => { Cmd(line, v); });
            btn.Enabled = true;
            OperationProgress.Visible = false;
            if (showp)
            {
                OpenPFile(pFilePath);
            }
        }

        private void OpenUposDirBtn_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(dllPath))
            {
                Process.Start(explorer, UposPath.Text);
            }
            else
            {
                MessageBox.Show(directoryNotExistMsg);
            }
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog { RootFolder = Environment.SpecialFolder.MyComputer })
            {
                {
                    if (folderBrowser.ShowDialog() == DialogResult.OK)
                    {
                        SetUposPath(folderBrowser.SelectedPath);
                    }
                }
            }
        }

        public void SetUposPath(string path)
        {
            UposPath.Text = path;
            dllPath = UposPath.Text;
            LoadParmPath = UposPath.Text + @"\LoadParm.exe";
            pFilePath = UposPath.Text + @"\p";
            CheckFIle(LoadParmPath);
        }

        public bool CheckFIle(string fPath)
        {
            if (File.Exists(fPath))
            {
                MsgLabel.Text = "";
                return true;
            }
            else
            {
                MsgLabel.Text = $"{Path.GetFileName(fPath)} {notFoundMsg}";
                return false;
            }
        }

        public void RunCmd(object sender, string cKeys, bool showp = false)
        {
            if (CheckFIle(LoadParmPath))
            {
                BtnCmd(sender, $"{LoadParmPath} {cKeys}", showp);
            }
        }

        public void RegDll(object sender, string dll, string v = "")
        {
            if (CheckFIle(dllPath + @"\sbrf.dll"))
            {
                BtnCmd(sender, $"regsvr32 {dllPath}\\{dll}", false, v);
            }
        }

        private void RecResultsBtn_Click(object sender, EventArgs e) => RunCmd(sender, "7");

        private void PaymentBtn_Click(object sender, EventArgs e) => RunCmd(sender, "1 100");

        private void CancelBtn_Click(object sender, EventArgs e) => RunCmd(sender, "8 100");

        private void RemoteDLBtn_Click(object sender, EventArgs e)
        {
            string tid = TID.Text;
            string ac = ActivationCode.Text;
            if ((!string.IsNullOrEmpty(tid) & !string.IsNullOrEmpty(ac)) && (tid != TIDMsg || ac != activationCodeMsg))
            {
                RunCmd(sender, $"21 {ActivationCode.Text} {TID.Text}");
            }
            else
            {
                DialogResult result = MessageBox.Show(remoteDownloadQuestionMsg, remoteDownloadMsg,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    RunCmd(sender, $"21");
                }
                else
                {
                    MsgLabel.Text = enterTIDActivatioCodeMsg;
                }
            }
        }

        private void PingBtn_Click(object sender, EventArgs e) => RunCmd(sender, "47 2");

        private void PinPadMenuBtn_Click(object sender, EventArgs e) => RunCmd(sender, "11");

        private async void RegDllBtn_Click(object sender, EventArgs e)
        {
            string v = "";
            if (AskAdminPrevCheckBox.Checked) { v = "runas"; }
            RegDll(sender, "sbrf.dll", v);
            await Task.Delay(500);
            RegDll(sender, "sbrfcom.dll", v);
            SbrfDllRegCheck();
        }

        private async void UnregDllBtn_Click(object sender, EventArgs e)
        {
            string v = "";
            if (AskAdminPrevCheckBox.Checked) { v = "runas"; }
            RegDll(sender, "sbrf.dll /u", v);
            await Task.Delay(500);
            RegDll(sender, "sbrfcom.dll /u", v);
            SbrfDllRegCheck();
        }

        private void ShowPBtn_Click(object sender, EventArgs e)
        {
            var s = (Button)sender;
            s.Enabled = false;
            OpenPFile(pFilePath);
            s.Enabled = true;
        }

        public void OpenPFile(string f)
        {
            if (CheckFIle(f)) { new ShowFileForm(f).Show(); }
        }

        private void UposVersionsInfoBtn_Click(object sender, EventArgs e)
        {
            if (CheckFIle(LoadParmPath))
            {
                OperationProgress.Visible = true;
                var s = (Button)sender;
                s.Enabled = false;
                new UposVersions(dllPath).Show();
                s.Enabled = true;
                OperationProgress.Visible = false;
            }
        }

        public void GetComPortsBtn_Click(object sender, EventArgs e)
        {
            OperationProgress.Visible = true;
            Button s = (Button)sender;
            s.Enabled = false;
            ManagementObjectSearcher searcher = PinPadComPort.GetPnPDev();
            if (searcher.Get().Count > 0)
            {
                new ShowCOMPorts(searcher).Show();
            }
            else
            {
                MsgLabel.Text = comPortsMissingMsg;
            }
            s.Enabled = true;
            OperationProgress.Visible = false;
        }

        public void ShowPinPadDev(object sender, EventArgs e) => new Thread(() => { Invoke((MethodInvoker)(() => { GetPinPadDev(); })); }).Start();

        public void GetPinPadDev()
        {
            string pinPadComPort = PinPadComPort.GetComPortNum();
            if (!String.IsNullOrEmpty(pinPadComPort))
            {
                WritePinPadFile(pinPadComPort);
                ShowPinPad.Text = $"pin-pad подключен на COM{pinPadComPort}";
            }
            else
            {
                ShowPinPad.Text = pinPadNotConnectedMsg;
            }
        }

        /// <summary>
        /// Записывает в pinpad.ini номер COM
        /// </summary>
        /// <param name="port">номер COM</param>
        private void WritePinPadFile(string port)
        {
            try
            {
                if (CheckFIle($"{dllPath}\\{pinpadini}"))
                {
                    PinPadIniFile.WriteIniFile($"{dllPath}\\{pinpadini}", port);
                }
            }
            catch
            {
                return;
            }
        }

        private void DevicesManagerBtn_Click(object sender, EventArgs e) => BtnCmd(sender, deviceManager);

        private void OpenPinPadiniBtn_Click(object sender, EventArgs e)
        {
            if (CheckFIle($"{dllPath}\\{pinpadini}"))
            {
                BtnCmd(sender, $"{notepad} {dllPath}\\{pinpadini}");
            }
        }

        private void PinPadVersionsInfoBtn_Click(object sender, EventArgs e) => RunCmd(sender, "36", true);

        private void KillProcBtn_Click(object sender, EventArgs e)
        {
            KillProcs("LoadParm");
            MsgLabel.Text = "";
        }

        private void TestUposForm_Load(object sender, EventArgs e)
        {
            ShowPinPadDev(sender, e);
            KillProcs("LoadParm");
            new Updater().CheckUpdate(5000, false);
            DeleteLog();
        }

        private void LoadParmBtn_Click(object sender, EventArgs e)
        {
            string key = loadParmKey.Text;
            if (!string.IsNullOrEmpty(key))
            {
                RunCmd(sender, $"{key}", showReceipt.Checked);
            }
            else
            {
                MsgLabel.Text = emptyKeyMsg;
                StartProcess(sender, LoadParmPath);
            }
        }

        async void StartProcess(object sender, string proc)
        {
            var s = (Button)sender;
            s.Enabled = false;
            await Task.Run(() => { Process.Start(proc).WaitForExit(); });
            s.Enabled = true;
            MsgLabel.Text = "";
        }

        public void OpenFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = UposPath.Text,
                RestoreDirectory = true,
                Title = selectReciptFileTitle
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    OpenPFile(openFileDialog.FileName);
                }
            }
        }

        private void OpenReceptMenuItem_Click(object sender, EventArgs e) => OpenFile();

        private void CheckUpdateMenuItem_Click(object sender, EventArgs e) => new Updater().CheckUpdate(10, true);

        private void LoadparmKeysHelpMenuItem_Click(object sender, EventArgs e) => new Help().Show();

        public void AddDragNDropCopyEffect(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void TestUposForm_DragEnter(object sender, DragEventArgs e) => AddDragNDropCopyEffect(sender, e);

        private void TestUposForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] dir = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (File.Exists($"{dir[0]}\\{loadparm}"))
            {
                SetUposPath(dir[0]);
            }
        }

        private void ShowPBtn_DragEnter(object sender, DragEventArgs e) => AddDragNDropCopyEffect(sender, e);

        private void ShowPBtn_DragDrop(object sender, DragEventArgs e)
        {
            string[] dir = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (File.Exists($"{dir[0]}"))
            {
                //BtnCmdWrapper(sender, OpenPFile(dir[0]));
                var s = (Button)sender;
                s.Enabled = false;
                OpenPFile(dir[0]);
                s.Enabled = true;
            }
        }

        private void TestSbrfDllMenuItem_Click(object sender, EventArgs e) => new TestSbrfDll().Show();

        private void SeachUPOSErrorsToolMenuItem_Click(object sender, EventArgs e) => new SearchUposErrors().Show();

        /// <summary>
        /// Удаляет sbkernel*.log
        /// </summary>
        private async void DeleteLog()
        {
            await Task.Run(() =>
            {
                try
                {
                    string[] logFiles = Directory.GetFiles(Environment.CurrentDirectory, "sbkernel*.log");
                    if (logFiles.Length > 0)
                    {
                        foreach (string file in logFiles)
                        {
                            if (File.Exists(file))
                            {
                                File.Delete(file);
                            }
                            return;
                        }
                    }
                    return;
                }
                catch
                {
                    return;
                }
            });
        }

        private void TestUposForm_FormClosing(object sender, FormClosingEventArgs e) => DeleteLog();

        private void OpenAppDirMenuItem_Click(object sender, EventArgs e) => Process.Start(explorer, Environment.CurrentDirectory);

        private void HostsTestBtn_Click(object sender, EventArgs e)
        {
            new HostsTest().Show();
        }
    }
}
