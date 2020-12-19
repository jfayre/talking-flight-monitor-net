using FSUIPC;
using DavyKager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tfm
{
    public partial class AirportsForm : Form
    {
                private string[] numericComparisonTypes = { "Between", "Equals", "Greater than", "Less than" };
        private string[] stringComparisonTypes = { "Contains", "Starts with", "Ends with", "Equals" };
        private ComparisonType comparison;
        private bool isStringSearch = false;

        Action<ComparisonType> doBetween()
        {
            return comparison =>
            {
                if(comparison == ComparisonType.Between)
                {
                    var field = fieldComboBox.SelectedItem.ToString();
                    var lower = (double)lowerNumericSpinner.Value;
                    var upper = (double)upperNumericSpinner.Value;
                    List<ListViewItem> rows = new List<ListViewItem>();
                    List<FsAirport> airports = new List<FsAirport>();
                    var database = FSUIPC.FSUIPCConnection.AirportsDatabase;
                                        database.SetReferenceLocation();

                    switch(field)
                    {
                        case "Distance":
                            airports = database.Airports.Where(a => Math.Round(a.DistanceNauticalMiles) >= lower && Math.Round(a.DistanceNauticalMiles) <= upper).ToList();
                            break;
                        case "Bearing":
                            airports = database.Airports.Where(a => Math.Round(a.BearingToTrue) >= lower && Math.Round(a.BearingToTrue) <= upper).ToList();
                            break;
                        case "Altitude":
                            airports = database.Airports.Where(a => Math.Round(a.AltitudeFeet) >= lower && Math.Round(a.AltitudeFeet) <= upper).ToList();
                            break;
                    }

                    foreach (FsAirport airport in airports)
                    {
                        string[] row = { airport.Name, airport.ICAO, airport.City, airport.State, airport.Country, Math.Round(airport.BearingToTrue).ToString(), Math.Round(airport.AltitudeFeet).ToString(), Math.Round(airport.DistanceNauticalMiles).ToString() };
                        rows.Add(new ListViewItem(row));
                    }
                    Tolk.Output($"{rows.Count()} results found.");
                    airportsListView.BeginUpdate();
                    airportsListView.Items.AddRange(rows.ToArray());
                    airportsListView.EndUpdate();
                } // End comparison condition.
                            };
        } // End doBetween.

        Action<ComparisonType> doNumericEquals()
        {
            return comparison =>
            {
                if (comparison == ComparisonType.NumericEquals)
                {
                    var field = fieldComboBox.SelectedItem.ToString();
                    var lower = (double)lowerNumericSpinner.Value;
                                        List<ListViewItem> rows = new List<ListViewItem>();
                    List<FsAirport> airports = new List<FsAirport>();
                    var database = FSUIPC.FSUIPCConnection.AirportsDatabase;
                    database.SetReferenceLocation();

                    switch (field)
                    {
                        case "Distance":
                            airports = database.Airports.Where(a => Math.Round(a.DistanceNauticalMiles) == lower).ToList();
                            break;
                        case "Bearing":
                            airports = database.Airports.Where(a => Math.Round(a.BearingToTrue) == lower).ToList();
                            break;
                        case "Altitude":
                            airports = database.Airports.Where(a => Math.Round(a.AltitudeFeet) == lower).ToList();
                            break;
                    }

                    foreach (FsAirport airport in airports)
                    {
                        string[] row = { airport.Name, airport.ICAO, airport.City, airport.State, airport.Country, Math.Round(airport.BearingToTrue).ToString(), Math.Round(airport.AltitudeFeet).ToString(), Math.Round(airport.DistanceNauticalMiles).ToString() };
                        rows.Add(new ListViewItem(row));
                    }
                    Tolk.Output($"{rows.Count()} results found.");
                    airportsListView.BeginUpdate();
                    airportsListView.Items.AddRange(rows.ToArray());
                    airportsListView.EndUpdate();
                } // End comparison condition.
            };
        } // End doNumericEquals.

Action<ComparisonType> doGreaterThan()
        {
            return comparison =>
            {
                if (comparison == ComparisonType.GreaterThan)
                {
                    var field = fieldComboBox.SelectedItem.ToString();
                    var lower = (double)lowerNumericSpinner.Value;
                                        List<ListViewItem> rows = new List<ListViewItem>();
                    List<FsAirport> airports = new List<FsAirport>();
                    var database = FSUIPC.FSUIPCConnection.AirportsDatabase;
                    database.SetReferenceLocation();

                    switch (field)
                    {
                        case "Distance":
                            airports = database.Airports.Where(a => Math.Round(a.DistanceNauticalMiles) >= lower).ToList();
                            break;
                        case "Bearing":
                            airports = database.Airports.Where(a => Math.Round(a.BearingToTrue) >= lower).ToList();
                            break;
                        case "Altitude":
                            airports = database.Airports.Where(a => Math.Round(a.AltitudeFeet) >= lower).ToList();
                            break;
                    }

                    foreach (FsAirport airport in airports)
                    {
                        string[] row = { airport.Name, airport.ICAO, airport.City, airport.State, airport.Country, Math.Round(airport.BearingToTrue).ToString(), Math.Round(airport.AltitudeFeet).ToString(), Math.Round(airport.DistanceNauticalMiles).ToString() };
                        rows.Add(new ListViewItem(row));
                    }
                    Tolk.Output($"{rows.Count()} results found.");
                    airportsListView.BeginUpdate();
                    airportsListView.Items.AddRange(rows.ToArray());
                    airportsListView.EndUpdate();
                } // End comparison condition.
            };
        } // End doGreaterThan.

        Action<ComparisonType> doLessThan()
        {
            return comparison =>
            {
                if (comparison == ComparisonType.LessThan)
                {
                    var field = fieldComboBox.SelectedItem.ToString();
                    var lower = (double)lowerNumericSpinner.Value;
                    List<ListViewItem> rows = new List<ListViewItem>();
                    List<FsAirport> airports = new List<FsAirport>();
                    var database = FSUIPC.FSUIPCConnection.AirportsDatabase;
                    database.SetReferenceLocation();

                    switch (field)
                    {
                        case "Distance":
                            airports = database.Airports.Where(a => Math.Round(a.DistanceNauticalMiles) <= lower).ToList();
                            break;
                        case "Bearing":
                            airports = database.Airports.Where(a => Math.Round(a.BearingToTrue) <= lower).ToList();
                            break;
                        case "Altitude":
                            airports = database.Airports.Where(a => Math.Round(a.AltitudeFeet) <= lower).ToList();
                            break;
                    }

                    foreach (FsAirport airport in airports)
                    {
                        string[] row = { airport.Name, airport.ICAO, airport.City, airport.State, airport.Country, Math.Round(airport.BearingToTrue).ToString(), Math.Round(airport.AltitudeFeet).ToString(), Math.Round(airport.DistanceNauticalMiles).ToString() };
                        rows.Add(new ListViewItem(row));
                    }
                    Tolk.Output($"{rows.Count()} results found.");
                    airportsListView.BeginUpdate();
                    airportsListView.Items.AddRange(rows.ToArray());
                    airportsListView.EndUpdate();
                } // End comparison condition.
            };
        } // End doLessThan.

        Action<ComparisonType> doStringEquals()
        {
                    return comparison =>
            {
                if(comparison == ComparisonType.StringEquals)
                {
                    var field = fieldComboBox.SelectedItem.ToString();
                    var filter = textFilterTextBox.Text;
                                        List<ListViewItem> rows = new List<ListViewItem>();
        List<FsAirport> airports = new List<FsAirport>();
        var database = FSUIPC.FSUIPCConnection.AirportsDatabase;
        database.SetReferenceLocation();

                    switch(field)
                    {
                        case "Name":
                            airports = database.Airports.Where(a => a.Name == filter).ToList();
                            break;
                        case "ICAO":
                            airports = database.Airports.Where(a => a.ICAO == filter).ToList();
                            break;
                        case "City":
                            airports = database.Airports.Where(a => a.City == filter).ToList();
                            break;
                        case "State/Province":
                            airports = database.Airports.Where(a => a.State == filter).ToList();
                            break;
                        case "Country":
                            airports = database.Airports.Where(a => a.Country == filter).ToList();
                            break;
                    }

                    foreach (FsAirport airport in airports)
                    {
                        string[] row = { airport.Name, airport.ICAO, airport.City, airport.State, airport.Country, Math.Round(airport.BearingToTrue).ToString(), Math.Round(airport.AltitudeFeet).ToString(), Math.Round(airport.DistanceNauticalMiles).ToString() };
    rows.Add(new ListViewItem(row));
                    }
Tolk.Output($"{rows.Count()} results found.");
airportsListView.BeginUpdate();
airportsListView.Items.AddRange(rows.ToArray());
airportsListView.EndUpdate();
                } // End comparison condition.
                            };
                    }         // End doStringEquals.

        Action<ComparisonType> doContains()
        {
            return comparison =>
            {
                if (comparison == ComparisonType.Contains)
                {
                    var field = fieldComboBox.SelectedItem.ToString();
                    var filter = textFilterTextBox.Text;
                    List<ListViewItem> rows = new List<ListViewItem>();
                    List<FsAirport> airports = new List<FsAirport>();
                    var database = FSUIPC.FSUIPCConnection.AirportsDatabase;
                    database.SetReferenceLocation();

                    switch (field)
                    {
                        case "Name":
                            airports = database.Airports.Where(a => a.Name.Contains(filter)).ToList();
                            break;
                        case "ICAO":
                            airports = database.Airports.Where(a => a.ICAO.Contains(filter)).ToList();
                            break;
                        case "City":
                            airports = database.Airports.Where(a => a.City.Contains(filter)).ToList();
                            break;
                        case "State/Province":
                            airports = database.Airports.Where(a => a.State.Contains(filter)).ToList();
                            break;
                        case "Country":
                            airports = database.Airports.Where(a => a.Country.Contains(filter)).ToList();
                            break;
                    }

                    foreach (FsAirport airport in airports)
                    {
                        string[] row = { airport.Name, airport.ICAO, airport.City, airport.State, airport.Country, Math.Round(airport.BearingToTrue).ToString(), Math.Round(airport.AltitudeFeet).ToString(), Math.Round(airport.DistanceNauticalMiles).ToString() };
                        rows.Add(new ListViewItem(row));
                    }
                    Tolk.Output($"{rows.Count()} results found.");
                    airportsListView.BeginUpdate();
                    airportsListView.Items.AddRange(rows.ToArray());
                    airportsListView.EndUpdate();
                } // End comparison condition.
            };
            }

        Action<ComparisonType> doStartsWith()
        {
            return comparison =>
            {
                if (comparison == ComparisonType.StartsWith)
                {
                    var field = fieldComboBox.SelectedItem.ToString();
                    var filter = textFilterTextBox.Text;
                    List<ListViewItem> rows = new List<ListViewItem>();
                    List<FsAirport> airports = new List<FsAirport>();
                    var database = FSUIPC.FSUIPCConnection.AirportsDatabase;
                    database.SetReferenceLocation();

                    switch (field)
                    {
                        case "Name":
                            airports = database.Airports.Where(a => a.Name.StartsWith(filter)).ToList();
                            break;
                        case "ICAO":
                            airports = database.Airports.Where(a => a.ICAO.StartsWith(filter)).ToList();
                            break;
                        case "City":
                            airports = database.Airports.Where(a => a.City.StartsWith(filter)).ToList();
                            break;
                        case "State/Province":
                            airports = database.Airports.Where(a => a.State.StartsWith(filter)).ToList();
                            break;
                        case "Country":
                            airports = database.Airports.Where(a => a.Country.StartsWith(filter)).ToList();
                            break;
                    }

                    foreach (FsAirport airport in airports)
                    {
                        string[] row = { airport.Name, airport.ICAO, airport.City, airport.State, airport.Country, Math.Round(airport.BearingToTrue).ToString(), Math.Round(airport.AltitudeFeet).ToString(), Math.Round(airport.DistanceNauticalMiles).ToString() };
                        rows.Add(new ListViewItem(row));
                    }
                    Tolk.Output($"{rows.Count()} results found.");
                    airportsListView.BeginUpdate();
                    airportsListView.Items.AddRange(rows.ToArray());
                    airportsListView.EndUpdate();
                } // End comparison condition.
            };
            }

        Action<ComparisonType> doEndsWith()
        {
            return comparison =>
            {
                if (comparison == ComparisonType.EndsWith)
                {
                    var field = fieldComboBox.SelectedItem.ToString();
                    var filter = textFilterTextBox.Text;
                    List<ListViewItem> rows = new List<ListViewItem>();
                    List<FsAirport> airports = new List<FsAirport>();
                    var database = FSUIPC.FSUIPCConnection.AirportsDatabase;
                    database.SetReferenceLocation();

                    switch (field)
                    {
                        case "Name":
                            airports = database.Airports.Where(a => a.Name.EndsWith(filter)).ToList();
                            break;
                        case "ICAO":
                            airports = database.Airports.Where(a => a.ICAO.EndsWith(filter)).ToList();
                            break;
                        case "City":
                            airports = database.Airports.Where(a => a.City.EndsWith(filter)).ToList();
                            break;
                        case "State/Province":
                            airports = database.Airports.Where(a => a.State.EndsWith(filter)).ToList();
                            break;
                        case "Country":
                            airports = database.Airports.Where(a => a.Country.EndsWith(filter)).ToList();
                            break;
                    }

                    foreach (FsAirport airport in airports)
                    {
                        string[] row = { airport.Name, airport.ICAO, airport.City, airport.State, airport.Country, Math.Round(airport.BearingToTrue).ToString(), Math.Round(airport.AltitudeFeet).ToString(), Math.Round(airport.DistanceNauticalMiles).ToString() };
                        rows.Add(new ListViewItem(row));
                    }
                    Tolk.Output($"{rows.Count()} results found.");
                    airportsListView.BeginUpdate();
                    airportsListView.Items.AddRange(rows.ToArray());
                    airportsListView.EndUpdate();
                } // End comparison condition.
            };
            }

                public AirportsForm()
        {
            InitializeComponent();
                                }
        private void ConfigureControls()
        {
            this.searchTypeComboBox.SelectedIndex = 0;
            this.fieldComboBox.SelectedIndex = 0;
        }

        private void ConfigureSearch(string searchType)
        {
            if(searchType == "text")
            {
                this.searchTypeComboBox.Items.Clear();
                this.searchTypeComboBox.Items.AddRange(stringComparisonTypes);
                this.searchTypeComboBox.SelectedIndex = 0;
                            }
            else if(searchType == "numeric")
            {
                this.searchTypeComboBox.Items.Clear();
                this.searchTypeComboBox.Items.AddRange(numericComparisonTypes);
                this.searchTypeComboBox.SelectedIndex = 0;
            }
        }

        private void ToggleSearchConditionType(string type)
        {
            if(type == "text")
            {
                textFilterTextBox.Visible = true;
                lowerNumericSpinner.Visible = false;
                upperNumericSpinner.Visible = false;
                isStringSearch = true;
            }
            else if(type == "numeric")
            {
                textFilterTextBox.Visible = false;
                lowerNumericSpinner.Visible = true;
                upperNumericSpinner.Visible = false;
                isStringSearch = false;                
            }
            else if(type == "range")
            {
                textFilterTextBox.Visible = false;
                lowerNumericSpinner.Visible = true;
                upperNumericSpinner.Visible = true;
                isStringSearch = false;
            }
        }

        private void  AirportsForm_Load(object sender, EventArgs e)
        {
            ConfigureControls();
                    }

        private void fieldComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
if(Tolk.DetectScreenReader() == "NVDA")
            {
                Tolk.Output(fieldComboBox.SelectedItem.ToString());
            }
switch(this.fieldComboBox.SelectedItem)
            {
                case "Name":
                    ConfigureSearch("text");
                                        break;
                case "ICAO":
                    ConfigureSearch("text");
                    break;
                case "City":
                    ConfigureSearch("text");
                                        break;
                case "State / Province":
                    ConfigureSearch("text");
                    break;
                case "Country":
                    ConfigureSearch("text");
                                        break;
                case "Bearing":
                    ConfigureSearch("numeric");
                    break;
                case "Altitude":
                    ConfigureSearch("numeric");
                    break;
                case "Distance":
                    ConfigureSearch("numeric");
                    break;
                default:
                    break;
            }
        }

        private void searchTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
if(Tolk.DetectScreenReader() == "NVDA")
            {
                Tolk.Output(searchTypeComboBox.SelectedItem.ToString());
            }
switch(this.searchTypeComboBox.SelectedItem)
            {
                case "Between":
                                        ToggleSearchConditionType("range");
                    comparison = ComparisonType.Between;
                    break;
                case "Equals":
                    if(isStringSearch == true)
                    {
                        ToggleSearchConditionType("text");
                        comparison = ComparisonType.StringEquals;
                    } 
                    else
                    {
                        ToggleSearchConditionType("numeric");
                        comparison = ComparisonType.NumericEquals;
                    }
                    break;
                case "Contains":
                    ToggleSearchConditionType("text");
                    comparison = ComparisonType.Contains;
                    break;
                case "Ends with":
                    ToggleSearchConditionType("text");
                    comparison = ComparisonType.EndsWith;
                    break;
                case "Starts with":
                    ToggleSearchConditionType("text");
                    comparison = ComparisonType.StartsWith;
                    break;
                case "Greater than":
                    ToggleSearchConditionType("numeric");
                    comparison = ComparisonType.GreaterThan;
                    break;
                case "Less than":
                    ToggleSearchConditionType("numeric");
                    comparison = ComparisonType.LessThan;
                    break;
                default:
                    break;
            }
            

        }

        private  void findButton_Click(object sender, EventArgs e)
        {
            airportsListView.Items.Clear();
            Dictionary<ComparisonType, Action<ComparisonType>> _actions = new Dictionary<ComparisonType, Action<ComparisonType>>();
            _actions.Add(ComparisonType.Between, doBetween());
            _actions.Add(ComparisonType.NumericEquals, doNumericEquals());
            _actions.Add(ComparisonType.GreaterThan, doGreaterThan());
            _actions.Add(ComparisonType.LessThan, doLessThan());
            _actions.Add(ComparisonType.StringEquals, doStringEquals());
            _actions.Add(ComparisonType.Contains, doContains());
            _actions.Add(ComparisonType.EndsWith, doEndsWith());
            _actions.Add(ComparisonType.StartsWith, doStartsWith());

                        _actions[comparison].Invoke(comparison);
            airportsListView.Focus();
            }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AirportsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Alt && e.KeyCode == Keys.A))
            {
                airportsListView.Focus();
            }
            if ((e.Alt && e.KeyCode == Keys.I))
            {
                fieldComboBox.Focus();
            }
            if ((e.Alt && e.KeyCode == Keys.T))
            {
                searchTypeComboBox.Focus();
            }
            if ((e.Alt && e.KeyCode == Keys.L))
            {
                if (textFilterTextBox.Visible == true)
                {
                    textFilterTextBox.Focus();
                }
                else
                {
                    Tolk.Output("The text filter field is not available. Select either Name, ICAO, City, State, or Country from the fields list.");
                }
            }
            if ((e.Alt && e.KeyCode == Keys.X))
            {
                if (upperNumericSpinner.Visible == true)
                {
                    upperNumericSpinner.Focus();
                }
                else
                {
                    Tolk.Output("The maxinum value field is not available. Select Bearing, Distance, or Altitude first, then choose between as the comparison operator.");
                }
            }
            if ((e.Alt && e.KeyCode == Keys.N))
            {
                if (lowerNumericSpinner.Visible == true)
                {
                    lowerNumericSpinner.Focus();
                }
                else
                {
                    Tolk.Output("The minimum value field is not available. Select Bearing, Distance, or Altitude from the fields list first.");
                }
            }
        }
    }
}
