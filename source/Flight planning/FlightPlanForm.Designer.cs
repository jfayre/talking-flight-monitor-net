namespace tfm
{
    partial class FlightPlanForm
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Sid waypoints", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("In route waypoints", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Star waypoints", System.Windows.Forms.HorizontalAlignment.Left);
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.planMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.simBriefMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPlanMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aircraftMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proceduresMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.airportsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxiwaysMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gatesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runwaysMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approachesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airacCycleTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.waypointsListView = new System.Windows.Forms.ListView();
            this.icaoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.routeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.distanceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.altitudeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courseColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.frequencyColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.proceduresTabControl = new System.Windows.Forms.TabControl();
            this.sidTabPage = new System.Windows.Forms.TabPage();
            this.starsTabPage = new System.Windows.Forms.TabPage();
            this.waypointRestrictionsTextBox = new System.Windows.Forms.TextBox();
            this.mainMenu.SuspendLayout();
            this.proceduresTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.AccessibleName = "Main menu";
            this.mainMenu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planMenu,
            this.proceduresMenu,
            this.airacCycleTextBox});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.mainMenu.Size = new System.Drawing.Size(1300, 40);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "Main menu";
            // 
            // planMenu
            // 
            this.planMenu.AccessibleName = "Plan";
            this.planMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenu,
            this.openPlanMenuItem,
            this.toolStripSeparator1,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.toolStripSeparator2,
            this.aircraftMenuItem,
            this.toolStripSeparator3,
            this.closeMenuItem});
            this.planMenu.Name = "planMenu";
            this.planMenu.Size = new System.Drawing.Size(69, 34);
            this.planMenu.Text = "&Plan";
            // 
            // NewMenu
            // 
            this.NewMenu.AccessibleName = "New";
            this.NewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simBriefMenuItem,
            this.openMenuItem});
            this.NewMenu.Name = "NewMenu";
            this.NewMenu.Size = new System.Drawing.Size(224, 32);
            this.NewMenu.Text = "&New";
            // 
            // simBriefMenuItem
            // 
            this.simBriefMenuItem.AccessibleName = "From Simbrief...";
            this.simBriefMenuItem.Name = "simBriefMenuItem";
            this.simBriefMenuItem.Size = new System.Drawing.Size(254, 32);
            this.simBriefMenuItem.Text = "From &Simbrief...";
            // 
            // openMenuItem
            // 
            this.openMenuItem.AccessibleName = "Open...";
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(254, 32);
            this.openMenuItem.Text = "&Open...";
            // 
            // openPlanMenuItem
            // 
            this.openPlanMenuItem.AccessibleName = "Open...";
            this.openPlanMenuItem.Name = "openPlanMenuItem";
            this.openPlanMenuItem.Size = new System.Drawing.Size(224, 32);
            this.openPlanMenuItem.Text = "&Open...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(224, 32);
            this.saveMenuItem.Text = "&Save";
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.AccessibleName = "Save as...";
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.Size = new System.Drawing.Size(224, 32);
            this.saveAsMenuItem.Text = "Save &as...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // aircraftMenuItem
            // 
            this.aircraftMenuItem.AccessibleName = "Aircraft...";
            this.aircraftMenuItem.Name = "aircraftMenuItem";
            this.aircraftMenuItem.Size = new System.Drawing.Size(224, 32);
            this.aircraftMenuItem.Text = "&Aircraft...";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Name = "closeMenuItem";
            this.closeMenuItem.Size = new System.Drawing.Size(224, 32);
            this.closeMenuItem.Text = "&Close";
            // 
            // proceduresMenu
            // 
            this.proceduresMenu.AccessibleName = "Procedures";
            this.proceduresMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.airportsMenuItem,
            this.taxiwaysMenuItem,
            this.gatesMenuItem,
            this.runwaysMenuItem,
            this.sidsMenuItem,
            this.starsMenuItem,
            this.approachesMenuItem});
            this.proceduresMenu.Name = "proceduresMenu";
            this.proceduresMenu.Size = new System.Drawing.Size(134, 34);
            this.proceduresMenu.Text = "P&rocedures";
            // 
            // airportsMenuItem
            // 
            this.airportsMenuItem.AccessibleName = "Airports...";
            this.airportsMenuItem.Name = "airportsMenuItem";
            this.airportsMenuItem.Size = new System.Drawing.Size(231, 32);
            this.airportsMenuItem.Text = "&Airports...";
            this.airportsMenuItem.Click += new System.EventHandler(this.airportsMenuItem_Click);
            // 
            // taxiwaysMenuItem
            // 
            this.taxiwaysMenuItem.AccessibleName = "Taxiways...";
            this.taxiwaysMenuItem.Name = "taxiwaysMenuItem";
            this.taxiwaysMenuItem.Size = new System.Drawing.Size(231, 32);
            this.taxiwaysMenuItem.Text = "&Taxiways...";
            // 
            // gatesMenuItem
            // 
            this.gatesMenuItem.AccessibleName = "Gates...";
            this.gatesMenuItem.Name = "gatesMenuItem";
            this.gatesMenuItem.Size = new System.Drawing.Size(231, 32);
            this.gatesMenuItem.Text = "&Gates...";
            // 
            // runwaysMenuItem
            // 
            this.runwaysMenuItem.AccessibleName = "Runways...";
            this.runwaysMenuItem.Name = "runwaysMenuItem";
            this.runwaysMenuItem.Size = new System.Drawing.Size(231, 32);
            this.runwaysMenuItem.Text = "&Runways...";
            // 
            // sidsMenuItem
            // 
            this.sidsMenuItem.AccessibleName = "Sids...";
            this.sidsMenuItem.Name = "sidsMenuItem";
            this.sidsMenuItem.Size = new System.Drawing.Size(231, 32);
            this.sidsMenuItem.Text = "&Sids...";
            // 
            // starsMenuItem
            // 
            this.starsMenuItem.AccessibleName = "Stars...";
            this.starsMenuItem.Name = "starsMenuItem";
            this.starsMenuItem.Size = new System.Drawing.Size(231, 32);
            this.starsMenuItem.Text = "&Stars...";
            // 
            // approachesMenuItem
            // 
            this.approachesMenuItem.AccessibleName = "Approaches...";
            this.approachesMenuItem.Name = "approachesMenuItem";
            this.approachesMenuItem.Size = new System.Drawing.Size(231, 32);
            this.approachesMenuItem.Text = "&Approaches...";
            // 
            // airacCycleTextBox
            // 
            this.airacCycleTextBox.AccessibleName = "Airac cycle";
            this.airacCycleTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airacCycleTextBox.Name = "airacCycleTextBox";
            this.airacCycleTextBox.ReadOnly = true;
            this.airacCycleTextBox.Size = new System.Drawing.Size(160, 34);
            // 
            // waypointsListView
            // 
            this.waypointsListView.AccessibleName = "Waypoints";
            this.waypointsListView.AllowColumnReorder = true;
            this.waypointsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.icaoColumnHeader,
            this.nameColumnHeader,
            this.routeColumnHeader,
            this.distanceColumnHeader,
            this.timeColumnHeader,
            this.altitudeColumnHeader,
            this.courseColumnHeader,
            this.frequencyColumnHeader});
            listViewGroup1.Header = "Sid waypoints";
            listViewGroup1.Name = "sidsGroup";
            listViewGroup2.Header = "In route waypoints";
            listViewGroup2.Name = "inRouteGroup";
            listViewGroup3.Header = "Star waypoints";
            listViewGroup3.Name = "starGroup";
            this.waypointsListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.waypointsListView.HideSelection = false;
            this.waypointsListView.Location = new System.Drawing.Point(10, 46);
            this.waypointsListView.MultiSelect = false;
            this.waypointsListView.Name = "waypointsListView";
            this.waypointsListView.Size = new System.Drawing.Size(580, 726);
            this.waypointsListView.TabIndex = 1;
            this.waypointsListView.UseCompatibleStateImageBehavior = false;
            this.waypointsListView.View = System.Windows.Forms.View.Details;
            // 
            // icaoColumnHeader
            // 
            this.icaoColumnHeader.Text = "ICAO";
            this.icaoColumnHeader.Width = 70;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 70;
            // 
            // routeColumnHeader
            // 
            this.routeColumnHeader.Text = "Route";
            this.routeColumnHeader.Width = 70;
            // 
            // distanceColumnHeader
            // 
            this.distanceColumnHeader.DisplayIndex = 6;
            this.distanceColumnHeader.Text = "Distance";
            this.distanceColumnHeader.Width = 70;
            // 
            // timeColumnHeader
            // 
            this.timeColumnHeader.Text = "Time";
            this.timeColumnHeader.Width = 70;
            // 
            // altitudeColumnHeader
            // 
            this.altitudeColumnHeader.DisplayIndex = 3;
            this.altitudeColumnHeader.Text = "Altitude";
            this.altitudeColumnHeader.Width = 70;
            // 
            // courseColumnHeader
            // 
            this.courseColumnHeader.DisplayIndex = 5;
            this.courseColumnHeader.Text = "Course";
            this.courseColumnHeader.Width = 70;
            // 
            // frequencyColumnHeader
            // 
            this.frequencyColumnHeader.Text = "Frequency";
            this.frequencyColumnHeader.Width = 70;
            // 
            // proceduresTabControl
            // 
            this.proceduresTabControl.AccessibleName = "Procedures";
            this.proceduresTabControl.Controls.Add(this.sidTabPage);
            this.proceduresTabControl.Controls.Add(this.starsTabPage);
            this.proceduresTabControl.Location = new System.Drawing.Point(600, 46);
            this.proceduresTabControl.Name = "proceduresTabControl";
            this.proceduresTabControl.SelectedIndex = 0;
            this.proceduresTabControl.Size = new System.Drawing.Size(400, 500);
            this.proceduresTabControl.TabIndex = 2;
            // 
            // sidTabPage
            // 
            this.sidTabPage.AccessibleName = "Sids";
            this.sidTabPage.Location = new System.Drawing.Point(4, 35);
            this.sidTabPage.Name = "sidTabPage";
            this.sidTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sidTabPage.Size = new System.Drawing.Size(392, 461);
            this.sidTabPage.TabIndex = 0;
            this.sidTabPage.Text = "Sids";
            this.sidTabPage.UseVisualStyleBackColor = true;
            // 
            // starsTabPage
            // 
            this.starsTabPage.AccessibleName = "Stars";
            this.starsTabPage.Location = new System.Drawing.Point(4, 35);
            this.starsTabPage.Name = "starsTabPage";
            this.starsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.starsTabPage.Size = new System.Drawing.Size(392, 461);
            this.starsTabPage.TabIndex = 1;
            this.starsTabPage.Text = "Stars";
            this.starsTabPage.UseVisualStyleBackColor = true;
            // 
            // waypointRestrictionsTextBox
            // 
            this.waypointRestrictionsTextBox.AccessibleName = "Waypoint restrictions";
            this.waypointRestrictionsTextBox.Location = new System.Drawing.Point(650, 552);
            this.waypointRestrictionsTextBox.Multiline = true;
            this.waypointRestrictionsTextBox.Name = "waypointRestrictionsTextBox";
            this.waypointRestrictionsTextBox.ReadOnly = true;
            this.waypointRestrictionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.waypointRestrictionsTextBox.Size = new System.Drawing.Size(150, 150);
            this.waypointRestrictionsTextBox.TabIndex = 3;
            // 
            // FlightPlanForm
            // 
            this.AccessibleName = "Flight planner";
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1300, 731);
            this.Controls.Add(this.waypointRestrictionsTextBox);
            this.Controls.Add(this.proceduresTabControl);
            this.Controls.Add(this.waypointsListView);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FlightPlanForm";
            this.Text = "Flight planning";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FlightPlanForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlightPlanForm_KeyDown);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.proceduresTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem planMenu;
        private System.Windows.Forms.ToolStripMenuItem proceduresMenu;
        private System.Windows.Forms.ToolStripTextBox airacCycleTextBox;
        private System.Windows.Forms.ToolStripMenuItem NewMenu;
        private System.Windows.Forms.ToolStripMenuItem simBriefMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPlanMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aircraftMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airportsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxiwaysMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gatesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runwaysMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sidsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem starsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approachesMenuItem;
        private System.Windows.Forms.ListView waypointsListView;
        private System.Windows.Forms.ColumnHeader icaoColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader routeColumnHeader;
        private System.Windows.Forms.ColumnHeader distanceColumnHeader;
        private System.Windows.Forms.ColumnHeader timeColumnHeader;
        private System.Windows.Forms.ColumnHeader altitudeColumnHeader;
        private System.Windows.Forms.ColumnHeader courseColumnHeader;
        private System.Windows.Forms.ColumnHeader frequencyColumnHeader;
        private System.Windows.Forms.TabControl proceduresTabControl;
        private System.Windows.Forms.TabPage sidTabPage;
        private System.Windows.Forms.TabPage starsTabPage;
        private System.Windows.Forms.TextBox waypointRestrictionsTextBox;
    }
}