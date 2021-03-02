using FSUIPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimConnector
{
    public class InstrumentPanel
    {
        private double aslAltitude;
        public double AslAltitude
        {
            get
            {
                aslAltitude = Math.Round((double)OffsetDeclarations.Altitude.Value, 0);
                return aslAltitude;
            }
        }
        private double heading;
        public double Heading
        {
            get
            {
                heading = Math.Round(OffsetDeclarations.CompassHeading.Value);
                return heading;
            }
        }
        private double aglAltitude;
        public double AglAltitude
        {
            get
            {
                double groundAlt = OffsetDeclarations.GroundAltitude.Value / 256d * 3.28084d;
                aglAltitude = OffsetDeclarations.Altitude.Value - groundAlt;
                return Math.Round(aglAltitude);
            }
        }
        private double indicatedAirspeed;
        public double IndicatedAirspeed
        {
            get
            {
                indicatedAirspeed = OffsetDeclarations.AirspeedIndicated.Value / 128d;
                return Math.Round(indicatedAirspeed);
            }
        }
        private double trueAirspeed;
        public double TrueAirspeed
        {
            get
            {
                trueAirspeed = OffsetDeclarations.AirspeedTrue.Value / 128d;
                return Math.Round(trueAirspeed);
            }
        }
        private double machSpeed;
        public double MachSpeed
        {
            get
            {
                machSpeed = OffsetDeclarations.AirspeedMach.Value / 20480d;
                return Math.Round(machSpeed, 2);
            }
        }
        private double latitude;
        public double Latitude
        {
            get
            {
                latitude = OffsetDeclarations.aircraftLat.Value.DecimalDegrees;
                return latitude;
            }
        }

        private double longitude;
        public double Longitude
        {
            get
            {
                longitude = OffsetDeclarations.aircraftLon.Value.DecimalDegrees;
                return longitude;
            }
        }

        private double verticalSpeed;
        public double VerticalSpeed
        {
            get
            {
                verticalSpeed = OffsetDeclarations.VerticalSpeed.Value * 3.28084d * -1;
                return Math.Round(verticalSpeed);
            }
        }

        private bool apMaster;

        [DisplayName("autopilot master switch")]
        public bool ApMaster
        {
            get
            {
                apMaster = OffsetDeclarations.ApMaster.Value != 0;
                return apMaster;
            }
            set
            {
                OffsetDeclarations.ApMaster.Value = value ? 1 : (uint)0;
                apMaster = value;
            }
        }

        private bool apNavLock;

        [DisplayName("nav lock")]
        public bool ApNavLock
        {
            get
            {
                apNavLock = OffsetDeclarations.ApNavLock.Value == 0 ? false : true;
                return apNavLock;
            }
            set
            {
                OffsetDeclarations.ApNavLock.Value = value ? 1 : (uint)0;
                apNavLock = value;
            }
        }
        private bool apWingLeveler;
        [DisplayName("Wing Leveler")]
        public bool ApWingLeveler
        {
            get
            {
                apWingLeveler = OffsetDeclarations.ApWingLeveler.Value == 0 ? false : true;
                return apWingLeveler;
            }
            set
            {
                OffsetDeclarations.ApWingLeveler.Value = value ? 1 : (uint)0;
                apWingLeveler = value;
            }
        }
        private bool apAttitudeHold;
        [DisplayName("attitude hold")]
        public bool ApAttitudeHold
        {
            get
            {
                apAttitudeHold = OffsetDeclarations.ApAttitudeHold.Value == 0 ? false : true;
                return apAttitudeHold;
            }
            set
            {
                OffsetDeclarations.ApAttitudeHold.Value = value ? 1 : (uint)0;
                apAttitudeHold = value;
            }
        }
        private bool apApproachHold;
        [DisplayName("Approach hold")]
        public bool ApApproachHold
        {
            get
            {
                apApproachHold = OffsetDeclarations.ApApproachHold.Value == 0 ? false : true;
                return apApproachHold;
            }
            set
            {
                OffsetDeclarations.ApApproachHold.Value = value ? 1 : (uint)0;
                apApproachHold = value;
            }

        }
        private double apHeading;
        [DisplayName("Heading")]
        public double ApHeading
        {
            get
            {
                apHeading = Math.Round(OffsetDeclarations.ApHeading.Value / 65536d * 360d);
                return apHeading;
            }
            set
            {
                // convert the supplied heading into the proper FSUIPC format(degrees*65536/360)
                OffsetDeclarations.ApHeading.Value = (ushort)(value * 65536 / 360);
                apHeading = value;
            }
        }
        private bool apHeadingLock;
        [DisplayName("heading lock")]
        public bool ApHeadingLock
        {
            get
            {
                apHeadingLock = OffsetDeclarations.ApHeadingLock.Value == 0 ? false : true;
                return apHeadingLock;
            }
            set
            {
                OffsetDeclarations.ApHeadingLock.Value = value ? 1 : (uint)0;
                apHeadingLock = value;
            }
        }
        private double apAltitude;
        [DisplayName("Altitude")]
        public double ApAltitude
        {
            get
            {
                apAltitude = Math.Round(OffsetDeclarations.ApAltitude.Value / 65536d * 3.28084d);
                return apAltitude;
            }
            set
            {
                OffsetDeclarations.ApAltitude.Value = (uint)(value / 3.28084 * 65536);
                apAltitude = value;
            }
        }
        private bool apAltitudeLock;
        [DisplayName("altitude lock")]
        public bool ApAltitudeLock
        {
            get
            {
                apAltitudeLock = OffsetDeclarations.ApAltitudeLock.Value == 0 ? false : true;
                return apAltitudeLock;
            }
            set
            {
                OffsetDeclarations.ApAltitudeLock.Value = value ? 1 : (uint)0;
                apAltitudeLock = value;
            }
        }

        private double apAirspeed;
        [DisplayName("Airspeed")]
        public double ApAirspeed
        {
            get
            {
                apAirspeed = OffsetDeclarations.ApAirspeed.Value;
                return apAirspeed;
            }
            set
            {
                OffsetDeclarations.ApAirspeed.Value = (short)value;
                apAirspeed = value;
            }
        }
        private bool apAirspeedHold;
        [DisplayName("airspeed hold")]
        public bool ApAirspeedHold
        {
            get
            {
                apAirspeedHold = OffsetDeclarations.ApSpeedHold.Value == 0 ? false : true;
                return apAirspeedHold;
            }
            set
            {
                OffsetDeclarations.ApSpeedHold.Value = value ? 1 : (uint)0;
                apAirspeedHold = value;
            }
        }

        private double apMachSpeed;
        [DisplayName("Mach")]
        public double ApMachSpeed
        {
            get
            {
                double mach = OffsetDeclarations.ApMach.Value / 65536d;
                string strMach = mach.ToString("F2");
                apMachSpeed = double.Parse(strMach);
                return apMachSpeed;
            }
            set
            {
                // FSUIPC needs the mach multiplied by 65536            }
                OffsetDeclarations.ApMach.Value = (uint)(value * 65536);
                apMachSpeed = value;
            }
        }
        private bool apMachHold;
        [DisplayName("mach hold")]
        public bool ApMachHold
        {
            get
            {
                apMachHold = OffsetDeclarations.ApMachHold.Value == 0 ? false : true;
                return apMachHold;
            }
            set
            {
                OffsetDeclarations.ApMachHold.Value = value ? 1 : (uint)0;
                apMachHold = value;
            }
        }


        private double apVerticalSpeed;
        [DisplayName("Vertical speed")]
        public double ApVerticalSpeed
        {
            get
            {
                apVerticalSpeed = OffsetDeclarations.ApVerticalSpeed.Value;
                return apVerticalSpeed;
            }
            set
            {
                OffsetDeclarations.ApVerticalSpeed.Value = (short)value;
                apVerticalSpeed = value;

            }
        }
        private bool apVerticalSpeedHold;
        [DisplayName("vertical speed hold")]
        public bool ApVerticalSpeedHold
        {
            get
            {
                apVerticalSpeedHold = OffsetDeclarations.ApVerticalSpeedHold.Value == 0 ? false : true;
                return apVerticalSpeedHold;
            }
            set
            {
                OffsetDeclarations.ApVerticalSpeedHold.Value = value ? 1 : (uint)0;
                apVerticalSpeedHold = value;
            }
        }
        private decimal com1Freq;
        [DisplayName("com 1")]
        [Category("communications")]
        public decimal Com1Freq
        {
            get
            {
                FsFrequencyCOM com1Helper = new FsFrequencyCOM(OffsetDeclarations.Com1Freq.Value);
                com1Freq = com1Helper.ToDecimal();
                return com1Freq;
            }
            set
            {
                // 1. Create a new instance of the COM helper class using the decimal value entered
                FsFrequencyCOM com1Helper = new FsFrequencyCOM(value);
                // 2. Now use the helper class to get the BCD value required by FSUIPC and set the offset to this new value
                OffsetDeclarations.Com1Freq.Value = com1Helper.ToBCD();
                com1Freq = value;
            }
        }

        private decimal com1StandbyFreq;
        [DisplayName("com 1 Standby")]
        [Category("communications")]
        public decimal Com1StandbyFreq
        {
            get
            {
                FsFrequencyCOM com1StandbyHelper = new FsFrequencyCOM(OffsetDeclarations.Com1StandbyFreq.Value);
                com1StandbyFreq = com1StandbyHelper.ToDecimal();
                return com1StandbyFreq;
            }
            set
            {
                // 1. Create a new instance of the COM helper class using the decimal value entered
                FsFrequencyCOM com1StandbyHelper = new FsFrequencyCOM(value);
                // 2. Now use the helper class to get the BCD value required by FSUIPC and set the offset to this new value
                OffsetDeclarations.Com1StandbyFreq.Value = com1StandbyHelper.ToBCD();
                com1StandbyFreq = value;
            }
        }

        private decimal com2Freq;
        [DisplayName("com 2")]
        [Category("communications")]
        public decimal Com2Freq
        {
            get
            {
                FsFrequencyCOM com2Helper = new FsFrequencyCOM(OffsetDeclarations.Com2Freq.Value);
                com2Freq = com2Helper.ToDecimal();
                return com2Freq;
            }
            set
            {
                // 1. Create a new instance of the COM helper class using the decimal value entered
                FsFrequencyCOM com2Helper = new FsFrequencyCOM(value);
                // 2. Now use the helper class to get the BCD value required by FSUIPC and set the offset to this new value
                OffsetDeclarations.Com2Freq.Value = com2Helper.ToBCD();
                com2Freq = value;
            }
        }
        private int transponder;
        [DisplayName("transponder")]
        [Category("communications")]
        public int Transponder
        {
            get
            {
                FsTransponderCode txHelper = new FsTransponderCode(OffsetDeclarations.Transponder.Value);
                transponder = txHelper.ToInteger();
                return transponder;
            }
            set
            {
                // 1. Create a new instance of the Transponder helper class using the integer that was entered
                //    Note the number box always returns the value as a 'decimal' type. So we have to cast to Int32
                FsTransponderCode txHelper = new FsTransponderCode(value);
                // 2. Now use the helper class to get the BCD value required by FSUIPC and set the offset to this new value
                OffsetDeclarations.Transponder.Value = txHelper.ToBCD();
                transponder = value;
            }
        }
        private decimal adf1Freq;
        [DisplayName("ADF frequency")]
        [Category("navigation")]
        public decimal Adf1Freq
        {
            get
            {
                // 1. Create a new instance of the helper ADF class using the values of the main AND extended offsets
                //    This is taking in the BCD values sent from FSUIPC
                FsFrequencyADF adf1Helper = new FsFrequencyADF(OffsetDeclarations.adf1Main.Value, OffsetDeclarations.adf1Extended.Value);
                // 2. Now use the helper class to get the string representation and show it on the form
                adf1Freq = adf1Helper.ToDecimal();
                return adf1Freq;
            }
            set
            {
                // 1. Create a new instance of the ADF helper class using the decimal value entered
                FsFrequencyADF adf1Helper = new FsFrequencyADF(value);
                // 2. Now use the helper class to get the two BCD values required by FSUIPC (main and extended)
                //    Set the offsets to these new values
                OffsetDeclarations.adf1Main.Value = adf1Helper.ToBCDMain();
                OffsetDeclarations.adf1Extended.Value = adf1Helper.ToBCDExtended();
                adf1Freq = value;
            }
        }
        private double altimeterQNH;
        [DisplayName("Altimeter QNH")]
        public double AltimeterQNH
        {
            get
            {
                double AltQNH = OffsetDeclarations.Altimeter.Value / 16d;
                altimeterQNH = Math.Floor(AltQNH + 0.5);
                return altimeterQNH;
            }
            set
            {
                OffsetDeclarations.Altimeter.Value = (ushort)(value * 16);
                altimeterQNH = value;
            }
        }
        private double altimeterInches;
        [DisplayName("Altimeter Inches")]
        public double AltimeterInches
        {
            get
            {
                double AltQNH = OffsetDeclarations.Altimeter.Value / 16d;
                altimeterInches = Math.Floor(100 * AltQNH * 29.92 / 1013.2 + 0.5);
                altimeterInches = altimeterInches / 100;
                return altimeterInches;
            }
            set
            {
                double qnh = value * 33.864;
                qnh = Math.Round(qnh, 1) * 16;
                OffsetDeclarations.Altimeter.Value = (ushort)qnh;
                altimeterInches = value;

            }
        }

        private decimal nav1Freq;
        [DisplayName("nav 1")]
        [Category("navigation")]
        public decimal Nav1Freq
        {
            get
            {
                FsFrequencyNAV nav1Helper = new FsFrequencyNAV(OffsetDeclarations.Nav1Freq.Value);
                nav1Freq = nav1Helper.ToDecimal();
                return nav1Freq;
            }
            set
            {
                // 1. Create a new instance of the COM helper class using the decimal value entered
                FsFrequencyNAV nav1Helper = new FsFrequencyNAV(value);
                // 2. Now use the helper class to get the BCD value required by FSUIPC and set the offset to this new value
                OffsetDeclarations.Nav1Freq.Value = nav1Helper.ToBCD();
                nav1Freq = value;
            }
        }
        private ushort nav1Course;
        public ushort Nav1Course
        {
            get
            {
                nav1Course = OffsetDeclarations.Nav1OBS.Value;
                return nav1Course;
            }
            set
            {
                OffsetDeclarations.Nav1OBS.Value = value;
                nav1Course = value;
            }
        }
        private decimal nav2Freq;
        [DisplayName("nav 2")]
        [Category("navigation")]
        public decimal Nav2Freq
        {
            get
            {
                FsFrequencyNAV nav2Helper = new FsFrequencyNAV(OffsetDeclarations.Nav2Freq.Value);
                nav2Freq = nav2Helper.ToDecimal();
                return nav2Freq;
            }
            set
            {
                // 1. Create a new instance of the NAV helper class using the decimal value entered
                FsFrequencyNAV nav2Helper = new FsFrequencyNAV(value);
                // 2. Now use the helper class to get the BCD value required by FSUIPC and set the offset to this new value
                OffsetDeclarations.Nav2Freq.Value = nav2Helper.ToBCD();
                nav2Freq = value;
            }
        }
        private ushort nav2Course;
        public ushort Nav2Course
        {
            get
            {
                nav2Course = OffsetDeclarations.Nav2OBS.Value;
                return nav2Course;
            }
            set
            {
                OffsetDeclarations.Nav2OBS.Value = value;
                nav2Course = value;
            }
        }

        // engine throttle properties
        private double engine1ThrottlePercent;
        public double Engine1ThrottlePercent
        {
            get
            {
                engine1ThrottlePercent = OffsetDeclarations.Engine1ThrottleLever.Value / 16384d * 100d;
                return engine1ThrottlePercent;
            }
            set
            {
                value = value / 100 * 16384;
                OffsetDeclarations.Engine1ThrottleLever.Value = (short)value;
            }
        }
        private double engine2ThrottlePercent;
        public double Engine2ThrottlePercent
        {
            get
            {
                engine2ThrottlePercent = OffsetDeclarations.Engine2ThrottleLever.Value / 16384d * 100d;
                return engine2ThrottlePercent;
            }
            set
            {
                value = value / 100 * 16384;
                OffsetDeclarations.Engine2ThrottleLever.Value = (short)value;
            }
        }
        private double engine3ThrottlePercent;
        public double Engine3ThrottlePercent
        {
            get
            {
                engine3ThrottlePercent = OffsetDeclarations.Engine3ThrottleLever.Value / 16384d * 100d;
                return engine3ThrottlePercent;
            }
            set
            {
                value = value / 100 * 16384;
                OffsetDeclarations.Engine3ThrottleLever.Value = (short)value;
            }
        }
        private double engine4ThrottlePercent;
        public double Engine4ThrottlePercent
        {
            get
            {
                engine4ThrottlePercent = OffsetDeclarations.Engine4ThrottleLever.Value / 16384d * 100d;
                return engine4ThrottlePercent;
            }
            set
            {
                value = value / 100 * 16384;
                OffsetDeclarations.Engine4ThrottleLever.Value = (short)value;
            }
        }



    }
}
