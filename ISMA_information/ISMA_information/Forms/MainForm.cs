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
using ISMA_information.FormsUser;

namespace ISMA_information
{
    public partial class MainForm : KryptonForm
    {
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            FormClosed += new FormClosedEventHandler(OnFormClosed);
        }

        private void LoadUserControl(UserControl userControl)
        {
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(userControl);
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e) { Application.Exit(); }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ControlTechnique());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LoadUserControl(new UserControl2());
        }
    }
}
