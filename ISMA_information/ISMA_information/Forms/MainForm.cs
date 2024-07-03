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

        private void OnFormClosed(object sender, FormClosedEventArgs e) { Application.Exit(); }
    }
}
