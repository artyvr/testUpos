using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testUpos
{
    public partial class TestSbrfDll : Form
    {
        public const string FatalErrorMsg = "Фатальная ошибка";
        public const string NotFoundErrorMsg = "Код {0} - не найден";

        public TestSbrfDll()
        {
            InitializeComponent();
            TestSbrfDllProgressBar.Visible = false;
            SbrfDllTestResalt.Text = "";
            Sbrfdll.CreateOblectSbrf();
        }

        private void DisableEnableButtons(bool condition)
        {
            foreach (Button button in Controls.OfType<Button>())
            {
                button.Enabled = condition;
            }
        }

        private async void TestDllCommandWrapper(Func<Dictionary<string, dynamic>> action)
        {
            try
            {
                DisableEnableButtons(false);
                SbrfDllTestResalt.Text = "";
                ResultCheque.Text = "";
                TestSbrfDllProgressBar.Visible = true;
                var result = await Task.Run(() => action());
                SbrfDllTestResalt.Text = await Task.Run(() => CheckError(result["resultCode"]));
                ResultCheque.Text = result["resultCheque"];
            }
            catch (Exception e)
            {
                SbrfDllTestResalt.Text = FatalErrorMsg;
                MessageBox.Show(e.Message);
            }
            finally
            {
                DisableEnableButtons(true);
                TestSbrfDllProgressBar.Visible = false;
            }

        }

        private string CheckError(int res)
        {
            foreach (var error in UposErrors.GetErrors().Where(error => error.Key == res))
            {
                return $"{error.Key} - {error.Value}";
            }
            return (string.Format(NotFoundErrorMsg, res));
        }

        private void TestPinPadConnectionBtn_Click(object sender, EventArgs e) => TestDllCommandWrapper(Sbrfdll.TestPinPadConnection);

        private void GetTIDBtn_Click(object sender, EventArgs e) => TestDllCommandWrapper(Sbrfdll.GetTID);

        private void AmountBtn_Click(object sender, EventArgs e) => TestDllCommandWrapper(Sbrfdll.GetAmount);

        private void RollBackAmountBtn_Click(object sender, EventArgs e) => TestDllCommandWrapper(Sbrfdll.RollBackAmount);

        private void CloseDayBtn_Click(object sender, EventArgs e) => TestDllCommandWrapper(Sbrfdll.CloseDay);
    }
}
