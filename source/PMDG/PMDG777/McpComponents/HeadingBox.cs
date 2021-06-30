using DavyKager;
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
    public partial class HeadingBox : Form
    {

        private System.Windows.Forms.Timer headingTimer = new System.Windows.Forms.Timer();

        public HeadingBox()
        {
            InitializeComponent();
            Tolk.Load();

            headingTimer.Tick += new EventHandler(TimerTick);
            headingTimer.Start();
        } // End constructor.

        private void TimerTick(object Sender, EventArgs eventArgs)
        {
            if (Aircraft.pmdg777.MCP_HDGDial_Mode.ValueChanged)
            {
                switch (Aircraft.pmdg777.MCP_HDGDial_Mode.Value)
                {
                    case 0:
                        modeButton.Text = "&Mode [HDG]";
                        modeButton.AccessibleName = "Mode [HDG]";
                        hdgTrkTextBox.AccessibleName = "Heading";
                        Tolk.Output("Heading mode on.");
                        break;
                    case 1:
                        modeButton.Text = "&Mode [TRK]";
                        modeButton.AccessibleName = "Mode [TRK]";
                        hdgTrkTextBox.AccessibleName = "Track";
                        Tolk.Output("Track mode on.");
                        break;
                }
            }
                if (Aircraft.pmdg777.MCP_Heading.ValueChanged)
                {
                    hdgTrkTextBox.Text = Aircraft.pmdg777.MCP_Heading.Value.ToString();
                }
            if (Aircraft.pmdg777.MCP_annunHDG_HOLD.ValueChanged)
            {
                switch (Aircraft.pmdg777.MCP_annunHDG_HOLD.Value)
                {
                    case 0:
                        hdgHoldButton.Text = "Heading h&old off";
                        hdgHoldButton.AccessibleName = "Heading hold off";
                        break;
                    case 1:
                        hdgHoldButton.Text = "Heading h&old on";
                        hdgHoldButton.AccessibleName = "Heading hold on";
                        break;
                }
            }
                    if (Aircraft.pmdg777.MCP_annunLNAV.ValueChanged)
                    {
                        switch (Aircraft.pmdg777.MCP_annunLNAV.Value)
                        {
                            case 0:
                                lNavButton.Text = "&LNav off";
                                lNavButton.AccessibleName = "LNav off";
                                break;
                            case 1:
                                lNavButton.Text = "&LNav on";
                                lNavButton.AccessibleName = "LNav on";
                        break;
                        }
                    }
                        } // End TimerTick.

        private void HeadingBox_Load(object sender, EventArgs e)
        {
            hdgTrkTextBox.Text = Aircraft.pmdg777.MCP_Heading.Value.ToString();

            if (Aircraft.pmdg777.MCP_HDGDial_Mode.Value == 0)
            {
                modeButton.Text = "&Mode [HDG]";
                modeButton.AccessibleName = "Mode [HDG]";
                hdgTrkTextBox.AccessibleName = "Heading";
            }
            else
            {
                modeButton.Text = "&Mode [TRK]";
                modeButton.AccessibleName = "Mode [TRK]";
                hdgTrkTextBox.AccessibleName = "Track";
            }

            if (Aircraft.pmdg777.MCP_annunHDG_HOLD.Value == 0)
            {
                hdgHoldButton.Text = "Heading h&old off";
                hdgHoldButton.AccessibleName = "Heading hold off";
            }
            else
            {
                hdgHoldButton.Text = "Heading h&old on";
                hdgHoldButton.AccessibleName = "Heading hold on";
            }
            if (Aircraft.pmdg777.MCP_annunLNAV.Value == 0)
            {
                lNavButton.Text = "&LNav off";
                lNavButton.AccessibleName = "LNav off";
            }
            else
            {
                lNavButton.Text = "&LNav on";
                lNavButton.AccessibleName = "LNav on";
            }
        } // End form load.

        private void HeadingBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        } // End form closing.

        private void HeadingBox_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.Alt) && (e.KeyCode == Keys.E))
            {
                hdgTrkTextBox.Focus();
            }
        } // End form keydown.

        private void interveneButton_Click(object sender, EventArgs e)
        {
            PMDG777Aircraft.HeadingIntervene();
            Tolk.Output("Heading intervene.");
        } // End headingButton click.

        private void hdgHoldButton_Click(object sender, EventArgs e)
        {
            PMDG777Aircraft.ToggleHeadingHold();
        } // End heading hold button click.

        private void lNavButton_Click(object sender, EventArgs e)
        {
            PMDG777Aircraft.ToggleLNav();
        } // End LNavButton click.

        private void modeButton_Click(object sender, EventArgs e)
        {
            PMDG777Aircraft.ToggleHeadingTrack();
        } // End modeButton click.

        private void hdgTrkTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                PMDG777Aircraft.SetHeading(hdgTrkTextBox.Text);
            }
        } // End hdgTrkTextBox KeyDown.
    } // End heading box.
} // End namespace.
