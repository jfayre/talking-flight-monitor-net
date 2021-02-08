
namespace tfm
{
    partial class AirportsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.airportsListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.icaoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.countryColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bearingColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.altitudeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.distanceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contAirport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuSetDepartureAirport = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldComboBox = new System.Windows.Forms.ComboBox();
            this.searchTypeComboBox = new System.Windows.Forms.ComboBox();
            this.textFilterTextBox = new System.Windows.Forms.TextBox();
            this.lowerNumericSpinner = new System.Windows.Forms.NumericUpDown();
            this.upperNumericSpinner = new System.Windows.Forms.NumericUpDown();
            this.findButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.mnuSetDestination = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAirportDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.contAirport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowerNumericSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperNumericSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // airportsListView
            // 
            this.airportsListView.AccessibleName = "Airports list";
            this.airportsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.icaoColumnHeader,
            this.cityColumnHeader,
            this.stateColumnHeader,
            this.countryColumnHeader,
            this.bearingColumnHeader,
            this.altitudeColumnHeader,
            this.distanceColumnHeader});
            this.airportsListView.ContextMenuStrip = this.contAirport;
            this.airportsListView.HideSelection = false;
            this.airportsListView.Location = new System.Drawing.Point(10, 10);
            this.airportsListView.Name = "airportsListView";
            this.airportsListView.Size = new System.Drawing.Size(500, 300);
            this.airportsListView.TabIndex = 1;
            this.airportsListView.UseCompatibleStateImageBehavior = false;
            this.airportsListView.View = System.Windows.Forms.View.Details;
            this.airportsListView.SelectedIndexChanged += new System.EventHandler(this.airportsListView_SelectedIndexChanged);
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            // 
            // icaoColumnHeader
            // 
            this.icaoColumnHeader.Text = "ICAO";
            // 
            // cityColumnHeader
            // 
            this.cityColumnHeader.Text = "City";
            // 
            // stateColumnHeader
            // 
            this.stateColumnHeader.Text = "State/province";
            this.stateColumnHeader.Width = 80;
            // 
            // countryColumnHeader
            // 
            this.countryColumnHeader.Text = "Country";
            // 
            // bearingColumnHeader
            // 
            this.bearingColumnHeader.Text = "Bearing";
            // 
            // altitudeColumnHeader
            // 
            this.altitudeColumnHeader.Text = "Altitude";
            // 
            // distanceColumnHeader
            // 
            this.distanceColumnHeader.Text = "Distance";
            // 
            // contAirport
            // 
            this.contAirport.AccessibleName = "context menu";
            this.contAirport.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.contAirport.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contAirport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetDepartureAirport,
            this.mnuSetDestination,
            this.mnuAirportDetails});
            this.contAirport.Name = "contAirport";
            this.contAirport.ShowItemToolTips = false;
            this.contAirport.Size = new System.Drawing.Size(330, 100);
            this.contAirport.Opened += new System.EventHandler(this.contAirport_Opened);
            this.contAirport.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cntAirport_ItemClicked);
            // 
            // mnuSetDepartureAirport
            // 
            this.mnuSetDepartureAirport.Enabled = false;
            this.mnuSetDepartureAirport.Name = "mnuSetDepartureAirport";
            this.mnuSetDepartureAirport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuSetDepartureAirport.Size = new System.Drawing.Size(329, 32);
            this.mnuSetDepartureAirport.Text = "Set Departure Airport";
            this.mnuSetDepartureAirport.Click += new System.EventHandler(this.mnuSetDepartureAirport_Click);
            // 
            // fieldComboBox
            // 
            this.fieldComboBox.AccessibleName = "Search field";
            this.fieldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldComboBox.FormattingEnabled = true;
            this.fieldComboBox.Items.AddRange(new object[] {
            "Name",
            "ICAO",
            "City",
            "State/Province",
            "Country",
            "Bearing",
            "Altitude",
            "Distance"});
            this.fieldComboBox.Location = new System.Drawing.Point(10, 320);
            this.fieldComboBox.Name = "fieldComboBox";
            this.fieldComboBox.Size = new System.Drawing.Size(121, 41);
            this.fieldComboBox.TabIndex = 2;
            this.fieldComboBox.SelectedIndexChanged += new System.EventHandler(this.fieldComboBox_SelectedIndexChanged);
            // 
            // searchTypeComboBox
            // 
            this.searchTypeComboBox.AccessibleName = "Search type";
            this.searchTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchTypeComboBox.FormattingEnabled = true;
            this.searchTypeComboBox.Items.AddRange(new object[] {
            "Between",
            "Contains",
            "Ends with",
            "Equals",
            "Greater than",
            "Less than",
            "Starts with"});
            this.searchTypeComboBox.Location = new System.Drawing.Point(137, 320);
            this.searchTypeComboBox.Name = "searchTypeComboBox";
            this.searchTypeComboBox.Size = new System.Drawing.Size(121, 41);
            this.searchTypeComboBox.Sorted = true;
            this.searchTypeComboBox.TabIndex = 3;
            this.searchTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.searchTypeComboBox_SelectedIndexChanged);
            // 
            // textFilterTextBox
            // 
            this.textFilterTextBox.AccessibleName = "Text filter";
            this.textFilterTextBox.Location = new System.Drawing.Point(264, 320);
            this.textFilterTextBox.Name = "textFilterTextBox";
            this.textFilterTextBox.Size = new System.Drawing.Size(100, 39);
            this.textFilterTextBox.TabIndex = 4;
            // 
            // lowerNumericSpinner
            // 
            this.lowerNumericSpinner.AccessibleName = "Minimum";
            this.lowerNumericSpinner.Location = new System.Drawing.Point(264, 320);
            this.lowerNumericSpinner.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.lowerNumericSpinner.Name = "lowerNumericSpinner";
            this.lowerNumericSpinner.Size = new System.Drawing.Size(120, 39);
            this.lowerNumericSpinner.TabIndex = 5;
            this.lowerNumericSpinner.Visible = false;
            // 
            // upperNumericSpinner
            // 
            this.upperNumericSpinner.AccessibleName = "Maximum";
            this.upperNumericSpinner.Location = new System.Drawing.Point(390, 320);
            this.upperNumericSpinner.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.upperNumericSpinner.Name = "upperNumericSpinner";
            this.upperNumericSpinner.Size = new System.Drawing.Size(120, 39);
            this.upperNumericSpinner.TabIndex = 6;
            this.upperNumericSpinner.Visible = false;
            // 
            // findButton
            // 
            this.findButton.AccessibleName = "Find airports";
            this.findButton.Location = new System.Drawing.Point(20, 364);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 7;
            this.findButton.Text = "&Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.AccessibleName = "Close";
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(425, 364);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // mnuSetDestination
            // 
            this.mnuSetDestination.Enabled = false;
            this.mnuSetDestination.Name = "mnuSetDestination";
            this.mnuSetDestination.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuSetDestination.Size = new System.Drawing.Size(329, 32);
            this.mnuSetDestination.Text = "Set Destination Airport";
            this.mnuSetDestination.Click += new System.EventHandler(this.mnuSetDestination_Click);
            // 
            // mnuAirportDetails
            // 
            this.mnuAirportDetails.Name = "mnuAirportDetails";
            this.mnuAirportDetails.Size = new System.Drawing.Size(265, 32);
            this.mnuAirportDetails.Text = "Airport Details...";
            // 
            // AirportsForm
            // 
            this.AccessibleName = "Airports";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 353);
            this.ControlBox = false;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.upperNumericSpinner);
            this.Controls.Add(this.lowerNumericSpinner);
            this.Controls.Add(this.textFilterTextBox);
            this.Controls.Add(this.searchTypeComboBox);
            this.Controls.Add(this.fieldComboBox);
            this.Controls.Add(this.airportsListView);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AirportsForm";
            this.ShowInTaskbar = false;
            this.Text = "Airports";
            this.Load += new System.EventHandler(this.AirportsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AirportsForm_KeyDown);
            this.contAirport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lowerNumericSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperNumericSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView airportsListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader icaoColumnHeader;
        private System.Windows.Forms.ColumnHeader cityColumnHeader;
        private System.Windows.Forms.ColumnHeader stateColumnHeader;
        private System.Windows.Forms.ColumnHeader countryColumnHeader;
        private System.Windows.Forms.ColumnHeader bearingColumnHeader;
        private System.Windows.Forms.ColumnHeader altitudeColumnHeader;
        private System.Windows.Forms.ColumnHeader distanceColumnHeader;
        private System.Windows.Forms.ComboBox fieldComboBox;
        private System.Windows.Forms.ComboBox searchTypeComboBox;
        private System.Windows.Forms.TextBox textFilterTextBox;
        private System.Windows.Forms.NumericUpDown lowerNumericSpinner;
        private System.Windows.Forms.NumericUpDown upperNumericSpinner;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ContextMenuStrip contAirport;
        private System.Windows.Forms.ToolStripMenuItem mnuSetDepartureAirport;
        private System.Windows.Forms.ToolStripMenuItem mnuSetDestination;
        private System.Windows.Forms.ToolStripMenuItem mnuAirportDetails;
    }
}