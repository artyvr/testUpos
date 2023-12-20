using System;
using System.Windows.Forms;

namespace testUpos
{
    public partial class Help : Form
    {
        public const string columnHeaderKeyText = "Ключ";
        public const string columnHeaderDescriptionText = "Описание";
        public const string helpWindowTitle = "Справка по ключам loadparm.exe";

        public Help()
        {
            InitializeComponent();
            Text = helpWindowTitle;
            AddColumnHeader();
        }

        private void AddColumnHeader()
        {
            ColumnHeader key, description;
            key = new ColumnHeader();
            description = new ColumnHeader();
            key.Text = columnHeaderKeyText;
            description.Text = columnHeaderDescriptionText;
            helpText.Columns.Add(key);
            helpText.Columns.Add(description);
            helpText.ShowItemToolTips = true;
        }

        private void Help_Load(object sender, EventArgs e)
        {
            foreach (var k in LoadParmKeys.GetKyes())
            {
                ListViewItem item = new ListViewItem(k.Key.ToString()); /* ключ */
                item.SubItems.Add(k.Value.ToString()); /* Описание */
                helpText.Items.Add(item);
            }
            helpText.FullRowSelect = true;
            helpText.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            helpText.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
