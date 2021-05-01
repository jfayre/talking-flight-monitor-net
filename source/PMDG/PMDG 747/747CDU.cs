using DavyKager;
using FSUIPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tfm
{
    public partial class _747CDU : Form
    {

        private System.Windows.Forms.Timer cduTimer = new System.Windows.Forms.Timer();
        int cduCursorPosition = 0;
        uint ClkL = 0x20000000;
        uint ClkR = 0x80000000;
        PMDG_NGX_CDU_Screen cdu;

        public _747CDU()
        {
            InitializeComponent();

            cdu = new PMDG_NGX_CDU_Screen(0x5400);
            RefreshCDU();
            cduTimer.Interval = 60000;

            cduTimer.Tick += new EventHandler(cduTimerTick);
            cduTimer.Start();
            this.Focus();
        } // End constructor.

        private void cduTimerTick(object Sender, EventArgs e)
        {
            try
            {
                this.RefreshCDU();
            } // End try.
            catch(FSUIPCException)
            {
                cduTimer.Enabled = false;
                cduTimer.Stop();
            } // End catche.
        } // End cduTimerTick.

        public void RefreshCDU()
        {
            // Check for keyboard focus before refreshing.
            if (txtCDU.Focused)
            {
                cduCursorPosition = txtCDU.SelectionStart;
            }

            txtCDU.Clear();
            Thread.Sleep(500);
            cdu.RefreshData();
            int rowCounter = 1;
            int lskCounter = 1;
            if (cdu.Powered)
            {
                this.Text = cdu.Rows[0].ToString().Trim() + "- PMDG 747 CDU";

            }
            foreach (PMDG_NGX_CDU_Row row in cdu.Rows)
            {
                if (new int[] { 3, 5, 7, 9, 11, 13 }.Contains(rowCounter))
                {
                    for (int i = 0; i <= 23; i++)
                    {
                        if (Convert.ToInt32(row.Cells[i].Symbol) == 234)
                        {
                            row.Cells[i].Symbol = '_';
                        }
                    }
                    txtCDU.Text += $"{lskCounter}: {row.ToString()}\r\n";
                    lskCounter++;
                }
                else
                {
                    txtCDU.Text += $"{row.ToString()}\r\n";
                }
                rowCounter++;
            }

            // Check for keyboard focus before restoring cursor state...
            if (txtCDU.Focused)
            {
                txtCDU.SelectionStart = cduCursorPosition;
            }
        } // End RefreshCDU.

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshCDU();
        } // End btnREFRESH_Click.

        private void btnClear_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_CLR, Aircraft.ClkL);
            RefreshCDU();
        } // End btnCLEAR_Click.

        private void btnInitRef_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_INIT_REF, Aircraft.ClkL);
            RefreshCDU();
        } // End btnInitRef_Click.

        private void btnRte_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_RTE, Aircraft.ClkL);
            RefreshCDU();
        } // End btnRTE_Click.

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_MENU, Aircraft.ClkL);
            RefreshCDU();
        } // End btnMENU_Click.

        private void btnLegs_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_LEGS, Aircraft.ClkL);
            RefreshCDU();
        } // End btnLEGS_Click.

        private void btnDepArr_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_DEP_ARR, Aircraft.ClkL);
            RefreshCDU();
        } // End btnDEPAR_Click.

        private void btnHold_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_HOLD, Aircraft.ClkL);
            RefreshCDU();
        } // End btnHOLD_Click.

        private void btnProg_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_PROG, Aircraft.ClkL);
            RefreshCDU();
        } // End btnPROG_Click.

        private void btnExec_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_EXEC, Aircraft.ClkL);
            RefreshCDU();
        } // End btnEXEC_Click.

        private void btnFix_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_FIX, Aircraft.ClkL);
            RefreshCDU();
        } // End btnFIX_Click.

        private void btnPrev_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_PREV_PAGE, Aircraft.ClkL);
            RefreshCDU();
        } // End btnPREV_Click.

        private void btnNext_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_NEXT_PAGE, Aircraft.ClkL);
            RefreshCDU();
        } // End btnNEXT_Click.

        private void btnATC_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_ATC, Aircraft.ClkL);
            RefreshCDU();
        } // End btnATC_Click.

        private void btnVNAV_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_VNAV, Aircraft.ClkL);
        } // End btnVNAV_Click.

        private void btnFMCCOMM_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_FMCCOMM, Aircraft.ClkL);
            RefreshCDU();
        } // End btnFMCCOMM_Click.

        private void btnSTART_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_START, Aircraft.ClkL);
            RefreshCDU();
        } // End btnSTART_Click.

        private void btnRADIOS_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_NAV_RAD, Aircraft.ClkL);
            RefreshCDU();
        } // End btnRADIOS_Click.

        private void btnEnd_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_END, Aircraft.ClkL);
            RefreshCDU();
        } // End btnEND_Click.

        private void txtEntry_KeyDown(object sender, KeyEventArgs e)
        {

            //Make an exception for Ctrl+A to perform default windows commands.
            if ((e.Control) && (e.KeyCode == Keys.A)) return;

            switch(e.KeyCode)
            {
                case Keys.A:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_A, Aircraft.ClkL);
                    break;
                case Keys.B:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_B, Aircraft.ClkL);
                    break;
                case Keys.C:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_C, Aircraft.ClkL);
                    break;
                case Keys.D:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_D, Aircraft.ClkL);
                    break;
                case Keys.E:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_E, Aircraft.ClkL);
                    break;
                case Keys.F:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_F, Aircraft.ClkL);
                    break;
                case Keys.G:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_G, Aircraft.ClkL);
                    break;
                case Keys.H:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_H, Aircraft.ClkL);
                    break;
                case Keys.I:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_I, Aircraft.ClkL);
                    break;
                case Keys.J:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_J, Aircraft.ClkL);
                    break;
                case Keys.K:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_K, Aircraft.ClkL);
                    break;
                case Keys.L:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_L, Aircraft.ClkL);
                    break;
                case Keys.M:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_M, Aircraft.ClkL);
                    break;
                case Keys.N:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_N, Aircraft.ClkL);
                    break;
                case Keys.O:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_O, Aircraft.ClkL);
                    break;
                case Keys.P:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_P, Aircraft.ClkL);
                    break;
                case Keys.Q:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_Q, Aircraft.ClkL);
                    break;
                case Keys.R:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_R, Aircraft.ClkL);
                    break;
                case Keys.S:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_S, Aircraft.ClkL);
                    break;
                case Keys.T:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_T, Aircraft.ClkL);
                    break;
                case Keys.U:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_U, Aircraft.ClkL);
                    break;
                case Keys.V:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_V, Aircraft.ClkL);
                    break;
                case Keys.W:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_W, Aircraft.ClkL);
                    break;
                case Keys.X:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_X, Aircraft.ClkL);
                    break;
                case Keys.Y:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_Y, Aircraft.ClkL);
                    break;
                case Keys.Z:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_Z, Aircraft.ClkL);
                    break;
                case Keys.D0:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_0, Aircraft.ClkL);
                    break;
                case Keys.D1:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_1, Aircraft.ClkL);
                    break;
                case Keys.D2:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_2, Aircraft.ClkL);
                    break;
                case Keys.D3:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_3, Aircraft.ClkL);
                    break;
                case Keys.D4:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_4, Aircraft.ClkL);
                    break;
                case Keys.D5:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_5, Aircraft.ClkL);
                    break;
                case Keys.D6:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_6, Aircraft.ClkL);
                    break;
                case Keys.D7:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_7, Aircraft.ClkL);
                    break;
                case Keys.D8:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_8, Aircraft.ClkL);
                    break;
                case Keys.D9:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_9, Aircraft.ClkL);
                    break;
                case Keys.Space:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_SPACE, Aircraft.ClkL);
                    break;
                case Keys.Back:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_DEL, Aircraft.ClkL);
                    break;
                case Keys.OemQuestion:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_SLASH, Aircraft.ClkL);
                    break;
                case Keys.Oemplus:
                    // send key twice to get plus symbol
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_PLUS_MINUS, Aircraft.ClkL);
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_PLUS_MINUS, Aircraft.ClkL);
                    break;
                
                case Keys.OemMinus:
                    txtEntry.Text = txtEntry.Text.Remove(txtEntry.Text.Length - 1, 1);
                        FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_PLUS_MINUS, Aircraft.ClkL);
                    break;
                case Keys.OemPeriod:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_DOT, Aircraft.ClkL);
                    break;
            } // End switch.
        } // End txtEntry_KeyDown.

        private void _747CDU_KeyDown(object sender, KeyEventArgs e)
        {
            // Allow Alt+F4 to perform the default Windows action.
            if ((e.Alt) && (e.KeyCode == Keys.F4)) return;

            // Line select keys.
            if (Properties.Settings.Default.PMDGCDUKeyLayout == "1")
            {
                ProcessDefaultSoftKeys(e);
            }

            if (Properties.Settings.Default.PMDGCDUKeyLayout == "2")
            {
                ProcessAlternateSoftKeys(e);
            }
            // Activate the buttons.
            if((e.Alt) && (e.KeyCode == Keys.R))
            {
                btnRefresh.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if((e.Control) && (e.KeyCode == Keys.S))
            {
                txtEntry.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if((e.Alt) && (e.KeyCode == Keys.C))
            {
                btnClear.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if((e.Alt) && (e.KeyCode == Keys.I))
            {
                btnInitRef.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if((e.Alt) && (e.KeyCode == Keys.T))
            {
                btnRte.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if((e.Alt) && (e.KeyCode == Keys.A))
            {
                btnATC.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if((e.Alt) && (e.KeyCode == Keys.V))
            {
                btnVNAV.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if((e.Control) && (e.KeyCode == Keys.F))
            {
                btnFMCCOMM.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if((e.Alt) && (e.KeyCode == Keys.M))
            {
                btnMenu.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if((e.Alt) && (e.KeyCode == Keys.G))
            {
                btnLegs.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if((e.Alt) && (e.KeyCode == Keys.D))
            {
                btnDepArr.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if((e.Alt) && (e.KeyCode == Keys.H))
            {
                btnHold.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if((e.Alt) && (e.KeyCode == Keys.P))
            {
                btnProg.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if((e.Control) && (e.KeyCode == Keys.E))
            {
                btnExec.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if((e.Alt) && (e.KeyCode == Keys.X))
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_DEL, Aircraft.ClkL);
                RefreshCDU();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if((e.Alt) && (e.KeyCode == Keys.S))
            {
                btnSTART.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if((e.Alt) && (e.KeyCode == Keys.F))
            {
                btnFix.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if(e.KeyCode == Keys.PageUp)
            {
                btnPrev.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if(e.KeyCode == Keys.PageDown)
            {
                btnNext.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if((e.Alt) && (e.KeyCode == Keys.O))
            {
                btnRADIOS.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if((e.Alt) && (e.KeyCode == Keys.E))
            {
                btnEnd.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if((e.Control) && (e.KeyCode == Keys.D))
            {
                txtCDU.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        } // End 747CDUKeyDown.
        private void ProcessDefaultSoftKeys(KeyEventArgs e)
        {
            if ((e.Alt && e.KeyCode == Keys.D1))
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_R1, 0x20000000);
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if ((e.Alt && e.KeyCode == Keys.D2))
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_R2, Aircraft.ClkL);
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if ((e.Alt && e.KeyCode == Keys.D3))
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_R3, 0x20000000);
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if ((e.Alt && e.KeyCode == Keys.D4))
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_R4, 0x20000000);
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if ((e.Alt && e.KeyCode == Keys.D5))
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_R5, 0x20000000);
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if ((e.Alt && e.KeyCode == Keys.D6))
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_R6, 0x20000000);
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if ((e.Control && e.KeyCode == Keys.D1))
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_L1, 0x20000000);
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if ((e.Control && e.KeyCode == Keys.D2))
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_L2, 0x20000000);
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if ((e.Control && e.KeyCode == Keys.D3))
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_L3, 0x20000000);
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if ((e.Control && e.KeyCode == Keys.D4))
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_L4, 0x20000000);
                RefreshCDU();
            }
            if ((e.Control && e.KeyCode == Keys.D5))
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_L5, 0x20000000);
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if ((e.Control && e.KeyCode == Keys.D6))
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_L6, 0x20000000);
                RefreshCDU();
                e.SuppressKeyPress = true;
            }

        }
        private void ProcessAlternateSoftKeys(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_L1, Aircraft.ClkL);
                RefreshCDU();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F2)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_L2, Aircraft.ClkL);
                RefreshCDU();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F3)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_L3, Aircraft.ClkL);
                RefreshCDU();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F4)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_L4, Aircraft.ClkL);
                RefreshCDU();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F5)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_L5, Aircraft.ClkL);
                RefreshCDU();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F6)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_L6, Aircraft.ClkL);
                RefreshCDU();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F7)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_R1, Aircraft.ClkL);
                RefreshCDU();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F8)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_R2, Aircraft.ClkL);
                RefreshCDU();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F9)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_R3, Aircraft.ClkL);
                RefreshCDU();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F10)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_R4, Aircraft.ClkL);
                RefreshCDU();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F11)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_R5, Aircraft.ClkL);
                RefreshCDU();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F12)
            {
                FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_R6, Aircraft.ClkL);
                RefreshCDU();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }


        }
    } // End form.
} // End namespace.
