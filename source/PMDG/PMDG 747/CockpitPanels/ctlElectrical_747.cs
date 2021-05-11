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

            apuGenerator1CheckBox.CheckedChanged -= apuGenerator1CheckBox_CheckedChanged;
            if(Aircraft.pmdg747.ELEC_APUGen_Sw_ON[0].Value == 0 && apuGenerator1CheckBox.Checked == false)
            {
                apuGenerator1CheckBox.Checked = true;
            }
            if(Aircraft.pmdg747.ELEC_APUGen_Sw_ON[0].Value == 1 && apuGenerator1CheckBox.Checked == true)
            {
                apuGenerator1CheckBox.Checked = false;
            }
            apuGenerator1CheckBox.CheckedChanged += apuGenerator1CheckBox_CheckedChanged;


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
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_APU_SEL_SWITCH, Aircraft.ClkR);
        }

        private void apuOnButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_APU_SEL_SWITCH, Aircraft.ClkR);
        }

        private void apuGenerator1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(apuGenerator1CheckBox.Checked)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_APU_GEN1_SWITCH, Aircraft.ClkL);
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_APU_GEN1_SWITCH, Aircraft.ClkR);
            }
        }

                private void apuGenerator2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(apuGenerator2CheckBox.Checked)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_APU_GEN2_SWITCH, Aircraft.ClkL);
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_OH_ELEC_APU_GEN2_SWITCH, Aircraft.ClkR);
            }
        }
    } // End form.
} // End namespace.
