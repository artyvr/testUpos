using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace testUpos
{
    public partial class UposVersions : Form
    {
        public const string columnHeaderNameText = "Файл";
        public const string columnHeaderVersionText = "Версия";
        public const string titleText = "Версии файлов UPOS";

        public UposVersions(string dllPath)
        {
            InitializeComponent();
            Text = $"{titleText} ({dllPath})";
            AddColumnHeader();
            ShowVersions(dllPath);
        }

        private void AddColumnHeader()
        {
            ColumnHeader fileName, fileVersion;
            fileName = new ColumnHeader();
            fileVersion = new ColumnHeader();
            fileName.Text = columnHeaderNameText;
            fileVersion.Text = columnHeaderVersionText;
            UposFilesVersions.Columns.Add(fileName);
            UposFilesVersions.Columns.Add(fileVersion);
        }

        private string GetFilesInfo(string file) => FileVersionInfo.GetVersionInfo(file).ProductVersion.ToString();

        private void ShowVersions(string fPath)
        {
            var files = Directory.GetFiles(fPath, "*.*", SearchOption.TopDirectoryOnly).Where(s => s.EndsWith(".dll") || s.EndsWith(".exe"));
            if (files != null)
            {
                foreach (string file in files)
                {
                    ListViewItem item = new ListViewItem(file);
                    item.SubItems.Add(GetFilesInfo(file));
                    UposFilesVersions.Items.Add(item);
                }
            }
            UposFilesVersions.FullRowSelect = true;
            UposFilesVersions.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

    }
}
