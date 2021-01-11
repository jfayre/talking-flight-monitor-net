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
        pmdg pmdg = new pmdg();

        public ctlAirSystems()
        {
            InitializeComponent();

        }

        public void SetDocking()
        {

        }

        private void RefreshLights()
        {
            Dictionary<string, bool> PanelLights = new Dictionary<string, bool>()
{
    {"zone 1 temperature", Aircraft.pmdg737.AIR_annunZoneTemp[0].Value > 0 },
    {"zone 2 temperature", Aircraft.pmdg737.AIR_annunZoneTemp[1].Value > 0 },
    {"zone 3 temperature", Aircraft.pmdg737.AIR_annunZoneTemp[2].Value > 0 },
                { "dual bleed", Aircraft.pmdg737.AIR_annunDualBleed.Value > 0 },
                { "Ram door left", Aircraft.pmdg737.AIR_annunRamDoorL.Value > 0 },
                { "Ram door right", Aircraft.pmdg737.AIR_annunRamDoorR.Value > 0 },
                { "Pack left tripped", Aircraft.pmdg737.AIR_annunPackTripOff[0].Value > 0 },
                { "Pack right tripped", Aircraft.pmdg737.AIR_annunPackTripOff[1].Value > 0 },
                { "left wing body overheat", Aircraft.pmdg737.AIR_annunWingBodyOverheat[0].Value > 0 },
                { "right wing body overheat", Aircraft.pmdg737.AIR_annunWingBodyOverheat[1].Value > 0 },
                { "Air bleed 1 trip", Aircraft.pmdg737.AIR_annunBleedTripOff[0].Value > 0 },
                        { "Air bleed 2 trip", Aircraft.pmdg737.AIR_annunBleedTripOff[1].Value > 0 },


};
            foreach (string item in PanelLights.Keys)
            {
                if (PanelLights[item])
                {
                    lvLights.Items.Add(item).SubItems.Add("On");
                }
                else
                {
                    lvLights.Items.Add(item).SubItems.Add("Off");
                }
            }
    }
        private void tmrAir_Tick(object sender, EventArgs e)
        {
            Aircraft.pmdg737.RefreshData();
            // update controls on the form based on current aircraft status
            // left aircon pack
            utility.UpdateControl(Aircraft.pmdg737.AIR_PackSwitch[0].Value == 0, radPackLeftOff);
            utility.UpdateControl(Aircraft.pmdg737.AIR_PackSwitch[0].Value == 1, radPackLeftAuto);
            utility.UpdateControl(Aircraft.pmdg737.AIR_PackSwitch[0].Value == 2, radPackLeftHigh);
            // right aircon pack
            utility.UpdateControl(Aircraft.pmdg737.AIR_PackSwitch[1].Value == 0, radPackRightOff);
            utility.UpdateControl(Aircraft.pmdg737.AIR_PackSwitch[1].Value == 1, radPackRightAuto);
            utility.UpdateControl(Aircraft.pmdg737.AIR_PackSwitch[1].Value == 2, radPackRightHigh);
            // recirc fans
            utility.UpdateControl(Aircraft.pmdg737.AIR_RecircFanSwitch[0].Value > 0, chkRecircLeft);
            utility.UpdateControl(Aircraft.pmdg737.AIR_RecircFanSwitch[1].Value > 0, chkRecircRight);
            // trim air
            utility.UpdateControl(Aircraft.pmdg737.AIR_TrimAirSwitch.Value > 0, chkTrimAir);
            // air bleeds
            utility.UpdateControl(Aircraft.pmdg737.AIR_APUBleedAirSwitch.Value > 0, chkAPUBleed);
            utility.UpdateControl(Aircraft.pmdg737.AIR_BleedAirSwitch[0].Value > 0, chkEng1Bleed);
            utility.UpdateControl(Aircraft.pmdg737.AIR_BleedAirSwitch[1].Value > 0, chkEng2Bleed);


        }

        private void radPacLeft_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "radPackLeftOff":
                        pmdg.PackLeftOff();
                        break;
                    case "radPackLeftAuto":
                        pmdg.PackLeftAuto();
                        break;
                    case "radPackLeftHigh":
                        pmdg.PackLeftHigh();
                        break;

                }
            }


        }

        private void radPacRight_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "radPackRightOff":
                        pmdg.PackRightOff();
                        break;
                    case "radPackRightAuto":
                        pmdg.PackRightAuto();
                        break;
                    case "radPackRightHigh":
                        pmdg.PackRightHigh();
                        break;

                }
            }


        }

        private void chkTrimAir_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTrimAir.Checked)
            {
                pmdg.TrimAirOn();
            }
            else
            {
                pmdg.TrimAirOff();
            }

        }

        private void chkRecircLeft_CheckedChanged(object sender, EventArgs e)
        {
if (chkRecircLeft.Checked)
            {
                pmdg.RecircLeftOn();

            }
            else
            {
                pmdg.RecircLeftOff();
            }

        }

        private void chkRecircRight_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRecircRight.Checked)
            {
                pmdg.RecircRightOn();
            }
            else
            {
                pmdg.RecircRightOff();
            }

        }

        private void chkAPUBleed_CheckedChanged(object sender, EventArgs e)
        {
if (chkAPUBleed.Checked)
            {
                pmdg.APUBleedOn();
            }
            else
            {
                pmdg.APUBleedOff();
            }
        }

        private void chkEng1Bleed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEng1Bleed.Checked)
            {
                pmdg.Engine1BleedOn();
            }
            else
            {
                pmdg.Engine1BleedOff();
            }

        }

        private void chkEng2Bleed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEng2Bleed.Checked)
            {
                pmdg.Engine2BleedOn();
            }
            else
            {
                pmdg.Engine2BleedOff();
            }


        }

        private void ctlAirSystems_Load(object sender, EventArgs e)
        {
            tmrAir.Start();
            RefreshLights();

        }
    }
}
