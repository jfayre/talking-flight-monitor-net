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

namespace tfm
{
    public partial class frmFuelManager : Form
    {
        FsFuelTanksCollection FuelTanks = null;
        // list to store fuel tanks present on the aircraft
        List<FsFuelTank> ActiveTanks = new List<FsFuelTank>();
        PayloadServices ps = FSUIPCConnection.PayloadServices;
        // Create a variable to hold the payload station data
        List<FsPayloadStation> payloadStations = null;

        public frmFuelManager()
        {
            InitializeComponent();
            
        }

        private void frmFuelManager_Load(object sender, EventArgs e)
        {
            txtTankWeight.Enabled = false;
            btnSetFuelTank.Enabled = false;
            this.Activate();
            getLoadData();
            refreshTankList();
            refreshPayloadList();
        }

        private void refreshPayloadList()
        {
            // clear the current list view on the form
            this.lvPayload.Items.Clear();
            if (this.payloadStations != null)
            {
                // Add each station to the list view
                foreach (FsPayloadStation station in this.payloadStations)
                {
                    // For each station create a new list item using the name of the station
                    ListViewItem newItem = new ListViewItem(station.Name);
                    // Set the weight as the first subitem
                    string weight = "";
                    if (Properties.Settings.Default.UseMetric)
                    {
                        weight = station.WeightKgs.ToString("F2") + " KG";
                    }
                    else
                    {
                        weight = station.WeightLbs.ToString("F2") + " lbs";
                    }
                    newItem.SubItems.Add(weight);
                    // add to the list
                    this.lvPayload.Items.Add(newItem);
            }
                // select the first item in the list
                lvPayload.Items[0].Selected = true;
            }

    }


    private void getLoadData()
        {
            // grab fuel and payload data from the sim
            FSUIPCConnection.PayloadServices.RefreshData();
            // Assign the fuel tanks to our class level variable for easier access
            FuelTanks = FSUIPCConnection.PayloadServices.FuelTanks;
            // Assign the payload stations to our class level variable for easier access
            this.payloadStations = FSUIPCConnection.PayloadServices.PayloadStations;

            foreach (FsFuelTank tank in FuelTanks)
            {
                if (tank.IsPresent)
                {
                    ActiveTanks.Add(tank);
                }
            }

        }
private void refreshTankList()
        {
            lvFuel.Items.Clear();
            foreach (FsFuelTank tank in ActiveTanks)
            {
                ListViewItem newItem = new ListViewItem(tank.Tank.ToString().Replace("_", " "));
                if (Properties.Settings.Default.UseMetric)
                {
                    newItem.SubItems.Add(tank.WeightKgs.ToString("F0") + " KG");
                    newItem.SubItems.Add(tank.CapacityKgs.ToString("F0")+ " KG");
                }
                else
                {
                    newItem.SubItems.Add(tank.WeightLbs.ToString("F0")+ " LB");
                    newItem.SubItems.Add(tank.CapacityLbs.ToString("F0") + " LB");

                }                
                newItem.SubItems.Add(tank.LevelPercentage.ToString("F1"));
                lvFuel.Items.Add(newItem);
            }
            lvFuel.Items[0].Selected = true;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double blockWeight = double.Parse(txtBlockWeight.Text);
            if (Properties.Settings.Default.UseMetric)
            {
                double fuelOver = ps.LoadFuelKgs(blockWeight, true);
                if (fuelOver > 0)
                {
                    MessageBox.Show("Over capacity by " + fuelOver.ToString("F1") + " kilograms. ", "warning", MessageBoxButtons.OK);
                }
            }
            else
            {
                double fuelOver = ps.LoadFuelLbs(blockWeight, true);
                if (fuelOver > 0)
                {
                    MessageBox.Show("Over capacity by " + fuelOver.ToString("F1") + " pounds.", "warning", MessageBoxButtons.OK);
                }
                checkWeight();

            }

            refreshTankList(); 

        }

        private void checkWeight()
        {
            if (ps.GrossWeightKgs > ps.MaxGrossWeightKgs)
            {
                if (Properties.Settings.Default.UseMetric)
                {
                    double overage = ps.GrossWeightKgs - ps.MaxGrossWeightKgs;
                    MessageBox.Show("aircraft overweight by " + overage.ToString("F1") + " kilograms. ", "warning", MessageBoxButtons.OK);

                }
                else
                {
                    double overage = ps.GrossWeightLbs - ps.MaxGrossWeightLbs;
                    MessageBox.Show("aircraft overweight by " + overage.ToString("F1") + " pounds. ", "warning", MessageBoxButtons.OK);

                }
            }
        }

        private void LvFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvFuel.SelectedIndices.Count > 0)
            {
                txtTankWeight.Enabled = true;
                btnSetFuelTank.Enabled = true;
                int index = this.lvFuel.SelectedIndices[0];
                FsFuelTank tank = ActiveTanks[index];
                lblTankWeight.Text = lvFuel.SelectedItems[0].Text;
                if (Properties.Settings.Default.UseMetric)
                {
                    txtTankWeight.Text = tank.WeightKgs.ToString("F0");
                }
                else
                {
                    txtTankWeight.Text = tank.WeightLbs.ToString("F0");
                }
                
            }

        }

        private void BtnSetFuelTank_Click(object sender, EventArgs e)
        {
            int index = this.lvFuel.SelectedIndices[0];
            FsFuelTank tank = ActiveTanks[index];
            if (Properties.Settings.Default.UseMetric)
            {
                tank.WeightKgs = double.Parse(txtTankWeight.Text);
            }
            else
            {
                tank.WeightLbs = double.Parse(txtTankWeight.Text);
            }
            ps.WriteChanges();
            checkWeight();

            refreshTankList();
            lvFuel.Focus();
            
        }

        private void lvPayload_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvPayload.SelectedIndices.Count > 0)
            {
                txtStationWeight.Enabled = true;
                int index = this.lvPayload.SelectedIndices[0];
                FsPayloadStation station = payloadStations[index];
                lblStation.Text = lvPayload.SelectedItems[0].Text;
                if (Properties.Settings.Default.UseMetric)
                {
                    txtStationWeight.Text = station.WeightKgs.ToString("F0");
                }
                else
                {
                    txtStationWeight.Text = station.WeightLbs.ToString("F0");
                }
                
            }

        }

        private void btnSetStation_Click(object sender, EventArgs e)
        {
            int index = this.lvPayload.SelectedIndices[0];
            FsPayloadStation station = payloadStations[index];
            if (Properties.Settings.Default.UseMetric)
            {
                station.WeightKgs = double.Parse(txtStationWeight.Text);
            }
            else
            {
                station.WeightLbs = double.Parse(txtStationWeight.Text);
            }
            ps.WriteChanges();
            checkWeight();
            refreshPayloadList();   
            lvPayload.Focus();

        }
    }
}
