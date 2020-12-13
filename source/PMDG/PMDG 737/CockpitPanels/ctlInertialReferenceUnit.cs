using FSUIPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tfm
{
    public partial class ctlInertialReferenceUnit : UserControl, iPanelsPage
    {
        public ctlInertialReferenceUnit()
        {
            InitializeComponent();
        }

        private void tmrIRU_Tick(object sender, EventArgs e)
        {
            txtDispLeft.Text = Aircraft.pmdg737.IRS_DisplayLeft.Value;
            txtDispRight.Text = Aircraft.pmdg737.IRS_DisplayRight.Value;
            switch (Aircraft.pmdg737.IRS_ModeSelector[0].Value)
            {
                case 0:
                    radIRULeftOff.Checked = true;
                    break;
                case 1:
                    radIRULeftAlign.Checked = true;
                    break;
                case 2:
                    radIRULeftNav.Checked = true;
                    break;
                case 3:
                    radIRULeftAtt.Checked = true;
                    break;

            }
            switch (Aircraft.pmdg737.IRS_ModeSelector[1].Value)
            {
                case 0:
                    radIRURightOff.Checked = true;
                    break;
                case 1:
                    radIRURightAlign.Checked = true;
                    break;
                case 2:
                    radIRURightNav.Checked = true;
                    break;
                case 3:
                    radIRURightAtt.Checked = true;
                    break;

            }

        }
        
        private void ctlInertialReferenceUnit_Load(object sender, EventArgs e)
        {
            tmrIRU.Start();
        }

        public void SetDocking()
        {
            
        }

        private void radIRULeft_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

        }
    }
}
