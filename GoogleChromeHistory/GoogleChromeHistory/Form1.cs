using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GoogleChromeHistory
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {

        }
        private Boolean closeChrome()
        {
            //closes google chrome so that this program can open the history sql file
            try
            {
                Process[] processNames = Process.GetProcessesByName("chrome");

                foreach (Process item in processNames)
                {
                    item.Kill();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
