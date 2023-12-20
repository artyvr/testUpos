
namespace testUpos
{
    partial class UposVersions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UposVersions));
            this.UposFilesVersions = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // UposFilesVersions
            // 
            this.UposFilesVersions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UposFilesVersions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UposFilesVersions.Location = new System.Drawing.Point(12, 13);
            this.UposFilesVersions.MultiSelect = false;
            this.UposFilesVersions.Name = "UposFilesVersions";
            this.UposFilesVersions.Size = new System.Drawing.Size(323, 330);
            this.UposFilesVersions.TabIndex = 6;
            this.UposFilesVersions.UseCompatibleStateImageBehavior = false;
            this.UposFilesVersions.View = System.Windows.Forms.View.Details;
            // 
            // UposVersions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 357);
            this.Controls.Add(this.UposFilesVersions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UposVersions";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Версии файлов UPOS";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView UposFilesVersions;
    }
}