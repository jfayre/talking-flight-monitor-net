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
    public partial class frmComRadios : Form
    {
        // get instance of Autopilot class.
        InstrumentPanel ap = new InstrumentPanel();
        public frmComRadios()
        {
            InitializeComponent();
        }

        private void frmComRadios_Load(object sender, EventArgs e)
        {
            txtCom1.Text = ap.Com1Freq.ToString();
            txtCom1Standby.Text = ap.Com1StandbyFreq.ToString();
            txtCom2.Text = ap.Com2Freq.ToString();
            
            
        }

        private void frmComRadios_Shown(object sender, EventArgs e)
        {
            txtCom1.Focus();
            this.Activate();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtCom1.Text != ap.Com1Freq.ToString())
            {
                ap.Com1Freq = decimal.Parse(txtCom1.Text);
            }
            
            if (txtCom1Standby.Text != ap.Com1StandbyFreq.ToString())
            {
                ap.Com1StandbyFreq = decimal.Parse(txtCom1Standby.Text);
            }
            
            if (txtCom2.Text != ap.Com2Freq.ToString())
            {
                ap.Com2Freq = decimal.Parse(txtCom2.Text);
            }

        }
    }
}
