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
            lstVoices.BeginUpdate();
            foreach (var voice in voices)
            {
                lstVoices.Items.Add(voice.ShortName);
            }
            lstVoices.EndUpdate();
            lstVoices.SelectedIndex = 0;
        }

        private void lstVoices_SelectedIndexChanged(object sender, EventArgs e)
        {
             SelectedVoice = lstVoices.SelectedItem.ToString();
        }

        private async void btnSample_Click(object sender, EventArgs e)
        {
            string voice = lstVoices.SelectedItem.ToString();
            config.SpeechSynthesisVoiceName = voice;
using (var synth  = new SpeechSynthesizer(config))
            {
var result = await synth.SpeakTextAsync("This is the currently selected voice");


            }
        }
    }
}
