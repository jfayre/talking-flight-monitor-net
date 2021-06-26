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
                    modeButton.Text = "&mode [IAS]";
                    modeButton.AccessibleName = "mode [IAS]";
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
        } // End SpeedBox_Load.

        private void modeButton_Click(object sender, EventArgs e)
        {

        }
    } // End SpeedBox form.
} // End namespace.
