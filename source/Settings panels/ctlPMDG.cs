using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tfm
{
    public partial class ctlPMDG : UserControl, iSettingsPage
    {
        public ctlPMDG()
        {
            InitializeComponent();
        }

        public void SetDocking()
        {
        }

        private void ctlPMDG_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PMDGCDUKeyLayout == "1")
            {
                radCDUKeysDefault.Checked = true;
            }
            else
            {
                radCDUKeysAlternate.Checked = true;

            }

        }

        private void radCDUKeys_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                if (rb.Name == "radCDUKeysDefault")
                {
                    Properties.Settings.Default.PMDGCDUKeyLayout = "1";
                }
                if (rb.Name == "radCDUKeysAlternate")
                {
                    Properties.Settings.Default.PMDGCDUKeyLayout = "2";
                }
            }

        }
    }
}
