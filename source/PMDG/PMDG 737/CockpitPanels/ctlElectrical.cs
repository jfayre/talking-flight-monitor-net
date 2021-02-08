using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSUIPC;
using DavyKager;
namespace tfm
{
    public partial class ctlElectrical : UserControl, iPanelsPage
    {
        pmdg pmdg = new pmdg();

        public ctlElectrical()
        {
            InitializeComponent();
            PMDGPanelUpdateEvent.PMDGPanelUpdate += onPMDGPanelUpdate;
        }

        private void onPMDGPanelUpdate(object sender, PMDGPanelUpdateEventArgs e)
        {

        }

        private void ctlElectrical_Load(object sender, EventArgs e)
        {
            tmrElectrical.Start();
        }


        public void SetDocking()
        {

        }




        private void btnIFE_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_IFE, Aircraft.ClkL);
        }


        private void btnDisconnectGen1_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_DISCONNECT_1_SWITCH, Aircraft.ClkL);
        }

        private void btnDisconnectGen2_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_DISCONNECT_2_SWITCH, Aircraft.ClkL);
        }





        private void btnBusTransfer_Click(object sender, EventArgs e)
        {

        }




        private void tmrElectrical_Tick(object sender, EventArgs e)
        {
            chkBattery.CheckedChanged -= chkBattery_CheckedChanged;
            if (Aircraft.pmdg737.ELEC_BatSelector.Value == 0 && chkBattery.Checked == true)
            {
                chkBattery.Checked = false;
            }
            if (Aircraft.pmdg737.ELEC_BatSelector.Value == 1 && chkBattery.Checked == false)
            {
                chkBattery.Checked = true;
            }
            chkBattery.CheckedChanged += chkBattery_CheckedChanged;
            if (Aircraft.pmdg737.ELEC_CabUtilSw.Value == 1)
            {
                chkCabUtil.Checked = true;
            }
            else
            {
                chkCabUtil.Checked = false;
            }
            if (Aircraft.pmdg737.ELEC_IFEPassSeatSw.Value == 1)
            {
                chkPassSeat.Checked = true;
            }
            else
            {
                chkPassSeat.Checked = false;
            }
            switch (Aircraft.pmdg737.ELEC_StandbyPowerSelector.Value)
            {
                case 0:
                    radStandbyBat.Checked = true;
                    break;
                case 1:
                    radStandbyOff.Checked = true;
                    break;
                case 2:
                    radStandbyAuto.Checked = true;
                    break;

            }
            // DC source switch
            switch (Aircraft.pmdg737.ELEC_DCMeterSelector.Value)
            {
                case 0:
                    radDCStandby.Checked = true;
                    break;
                case 1:
                    radDCBatBus.Checked = true;
                    break;
                case 2:
                    radDCBattery.Checked = true;
                    break;
                case 3:
                    radDCAuxBat.Checked = true;
                    break;
                case 4:
                    radDCTR1.Checked = true;
                    break;
                case 5:
                    radDCTR3.Checked = true;
                    break;
                case 6:
                    radDCTR3.Checked = true;
                    break;

            }
            // DC Meter display
            txtDCAmps.Text = Aircraft.pmdg737.ELEC_MeterDisplayTop.Value.Substring(0, 3);
            txtDCVolts.Text = Aircraft.pmdg737.ELEC_MeterDisplayBottom.Value.Substring(0, 3);
            // AC source switch
            switch (Aircraft.pmdg737.ELEC_ACMeterSelector.Value)
            {
                case 0:
                    radACStandby.Checked = true;
                    break;
                case 1:
                    radACGroundPower.Checked = true;
                    break;
                case 2:
                    radACGen1.Checked = true;
                    break;
                case 3:
                    radACAPUGen.Checked = true;
                    break;
                case 4:
                    radACGen2.Checked = true;
                    break;
                case 5:
                    radACInverter.Checked = true;
                    break;
                
            }

            txtACAmps.Text = Aircraft.pmdg737.ELEC_MeterDisplayBottom.Value.Substring(8, 4);
            txtACVolts.Text = Aircraft.pmdg737.ELEC_MeterDisplayBottom.Value.Substring(4, 4);
            // APU EGT
            txtAPUEGT.Text = Aircraft.pmdg737.APU_EGTNeedle.Value.ToString();
        }


        private void chkBattery_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBattery.Checked)
            {
                pmdg.ElecBatteryOn();

            }
            else
            {
                pmdg.ElecBatteryOff();
            }
        }

        private void chkCabUtil_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCabUtil.Checked)
            {
                pmdg.ElecCabUtilOn();
            }
            else
            {
                pmdg.ElecCabUtilOff();
            }
        }

        private void RadStandby_CheckChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "radStandbyBat":
                        pmdg.ElecStandbyBattery();
                        break;
                    case "radStandbyOff":
                        pmdg.ElecStandbyOff();
                        break;
                    case "radStandbyAuto":
                        pmdg.ElecStandbyAuto();
                        break;

                }
            }
        }

        private void btnGroundPowerOn_Click(object sender, EventArgs e)
        {
            pmdg.ElecGroundPowerOn();
        }

        private void btnGroundPowerOff_Click(object sender, EventArgs e)
        {
            pmdg.ElecGroundPowerOff();
        }

        private void btnAPU1On_Click(object sender, EventArgs e)
        {
            pmdg.ElecAPUGen1On();
        }

        private void btnAPU1Off_Click(object sender, EventArgs e)
        {
            pmdg.ElecAPUGen1Off();
        }

        private void btnAPU2On_Click(object sender, EventArgs e)
        {
            pmdg.ElecAPUGen2On();
        }

        private void btnAPU2Off_Click(object sender, EventArgs e)
        {
            pmdg.ElecAPUGen2Off();
        }

        private void btnGen1On_Click(object sender, EventArgs e)
        {
            pmdg.ElecGen1On();
        }

        private void btnGen1Off_Click(object sender, EventArgs e)
        {
            pmdg.ElecGen1Off();
        }

        private void btnGen2On_Click(object sender, EventArgs e)
        {
            pmdg.ElecGen2On();
        }

        private void btnGen2Off_Click(object sender, EventArgs e)
        {
            pmdg.ElecGen2Off();
        }

        // DC Source
        private void radDCSource_CheckChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "radDCStandby":
                        pmdg.ElecDCSource(0);
                        break;
                    case "radDCBatBus":
                        pmdg.ElecDCSource(1);
                        break;
                    case "radDCBattery":
                        pmdg.ElecDCSource(2);
                        break;
                    case "radDCAuxBat":
                        pmdg.ElecDCSource(3);
                        break;
                    case "radDCTR1":
                        pmdg.ElecDCSource(4);
                        break;
                    case "radDCTR2":
                        pmdg.ElecDCSource(5);
                        break;
                    case "radDCTR3":
                        pmdg.ElecDCSource(6);
                        break;


                }
            }
        }

        // AC Source
        private void radACSource_CheckChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "radACStandby":
                        pmdg.ElecACSource(0);
                        break;
                    case "radACGroundPower":
                        pmdg.ElecACSource(1);
                        break;
                    case "radACGen1":
                        pmdg.ElecACSource(2);
                        break;
                    case "radACAPUGen":
                        pmdg.ElecACSource(3);
                        break;
                    case "radACGen2":
                        pmdg.ElecACSource(4);
                        break;
                    case "radACInverter":
                        pmdg.ElecACSource(5);
                        break;
                    

                }
            }

        }

        private void btnAPUStart_Click(object sender, EventArgs e)
        {
            pmdg.ElecAPUStart();
        }

        private void btnAPUShutdown_Click(object sender, EventArgs e)
        {
            pmdg.ElecAPUShutdown();
        }
    }
}
 