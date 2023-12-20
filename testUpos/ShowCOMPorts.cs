using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace testUpos
{
    public partial class ShowCOMPorts : Form
    {
        public const string columnHeaderComNameText = "Название";
        public const string columnHeaderComManText = "Производитель";
        public const string columnHeaderDevIdText = "ID";

        public ShowCOMPorts(ManagementObjectSearcher ports)
        {
            InitializeComponent();
            AddColumnHeader();
            ComPorts(ports);
        }

        private void AddColumnHeader()
        {
            ColumnHeader comName, comMan, devID;
            comName = new ColumnHeader();
            comMan = new ColumnHeader();
            devID = new ColumnHeader();
            comName.Text = columnHeaderComNameText;
            comMan.Text = columnHeaderComManText;
            devID.Text = columnHeaderDevIdText;
            COMPortsList.Columns.Add(comName);
            COMPortsList.Columns.Add(comMan);
            COMPortsList.Columns.Add(devID);
        }

        private void ComPorts(ManagementObjectSearcher ports)
        {
            using (ManagementObjectCollection mCollection = ports.Get())
            {
                foreach (var (queryObj, item) in from ManagementObject queryObj in mCollection
                                                 let item = new ListViewItem(queryObj["name"].ToString())
                                                 select (queryObj, item))
                {
                    item.SubItems.Add(queryObj["Manufacturer"].ToString());
                    item.SubItems.Add(((string[])queryObj["HardwareID"])[0]);
                    COMPortsList.Items.Add(item);
                }
            }

            COMPortsList.FullRowSelect = true;
            COMPortsList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
