using DavyKager;
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
    public partial class ctlAircraft : UserControl, iSettingsPage
    {
        public ctlAircraft()
        {
            InitializeComponent();
        }

        public void SetDocking()
        {
            
        }

        private void ctlAircraft_Load(object sender, EventArgs e)
        {
switch(Properties.Settings.Default.takeOffAssistMode)
            {
                case "off":
                    takeoffAssistDropDown.SelectedIndex = 0;
                    break;
                case "partial":
                    takeoffAssistDropDown.SelectedIndex = 1;
                    break;
                case "full":
                    takeoffAssistDropDown.SelectedIndex = 2;
                    break;
                default:
                    MessageBox.Show("There is a problem loading aircraft settings. Try again later.");
                    break;                    
            }
        }

        private void takeoffAssistDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Tolk.DetectScreenReader() == "NVDA")
            {
                Tolk.Output(takeoffAssistDropDown.SelectedItem.ToString());
            }
                        switch(takeoffAssistDropDown.SelectedIndex)
            {
                case 0:
                    Properties.Settings.Default.takeOffAssistMode = "off";
                    break;
                case 1:
                    Properties.Settings.Default.takeOffAssistMode = "partial";
                    break;
                case 2:
                    Properties.Settings.Default.takeOffAssistMode = "full";
                    break;
default:
                    MessageBox.Show("There is a problem displaying aircraft settings. Try again later.");
                    break;
            }
        }
    }
}
