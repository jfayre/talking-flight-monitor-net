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
    public partial class VerticalSpeedBox : Form
    {
        System.Windows.Forms.Timer verticalSpeedTimer = new System.Windows.Forms.Timer();

        public VerticalSpeedBox()
        {
            InitializeComponent();

            verticalSpeedTimer.Tick += new EventHandler(TimerTick);
            verticalSpeedTimer.Start();
            Tolk.Load();
        } // End constructor.

        private void TimerTick(object Sender, EventArgs eventArgs)
        {

            if (Aircraft.pmdg777.MCP_VSDial_Mode.ValueChanged)
            {
                switch (Aircraft.pmdg777.MCP_VSDial_Mode.Value)
                {
                    case 0:
                        vsFpaTextBox.AccessibleName = "Vertical speed";
                                                modeButton.Text = "&Mode [VS]";
                        modeButton.AccessibleName = "Mode [VS]";
                        Tolk.Output("Vertical speed mode.");
                        break;
                    case 1:
                        vsFpaTextBox.AccessibleName = "Flight path angle";
                                                modeButton.Text = "&Mode [FPA]";
                        modeButton.AccessibleName = "Mode [FPA]";
                        Tolk.Output("FPA mode.");
                        break;
                }
            }

            if(Aircraft.pmdg777.MCP_VSDial_Mode.Value == 0 && Aircraft.pmdg777.MCP_VertSpeed.ValueChanged)
            {
                vsFpaTextBox.Text = Aircraft.pmdg777.MCP_VertSpeed.Value.ToString();
            }
            if(Aircraft.pmdg777.MCP_VSDial_Mode.Value == 1 && Aircraft.pmdg777.MCP_FPA.ValueChanged)
            {
                vsFpaTextBox.Text = $"{Aircraft.pmdg777.MCP_FPA.Value}";
            }
        } // End TimerTick.

        private void VerticalSpeedBox_Load(object sender, EventArgs e)
        {
            if(Aircraft.pmdg777.MCP_VSDial_Mode.Value == 0)
            {
                                                                            vsFpaTextBox.AccessibleName = "Vertical speed";
                                                modeButton.Text = "&Mode [VS]";
                modeButton.AccessibleName = "Mode [VS]";
                vsFpaTextBox.Text = Aircraft.pmdg777.MCP_VertSpeed.Value.ToString();
                }
                else
                {
                                                                                                                        vsFpaTextBox.AccessibleName = "Flight path angle";
                vsFpaTextBox.Text = $"{Aircraft.pmdg777.MCP_FPA.Value}";
                                                        modeButton.Text = "&Mode [FPA]";
                            modeButton.AccessibleName = "Mode [FPA]";
                    }
        } // End form load.

        private void interveneButton_Click(object sender, EventArgs e)
        {
            PMDG777Aircraft.VerticalSpeed_FPAIntervene();
        } // End intervene

        private void VerticalSpeedBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            } // End form closing.
        }

        private void VerticalSpeedBox_KeyDown(object sender, KeyEventArgs e)
        {
            
            if((e.Alt) && (e.KeyCode == Keys.E))
            {
                e.SuppressKeyPress = true;
                vsFpaTextBox.Focus();
            }
        } // End key down event.

        private void modeButton_Click(object sender, EventArgs e)
        {
            PMDG777Aircraft.ToggleVsFPAMode();

                    } // End mode.

        private void vsFpaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
                        if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if(Aircraft.pmdg777.MCP_VSDial_Mode.Value == 0)
                {
                    ushort.TryParse(vsFpaTextBox.Text, out ushort vs);
                    FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_VS_SET, PMDG777Aircraft.CalculateVerticalSpeedParameter(vs));
                }
                else
                {
                    float.TryParse(vsFpaTextBox.Text, out float FPA);
                    FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_FPA_SET, (int)PMDG777Aircraft.CalculateFPAParameter(FPA));
                }
            } // End key check.

        } // End vsFPATextBox KeyDown event
    } // End VerticalSpeedBox.
} // End namespace.
