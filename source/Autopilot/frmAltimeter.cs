using DavyKager;
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
    public partial class frmAltimeter : Form
    {
        InstrumentPanel inst = new InstrumentPanel();
        public frmAltimeter()
        {
            InitializeComponent();
        }

        private void frmAltimeter_Load(object sender, EventArgs e)
        {
            this.Activate();
            double AltQNH = (double)Aircraft.Altimeter.Value / 16d;
            double AltHPA = Math.Floor(AltQNH + 0.5);
            double AltInches = Math.Floor(((100 * AltQNH * 29.92) / 1013.2) + 0.5);
            txtInches.Text = $"{AltInches / 100}";
            txtQNH.Text = $"{AltHPA}";

        }

        
        private void btnInches_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtInches.Text, out double inches) && inches >= 28.00 && inches <= 31.00)
                    {
                inst.AltimeterInches = inches;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                Tolk.Output("Invalid Altimeter Inches setting.");
            }
        }

        private void btnQNH_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtQNH.Text, out double qnh) && qnh >= 940 && qnh <= 1050)
            {
                inst.AltimeterQNH = qnh;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                Tolk.Output("Invalid Altimeter QNH setting.");
            }

        }
    }
    }
