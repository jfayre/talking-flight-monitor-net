using FSUIPC;
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
    public partial class ctlAntiIce : UserControl, iPanelsPage
    {
        pmdg pmdg = new pmdg();
        public ctlAntiIce()
        {
            InitializeComponent();
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


        private void chkLeftSide_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLeftSide.Checked)
            {
                pmdg.WindowHeatLeftSideOn();
            }
            else
            {
                pmdg.WindowHeatLeftSideOff();
            }

        }

        private void chkLeftForward_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLeftForward.Checked)
            {
                pmdg.WindowHeatLeftForwardOn();
            }
            else
            {
                pmdg.WindowHeatLeftForwardOff();
            }

        }

        private void chkRightForward_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRightForward.Checked)
            {
                pmdg.WindowHeatRightForwardOn();
            }
            else
            {
                pmdg.WindowHeatRightForwardOff();
            }

        }

        private void chkRightSide_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRightSide.Checked)
            {
                pmdg.WindowHeatRightSideOn();
            }
            else
            {
                pmdg.WindowHeatRightSideOff();
            }

        }

        private void chkProbeHeatLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProbeHeatLeft.Checked)
            {
                pmdg.ProbeHeatLeftOn();
            }
            else
            {
                pmdg.ProbeHeatLeftOff();
            }

        }

        private void chkProbeHeatRight_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProbeHeatRight.Checked)
            {
                pmdg.ProbeHeatRightOn();
            }
            else
            {
                pmdg.ProbeHeatRightOff();
            }

        }

        public void SetDocking()
        {
            
        }

        private void tmrAntiIce_Tick(object sender, EventArgs e)
        {
            Aircraft.pmdg737.RefreshData();
            UpdateToggleControl(Aircraft.pmdg737.ICE_WindowHeatSw[0].Value > 0, chkLeftSide);
            UpdateToggleControl(Aircraft.pmdg737.ICE_WindowHeatSw[1].Value > 0, chkLeftForward);
            UpdateToggleControl(Aircraft.pmdg737.ICE_WindowHeatSw[2].Value > 0, chkRightForward);
            UpdateToggleControl(Aircraft.pmdg737.ICE_WindowHeatSw[3].Value > 0, chkRightSide);
            // the .net library is missing the offsets for the probe heat switches, so we need to get these using l:vars
            UpdateToggleControl(FSUIPCConnection.ReadLVar("switch_140_73X") == 100, chkProbeHeatLeft);
            UpdateToggleControl(FSUIPCConnection.ReadLVar("switch_141_73X") == 100, chkProbeHeatRight);
            UpdateToggleControl(Aircraft.pmdg737.ICE_WingAntiIceSw.Value > 0, chkWingAntiIce);
            UpdateToggleControl(Aircraft.pmdg737.ICE_EngAntiIceSw[0].Value > 0, chkEng1AntiIce);
            UpdateToggleControl(Aircraft.pmdg737.ICE_EngAntiIceSw[1].Value > 0, chkEng2AntiIce);

        }   

        private void ctlAntiIce_Load(object sender, EventArgs e)
        {
            tmrAntiIce.Start();
        }

        private void chkWingAntiIce_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWingAntiIce.Checked)
            {
                pmdg.WingAntiIceOn();
            }
            else
            {
                pmdg.WingAntiIceOff();
            }
        }

        private void chkEng1AntiIce_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEng1AntiIce.Checked)
            {
                pmdg.Engine1AntiIceOn();
            }
            else
            {
                pmdg.Engine1AntiIceOff();
            }

        }

        private void chkEng2AntiIce_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEng2AntiIce.Checked)
            {
                pmdg.Engine2AntiIceOn();
            }
            else
            {
                pmdg.Engine2AntiIceOff();
            }

        }
    }
}
