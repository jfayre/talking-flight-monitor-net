using DavyKager;
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
        pmdg pmdg = new pmdg();
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
switch (Aircraft.pmdg737.IRS_DisplaySelector.Value)
            {
                case 0:
                    radDispTKGS.Checked = true;
                    lblLeft.Text = "track ";
                    lblRight.Text = "ground speed ";
                    break;
                case 1:
                    radDispPPOS.Checked = true;
                    break;
                case 2:
                    radDispWind.Checked = true;
                    break;
                case 3:
                    radDispHDGStat.Checked = true;
                    lblLeft.Text = "heading ";
                    lblRight.Text = "status ";
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
            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "radIRULeftOff":
                        pmdg.IRULeftOff();
                        
                        break;
                    case "radIRULeftAlign":
                        pmdg.IRULeftAlign();
                        break;
                    case "radIRULeftNav":
                        pmdg.IRULeftNav();
                        break;

                    case "radIRULeftAtt":
                        pmdg.IRULeftAtt();
                        break;



                }
            }
        
        }

        private void radIRURight_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "radIRURightOff":
                        pmdg.IRURightOff();
                        break;
                    case "radIRURightAlign":
                        pmdg.IRURightAlign();
                        break;
                    case "radIRURightNav":
                        pmdg.IRURightNav();
                        break;

                    case "radIRURightAtt":
                        pmdg.IRURightAtt();
                        break;

                }
            }

        }
    }
}
