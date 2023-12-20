using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace testUpos
{
    public partial class ShowFileForm : Form
    {
        public static string pPath;

        public const string windowTitle = "Содержимое файла {0}";
        public const string saveFileDialogTitle = "Сохранить как";

        public ShowFileForm(string filepath)
        {
            InitializeComponent();
            Text = string.Format(windowTitle, filepath);
            CheckContent.WordWrap = false;
            CheckContent.Text = ReadFile(filepath);
        }

        private string ReadFile(string filepath) => File.ReadAllText(filepath, Encoding.GetEncoding(866));

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintPageHandler;
            PrintDialog printDialog = new PrintDialog { Document = printDocument };
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDialog.Document.Print();
            }
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e) => e.Graphics.DrawString(CheckContent.Text, new Font("Courier New", 12), Brushes.Black, 0, 0);

        public void SaveFile()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                Title = saveFileDialogTitle,
                FileName = $"recipt_{DateTime.Now:ddMMyyyy_Hmmss}",
                AddExtension = true,
                DefaultExt = "txt",
                RestoreDirectory = true
            })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveTextToFile(saveFileDialog.FileName, CheckContent.Text);
                }
            }
        }

        public async void SaveTextToFile(string fileName, string text) => await Task.Run(() => { File.WriteAllText(fileName, text); });

        private void SaveBtn_Click(object sender, EventArgs e) => SaveFile();

        private void ShowFileForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] dir = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (File.Exists($"{dir[0]}"))
            {
                CheckContent.Text = ReadFile(dir[0]);
                Text = string.Format(windowTitle, dir[0]);
            }
        }

        private void ShowFileForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

    }
}
