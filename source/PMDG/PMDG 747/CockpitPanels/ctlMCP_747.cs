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
    public partial class ctlMCP_747 : UserControl, iPanelsPage
    {

                public ctlMCP_747()
                    {
            InitializeComponent();
                } // End constructor.

        public void SetDocking()
        {
                    } // End SetDocking.

        private void TimerTick(object Sender, EventArgs eventArgs)
        {
                        // Speed.
            if(Aircraft.pmdg747.MCP_IASMach.ValueChanged)
            {
                speedTextBox.Text = Aircraft.pmdg747.MCP_IASMach.Value.ToString();
            } // End speed box.

            // Altitude box.
            if(Aircraft.pmdg747.MCP_Altitude.ValueChanged)
            {
                altitudeTextBox.Text = Aircraft.pmdg747.MCP_Altitude.Value.ToString();
            } // End altitude box
            
            // Heading.
            if(Aircraft.pmdg747.MCP_Heading.ValueChanged)
            {
                headingTextBox.Text = Aircraft.pmdg747.MCP_Heading.Value.ToString();
            } // End heading.

            // Vertical speed.
            if(Aircraft.pmdg747.MCP_VertSpeed.ValueChanged)
            {
                verticalSpeedTextBox.Text = Aircraft.pmdg747.MCP_VertSpeed.Value.ToString();
            } // End vertical speed.

                        if(Aircraft.pmdg747.MCP_ATArm_Sw_On.Value == 0)
            {
                autoThrottleButton.Text = "Autothrottle [Off]";
                autoThrottleButton.AccessibleName = "Autothrottle [Off]";
                            }
            else
            {
                autoThrottleButton.Text = "Autothrottle [Armed]";
                autoThrottleButton.AccessibleName = "Autothrottle [Armed]";
            } // End Autothrottle.

                        if(Aircraft.pmdg747.MCP_FD_Sw_On[0].Value == 0)
            {
                fdlButton.Text = "FD/L [Off]";
                fdlButton.AccessibleName = "FD/L [Off]";
            }
                        else
            {
                fdlButton.Text = "FD/L [On]";
                fdlButton.AccessibleName = "FD/L [On]";
            } // End FD/L.

                        if(Aircraft.pmdg747.MCP_FD_Sw_On[1].Value == 0)
            {
                fdrButton.Text = "FD/R [Off]";
                fdrButton.AccessibleName = "FD/R [Off]";
            }
                        else
            {
                fdrButton.Text = "FD/R [On]";
                fdrButton.AccessibleName = "FD/R [On]";
            } // End FD/R.

                        if(Aircraft.pmdg747.MCP_BankLimitSel.Value == 0)
            {
                bankLimitButton.Text = "Bank limiter [Off]";
                bankLimitButton.AccessibleName = "Bank limiter [Off]";
            }
                        else
            {
                bankLimitButton.Text = "Bank limiter [On]";
                bankLimitButton.AccessibleName = "Bank limiter [On]";
            } // End Bank limiter.

                        if(Aircraft.pmdg747.MCP_DisengageBar.Value == 0)
            {
                disBarButton.Text = "Disengage baro [Off]";
                disBarButton.AccessibleName = "Disengage baro [Off]";
            }
                        else
            {
                disBarButton.Text = "Disengage baro [On]";
                disBarButton.AccessibleName = "Disengage baro [On]";
            } // End disengage baro.

                        if(Aircraft.pmdg747.MCP_AP_Sw_Pushed[0].Value == 0)
            {
                apLButton.Text = "AP/L [Off]";
                apLButton.AccessibleName = "AP/L [Off]";
                            }
                        else
            {
                apLButton.Text = "AP/L [On]";
                apLButton.AccessibleName = "AP/L [On]";
            } // End AP/L.

                        if(Aircraft.pmdg747.MCP_AP_Sw_Pushed[1].Value == 0)
            {
                apCButton.Text = "AP/C [Off]";
                apCButton.AccessibleName = "AP/C [Off]";
            }
                        else
            {
                apCButton.Text = "AP/C [On]";
                apCButton.AccessibleName = "AP/C [On]";
            } // End AP/C.

                        if(Aircraft.pmdg747.MCP_AP_Sw_Pushed[2].Value == 0)
            {
                apRButton.Text = "AP/R [Off]";
                apRButton.AccessibleName = "AP/R [Off]";
            }
            else
            {
                apRButton.Text = "AP/R [On]";
                apRButton.AccessibleName = "AP/R [On]";
            } // End AP/R

            if(Aircraft.pmdg747.MCP_annunLNAV.Value == 0)
            {
                lNavButton.Text = "L NAV [Off]";
                lNavButton.AccessibleName = "L NAV [Off]";
            }
            else
            {
                lNavButton.Text = "L NAV [On]";
                lNavButton.AccessibleName = "L NAV [On]";
            } // End L NAV.

            if(Aircraft.pmdg747.MCP_annunVNAV.Value == 0)
            {
                vNavButton.Text = "V NAV [Off]";
                vNavButton.AccessibleName = "V NAV [Off]";
            }
            else
            {
                vNavButton.Text = "V NAV [On]";
                vNavButton.AccessibleName = "V NAV [On]";
            } // End V NAV.

            if(Aircraft.pmdg747.MCP_LOC_Sw_Pushed.Value == 0)
            {
                locHoldButton.Text = "LOcalizer hold [Off]";
                locHoldButton.AccessibleName = "Localizer hold [Off]";
            }
            else
            {
                locHoldButton.Text = "Localizer hold [On]";
                locHoldButton.AccessibleName = "Localizer hold [On]";
            } // End Loc hold.

            if(Aircraft.pmdg747.MCP_APP_Sw_Pushed.Value == 0)
            {
                apprButton.Text = "Approach [Off]";
                apprButton.AccessibleName = "Approach [Off]";
            }
            else
            {
                apprButton.Text = "Approach [On]";
                apprButton.AccessibleName = "Approach [On]";
            }
                        
            MonitorLights();
        } // End timerTick.

        private void ctlMCP_747_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();

            InstallLights();
            panelLightsListBox.SelectedIndex = 0;

            // Set initial values when the form loads. The timer tick event handles refreshes.
            speedTextBox.Text = Aircraft.pmdg747.MCP_IASMach.Value.ToString();
            altitudeTextBox.Text = Aircraft.pmdg747.MCP_Altitude.Value.ToString();
            headingTextBox.Text = Aircraft.pmdg747.MCP_Heading.Value.ToString();
            verticalSpeedTextBox.Text = Aircraft.pmdg747.MCP_VertSpeed.Value.ToString();        
        } // End form_load.

        // Sets up the lights on first load of the form.
        private void InstallLights()
        {

                                    // Autopilot left side.
            if (Aircraft.pmdg747.MCP_annunAP[0].Value == 0)
            {
                panelLightsListBox.Items.Add("AP/L: Off");
            }
            else
            {
                panelLightsListBox.Items.Add("AP/L: On");
            } // End AP/L.

// Autopilot center
            if(Aircraft.pmdg747.MCP_annunAP[1].Value == 0)
            {
                panelLightsListBox.Items.Add("AP/C: Off");
            }
            else
            {
                panelLightsListBox.Items.Add("AP/C: On");
            } // End AP/C.

            // Autopilot right side.
            if(Aircraft.pmdg747.MCP_annunAP[2].Value == 0)
            {
                panelLightsListBox.Items.Add("AP/R: Off");
            }
            else
            {
                panelLightsListBox.Items.Add("AP/R: On");
            } // End AP/R.
            
            // Thrust.
            if(Aircraft.pmdg747.MCP_annunTHR.Value == 0)
            {
                panelLightsListBox.Items.Add("THR: Off");
            }
            else
            {
                panelLightsListBox.Items.Add("THR: On");
            } // End THR.

            // SPD.
            if(Aircraft.pmdg747.MCP_annunSPD.Value == 0)
            {
                panelLightsListBox.Items.Add("SPD: Off");
            }
            else
            {
                panelLightsListBox.Items.Add("SPD: On");
            } // End SPD.

            // LNav.
            if(Aircraft.pmdg747.MCP_annunLNAV.Value == 0)
            {
                panelLightsListBox.Items.Add("L NAV: Off");
            }
            else
            {
                panelLightsListBox.Items.Add("L NAV: On");
            } // End LNav.

            // VNAV.
            if(Aircraft.pmdg747.MCP_annunVNAV.Value == 0)
            {
                panelLightsListBox.Items.Add("V NAV: Off");
            }
            else
            {
                panelLightsListBox.Items.Add("V NAV: On");
            } // End VNav.

            // Flight change.
            if(Aircraft.pmdg747.MCP_annunFLCH.Value == 0)
            {
                panelLightsListBox.Items.Add("FLCH: Off");
            }
            else
            {
                panelLightsListBox.Items.Add("FLCH: On");
            } // End FLCH.

            // Heading hold.
            if(Aircraft.pmdg747.MCP_annunHDG_HOLD.Value == 0)
            {
                panelLightsListBox.Items.Add("HDG HOLD: Off");
            }
            else
            {
                panelLightsListBox.Items.Add("HDG HOLD: On");
            } // End HDG HOLD.

            // Vertical Speed mode.
            if(Aircraft.pmdg747.MCP_annunVS.Value == 0)
            {
                panelLightsListBox.Items.Add("VS: Off");
            }
            else
            {
                panelLightsListBox.Items.Add("VS: On");
            } // End VS mode.

            // Altitude hold.
            if(Aircraft.pmdg747.MCP_annunALT_HOLD.Value == 0)
            {
                panelLightsListBox.Items.Add("ALT HOLD: Off");
            }
            else
            {
                panelLightsListBox.Items.Add("ALT HOLD: On");
            } // End ALT HOLD.

            // Localizer hold.
            if(Aircraft.pmdg747.MCP_annunLOC.Value == 0)
            {
                panelLightsListBox.Items.Add("LOC: Off");
            }
            else
            {
                panelLightsListBox.Items.Add("LOC: On");
            } // End LOC.

            // Approach mode.
            if(Aircraft.pmdg747.MCP_annunAPP.Value == 0)
            {
                panelLightsListBox.Items.Add("APPR: Off");
            }
            else
            {
                panelLightsListBox.Items.Add("APPR: On");
            } // End APPR
        } // End InstallLights.

        private void MonitorLights()
        {
            // Autopilot left side. index 0.
            if (Aircraft.pmdg747.MCP_annunAP[0].ValueChanged)
            {
                switch(Aircraft.pmdg747.MCP_annunAP[0].Value)
                {
                    case 0:
                        panelLightsListBox.Items[0] = "AP/L: Off";
                        break;
                    case 1:
                        panelLightsListBox.Items[0] = "AP/L: On";
                        break;
                }
            } // End AP/L.

            // Autopilot center. index 1
            if (Aircraft.pmdg747.MCP_annunAP[1].ValueChanged)
            {
                switch(Aircraft.pmdg747.MCP_annunAP[1].Value)
                {
                    case 0:
                        panelLightsListBox.Items[1] = "AP/C: Off";
                        break;
                    case 1:
                        panelLightsListBox.Items[1] = "AP/C: On";
                        break;
                }
            } // End AP/C.

            // Autopilot right side. index 2
            if (Aircraft.pmdg747.MCP_annunAP[2].ValueChanged)
            {
                switch(Aircraft.pmdg747.MCP_annunAP[2].Value)
                {
                    case 0:
                        panelLightsListBox.Items[2] = "AP/R: Off";
                        break;
                    case 1:
                        panelLightsListBox.Items[2] = "AP/R: On";
                        break;
                }
            } // End AP/R.

            // Thrust. index 3.
            if (Aircraft.pmdg747.MCP_annunTHR.ValueChanged)
            {
                switch(Aircraft.pmdg747.MCP_annunTHR.Value)
                {
                    case 0:
                        panelLightsListBox.Items[3] = "THR: Off";
                        break;
                    case 1:
                        panelLightsListBox.Items[3] = "THR: On";
                        break;
                }
            } // End THR.

            // SPD. index 4.
            if (Aircraft.pmdg747.MCP_annunSPD.ValueChanged)
            {
                switch(Aircraft.pmdg747.MCP_annunSPD.Value)
                {
                    case 0:
                        panelLightsListBox.Items[4] = "SPD: Off";
                        break;
                    case 1:
                        panelLightsListBox.Items[4] = "SPD: On";
                        break;
                }
            } // End SPD.

            // LNav. index 5.
            if (Aircraft.pmdg747.MCP_annunLNAV.ValueChanged)
            {
                switch(Aircraft.pmdg747.MCP_annunLNAV.Value)
                {
                    case 0:
                        panelLightsListBox.Items[5] = "L NAV: Off";
                        break;
                    case 1:
                        panelLightsListBox.Items[5] = "L NAV: On";
                        break;
                }
            } // End LNav.

            // VNAV. index 6.
            if (Aircraft.pmdg747.MCP_annunVNAV.ValueChanged)
            {
                switch(Aircraft.pmdg747.MCP_annunVNAV.Value)
                {
                    case 0:
                        panelLightsListBox.Items[6] = "V NAV: Off";
                        break;
                    case 1:
                        panelLightsListBox.Items[6] = "V NAV: On";
                        break;
                }
            } // End VNav.

            // Flight change. index 7
            if (Aircraft.pmdg747.MCP_annunFLCH.ValueChanged)
            {
                switch(Aircraft.pmdg747.MCP_annunFLCH.Value)
                {
                    case 0:
                        panelLightsListBox.Items[7] = "FLCH: Off";
                        break;
                    case 1:
                        panelLightsListBox.Items[7] = "FLCH: On";
                        break;
                }
            } // End FLCH.

            // Heading hold. index 8.
            if (Aircraft.pmdg747.MCP_annunHDG_HOLD.ValueChanged)
            {
                switch(Aircraft.pmdg747.MCP_annunHDG_HOLD.Value)
                {
                    case 0:
                        panelLightsListBox.Items[8] = "HDG HOLD: Off";
                        break;
                    case 1:
                        panelLightsListBox.Items[8] = "HDG HOLD: On";
                        break;
                }
            } // End HDG HOLD.

            // Vertical Speed mode. index 9.
            if (Aircraft.pmdg747.MCP_annunVS.ValueChanged)
            {
                switch(Aircraft.pmdg747.MCP_annunVS.Value)
                {
                    case 0:
                        panelLightsListBox.Items[9] = "VS: Off";
                        break;
                    case 1:
                        panelLightsListBox.Items[9] = "VS: On";
                        break;
                }
            } // End VS mode.

            // Altitude hold. index 10.
            if (Aircraft.pmdg747.MCP_annunALT_HOLD.ValueChanged)
            {
                switch(Aircraft.pmdg747.MCP_annunALT_HOLD.Value)
                {
                    case 0:
                        panelLightsListBox.Items[10] = "ALT HOLD: Off";
                        break;
                    case 1:
                        panelLightsListBox.Items[10] = "ALT HOLD: On";
                        break;
                }
            } // End ALT HOLD.

            // Localizer hold. index 11
            if (Aircraft.pmdg747.MCP_annunLOC.ValueChanged)
            {
                switch(Aircraft.pmdg747.MCP_annunLOC.Value)
                {
                    case 0:
                        panelLightsListBox.Items[11] = "LOC: Off";
                        break;
                    case 1:
                        panelLightsListBox.Items[11] = "LOC: On";
                        break;
                }
            } // End LOC.

            // Approach mode. index 12.
            if (Aircraft.pmdg747.MCP_annunAPP.ValueChanged)
            {
                switch(Aircraft.pmdg747.MCP_annunAPP.Value)
                {
                    case 0:
                        panelLightsListBox.Items[12] = "APPR: Off";
                        break;
                    case 1:
                        panelLightsListBox.Items[12] = "APPR: On";
                        break;
                }
            } // End APPR
        } // End MonitorLights.

        private void speedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void speedIntvButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_SPEED_PUSH_SWITCH, Aircraft.ClkL);
        }

        private void cmdSpdButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_SPD_SWITCH, Aircraft.ClkL);
        }

        private void autoThrottleButton_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.MCP_ATArm_Sw_On.Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_AT_ARM_SWITCH, Aircraft.ClkL);
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_AT_ARM_SWITCH, Aircraft.ClkR);
            }
        }

        private void iasMachToggleButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_IAS_MACH_SWITCH, Aircraft.ClkL);
        }

        private void thrustButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_THR_SWITCH, Aircraft.ClkL);
        }

        private void altitudeHoldButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_ALT_HOLD_SWITCH, Aircraft.ClkL);
        }

        private void flChangeButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_LVL_CHG_SWITCH, Aircraft.ClkL);
        }

        private void altitudeButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_ALTITUDE_PUSH_SWITCH, Aircraft.ClkL);
        }

        private void headingTextBox_TextChanged(object sender, EventArgs e)
        {
            if(short.TryParse(headingTextBox.Text, out short heading))
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_HDG_SET, heading);
            }
        }

        private void altitudeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void headingHoldButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_HDG_HOLD_SWITCH, Aircraft.ClkL);
        }

        private void headingButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_HEADING_PUSH_SWITCH, Aircraft.ClkL);
        }

        private void verticalSpeedTextBox_TextChanged(object sender, EventArgs e)
        {
            if(short.TryParse(verticalSpeedTextBox.Text, out short vspeed))
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_VS_SET, vspeed);
            }
        }

        private void vertSpeedHoldButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_VS_SWITCH, Aircraft.ClkL);
        }

        private void fdlButton_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.MCP_FD_Sw_On[0].Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_FD_SWITCH_L, Aircraft.ClkL);
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_FD_SWITCH_L, Aircraft.ClkR);
            }
        }

        private void fdrButton_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.MCP_FD_Sw_On[1].Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_FD_SWITCH_R, Aircraft.ClkL);
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_FD_SWITCH_R, Aircraft.ClkR);
            }
        }

        private void bankLimitButton_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.MCP_BankLimitSel.Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_BANK_ANGLE_SELECTOR, Aircraft.ClkL);
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_BANK_ANGLE_SELECTOR, Aircraft.ClkR);    
            }
        }

        private void disBarButton_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.MCP_DisengageBar.Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_DISENGAGE_BAR, Aircraft.ClkL);
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_DISENGAGE_BAR, Aircraft.ClkR);
            }
        }

        private void apLButton_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.MCP_AP_Sw_Pushed[0].Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_AP_L_SWITCH, Aircraft.ClkL);
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_AP_L_SWITCH, Aircraft.ClkR);
            }
        }

        private void apCButton_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.MCP_AP_Sw_Pushed[1].Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_AP_C_SWITCH, Aircraft.ClkL);
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_AP_C_SWITCH, Aircraft.ClkR);
            }
        }

        private void apRButton_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.MCP_AP_Sw_Pushed[2].Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_AP_R_SWITCH, Aircraft.ClkL);
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_AP_R_SWITCH, Aircraft.ClkR);
            }
        }

        private void lNavButton_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.MCP_LNAV_Sw_Pushed.Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_LNAV_SWITCH, Aircraft.ClkL);
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_LNAV_SWITCH, Aircraft.ClkR);
            }
        }

        private void vNavButton_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.MCP_VNAV_Sw_Pushed.Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_VNAV_SWITCH, Aircraft.ClkL);
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_VNAV_SWITCH, Aircraft.ClkR);
            }
        }

        private void locHoldButton_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.MCP_LOC_Sw_Pushed.Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_LOC_SWITCH, Aircraft.ClkL);
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_LOC_SWITCH, Aircraft.ClkR);
            }
        }

        private void apprButton_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg747.MCP_APP_Sw_Pushed.Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_APP_SWITCH, Aircraft.ClkL);
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_APP_SWITCH, Aircraft.ClkR);
            }
        }

        private void speedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(int.TryParse(speedTextBox.Text, out int speed))
                {
                    if(speed > 10)
                    {
                        FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_IAS_SET, speed);
                    }
                    else
                    {
                        FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_MACH_SET, speed);
                    }
                }
            }
        }

        private void altitudeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(altitudeTextBox.Text, out int altitude))
                {
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_ALT_SET, altitude);
                }
            }
        }

        private void headingTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (short.TryParse(headingTextBox.Text, out short heading))
                {
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_HDG_SET, heading);
                }
            }
        }

        private void verticalSpeedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(short.TryParse(verticalSpeedTextBox.Text, out short vspeed))
                {
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_MCP_VS_SET, vspeed);
                }
            }
        }
    } // End form.
} // End namespace.
