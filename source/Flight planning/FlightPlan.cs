using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSUIPC;

namespace tfm
{
    static public  class FlightPlan
    {
        #region Private fields
        private static string _title = string.Empty;
        private static FsAirport _departureAirport = null;
        private static FsAirport _destinationAirport = null;
        private static FsRunway _departureRunway;
        private static FsRunway _destinationRunway;

        #endregion
        #region Public properties
        static public string Title
        {
            get
            {
                if(Destination != null && Departure != null)
                {
                    return $"{Departure.Name} to {Destination.Name}";
                }
                else
                {
                    return "Untitled flight plan";
                }
            }
            set
            {
                if(value.Length < 4)
                {
                    throw new ArgumentException("The flight plan title must be longer than 4 characters in length.");
                }
                else
                {
                    _title = value;
                }
            }
        }
        static public FsAirport Departure
        {
            get
            {
                return _departureAirport;
            }
            set
            {
                _departureAirport = value;
            }
        }
        static public FsAirport Destination
        {
            get
            {
                return _destinationAirport;
            }
            set
            {
                _destinationAirport = value;
            }
        }
        static public FsRunway DepartureRunway
        {
            get
            {
                return _departureRunway;
            }
            set
            {
                _departureRunway = value;
            }
        }
        static public FsRunway DestinationRunway
        {
            get
            {
                return _destinationRunway;
            }
            set
            {
                _destinationRunway = value;
            }
        }

        #endregion

    }
}
