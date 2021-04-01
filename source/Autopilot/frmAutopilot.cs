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
            else if(instrument == "spoilers")
            {
                this.Text = "Deploy spoilers";
                lblSetting.Text = "Enter percent (0 to retract, 1 to arm, or 7 - 100):";
                chkLock.Visible = false;
                txtSetting.Text = ap.SpoilerPercent.ToString();
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
                case "spoilers":
                    if(uint.TryParse(txtSetting.Text, out uint spoilerPercent))
                    {
                        if((spoilerPercent == 0) || (spoilerPercent == 1) || (spoilerPercent >= 7 && spoilerPercent <= 100))
                        {
                            ap.SpoilerPercent = spoilerPercent;
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            Tolk.Output("Invalid spoiler value.");
                            txtSetting.Text = string.Empty;
                            txtSetting.Focus();
                        }
                    }
                    else
                    {
                        Tolk.Output("Invalid spoiler value.");
                        txtSetting.Text = string.Empty;
                        txtSetting.Focus();
                    }
                    break;
                    }
            }


                
    }
    }
