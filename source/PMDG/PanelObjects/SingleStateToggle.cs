using FSUIPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfm.PMDG.PanelObjects
{
    class SingleStateToggle: PanelObject
    {

        private Offset<byte> _offset;
        private PanelObjectType _type = PanelObjectType.SingleState;
                private Dictionary<byte, string> _availableStates = null;
        private KeyValuePair<byte, string> _currentState;

        public Dictionary<byte, string> AvailableStates { get => _availableStates; set => _availableStates = value; }
        public KeyValuePair<byte, string> CurrentState
        {
            get
            {
                                KeyValuePair<byte, string> item = new KeyValuePair<byte, string>();

                if (this._type == PanelObjectType.Dial)
                {
                    
                    // Convert offset value to a percent.
                    double percent = ((this._offset.Value - 1) * 100) / (150 - 1);

                    // Round it to the nearest whole number.
                    percent = Math.Round(percent, 0);
                    item = new KeyValuePair<byte, string>(this._offset.Value, $"{percent}%");
                                                        }
                else
                {

                    foreach (KeyValuePair<byte, string> pair in this._availableStates)
                    {
                        if (Aircraft.pmdg777.BRAKES_ParkingBrakeLeverOn.Value == pair.Key)
                        {
                            item = pair;
                            break;
                        }
                    }
                }                                    
                return item;
            } // End Get    
        } // End CurrentState.
                public override PanelObjectType Type => this._type;

        public override Offset Offset
        {
            get => this._offset;
            set
            {
                this._offset = (Offset<byte>)value;
                base.Offset = value;
            }
        }


        public override string ToString()
        {
                return $"{this.Name}: {this.CurrentState.Value}";
                                } // End ToString.
           } // End SingleStateToggle.
}// End namespace.
