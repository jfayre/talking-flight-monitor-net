using FSUIPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimConnector
{
    public class SimData
    {
        private bool _isConnectionOpen;
        public bool IsConnectionOpen
        {
            get
            {
                _isConnectionOpen = FSUIPCConnection.IsOpen;
                return _isConnectionOpen;
            }
        }
    }
}
