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
            tmrEngines.Start();
        }
        

        private void tmrEngines_Tick(object sender, EventArgs e)
        {
            Aircraft.pmdg737.RefreshData();
            // engine 1 starter
            utility.UpdateControl(Aircraft.pmdg737.ENG_StartSelector[0].Value == 0, radEng1Grd);
            utility.UpdateControl(Aircraft.pmdg737.ENG_StartSelector[0].Value == 1, radEng1Auto);
            utility.UpdateControl(Aircraft.pmdg737.ENG_StartSelector[0].Value == 2, radEng1Cont);
            utility.UpdateControl(Aircraft.pmdg737.ENG_StartSelector[0].Value == 3, radEng1Flt);
            // engine 2 starter
            utility.UpdateControl(Aircraft.pmdg737.ENG_StartSelector[1].Value == 0, radEng2Grd);
            utility.UpdateControl(Aircraft.pmdg737.ENG_StartSelector[1].Value == 1, radEng2Auto);
            utility.UpdateControl(Aircraft.pmdg737.ENG_StartSelector[1].Value == 2, radEng2Cont);
            utility.UpdateControl(Aircraft.pmdg737.ENG_StartSelector[1].Value == 3, radEng2Flt);
            // engine 1 fuel
            utility.UpdateControl(FSUIPCConnection.ReadLVar("switch_688_73X") == 100, radEng1CutOff);
            utility.UpdateControl(FSUIPCConnection.ReadLVar("switch_688_73X") == 0, radEng1Idle);
            // engine 2 fuel
            utility.UpdateControl(FSUIPCConnection.ReadLVar("switch_689_73X") == 100, radEng2CutOff);
            utility.UpdateControl(FSUIPCConnection.ReadLVar("switch_689_73X") == 0, radEng2Idle);


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
