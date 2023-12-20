using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace testUpos
{
    public partial class SearchUposErrors : Form
    {
        const string columnHeaderKeyText = "Код";
        const string columnHeaderDescriptionText = "Описание";
        const string SearchTextToolTipText = "Текст для поиска...";
        const string SearchResultsToolTipText = "Результаты поиска";

        public SearchUposErrors()
        {
            InitializeComponent();
            SetToolTips();
            SearchResults.Enabled = false;
            SearchText.KeyUp += SearchText_KeyUp;
        }

        private void SetToolTips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(SearchText, SearchTextToolTipText);
            toolTip.SetToolTip(SearchResults, SearchResultsToolTipText);
        }

        private void SearchText_KeyUp(object sender, KeyEventArgs e) => SearchError();

        private void AddColumnHeader()
        {
            ColumnHeader key, description;
            key = new ColumnHeader();
            description = new ColumnHeader();
            key.Text = columnHeaderKeyText;
            description.Text = columnHeaderDescriptionText;
            SearchResults.Columns.Add(key);
            SearchResults.Columns.Add(description);
            SearchResults.ShowItemToolTips = true;
        }

        public void SearchError()
        {
            SearchResults.Clear();
            AddColumnHeader();
            string q = SearchText.Text.Trim();
            if (!String.IsNullOrEmpty(q))
            {
                foreach (var error in UposErrors.GetErrors())
                {
                    SearchResults.Enabled = true;
                    if (Regex.IsMatch(error.Key.ToString(), $"\\b{q}\\b") || Regex.IsMatch(error.Value.ToString(), $"\\b{q}\\b"))
                    {
                        ListViewItem item = new ListViewItem(error.Key.ToString()); /* ключ */
                        item.SubItems.Add(error.Value); /* Описание */
                        SearchResults.Items.Add(item);
                    }
                }
                SearchResults.FullRowSelect = true;
                SearchResults.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            else
            {
                SearchResults.Clear();
                SearchResults.Enabled = false;
            }
        }
    }
}
