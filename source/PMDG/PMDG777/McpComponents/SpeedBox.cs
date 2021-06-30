using tfm.PMDG.PMDG777;
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

namespace tfm.PMDG.PMDG777.McpComponents
{
    public partial class SpeedBox : Form
    {
        System.Windows.Forms.Timer speedTimer = new System.Windows.Forms.Timer();
        private bool _isAirspeedMode = true;



        
        public SpeedBox()
        {
            InitializeComponent();

            // Timer for tracking MCP switches and values.
                        speedTimer.Tick += new EventHandler(SpeedTimerTick);
            speedTimer.Start();
        } // End SpeedBox constructor,.

        private void SpeedTimerTick(object Sender, EventArgs eventArgs)
        {

            // Only look for changes as to not paralize a screen reader when
            // using the controls.

            if(this._isAirspeedMode)
            {
                if(Aircraft.pmdg777.MCP_IASMach.ValueChanged)
                {
                    speedTextBox.Text = Aircraft.pmdg777.MCP_IASMach.Value.ToString();
                    modeButton.Text = "&mode [IAS]";
                    modeButton.AccessibleName = "mode [IAS]";
                                    }
            } // Airspeed mode.
            else
            {
                if(Aircraft.pmdg777.MCP_IASMach.ValueChanged)
                {
                    speedTextBox.Text = $"{Math.Round(Aircraft.pmdg777.MCP_IASMach.Value, 2)}";
                    modeButton.Text = "&mode [mach]";
                    modeButton.AccessibleName = "mode [mach]";
                } // End value changed.
                                            } // End mach mode.
            if(Aircraft.pmdg777.MCP_ATArm_Sw_On[0].ValueChanged)
            {
                switch(Aircraft.pmdg777.MCP_ATArm_Sw_On[0].Value)
                {
                    case 0:
                        autoThrottleLButton.Text = "&left off";
                        autoThrottleLButton.AccessibleName = "left off";
                        break;
                    case 1:
                        autoThrottleLButton.Text = "&left on";
                        autoThrottleLButton.AccessibleName = "left on";
                        break;
                }
            }
            if(Aircraft.pmdg777.MCP_ATArm_Sw_On[1].ValueChanged)
            {
                switch(Aircraft.pmdg777.MCP_ATArm_Sw_On[1].Value)
                {
                    case 0:
                        autoThrottleRButton.Text = "&right off";
                        autoThrottleRButton.AccessibleName = "right off";
                        break;
                    case 1:
                        autoThrottleRButton.Text = "&right on";
                        autoThrottleRButton.AccessibleName = "right on";
                        break;
                }
            }

            if(Aircraft.pmdg777.MCP_annunAT.ValueChanged)
            {
                switch(Aircraft.pmdg777.MCP_annunAT.Value)
                {
                    case 0:
                        autoThrottleButton.Text = "&autothrottle off";
                        autoThrottleButton.AccessibleName = "Autothrottle off";
                        break;
                    case 1:
                        autoThrottleButton.Text = "&Autothrottle on";
                        autoThrottleButton.AccessibleName = "Autothrottle on";
                        break;
                }
            }
        } // End SpeedTimerTick.

        private void SpeedBox_Load(object sender, EventArgs e)
        {

            // Set initial values for the form.
            if(this._isAirspeedMode)
            {
                speedTextBox.Text = Aircraft.pmdg777.MCP_IASMach.Value.ToString();
            } // End airspeed mode.
            else
            {
                speedTextBox.Text = $"{Math.Round(Aircraft.pmdg777.MCP_IASMach.Value, 2)}";
            } // End mach mode.

            if(Aircraft.pmdg777.MCP_ATArm_Sw_On[0].Value == 0)
            {
                autoThrottleLButton.Text = "&left off";
                autoThrottleLButton.AccessibleName = "left off";
            }
            else
            {
                autoThrottleLButton.Text = "&left on";
                autoThrottleLButton.AccessibleName = "left on";
            } // End left autothrottle.

            if(Aircraft.pmdg777.MCP_ATArm_Sw_On[1].Value == 0)
            {
                autoThrottleRButton.Text = "&right off";
                autoThrottleRButton.AccessibleName = "right off";
            }
            else
            {
                autoThrottleRButton.Text = "&right on";
                autoThrottleRButton.AccessibleName = "right on";
            } // End right autothrottle.

            if(this._isAirspeedMode)
            {
                modeButton.Text = "&mode [IAS]";
                modeButton.AccessibleName = "mode [IAS]";
            }
            else
            {
                modeButton.Text = "&mode [mach]";
                modeButton.AccessibleName = "mode [mach]";
            }

            if(Aircraft.pmdg777.MCP_annunAT.Value == 0)
            {
                autoThrottleButton.Text = "&Autothrottle off";
                autoThrottleButton.AccessibleName = "Autothrottle off";
            }
            else
            {
                autoThrottleButton.Text = "&Autothrottle on";
                autoThrottleButton.AccessibleName = "Autothrottle on";
            } // End autothrottle.
        } // End SpeedBox_Load.

        private void modeButton_Click(object sender, EventArgs e)
        {
                        if(Aircraft.pmdg777.MCP_IASMach.Value < 10)
            {
                FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_IAS_MACH_SWITCH, Aircraft.ClkR);
                _isAirspeedMode = false;
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_IAS_MACH_SWITCH, Aircraft.ClkL);
                _isAirspeedMode = true;
            }
        } // End modeButton click.

        private void SpeedBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
                    } // End closing event.

        private void speedButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_SPEED_PUSH_SWITCH, Aircraft.ClkL);
        }

        private void autoThrottleLButton_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg777.MCP_ATArm_Sw_On[0].Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_AT_ARM_SWITCH_L, Aircraft.ClkL);
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_AT_ARM_SWITCH_L, Aircraft.ClkR);
            }
        }

        private void autoThrottleRButton_Click(object sender, EventArgs e)
        {
            if(Aircraft.pmdg777.MCP_ATArm_Sw_On[1].Value == 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_AT_ARM_SWITCH_R, Aircraft.ClkL);
            }
            else
            {
                FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_AT_ARM_SWITCH_R, Aircraft.ClkR);
            }
        }

        private void autoThrottleButton_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_AT_SWITCH, Aircraft.ClkL);
            if (Aircraft.pmdg777.MCP_annunAT.Value == 0)
            {
                autoThrottleButton.Text = "&Autothrottle on";
                autoThrottleButton.AccessibleName = "Autothrottle on";
            }
            else
            {
                                autoThrottleButton.Text = "&Autothrottle off";
                autoThrottleButton.AccessibleName = "Autothrottle off";
            }
        }

        private void speedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
                        if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (Aircraft.pmdg777.MCP_IASMach.Value < 10)
                {
                    float.TryParse(speedTextBox.Text, out float mach);
                    FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_MACH_SET, PMDG777Aircraft.CalculateMachParameter(mach));
                } // End mach.
                else
                {
                    int.TryParse(speedTextBox.Text, out int speed);
                    FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_IAS_SET, speed);
                } // End airspeed.
            } // End key check.
        } // End key down event.

        private void SpeedBox_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.Alt) && (e.KeyCode == Keys.E))
            {
                e.SuppressKeyPress = true;
                speedTextBox.Focus();
            }
        } // End SpeedBox key down event.
    } // End SpeedBox form.
} // End namespace.
