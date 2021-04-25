using DavyKager;
using FSUIPC;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace tfm
{
    public static class Aircraft
    {
        // =====================================
        // DECLARE OFFSETS YOU WANT TO USE HERE
        // =====================================
        public static Offset<short> SimPauseControl = new Offset<short>(0x0262);
        public static Offset<short> SimPauseIndicator = new Offset<short>(0x0264);
        public static Offset<short> SimSoundFlag = new Offset<short>(0x0b24);
        public static  Offset<ushort> Com1Freq = new Offset<ushort>(0x034e);
        public static  Offset<ushort> Com1StandbyFreq = new Offset<ushort>(0x311a);
        public static  Offset<ushort> Com2Freq = new Offset<ushort>(0x3118);
        public static  Offset<ushort> Com2StandbyFreq = new Offset<ushort>(0x311c);
        public static  Offset<FsBitArray> RadioAudio = new Offset<FsBitArray>(0x3122, 1);
        public static Offset<ushort> Nav1Freq = new Offset<ushort>(0x0350);
        public static Offset<ushort> Nav2Freq = new Offset<ushort>(0x0352);
        // ADF frequencies are split over 2 offsets, the 'main' and 'extended'.
        public static Offset<ushort> adf1Main = new Offset<ushort>(0x034C);
        public static Offset<ushort> adf1Extended = new Offset<ushort>(0x0356);

        public static  Offset<FsLatitude> aircraftLat = new Offset<FsLatitude>(0x0560, 8);
        public static  Offset<FsLongitude> aircraftLon = new Offset<FsLongitude>(0x0568, 8);
        public static  Offset<short> Flaps = new Offset<short>(0x30f0);
        public static  Offset<short> OnGround = new Offset<short>(0x0366);
        public static  Offset<short> ParkingBrake = new Offset<short>(0x0bc8);
        public static  Offset<uint> LandingGear = new Offset<uint>(0x0bec);
        public static Offset<uint> LandingGearControl = new Offset<uint>(0x0BE8);
        public static Offset<uint> ElevatorControll = new Offset<uint>(0x0BB2);
        public static  Offset<int> Altitude = new Offset<int>(0x3324);
        public static  Offset<int> GroundAltitude = new Offset<int>(0x0020);
        public static  Offset<uint> SpoilersArm = new Offset<uint>(0x0bcc);
        public static  Offset<uint> Spoilers = new Offset<uint>(0x0bd0);
        public static Offset<byte> SeatbeltSign = new Offset<byte>(0x341d);
        public static Offset<byte> NoSmokingSign = new Offset<byte>(0x341c);

        public static  Offset<uint> AvionicsMaster = new Offset<uint>(0x2e80);
        public static  Offset<uint> ApMaster = new Offset<uint>(0x07bc);
        public static  Offset<uint> ApNavLock = new Offset<uint>(0x07c4);
        public static  Offset<uint> ApHeadingLock = new Offset<uint>(0x07c8);
        public static  Offset<ushort> ApHeading = new Offset<ushort>(0x07cc);
        public static  Offset<uint> ApAltitudeLock = new Offset<uint>(0x07d0);
        public static  Offset<uint> ApAltitude = new Offset<uint>(0x07d4);
        public static  Offset<uint> ApSpeedHold = new Offset<uint>(0x07dc);
        public static  Offset<uint> ApMachHold = new Offset<uint>(0x07e4);
        public static  Offset<short> ApAirspeed = new Offset<short>(0x07e2);
        public static  Offset<uint> ApMach = new Offset<uint>(0x07e8);
        public static  Offset<uint> ApVerticalSpeedHold = new Offset<uint>(0x07ec);
        public static  Offset<short> ApVerticalSpeed = new Offset<short>(0x07f2);
        public static  Offset<uint> ApNavGPS = new Offset<uint>(0x132c);
        public static  Offset<uint> ApApproachHold = new Offset<uint>(0x0800);
        public static  Offset<uint> ApGlideSlopeHold = new Offset<uint>(0x07fc);
        public static  Offset<uint> ApFlightDirector = new Offset<uint>(0x2ee0);
        public static  Offset<double> ApFlightDirectorPitch = new Offset<double>(0x2ee8);
        public static  Offset<double> ApFlightDirectorBank = new Offset<double>(0x2ef0);
        public static  Offset<uint> ApAttitudeHold = new Offset<uint>(0x07d8);
        public static  Offset<uint> ApWingLeveler = new Offset<uint>(0x07c0);
        public static  Offset<uint> PropSync = new Offset<uint>(0x243c);
        public static  Offset<short> ApAutoRudder = new Offset<short>(0x0278);
        public static  Offset<uint> BatteryMaster = new Offset<uint>(0x281c);
        public static  Offset<byte> Alternator = new Offset<byte>(0x3101);
        public static  Offset<uint> Heading = new Offset<uint>(0x0580);
        public static  Offset<short> MagneticVariation = new Offset<short>(0x02a0);
        public static  Offset<ushort> Transponder = new Offset<ushort>(0x0354);
        public static  Offset<double> CompassHeading = new Offset<double>(0x2b00);
        public static  Offset<double> NextWPDistance = new Offset<double>(0x6048);
        public static Offset<string> NextWPName = new Offset<string>(0x60a4, 6);
        public static  Offset<uint> NextWPETE = new Offset<uint>(0x60e4);
        public static  Offset<byte> AutoBrake = new Offset<byte>(0x2f80);
        public static  Offset<uint> AirspeedTrue = new Offset<uint>(0x02b8);
        public static  Offset<uint> AirspeedIndicated = new Offset<uint>(0x02bc);
        public static  Offset<uint> GroundSpeed = new Offset<uint>(0x02b4);
        public static  Offset<uint> ApYawDamper = new Offset<uint>(0x0808);
        public static  Offset<uint> Toga = new Offset<uint>(0x080c);
        public static  Offset<uint> AutoThrottleArm = new Offset<uint>(0x0810);
        public static  Offset<uint> AutoFeather = new Offset<uint>(0x2438);
        public static  Offset<short> AirspeedMach = new Offset<short>(0x11c6);
        public static  Offset<uint> NextWPETA = new Offset<uint>(0x60e8);
        public static  Offset<double> NextWPBaring = new Offset<double>(0x6050);
        public static Offset<string> DestinationAirportID = new Offset<string>(0x6137, 5);
        public static  Offset<uint> DestinationTimeEnroute = new Offset<uint>(0x6198);
        public static  Offset<double> RouteDistance = new Offset<double>(0x61a0);
        public static  Offset<double> FuelBurn = new Offset<double>(0x61a8);
        public static  Offset<uint> FuelQuantity = new Offset<uint>(0x126c);
        public static  Offset<double> ElevatorTrim = new Offset<double>(0x2ea0);
        public static  Offset<double> AileronTrim = new Offset<double>(0x2eb0);
        public static  Offset<double> RudderTrim = new Offset<double>(0x2ec0);
        public static  Offset<short> VerticalSpeed = new Offset<short>(0x0842);
        public static Offset<int> LandingRate = new Offset<int>(0x030C);
        public static Offset<byte> StallWarning = new Offset<byte>(0x036C);
        public static Offset<byte> OverSpeedWarning = new Offset<byte>(0x036D);
        public static  Offset<short> AirTemp = new Offset<short>(0x0e8c);
        public static  Offset<byte> Nav1GS = new Offset<byte>(0x0c4c);
        public static  Offset<short> Nav1LocaliserInverseRunwayHeading = new Offset<short>(0x0870);

        public static Offset<sbyte> Nav1GSNeedle = new Offset<sbyte>(0x0c49);
        public static Offset<sbyte> Nav1LocNeedle = new Offset<sbyte>(0x0c48);
        public static Offset<string> Vor1ID = new Offset<string>(0x3000, 6);
        public static Offset<string> Vor1Name = new Offset<string>(0x3006, 25);
        public static Offset<ushort> Nav1GSInclination = new Offset<ushort>(0x0872);
        public static Offset<ushort> Nav1OBS = new Offset<ushort>(0x0C4E);
        public static Offset<ushort> Nav1Radial = new Offset<ushort>(0x0C50);

        public static  Offset<FsBitArray> Nav1Flags = new Offset<FsBitArray>(0x0c4d, 1);
        public enum NavFlag
        {
            DMEAvailable,
            TACAN,
            VoiceAvailable,
            NoSignal,
            DMEGSCoLocated,
            NoBackCourse,
            GSAvailable,
            NavType
        }

        public static  Offset<uint> Nav1Signal = new Offset<uint>(0x0c52);
        public static  Offset<ushort> Nav2OBS = new Offset<ushort>(0x0C5E);
        public static  Offset<ushort> Nav2Radial = new Offset<ushort>(0x0C60);

        /* Additional radio and autopilot status indicators (read only access). Allocation by bits which are set when true. Bit 0 = least significant (value 1):
0  = reserved
1  = good NAV1
2  = good NAV2
3  = good ADF1
4  = NAV1 has DME
5  = NAV2 has DME
6  = NAV1 is ILS
7  = AP NAV1 radial acquired
8  = AP ILS LOC acquired (incl BC—see 10)
9  = AP ILS GS acquired
10=AP ILS LOC is BC
11=good ADF2
12=NAV2 is ILS
13–15 reserved */
        public static Offset<FsBitArray> AutopilotRadioStatus = new Offset<FsBitArray>(0x3300, 2);
        public static Offset<ushort> Altimeter = new Offset<ushort>(0x0330);
        public static  Offset<FsBitArray> Doors = new Offset<FsBitArray>(0x3367, 1);
        public static  Offset<byte> APUGenerator = new Offset<byte>("LowPriority", 0x0b51);
        public static  Offset<byte> APUGeneratorActive = new Offset<byte>(0x0b52);
        public static  Offset<float> APUPercentage = new Offset<float>(0x0b54);
        public static  Offset<float> APUVoltage = new Offset<float>(0x0b5c);
        public static  Offset<double> Eng1RPM = new Offset<double>(0x2400);
        public static  Offset<uint> Eng1Starter = new Offset<uint>("LowPriority", 0x3b00);
        public static  Offset<uint> Eng2Starter = new Offset<uint>("LowPriority", 0x3a40);
        public static  Offset<uint> Eng3Starter = new Offset<uint>("LowPriority", 0x3980);
        public static  Offset<uint> Eng4Starter = new Offset<uint>("LowPriority", 0x38c0);
        public static  Offset<double> Eng1FuelFlow = new Offset<double>(0x2060);
        public static  Offset<double> Eng2FuelFlow = new Offset<double>(0x2160);
        public static  Offset<double> Eng3FuelFlow = new Offset<double>(0x2260);
        public static  Offset<double> Eng4FuelFlow = new Offset<double>(0x2360);
        public static  Offset<double> Eng1N1 = new Offset<double>(0x2010);
        public static  Offset<uint> Eng4Generator = new Offset<uint>("LowPriority", 0x393c);
        public static  Offset<uint> Eng3Generator = new Offset<uint>("LowPriority", 0x39fc);
        public static  Offset<uint> Eng2Generator = new Offset<uint>("LowPriority", 0x3abc);
        public static  Offset<uint> Eng1Generator = new Offset<uint>("LowPriority", 0x3b7c);
        public static Offset<short> Engine1ThrottleLever = new Offset<short>(0x088c);
        public static Offset<short> Engine2ThrottleLever = new Offset<short>(0x0924);
        public static Offset<short> Engine3ThrottleLever = new Offset<short>(0x09bc);
        public static Offset<short> Engine4ThrottleLever = new Offset<short>(0x0a54);
        public static Offset<double> Engine1JetThrust = new Offset<double>(0x204c);
        public static Offset<double> Engine2JetThrust = new Offset<double>(0x214c);
        public static Offset<double> Engine3JetThrust = new Offset<double>(0x224c);
        public static Offset<double> Engine4JetThrust = new Offset<double>(0x234c);

        public static  Offset<double> Eng1N2 = new Offset<double>(0x2018);
        public static  Offset<double> Eng2N1 = new Offset<double>(0x2110);
        public static  Offset<double> Eng2N2 = new Offset<double>(0x2118);
        public static  Offset<double> Eng3N1 = new Offset<double>(0x2210);
        public static  Offset<double> Eng3N2 = new Offset<double>(0x2218);
        public static  Offset<double> Eng4N1 = new Offset<double>(0x2310);
        public static  Offset<double> Eng4N2 = new Offset<double>(0x2318);
        public static  Offset<ushort> Eng1Combustion = new Offset<ushort>("LowPriority", 0x0894);
        public static  Offset<ushort> Eng2Combustion = new Offset<ushort>("LowPriority", 0x092c);
        public static  Offset<ushort> Eng3Combustion = new Offset<ushort>("LowPriority", 0x09c4);
        public static  Offset<ushort> Eng4Combustion = new Offset<ushort>("LowPriority", 0x0a5c);
        public static  Offset<uint> Eng1ITT = new Offset<uint>(0x08f0);
        public static  Offset<uint> Eng2ITT = new Offset<uint>(0x0988);
        public static  Offset<uint> Eng3ITT = new Offset<uint>(0x0a20);
        public static  Offset<uint> Eng4ITT = new Offset<uint>(0x0ab8);
        public static  Offset<uint> Eng1FuelValve = new Offset<uint>("LowPriority", 0x3590);
        public static  Offset<uint> Eng2FuelValve = new Offset<uint>("LowPriority", 0x3594);
        public static  Offset<uint> Eng3FuelValve = new Offset<uint>("LowPriority", 0x3598);
        public static  Offset<uint> Eng4FuelValve = new Offset<uint>("LowPriority", 0x359c);
        public static  Offset<byte> PitotHeat = new Offset<byte>(0x029c);
        public static Offset<FsBitArray> Lights = new Offset<FsBitArray>(0x0d0c, 2);
        public enum light
        {
            Navigation,
            Beacon,
            Landing,
            Taxi,
            Strobe,
            Instruments,
            Recognition,
            Wing,
            Logo,
            Cabin
        }

        public static  Offset<ushort> WindSpeed = new Offset<ushort>(0x0e90);
        public static  Offset<ushort> WindDirection = new Offset<ushort>(0x0e92);
        public static  Offset<ushort> WindGust = new Offset<ushort>(0x0e94);
        public static  Offset<uint> RadioAltimeter = new Offset<uint>(0x31e4);
        public static  Offset<byte> FuelPump = new Offset<byte>(0x3104);
        public static  Offset<ushort> num_engines = new Offset<ushort>(0x0aec);
        public static  Offset<double> eng1_fuel_flow = new Offset<double>(0x0918);
        public static  Offset<double> eng2_fuel_flow = new Offset<double>(0x09b0);
        public static  Offset<double> eng3_fuel_flow = new Offset<double>(0x0a48);
        public static  Offset<double> eng4_fuel_flow = new Offset<double>(0x0ae0);
        public static Offset<BitArray> EngineSelectFlags = new Offset<BitArray>(0x0888, 1);
        public enum EngSelect
        {
            Eng1,
            Eng2,
            Eng3,
            Eng4
        }

        public static  Offset<double> GyroSuction = new Offset<double>(0x0b18);
        public static  Offset<byte> OilQuantity = new Offset<byte>(0x66c9);
        public static  Offset<string> AircraftName = new Offset<string>(0x3d00, 255);
        public static Offset<byte> EngineType = new Offset<byte>(0x0609);
        public static Offset<double> Engine1RPM = new Offset<double>(0x2400);
        public static Offset<double> Engine2RPM = new Offset<double>(0x2500);
        public static Offset<double> Engine3RPM = new Offset<double>(0x2600);
        public static Offset<double> Engine4RPM = new Offset<double>(0x2700);
        public static Offset<short> Engine1ManifoldPressure = new Offset<short>(0x08c0);
        public static Offset<short> Engine2ManifoldPressure = new Offset<short>(0x0958);
        public static Offset<short> Engine3ManifoldPressure = new Offset<short>(0x09f0);
        public static Offset<short> Engine4ManifoldPressure = new Offset<short>(0x0a88);
        public static Offset<double> Engine1CHT = new Offset<double>(0x08e8);
        public static Offset<double> Engine2CHT = new Offset<double>(0x0980);
        public static Offset<double> Engine3CHT = new Offset<double>(0x0a18);
        public static Offset<double> Engine4CHT = new Offset<double>(0x0ab0);
        public static Offset<double> Engine1EGT = new Offset<double>(0x3b70);
        public static Offset<double> Engine2EGT = new Offset<double>(0x3ab0);
        public static Offset<double> Engine3EGT = new Offset<double>(0x39f0);
        public static Offset<double> Engine4EGT = new Offset<double>(0x3930);
        public static Offset<double> CenterOfGravity = new Offset<double>("Payload", 0x2ef8);
        // atitude mode offsets
        public static Offset<int> AttitudePitch = new Offset<int>("attitude", 0x0578);
        public static Offset<int> AttitudeBank = new Offset<int>("attitude", 0x057c);
        public static  TextMenu textMenu = new TextMenu();
        public static Offset<ushort> SimulationRate = new Offset<ushort>(0x0c1a);
        // PMDG offsets. These are all read-only. Writing is done via the PMDG control codes.
        public static PMDG_737_NGX_Offsets pmdg737 = new PMDG_737_NGX_Offsets();
        public static PMDG_747QOTSII_Offsets pmdg747 = new PMDG_747QOTSII_Offsets();
        // define a few PMDG offsets that aren't included in the .net library.
        public static Offset<string> AIR_DisplayFltAlt = new Offset<string>(0x6C82, 6);
        public static Offset<string> AIR_DisplayLandAlt = new Offset<string>(0x6C88, 6);


        // constants for PMDG mouse click parameters
        public const int ClkL = 536870912;
        public const int ClkR = -2147483648;
        public const int Inc = 16384;
        public const int Dec = 8192;

        public static void InitOffsets()
        {
            // forces static fields to be initialised.
        }
        public static double ConvertRadiansToDegrees(double radians)
        {
            double degrees = (180 / Math.PI) * radians;
            return (degrees);
        }

public static double n1MonitorValue { set; get; }        
    }
}
