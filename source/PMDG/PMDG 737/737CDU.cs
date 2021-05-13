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
    public partial class _737CDU : Form
    {
        private System.Windows.Forms.Timer cduTimer = new System.Windows.Forms.Timer();
                int cduCursorPosition = 0;
        uint ClkL = 0x20000000;
        uint ClkR = 0x80000000;

        pmdg pmdg = new pmdg();
        
        

        public _737CDU()
        {
            InitializeComponent();
            RefreshCDU();
            cduTimer.Interval = 60000;
            cduTimer.Tick += new EventHandler(cduTimerTick);
            cduTimer.Start();
            txtEntry.Focus();
        }

        private void cduTimerTick(object Sender, EventArgs e)
        {

            try
            {
                RefreshCDU();
            }
            catch(FSUIPCException)
            {
                cduTimer.Enabled = false;
                cduTimer.Stop();
            }
            
        }

        public void RefreshCDU()
        {
            
            // Check for keyboard focus before refreshing.
            if(txtCDU.Focused)
              {
                  cduCursorPosition = txtCDU.SelectionStart;
              }

                        txtCDU.Clear();
            Thread.Sleep(500);
            string CDUScreen = pmdg.RefreshCDU(0);
            if (pmdg.cdu0.Powered)
            {
                this.Text = pmdg.cdu0.Rows[0].ToString().Trim() + "- PMDG 737 CDU";

            }
            txtCDU.Text = CDUScreen;

            // Check for keyboard focus before restoring cursor state...
            if(txtCDU.Focused)
                {
                    txtCDU.SelectionStart = cduCursorPosition;
                }
                    }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
                                        RefreshCDU();
                                }

        

        private void CDUForm_KeyDown(object sender, KeyEventArgs e)
        {

            // Special case where we need to look for ALT+F4.
            if((e.Alt) && (e.KeyCode == Keys.F4)) {
                return;
            }
            // keys for CDU buttons
            // menu key
            if ((e.Alt && e.KeyCode == Keys.M))
            {
                btnMenu.PerformClick();
                e.SuppressKeyPress = true;
            }
            // Execute
            if ((e.Alt && e.KeyCode == Keys.E))
            {
                btnExec.PerformClick();
                e.SuppressKeyPress = true;
            }
            // dep arr
            if ((e.Alt && e.KeyCode == Keys.A))
            {
                btnDepArr.PerformClick();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            // init ref
            if ((e.Alt && e.KeyCode == Keys.I))
            {
                btnInitRef.PerformClick();
                e.SuppressKeyPress = true;
            }
            // prog
            if ((e.Alt && e.KeyCode == Keys.P))
            {
                btnProg.PerformClick();
                e.SuppressKeyPress = true;
            }
            // RTE
            if ((e.Alt && e.KeyCode == Keys.T))
            {
                btnRte.PerformClick();
                e.SuppressKeyPress = true;
            }
            // CLB
            if ((e.Alt && e.KeyCode == Keys.B))
            {
                btnClb.PerformClick();
                e.SuppressKeyPress = true;
            }
            // CRZ
            if ((e.Alt && e.KeyCode == Keys.Z))
            {
                btnCrz.PerformClick();
                e.SuppressKeyPress = true;
            }
            // DES
            if ((e.Alt && e.KeyCode == Keys.D))
            {
                btnDes.PerformClick();
                e.SuppressKeyPress = true;
            }
            // legs
            if ((e.Alt && e.KeyCode == Keys.G))
            {
                btnLegs.PerformClick();
                e.SuppressKeyPress = true;
            }
            // hold
            if ((e.Alt && e.KeyCode == Keys.H))
            {
                btnHold.PerformClick();
                e.SuppressKeyPress = true;
            }
            // N1 Limit
            if ((e.Alt && e.KeyCode == Keys.N))
            {
                btnN1Limit.PerformClick();
                e.SuppressKeyPress = true;
            }
            // fix
            if ((e.Alt && e.KeyCode == Keys.F))
            {
                btnFix.PerformClick();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            // process soft keys based on key setting
            if (Properties.Settings.Default.PMDGCDUKeyLayout == "1")
            {
                ProcessDefaultSoftKeys(e);
            }

            if (Properties.Settings.Default.PMDGCDUKeyLayout == "2")
            {
                ProcessAlternateSoftKeys(e);
            }

            if ((e.Alt && e.KeyCode == Keys.X))
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_DEL, 0x20000000);
                RefreshCDU();
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.PageDown)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_NEXT_PAGE, 0x20000000);
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.PageUp)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_PREV_PAGE, 0x20000000);
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if((e.Alt && e.KeyCode == Keys.C))
            {
                btnClear.PerformClick();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if((e.Alt && e.KeyCode == Keys.R))
            {
                btnRefresh.PerformClick();
                e.SuppressKeyPress = true;
            }
            if((e.Alt && e.KeyCode == Keys.S))
            {
                txtEntry.Focus();
                e.SuppressKeyPress = true;
            }
            if((e.Alt && e.KeyCode == Keys.Home))
            {
                txtCDU.Focus();
                e.SuppressKeyPress = true;
            }

        }

        private void ProcessDefaultSoftKeys(KeyEventArgs e)
        {
            if ((e.Alt && e.KeyCode == Keys.D1))
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_R1, 0x20000000);
                RefreshCDU();
                txtEntry.Clear();
                e.SuppressKeyPress = true;
            }
            if ((e.Alt && e.KeyCode == Keys.D2))
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_R2, Aircraft.ClkL);
                txtEntry.Clear();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if ((e.Alt && e.KeyCode == Keys.D3))
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_R3, 0x20000000);
                txtEntry.Clear();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if ((e.Alt && e.KeyCode == Keys.D4))
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_R4, 0x20000000);
                txtEntry.Clear();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if ((e.Alt && e.KeyCode == Keys.D5))
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_R5, 0x20000000);
                txtEntry.Clear();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if ((e.Alt && e.KeyCode == Keys.D6))
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_R6, 0x20000000);
                txtEntry.Clear();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if ((e.Control && e.KeyCode == Keys.D1))
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_L1, 0x20000000);
                txtEntry.Clear();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if ((e.Control && e.KeyCode == Keys.D2))
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_L2, 0x20000000);
                txtEntry.Clear();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if ((e.Control && e.KeyCode == Keys.D3))
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_L3, 0x20000000);
                txtEntry.Clear();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if ((e.Control && e.KeyCode == Keys.D4))
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_L4, 0x20000000);
                txtEntry.Clear();
                RefreshCDU();
            }
            if ((e.Control && e.KeyCode == Keys.D5))
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_L5, 0x20000000);
                txtEntry.Clear();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if ((e.Control && e.KeyCode == Keys.D6))
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_L6, 0x20000000);
                txtEntry.Clear();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }

        }

        private void ProcessAlternateSoftKeys(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_R1, 0x20000000);
                txtEntry.Clear();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F8)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_R2, Aircraft.ClkL);
                txtEntry.Clear();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F9)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_R3, 0x20000000);
                txtEntry.Clear();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F10)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_R4, 0x20000000);
                txtEntry.Clear();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F11)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_R5, 0x20000000);
                txtEntry.Clear();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F12)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_R6, 0x20000000);
                txtEntry.Clear();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_L1, 0x20000000);
                txtEntry.Clear();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F2)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_L2, 0x20000000);
                txtEntry.Clear();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F3)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_L3, 0x20000000);
                txtEntry.Clear();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F4)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_L4, 0x20000000);
                txtEntry.Clear();
                RefreshCDU();
            }
            if (e.KeyCode == Keys.F5)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_L5, 0x20000000);
                txtEntry.Clear();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F6)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_L6, 0x20000000);
                txtEntry.Clear();
                RefreshCDU();
                e.SuppressKeyPress = true;
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtEntry.Text == "") return;
            // clear the entry textbox
//            txtEntry.Clear();
            // convert the entered text to an array so we can get at each character
            char [] charArray = txtEntry.Text.ToUpper().ToCharArray();
            foreach (char ch in charArray)
            {
                switch (ch)
                {
                    case 'A':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_A, Aircraft.ClkL);
                        break;
                    case 'B':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_B, Aircraft.ClkL);
                        break;
                    case 'C':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_C, Aircraft.ClkL);
                        break;
                    case 'D':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_D, Aircraft.ClkL);
                        break;
                    case 'E':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_E, Aircraft.ClkL);
                        break;
                    case 'F':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_F, Aircraft.ClkL);
                        break;
                    case 'G':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_G, Aircraft.ClkL);
                        break;
                    case 'H':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_H, Aircraft.ClkL);
                        break;
                    case 'I':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_I, Aircraft.ClkL);
                        break;
                    case 'J':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_J, Aircraft.ClkL);
                        break;
                    case 'K':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_K, Aircraft.ClkL);
                        break;
                    case 'L':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_L, Aircraft.ClkL);
                        break;
                    case 'M':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_M, Aircraft.ClkL);
                        break;
                    case 'N':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_N, Aircraft.ClkL);
                        break;
                    case 'O':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_O, Aircraft.ClkL);
                        break;
                    case 'P':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_P, Aircraft.ClkL);
                        break;
                    case 'Q':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_Q, Aircraft.ClkL);
                        break;
                    case 'R':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_R, Aircraft.ClkL);
                        break;
                    case 'S':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_S, Aircraft.ClkL);
                        break;
                    case 'T':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_T, Aircraft.ClkL);
                        break;
                    case 'U':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_U, Aircraft.ClkL);
                        break;
                    case 'V':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_V, Aircraft.ClkL);
                        break;
                    case 'W':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_W, Aircraft.ClkL);
                        break;
                    case 'X':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_X, Aircraft.ClkL);
                        break;
                    case 'Y':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_Y, Aircraft.ClkL);
                        break;
                    case 'Z':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_Z, Aircraft.ClkL);
                        break;
                    case '1':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_1, Aircraft.ClkL);
                        break;
                    case '2':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_2, Aircraft.ClkL);
                        break;
                    case '3':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_3, Aircraft.ClkL);
                        break;
                    case '4':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_4, Aircraft.ClkL);
                        break;
                    case '5':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_5, Aircraft.ClkL);
                        break;
                    case '6':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_6, Aircraft.ClkL);
                        break;
                    case '7':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_7, Aircraft.ClkL);
                        break;
                    case '8':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_8, Aircraft.ClkL);
                        break;
                    case '9':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_9, Aircraft.ClkL);
                        break;
                    case '0':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_0, Aircraft.ClkL);
                        break;
                    case '.':
                        FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_DOT, Aircraft.ClkL);
                        break;


                }
                Thread.Sleep(50);
                RefreshCDU();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_CLR, Aircraft.ClkL);
            RefreshCDU();
        }

        private void btnInitRef_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_INIT_REF, Aircraft.ClkL);
            RefreshCDU();

        }

        private void btnRte_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_RTE, Aircraft.ClkL);
            RefreshCDU();

        }

        private void btnClb_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_CLB, Aircraft.ClkL);
            RefreshCDU();

        }

        private void btnCrz_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_CRZ, Aircraft.ClkL);
            RefreshCDU();

        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_DES, Aircraft.ClkL);
            RefreshCDU();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_MENU, Aircraft.ClkL);
            RefreshCDU();

        }

        private void btnLegs_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_LEGS, Aircraft.ClkL);
            RefreshCDU();

        }

        private void btnDepArr_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_DEP_ARR, Aircraft.ClkL);
            RefreshCDU();

        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_HOLD, Aircraft.ClkL);
            RefreshCDU();

        }

        private void btnProg_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_PROG, Aircraft.ClkL);
            RefreshCDU();

        }

        private void btnExec_Click_1(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_EXEC, Aircraft.ClkL);
            RefreshCDU();

        }

        private void btnN1Limit_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_N1_LIMIT, Aircraft.ClkL);
            RefreshCDU();

        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_FIX, Aircraft.ClkL);
            RefreshCDU();

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_NEXT_PAGE, 0x20000000);
            RefreshCDU();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_PREV_PAGE, 0x20000000);
            RefreshCDU();

        }

        private void txtEntry_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control && e.KeyCode == Keys.A)) return;

            switch (e.KeyCode)
            {
                case Keys.A:
                    
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_A, Aircraft.ClkL);
                    break;
                case Keys.B:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_B, Aircraft.ClkL);
                    break;
                case Keys.C:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_C, Aircraft.ClkL);
                    break;
                case Keys.D:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_D, Aircraft.ClkL);
                    break;
                case Keys.E:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_E, Aircraft.ClkL);
                    break;
                case Keys.F:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_F, Aircraft.ClkL);
                    break;
                case Keys.G:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_G, Aircraft.ClkL);
                    break;
                case Keys.H:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_H, Aircraft.ClkL);
                    break;
                case Keys.I:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_I, Aircraft.ClkL);
                    break;
                case Keys.J:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_J, Aircraft.ClkL);
                    break;
                case Keys.K:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_K, Aircraft.ClkL);
                    break;
                case Keys.L:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_L, Aircraft.ClkL);
                    break;
                case Keys.M:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_M, Aircraft.ClkL);
                    break;
                case Keys.N:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_N, Aircraft.ClkL);
                    break;
                case Keys.O:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_O, Aircraft.ClkL);
                    break;
                case Keys.P:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_P, Aircraft.ClkL);
                    break;
                case Keys.Q:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_Q, Aircraft.ClkL);
                    break;
                case Keys.R:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_R, Aircraft.ClkL);
                    break;
                case Keys.S:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_S, Aircraft.ClkL);
                    break;
                case Keys.T:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_T, Aircraft.ClkL);
                    break;
                case Keys.U:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_U, Aircraft.ClkL);
                    break;
                case Keys.V:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_V, Aircraft.ClkL);
                    break;
                case Keys.W:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_W, Aircraft.ClkL);
                    break;
                case Keys.X:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_X, Aircraft.ClkL);
                    break;
                case Keys.Y:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_Y, Aircraft.ClkL);
                    break;
                case Keys.Z:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_Z, Aircraft.ClkL);
                    break;
                case Keys.D1:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_1, Aircraft.ClkL);
                    break;
                case Keys.D2:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_2, Aircraft.ClkL);
                    break;
                case Keys.D3:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_3, Aircraft.ClkL);
                    break;
                case Keys.D4:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_4, Aircraft.ClkL);
                    break;
                case Keys.D5:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_5, Aircraft.ClkL);
                    break;
                case Keys.D6:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_6, Aircraft.ClkL);
                    break;
                case Keys.D7:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_7, Aircraft.ClkL);
                    break;
                case Keys.D8:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_8, Aircraft.ClkL);
                    break;
                case Keys.D9:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_9, Aircraft.ClkL);
                    break;
                case Keys.D0:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_0, Aircraft.ClkL);
                    break;
                case Keys.OemPeriod:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_DOT, Aircraft.ClkL);
                    break;
                case Keys.Space:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_SPACE, Aircraft.ClkL);
                    break;
                case Keys.OemQuestion:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_SLASH, Aircraft.ClkL);
                    break;
                case Keys.Oemplus:
                    // send key twice to get plus symbol
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_PLUS_MINUS, Aircraft.ClkL);
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_PLUS_MINUS, Aircraft.ClkL);
                    break;
                case Keys.OemMinus:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CDU_L_PLUS_MINUS, Aircraft.ClkL);
                    break;
                case Keys.Back:
                    FSUIPCConnection.SendControlToFS(PMDG_747QOTSII_Control.EVT_CDU_L_DEL, Aircraft.ClkL);
                    break;

            }

        }

        private void txtCDU_Leave(object sender, EventArgs e)
        {
            cduCursorPosition = txtCDU.SelectionStart;
        }

        private void txtCDU_Enter(object sender, EventArgs e)
        {
            txtCDU.SelectionStart = cduCursorPosition;
        }
    }

        
    }
