using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
namespace tfm
{
    public partial class frmSelectAzureVoice : Form
    {
        private ReadOnlyCollection<VoiceInfo> voices;
        private SpeechConfig config;
        public string SelectedVoice;
        public frmSelectAzureVoice(ReadOnlyCollection<Microsoft.CognitiveServices.Speech.VoiceInfo> voices, SpeechConfig config)
        {
            this.voices = voices;
            this.config = config;
            InitializeComponent();
        }

        private void frmSelectAzureVoice_Load(object sender, EventArgs e)
        {
            lvVoices.BeginUpdate();
            foreach (var voice in voices)
            {
                string location = null;
                int index = 0;
                if (voice.ShortName.StartsWith("en-"))
                {
                    switch (voice.Locale)
                    {
                        case "en-US":
                            location = "US";
                            break;
                        case "en-AU":
                            location = "Australia";
                            break;
                        case "en-CA":
                            location = "Canada";
                            break;

                        case "en-GB":
                            location = "UK";
                            break;
                        case "en-IE":
                            location = "Ireland";
                            break;
                        case "en-IN":
                            location = "India";
                            break;



                    }
                    ListViewItem item = new ListViewItem();
                    if (voice.Name.Contains("Neural"))
                    {
                        item.Text = $"{voice.LocalName} - Neural - {location}";
                    }
                    else
                    {
                        item.Text = $"{voice.LocalName} - {location}";
                    }
                    
                    item.Tag = voice.ShortName;
                    lvVoices.Items.Add(item);
                }

            }
            lvVoices.EndUpdate();
        }

        
        private async void btnSample_Click(object sender, EventArgs e)
        {
            string voice = lvVoices.SelectedItems[0].Tag.ToString();
            config.SpeechSynthesisVoiceName = voice;
            using (var synth  = new SpeechSynthesizer(config))
            {
                using (var result = await synth.SpeakTextAsync("This is the currently selected voice"))
                {
                    if (result.Reason == ResultReason.Canceled)
                    {
                        var cancellation = SpeechSynthesisCancellationDetails.FromResult(result);
                        MessageBox.Show($"{cancellation.Reason}");

                    }
                }


            }
        }

        private void lvVoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection voice = lvVoices.SelectedItems;
            foreach (ListViewItem item in voice)
            {
                SelectedVoice = item.Tag.ToString();
            }
        }
    }
}
