﻿
namespace testUpos
{
    partial class ShowCOMPorts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowCOMPorts));
            this.COMPortsList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // COMPortsList
            // 
            this.COMPortsList.HideSelection = false;
            this.COMPortsList.Location = new System.Drawing.Point(12, 12);
            this.COMPortsList.Name = "COMPortsList";
            this.COMPortsList.Size = new System.Drawing.Size(479, 209);
            this.COMPortsList.TabIndex = 0;
            this.COMPortsList.UseCompatibleStateImageBehavior = false;
            this.COMPortsList.View = System.Windows.Forms.View.Details;
            // 
            // ShowCOMPorts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 232);
            this.Controls.Add(this.COMPortsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowCOMPorts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COM порты";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView COMPortsList;
    }
}