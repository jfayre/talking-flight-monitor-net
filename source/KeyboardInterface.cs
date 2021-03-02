using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using NAudio.Wave;
using NHotkey;
using NHotkey.Wpf;
using SimConnector;

namespace tfm
{
    class KeyboardInterface
    {
        SimData sim = new SimData();
        // audio player objects
        WaveFileReader cmdSound;
        WaveFileReader apCmdSound;
        // list to store registered hotkey identifiers
        List<string> hotkeys = new List<string>();
        List<string> autopilotHotkeys = new List<string>();

        public KeyboardInterface()
        {
            KeyConverter kc = new KeyConverter();
            ModifierKeysConverter mc = new ModifierKeysConverter();
            Key k;
            ModifierKeys m;
            string[] cmdkey = Properties.Hotkeys.Default.Command_Key.Split('+');
            if (cmdkey.Count() == 1)
            {
                k = (Key)kc.ConvertFromString(cmdkey[0]);
                HotkeyManager.Current.AddOrReplace("Command_Key", k, ModifierKeys.None, commandMode);
            }

        }

        private void commandMode(object sender, HotkeyEventArgs e)
        {
            // Check to see if we are connected to the sim
            if (sim.IsConnectionOpen || utility.DebugEnabled)
            {
                // remove the left bracket autopilot command
                HotkeyManager.Current.Remove("ap_Command_Key");
                // play the command sound
                cmdSound = new WaveFileReader(@"sounds\command.wav");
                mixer.AddMixerInput(cmdSound);
                // populate a list of hotkeys, so we can clear them later.
                foreach (SettingsProperty s in Properties.Hotkeys.Default.Properties)
                {
                    if (s.Name == "Command_Key") continue;
                    if (s.Name.StartsWith("ap_")) continue;
                    hotkeys.Add(s.Name);
                    try
                    {
                        HotkeyManager.Current.AddOrReplace(s.Name, (Keys)Properties.Hotkeys.Default[s.Name], onKeyPressed);
                    }
                    catch (NHotkey.HotkeyAlreadyRegisteredException ex)
                    {
                        logger.Debug($"Cannot register {s.Name}. Probably duplicated key.");
                        fireOnScreenReaderOutputEvent(isGauge: false, output: $"hotkey error in {s.Name}");
                    }

                }




            }
            else
            {
                Tolk.Output("not connected to simulator");

            }

        }
    }
}
