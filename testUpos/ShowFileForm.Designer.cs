
namespace testUpos
{
    partial class ShowFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowFileForm));
            this.CheckContent = new System.Windows.Forms.RichTextBox();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckContent
            // 
            this.CheckContent.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckContent.Location = new System.Drawing.Point(12, 42);
            this.CheckContent.Name = "CheckContent";
            this.CheckContent.ReadOnly = true;
            this.CheckContent.Size = new System.Drawing.Size(350, 500);
            this.CheckContent.TabIndex = 1;
            this.CheckContent.Text = "";
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(13, 13);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(70, 23);
            this.PrintBtn.TabIndex = 2;
            this.PrintBtn.Text = "Печать";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(292, 13);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(70, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ShowFileForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 555);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.CheckContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Содержимое файла";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ShowFileForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ShowFileForm_DragEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox CheckContent;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}