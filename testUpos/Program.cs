using System;
using System.Threading;
using System.Windows.Forms;

namespace testUpos
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(AppException);
            Application.Run(new TestUposForm());
        }

        static void AppException(object sender, ThreadExceptionEventArgs e) => MessageBox.Show(e.Exception.Message);
    }
}
