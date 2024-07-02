using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Progress.Value += 2;

            if (Progress.Value == 100)
            {
                timer1.Stop();
                Authentication authentication = new Authentication();
                authentication.Show();
                //ProgressMenu progressMenu = new ProgressMenu();
                //progressMenu.Close();
                Hide();
            }
        }
    }
}
