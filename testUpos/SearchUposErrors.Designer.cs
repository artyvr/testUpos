
namespace testUpos
{
    partial class SearchUposErrors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchUposErrors));
            this.SearchText = new System.Windows.Forms.TextBox();
            this.SearchResults = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(15, 12);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(359, 20);
            this.SearchText.TabIndex = 0;
            // 
            // SearchResults
            // 
            this.SearchResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchResults.HideSelection = false;
            this.SearchResults.Location = new System.Drawing.Point(15, 38);
            this.SearchResults.Name = "SearchResults";
            this.SearchResults.Size = new System.Drawing.Size(359, 215);
            this.SearchResults.TabIndex = 1;
            this.SearchResults.UseCompatibleStateImageBehavior = false;
            this.SearchResults.View = System.Windows.Forms.View.Details;
            // 
            // SearchUposErrors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 265);
            this.Controls.Add(this.SearchResults);
            this.Controls.Add(this.SearchText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchUposErrors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск ошибок UPOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.ListView SearchResults;
    }
}