using DavyKager;
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
    public partial class frmAutopilot : Form
    {
        InstrumentPanel ap = new InstrumentPanel();
        string instrument;
        public frmAutopilot(string instrument)
        {
            InitializeComponent();
            this.instrument = instrument;

        }

        private void frmAutopilot_Load(object sender, EventArgs e)
        {
            this.Activate();
            if (instrument == "Transponder")
            {
                this.Text = "set transponder";
            }
            else if (this.instrument == "Throttle")
            {
                this.Text = "Set Throttle Percent (min 0, max 100)";
            }
            else if (this.instrument == "Spoilers")
            {
                this.Text = "Enter spoiler percentage (0 or 7 <= percentage <= 100)";
            }
            else
            {
                this.Text = $"set autopilot {instrument}";
            }
            
            lblSetting.Text = $"Enter {this.instrument}: ";
            switch (this.instrument)
            {
                case "Altitude":
                    txtSetting.Text = ap.ApAltitude.ToString();
                    chkLock.AccessibleName = "Altitude lock";
                    chkLock.Checked = ap.ApAltitudeLock;
                    break;
                case "Heading":
                    txtSetting.Text = ap.ApHeading.ToString();
                    chkLock.AccessibleName = "heading lock";
                    chkLock.Checked = ap.ApHeadingLock;
                    break;
                case "Airspeed":
                    txtSetting.Text = ap.ApAirspeed.ToString();
                    chkLock.AccessibleName = "airspeed hold";
                    chkLock.Checked = ap.ApAirspeedHold;
                    break;
                case "Mach":
                    txtSetting.Text = ap.ApMachSpeed.ToString();
                    chkLock.AccessibleName = "mach hold";
                    chkLock.Checked = ap.ApMachHold;
                    break;
                case "Vertical speed":
                    txtSetting.Text = ap.ApVerticalSpeed.ToString();
                    chkLock.AccessibleName = "vertical speed hold";
                    chkLock.Checked = ap.ApVerticalSpeedHold;
                    break;
                case "Transponder":
                    txtSetting.Text = ap.Transponder.ToString();
                    chkLock.Visible = false;
                    break;
                case "Throttle":
                    txtSetting.Text = ap.Engine1ThrottlePercent.ToString();
                    chkLock.Visible = false;
                    break;
                case "Spoilers":
                    txtSetting.Text = ap.SpoilerPercent.ToString();
                    chkLock.Visible = false;
                    break;
            }
            txtSetting.SelectionStart = 0;
            txtSetting.SelectionLength = txtSetting.Text.Length;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            switch (this.instrument)
            {
                case "Altitude":
                    if (double.TryParse(txtSetting.Text, out double altitude))
                    {
                        ap.ApAltitude = altitude;
                        ap.ApAltitudeLock = chkLock.Checked;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Tolk.Output("invalid altitude");
                        txtSetting.Text = string.Empty;
                        txtSetting.Focus();
                    }
                    
                    break;

                case "Heading":
                    if (double.TryParse(txtSetting.Text, out double heading) && heading >= 0 && heading <= 360)
                    {
                        ap.ApHeading = heading;
                        ap.ApHeadingLock = chkLock.Checked;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Tolk.Output("invalid heading");
                        txtSetting.Text = string.Empty;
                        txtSetting.Focus();
                    }


                    
                    break;

                case "Airspeed":
                    if (double.TryParse(txtSetting.Text, out double airspeed))
                    {
                        ap.ApAirspeed = airspeed;
                        ap.ApAirspeedHold = chkLock.Checked;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Tolk.Output("invalid airspeed");
                        txtSetting.Text = string.Empty;
                        txtSetting.Focus();
                    }

                    break;

                case "Mach":
                    if (double.TryParse(txtSetting.Text, out double mach))
                    {
                        ap.ApMachSpeed = mach;
                        ap.ApMachHold = chkLock.Checked;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Tolk.Output("invalid mach speed");
                        txtSetting.Text = string.Empty;
                        txtSetting.Focus();
                    }

                    break;

                case "Vertical speed":
                    if (double.TryParse(txtSetting.Text, out double verticalSpeed))
                    {
                        ap.ApVerticalSpeed = verticalSpeed;
                        ap.ApVerticalSpeedHold = chkLock.Checked;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Tolk.Output("invalid vertical speed");
                        txtSetting.Text = string.Empty;
                        txtSetting.Focus();
                    }

                    break;
                case "Transponder":
                    if (int.TryParse(txtSetting.Text, out int transponder))
                    {
                        ap.Transponder = transponder;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Tolk.Output("invalid transponder setting");
                        txtSetting.Text = string.Empty;
                        txtSetting.Focus();
                    }

                    break;

                case "Throttle":
                    if (Double.TryParse(txtSetting.Text, out double thrPercent))
                    {
                        if ((0.0 <= thrPercent) && (thrPercent <= 100.0))
                        {
                            ap.Engine1ThrottlePercent = ap.Engine2ThrottlePercent = ap.Engine3ThrottlePercent = ap.Engine4ThrottlePercent = thrPercent;
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            Tolk.Output("Invalid throttle setting. Must be between 0 and 100.");
                            txtSetting.Text = String.Empty;
                            txtSetting.Focus();
                        }
                    }
                    else
                    {
                        Tolk.Output("Invalid throttle setting.");
                        txtSetting.Text = String.Empty;
                        txtSetting.Focus();
                    }
                    break;

                case "Spoilers":
if(uint.TryParse(txtSetting.Text, out uint spPercent))
                    {
                        if((spPercent==0)||((7 <= spPercent)&&(spPercent <= 100)))
                        {
                            ap.SpoilerPercent = spPercent;
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            Tolk.Output("Spoiler percentage can only be 0, or greater than 7 and less than 100. This is an internal limitation.");
                            txtSetting.Text = String.Empty;
                            txtSetting.Focus();
                        }
                    }
                    else
                    {
                        Tolk.Output("Spoiler percentage must be 0, or a number greater than 7 and less than 100. This is an internal limitation.");
                        txtSetting.Text = String.Empty;
                        txtSetting.Focus();
                    }
                    break;  
                    }
            }


                
    }
    }
