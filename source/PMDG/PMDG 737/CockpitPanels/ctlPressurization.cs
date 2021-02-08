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
    public partial class ctlPressurization : UserControl, iPanelsPage
    {
        public ctlPressurization()
        {
            InitializeComponent();
        }

        public void SetDocking()
        {

        }

        


        private void btnSetLandingAlt_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSetCrzAlt_Click(object sender, EventArgs e)
        {

        }

        private void ctlPressurization_Load(object sender, EventArgs e)
        {
            tmrPressurization.Start();
            txtCrzAlt.Text = Aircraft.AIR_DisplayFltAlt.Value;
            txtLandAlt.Text = Aircraft.AIR_DisplayLandAlt.Value;

        }

        private void tmrPressurization_Tick(object sender, EventArgs e)
        {

        }

        private void txtCrzAlt_Enter(object sender, EventArgs e)
        {
        }
    }
}
