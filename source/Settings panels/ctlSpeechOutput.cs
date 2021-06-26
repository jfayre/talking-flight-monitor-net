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
// using Microsoft.CognitiveServices.Speech;
using System.Collections.ObjectModel;

namespace tfm
{
    public partial class ctlSpeechOutput : UserControl, iSettingsPage
    {
        System.Speech.Synthesis.SpeechSynthesizer synthSAPI = new System.Speech.Synthesis.SpeechSynthesizer();

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
            switch (Properties.Settings.Default.SpeechSystem)
            {
                case "ScreenReader":
                    radScreenReader.Checked = true;
                    break;
                case "SAPI":
                    radSAPI.Checked = true;
                    break;
                case "Azure":
                    radAzureSpeech.Checked = true;
                    grpAzure.Enabled = true;
                    if (Properties.Settings.Default.AzureVoice != "")
                    {
                        txtVoice.Text = Properties.Settings.Default.AzureVoice;
                    }
                    break;
                        
            }
            switch (Properties.Settings.Default.FallbackSpeechSystem)
            {
                case "ScreenReader":
                    radFBScreenReader.Checked = true;
                    break;
                case "SAPI":
                    radFBSAPI.Checked = true;
                    break;

            }

        }

        private void trkSpeechRate_Scroll(object sender, EventArgs e)
        {
            synthSAPI.SpeakAsyncCancelAll();
            int val = trkSpeechRate.Value;
            synthSAPI.SpeakAsync("rate " + val);
            val = val - 10;
            Properties.Settings.Default.SAPISpeechRate = val;
            synthSAPI.Rate = val;
            
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
                    grpAzure.Enabled = false;
                    break;
                case "radSAPI":
                    Properties.Settings.Default.SpeechSystem = "sAPI";
                    grpAzure.Enabled = false;
                    break;
                /* Disabling azure for now while we debug.
                 * case "radAzureSpeech":
                    Properties.Settings.Default.SpeechSystem = "Azure";
                    grpAzure.Enabled = true;
                    break;
*/

            }
        }

        private async void btnVoice_Click(object sender, EventArgs e)
        {
                /* SpeechConfig config = null;
            Microsoft.CognitiveServices.Speech.SpeechSynthesizer synthesizer = null;
            if (txtKey.Text == "" || txtRegion.Text == "")
            {
                MessageBox.Show("Both Key and Region fields are required.");
                return;
            }
            else
            {
                // Creates an instance of a speech config with specified subscription key and service region.
                config = SpeechConfig.FromSubscription(txtKey.Text, txtRegion.Text);
                synthesizer = new Microsoft.CognitiveServices.Speech.SpeechSynthesizer(config);

            }
            using (var result = await synthesizer.GetVoicesAsync(""))
            {
                if (result.Reason == ResultReason.VoicesListRetrieved)
                {
                    // API key and region are valid. Open the form to select a voice, passing in the voices list and config object.
                    System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.CognitiveServices.Speech.VoiceInfo> VoicesList = result.Voices;
                    frmSelectAzureVoice frm = new frmSelectAzureVoice(VoicesList, config);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        if (frm.SelectedVoice != null)
                        {
                            Properties.Settings.Default.AzureVoice = frm.SelectedVoice;
                        }
                        
                    }

                }
                else if (result.Reason == ResultReason.Canceled)
                {
                    MessageBox.Show($"Error retrieving voices list: {result.ErrorDetails}");
                }


            }
*/
        }

        private void radFallbackSpeech_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "radFBScreenReader":
                        Properties.Settings.Default.FallbackSpeechSystem = "ScreenReader";
                        break;
                    case "radFBSAPI":
                        Properties.Settings.Default.FallbackSpeechSystem = "SAPI";
                        break;

                }
            }
        }
    }
}
