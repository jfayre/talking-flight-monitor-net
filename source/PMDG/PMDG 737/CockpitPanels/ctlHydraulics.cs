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
    public partial class ctlHydraulics : UserControl, iPanelsPage
    {
        pmdg pmdg = new pmdg();
        public ctlHydraulics()
        {
            InitializeComponent();
        }

        public void SetDocking()
        {
            
        }
        
        private void ctlHydraulics_Load(object sender, EventArgs e)
        {
            tmrHydraulics.Start();
        }

        private void UpdateToggleControl(bool toggleStateOn, CheckBox ctrl)
        {

            if (toggleStateOn)
            {
                if (ctrl.Checked != true)
                {
                    ctrl.Checked = true;
                }

            }
            else
            {
                if (ctrl.Checked != false)
                {
                    ctrl.Checked = false;
                }

            }
        }


        private void tmrHydraulics_Tick(object sender, EventArgs e)
        {
            UpdateToggleControl(Aircraft.pmdg737.HYD_PumpSw_elec[1].Value > 0, chkElec1);
            UpdateToggleControl(Aircraft.pmdg737.HYD_PumpSw_elec[0].Value > 0, chkElec2);
            UpdateToggleControl(Aircraft.pmdg737.HYD_PumpSw_eng[0].Value > 0, chkEng1);
            UpdateToggleControl(Aircraft.pmdg737.HYD_PumpSw_eng[1].Value > 0, chkEng2);

        }

        private void chkElec1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkElec1.Checked)
            {
                pmdg.HydElec1On();

            }
            else
            {
                pmdg.HydElec1Off();
            }
        }

        private void chkElec2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkElec2.Checked)
            {
                pmdg.HydElec2On();

            }
            else
            {
                pmdg.HydElec2Off();
            }

        }

        private void chkEng1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEng1.Checked)
            {
                pmdg.HydEng1On();

            }
            else
            {
                pmdg.HydEng1Off();
            }

        }

        private void chkEng2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEng2.Checked)
            {
                pmdg.HydEng2On();

            }
            else
            {
                pmdg.HydEng2Off();
            }

        }


    }
}
