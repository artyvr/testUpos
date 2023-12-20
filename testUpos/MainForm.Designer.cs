
namespace testUpos
{
    partial class TestUposForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestUposForm));
            this.UposPath = new System.Windows.Forms.TextBox();
            this.UposPathLabel = new System.Windows.Forms.Label();
            this.RecResultsBtn = new System.Windows.Forms.Button();
            this.PaymentBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.RemoteDLBtn = new System.Windows.Forms.Button();
            this.PingBtn = new System.Windows.Forms.Button();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.MsgLabel = new System.Windows.Forms.Label();
            this.RegDllBtn = new System.Windows.Forms.Button();
            this.ShowPBtn = new System.Windows.Forms.Button();
            this.TID = new System.Windows.Forms.TextBox();
            this.ActivationCode = new System.Windows.Forms.TextBox();
            this.UnregDllBtn = new System.Windows.Forms.Button();
            this.UposVersionsInfoBtn = new System.Windows.Forms.Button();
            this.GetComPortsBtn = new System.Windows.Forms.Button();
            this.DevicesManagerBtn = new System.Windows.Forms.Button();
            this.OpenPinPadiniBtn = new System.Windows.Forms.Button();
            this.OpenUposDirBtn = new System.Windows.Forms.Button();
            this.PinPadVersionsInfoBtn = new System.Windows.Forms.Button();
            this.KillProcBtn = new System.Windows.Forms.Button();
            this.ShowPinPad = new System.Windows.Forms.Label();
            this.LoadParmBtn = new System.Windows.Forms.Button();
            this.loadParmKey = new System.Windows.Forms.TextBox();
            this.showReceipt = new System.Windows.Forms.CheckBox();
            this.appMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.openReceptMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.checkUpdateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAppDirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SeachUPOSErrorsToolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadparmKeysHelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TestSbrfDllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinPadMenuBtn = new System.Windows.Forms.Button();
            this.OperationProgress = new System.Windows.Forms.ProgressBar();
            this.AskAdminPrevCheckBox = new System.Windows.Forms.CheckBox();
            this.AppMsglabel = new System.Windows.Forms.Label();
            this.HostsTestBtn = new System.Windows.Forms.Button();
            this.appMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // UposPath
            // 
            this.UposPath.Location = new System.Drawing.Point(54, 56);
            this.UposPath.Name = "UposPath";
            this.UposPath.Size = new System.Drawing.Size(171, 20);
            this.UposPath.TabIndex = 0;
            // 
            // UposPathLabel
            // 
            this.UposPathLabel.AutoSize = true;
            this.UposPathLabel.Location = new System.Drawing.Point(14, 40);
            this.UposPathLabel.Name = "UposPathLabel";
            this.UposPathLabel.Size = new System.Drawing.Size(79, 13);
            this.UposPathLabel.TabIndex = 1;
            this.UposPathLabel.Text = "Путь до UPOS";
            // 
            // RecResultsBtn
            // 
            this.RecResultsBtn.Location = new System.Drawing.Point(16, 124);
            this.RecResultsBtn.Name = "RecResultsBtn";
            this.RecResultsBtn.Size = new System.Drawing.Size(245, 23);
            this.RecResultsBtn.TabIndex = 2;
            this.RecResultsBtn.Text = "Сверка итогов (LoadParm.exe 7)";
            this.RecResultsBtn.UseVisualStyleBackColor = true;
            this.RecResultsBtn.Click += new System.EventHandler(this.RecResultsBtn_Click);
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.Location = new System.Drawing.Point(16, 153);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(245, 23);
            this.PaymentBtn.TabIndex = 3;
            this.PaymentBtn.Text = "Оплата 1 руб. (LoadParm.exe 1 100)";
            this.PaymentBtn.UseVisualStyleBackColor = true;
            this.PaymentBtn.Click += new System.EventHandler(this.PaymentBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(16, 182);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(245, 23);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Отмена 1 руб. (LoadParm.exe 8 100)";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // RemoteDLBtn
            // 
            this.RemoteDLBtn.Location = new System.Drawing.Point(15, 269);
            this.RemoteDLBtn.Name = "RemoteDLBtn";
            this.RemoteDLBtn.Size = new System.Drawing.Size(141, 46);
            this.RemoteDLBtn.TabIndex = 5;
            this.RemoteDLBtn.Text = "Удаленная загрузка (loadParm.exe 21)";
            this.RemoteDLBtn.UseVisualStyleBackColor = true;
            this.RemoteDLBtn.Click += new System.EventHandler(this.RemoteDLBtn_Click);
            // 
            // PingBtn
            // 
            this.PingBtn.Location = new System.Drawing.Point(16, 240);
            this.PingBtn.Name = "PingBtn";
            this.PingBtn.Size = new System.Drawing.Size(245, 23);
            this.PingBtn.TabIndex = 6;
            this.PingBtn.Text = "Ping (LoadParm.exe 47 2)";
            this.PingBtn.UseVisualStyleBackColor = true;
            this.PingBtn.Click += new System.EventHandler(this.PingBtn_Click);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(231, 56);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(30, 20);
            this.BrowseBtn.TabIndex = 8;
            this.BrowseBtn.Text = "...";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // MsgLabel
            // 
            this.MsgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MsgLabel.ForeColor = System.Drawing.Color.Red;
            this.MsgLabel.Location = new System.Drawing.Point(16, 79);
            this.MsgLabel.Name = "MsgLabel";
            this.MsgLabel.Size = new System.Drawing.Size(245, 13);
            this.MsgLabel.TabIndex = 9;
            this.MsgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegDllBtn
            // 
            this.RegDllBtn.Location = new System.Drawing.Point(17, 409);
            this.RegDllBtn.Name = "RegDllBtn";
            this.RegDllBtn.Size = new System.Drawing.Size(156, 23);
            this.RegDllBtn.TabIndex = 10;
            this.RegDllBtn.Text = "regsvr32 sbrf.dll sbrfcom.dll";
            this.RegDllBtn.UseVisualStyleBackColor = true;
            this.RegDllBtn.Click += new System.EventHandler(this.RegDllBtn_Click);
            // 
            // ShowPBtn
            // 
            this.ShowPBtn.AllowDrop = true;
            this.ShowPBtn.Location = new System.Drawing.Point(16, 211);
            this.ShowPBtn.Name = "ShowPBtn";
            this.ShowPBtn.Size = new System.Drawing.Size(245, 23);
            this.ShowPBtn.TabIndex = 11;
            this.ShowPBtn.Text = "Показать последний чек (файл p)";
            this.ShowPBtn.UseVisualStyleBackColor = true;
            this.ShowPBtn.Click += new System.EventHandler(this.ShowPBtn_Click);
            this.ShowPBtn.DragDrop += new System.Windows.Forms.DragEventHandler(this.ShowPBtn_DragDrop);
            this.ShowPBtn.DragEnter += new System.Windows.Forms.DragEventHandler(this.ShowPBtn_DragEnter);
            // 
            // TID
            // 
            this.TID.ForeColor = System.Drawing.Color.DarkGray;
            this.TID.Location = new System.Drawing.Point(162, 269);
            this.TID.Name = "TID";
            this.TID.Size = new System.Drawing.Size(100, 20);
            this.TID.TabIndex = 12;
            this.TID.Text = "TID";
            // 
            // ActivationCode
            // 
            this.ActivationCode.ForeColor = System.Drawing.Color.DarkGray;
            this.ActivationCode.Location = new System.Drawing.Point(162, 295);
            this.ActivationCode.Name = "ActivationCode";
            this.ActivationCode.Size = new System.Drawing.Size(100, 20);
            this.ActivationCode.TabIndex = 13;
            this.ActivationCode.Text = "Код активации";
            // 
            // UnregDllBtn
            // 
            this.UnregDllBtn.Location = new System.Drawing.Point(178, 409);
            this.UnregDllBtn.Name = "UnregDllBtn";
            this.UnregDllBtn.Size = new System.Drawing.Size(30, 23);
            this.UnregDllBtn.TabIndex = 14;
            this.UnregDllBtn.Text = "/u";
            this.UnregDllBtn.UseVisualStyleBackColor = true;
            this.UnregDllBtn.Click += new System.EventHandler(this.UnregDllBtn_Click);
            // 
            // UposVersionsInfoBtn
            // 
            this.UposVersionsInfoBtn.Location = new System.Drawing.Point(15, 467);
            this.UposVersionsInfoBtn.Name = "UposVersionsInfoBtn";
            this.UposVersionsInfoBtn.Size = new System.Drawing.Size(245, 23);
            this.UposVersionsInfoBtn.TabIndex = 15;
            this.UposVersionsInfoBtn.Text = "Версии файлов UPOS";
            this.UposVersionsInfoBtn.UseVisualStyleBackColor = true;
            this.UposVersionsInfoBtn.Click += new System.EventHandler(this.UposVersionsInfoBtn_Click);
            // 
            // GetComPortsBtn
            // 
            this.GetComPortsBtn.Location = new System.Drawing.Point(16, 525);
            this.GetComPortsBtn.Name = "GetComPortsBtn";
            this.GetComPortsBtn.Size = new System.Drawing.Size(113, 23);
            this.GetComPortsBtn.TabIndex = 16;
            this.GetComPortsBtn.Text = "COM-порты";
            this.GetComPortsBtn.UseVisualStyleBackColor = true;
            this.GetComPortsBtn.Click += new System.EventHandler(this.GetComPortsBtn_Click);
            // 
            // DevicesManagerBtn
            // 
            this.DevicesManagerBtn.Location = new System.Drawing.Point(135, 525);
            this.DevicesManagerBtn.Name = "DevicesManagerBtn";
            this.DevicesManagerBtn.Size = new System.Drawing.Size(125, 23);
            this.DevicesManagerBtn.TabIndex = 17;
            this.DevicesManagerBtn.Text = "Диспетчер устройств";
            this.DevicesManagerBtn.UseVisualStyleBackColor = true;
            this.DevicesManagerBtn.Click += new System.EventHandler(this.DevicesManagerBtn_Click);
            // 
            // OpenPinPadiniBtn
            // 
            this.OpenPinPadiniBtn.Location = new System.Drawing.Point(15, 496);
            this.OpenPinPadiniBtn.Name = "OpenPinPadiniBtn";
            this.OpenPinPadiniBtn.Size = new System.Drawing.Size(245, 23);
            this.OpenPinPadiniBtn.TabIndex = 18;
            this.OpenPinPadiniBtn.Text = "Открыть pinpad.ini";
            this.OpenPinPadiniBtn.UseVisualStyleBackColor = true;
            this.OpenPinPadiniBtn.Click += new System.EventHandler(this.OpenPinPadiniBtn_Click);
            // 
            // OpenUposDirBtn
            // 
            this.OpenUposDirBtn.Location = new System.Drawing.Point(17, 56);
            this.OpenUposDirBtn.Name = "OpenUposDirBtn";
            this.OpenUposDirBtn.Size = new System.Drawing.Size(30, 20);
            this.OpenUposDirBtn.TabIndex = 19;
            this.OpenUposDirBtn.Text = "->";
            this.OpenUposDirBtn.UseVisualStyleBackColor = true;
            this.OpenUposDirBtn.Click += new System.EventHandler(this.OpenUposDirBtn_Click);
            // 
            // PinPadVersionsInfoBtn
            // 
            this.PinPadVersionsInfoBtn.Location = new System.Drawing.Point(16, 380);
            this.PinPadVersionsInfoBtn.Name = "PinPadVersionsInfoBtn";
            this.PinPadVersionsInfoBtn.Size = new System.Drawing.Size(245, 23);
            this.PinPadVersionsInfoBtn.TabIndex = 20;
            this.PinPadVersionsInfoBtn.Text = "Версии в pin-pad (Loadparm.exe 36)";
            this.PinPadVersionsInfoBtn.UseVisualStyleBackColor = true;
            this.PinPadVersionsInfoBtn.Click += new System.EventHandler(this.PinPadVersionsInfoBtn_Click);
            // 
            // KillProcBtn
            // 
            this.KillProcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KillProcBtn.ForeColor = System.Drawing.Color.OliveDrab;
            this.KillProcBtn.Location = new System.Drawing.Point(16, 95);
            this.KillProcBtn.Name = "KillProcBtn";
            this.KillProcBtn.Size = new System.Drawing.Size(245, 23);
            this.KillProcBtn.TabIndex = 21;
            this.KillProcBtn.Text = "Убить процесс Loadparm.exe";
            this.KillProcBtn.UseVisualStyleBackColor = true;
            this.KillProcBtn.Click += new System.EventHandler(this.KillProcBtn_Click);
            // 
            // ShowPinPad
            // 
            this.ShowPinPad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPinPad.Location = new System.Drawing.Point(17, 551);
            this.ShowPinPad.Name = "ShowPinPad";
            this.ShowPinPad.Size = new System.Drawing.Size(242, 23);
            this.ShowPinPad.TabIndex = 22;
            this.ShowPinPad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadParmBtn
            // 
            this.LoadParmBtn.Location = new System.Drawing.Point(15, 351);
            this.LoadParmBtn.Name = "LoadParmBtn";
            this.LoadParmBtn.Size = new System.Drawing.Size(140, 23);
            this.LoadParmBtn.TabIndex = 24;
            this.LoadParmBtn.Text = "LoadParm.exe";
            this.LoadParmBtn.UseVisualStyleBackColor = true;
            this.LoadParmBtn.Click += new System.EventHandler(this.LoadParmBtn_Click);
            // 
            // loadParmKey
            // 
            this.loadParmKey.Location = new System.Drawing.Point(161, 352);
            this.loadParmKey.Name = "loadParmKey";
            this.loadParmKey.Size = new System.Drawing.Size(46, 20);
            this.loadParmKey.TabIndex = 25;
            // 
            // showReceipt
            // 
            this.showReceipt.AutoSize = true;
            this.showReceipt.Location = new System.Drawing.Point(213, 355);
            this.showReceipt.Name = "showReceipt";
            this.showReceipt.Size = new System.Drawing.Size(46, 17);
            this.showReceipt.TabIndex = 26;
            this.showReceipt.Text = "Чек";
            this.showReceipt.UseVisualStyleBackColor = true;
            // 
            // appMenuStrip
            // 
            this.appMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.appMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu});
            this.appMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.appMenuStrip.Name = "appMenuStrip";
            this.appMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.appMenuStrip.ShowItemToolTips = true;
            this.appMenuStrip.Size = new System.Drawing.Size(277, 24);
            this.appMenuStrip.TabIndex = 28;
            this.appMenuStrip.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openReceptMenuItem,
            this.toolStripSeparator2,
            this.checkUpdateMenuItem,
            this.openAppDirMenuItem,
            this.toolStripSeparator1,
            this.SeachUPOSErrorsToolMenuItem,
            this.loadparmKeysHelpMenuItem,
            this.toolStripSeparator3,
            this.TestSbrfDllMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(48, 20);
            this.menu.Text = "Меню";
            // 
            // openReceptMenuItem
            // 
            this.openReceptMenuItem.Name = "openReceptMenuItem";
            this.openReceptMenuItem.Size = new System.Drawing.Size(234, 22);
            this.openReceptMenuItem.Text = "Открыть файл чека";
            this.openReceptMenuItem.Click += new System.EventHandler(this.OpenReceptMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(231, 6);
            // 
            // checkUpdateMenuItem
            // 
            this.checkUpdateMenuItem.Name = "checkUpdateMenuItem";
            this.checkUpdateMenuItem.Size = new System.Drawing.Size(234, 22);
            this.checkUpdateMenuItem.Text = "Проверить обновления";
            this.checkUpdateMenuItem.Click += new System.EventHandler(this.CheckUpdateMenuItem_Click);
            // 
            // openAppDirMenuItem
            // 
            this.openAppDirMenuItem.Name = "openAppDirMenuItem";
            this.openAppDirMenuItem.Size = new System.Drawing.Size(234, 22);
            this.openAppDirMenuItem.Text = "Открыть каталог с программой";
            this.openAppDirMenuItem.Click += new System.EventHandler(this.OpenAppDirMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // SeachUPOSErrorsToolMenuItem
            // 
            this.SeachUPOSErrorsToolMenuItem.Name = "SeachUPOSErrorsToolMenuItem";
            this.SeachUPOSErrorsToolMenuItem.Size = new System.Drawing.Size(234, 22);
            this.SeachUPOSErrorsToolMenuItem.Text = "Поиск ошибок UPOS";
            this.SeachUPOSErrorsToolMenuItem.Click += new System.EventHandler(this.SeachUPOSErrorsToolMenuItem_Click);
            // 
            // loadparmKeysHelpMenuItem
            // 
            this.loadparmKeysHelpMenuItem.Name = "loadparmKeysHelpMenuItem";
            this.loadparmKeysHelpMenuItem.Size = new System.Drawing.Size(234, 22);
            this.loadparmKeysHelpMenuItem.Text = "Справка по ключам";
            this.loadparmKeysHelpMenuItem.Click += new System.EventHandler(this.LoadparmKeysHelpMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(231, 6);
            // 
            // TestSbrfDllMenuItem
            // 
            this.TestSbrfDllMenuItem.Name = "TestSbrfDllMenuItem";
            this.TestSbrfDllMenuItem.Size = new System.Drawing.Size(234, 22);
            this.TestSbrfDllMenuItem.Text = "Тест sbrf.dll";
            this.TestSbrfDllMenuItem.Click += new System.EventHandler(this.TestSbrfDllMenuItem_Click);
            // 
            // pinPadMenuBtn
            // 
            this.pinPadMenuBtn.Location = new System.Drawing.Point(16, 322);
            this.pinPadMenuBtn.Name = "pinPadMenuBtn";
            this.pinPadMenuBtn.Size = new System.Drawing.Size(245, 23);
            this.pinPadMenuBtn.TabIndex = 29;
            this.pinPadMenuBtn.Text = "Тех. меню (loadparm. exe 11)";
            this.pinPadMenuBtn.UseVisualStyleBackColor = true;
            this.pinPadMenuBtn.Click += new System.EventHandler(this.PinPadMenuBtn_Click);
            // 
            // OperationProgress
            // 
            this.OperationProgress.BackColor = System.Drawing.SystemColors.Control;
            this.OperationProgress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.OperationProgress.Location = new System.Drawing.Point(0, 574);
            this.OperationProgress.Margin = new System.Windows.Forms.Padding(0);
            this.OperationProgress.MarqueeAnimationSpeed = 50;
            this.OperationProgress.Name = "OperationProgress";
            this.OperationProgress.Size = new System.Drawing.Size(277, 10);
            this.OperationProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.OperationProgress.TabIndex = 31;
            this.OperationProgress.Visible = false;
            // 
            // AskAdminPrevCheckBox
            // 
            this.AskAdminPrevCheckBox.AutoSize = true;
            this.AskAdminPrevCheckBox.Location = new System.Drawing.Point(213, 413);
            this.AskAdminPrevCheckBox.Name = "AskAdminPrevCheckBox";
            this.AskAdminPrevCheckBox.Size = new System.Drawing.Size(46, 17);
            this.AskAdminPrevCheckBox.TabIndex = 32;
            this.AskAdminPrevCheckBox.Text = "adm";
            this.AskAdminPrevCheckBox.UseVisualStyleBackColor = true;
            // 
            // AppMsglabel
            // 
            this.AppMsglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppMsglabel.ForeColor = System.Drawing.Color.DimGray;
            this.AppMsglabel.Location = new System.Drawing.Point(103, 40);
            this.AppMsglabel.Name = "AppMsglabel";
            this.AppMsglabel.Size = new System.Drawing.Size(159, 13);
            this.AppMsglabel.TabIndex = 33;
            this.AppMsglabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HostsTestBtn
            // 
            this.HostsTestBtn.Location = new System.Drawing.Point(17, 438);
            this.HostsTestBtn.Name = "HostsTestBtn";
            this.HostsTestBtn.Size = new System.Drawing.Size(245, 23);
            this.HostsTestBtn.TabIndex = 34;
            this.HostsTestBtn.Text = "HOSTS тест";
            this.HostsTestBtn.UseVisualStyleBackColor = true;
            this.HostsTestBtn.Click += new System.EventHandler(this.HostsTestBtn_Click);
            // 
            // TestUposForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 584);
            this.Controls.Add(this.HostsTestBtn);
            this.Controls.Add(this.AppMsglabel);
            this.Controls.Add(this.AskAdminPrevCheckBox);
            this.Controls.Add(this.OperationProgress);
            this.Controls.Add(this.pinPadMenuBtn);
            this.Controls.Add(this.RegDllBtn);
            this.Controls.Add(this.UnregDllBtn);
            this.Controls.Add(this.ShowPinPad);
            this.Controls.Add(this.KillProcBtn);
            this.Controls.Add(this.OpenUposDirBtn);
            this.Controls.Add(this.showReceipt);
            this.Controls.Add(this.MsgLabel);
            this.Controls.Add(this.UposVersionsInfoBtn);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.RecResultsBtn);
            this.Controls.Add(this.UposPathLabel);
            this.Controls.Add(this.GetComPortsBtn);
            this.Controls.Add(this.UposPath);
            this.Controls.Add(this.PinPadVersionsInfoBtn);
            this.Controls.Add(this.ActivationCode);
            this.Controls.Add(this.DevicesManagerBtn);
            this.Controls.Add(this.TID);
            this.Controls.Add(this.loadParmKey);
            this.Controls.Add(this.ShowPBtn);
            this.Controls.Add(this.OpenPinPadiniBtn);
            this.Controls.Add(this.PingBtn);
            this.Controls.Add(this.PaymentBtn);
            this.Controls.Add(this.RemoteDLBtn);
            this.Controls.Add(this.LoadParmBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.appMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.appMenuStrip;
            this.MaximizeBox = false;
            this.Name = "TestUposForm";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test UPOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestUposForm_FormClosing);
            this.Load += new System.EventHandler(this.TestUposForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.TestUposForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.TestUposForm_DragEnter);
            this.appMenuStrip.ResumeLayout(false);
            this.appMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UposPath;
        private System.Windows.Forms.Label UposPathLabel;
        private System.Windows.Forms.Button RecResultsBtn;
        private System.Windows.Forms.Button PaymentBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button RemoteDLBtn;
        private System.Windows.Forms.Button PingBtn;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Label MsgLabel;
        private System.Windows.Forms.Button RegDllBtn;
        private System.Windows.Forms.Button ShowPBtn;
        private System.Windows.Forms.TextBox TID;
        private System.Windows.Forms.TextBox ActivationCode;
        private System.Windows.Forms.Button UnregDllBtn;
        private System.Windows.Forms.Button UposVersionsInfoBtn;
        private System.Windows.Forms.Button GetComPortsBtn;
        private System.Windows.Forms.Button DevicesManagerBtn;
        private System.Windows.Forms.Button OpenPinPadiniBtn;
        private System.Windows.Forms.Button OpenUposDirBtn;
        private System.Windows.Forms.Button PinPadVersionsInfoBtn;
        private System.Windows.Forms.Button KillProcBtn;
        private System.Windows.Forms.Label ShowPinPad;
        private System.Windows.Forms.Button LoadParmBtn;
        private System.Windows.Forms.TextBox loadParmKey;
        private System.Windows.Forms.CheckBox showReceipt;
        private System.Windows.Forms.MenuStrip appMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem openReceptMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkUpdateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadparmKeysHelpMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button pinPadMenuBtn;
        private System.Windows.Forms.ProgressBar OperationProgress;
        private System.Windows.Forms.CheckBox AskAdminPrevCheckBox;
        private System.Windows.Forms.ToolStripMenuItem TestSbrfDllMenuItem;
        private System.Windows.Forms.Label AppMsglabel;
        private System.Windows.Forms.ToolStripMenuItem SeachUPOSErrorsToolMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem openAppDirMenuItem;
        private System.Windows.Forms.Button HostsTestBtn;
    }
}

