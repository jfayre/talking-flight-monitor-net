using FSUIPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tfm
{
    public partial class ctlEngines : UserControl, iPanelsPage
    {
        pmdg pmdg = new pmdg();
        public ctlEngines()
        {
            InitializeComponent();
        }

        public void SetDocking()
        {
            
        }

        private void ctlEngines_Load(object sender, EventArgs e)
        {

        }
        

        private void tmrEngines_Tick(object sender, EventArgs e)
        {

        }

        private void btnEng1Start_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Left:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_LIGHTS_L_ENGINE_START, Aircraft.ClkL);
                    break;
                case Keys.Right:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_LIGHTS_L_ENGINE_START, Aircraft.ClkR);
                    break;
            }
        }

        private void btnEng1Fuel_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CONTROL_STAND_ENG1_START_LEVER, Aircraft.ClkL);
                    break;

                case Keys.Right:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CONTROL_STAND_ENG1_START_LEVER, Aircraft.ClkR);
                    break;

            }

        }

        private void btnEng2Start_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_LIGHTS_R_ENGINE_START, Aircraft.ClkL);
                    break;
                case Keys.Right:
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_LIGHTS_R_ENGINE_START, Aircraft.ClkR);
                    break;
            }
        }

    private void btnEng2Fuel_KeyDown(object sender, KeyEventArgs e)
    {

        switch (e.KeyCode)
        {
            case Keys.Left:
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CONTROL_STAND_ENG2_START_LEVER, Aircraft.ClkL);
                break;

            case Keys.Right:
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CONTROL_STAND_ENG2_START_LEVER, Aircraft.ClkR);
                break;

        }
    }

        private void radEng1Start_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "radEng1Grd":
                        pmdg.Eng1StartGrd();
                        break;
                    case "radEng1Auto":
                        pmdg.Eng1StartAuto();
                        break;
                    case "radEng1Cont":
                        pmdg.Eng1StartCont();
                        break;
                    case "radEng1Flt":
                        pmdg.Eng1StartFlt();
                        break;

                }
            }
        }

        private void radEng2Start_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "radEng2Grd":
                        pmdg.Eng2StartGrd();
                        break;
                    case "radEng2Auto":
                        pmdg.Eng2StartAuto();
                        break;
                    case "radEng2Cont":
                        pmdg.Eng2StartCont();
                        break;
                    case "radEng2Flt":
                        pmdg.Eng2StartFlt();
                        break;

                }
            }
        }
        
        private void radEng1Fuel_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "radEng1Idle":
                        pmdg.Eng1FuelIdle();
                        break;
                    case "radEng1CutOff":
                        pmdg.Eng1FuelCutOff();
                        break;
                        

                }

            }

            }
        private void radEng2Fuel_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "radEng2Idle":
                        pmdg.Eng2FuelIdle();
                        break;
                    case "radEng2CutOff":
                        pmdg.Eng2FuelCutOff();
                        break;


                }

            }

        }
    }
}
