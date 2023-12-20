
namespace testUpos
{
    partial class TestSbrfDll
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestSbrfDll));
            this.TestPinPadConnectionBtn = new System.Windows.Forms.Button();
            this.SbrfDllTestResalt = new System.Windows.Forms.Label();
            this.GetTIDBtn = new System.Windows.Forms.Button();
            this.AmountBtn = new System.Windows.Forms.Button();
            this.RollBackAmountBtn = new System.Windows.Forms.Button();
            this.CloseDayBtn = new System.Windows.Forms.Button();
            this.TestSbrfDllProgressBar = new System.Windows.Forms.ProgressBar();
            this.ResultCheque = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TestPinPadConnectionBtn
            // 
            this.TestPinPadConnectionBtn.Location = new System.Drawing.Point(13, 38);
            this.TestPinPadConnectionBtn.Name = "TestPinPadConnectionBtn";
            this.TestPinPadConnectionBtn.Size = new System.Drawing.Size(155, 30);
            this.TestPinPadConnectionBtn.TabIndex = 0;
            this.TestPinPadConnectionBtn.Text = "Тест соединения c pin-pad";
            this.TestPinPadConnectionBtn.UseVisualStyleBackColor = true;
            this.TestPinPadConnectionBtn.Click += new System.EventHandler(this.TestPinPadConnectionBtn_Click);
            // 
            // SbrfDllTestResalt
            // 
            this.SbrfDllTestResalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SbrfDllTestResalt.Location = new System.Drawing.Point(13, 12);
            this.SbrfDllTestResalt.Name = "SbrfDllTestResalt";
            this.SbrfDllTestResalt.Size = new System.Drawing.Size(397, 23);
            this.SbrfDllTestResalt.TabIndex = 1;
            this.SbrfDllTestResalt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GetTIDBtn
            // 
            this.GetTIDBtn.Location = new System.Drawing.Point(13, 74);
            this.GetTIDBtn.Name = "GetTIDBtn";
            this.GetTIDBtn.Size = new System.Drawing.Size(155, 30);
            this.GetTIDBtn.TabIndex = 2;
            this.GetTIDBtn.Text = "Получить TID из pin-pad";
            this.GetTIDBtn.UseVisualStyleBackColor = true;
            this.GetTIDBtn.Click += new System.EventHandler(this.GetTIDBtn_Click);
            // 
            // AmountBtn
            // 
            this.AmountBtn.Location = new System.Drawing.Point(13, 146);
            this.AmountBtn.Name = "AmountBtn";
            this.AmountBtn.Size = new System.Drawing.Size(155, 30);
            this.AmountBtn.TabIndex = 3;
            this.AmountBtn.Text = "Оплата на 1 руб.";
            this.AmountBtn.UseVisualStyleBackColor = true;
            this.AmountBtn.Click += new System.EventHandler(this.AmountBtn_Click);
            // 
            // RollBackAmountBtn
            // 
            this.RollBackAmountBtn.Location = new System.Drawing.Point(13, 182);
            this.RollBackAmountBtn.Name = "RollBackAmountBtn";
            this.RollBackAmountBtn.Size = new System.Drawing.Size(155, 30);
            this.RollBackAmountBtn.TabIndex = 4;
            this.RollBackAmountBtn.Text = "Возврат на 1 руб.";
            this.RollBackAmountBtn.UseVisualStyleBackColor = true;
            this.RollBackAmountBtn.Click += new System.EventHandler(this.RollBackAmountBtn_Click);
            // 
            // CloseDayBtn
            // 
            this.CloseDayBtn.Location = new System.Drawing.Point(13, 110);
            this.CloseDayBtn.Name = "CloseDayBtn";
            this.CloseDayBtn.Size = new System.Drawing.Size(155, 30);
            this.CloseDayBtn.TabIndex = 5;
            this.CloseDayBtn.Text = "Свергка итогов";
            this.CloseDayBtn.UseVisualStyleBackColor = true;
            this.CloseDayBtn.Click += new System.EventHandler(this.CloseDayBtn_Click);
            // 
            // TestSbrfDllProgressBar
            // 
            this.TestSbrfDllProgressBar.Location = new System.Drawing.Point(0, 218);
            this.TestSbrfDllProgressBar.Name = "TestSbrfDllProgressBar";
            this.TestSbrfDllProgressBar.Size = new System.Drawing.Size(423, 10);
            this.TestSbrfDllProgressBar.Step = 5;
            this.TestSbrfDllProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.TestSbrfDllProgressBar.TabIndex = 6;
            this.TestSbrfDllProgressBar.Visible = false;
            // 
            // ResultCheque
            // 
            this.ResultCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultCheque.Location = new System.Drawing.Point(175, 38);
            this.ResultCheque.Name = "ResultCheque";
            this.ResultCheque.ReadOnly = true;
            this.ResultCheque.Size = new System.Drawing.Size(235, 174);
            this.ResultCheque.TabIndex = 7;
            this.ResultCheque.Text = "";
            // 
            // TestSbrfDll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 227);
            this.Controls.Add(this.ResultCheque);
            this.Controls.Add(this.TestSbrfDllProgressBar);
            this.Controls.Add(this.CloseDayBtn);
            this.Controls.Add(this.RollBackAmountBtn);
            this.Controls.Add(this.AmountBtn);
            this.Controls.Add(this.GetTIDBtn);
            this.Controls.Add(this.SbrfDllTestResalt);
            this.Controls.Add(this.TestPinPadConnectionBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestSbrfDll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест через интерфейс sbrf.dll";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TestPinPadConnectionBtn;
        private System.Windows.Forms.Label SbrfDllTestResalt;
        private System.Windows.Forms.Button GetTIDBtn;
        private System.Windows.Forms.Button AmountBtn;
        private System.Windows.Forms.Button RollBackAmountBtn;
        private System.Windows.Forms.Button CloseDayBtn;
        private System.Windows.Forms.ProgressBar TestSbrfDllProgressBar;
        private System.Windows.Forms.RichTextBox ResultCheque;
    }
}