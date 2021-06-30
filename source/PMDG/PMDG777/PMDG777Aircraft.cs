using tfm.PMDG;
using tfm.PMDG.PanelObjects;
using FSUIPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace tfm
{
static class PMDG777Aircraft
    {

        // The MCP dialogs.
        private static System.Windows.Forms.Form speedBox = new tfm.PMDG.PMDG777.McpComponents.SpeedBox();
        private static System.Windows.Forms.Form altitudeBox = new tfm.PMDG.PMDG777.McpComponents.AltitudeBox();
        private static System.Windows.Forms.Form headingBox = new tfm.PMDG.PMDG777.McpComponents.HeadingBox();
        private static System.Windows.Forms.Form verticalSpeedBox = new tfm.PMDG.PMDG777.McpComponents.VerticalSpeedBox();


/* State dictionaries -
 * The state dictionaries are designed
 * to make creating panel objects eaiser. Each dictionary
 * is a list of 'states' each panel control
 * will look for. The result is found in
 *the panel object's CurrentState property. Each list
 *below is named with the byte = 1 item first, then
 *the byte = 0 item last. Where more than two
 *values are present for a panel object state, it is named after the panel control. EX:
 *_backupPowerStates is used with the backup power switch. */

        private static  Dictionary<byte, string> _onOrOffStates = new Dictionary<byte, string>()
        {
            {0, "off" },
            {1, "on" },
        };

        private static  Dictionary<byte, string> _offOrOnStates = new Dictionary<byte, string>
        {
            {0, "on" },
            {1, "off" },
        };
        private static Dictionary<byte, string> _autoOrOffStates = new Dictionary<byte, string>
        {
            {0, "off" },
            {1, "auto" },
        };

        private static Dictionary<byte, string> _standbyPowerStates = new Dictionary<byte, string>
        {
            { 0, "off" },
            {1, "auto" },
            {2, "battery" },
        };

        private static Dictionary<byte, string> _testOrOffStates = new Dictionary<byte, string>
        {
            {0, "off" },
            {1, "test" },
        };
        private static Dictionary<byte, string> _batteryOrOffStates = new Dictionary<byte, string>
        {
            {0, "off" },
            {1, "battery" },
        };

        private static Dictionary<byte, string> _cargoTempStates = new Dictionary<byte, string>
        {
            {0, "off" },
            {1, "low" },
            {2, "high" },
        };

        private static Dictionary<byte, string> _apuStates = new Dictionary<byte, string>
        {
            {0, "off" },
            {1, "on" },
            {2, "start" },
        };

        private static Dictionary<byte, string> _momentaryControlState = new Dictionary<byte, string>
        {
            {1, "pressed" },
        };

        private static Dictionary<byte, string> _connectOrDisconnectStates = new Dictionary<byte, string>
        {
            {0, "disconnected" },
            {1, "connected" },
        };

        private static Dictionary<byte, string> _availableOrUnavailableStates = new Dictionary<byte, string>
        {
            {0, "unavailable" },
            {1, "available" },
        };

        private static Dictionary<byte, string> _wiperStates = new Dictionary<byte, string>
        {
            {0, "off" },
            {1, "intermittent" },
            {2, "low" },
            {3, "high" },
        };

        private static  Dictionary<byte, string> _armedOnOrOffStates = new Dictionary<byte, string>
        {
            {0, "off" },
            {1, "armed" },
            {2, "on" },
        };

        private static Dictionary<byte, string> _autoOnOrOffStates = new Dictionary<byte, string>
        {
            {0, "off" },
            {1, "auto" },
            {2, "on" },
        };

        private static Dictionary<byte, string> _indoorLightTestStates = new Dictionary<byte, string>
        {
            {0, "test" },
            {1, "bright" },
            {2, "dim" },
        };

        private static Dictionary<byte, string> _apuFireHandleStates = new Dictionary<byte, string>
        {
            {0, "normal" },
            {1, "pulled" },
            {2, "turned left" }, // Momentary position.
            {3, "turned right" }, // Momentary position.
        };

        private static Dictionary<byte, string> _engineStartModeStates = new Dictionary<byte, string>
        {
            {0, "start" },
            {1, "normal" },
        };

        private static Dictionary<byte, string> _fuelToRemainStates = new Dictionary<byte, string>
        {
            {0, "pushed" },
            {1, "pulled" },
        };

        private static Dictionary<byte, string> _fuelSelectorStates = new Dictionary<byte, string>
        {
            {0, "decrease" },
            {1, "neutral" },
            {2, "increase" },
        };

        private static Dictionary<byte, string> _neutralClosedOrOpenStates = new Dictionary<byte, string>
        {
            {0, "opened" },
            {1, "neutral" },
            {2, "closed" },
        };

        private static Dictionary<byte, string> _neutralIncreaseOrDecrease = new Dictionary<byte, string>
        {
            {0, "decrease" },
            {1, "neutral" },
            {2, "increase" },
        };

        public static Dictionary<string, System.Windows.Forms.Form> McpComponents
        {
            get => new Dictionary<string, System.Windows.Forms.Form>
            {
                {"altitude", altitudeBox },
                {"speed", speedBox },
                {"heading", headingBox },
                {"vertical", verticalSpeedBox },
            };
        } // End McpComponents.
public static  PanelObject[] PanelControls
        {
            get => new PanelObject[]
            {
                new SingleStateToggle {Name = "Backup window heat/left side", PanelName = "Overhead maint.", PanelSection = "Backup window heat", Offset = Aircraft.pmdg777.ICE_WindowHeatBackUp_Sw_OFF[0], Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Medium, AvailableStates = _offOrOnStates },
new SingleStateToggle{Name = "Backup window heat/Right side", PanelName = "Overhead maint.", PanelSection = "Backup window heat", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Medium, Offset = Aircraft.pmdg777.ICE_WindowHeatBackUp_Sw_OFF[1], AvailableStates = _offOrOnStates },
new SingleStateToggle{Name = "Standby power", PanelName = "Overhead Maint.", PanelSection = "Standby power", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_StandbyPowerSw, AvailableStates = _standbyPowerStates },
new SingleStateToggle{Name = "Left wing hyd. valve", PanelName = "Overhead Maint.", PanelSection = "Flight controls", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Medium, Offset = Aircraft.pmdg777.FCTL_WingHydValve_Sw_SHUT_OFF[0], AvailableStates = _offOrOnStates },
new SingleStateToggle{Name = "Right wing hyd. valve", PanelName = "Overhead Maint.", PanelSection = "Flight controls", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Medium, Offset = Aircraft.pmdg777.FCTL_WingHydValve_Sw_SHUT_OFF[1], AvailableStates = _offOrOnStates },
new SingleStateToggle{Name = "Center wing hyd. valve", PanelName = "Overhead Maint.", PanelSection = "Flight controls", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Medium, Offset = Aircraft.pmdg777.FCTL_WingHydValve_Sw_SHUT_OFF[2], AvailableStates = _offOrOnStates },
new SingleStateToggle{Name = "Left tail hyd. valve", PanelName = "Overhead Maint.", PanelSection = "Flight controls", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Medium, Offset = Aircraft.pmdg777.FCTL_TailHydValve_Sw_SHUT_OFF[0], AvailableStates = _offOrOnStates },
new SingleStateToggle{Name = "Right tail hyd. valve", PanelName = "Overhead Maint.", PanelSection = "Flight controls", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Medium, Offset = Aircraft.pmdg777.FCTL_TailHydValve_Sw_SHUT_OFF[1], AvailableStates = _offOrOnStates },
new SingleStateToggle{Name = "Center tail hyd. valve", PanelName = "Overhead Maint.", PanelSection = "Flight controls", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Medium, Offset = Aircraft.pmdg777.FCTL_TailHydValve_Sw_SHUT_OFF[2], AvailableStates = _offOrOnStates },
new SingleStateToggle{Name = "APU power", PanelName = "Overhead Maint.", PanelSection = "APU Maint.", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.APU_Power_Sw_TEST, AvailableStates = _testOrOffStates},
new SingleStateToggle{Name = "Engine #1 EEC power", PanelName = "Overhead Maint.", PanelSection = "EEC Maint.", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Medium, Offset = Aircraft.pmdg777.ENG_EECPower_Sw_TEST[0], AvailableStates = _testOrOffStates },
new SingleStateToggle{Name = "Engine #2 EEC power", PanelName = "Overhead Maint.", PanelSection = "EEC Maint.", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Medium, Offset = Aircraft.pmdg777.ENG_EECPower_Sw_TEST[1], AvailableStates = _testOrOffStates },
new SingleStateToggle{Name = "Towing power", PanelName = "Overhead Maint.", PanelSection = "Electrical", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Medium, Offset = Aircraft.pmdg777.ELEC_TowingPower_Sw_BATT, AvailableStates = _batteryOrOffStates },
new SingleStateToggle{Name = "AFT cargo temp.", PanelName = "Overhead Maint.", PanelSection = "Cargo temp", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Medium, Offset = Aircraft.pmdg777.AIR_CargoTemp_Selector[0], AvailableStates = _cargoTempStates },
new SingleStateToggle{Name = "Bulk cargo temp.", PanelName = "Overhead Maint.", PanelSection = "Cargo temp", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Medium, Offset = Aircraft.pmdg777.AIR_CargoTemp_Selector[1], AvailableStates = _cargoTempStates },
new SingleStateToggle{Name = "Adiru", PanelName = "Overhead", PanelSection = "Adiru", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ADIRU_Sw_On, AvailableStates = _onOrOffStates },
new SingleStateToggle{Name = "Thurst Asym comp", PanelName = "Overhead", PanelSection = "Flight controls", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.FCTL_ThrustAsymComp_Sw_AUTO, AvailableStates = _autoOrOffStates },
new SingleStateToggle{Name = "Cabin utility", PanelName = "Overhead", PanelSection = "Electrical", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_CabUtilSw, AvailableStates = _onOrOffStates },
new SingleStateToggle{Name = "Passenger seat power", PanelName = "Overhead", PanelSection = "Electrical", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_IFEPassSeatsSw, AvailableStates = _onOrOffStates },
new SingleStateToggle{Name = "Battery", PanelName = "Overhead", PanelSection = "Electrical", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_Battery_Sw_ON, AvailableStates = _onOrOffStates },
new SingleStateToggle{Name = "APU generator", PanelName = "Overhead", PanelSection = "Electrical", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_APUGen_Sw_ON, AvailableStates = _onOrOffStates },
new SingleStateToggle{Name = "APU", PanelName = "Overhead", PanelSection = "Electrical", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_APU_Selector, AvailableStates = _apuStates },
new SingleStateToggle{Name = "Bus tie #1", PanelName = "Overhead", PanelSection = "Electrical", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_BusTie_Sw_AUTO[0], AvailableStates = _autoOrOffStates },
new SingleStateToggle{Name = "Bus tie #2", PanelName = "Overhead", PanelSection = "Electrical", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_BusTie_Sw_AUTO[1], AvailableStates = _autoOrOffStates },
new SingleStateToggle{Name = "Primary ground power", PanelName = "Overhead", PanelSection = "Electrical", Type = PanelObjectType.MomintaryPushButton, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_ExtPwrSw[0], AvailableStates = _momentaryControlState },
new SingleStateToggle{Name = "Secondary ground power", PanelName = "Overhead", PanelSection = "Electrical", Type = PanelObjectType.MomintaryPushButton, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_ExtPwrSw[1], AvailableStates = _momentaryControlState },
new SingleStateToggle{Name = "Primary ground power", PanelName = "Overhead", PanelSection = "Electrical", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_annunExtPowr_AVAIL[0], AvailableStates = _availableOrUnavailableStates },
new SingleStateToggle{Name = "Secondary ground power", PanelName = "Overhead", PanelSection = "Electrical", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_annunExtPowr_AVAIL[1], AvailableStates = _availableOrUnavailableStates },
new SingleStateToggle{Name = "Primary ground power", PanelName = "Overhead", PanelSection = "Electrical", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_annunExtPowr_ON[0], AvailableStates = _connectOrDisconnectStates },
new SingleStateToggle{Name = "Secondary ground power", PanelName = "Overhead", PanelSection = "Electrical", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_annunExtPowr_ON[1], AvailableStates = _connectOrDisconnectStates },
new SingleStateToggle{Name = "Generator #1", PanelName = "Overhead", PanelSection = "Electrical", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_Gen_Sw_ON[0], AvailableStates = _onOrOffStates },
new SingleStateToggle{Name = "Generator #2", PanelName = "Overhead", PanelSection = "Electrical", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_Gen_Sw_ON[1], AvailableStates = _onOrOffStates },
new SingleStateToggle{Name = "Backup generator #1", PanelName = "Overhead", PanelSection = "Electrical", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_BackupGen_Sw_ON[0], AvailableStates = _onOrOffStates },
new SingleStateToggle{Name = "Backup generator #2", PanelName = "Overhead", PanelSection = "Electrical", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_BackupGen_Sw_ON[1], AvailableStates = _onOrOffStates },
new SingleStateToggle{Name = "IDG #1", PanelName = "Overhead", PanelSection = "Electrical", Type = PanelObjectType.MomintaryPushButton, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_IDGDiscSw[0], AvailableStates = _momentaryControlState },
new SingleStateToggle{Name = "IDG #2", PanelName = "Overhead", PanelSection = "Electrical", Type = PanelObjectType.MomintaryPushButton, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_IDGDiscSw[1], AvailableStates = _momentaryControlState },
new SingleStateToggle{Name = "IDG #1", PanelName = "Overhead", PanelSection = "Electrical", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_annunIDGDiscDRIVE[0], AvailableStates = _connectOrDisconnectStates },
new SingleStateToggle{Name = "IDG #2", PanelName = "Overhead", PanelSection = "Electrical", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ELEC_annunIDGDiscDRIVE[1], AvailableStates = _connectOrDisconnectStates },
new SingleStateToggle{Name = "Left wipers", PanelName = "Overhead", PanelSection = "Wipers", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.WIPERS_Selector[0], AvailableStates = _wiperStates },
new SingleStateToggle{Name = "Right wipers", PanelName = "Overhead", PanelSection = "Wipers", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.WIPERS_Selector[1], AvailableStates = _wiperStates },
new SingleStateToggle{Name = "Emergency lights", PanelName = "Overhead", PanelSection = "Emergency lights", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.LTS_EmerLightsSelector, AvailableStates = _armedOnOrOffStates },
new SingleStateToggle{Name = "Service interphone", PanelName = "Overhead", PanelSection = "Service interphone", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.High, Offset = Aircraft.pmdg777.COMM_ServiceInterphoneSw, AvailableStates = _onOrOffStates },
new SingleStateToggle{Name = "Passenger oxygen", PanelName = "Overhead", PanelSection = "Passenger oxygen", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.OXY_PassOxygen_Sw_On, AvailableStates = _onOrOffStates },
new SingleStateToggle{Name = "Left window heat", PanelName = "Overhead", PanelSection = "Window heat", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ICE_WindowHeat_Sw_ON[0], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Left FWD window heat", PanelName = "Overhead", PanelSection = "Window heat", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ICE_WindowHeat_Sw_ON[1], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Right FWD window heat", PanelName = "Overhead", PanelSection = "Window heat", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ICE_WindowHeat_Sw_ON[2], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Right window heat", PanelName = "Overhead", PanelSection = "Window heat", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ICE_WindowHeat_Sw_ON[3], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Ram turbine", PanelName = "Overhead", PanelSection = "Hydraulics", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Medium, Offset = Aircraft.pmdg777.HYD_RamAirTurbineSw, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Engine #1 primary pump", PanelName = "Overhead", PanelSection = "Hydraulics", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.HYD_PrimaryEngPump_Sw_ON[0], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Engine #2 primary pump", PanelName = "Overhead", PanelSection = "Hydraulics", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.HYD_PrimaryEngPump_Sw_ON[1], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Primary electrical pump #1", PanelName = "Overhead", PanelSection = "Hydraulics", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.HYD_PrimaryElecPump_Sw_ON[0], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Primary electrical pump #2", PanelName = "Overhead", PanelSection = "Hydraulics", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.HYD_PrimaryElecPump_Sw_ON[1], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Electrical demand pump #1", PanelName = "Overhead", PanelSection = "Hydraulics", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.HYD_DemandElecPump_Selector[0], AvailableStates = _autoOnOrOffStates},
new SingleStateToggle{Name = "Electrical demand pump #2", PanelName = "Overhead", PanelSection = "Hydraulics", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.HYD_DemandElecPump_Selector[1], AvailableStates = _autoOnOrOffStates},
new SingleStateToggle{Name = "Air demand pump #1", PanelName = "Overhead", PanelSection = "Hydraulics", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.HYD_DemandAirPump_Selector[0], AvailableStates = _autoOnOrOffStates},
new SingleStateToggle{Name = "Air demand pump #2", PanelName = "Overhead", PanelSection = "Hydraulics", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.HYD_DemandAirPump_Selector[1], AvailableStates = _autoOnOrOffStates},
new SingleStateToggle{Name = "No smoking sign", PanelName = "Overhead", PanelSection = "Passenger signs", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.SIGNS_NoSmokingSelector, AvailableStates = _autoOnOrOffStates},
new SingleStateToggle{Name = "Seatbelt sign", PanelName = "Overhead", PanelSection = "Passenger signs", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.SIGNS_SeatBeltsSelector, AvailableStates = _autoOnOrOffStates},
new SingleStateToggle{Name = "Dome light", PanelName = "Overhead", PanelSection = "Flight deck lights", Type = PanelObjectType.Dial, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.LTS_DomeLightKnob, AvailableStates = null},
new SingleStateToggle{Name = "Circuit breaker light", PanelName = "Overhead", PanelSection = "Flight deck lights", Type = PanelObjectType.Dial, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.LTS_CircuitBreakerKnob, AvailableStates = null},
new SingleStateToggle{Name = "Overhead panel light", PanelName = "Overhead", PanelSection = "Flight deck lights", Type = PanelObjectType.Dial, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.LTS_OvereadPanelKnob, AvailableStates = null},
new SingleStateToggle{Name = "Glare shield panel light", PanelName = "Overhead", PanelSection = "Flight deck lights", Type = PanelObjectType.Dial, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.LTS_GlareshieldPNLlKnob, AvailableStates = null},
new SingleStateToggle{Name = "Glare shield flood light", PanelName = "Overhead", PanelSection = "Flight deck lights", Type = PanelObjectType.Dial, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.LTS_GlareshieldFLOODKnob, AvailableStates = null},
new SingleStateToggle{Name = "Storm light", PanelName = "Overhead", PanelSection = "Flight deck lights", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.LTS_Storm_Sw_ON, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Master brightness", PanelName = "Overhead", PanelSection = "Flight deck lights", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.LTS_MasterBright_Sw_ON, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Master brightness light", PanelName = "Overhead", PanelSection = "Flight deck lights", Type = PanelObjectType.Dial, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.LTS_MasterBrigntKnob, AvailableStates = null},
new SingleStateToggle{Name = "Indoor lights test", PanelName = "Overhead", PanelSection = "Flight deck lights", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.LTS_IndLightsTestSw, AvailableStates = _indoorLightTestStates},
new SingleStateToggle{Name = "Left landing lights", PanelName = "Overhead", PanelSection = "Exterior lights", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.LTS_LandingLights_Sw_ON[0], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Right landing lights", PanelName = "Overhead", PanelSection = "Exterior lights", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.LTS_LandingLights_Sw_ON[1], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Nose landing lights", PanelName = "Overhead", PanelSection = "Exterior lights", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.LTS_LandingLights_Sw_ON[2], AvailableStates = _onOrOffStates},
new SingleStateToggle {Name = "Beacon light", PanelName = "Overhead", PanelSection = "Exterior lights", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.LTS_Beacon_Sw_ON, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Navigation lights", PanelName = "Overhead", PanelSection = "Exterior lights", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.LTS_NAV_Sw_ON, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Logo lights", PanelName = "Overhead", PanelSection = "Exterior lights", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.LTS_Logo_Sw_ON, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Wing lights", PanelName = "Overhead", PanelSection = "Exterior lights", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.LTS_Wing_Sw_ON, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Left runway turnoff lights", PanelName = "Overhead", PanelSection = "Exterior lights", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.LTS_RunwayTurnoff_Sw_ON[0], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Right runway turnoff lights", PanelName = "Overhead", PanelSection = "Exterior lights", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.LTS_RunwayTurnoff_Sw_ON[1], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Taxi lights", PanelName = "Overhead", PanelSection = "Exterior lights", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.LTS_Taxi_Sw_ON, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Strobe lights", PanelName = "Overhead", PanelSection = "Exterior lights", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.LTS_Strobe_Sw_ON, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "FWD cargo fire arm", PanelName = "Overhead", PanelSection = "Cargo/APU fire", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.FIRE_CargoFire_Sw_Arm[0], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "AFT cargo fire arm", PanelName = "Overhead", PanelSection = "Cargo/APU fire", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.FIRE_CargoFire_Sw_Arm[1], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Cargo fire discharge", PanelName = "Overhead", PanelSection = "Cargo/APU fire", Type = PanelObjectType.MomintaryPushButton, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.FIRE_CargoFireDisch_Sw, AvailableStates = _momentaryControlState},
new SingleStateToggle{Name = "Cargo fire discharge light", PanelName = "Overhead", PanelSection = "Cargo/APU fire", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.FIRE_annunCargoDISCH, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Fire overheat test", PanelName = "Overhead", PanelSection = "Cargo/APU fire", Type = PanelObjectType.MomintaryPushButton, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.FIRE_FireOvhtTest_Sw, AvailableStates = _momentaryControlState},
new SingleStateToggle{Name = "APU fire handle", PanelName = "Overhead", PanelSection = "Cargo/APU fire", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.FIRE_APUHandle, AvailableStates = _apuFireHandleStates},
new SingleStateToggle{Name = "APU fire handle unlock switch", PanelName = "Overhead", PanelSection = "Cargo/APU fire", Type = PanelObjectType.MomintaryPushButton, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.FIRE_APUHandleUnlock_Sw, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Engine #1 EEC normal mode", PanelName = "Overhead", PanelSection = "Engines", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ENG_EECMode_Sw_NORM[0], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Engine #2 EEC normal mode", PanelName = "Overhead", PanelSection = "Engines", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ENG_EECMode_Sw_NORM[1], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Engine #1 start mode", PanelName = "Overhead", PanelSection = "Engines", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ENG_Start_Selector[0], AvailableStates = _engineStartModeStates},
new SingleStateToggle{Name = "Engine #2 start mode", PanelName = "Overhead", PanelSection = "Engines", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ENG_Start_Selector[1], AvailableStates = _engineStartModeStates},
new SingleStateToggle{Name = "Engine autostart", PanelName = "Overhead", PanelSection = "Engines", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ENG_Autostart_Sw_ON, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "FWD cross feed", PanelName = "Overhead", PanelSection = "Fuel", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.FUEL_CrossFeedFwd_Sw, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "AFT cross feed", PanelName = "Overhead", PanelSection = "Fuel", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.FUEL_CrossFeedAft_Sw, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Left FWD fuel pump", PanelName = "Overhead", PanelSection = "Fuel", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.FUEL_PumpFwd_Sw[0], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Right FWD fuel pump", PanelName = "Overhead", PanelSection = "Fuel", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.FUEL_PumpFwd_Sw[1], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Left AFT fuel pump", PanelName = "Overhead", PanelSection = "Fuel", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.FUEL_PumpAft_Sw[0], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Right AFT fuel pump", PanelName = "Overhead", PanelSection = "Fuel", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.FUEL_PumpAft_Sw[1], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Left center fuel pump", PanelName = "Overhead", PanelSection = "Fuel", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.FUEL_PumpCtr_Sw[0], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Right center fuel pump", PanelName = "Overhead", PanelSection = "Fuel", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.FUEL_PumpCtr_Sw[1], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Left jettison nozel", PanelName = "Overhead", PanelSection = "Fuel", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.FUEL_JettisonNozle_Sw[0], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Right jettison nozel", PanelName = "Overhead", PanelSection = "Fuel", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.FUEL_JettisonNozle_Sw[1], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Jettison arm", PanelName = "OVerhead", PanelSection = "Fuel", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.FUEL_JettisonArm_Sw, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Fuel to remain switch", PanelName = "Overhead", PanelSection = "Fuel", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.FUEL_FuelToRemain_Sw_Pulled, AvailableStates = _fuelToRemainStates},
new SingleStateToggle{Name = "Fuel to remain", PanelName = "Overhead", PanelSection = "Fuel", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.FUEL_FuelToRemain_Selector, AvailableStates = _fuelSelectorStates},
new SingleStateToggle{Name = "Wing anti ice", PanelName = "Overhead", PanelSection = "Anti ice", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ICE_WingAntiIceSw, AvailableStates = _autoOnOrOffStates},
new SingleStateToggle{Name = "Engine #1 anti ice", PanelName = "Overhead", PanelSection = "Anti ice", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ICE_EngAntiIceSw[0], AvailableStates = _autoOnOrOffStates},
new SingleStateToggle{Name = "Engine #2 anti ice", PanelName = "Overhead", PanelSection = "Anti ice", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.ICE_EngAntiIceSw[1], AvailableStates = _autoOnOrOffStates},
new SingleStateToggle{Name = "Left pack", PanelName = "Overhead", PanelSection = "Air conditioning", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.AIR_Pack_Sw_AUTO[0], AvailableStates = _autoOrOffStates},
new SingleStateToggle{Name = "Right pack", PanelName = "Overhead", PanelSection = "Air conditioning", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.AIR_Pack_Sw_AUTO[1], AvailableStates = _autoOrOffStates},
new SingleStateToggle{Name = "Left air trim", PanelName = "Overhead", PanelSection = "Air conditioning", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.AIR_TrimAir_Sw_On[0], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Right air trim", PanelName = "Overhead", PanelSection = "Air conditioning", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.AIR_TrimAir_Sw_On[1], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Upper recirculation fan", PanelName = "Overhead", PanelSection = "Air conditioning", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.AIR_RecircFan_Sw_On[0], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Lower recirculation fan", PanelName = "Overhead", PanelSection = "Air conditioning", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.AIR_RecircFan_Sw_On[1], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Air conditioning reset", PanelName = "Overhead", PanelSection = "Air conditioning", Type = PanelObjectType.MomintaryPushButton, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.AIR_AirCondReset_Sw_Pushed, AvailableStates = _momentaryControlState},
new SingleStateToggle{Name = "Equipment cooling", PanelName = "Overhead", PanelSection = "Air conditioning", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.AIR_EquipCooling_Sw_AUTO, AvailableStates = _autoOrOffStates},
new SingleStateToggle{Name = "Gasper", PanelName = "Overhead", PanelSection = "Air conditioning", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.AIR_Gasper_Sw_On, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Engine #1 bleed air", PanelName = "Overhead", PanelSection = "Bleed air", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.AIR_EngBleedAir_Sw_AUTO[0], AvailableStates = _autoOrOffStates},
new SingleStateToggle{Name = "Engine #2 bleed air", PanelName = "Overhead", PanelSection = "Bleed air", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.AIR_EngBleedAir_Sw_AUTO[1], AvailableStates = _autoOrOffStates},
new SingleStateToggle{Name = "APU bleed air", PanelName = "OVerhead", PanelSection = "Bleed air", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.AIR_APUBleedAir_Sw_AUTO, AvailableStates = _autoOrOffStates},
new SingleStateToggle{Name = "Left isolation valve", PanelName = "Overhead", PanelSection = "Bleed air", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.AIR_IsolationValve_Sw[0], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Right isolation valve", PanelName = "Overhead", PanelSection = "Bleed air", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.AIR_IsolationValve_Sw[1], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Center isolation valve", PanelName = "Overhead", PanelSection = "Bleed air", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.AIR_CtrIsolationValve_Sw, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "FWD outflow valve", PanelName = "OVerhead", PanelSection = "Pressurization", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.AIR_OutflowValve_Sw_AUTO[0], AvailableStates = _autoOrOffStates},
new SingleStateToggle{Name = "AFT outflow valve", PanelName = "OVerhead", PanelSection = "Pressurization", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.AIR_OutflowValve_Sw_AUTO[1], AvailableStates = _autoOrOffStates},
new SingleStateToggle{Name = "FWD outflow valve selector", PanelName = "Overhead", PanelSection = "Pressurization", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.AIR_OutflowValveManual_Selector[0], AvailableStates = _neutralClosedOrOpenStates},
new SingleStateToggle{Name = "AFT outflow valve selector", PanelName = "Overhead", PanelSection = "Pressurization", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.AIR_OutflowValveManual_Selector[1], AvailableStates = _neutralClosedOrOpenStates},
new SingleStateToggle{Name = "Landing altitude pressurization", PanelName = "Overhead", PanelSection = "Pressurization", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.AIR_LdgAlt_Sw_Pulled, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Landing altitude", PanelName = "Overhead", PanelSection = "Pressurization", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.AIR_LdgAlt_Selector, AvailableStates = _neutralIncreaseOrDecrease},
new SingleStateToggle{Name = "Left Flight director", PanelName = "Glare shield", PanelSection = "MCP", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.MCP_FD_Sw_On[0], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Right Flight director", PanelName = "Glare shield", PanelSection = "MCP", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.MCP_FD_Sw_On[1], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Left autothrottle", PanelName = "Glare shield", PanelSection = "MCP", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.MCP_ATArm_Sw_On[0], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Right autothrottle", PanelName = "Glare shield", PanelSection = "MCP", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.MCP_ATArm_Sw_On[1], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Disengage autopilot", PanelName = "Glare shield", PanelSection = "MCP", Type = PanelObjectType.Switch, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.MCP_DisengageBar, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Left Autopilot", PanelName = "Glare shield", PanelSection = "MCP", Type = PanelObjectType.MomintaryPushButton, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.MCP_AP_Sw_Pushed[0], AvailableStates = _momentaryControlState},
new SingleStateToggle{Name = "Right Autopilot", PanelName = "Glare shield", PanelSection = "MCP", Type = PanelObjectType.MomintaryPushButton, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.MCP_AP_Sw_Pushed[1], AvailableStates = _momentaryControlState},
new SingleStateToggle{Name = "Left autopilot", PanelName = "Glare shield", PanelSection = "MCP", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.MCP_annunAP[0], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Right autopilot", PanelName = "Glare shield", PanelSection = "MCP", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.MCP_annunAP[1], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Autothrottle", PanelName = "Glare shield", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.MCP_annunAT, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "LNav", PanelName = "Glare shield", PanelSection = "MCP", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.MCP_annunLNAV, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "VNav", PanelName = "Glare shield", PanelSection = "MCP", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.MCP_annunVNAV, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Level change", PanelName = "Glare shield", PanelSection = "MCP", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.MCP_annunFLCH, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Heading hold", PanelName = "Glare shield", PanelSection = "MCP", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.MCP_annunHDG_HOLD, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "VS/FPA", PanelName = "Glare shield", PanelSection = "MCP", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.MCP_annunVS_FPA, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Altitude hold", PanelName = "Glare shield", PanelSection = "MCP", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.MCP_annunALT_HOLD, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Localizer hold", PanelName = "Glare shield", PanelSection = "MCP", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.MCP_annunLOC, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Approach mode", PanelName = "Glare shield", PanelSection = "MCP", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.MCP_annunAPP, AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Left master warning", PanelName = "Glare shield", PanelSection = "Warnings", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.WARN_annunMASTER_WARNING[0], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Right master warning", PanelName = "Glare shield", PanelSection = "Warnings", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.WARN_annunMASTER_WARNING[1], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Left master caution", PanelName = "Glare shield", PanelSection = "Warnings", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.WARN_annunMASTER_CAUTION[0], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Right master caution", PanelName = "Glare shield", PanelSection = "Warnings", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.WARN_annunMASTER_CAUTION[1], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "Execute key", PanelName = "Forward Aisle Stand", PanelSection = "CDU", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.CDU_annunEXEC[0], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "CDU message light", PanelName = "Forward Aisle Stand", PanelSection = "CDU", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.CDU_annunMSG[0], AvailableStates = _onOrOffStates},
new SingleStateToggle{Name = "CDU offset light", PanelName = "Forward Aisle Stand", PanelSection = "CDU", Type = PanelObjectType.Annunciator, Verbosity = AircraftVerbosity.Low, Offset = Aircraft.pmdg777.CDU_annunOFST[0], AvailableStates = _onOrOffStates},
            };
        } // End PanelControls.

        public static void ShowSpeedBox()
        {
                            // Show the speed box.
                McpComponents["speed"].Show();
                    } // End ShowSpeedBox.

        public static void ShowAltitudeBox()
        {
            McpComponents["altitude"].Show();
        } // End ShowAltitudeBox.

        public static void ShowVerticalSpeedBox()
        {
            McpComponents["vertical"].Show();
        } // End ShowVerticalSpeedBox.
        public static  int CalculateMachParameter(float machSpeed)
        {
            return (int)(machSpeed / 0.01);
        } // End CalculateMachParameter.

        public static void AltitudeIntervene()
        {
            FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_ALTITUDE_PUSH_SWITCH, Aircraft.ClkL);
        } // End AltitudeInterVene

        public  static void VerticalSpeed_FPAIntervene()
        {
            FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_VS_SWITCH, Aircraft.ClkL);
        } // End VerticalSpeed_FPAIntervene.

        public static void ToggleVNav()
        {
            FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_VNAV_SWITCH, Aircraft.ClkL);
        } // End ToggleVNav.

        public static void ToggleAltitudeHold()
        {
            FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_ALT_HOLD_SWITCH, Aircraft.ClkL);
        } // End ToggleAltitudeHold.

        public static void ToggleLevelChange()
        {
            FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_LVL_CHG_SWITCH, Aircraft.ClkL);
        } // End ToggleLevelChange.
        public static void SetAltitude(string altitudeText)
        {
            short.TryParse(altitudeText, out short altitude);
            FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_ALT_SET, altitude);
        } // End SetAltitude().

        public static void ToggleVsFPAMode()
        {
            FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_VS_FPA_SWITCH, Aircraft.ClkL);
        } // End ToggleVs_FPAMode.

public static int CalculateVerticalSpeedParameter(ushort vs)
        {
            return vs + 10000;
        } // End CalculateVerticalSpeedParameter.

        public static double CalculateFPAParameter(float FPA)
        {
            return (FPA + 10) / 0.1;
        } // End CalculateFPAParameter.

        public static void SetHeading(string headingText)
        {
            ushort.TryParse(headingText, out ushort heading);
            FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_HDGTRK_SET, heading);
        } // End SetHeading.

        public static void HeadingIntervene()
        {
            FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_HEADING_PUSH_SWITCH, Aircraft.ClkL);
        } // End HeadingIntervene.

        public static void ToggleHeadingHold()
        {
            FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_HDG_HOLD_SWITCH, Aircraft.ClkL);
        } // End ToggleHeadingHold.

        public static void ToggleLNav()
        {
            FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_LNAV_SWITCH, Aircraft.ClkL);
        } // End ToggleLnav.

        public static void ToggleHeadingTrack()
        {
            FSUIPCConnection.SendControlToFS(PMDG_777X_Control.EVT_MCP_HDG_TRK_SWITCH, Aircraft.ClkL);
        } // End ToggleHeadingTrack.
    } // End PMDG777 class.
} // End namespace.
