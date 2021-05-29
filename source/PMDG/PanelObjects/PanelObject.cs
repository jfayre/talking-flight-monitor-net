using tfm.PMDG;
using FSUIPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfm.PMDG.PanelObjects
{
abstract class PanelObject
    {

        private string _name = string.Empty;
        private string _panelName = string.Empty;
        private string _panelSection = string.Empty;
        private AircraftVerbosity _verbosity = AircraftVerbosity.None;
        private PanelObjectType _type;
        
                                public string Name { get => _name; set => _name = value; }
        public string PanelName { get => _panelName; set => _panelName = value; }
        public string PanelSection { get => _panelSection; set => _panelSection = value; }
public AircraftVerbosity Verbosity { get => _verbosity; set => _verbosity = value; }
        public virtual  PanelObjectType Type { get => _type;}

    } // End PanelObject.
} // End namespace.
