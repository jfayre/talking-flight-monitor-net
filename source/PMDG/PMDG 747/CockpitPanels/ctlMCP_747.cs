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
    } // End form.
} // End namespace.
