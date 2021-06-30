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

namespace tfm.PMDG.PMDG777.McpComponents
{
    public partial class AltitudeBox : Form
    {
        private System.Windows.Forms.Timer altitudeTimer = new System.Windows.Forms.Timer();

        public AltitudeBox()
        {
            InitializeComponent();
            altitudeTimer.Tick += new EventHandler(AltitudeTimerTick);
            altitudeTimer.Start();
            Tolk.Load();
        } // End constructor.

        private void AltitudeTimerTick(object Sender, EventArgs eventArgs)
        {

            if (Aircraft.pmdg777.MCP_Altitude.ValueChanged)
            {
                altitudeTextBox.Text = Aircraft.pmdg777.MCP_Altitude.Value.ToString();
            }

            if (Aircraft.pmdg777.MCP_annunALT_HOLD.ValueChanged)
            {
                switch (Aircraft.pmdg777.MCP_annunALT_HOLD.Value)
                {
                    case 0:
                        altitudeHoldButton.Text = "&Altitude hold off";
                        altitudeHoldButton.AccessibleName = "Altitude hold off";
                        break;
                    case 1:
                        altitudeHoldButton.Text = "&Altitude hold on";
                        altitudeHoldButton.AccessibleName = "Altitude hold on";
                        break;
                }
            }
            if (Aircraft.pmdg777.MCP_annunVNAV.ValueChanged)
            {
                switch (Aircraft.pmdg777.MCP_annunVNAV.Value)
                {
                    case 0:
                        vNavButton.Text = "&VNav off";
                        vNavButton.AccessibleName = "VNav off";
                        break;
                    case 1:
                        vNavButton.Text = "&VNav on";
                        vNavButton.AccessibleName = "VNav on";
                        break;
                }
            }

            if (Aircraft.pmdg777.MCP_annunFLCH.ValueChanged)
            {
                switch (Aircraft.pmdg777.MCP_annunFLCH.Value)
                {
                    case 0:
                        levelChangeButton.Text = "&Level change off";
                        levelChangeButton.AccessibleName = "Level change off";
                        break;
                    case 1:
                        levelChangeButton.Text = "&Level change on";
                        levelChangeButton.AccessibleName = "Level change on";
                        break;
                }
            }
        } // End AltitudeTimerTick.

        private void AltitudeBox_Load(object sender, EventArgs e)
        {
            altitudeTextBox.Text = Aircraft.pmdg777.MCP_Altitude.Value.ToString();
            if (Aircraft.pmdg777.MCP_annunALT_HOLD.Value == 0)
            {
                altitudeHoldButton.Text = "&Altitude hold off";
                altitudeHoldButton.AccessibleName = "Altitude hold off";
            }
            else
            {
                altitudeHoldButton.Text = "&Altitude hold on";
                altitudeHoldButton.AccessibleName = "Altitude hold on";
            }

            if (Aircraft.pmdg777.MCP_annunVNAV.Value == 0)
            {
                vNavButton.Text = "Y&V nav off";
                vNavButton.AccessibleName = "VNav off";
            }
            else
            {
                vNavButton.Text = "&VNav on";
                vNavButton.AccessibleName = "VNav on";
            }

            if (Aircraft.pmdg777.MCP_annunFLCH.Value == 0)
            {
                levelChangeButton.Text = "&Level change off";
                levelChangeButton.AccessibleName = "Level change off";
            }
            else
            {
                levelChangeButton.Text = "&Level change on";
                levelChangeButton.AccessibleName = "Level change on";
            }
        }

        private void altitudeButton_Click(object sender, EventArgs e)
        {
            PMDG777Aircraft.AltitudeIntervene();
            Tolk.Output("Altitude intervene");
        } // End AltitudeButton_Click.

        private void altitudeHoldButton_Click(object sender, EventArgs e)
        {
            PMDG777Aircraft.ToggleAltitudeHold();
        } // End AltitudeBox.

        private void vNavButton_Click(object sender, EventArgs e)
        {
            PMDG777Aircraft.ToggleVNav();
        } // End vNavButton_Click.

        private void levelChangeButton_Click(object sender, EventArgs e)
        {
            PMDG777Aircraft.ToggleLevelChange();
        } // End levelChangeButton_Click.

        private void altitudeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                PMDG777Aircraft.SetAltitude(altitudeTextBox.Text);
                e.SuppressKeyPress = true;
            }
        } // End altitudeTextBox_KeyDown.

        private void AltitudeBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        } // End Form closing event.

        private void AltitudeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.Alt) && (e.KeyCode == Keys.E))
            {
                e.SuppressKeyPress = true;
                altitudeTextBox.Focus();
            }
        } // End AltitudeBox key down event.
    } // End AltitudeBox.
    } // End namespace.
