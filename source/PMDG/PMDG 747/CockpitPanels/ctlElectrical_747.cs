using FSUIPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tfm
{
    public partial class ctlElectrical_747 : UserControl, iPanelsPage
    {
                private void PanelUpdateEvent(object Sender, PMDGPanelUpdateEventArgs eventArgs)
        {

        }
        public ctlElectrical_747()
        {
            InitializeComponent();
            PMDGPanelUpdateEvent.PMDGPanelUpdate += PanelUpdateEvent;
        } // End constructor.

        private void TimerTick(object Sender, EventArgs eventArgs)
        {
            batteryCheckBox.CheckedChanged -= batteryCheckBox_CheckedChanged;
            if (Aircraft.pmdg747.ELEC_Battery_Sw_ON.Value == 1 && batteryCheckBox.Checked == false)
            {
                batteryCheckBox.Checked = true;
                            }
            if(Aircraft.pmdg747.ELEC_Battery_Sw_ON.Value == 0 && batteryCheckBox.Checked == true)
            {
                batteryCheckBox.Checked = false;
                            } // End battery.
            batteryCheckBox.CheckedChanged += batteryCheckBox_CheckedChanged;
            utility1CheckBox.CheckedChanged -= utility1CheckBox_CheckedChanged;
            if (Aircraft.pmdg747.ELEC_UtilSw[0].Value == 1 && utility1CheckBox.Checked == false)
            {
                utility1CheckBox.Checked = true;
                            }
            if(Aircraft.pmdg747.ELEC_UtilSw[0].Value == 0 && utility1CheckBox.Checked == true)
            {
                utility1CheckBox.Checked = false;
            } // End utility 1
            utility1CheckBox.CheckedChanged += utility1CheckBox_CheckedChanged;

            utility2CheckBox.CheckedChanged -= utility2CheckBox_CheckedChanged;
if(Aircraft.pmdg747.ELEC_UtilSw[1].Value == 1 && utility2CheckBox.Checked == false)
            {
                utility2CheckBox.Checked = true;
            }
if(Aircraft.pmdg747.ELEC_UtilSw[1].Value == 0 && utility2CheckBox.Checked == true)
            {
                utility2CheckBox.Checked = false;
            } // End utility 2.
            utility2CheckBox.CheckedChanged += utility2CheckBox_CheckedChanged;

            if(Aircraft.pmdg747.ELEC_Gen_Sw_ON[0].Value == 0)
            {
                generator1Button.Text = "#1 [Off]";
                generator1Button.AccessibleName = "#1 [Off]";
            }
            if(Aircraft.pmdg747.ELEC_Gen_Sw_ON[0].Value == 1)
            {
                generator1Button.Text = "#1 [On]";
                generator1Button.AccessibleName = "#1 [On]";
            }

            if(Aircraft.pmdg747.ELEC_Gen_Sw_ON[1].Value == 0)
            {
                generator2Button.Text = "#2 [Off]";
                generator2Button.AccessibleName = "#2 [Off]";
            }
            if(Aircraft.pmdg747.ELEC_Gen_Sw_ON[1].Value == 1)
            {
                generator2Button.Text = "#2 [On]";
                generator2Button.AccessibleName = "#2 [On]";
            }

            if(Aircraft.pmdg747.ELEC_Gen_Sw_ON[2].Value == 0)
            {
                generator3Button.Text = "#3 [Off]";
                generator3Button.AccessibleName = "#3 [Off]";
            }
            if(Aircraft.pmdg747.ELEC_Gen_Sw_ON[2].Value == 1)
            {
                generator3Button.Text = "#3 [On]";
                generator3Button.AccessibleName = "#3 [On]";
            }

            if(Aircraft.pmdg747.ELEC_Gen_Sw_ON[3].Value == 0)
            {
                generator4Button.Text = "#4 [Off]";
                generator4Button.AccessibleName = "#4 [Off]";
            }
            if(Aircraft.pmdg747.ELEC_Gen_Sw_ON[3].Value == 1)
            {
                generator4Button.Text = "#4 [On]";
                generator4Button.AccessibleName = "#4 [On]";
            }

            if(Aircraft.pmdg747.ELEC_BusTie_Sw_AUTO[0].Value == 0)
            {
                busTie1Button.Text = "#1 [Off]";
                busTie1Button.AccessibleName = "#1 [Off]";
            }
            if(Aircraft.pmdg747.ELEC_BusTie_Sw_AUTO[0].Value == 1)
            {
                busTie1Button.Text = "#1 [Auto]";
                busTie1Button.AccessibleName = "#1 [Auto]";
            }
            if(Aircraft.pmdg747.ELEC_BusTie_Sw_AUTO[1].Value == 0)
            {
                busTie2Button.Text = "#2 [Off]";
                busTie2Button.AccessibleName = "#2 [Off]";
            }
            if(Aircraft.pmdg747.ELEC_BusTie_Sw_AUTO[1].Value == 1)
            {
                busTie2Button.Text = "#2 [Auto]";
                busTie2Button.AccessibleName = "#2 [Auto]";
            }
            if(Aircraft.pmdg747.ELEC_BusTie_Sw_AUTO[2].Value == 0)
            {
                busTie3Button.Text = "#3 [Off]";
                busTie3Button.AccessibleName = "#3 [Off]";
            }
            if(Aircraft.pmdg747.ELEC_BusTie_Sw_AUTO[2].Value == 1)
            {
                busTie3Button.Text = "#3 [Auto]";
                busTie3Button.AccessibleName = "#3 [Auto]";
            }
            if(Aircraft.pmdg747.ELEC_BusTie_Sw_AUTO[3].Value == 0)
            {
                busTie4Button.Text = "#4 [Off]";
                busTie4Button.AccessibleName = "#4 [Off]";
            }
            if(Aircraft.pmdg747.ELEC_BusTie_Sw_AUTO[3].Value == 1)
            {
                busTie4Button.Text = "#4 [Auto]";
                busTie4Button.AccessibleName = "#4 [Auto]";
            }

            if(Aircraft.pmdg747.ELEC_IDGDiscSw[0].Value == 0)
            {
                idgDiscon1Button.Text = "#1 [Off]";
                idgDiscon1Button.AccessibleName = "#1 [Off]";
            }
            if(Aircraft.pmdg747.ELEC_IDGDiscSw[0].Value == 1)
            {
                idgDiscon1Button.Text = "#1 [On]";
                idgDiscon1Button.AccessibleName = "#1 [On]";
            }
            if(Aircraft.pmdg747.ELEC_IDGDiscSw[1].Value == 0)
            {
                idgDiscon2Button.Text = "#2 [Off]";
                idgDiscon2Button.AccessibleName = "#2 [Off]";
            }
            if(Aircraft.pmdg747.ELEC_IDGDiscSw[1].Value == 1)
            {
                idgDiscon2Button.Text = "#2 [On]";
                idgDiscon2Button.AccessibleName = "#2 [On]";
            }
            if(Aircraft.pmdg747.ELEC_IDGDiscSw[2].Value == 0)
            {
                idgDiscon3Button.Text = "#3 [Off]";
                idgDiscon3Button.AccessibleName = "#3 [Off]";
            }
            if(Aircraft.pmdg747.ELEC_IDGDiscSw[2].Value == 1)
            {
                idgDiscon3Button.Text = "#3 [On]";
                idgDiscon3Button.AccessibleName = "#3 [On]";
            }
            if(Aircraft.pmdg747.ELEC_IDGDiscSw[3].Value == 0)
            {
                idgDiscon4Button.Text = "#4 [Off]";
                idgDiscon4Button.AccessibleName = "#4 [Off]";
            }
            if(Aircraft.pmdg747.ELEC_IDGDiscSw[3].Value == 1)
            {
                idgDiscon4Button.Text = "#4 [On]";
                idgDiscon4Button.AccessibleName = "#4 [On]";
            }

            if(Aircraft.pmdg747.ELEC_ExtPwrSw[0].Value == 0)
            {
                extPwr1Button.Text = "#1 [Off]";
                extPwr1Button.AccessibleName = "#1 [Off]";
            }
            if(Aircraft.pmdg747.ELEC_ExtPwrSw[0].Value == 1)
            {
                extPwr1Button.Text = "#1 [On]";
                extPwr1Button.AccessibleName = "#1 [On]";
            }
            if(Aircraft.pmdg747.ELEC_ExtPwrSw[1].Value == 0)
            {
                extPwr2Button.Text = "#2 [Off]";
                extPwr2Button.AccessibleName = "#2 [Off]";
            }
            if(Aircraft.pmdg747.ELEC_ExtPwrSw[1].Value == 1)
            {
                extPwr2Button.Text = "#2 [On]";
                extPwr2Button.AccessibleName = "#2 [On]";
            }
                                                                                            } // End TimerTick.

                                                                        public void SetDocking()
        {
                    } // End SetDocking.

        private void ctlElectrical_747_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                                     timer.Tick += new EventHandler(TimerTick);
             timer.Start();
                    } // End FormLoad.

        private void batteryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(batteryCheckBox.Checked)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_BATTERY_GUARD, Aircraft.ClkR);
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_BATTERY_SWITCH, Aircraft.ClkR);
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_BATTERY_GUARD, Aircraft.ClkL);
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_BATTERY_GUARD, Aircraft.ClkR);
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_BATTERY_SWITCH, Aircraft.ClkL);
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_BATTERY_GUARD, Aircraft.ClkL);
            }
        } // End batteryCheckBox_CheckedChanged

                private void utility1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (utility1CheckBox.Checked)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_L_UTIL, Aircraft.ClkL);
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_L_UTIL, Aircraft.ClkR);
            }
        } // End utility1CheckBox_CheckChanged.

        private void utility2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (utility2CheckBox.Checked)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_R_UTIL, Aircraft.ClkL);
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_R_UTIL, Aircraft.ClkR);
            }
        } // End utility2CheckBox_CheckChanged.

                                        private void shutdownAPUButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_APU_SEL_SWITCH, Aircraft.ClkL);
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_APU_SEL_SWITCH, Aircraft.ClkL);
        }

        private void startApuButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_APU_SEL_SWITCH, Aircraft.ClkR);
            Thread.Sleep(250);
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_APU_SEL_SWITCH, Aircraft.ClkR);
        }

        private void apuOnButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_APU_SEL_SWITCH, Aircraft.ClkR);
        }

        private void apuGen1OnButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_APU_GEN1_SWITCH, Aircraft.ClkL);
        }

        private void apuGen1OffButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_APU_GEN1_SWITCH, Aircraft.ClkR);
        }

        private void apuGen2OnButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_APU_GEN2_SWITCH, Aircraft.ClkL);
        }

        private void apuGen2OffButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_APU_GEN2_SWITCH, Aircraft.ClkR);        
        }

                private void decStndByPwrModeButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_STBY_PWR_SWITCH, Aircraft.ClkL);
        }

        private void incStndByPwrModeButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_STBY_PWR_SWITCH, Aircraft.ClkR);
        }

        private void busTie1Button_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.ELEC_BusTie_Sw_AUTO[0].Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_BUS_TIE1_SWITCH, Aircraft.ClkL);
                busTie1Button.AccessibleName = "#1 [Auto]";
                busTie1Button.Text = "#1 [Auto]";
                            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_BUS_TIE1_SWITCH, Aircraft.ClkR);
                busTie1Button.Text = "#1 [Off]";
                busTie1Button.AccessibleName = "#1 [Off]";
                            }
        }

        private void busTie2Button_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.ELEC_BusTie_Sw_AUTO[1].Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_BUS_TIE2_SWITCH, Aircraft.ClkL);
                busTie2Button.Text = "#2 [Auto]";
                busTie2Button.AccessibleName = "#2 [Auto]";
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_BUS_TIE2_SWITCH, Aircraft.ClkR);
                busTie2Button.Text = "#2 [Off]";
                busTie2Button.AccessibleName = "#2 [Off]";
            }
        }

        private void busTie3Button_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.ELEC_BusTie_Sw_AUTO[2].Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_BUS_TIE3_SWITCH, Aircraft.ClkL);
                busTie3Button.Text = "#3 [Auto]";
                busTie3Button.AccessibleName = "#3 [Auto]";
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_BUS_TIE3_SWITCH, Aircraft.ClkR);
                busTie3Button.Text = "#3 [Off]";
                busTie3Button.AccessibleName = "#3 [Off]";
            }
        }

        private void busTie4Button_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.ELEC_BusTie_Sw_AUTO[3].Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_BUS_TIE4_SWITCH, Aircraft.ClkL);
                busTie4Button.Text = "#4 [Auto]";
                busTie4Button.AccessibleName = "#4 [Auto]";
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_BUS_TIE4_SWITCH, Aircraft.ClkR);
                busTie4Button.Text = "#4 [Off]";
                busTie4Button.AccessibleName = "#4 [Off]";
            }   
        }

        private void generator1Button_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.ELEC_Gen_Sw_ON[0].Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_GEN1_SWITCH, Aircraft.ClkL);
                generator1Button.Text = "#1 [On]";
                generator1Button.AccessibleName = "#1 [On]";
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_GEN1_SWITCH, Aircraft.ClkR);
                generator1Button.Text = "#1 [Off]";
                generator1Button.AccessibleName = "#1 [Off]";
            }
        }

        private void generator2Button_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.ELEC_Gen_Sw_ON[1].Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_GEN2_SWITCH, Aircraft.ClkL);
                generator2Button.Text = "#2 [On]";
                generator2Button.AccessibleName = "#2 [On]";
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_GEN2_SWITCH, Aircraft.ClkR);
                generator2Button.Text = "#2 [Off]";
                generator2Button.AccessibleName = "#2 [Off]";
                    }
        }

        private void generator3Button_Click(object sender, EventArgs e)
        {
            if (Aircraft.pmdg747.ELEC_Gen_Sw_ON[2].Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_GEN2_SWITCH, Aircraft.ClkL);
                generator2Button.Text = "#3 [On]";
                generator2Button.AccessibleName = "#3 [On]";
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_GEN2_SWITCH, Aircraft.ClkR);
                generator2Button.Text = "#3 [Off]";
                generator2Button.AccessibleName = "#3 [Off]";
            }
        }

        private void generator4Button_Click(object sender, EventArgs e)
        {
            if (Aircraft.pmdg747.ELEC_Gen_Sw_ON[3].Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_GEN2_SWITCH, Aircraft.ClkL);
                generator2Button.Text = "#4 [On]";
                generator2Button.AccessibleName = "#4 [On]";
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_GEN2_SWITCH, Aircraft.ClkR);
                generator2Button.Text = "#4 [Off]";
                generator2Button.AccessibleName = "#4 [Off]";
            }
        }

        private void idgDiscon1Button_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.ELEC_IDGDiscSw[0].Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT1_GUARD, Aircraft.ClkL);
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT1_SWITCH, Aircraft.ClkL);
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT1_GUARD, Aircraft.ClkR);
                idgDiscon1Button.Text = "#1 [On]";
                idgDiscon1Button.AccessibleName = "#1 [On]";
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT1_GUARD, Aircraft.ClkL);
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT1_SWITCH, Aircraft.ClkR);
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT1_GUARD, Aircraft.ClkR);
                idgDiscon1Button.Text = "#1 [Off]";
                idgDiscon1Button.AccessibleName = "#1 [Off]";
            }
        }

        private void idgDiscon2Button_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.ELEC_IDGDiscSw[1].Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT2_GUARD, Aircraft.ClkL);
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT2_SWITCH, Aircraft.ClkL);
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT2_GUARD, Aircraft.ClkR);
                idgDiscon2Button.Text = "#2 [On]";
                idgDiscon2Button.AccessibleName = "#2 [On]";
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT2_GUARD, Aircraft.ClkL);
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT2_SWITCH, Aircraft.ClkR);
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT2_GUARD, Aircraft.ClkR);
                idgDiscon2Button.Text = "#2 [Off]";
                idgDiscon2Button.AccessibleName = "#2 [Off]";
            }
        }

        private void idgDiscon3Button_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.ELEC_IDGDiscSw[2].Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT3_GUARD, Aircraft.ClkL);
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT3_SWITCH, Aircraft.ClkL);
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT3_GUARD, Aircraft.ClkR);
                idgDiscon3Button.Text = "#3 [On]";
                idgDiscon3Button.AccessibleName = "#3 [On]";
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT3_GUARD, Aircraft.ClkL);
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT3_SWITCH, Aircraft.ClkR);
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT3_GUARD, Aircraft.ClkR);
                idgDiscon3Button.Text = "#3 [Off]";
                idgDiscon3Button.AccessibleName = "#3 [Off]";
            }
        }

        private void idgDiscon4Button_Click(object sender, EventArgs e)
        {
if(Aircraft.pmdg747.ELEC_IDGDiscSw[3].Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT4_GUARD, Aircraft.ClkL);
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT4_SWITCH, Aircraft.ClkL);
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT4_GUARD, Aircraft.ClkR);
                idgDiscon4Button.Text = "#4 [On]";
                idgDiscon4Button.AccessibleName = "#4 [On]";
            }
else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT4_GUARD, Aircraft.ClkL);
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT4_SWITCH, Aircraft.ClkR);
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_DISCONNECT4_GUARD, Aircraft.ClkR);
                idgDiscon4Button.Text = "#4 [Off]";
                idgDiscon4Button.AccessibleName = "#4 [Off]";
            }
        }

        private void extPwr1Button_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.ELEC_ExtPwrSw[0].Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_EXT_PWR1_SWITCH, Aircraft.ClkL);
                extPwr1Button.Text = "#1 [On]";
                extPwr1Button.AccessibleName = "#1 [On]";
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_EXT_PWR1_SWITCH, Aircraft.ClkR);
                extPwr1Button.Text = "#1 [Off]";
                extPwr1Button.AccessibleName = "#1 [Off]";
            }
        }

        private void extPwr2Button_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.ELEC_ExtPwrSw[1].Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_EXT_PWR2_SWITCH, Aircraft.ClkL);
                extPwr2Button.Text = "#2 [On]";
                extPwr2Button.AccessibleName = "#2 [On]";
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_EXT_PWR2_SWITCH, Aircraft.ClkR);
                extPwr2Button.Text = "#2 [Off]";
                extPwr2Button.AccessibleName = "#2 [Off]";
            }
        }
    } // End form.
} // End namespace.
