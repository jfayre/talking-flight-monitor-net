using FSUIPC;
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
        private bool isStringSearch = true;
        private string[] numericComparisonTypes = { "Between", "Equals", "Greater than", "Less than" };
        private string[] stringComparisonTypes = { "Contains", "Starts with", "Ends with", "Equals" };

                        public AirportsForm()
        {
            InitializeComponent();
                                }
        private async  Task<List<ListViewItem>> LoadAirports(Expression<Func<FsAirport, bool>> expression)
        {
            var database = FSUIPCConnection.AirportsDatabase;
            List<ListViewItem> rows = new List<ListViewItem>();
                                     database.SetReferenceLocation();
            List<FsAirport> airports = database.Airports.AsQueryable().Where(expression).ToList();
            foreach (FsAirport airport in airports)
            {
                string[] row = { airport.Name, airport.ICAO, airport.City, airport.State, airport.Country, Math.Round(airport.BearingToTrue).ToString(), Math.Round(airport.AltitudeFeet).ToString(), Math.Round(airport.DistanceNauticalMiles).ToString() };
                rows.Add(new ListViewItem(row));
                            }
            return rows;
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
                isStringSearch = true;                
            }
            else if(searchType == "numeric")
            {
                this.searchTypeComboBox.Items.Clear();
                this.searchTypeComboBox.Items.AddRange(numericComparisonTypes);
                this.searchTypeComboBox.SelectedIndex = 0;
                isStringSearch = false;
            }
        }

        private void ToggleSearchConditionType(string type)
        {
            if(type == "text")
            {
                textFilterTextBox.Visible = true;
                lowerNumericSpinner.Visible = false;
                upperNumericSpinner.Visible = false;
            }
            else if(type == "numeric")
            {
                textFilterTextBox.Visible = false;
                lowerNumericSpinner.Visible = true;
                upperNumericSpinner.Visible = false;
                            }
            else if(type == "range")
            {
                textFilterTextBox.Visible = false;
                lowerNumericSpinner.Visible = true;
                upperNumericSpinner.Visible = true;
            }
        }

        private void  AirportsForm_Load(object sender, EventArgs e)
        {
//            Task<List<ListViewItem>> listViewItems;
            ConfigureControls();
            
            //listViewItems = Task.Run(() => LoadAirports());
            //airportsListView.BeginUpdate();
            //airportsListView.Items.AddRange(listViewItems.Result.ToArray());
            //airportsListView.EndUpdate();
        }

        private void fieldComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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
switch(this.searchTypeComboBox.SelectedItem)
            {
                case "Between":
                                        ToggleSearchConditionType("range");                    
                    break;
                case "Equals":
                    if(isStringSearch == true)
                    {
                        ToggleSearchConditionType("text");
                    } 
                    else
                    {
                        ToggleSearchConditionType("numeric");
                    }
                    break;
                case "Contains":
                    ToggleSearchConditionType("text");
                    break;
                case "Ends with":
                    ToggleSearchConditionType("text");
                    break;
                case "Starts with":
                    ToggleSearchConditionType("text");
                    break;
                case "Greater than":
                    ToggleSearchConditionType("numeric");
                    break;
                case "Less than":
                    ToggleSearchConditionType("numeric");
                    break;
                default:
                    break;
            }
            

        }

        private async void findButton_Click(object sender, EventArgs e)
        {
            Task<List<ListViewItem>> listViewItems;
            Expression<Func<FsAirport, bool>> expression = null;
            string distanceField = null;
            if(Properties.Settings.Default.UseMetric)
            {
                distanceField = "DistanceKilometres";
            }
            else
            {
             distanceField = "DistanceNauticalMiles";
            }
                      
switch(searchTypeComboBox.SelectedItem)
            {
                case "Equals":
                    if(isStringSearch) {
                        expression = ExpressionBuilder<FsAirport>.BuildFromString(fieldComboBox.SelectedItem.ToString(), textFilterTextBox.Text, ExpressionBuilder<FsAirport>.type.Equals);
                                            }
                    else
                    {
                        if(fieldComboBox.SelectedItem == "Distance")
                        {
                            expression = ExpressionBuilder<FsAirport>.BuildFromDouble(ExpressionBuilder<FsAirport>.type.Equals, distanceField, (double)lowerNumericSpinner.Value);
                            MessageBox.Show(expression.ToString());
                        }


                                            }
                    break;
            }
            listViewItems = Task.Run(() => LoadAirports(expression));
            airportsListView.BeginUpdate();
            airportsListView.Items.AddRange(listViewItems.Result.ToArray());
            airportsListView.EndUpdate();
        }
    }
}
