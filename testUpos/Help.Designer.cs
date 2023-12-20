
namespace testUpos
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.helpText = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // helpText
            // 
            this.helpText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpText.GridLines = true;
            this.helpText.HideSelection = false;
            this.helpText.Location = new System.Drawing.Point(12, 12);
            this.helpText.Name = "helpText";
            this.helpText.Size = new System.Drawing.Size(405, 669);
            this.helpText.TabIndex = 0;
            this.helpText.UseCompatibleStateImageBehavior = false;
            this.helpText.View = System.Windows.Forms.View.Details;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 693);
            this.Controls.Add(this.helpText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Help";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Помощь";
            this.Load += new System.EventHandler(this.Help_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView helpText;
    }
}