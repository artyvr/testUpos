namespace testUpos
{
    partial class HostsTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostsTest));
            this.runTestBtn = new System.Windows.Forms.Button();
            this.hostsPorts = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // runTestBtn
            // 
            this.runTestBtn.Location = new System.Drawing.Point(12, 12);
            this.runTestBtn.Name = "runTestBtn";
            this.runTestBtn.Size = new System.Drawing.Size(348, 23);
            this.runTestBtn.TabIndex = 0;
            this.runTestBtn.Text = "Запустить тест";
            this.runTestBtn.UseVisualStyleBackColor = true;
            this.runTestBtn.Click += new System.EventHandler(this.ReloadBtn_Click);
            // 
            // hostsPorts
            // 
            this.hostsPorts.HideSelection = false;
            this.hostsPorts.Location = new System.Drawing.Point(12, 41);
            this.hostsPorts.Name = "hostsPorts";
            this.hostsPorts.Size = new System.Drawing.Size(348, 600);
            this.hostsPorts.TabIndex = 1;
            this.hostsPorts.UseCompatibleStateImageBehavior = false;
            this.hostsPorts.View = System.Windows.Forms.View.Details;
            // 
            // HostsTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 653);
            this.Controls.Add(this.hostsPorts);
            this.Controls.Add(this.runTestBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HostsTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOSTS тест";
            this.Load += new System.EventHandler(this.HostsTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button runTestBtn;
        private System.Windows.Forms.ListView hostsPorts;
    }
}