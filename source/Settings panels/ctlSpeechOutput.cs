using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
namespace tfm
{
    public partial class ctlSpeechOutput : UserControl, iSettingsPage
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();

        public ctlSpeechOutput()
        {
            InitializeComponent();

        }

        public void SetDocking()
        {
            
        }
        private void ctlSpeechOutput_Load(object sender, EventArgs e)
        {
switch (Properties.Settings.Default.AttitudeAnnouncementMode)
            {
                case 1:
                    radTones.Checked = true;
                    break;
                case 2:
                    radSpeech.Checked = true;
                    break;
                case 3:
                    radBoth.Checked = true;
                    break;
            }
            trkSpeechRate.Value = Properties.Settings.Default.SAPISpeechRate + 10;
        }

        private void trkSpeechRate_Scroll(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            int val = trkSpeechRate.Value;
            synth.SpeakAsync("rate " + val);
            val = val - 10;
            Properties.Settings.Default.SAPISpeechRate = val;
            synth.Rate = val;
            
        }

        private void radTones_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                Properties.Settings.Default.AttitudeAnnouncementMode = 1;
            }

        }

        private void radSpeech_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                Properties.Settings.Default.AttitudeAnnouncementMode = 2;
            }


        }

        private void radBoth_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                Properties.Settings.Default.AttitudeAnnouncementMode = 3;
            }

        }

        private void radSpeechSystem_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
switch (rb.Name)
            {
                case "radScreenReader":
                    Properties.Settings.Default.SpeechSystem = "ScreenReader";
                    break;
                case "radSAPI":
                    Properties.Settings.Default.SpeechSystem = "sAPI";
                    break;
                case "radAzureSpeech":
                    Properties.Settings.Default.SpeechSystem = "Azure";
                    break;


            }
        }
    }
}
