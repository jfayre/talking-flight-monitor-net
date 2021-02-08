using FSUIPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tfm
{
    public partial class ctlFuel : UserControl, iPanelsPage
    {
        pmdg pmdg = new pmdg();
        public ctlFuel()
        {
            InitializeComponent();
            tmrFuel.Start();
        }
        
        
        public void SetDocking()
        {
        }

        private void UpdateToggleControl (bool toggleStateOn, CheckBox ctrl)
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

        private void tmrFuel_Tick(object sender, EventArgs e)
        {
            UpdateToggleControl(Aircraft.pmdg737.FUEL_PumpAftSw[0].Value > 0, chkAftLeft);
            UpdateToggleControl(Aircraft.pmdg737.FUEL_PumpFwdSw[0].Value > 0, chkFwdLeft);
            UpdateToggleControl(Aircraft.pmdg737.FUEL_PumpFwdSw[1].Value > 0, chkFwdRight);
            UpdateToggleControl(Aircraft.pmdg737.FUEL_PumpAftSw[1].Value > 0, chkAftRight);
            UpdateToggleControl(Aircraft.pmdg737.FUEL_PumpCtrSw[0].Value > 0, chkCenterLeft);
            UpdateToggleControl(Aircraft.pmdg737.FUEL_PumpCtrSw[1].Value > 0, chkCenterRight);
        }

        private void chkFwdLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFwdLeft.Checked)
            {
                pmdg.FuelFwdLeftOn();
            }
            else
            {
                pmdg.FuelFwdLeftOff();
            }

        }

        private void chkAftLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAftLeft.Checked)
            {
                pmdg.FuelAftLeftOn();
            }
            else
            {
                pmdg.FuelAftLeftOff();
            }

        }

        private void chkFwdRight_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFwdRight.Checked)
            {
                pmdg.FuelFwdRightOn();
            }
            else
            {
                pmdg.FuelFwdRightOff();
            }

        }

        private void chkAftRight_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAftRight.Checked)
            {
                pmdg.FuelAftRightOn();
            }
            else
            {
                pmdg.FuelAftRightOff();
            }

        }

        private void chkCenterLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCenterLeft.Checked)
            {
                pmdg.FuelCtrLeftOn();
            }
            else
            {
                pmdg.FuelCtrLeftOff();
            }

        }

        private void chkCenterRight_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCenterRight.Checked)
            {
                pmdg.FuelCtrRightOn();
            }
            else
            {
                pmdg.FuelCtrRightOff();
            }

        }

        private void btnAllOn_Click(object sender, EventArgs e)
        {
            // turn on all fuel pumps
            pmdg.FuelFwdLeftOn();
            Thread.Sleep(250);
            pmdg.FuelAftLeftOn();
            Thread.Sleep(250);
            pmdg.FuelFwdRightOn();
            Thread.Sleep(250);
            pmdg.FuelAftRightOn();
            Thread.Sleep(250);
            pmdg.FuelCtrLeftOn();
            Thread.Sleep(250);
            pmdg.FuelCtrRightOn();
        }

        private void btnAllOff_Click(object sender, EventArgs e)
        {
            // turn off all fuel pumps
            pmdg.FuelFwdLeftOff();
            Thread.Sleep(250);
            pmdg.FuelAftLeftOff();
            Thread.Sleep(250);
            pmdg.FuelFwdRightOff();
            Thread.Sleep(250);
            pmdg.FuelAftRightOff();
            Thread.Sleep(250);
            pmdg.FuelCtrLeftOff();
            Thread.Sleep(250);
            pmdg.FuelCtrRightOff();
        }
    }
}   
