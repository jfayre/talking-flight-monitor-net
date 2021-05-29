using tfm.PMDG;
using tfm.PMDG.PanelObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfm
{
static      class PMDG777
    {
public static  PanelObject[] PanelControls
        {
            get => new PanelObject[]
            {
                new SingleStateToggle {Offset = Aircraft.pmdg777.BRAKES_ParkingBrakeLeverOn, Name = "Parking break", Verbosity = AircraftVerbosity.Low, PanelName = "Forward", PanelSection = "CDU", AvailableStates = new Dictionary<byte, string> { { 1, "on" }, { 0, "off" }, },  },

            };
        }
    } // End PMDG777 class.
} // End namespace.
