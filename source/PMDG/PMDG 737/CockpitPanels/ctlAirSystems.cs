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
    public partial class ctlAirSystems : UserControl, iPanelsPage
    {
        public ctlAirSystems()
        {
            InitializeComponent();
            tmrAir.Start();
        }

        public void SetDocking()
        {
            
        }

        private void tmrAir_Tick(object sender, EventArgs e)
        {
            
        }

        private void radPacLeft_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radPacRight_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTrimAir_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkRecircLeft_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkRecircRight_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkAPUBleed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkEng1Bleed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkEng2Bleed_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
