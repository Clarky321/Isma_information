using ISMA_information.Forms;
using System;
using System.Windows.Forms;

namespace ISMA_information
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ProgressMenu progressMenu = new ProgressMenu();
            progressMenu.FormClosed += OnFormClosed;
            progressMenu.Show();
            Application.Run();
        }

        private static void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            if (sender is ProgressMenu)
            {
                Authentication authForm = CreateAuthenticationForm();
                authForm.Show();
            }
        }

        public static Authentication CreateAuthenticationForm() { return new Authentication(); }
    }
}