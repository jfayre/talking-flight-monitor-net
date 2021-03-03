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
        // Get an instance of SimData class to grab data from the slight sim
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

        private void onKeyPressed(object sender, HotkeyEventArgs e)
        {

            e.Handled = true;
            ResetHotkeys();
            switch (e.Name)
            {
                case "flight_planner":
                    var isPlannerActive = false;
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is FlightPlanForm)
                        {
                            isPlannerActive = true;
                            break;
                        }
                    }
                    if (isPlannerActive)
                    {
                        fireOnScreenReaderOutputEvent(isGauge: false, output: "Flight planner is already open!");
                        break;
                    }
                    else
                    {
                        FlightPlanForm fp = new FlightPlanForm();
                        fp.ShowDialog();
                        isPlannerActive = true;
                        break;
                    }
                    isPlannerActive = false;
                    break;
                case "takeoff_assist":
                    onTakeOffAssistant();
                    break;
                case "ASL_Altitude":
                    onASLKey();
                    break;
                case "Fuel_Manager":
                    if (fuelManagerActive)
                    {
                        fireOnScreenReaderOutputEvent(isGauge: false, output: "fuel manager already open");
                        break;
                    }
                    frmFuelManager frm = new frmFuelManager();
                    fuelManagerActive = true;
                    frm.ShowDialog();
                    fuelManagerActive = false;
                    break;

                case "Current_Location":
                    onCurrentLocation();
                    break;
                case "AGL_Altitude":
                    onAGLKey();
                    break;
                case "Disable_Command_Key":
                    fireOnScreenReaderOutputEvent(isGauge: false, output: "command key disabled.");
                    CommandKeyEnabled = false;
                    break;

                case "Aircraft_Heading":
                    onHeadingKey();
                    break;
                case "Indicated_Airspeed":
                    onIASKey();
                    break;
                case "Read_Simulation_Rate":
                    ReadSimulationRate(true);
                    break;
                case "Ground_Speed":
                    onGroundSpeedKey();
                    break;

                case "True_Airspeed":
                    onTASKey();
                    break;
                case "Mach_Speed":
                    onMachKey();
                    break;
                case "Vertical_Speed":
                    onVSpeedKey();
                    break;
                case "Landing_Rate":
                    onLandingRateKey();
                    break;

                case "Outside_Temperature":
                    onAirtempKey();
                    break;
                case "Toggle_Trim_Announcement":
                    onTrimKey();
                    break;
                case "Mute_Simconnect_Messages":
                    onMuteSimconnectKey();
                    break;
                case "Repeat_Last_Simconnect_Message":
                    onRepeatLastSimconnectMessage();
                    break;
                case "Output_History":
                    frmOutputHistory frmHistory = new frmOutputHistory();
                    frmHistory.ShowDialog();
                    break;

                case "Nearest_City":
                    onCityKey();
                    break;
                case "Next_Waypoint":
                    onWaypointKey();
                    break;
                case "Destination_Info":
                    onDestinationKey();
                    break;
                case "Attitude_Mode":
                    onAttitudeKey();
                    break;
                case "Toggle_Autopilot_Announcement":
                    onAutopilotKey();
                    break;
                case "Toggle_GPWS_Announcement":
                    onGPWSKey();
                    break;
                case "Toggle_ILS_Announcement":
                    onToggleILSKey();
                    break;
                case "Toggle_Flaps_Announcement":
                    onToggleFlapsAnnouncementKey();
                    break;
                case "Read_Flaps_Angle":
                    onFlapsAngleKey();
                    break;
                case "Read_Landing_Gear":
                    onGearState();
                    break;

                case "Wind_Information":
                    onWindKey();
                    break;
                case "Runway_Guidance_Mode":
                    onRunwayGuidanceKey();
                    break;
                case "Fuel_Report":
                    onFuelReportKey();
                    break;
                case "Fuel_Flow":
                    onFuelFlowKey();
                    break;
                case "Weight_Report":
                    onWeightReportKey();
                    break;

                case "Fuel_Tank_1":
                    onFuelTankKey(1);
                    break;
                case "Fuel_Tank_2":
                    onFuelTankKey(2);
                    break;
                case "Fuel_Tank_3":
                    onFuelTankKey(3);
                    break;
                case "Fuel_Tank_4":
                    onFuelTankKey(4);
                    break;
                case "Fuel_Tank_5":
                    onFuelTankKey(5);
                    break;
                case "Fuel_Tank_6":
                    onFuelTankKey(6);
                    break;
                case "Fuel_Tank_7":
                    onFuelTankKey(7);
                    break;
                case "Fuel_Tank_8":
                    onFuelTankKey(8);
                    break;
                case "Fuel_Tank_9":
                    onFuelTankKey(9);
                    break;
                case "Fuel_Tank_10":
                    onFuelTankKey(10);
                    break;
                case "Nearby_Airborn_Aircraft":
                    onNearbyAircraft();
                    break;
                case "Nearby_Ground_Aircraft":
                    onTCASGround();
                    break;
                case "Engine_1_Throttle":
                    onEngineThrottleKey(1);
                    break;

                case "Engine_2_Throttle":
                    onEngineThrottleKey(2);
                    break;

                case "Engine_3_Throttle":
                    onEngineThrottleKey(3);
                    break;

                case "Engine_4_Throttle":
                    onEngineThrottleKey(4);
                    break;

                case "Engine_1_Info":
                    onEngineInfoKey(1);
                    break;
                case "Engine_2_Info":
                    onEngineInfoKey(2);
                    break;
                case "Engine_3_Info":
                    onEngineInfoKey(3);
                    break;
                case "Engine_4_Info":
                    onEngineInfoKey(4);
                    break;
                case "Toggle_Braille_Output":
                    onBrailleOutputKey();
                    break;

            }

        }

        private void onAutopilotKeyPressed(object sender, HotkeyEventArgs e)
        {
            frmAutopilot ap;
            frmComRadios com;
            frmNavRadios nav;
            frmPMDGCDU cdu;
            frmAltimeter alt;
            string gaugeName;
            string gaugeValue;
            bool isGauge = true;

            e.Handled = true;
            ResetHotkeys();
            switch (e.Name)
            {
                case "ap_Get_Altitude":
                    gaugeName = "AP altitude";
                    gaugeValue = Autopilot.ApAltitude.ToString();
                    if (Autopilot.ApAltitudeLock) gaugeValue = " hold " + gaugeValue;
                    fireOnScreenReaderOutputEvent(gaugeName, gaugeValue, isGauge);
                    break;
                case "ap_Set_Altitude":
                    ap = new frmAutopilot("Altitude");
                    ap.ShowDialog();
                    break;
                case "ap_Get_Altimeter":
                    ReadAltimeter(true);
                    break;
                case "ap_Set_Altimeter":
                    alt = new frmAltimeter();
                    alt.ShowDialog();
                    break;

                case "ap_Get_Heading":
                    gaugeName = "AP heading";
                    gaugeValue = Autopilot.ApHeading.ToString();
                    if (Autopilot.ApHeadingLock) gaugeValue = " hold " + gaugeValue;
                    fireOnScreenReaderOutputEvent(gaugeName, gaugeValue, isGauge);
                    break;
                case "ap_Set_Heading":
                    ap = new frmAutopilot("Heading");
                    ap.ShowDialog();
                    break;

                case "ap_Get_Airspeed":
                    gaugeName = "AP airspeed";
                    gaugeValue = Autopilot.ApAirspeed.ToString();
                    if (Autopilot.ApAirspeedHold) gaugeValue = " hold " + gaugeValue;
                    fireOnScreenReaderOutputEvent(gaugeName, gaugeValue, isGauge);
                    break;

                case "ap_Set_Airspeed":
                    ap = new frmAutopilot("Airspeed");
                    ap.ShowDialog();
                    break;

                case "ap_Get_Mach_Speed":
                    gaugeName = "AP mach";
                    gaugeValue = Autopilot.ApMachSpeed.ToString();
                    if (Autopilot.ApMachHold) gaugeValue = " hold " + gaugeValue;
                    fireOnScreenReaderOutputEvent(gaugeName, gaugeValue, isGauge);
                    break;

                case "ap_Set_Mach_Speed":
                    ap = new frmAutopilot("Mach");
                    ap.ShowDialog();
                    break;

                case "ap_Get_Vertical_Speed":
                    gaugeName = "AP vertical speed";
                    gaugeValue = Autopilot.ApVerticalSpeed.ToString();
                    if (Autopilot.ApVerticalSpeedHold) gaugeValue = " hold " + gaugeValue;
                    fireOnScreenReaderOutputEvent(gaugeName, gaugeValue, isGauge);
                    break;

                case "ap_Set_Vertical_Speed":
                    ap = new frmAutopilot("Vertical speed");
                    ap.ShowDialog();
                    break;

                case "ap_Get_Com_Radios":
                    fireOnScreenReaderOutputEvent(isGauge: false, output: $"com 1: {Autopilot.Com1Freq.ToString()}. ");
                    fireOnScreenReaderOutputEvent(isGauge: false, output: $"com 2: {Autopilot.Com2Freq.ToString()}. ");
                    break;


                case "ap_Set_Com_Radios":
                    com = new frmComRadios();
                    com.ShowDialog();
                    break;

                case "ap_Get_Nav_Radios":
                    string navInfo = null;
                    fireOnScreenReaderOutputEvent(isGauge: false, output: $"nav 1: {Autopilot.Nav1Freq.ToString()}. Course: {Autopilot.Nav1Course.ToString()}. ");

                    if (Aircraft.AutopilotRadioStatus.Value[6])
                    {
                        // nav 1 has ILS
                        navInfo += "ILS. \n";
                        double gsInclination = (double)Aircraft.Nav1GSInclination.Value * 360d / 65536d - 360d;
                        navInfo += "Glide slope angle: " + gsInclination.ToString("F1") + "degrees. \n";
                        navInfo += $"{Aircraft.Vor1Name.Value}. \n";
                        double magvar = (double)Aircraft.MagneticVariation.Value * 360d / 65536d;
                        double rwyHeading = (double)Aircraft.Nav1LocaliserInverseRunwayHeading.Value * 360d / 65536d + 180d - magvar;
                        navInfo += "localiser heading: " + rwyHeading.ToString("F0");
                    }
                    else
                    {
                        if (Aircraft.Vor1ID.Value != "")
                        {
                            navInfo += $"VOR ID: {Aircraft.Vor1ID.Value}. ";
                        }

                    }
                    fireOnScreenReaderOutputEvent(isGauge: false, output: navInfo);
                    break;
                case "ap_Set_Nav_Radios":
                    nav = new frmNavRadios();
                    nav.ShowDialog();
                    break;


                case "ap_Get_Transponder":
                    gaugeName = "Transponder";
                    gaugeValue = Autopilot.Transponder.ToString();
                    fireOnScreenReaderOutputEvent(gaugeName, gaugeValue, isGauge);
                    break;
                case "ap_Set_Transponder":
                    ap = new frmAutopilot("Transponder");
                    ap.ShowDialog();
                    break;

                case "ap_Set_Throttle":
                    ap = new frmAutopilot("Throttle");
                    ap.ShowDialog();
                    break;
                case "ap_PMDG_CDU":
                    cdu = new frmPMDGCDU();
                    cdu.Show();
                    break;
                case "ap_PMDG_Panels":
                    frmCockpitPanels pnl = new frmCockpitPanels();
                    pnl.Show();
                    break;

                default:
                    Tolk.Output("key not defined");
                    break;

            }
        }

        arState()
        {
            var gaugeName = "Gear";
            var isGauge = true;
            string gaugeValue;
            if (Aircraft.LandingGear.Value == 0)
            {
                gaugeValue = "up. ";
                fireOnScreenReaderOutputEvent(gaugeName, gaugeValue, isGauge);
            }
            if (Aircraft.LandingGear.Value == 16383)
            {
                gaugeValue = "down. ";
                fireOnScreenReaderOutputEvent(gaugeName, gaugeValue, isGauge);
            }
            if (Aircraft.LandingGear.Value > 0 && Aircraft.LandingGear.Value < 16383)
            {
                gaugeValue = "in motion. ";
                fireOnScreenReaderOutputEvent(gaugeName, gaugeValue, isGauge);
            }

        }

        private void onFlapsAngleKey()
        {
            double FlapsAngle = (double)Aircraft.Flaps.Value / 256d;
            var gaugeName = "Flaps";
            var gaugeValue = FlapsAngle.ToString("f0");
            var isGauge = true;
            fireOnScreenReaderOutputEvent(gaugeName, gaugeValue, isGauge);
        }



        private void onBrailleOutputKey()
        {
            if (Properties.Settings.Default.OutputBraille)
            {
                Properties.Settings.Default.OutputBraille = false;
                fireOnScreenReaderOutputEvent(isGauge: false, output: "Braille output disabled. ");
            }
            else
            {
                Properties.Settings.Default.OutputBraille = true;
                fireOnScreenReaderOutputEvent(isGauge: false, output: "Braille output enabled. ");
            }
        }

        private void onEngineThrottleKey(int engine)
        {
            string throttleValue = null;
            string thrustValue = null;
            if (engine > Aircraft.num_engines.Value)
            {
                fireOnScreenReaderOutputEvent(isGauge: false, output: $"Only {Aircraft.num_engines.Value} available. ");
                return;
            }
            if (engine == 1)
            {
                double throttlePercent = (double)Aircraft.Engine1ThrottleLever.Value / 16384d * 100d;
                double thrust = Aircraft.Engine1JetThrust.Value;
                throttleValue = throttlePercent.ToString("F1");
                thrustValue = Aircraft.Engine1JetThrust.Value.ToString("F0");
                fireOnScreenReaderOutputEvent(isGauge: false, output: $"Engine 1: {throttleValue} percent, {thrustValue} pounds thrust.");
            }
            if (engine == 2)
            {
                double throttlePercent = (double)Aircraft.Engine2ThrottleLever.Value / 16384d * 100d;
                throttleValue = throttlePercent.ToString("F1");
                thrustValue = Aircraft.Engine2JetThrust.Value.ToString("F0");
                fireOnScreenReaderOutputEvent(isGauge: false, output: $"Engine 2: {throttleValue} percent, {thrustValue} pounds thrust.");
            }
            if (engine == 3)
            {
                double throttlePercent = (double)Aircraft.Engine3ThrottleLever.Value / 16384d * 100d;
                throttleValue = throttlePercent.ToString("F1");
                thrustValue = Aircraft.Engine3JetThrust.Value.ToString("F0");
                fireOnScreenReaderOutputEvent(isGauge: false, output: $"Engine 3: {throttleValue} percent, {thrustValue} pounds thrust.");
            }
            if (engine == 4)
            {
                double throttlePercent = (double)Aircraft.Engine4ThrottleLever.Value / 16384d * 100d;
                throttleValue = throttlePercent.ToString("F1");
                thrustValue = Aircraft.Engine4JetThrust.Value.ToString("F0");
                fireOnScreenReaderOutputEvent(isGauge: false, output: $"Engine 4: {throttleValue} percent, {thrustValue} pounds thrust.");

            }



        }

        private void onGroundSpeedKey()
        {
            var gaugeName = "Ground speed";
            var gaugeValue = GroundSpeed.ToString();
            var isGauge = true;
            fireOnScreenReaderOutputEvent(gaugeName, gaugeValue, isGauge);
        }

        private void onRepeatLastSimconnectMessage()
        {
            if (OldSimConnectMessage != null)
            {
                fireOnScreenReaderOutputEvent(isGauge: false, output: OldSimConnectMessage);
            }
            else
            {
                fireOnScreenReaderOutputEvent(isGauge: false, output: "no recent message");
            }

        }

        private void onWindKey()
        {
            double WindSpeed = (double)Aircraft.WindSpeed.Value;
            double WindDirection = (double)Aircraft.WindDirection.Value * 360d / 65536d;
            WindDirection = Math.Round(WindDirection);
            double WindGust = (double)Aircraft.WindGust.Value;
            fireOnScreenReaderOutputEvent(isGauge: false, output: $"Wind: {WindDirection} at {WindSpeed} knotts. Gusts at {WindGust} knotts.");

        }


        private void onNearbyAircraft()
        {
            // Get a reference to the AITrafficServices (for easier use)
            AITrafficServices ts = FSUIPCConnection.AITrafficServices;
            ts.UpdateExtendedPlaneIndentifiers(
                    TailNumber: false,
                    AirlineAndFlightNumber: true,
                    AircraftTypeAndModel: true,
                    AircraftTitle: false);

            // Get the latest data from FSUIPC
            Tolk.Output("please wait... ");
            ts.RefreshAITrafficInformation();

            // Get the list of all AI Traffic
            List<AIPlaneInfo> groundtraffic = ts.GroundTraffic;
            List<AIPlaneInfo> airbornTraffic = ts.AirborneTraffic;
            if (groundtraffic.Count == 0 && airbornTraffic.Count == 0)
            {
                fireOnScreenReaderOutputEvent(isGauge: false, output: "no traffic available. ");
            }
            else
            {
                frmNearbyAircraft frm = new frmNearbyAircraft(groundtraffic, airbornTraffic);
                frm.ShowDialog();

            }
        }

        private void onTCASGround()
        {
            Tolk.Output("not yet implemented.");
        }

        private void onFuelTankKey(int tank)
        {
            FSUIPCConnection.PayloadServices.RefreshData();
            if (tank > ActiveTanks.Count)
            {
                fireOnScreenReaderOutputEvent(isGauge: false, output: "tank not available");
            }
            else
            {
                tank = tank - 1;
                string name = ActiveTanks[tank].Tank.ToString();
                string pct = ActiveTanks[tank].LevelPercentage.ToString("F0");
                string weight = null;
                if (Properties.Settings.Default.UseMetric)
                {
                    weight = ActiveTanks[tank].WeightKgs.ToString("F0");
                }
                else
                {
                    weight = ActiveTanks[tank].WeightLbs.ToString("F0");
                }

                string gal = ActiveTanks[tank].LevelUSGallons.ToString("F0");
                if (Properties.Settings.Default.UseMetric)
                {
                    fireOnScreenReaderOutputEvent(isGauge: false, output: $"{name}.  {pct} percent, {weight} kilograms, {gal} gallons.");
                }
                else
                {
                    fireOnScreenReaderOutputEvent(isGauge: false, output: $"{name}.  {pct} percent, {weight} pounds, {gal} gallons.");
                }

            }
        }

        private void onFuelFlowKey()
        {
            int NumEngines = Aircraft.num_engines.Value;
            double eng1 = Math.Round(Aircraft.eng1_fuel_flow.Value);
            double eng2 = Math.Round(Aircraft.eng2_fuel_flow.Value);
            double eng3 = Math.Round(Aircraft.eng3_fuel_flow.Value);
            double eng4 = Math.Round(Aircraft.eng4_fuel_flow.Value);
            fireOnScreenReaderOutputEvent(isGauge: false, output: "Fuel flow (pounds per hour): ");
            fireOnScreenReaderOutputEvent(isGauge: false, output: $"Engine 1: {eng1}. ");
            if (NumEngines >= 2)
            {
                fireOnScreenReaderOutputEvent(isGauge: false, output: $"Engine 2: {eng2}. ");
            }
            if (NumEngines >= 3)
            {
                fireOnScreenReaderOutputEvent(isGauge: false, output: $"Engine 3: {eng3}. ");
            }
            if (NumEngines >= 4)
            {
                fireOnScreenReaderOutputEvent(isGauge: false, output: $"Engine 4: {eng4}. ");
            }

        }

        private void onFuelReportKey()
        {
            // Make a variable to make accessing the payload services object quicker
            // NOTE: The connection must already be open in order to access payload services
            PayloadServices ps = FSUIPCConnection.PayloadServices;
            // Refresh the current payload data
            ps.RefreshData();
            string TotalFuelWeight = ps.FuelWeightLbs.ToString("F1");
            string TotalFuelQuantity = ps.FuelLevelUSGallons.ToString("F1");
            fireOnScreenReaderOutputEvent(isGauge: false, output: $"total fuel: {TotalFuelWeight} pounds. ");
            fireOnScreenReaderOutputEvent(isGauge: false, output: $"{TotalFuelQuantity} gallons. ");
            double TotalFuelFlow = (double)Aircraft.eng1_fuel_flow.Value + Aircraft.eng2_fuel_flow.Value + Aircraft.eng3_fuel_flow.Value + Aircraft.eng4_fuel_flow.Value;
            TotalFuelFlow = Math.Round(TotalFuelFlow);
            fireOnScreenReaderOutputEvent(isGauge: false, output: $"Total fuel flow: {TotalFuelFlow}");
        }
        private void onWeightReportKey()
        {
            // Make a variable to make accessing the payload services object quicker
            // NOTE: The connection must already be open in order to access payload services
            PayloadServices ps = FSUIPCConnection.PayloadServices;
            // Refresh the current payload data
            ps.RefreshData();
            if (Properties.Settings.Default.UseMetric)
            {
                string GrossWeight = ps.GrossWeightKgs.ToString("F0");
                string EmptyWeight = ps.EmptyWeightKgs.ToString("F0");
                string FuelWeight = ps.FuelWeightKgs.ToString("F0");
                string PayloadWeight = ps.PayloadWeightKgs.ToString("F0");
                string MaxGrossWeight = ps.MaxGrossWeightKgs.ToString("F0");
                if (ps.GrossWeightKgs > ps.MaxGrossWeightKgs)
                {
                    fireOnScreenReaderOutputEvent(isGauge: false, output: "Overweight warning! ");
                }
                fireOnScreenReaderOutputEvent(isGauge: false, output: $"Fuel Weight: {FuelWeight} Kilograms");
                fireOnScreenReaderOutputEvent(isGauge: false, output: $"Payload Weight: {PayloadWeight} kilograms. ");
                fireOnScreenReaderOutputEvent(isGauge: false, output: $"Gross Weight: {GrossWeight} of {MaxGrossWeight} kilograms maximum.");

            }
            else
            {
                string GrossWeight = ps.GrossWeightLbs.ToString("F0");
                string EmptyWeight = ps.EmptyWeightLbs.ToString("F0");
                string FuelWeight = ps.FuelWeightLbs.ToString("F0");
                string PayloadWeight = ps.PayloadWeightLbs.ToString("F0");
                string MaxGrossWeight = ps.MaxGrossWeightLbs.ToString("F0");
                if (ps.GrossWeightLbs > ps.MaxGrossWeightLbs)
                {
                    fireOnScreenReaderOutputEvent(isGauge: false, output: "Overweight warning! ");
                }
                fireOnScreenReaderOutputEvent(isGauge: false, output: $"Fuel Weight: {FuelWeight} pounds");
                fireOnScreenReaderOutputEvent(isGauge: false, output: $"Payload Weight: {PayloadWeight} pounds. ");
                fireOnScreenReaderOutputEvent(isGauge: false, output: $"Gross Weight: {GrossWeight} of {MaxGrossWeight} pounds maximum.");

            }
        }
        private void onRunwayGuidanceKey()
        {
            if (!runwayGuidanceEnabled)
            {
                runwayGuidanceEnabled = true;
                // set up the timer
                RunwayGuidanceTimer = new System.Timers.Timer(200); // 200 milliseconds
                // Hook up the Elapsed event for the timer. 
                RunwayGuidanceTimer.Elapsed += OnRunwayGuidanceTickEvent;
                RunwayGuidanceTimer.AutoReset = true;
                RunwayGuidanceTrackedHeading = (double)Math.Round(Aircraft.CompassHeading.Value);
                fireOnScreenReaderOutputEvent(isGauge: false, output: $"Runway guidance enabled. current heading: {RunwayGuidanceTrackedHeading}. ");
                // play tones for 45 degrees on either side of the tracked heading
                HdgRight = RunwayGuidanceTrackedHeading + 45;
                HdgLeft = RunwayGuidanceTrackedHeading - 45;
                if (HdgRight > 360)
                {
                    HdgRight = HdgRight - 360;
                }
                if (HdgLeft < 0)
                {
                    HdgLeft = HdgLeft + 360;
                }
                // start audio
                wg = new SignalGenerator();
                wg.Type = SignalGeneratorType.Square;
                wg.Gain = 0.1;
                // set up panning provider, with the signal generator as input
                pan = new PanningSampleProvider(wg.ToMono());
                // we use an OffsetSampleProvider to allow playing beep tones
                RunwayGuidanceTimer.Enabled = true;
            }
            else
            {
                driverOut.Stop();
                RunwayGuidanceTimer.Stop();
                runwayGuidanceEnabled = false;
                fireOnScreenReaderOutputEvent(isGauge: false, output: "Runway Guidance disabled. ");
            }

        }
        private void OnRunwayGuidanceTickEvent(Object source, ElapsedEventArgs e)
        {
            pulse = new OffsetSampleProvider(pan)
            {
                Take = TimeSpan.FromMilliseconds(50),
            };
            mixer.RemoveAllMixerInputs();
            double hdg = (double)Math.Round(Aircraft.CompassHeading.Value);
            if (hdg > RunwayGuidanceTrackedHeading && hdg < HdgRight)
            {
                double freq = mapOneRangeToAnother(hdg, RunwayGuidanceTrackedHeading, HdgRight, 400, 800, 0);
                wg.Frequency = freq;
                pan.Pan = 1;
                mixer.AddMixerInput(pulse);
            }
            if (hdg < RunwayGuidanceTrackedHeading && hdg > HdgLeft)
            {
                double freq = mapOneRangeToAnother(hdg, HdgLeft, RunwayGuidanceTrackedHeading, 800, 400, 0);
                wg.Frequency = freq;
                pan.Pan = -1;
                mixer.AddMixerInput(pulse);
            }
            if (hdg == RunwayGuidanceTrackedHeading)
            {
                mixer.RemoveAllMixerInputs();
            }
        }



        private void onToggleFlapsAnnouncementKey()
        {
            if (Properties.Settings.Default.ReadFlaps)
            {
                Properties.Settings.Default.ReadFlaps = false;
                fireOnScreenReaderOutputEvent(isGauge: false, output: "flaps announcement disabled. ");
            }
            else
            {
                Properties.Settings.Default.ReadFlaps = true;
                fireOnScreenReaderOutputEvent(isGauge: false, output: "Flaps announcement enabled. ");
            }
        }

        private void onToggleILSKey()
        {
            if (Properties.Settings.Default.ReadILS == true)
            {
                Properties.Settings.Default.ReadILS = false;
                ilsTimer.Enabled = false;
                fireOnScreenReaderOutputEvent(isGauge: false, output: "Read ILS disabled");
            }
            else
            {
                Properties.Settings.Default.ReadILS = true;
                fireOnScreenReaderOutputEvent(isGauge: false, output: "Read ILS enabled");

            }
        }

        private void onGPWSKey()
        {
            Tolk.Output("not yet implemented.");
        }

        private void onDirectorKey()
        {
            Tolk.Output("not yet implemented.");
        }

        private void onAutopilotKey()
        {
            if (Properties.Settings.Default.ReadAutopilot)
            {
                Properties.Settings.Default.ReadAutopilot = false;
                fireOnScreenReaderOutputEvent(isGauge: false, output: "read autopilot instruments disabled");
            }
            else
            {
                Properties.Settings.Default.ReadAutopilot = true;
                fireOnScreenReaderOutputEvent(isGauge: false, output: "Read autopilot instruments enabled. ");
            }
        }

        private void onAttitudeKey()
        {
            if (!attitudeModeEnabled)
            {
                attitudeModeEnabled = true;
                // set up the timer
                AttitudeTimer = new System.Timers.Timer(150); // 200 milliseconds
                // Hook up the Elapsed event for the timer. 
                AttitudeTimer.Elapsed += OnAttitudeModeTickEvent;
                AttitudeTimer.AutoReset = true;
                fireOnScreenReaderOutputEvent(isGauge: false, output: "Attitude mode enabled. ");
                // start audio
                // signal generator for generating tones
                wg = new SignalGenerator();
                wg.Type = SignalGeneratorType.Square;
                wg.Gain = 0.1;
                // set up panning provider, with the signal generator as input
                pan = new PanningSampleProvider(wg.ToMono());

                pitchSineProvider = new SineWaveProvider();
                // bankSineProvider = new SineWaveProvider();
                AttitudeTimer.Enabled = true;
            }
            else
            {
                mixer.RemoveAllMixerInputs();
                AttitudePitchPlaying = false;
                AttitudeBankLeftPlaying = false;
                AttitudeBankRightPlaying = false;
                AttitudeTimer.Stop();
                attitudeModeEnabled = false;
                fireOnScreenReaderOutputEvent(isGauge: false, output: "Attitude mode disabled. ");
            }
        }
        private void OnAttitudeModeTickEvent(Object source, ElapsedEventArgs e)
        {
            attitudeModeSelect = Properties.Settings.Default.AttitudeAnnouncementMode;
            // pan = new PanningSampleProvider(bankSineProvider);
            FSUIPCConnection.Process("attitude");
            double Pitch = Math.Round((double)Aircraft.AttitudePitch.Value * 360d / (65536d * 65536d));
            double Bank = Math.Round((double)Aircraft.AttitudeBank.Value * 360d / (65536d * 65536d));
            // pitch down
            if (Pitch > 0 && Pitch < 20)
            {
                if (attitudeModeSelect == 2 || attitudeModeSelect == 3)
                {
                    if (Pitch != oldPitch)
                    {
                        fireOnScreenReaderOutputEvent(isGauge: false, textOutput: false, interruptSpeech: true, output: $"down {Pitch}");
                        oldPitch = Pitch;
                        if (attitudeModeSelect == 2) return;
                    }
                }
                if (attitudeModeSelect == 1 || attitudeModeSelect == 3)
                {
                    if (!AttitudePitchPlaying)
                    {
                        mixer.AddMixerInput(new SampleToWaveProvider(pitchSineProvider.ToStereo()));
                        Logger.Debug("pitch: " + Pitch);
                        AttitudePitchPlaying = true;
                    }

                    double freq = mapOneRangeToAnother(Pitch, 0, 20, 600, 200, 0);
                    pitchSineProvider.Frequency = freq;
                }

            }
            // pitch up
            if (Pitch < 0 && Pitch > -20)
            {
                if (attitudeModeSelect == 2 || attitudeModeSelect == 3)
                {
                    if (Pitch != oldPitch)
                    {
                        fireOnScreenReaderOutputEvent(interruptSpeech: true, isGauge: false, textOutput: false, output: $"up {Math.Abs(Pitch)}");
                        oldPitch = Pitch;
                        if (attitudeModeSelect == 2) return;
                    }
                }

                if (attitudeModeSelect == 1 || attitudeModeSelect == 3)
                {
                    if (!AttitudePitchPlaying)
                    {
                        mixer.AddMixerInput(new SampleToWaveProvider(pitchSineProvider.ToStereo()));
                        Logger.Debug("pitch: " + Pitch);
                        AttitudePitchPlaying = true;
                    }
                    double freq = mapOneRangeToAnother(Pitch, -20, 0, 1200, 800, 0);
                    pitchSineProvider.Frequency = freq;
                }

            }
            // bank left
            if (Bank > 0 && Bank < 90)
            {
                if (attitudeModeSelect == 2 || attitudeModeSelect == 3)
                {
                    if (Bank != oldBank)
                    {
                        fireOnScreenReaderOutputEvent(interruptSpeech: true, isGauge: false, textOutput: false, output: $"left {Bank}");
                        oldBank = Bank;
                        if (attitudeModeSelect == 2) return;
                    }
                }
                if (attitudeModeSelect == 1 || attitudeModeSelect == 3)
                {
                    double freq = mapOneRangeToAnother(Bank, 1, 90, 400, 800, 0);
                    // bankSineProvider.Frequency = freq;
                    wg.Frequency = freq;
                    if (!AttitudeBankLeftPlaying)
                    {
                        mixer.RemoveAllMixerInputs();
                        pan.Pan = -1;
                        mixer.AddMixerInput(pan);
                        mixer.AddMixerInput(new SampleToWaveProvider(pitchSineProvider.ToStereo()));
                        AttitudeBankLeftPlaying = true;
                        AttitudeBankRightPlaying = false;
                    }

                }


            }
            // bank right
            if (Bank < 0 && Bank > -90)
            {
                Bank = Math.Abs(Bank);
                if (attitudeModeSelect == 2 || attitudeModeSelect == 3)
                {
                    if (Bank != oldBank)
                    {
                        fireOnScreenReaderOutputEvent(interruptSpeech: true, isGauge: false, textOutput: false, output: $"right {Bank}");
                        oldBank = Bank;
                        if (attitudeModeSelect == 2) return;
                    }
                }

                if (attitudeModeSelect == 1 || attitudeModeSelect == 3)
                {
                    double freq = mapOneRangeToAnother(Bank, 1, 90, 400, 800, 0);
                    // bankSineProvider.Frequency = freq;
                    wg.Frequency = freq;
                    if (!AttitudeBankRightPlaying)
                    {
                        mixer.RemoveAllMixerInputs();
                        pan.Pan = 1;
                        mixer.AddMixerInput(pan);
                        mixer.AddMixerInput(new SampleToWaveProvider(pitchSineProvider.ToStereo()));
                        AttitudeBankLeftPlaying = false;
                        AttitudeBankRightPlaying = true;
                    }

                }
            }
            if (Bank == 0)
            {
                if (attitudeModeSelect == 1 || attitudeModeSelect == 3)
                {
                    mixer.RemoveAllMixerInputs();
                    mixer.AddMixerInput(new SampleToWaveProvider(pitchSineProvider.ToStereo()));
                    AttitudeBankLeftPlaying = false;
                    AttitudeBankRightPlaying = false;
                    AttitudePitchPlaying = true;

                }
            }

        }


        private void onDestinationKey()
        {
            TimeSpan TimeEnroute = TimeSpan.FromSeconds(Aircraft.DestinationTimeEnroute.Value);
            string strTime = string.Format("{0:%h} hours {0:%m} minutes, {0:%s} seconds", TimeEnroute);
            if (TimeEnroute.Hours == 0)
            {
                strTime = string.Format("{0:%m} minutes, {0:%s} seconds", TimeEnroute);
            }
            if (TimeEnroute.Minutes == 0 && TimeEnroute.Hours == 0)
            {
                strTime = string.Format("{0:%s} seconds", TimeEnroute);
            }
            fireOnScreenReaderOutputEvent(isGauge: false, output: $"Time enroute to destination, {strTime}. ");


        }

        private void onWaypointKey()
        {
            ReadWayPoint();
        }

        private void onCityKey()
        {
            double lat = Aircraft.aircraftLat.Value.DecimalDegrees;
            double lon = Aircraft.aircraftLon.Value.DecimalDegrees;
            // double lat = -48.876667;
            // double lon = -123.393333;
            if (Properties.Settings.Default.GeonamesUsername == "")
            {
                fireOnScreenReaderOutputEvent(isGauge: false, output: "geonames username not configured");
                return;
            }
            var geonamesUser = Properties.Settings.Default.GeonamesUsername;
            if (Properties.Settings.Default.FlightFollowingOffline)
            {
                var pos = r.CreateFromLatLong(lat, lon);
                var results = r.NearestNeighbourSearch(pos, 1);
                foreach (var res in results)
                {
                    Tolk.Output(res.Name);
                    Tolk.Output(res.Admincodes[1]);
                }
            }
            else
            {
                try
                {

                    var xmlNearby = XElement.Load($"http://api.geonames.org/findNearbyPlaceName?style=long&lat={lat}&lng={lon}&username={geonamesUser}&cities=cities1000&radius=200");
                    var locations = xmlNearby.Descendants("geoname").Select(g => new
                    {
                        Name = g.Element("name").Value,
                        Lat = g.Element("lat").Value,
                        Long = g.Element("lng").Value,
                        admin1 = g.Element("adminName1").Value,
                        countryName = g.Element("countryName").Value
                    });
                    if (locations.Count() > 0)
                    {
                        var location = locations.First();
                        // get the current magnetic variation
                        double magVarDegrees = (double)Aircraft.MagneticVariation.Value * 360d / 65536d;
                        // create a point for the aircraft current position
                        FsLatLonPoint aircraftPos = new FsLatLonPoint(Aircraft.aircraftLat.Value, Aircraft.aircraftLon.Value);
                        // create a point for the nearest city
                        double nearestCityLat = double.Parse(location.Lat);
                        double nearestCityLong = double.Parse(location.Long);
                        FsLatLonPoint nearestCityPoint = new FsLatLonPoint(nearestCityLat, nearestCityLong);
                        string distanceNM = aircraftPos.DistanceFromInNauticalMiles(nearestCityPoint).ToString("F1");
                        double bearingTrue = aircraftPos.BearingTo(nearestCityPoint);
                        double bearingMagnetic = bearingTrue - magVarDegrees;
                        string strBearing = bearingMagnetic.ToString("F0");
                        fireOnScreenReaderOutputEvent(isGauge: false, output: $"{location.Name} {location.admin1}, {location.countryName}. ");
                        fireOnScreenReaderOutputEvent(isGauge: false, output: $"{distanceNM} nautical miles, {strBearing} degrees.");
                    }
                    else
                    {
                        fireOnScreenReaderOutputEvent(isGauge: false, output: $"No city nearby.");
                    }
                }
                catch (Exception ex)
                {
                    Logger.Debug($"error retrieving nearest city: {ex.Message}");
                    Tolk.Output("error retrieving nearest city. check log.");
                }
                try
                {
                    var xmlOcean = XElement.Load($"http://api.geonames.org/ocean?lat={lat}&lng={lon}&username={geonamesUser}");
                    var ocean = xmlOcean.Descendants("ocean").Select(g => new
                    {
                        Name = g.Element("name").Value
                    });
                    if (ocean.Count() > 0)
                    {
                        var currentOcean = ocean.First();
                        fireOnScreenReaderOutputEvent(isGauge: false, output: $"{currentOcean.Name}. ");
                    }

                }
                catch (Exception ex)
                {
                    Logger.Debug($"error retrieving oceanic info: {ex.Message}");

                }
                var xmlTimezone = XElement.Load($"http://api.geonames.org/timezone?lat={lat}&lng={lon}&username={geonamesUser}&radius=50");
                var timezone = xmlTimezone.Descendants("timezone").Select(g => new
                {
                    Name = g.Element("timezoneId").Value
                });
                if (timezone.Count() > 0)
                {
                    var currentTimezone = timezone.First();
                    if (currentTimezone.Name != oldTimezone)
                    {
                        try
                        {
                            string tzName = TZConvert.IanaToWindows(currentTimezone.Name);
                            fireOnScreenReaderOutputEvent(isGauge: false, output: $"{tzName}. ");
                        }
                        catch (Exception)
                        {

                            Logger.Debug($"cannot convert timezone: {currentTimezone.Name}");
                        }

                        oldTimezone = currentTimezone.Name;
                    }

                }


            }
        }
        private void onMuteSimconnectKey()
        {
            if (muteSimconnect)
            {
                muteSimconnect = false;
                fireOnScreenReaderOutputEvent(isGauge: false, output: "SimConnect messages unmuted. ");
            }
            else
            {
                muteSimconnect = true;
                fireOnScreenReaderOutputEvent(isGauge: false, output: "SimConnect messages muted.");
            }
            ResetHotkeys();
        }

        private void onTrimKey()
        {
            if (TrimEnabled)
            {
                TrimEnabled = false;
                fireOnScreenReaderOutputEvent(isGauge: false, output: "read trim disabled. ");
            }
            else
            {
                TrimEnabled = true;
                fireOnScreenReaderOutputEvent(isGauge: false, output: "trim enabled. ");
            }
            ResetHotkeys();
        }

        private void onAirtempKey()
        {
            double tempC = (double)Aircraft.AirTemp.Value / 256d;
            double tempF = 9.0 / 5.0 * tempC + 32;
            var gaugeName = "Outside temperature";
            var isGauge = true;
            var gaugeValue = "";
            if (Properties.Settings.Default.UseMetric)
            {
                gaugeValue = tempC.ToString("F0");
            }
            else
            {
                gaugeValue = tempF.ToString("F0");
            }
            fireOnScreenReaderOutputEvent(gaugeName, gaugeValue, isGauge);
        }

        private void onVSpeedKey()
        {
            double vspeed = (double)Aircraft.VerticalSpeed.Value * 3.28084d * -1;

            // used in the onScreenReaderOutput event in the main form.
            var gageName = "Vertical speed";
            var gageValue = vspeed.ToString("f0");
            var isGage = true;

            //Tolk.Output(vspeed.ToString("f0") + " feet per minute. ");
            // Test the new event.
            fireOnScreenReaderOutputEvent(gageName, gageValue, isGage);
            ResetHotkeys();

        }
        private void onLandingRateKey()
        {
            // convert FSUIPC unit to expected FPM value
            double vspd = Math.Round(Aircraft.LandingRate.Value * 60 * 3.28084 / 256);
            fireOnScreenReaderOutputEvent(isGauge: false, output: $"Landing Rate: {vspd} Feet per minute");

        }
        private void onMachKey()
        {
            double mach = (double)Aircraft.AirspeedMach.Value / 20480d;
            var gaugeName = "Mach";
            var isGauge = true;
            var gaugeValue = mach.ToString("F2");
            fireOnScreenReaderOutputEvent(gaugeName, gaugeValue, isGauge);

        }

        private void onTASKey()
        {
            double tas = (double)Aircraft.AirspeedTrue.Value / 128d;
            var gaugeName = "Airspeed true";
            var isGauge = true;
            var gaugeValue = tas.ToString("F0");
            fireOnScreenReaderOutputEvent(gaugeName, gaugeValue, isGauge);
        }

        private void onIASKey()
        {
            double ias = (double)Aircraft.AirspeedIndicated.Value / 128d;
            var gaugeName = "Airspeed indicated";
            var isGauge = true;
            var gaugeValue = ias.ToString("F0");
            fireOnScreenReaderOutputEvent(gaugeName, gaugeValue, isGauge);
        }

        private void onHeadingKey()
        {
            double hdgTrue = (double)Aircraft.Heading.Value * 360d / (65536d * 65536d);
            fireOnScreenReaderOutputEvent(isGauge: false, output: "heading: " + Autopilot.Heading);
            ResetHotkeys();
        }

        private void onAGLKey()
        {
            double groundAlt = (double)Aircraft.GroundAltitude.Value / 256d * 3.28084d;
            double agl = (double)Aircraft.Altitude.Value - groundAlt;
            var gaugeName = "AGL altitude";
            var isGauge = true;
            var gaugeValue = Math.Round(agl, 0).ToString();
            fireOnScreenReaderOutputEvent(gaugeName, gaugeValue, isGauge);
        }

        public void ResetHotkeys()
        {
            HotkeyManager.Current.Remove("Command_Key");
            HotkeyManager.Current.Remove("ap_Command_Key");
            foreach (string k in hotkeys)
            {
                HotkeyManager.Current.Remove(k);
            }
            foreach (string k in autopilotHotkeys)
            {
                HotkeyManager.Current.Remove(k);
            }
            if (CommandKeyEnabled)
            {
                HotkeyManager.Current.AddOrReplace("Command_Key", (Keys)Properties.Hotkeys.Default.Command_Key, commandMode);
                HotkeyManager.Current.AddOrReplace("ap_Command_Key", (Keys)Properties.Hotkeys.Default.ap_Command_Key, autopilotCommandMode);
            }

        }


        private void onASLKey()
        {
            double asl = Math.Round((double)Aircraft.Altitude.Value, 0);
            var gaugeName = "ASL altitude";
            var gaugeValue = asl.ToString("F0");
            var isGauge = true;
            fireOnScreenReaderOutputEvent(gaugeName, gaugeValue, isGauge);
        }


        private void onEngineInfoKey(int eng)
        {
            double N1 = 0;
            double N2 = 0;
            double cht = 0;
            double egt = 0;
            double manifold = 0;
            double rpm = 0;
            bool metric = Properties.Settings.Default.UseMetric;
            string units = null;
            string output = null;
            // check engine type. 0 - piston, 1- jet
            if (Aircraft.EngineType.Value == 0)
            {
                switch (eng)
                {
                    case 1:
                        // FSUIPC represents EGT in degrees Rankine, so we need to convert
                        egt = Aircraft.Engine1EGT.Value;
                        if (metric == true)
                        {
                            egt = Math.Round((egt - 491.67) * 5d / 9d);
                            units = "C";
                        }
                        else
                        {
                            egt = Math.Round(egt - 459.67);
                            units = "F";
                        }
                        cht = Aircraft.Engine1CHT.Value;
                        if (Properties.Settings.Default.UseMetric == true)
                        {
                            cht = Math.Round((cht - 32) * 5 / 9);
                            units = "C";
                        }
                        else
                        {
                            cht = Math.Round(cht);
                            units = "F";
                        }
                        rpm = Math.Round(Aircraft.Engine1RPM.Value);
                        manifold = Aircraft.Engine1ManifoldPressure.Value / 1024;
                        output = $"Engine 1: CHT: {cht} {units}, EGT: {egt} {units}, RPM: {rpm}, manifold: {manifold} inches. ";
                        fireOnScreenReaderOutputEvent(isGauge: false, output: output);
                        break;

                    case 2:
                        // FSUIPC represents EGT in degrees Rankine, so we need to convert
                        egt = Aircraft.Engine2EGT.Value;
                        if (metric == true)
                        {
                            egt = Math.Round((egt - 491.67) * 5d / 9d);
                            units = "C";
                        }
                        else
                        {
                            egt = Math.Round(egt - 459.67);
                            units = "F";
                        }
                        cht = Aircraft.Engine2CHT.Value;
                        if (Properties.Settings.Default.UseMetric == true)
                        {
                            cht = Math.Round((cht - 32) * 5 / 9);
                            units = "C";
                        }
                        else
                        {
                            cht = Math.Round(cht);
                            units = "F";
                        }
                        rpm = Math.Round(Aircraft.Engine2RPM.Value);
                        manifold = Aircraft.Engine2ManifoldPressure.Value / 1024;
                        output = $"Engine 2: CHT: {cht} {units}, EGT: {egt} {units}, RPM: {rpm}, manifold: {manifold} inches. ";
                        fireOnScreenReaderOutputEvent(isGauge: false, output: output);
                        break;

                    case 3:
                        // FSUIPC represents EGT in degrees Rankine, so we need to convert
                        egt = Aircraft.Engine3EGT.Value;
                        if (metric == true)
                        {
                            egt = Math.Round((egt - 491.67) * 5d / 9d);
                            units = "C";
                        }
                        else
                        {
                            egt = Math.Round(egt - 459.67);
                            units = "F";
                        }
                        cht = Aircraft.Engine3CHT.Value;
                        if (Properties.Settings.Default.UseMetric == true)
                        {
                            cht = Math.Round((cht - 32) * 5 / 9);
                            units = "C";
                        }
                        else
                        {
                            cht = Math.Round(cht);
                            units = "F";
                        }
                        rpm = Math.Round(Aircraft.Engine3RPM.Value);
                        manifold = Aircraft.Engine3ManifoldPressure.Value / 1024;
                        output = $"Engine 3: CHT: {cht} {units}, EGT: {egt} {units}, RPM: {rpm}, manifold: {manifold} inches. ";
                        fireOnScreenReaderOutputEvent(isGauge: false, output: output);
                        break;

                    case 4:
                        // FSUIPC represents EGT in degrees Rankine, so we need to convert
                        egt = Aircraft.Engine4EGT.Value;
                        if (metric == true)
                        {
                            egt = Math.Round((egt - 491.67) * 5d / 9d);
                            units = "C";
                        }
                        else
                        {
                            egt = Math.Round(egt - 459.67);
                            units = "F";
                        }
                        cht = Aircraft.Engine4CHT.Value;
                        if (Properties.Settings.Default.UseMetric == true)
                        {
                            cht = Math.Round((cht - 32) * 5 / 9);
                            units = "C";
                        }
                        else
                        {
                            cht = Math.Round(cht);
                            units = "F";
                        }
                        rpm = Math.Round(Aircraft.Engine4RPM.Value);
                        manifold = Aircraft.Engine4ManifoldPressure.Value / 1024;
                        output = $"Engine 4: CHT: {cht} {units}, EGT: {egt} {units}, RPM: {rpm}, manifold: {manifold} inches. ";
                        fireOnScreenReaderOutputEvent(isGauge: false, output: output);
                        break;
                }
            }
            if (Aircraft.EngineType.Value == 1)
            {
                switch (eng)
                {
                    case 1:
                        N1 = (double)Aircraft.Eng1N1.Value;
                        N2 = (double)Aircraft.Eng1N2.Value;
                        break;
                    case 2:
                        N1 = (double)Aircraft.Eng2N1.Value;
                        N2 = (double)Aircraft.Eng2N2.Value;
                        break;
                    case 3:
                        N1 = (double)Aircraft.Eng3N1.Value;
                        N2 = (double)Aircraft.Eng3N2.Value;
                        break;
                    case 4:
                        N1 = (double)Aircraft.Eng4N1.Value;
                        N2 = (double)Aircraft.Eng4N2.Value;
                        break;
                }
                fireOnScreenReaderOutputEvent(isGauge: false, output: $"Engine {eng}. ");
                fireOnScreenReaderOutputEvent(isGauge: false, output: $"N1: {Math.Round(N1)}. ");
                fireOnScreenReaderOutputEvent(isGauge: false, output: $"N2: {Math.Round(N2)}. ");
            }

        }

        private async void onCurrentLocation()
        {
            var database = FSUIPCConnection.AirportsDatabase;
            database.SetReferenceLocation();
            FsGate currentGate = null;
            FsTaxiway currentTaxiWay = null;
            FsRunway currentRunway = null;

            foreach (FsAirport airport in database.Airports)
            {
                foreach (FsGate gate in airport.Gates)
                {
                    if (gate.IsPlayerAtGate)
                    {
                        currentGate = gate;
                        break;
                    }
                } // Loop gates.
                foreach (FsRunway runway in airport.Runways)
                {
                    if (runway.IsPlayerOnRunway)
                    {
                        currentRunway = runway;
                        break;
                    }
                } //Loop through runways.
                foreach (FsTaxiway taxiway in airport.Taxiways)
                {
                    if (taxiway.IsPlayerOnTaxiway)
                    {
                        currentTaxiWay = taxiway;
                        break;
                    }
                } // Loop through taxiways.
            } // loop through airports.

            if (currentTaxiWay != null && currentGate == null)
            {
                fireOnScreenReaderOutputEvent(isGauge: false, output: $"taxi way {currentTaxiWay.Name}@{currentTaxiWay.Airport.ICAO}");
            }
            else if (currentRunway != null)
            {
                fireOnScreenReaderOutputEvent(isGauge: false, output: $"runway {currentRunway.ID.ToString()}@{currentRunway.Airport.ICAO}");
            }
            else if (currentGate != null)
            {
                fireOnScreenReaderOutputEvent(isGauge: false, output: $"gate {currentGate.ID}@{currentGate.Airport.ICAO}");
            }
            else
            {
                if (string.IsNullOrEmpty(Properties.Settings.Default.bingMapsAPIKey))
                {
                    fireOnScreenReaderOutputEvent(isGauge: false, output: "Please set the Bing Maps API key in settings before using the where am I feature.");
                    return;
                } // Sanity check on api keys.
                var latitude = Aircraft.aircraftLat.Value.DecimalDegrees;
                var longitude = Aircraft.aircraftLon.Value.DecimalDegrees;
                // Retrieve the state/province/territory.
                var cityRequest = new GetBoundaryRequest()
                {
                    EntityType = BoundaryEntityType.AdminDivision2,
                    LevelOfDetail = 3,
                    GetAllPolygons = true,
                    GetEntityMetadata = true,
                    Coordinate = new BingMapsSDSToolkit.GeodataLocation(latitude, longitude)
                };

                var stateRequest = new GetBoundaryRequest()
                {
                    EntityType = BoundaryEntityType.AdminDivision1,
                    LevelOfDetail = 3,
                    GetAllPolygons = true,
                    GetEntityMetadata = true,
                    Coordinate = new BingMapsSDSToolkit.GeodataLocation(latitude, longitude)
                };

                var countryRequest = new GetBoundaryRequest()
                {
                    EntityType = BoundaryEntityType.CountryRegion,
                    LevelOfDetail = 3,
                    GetAllPolygons = true,
                    GetEntityMetadata = true,
                    Coordinate = new BingMapsSDSToolkit.GeodataLocation(latitude, longitude)
                };
                var cityResponse = await GeodataManager.GetBoundary(cityRequest, Properties.Settings.Default.bingMapsAPIKey);
                var stateResponse = await GeodataManager.GetBoundary(stateRequest, Properties.Settings.Default.bingMapsAPIKey);
                var countryResponse = await GeodataManager.GetBoundary(countryRequest, Properties.Settings.Default.bingMapsAPIKey);

                // Check for existence of a country. If none present, most likely we are in a body of water.
                if (countryResponse == null)
                {
                    if (string.IsNullOrWhiteSpace(Properties.Settings.Default.GeonamesUsername))
                    {
                        fireOnScreenReaderOutputEvent(isGauge: false, output: "You must have a Geonames username to use this feature.");
                        return;
                    }
                    try
                    {
                        var xmlOcean = XElement.Load($"http://api.geonames.org/ocean?lat={latitude}&lng={longitude}&username={Properties.Settings.Default.GeonamesUsername}");
                        var ocean = xmlOcean.Descendants("ocean").Select(g => new
                        {
                            Name = g.Element("name").Value
                        });
                        if (ocean.Count() > 0)
                        {
                            var currentOcean = ocean.First();
                            fireOnScreenReaderOutputEvent(isGauge: false, output: $"{currentOcean.Name}. ");
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Debug($"error retrieving oceanic info: {ex.Message}");

                    }
                }
                else
                {
                    fireOnScreenReaderOutputEvent(isGauge: false, output: $"{cityResponse[0].Name.EntityName} {stateResponse[0].Name.EntityName}, {countryResponse[0].Name.EntityName}");
                }
                var xmlTimezone = XElement.Load($"http://api.geonames.org/timezone?lat={latitude}&lng={longitude}&username={Properties.Settings.Default.GeonamesUsername}&radius=50");
                var timezone = xmlTimezone.Descendants("timezone").Select(g => new
                {
                    Name = g.Element("timezoneId").Value
                });
                if (timezone.Count() > 0)
                {
                    var currentTimezone = timezone.First();
                    if (currentTimezone.Name != oldTimezone)
                    {
                        try
                        {
                            string tzName = TZConvert.IanaToWindows(currentTimezone.Name);
                            fireOnScreenReaderOutputEvent(isGauge: false, output: $"{tzName}. ");
                        }
                        catch (Exception)
                        {

                            Logger.Debug($"cannot convert timezone: {currentTimezone.Name}");
                        }
                    }
                    oldTimezone = currentTimezone.Name;
                }
            }
        }

        private void onTakeOffAssistant()
        {
            if (Properties.Settings.Default.takeOffAssistMode == "off")
            {
                fireOnScreenReaderOutputEvent(isGauge: false, textOutput: true, output: "Takeoff assist is turned off. Please change it to full or partial in settings.");
                takeOffAssistantActive = false;
            } // Takeoff assist is permanently turned off.
            else if (Properties.Settings.Default.takeOffAssistMode == "full")
            {
                takeOffAssistantActive = true;
                fireOnScreenReaderOutputEvent(isGauge: false, textOutput: true, output: "Takeoff assist on.");
                // Flaps aren't included because flap positions very between planes,
                // and there isn't a promising way to determine flap positions.

                Aircraft.AutoThrottleArm.Value = 1; // On.
                Aircraft.AutoBrake.Value = 0; // Rejected takeoff.
                Aircraft.ApWingLeveler.Value = 1; // On.
                Aircraft.PitotHeat.Value = 1; // On.
                Autopilot.ApMaster = true;
                Autopilot.ApVerticalSpeed = 500; // Keeps most planes from bouncing.
                                                 //Autopilot.ApAltitudeLock = true; // Lock altitude before setting it. Otherwise, altitude lock reverts to current altitude.
                Autopilot.ApAltitude = 5000; // Reasonable request for a step climb until profiles are implemented.
                Autopilot.ApAirspeed = 250; // Must be faster than takeoff speed to avoid crashing.
                Aircraft.ParkingBrake.Value = 0; // Off.
                                                 // Start the engines on the plane.
                                                 //switch (Aircraft.num_engines.Value)
                                                 //{
                                                 //    case 1:
                                                 //        Aircraft.Engine1ThrottleLever.Value = 16388;
                                                 //        break;
                                                 //    case 2:
                                                 //        Aircraft.Engine1ThrottleLever.Value = 16388;
                                                 //        Aircraft.Engine2ThrottleLever.Value = 16388;
                                                 //        break;
                                                 //    case 3:
                                                 //        Aircraft.Engine1ThrottleLever.Value = 16388;
                                                 //        Aircraft.Engine2ThrottleLever.Value = 16388;
                                                 //        Aircraft.Engine3ThrottleLever.Value = 16388;
                                                 //        break;
                                                 //    case 4:
                                                 //        Aircraft.Engine1ThrottleLever.Value = 16388;
                                                 //        Aircraft.Engine2ThrottleLever.Value = 16388;
                                                 //        Aircraft.Engine3ThrottleLever.Value = 16388;
                                                 //        Aircraft.Engine4ThrottleLever.Value = 16388;
                                                 //        break;
                                                 //    case 0:
                                                 //        fireOnScreenReaderOutputEvent(isGauge: false, textOutput: true, output: "The aircraft engines are off, or have problems. Try again later.");
                                                 //        break;
                                                 //} // End throttle engines.
                isTakeoffComplete = false;
                PostTakeOffChecklist();
            } // End takeoff mode is full.
            else if (Properties.Settings.Default.takeOffAssistMode == "partial")
            {
                takeOffAssistantActive = true;
                fireOnScreenReaderOutputEvent(isGauge: false, textOutput: true, output: "Takeoff assist on.");
                isTakeoffComplete = false;
                PostTakeOffChecklist();
            } // End takeoff assist mode partial.
        }
        public bool PostTakeOffChecklist()
        {
            double groundAlt = (double)Aircraft.GroundAltitude.Value / 256d * 3.28084d;
            double agl = (double)Math.Round(Aircraft.Altitude.Value - groundAlt);
            if (takeOffAssistantActive && Aircraft.OnGround.Value == 0 && agl >= 100)
            {
                //var airSpeed = Autopilot.ApAirspeed;
                //Autopilot.ApAirspeed = airSpeed;
                Autopilot.ApAirspeedHold = true;
                Autopilot.ApAltitude = 32000;
                Autopilot.ApAltitudeLock = true;
                if (Aircraft.ApWingLeveler.Value == 1) Aircraft.ApWingLeveler.Value = 0; // Off.
                if (!Autopilot.ApHeadingLock) Autopilot.ApHeadingLock = true;
                Aircraft.AutoBrake.Value = 1; // Off.    
                Aircraft.ApYawDamper.Value = 1; // On.
                Autopilot.ApVerticalSpeedHold = true;
                Autopilot.ApVerticalSpeed = 2500; // Slowly increase for smoother transition.
                Aircraft.LandingGearControl.Value = 0; // Gear up.
                takeOffAssistantActive = false;
                isTakeoffComplete = true;
                fireOnScreenReaderOutputEvent(isGauge: false, output: "Takeoff assist off.");
                return isTakeoffComplete;
            }
            else
            {
                return isTakeoffComplete;
            }

        } // End PostTakeoffChecklist.
    }
}
