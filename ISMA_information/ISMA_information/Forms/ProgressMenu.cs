using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace ISMA_information.Forms
{
    public partial class ProgressMenu : KryptonForm
    {
        public ProgressMenu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            FormClosed += new FormClosedEventHandler(OnFormClosed);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Progress.Value += 2;

            if (Progress.Value >= 100)
            {
                timer1.Stop();

                Authentication authentication = Program.CreateAuthenticationForm();
                authentication.Show();
                Hide();
            }
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e) { Application.Exit(); }
    }
}