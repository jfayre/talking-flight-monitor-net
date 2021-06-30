namespace tfm
{
    partial class TFMMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TFMMainForm));
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.timerConnection = new System.Windows.Forms.Timer(this.components);
            this.TFMMainMenu = new System.Windows.Forms.MenuStrip();
            this.PlanMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenPlanMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SavePlanMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SavePlanAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.QuitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.A2AManagerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AircraftMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyManagerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CommandKeyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FuelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightPlanMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.WebsiteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportIssueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkeyHelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waypointsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addWaypointContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeWaypointContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.directToHereContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.holdContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAltitudeContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSpeedContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeVerticalSpeedContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbLoadWorker = new System.ComponentModel.BackgroundWorker();
            this.timerLowPriority = new System.Windows.Forms.Timer(this.components);
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TFMMainMenu.SuspendLayout();
            this.waypointsContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerMain
            // 
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // timerConnection
            // 
            this.timerConnection.Interval = 1000;
            this.timerConnection.Tick += new System.EventHandler(this.TimerConnection_Tick);
            // 
            // TFMMainMenu
            // 
            this.TFMMainMenu.AccessibleDescription = "Talking flight moniter main menu";
            this.TFMMainMenu.AccessibleName = "TFM Main menu";
            this.TFMMainMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TFMMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TFMMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlanMenu,
            this.ToolsMenu,
            this.HelpMenu});
            this.TFMMainMenu.Location = new System.Drawing.Point(0, 0);
            this.TFMMainMenu.Name = "TFMMainMenu";
            this.TFMMainMenu.Size = new System.Drawing.Size(484, 48);
            this.TFMMainMenu.TabIndex = 0;
            this.TFMMainMenu.Text = "Main menu";
            // 
            // PlanMenu
            // 
            this.PlanMenu.AccessibleDescription = "";
            this.PlanMenu.AccessibleName = "Plan";
            this.PlanMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenPlanMenuItem,
            this.toolStripSeparator1,
            this.SavePlanMenuItem,
            this.SavePlanAsMenuItem,
            this.toolStripSeparator2,
            this.QuitMenuItem});
            this.PlanMenu.Name = "PlanMenu";
            this.PlanMenu.ShortcutKeyDisplayString = "ALT+P";
            this.PlanMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.PlanMenu.Size = new System.Drawing.Size(87, 44);
            this.PlanMenu.Text = "&Plan";
            this.PlanMenu.ToolTipText = "Load and save flight plans.";
            // 
            // OpenPlanMenuItem
            // 
            this.OpenPlanMenuItem.AccessibleDescription = "";
            this.OpenPlanMenuItem.AccessibleName = "Open...";
            this.OpenPlanMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenPlanMenuItem.Name = "OpenPlanMenuItem";
            this.OpenPlanMenuItem.ShortcutKeyDisplayString = "CONTROL+O";
            this.OpenPlanMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenPlanMenuItem.Size = new System.Drawing.Size(443, 40);
            this.OpenPlanMenuItem.Text = "&Open...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(440, 6);
            // 
            // SavePlanMenuItem
            // 
            this.SavePlanMenuItem.AccessibleDescription = "";
            this.SavePlanMenuItem.AccessibleName = "Save...";
            this.SavePlanMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePlanMenuItem.Name = "SavePlanMenuItem";
            this.SavePlanMenuItem.ShortcutKeyDisplayString = "CONTROL+S";
            this.SavePlanMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SavePlanMenuItem.Size = new System.Drawing.Size(443, 40);
            this.SavePlanMenuItem.Text = "&Save...";
            // 
            // SavePlanAsMenuItem
            // 
            this.SavePlanAsMenuItem.AccessibleDescription = "";
            this.SavePlanAsMenuItem.AccessibleName = "Save as...";
            this.SavePlanAsMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePlanAsMenuItem.Name = "SavePlanAsMenuItem";
            this.SavePlanAsMenuItem.ShortcutKeyDisplayString = "CONTROL+SHIFT+S";
            this.SavePlanAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SavePlanAsMenuItem.Size = new System.Drawing.Size(443, 40);
            this.SavePlanAsMenuItem.Text = "&Save as...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(440, 6);
            // 
            // QuitMenuItem
            // 
            this.QuitMenuItem.AccessibleDescription = "";
            this.QuitMenuItem.AccessibleName = "Quit";
            this.QuitMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitMenuItem.Name = "QuitMenuItem";
            this.QuitMenuItem.ShortcutKeyDisplayString = "ALT+F4";
            this.QuitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.QuitMenuItem.Size = new System.Drawing.Size(443, 40);
            this.QuitMenuItem.Text = "&Quit";
            this.QuitMenuItem.Click += new System.EventHandler(this.QuitMenuItem_Click);
            // 
            // ToolsMenu
            // 
            this.ToolsMenu.AccessibleDescription = "";
            this.ToolsMenu.AccessibleName = "Tools";
            this.ToolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.A2AManagerMenuItem,
            this.AircraftMenuItem,
            this.SettingsMenuItem,
            this.KeyManagerMenuItem,
            this.CommandKeyMenuItem,
            this.ConnectMenuItem,
            this.FuelMenuItem,
            this.flightPlanMenuItem});
            this.ToolsMenu.Name = "ToolsMenu";
            this.ToolsMenu.ShortcutKeyDisplayString = "ALT+T";
            this.ToolsMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.ToolsMenu.Size = new System.Drawing.Size(98, 44);
            this.ToolsMenu.Text = "&Tools";
            this.ToolsMenu.Click += new System.EventHandler(this.ToolsMenu_Click);
            // 
            // A2AManagerMenuItem
            // 
            this.A2AManagerMenuItem.AccessibleDescription = "";
            this.A2AManagerMenuItem.AccessibleName = "A2A aircraft manager";
            this.A2AManagerMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2AManagerMenuItem.Name = "A2AManagerMenuItem";
            this.A2AManagerMenuItem.ShortcutKeyDisplayString = "CONTROL+M";
            this.A2AManagerMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.A2AManagerMenuItem.Size = new System.Drawing.Size(677, 48);
            this.A2AManagerMenuItem.Text = "A2A aircraft &manager";
            // 
            // AircraftMenuItem
            // 
            this.AircraftMenuItem.AccessibleDescription = "";
            this.AircraftMenuItem.AccessibleName = "Aircraft profiles...";
            this.AircraftMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AircraftMenuItem.Name = "AircraftMenuItem";
            this.AircraftMenuItem.ShortcutKeyDisplayString = "CONTROL+I";
            this.AircraftMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.AircraftMenuItem.Size = new System.Drawing.Size(677, 48);
            this.AircraftMenuItem.Text = "A&ircraft...";
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.AccessibleDescription = "";
            this.SettingsMenuItem.AccessibleName = "Settings...";
            this.SettingsMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.ShortcutKeyDisplayString = "CONTROL+,";
            this.SettingsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemcomma)));
            this.SettingsMenuItem.Size = new System.Drawing.Size(677, 48);
            this.SettingsMenuItem.Text = "&Settings...";
            this.SettingsMenuItem.Click += new System.EventHandler(this.SettingsMenuItem_Click);
            // 
            // KeyManagerMenuItem
            // 
            this.KeyManagerMenuItem.Name = "KeyManagerMenuItem";
            this.KeyManagerMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.KeyManagerMenuItem.Size = new System.Drawing.Size(677, 48);
            this.KeyManagerMenuItem.Text = "&Keyboard Manager";
            this.KeyManagerMenuItem.Click += new System.EventHandler(this.KeyManagerMenuItem_Click);
            // 
            // CommandKeyMenuItem
            // 
            this.CommandKeyMenuItem.CheckOnClick = true;
            this.CommandKeyMenuItem.Name = "CommandKeyMenuItem";
            this.CommandKeyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.CommandKeyMenuItem.Size = new System.Drawing.Size(677, 48);
            this.CommandKeyMenuItem.Text = "Enable/Disable command key";
            this.CommandKeyMenuItem.Click += new System.EventHandler(this.CommandKeyMenuItem_Click);
            // 
            // ConnectMenuItem
            // 
            this.ConnectMenuItem.AccessibleName = "Connect to simulator";
            this.ConnectMenuItem.Name = "ConnectMenuItem";
            this.ConnectMenuItem.ShortcutKeyDisplayString = "CTRL+SHIFT+R";
            this.ConnectMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.ConnectMenuItem.Size = new System.Drawing.Size(677, 48);
            this.ConnectMenuItem.Text = "&Connect to simulator";
            this.ConnectMenuItem.Click += new System.EventHandler(this.ConnectMenuItem_Click);
            // 
            // FuelMenuItem
            // 
            this.FuelMenuItem.Name = "FuelMenuItem";
            this.FuelMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FuelMenuItem.Size = new System.Drawing.Size(677, 48);
            this.FuelMenuItem.Text = "&Fuel Manager";
            this.FuelMenuItem.Click += new System.EventHandler(this.FuelMenuItem_Click);
            // 
            // flightPlanMenuItem
            // 
            this.flightPlanMenuItem.AccessibleName = "Flight planner";
            this.flightPlanMenuItem.Name = "flightPlanMenuItem";
            this.flightPlanMenuItem.ShortcutKeyDisplayString = "Ctrl+P";
            this.flightPlanMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.flightPlanMenuItem.Size = new System.Drawing.Size(677, 48);
            this.flightPlanMenuItem.Text = "Flight planner";
            this.flightPlanMenuItem.Click += new System.EventHandler(this.flightPlanMenuItem_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.AccessibleDescription = "";
            this.HelpMenu.AccessibleName = "Help";
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WebsiteMenuItem,
            this.ReportIssueMenuItem,
            this.AboutMenuItem,
            this.hotkeyHelpMenuItem});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.ShortcutKeyDisplayString = "ALT+H";
            this.HelpMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.HelpMenu.Size = new System.Drawing.Size(93, 44);
            this.HelpMenu.Text = "Help";
            // 
            // WebsiteMenuItem
            // 
            this.WebsiteMenuItem.AccessibleDescription = "";
            this.WebsiteMenuItem.AccessibleName = "Visit website";
            this.WebsiteMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebsiteMenuItem.Name = "WebsiteMenuItem";
            this.WebsiteMenuItem.ShortcutKeyDisplayString = "CONTROL+SHIFT+W";
            this.WebsiteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.W)));
            this.WebsiteMenuItem.Size = new System.Drawing.Size(505, 48);
            this.WebsiteMenuItem.Text = "Visit &website";
            this.WebsiteMenuItem.Click += new System.EventHandler(this.WebsiteMenuItem_Click);
            // 
            // ReportIssueMenuItem
            // 
            this.ReportIssueMenuItem.AccessibleDescription = "";
            this.ReportIssueMenuItem.AccessibleName = "Report an issue";
            this.ReportIssueMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportIssueMenuItem.Name = "ReportIssueMenuItem";
            this.ReportIssueMenuItem.ShortcutKeyDisplayString = "CONTROL+SHIFT+I";
            this.ReportIssueMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.ReportIssueMenuItem.Size = new System.Drawing.Size(505, 48);
            this.ReportIssueMenuItem.Text = "Report an &issue";
            this.ReportIssueMenuItem.Click += new System.EventHandler(this.ReportIssueMenuItem_Click);
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.AccessibleDescription = "";
            this.AboutMenuItem.AccessibleName = "About...";
            this.AboutMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(505, 48);
            this.AboutMenuItem.Text = "&About...";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // hotkeyHelpMenuItem
            // 
            this.hotkeyHelpMenuItem.Name = "hotkeyHelpMenuItem";
            this.hotkeyHelpMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.hotkeyHelpMenuItem.Size = new System.Drawing.Size(505, 48);
            this.hotkeyHelpMenuItem.Text = "Hotkey help";
            this.hotkeyHelpMenuItem.Click += new System.EventHandler(this.hotkeyHelpMenuItem_Click);
            // 
            // waypointsContextMenu
            // 
            this.waypointsContextMenu.AccessibleName = "Waypoint menu";
            this.waypointsContextMenu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waypointsContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.waypointsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWaypointContextMenuItem,
            this.removeWaypointContextMenu,
            this.directToHereContextMenuItem,
            this.holdContextMenuItem,
            this.changeAltitudeContextMenuItem,
            this.changeSpeedContextMenuItem,
            this.changeVerticalSpeedContextMenuItem});
            this.waypointsContextMenu.Name = "waypointsContextMenu";
            this.waypointsContextMenu.Size = new System.Drawing.Size(333, 284);
            // 
            // addWaypointContextMenuItem
            // 
            this.addWaypointContextMenuItem.AccessibleName = "Add waypoint";
            this.addWaypointContextMenuItem.Name = "addWaypointContextMenuItem";
            this.addWaypointContextMenuItem.Size = new System.Drawing.Size(332, 40);
            this.addWaypointContextMenuItem.Text = "&Add waypoint";
            // 
            // removeWaypointContextMenu
            // 
            this.removeWaypointContextMenu.Name = "removeWaypointContextMenu";
            this.removeWaypointContextMenu.Size = new System.Drawing.Size(332, 40);
            this.removeWaypointContextMenu.Text = "&Remove waypoint";
            // 
            // directToHereContextMenuItem
            // 
            this.directToHereContextMenuItem.AccessibleName = "Direct to here";
            this.directToHereContextMenuItem.Name = "directToHereContextMenuItem";
            this.directToHereContextMenuItem.Size = new System.Drawing.Size(332, 40);
            this.directToHereContextMenuItem.Text = "&Direct to here";
            // 
            // holdContextMenuItem
            // 
            this.holdContextMenuItem.AccessibleName = "Hold";
            this.holdContextMenuItem.Name = "holdContextMenuItem";
            this.holdContextMenuItem.Size = new System.Drawing.Size(332, 40);
            this.holdContextMenuItem.Text = "&hold";
            // 
            // changeAltitudeContextMenuItem
            // 
            this.changeAltitudeContextMenuItem.AccessibleName = "Change altitude";
            this.changeAltitudeContextMenuItem.Name = "changeAltitudeContextMenuItem";
            this.changeAltitudeContextMenuItem.Size = new System.Drawing.Size(332, 40);
            this.changeAltitudeContextMenuItem.Text = "Change &altitude";
            // 
            // changeSpeedContextMenuItem
            // 
            this.changeSpeedContextMenuItem.AccessibleName = "Change speed";
            this.changeSpeedContextMenuItem.Name = "changeSpeedContextMenuItem";
            this.changeSpeedContextMenuItem.Size = new System.Drawing.Size(332, 40);
            this.changeSpeedContextMenuItem.Text = "Change &speed";
            // 
            // changeVerticalSpeedContextMenuItem
            // 
            this.changeVerticalSpeedContextMenuItem.AccessibleName = "Change vertical speed";
            this.changeVerticalSpeedContextMenuItem.Name = "changeVerticalSpeedContextMenuItem";
            this.changeVerticalSpeedContextMenuItem.Size = new System.Drawing.Size(332, 40);
            this.changeVerticalSpeedContextMenuItem.Text = "Change &vertical speed";
            // 
            // dbLoadWorker
            // 
            this.dbLoadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.dbLoadWorker_DoWork);
            // 
            // timerLowPriority
            // 
            this.timerLowPriority.Interval = 1000;
            this.timerLowPriority.Tick += new System.EventHandler(this.timerLowPriority_Tick);
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.trayIcon.BalloonTipText = "TFM is minimized to the system tray.";
            this.trayIcon.BalloonTipTitle = "TFM notification";
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "TFM";
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // TFMMainForm
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "Talking flight moniter";
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.TFMMainMenu);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.TFMMainMenu;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TFMMainForm";
            this.Text = "Talking flight moniter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.TFMMainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TFMMainForm_KeyDown);
            this.Resize += new System.EventHandler(this.TFMMainForm_Resize);
            this.TFMMainMenu.ResumeLayout(false);
            this.TFMMainMenu.PerformLayout();
            this.waypointsContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Timer timerConnection;
        private System.Windows.Forms.MenuStrip TFMMainMenu;
        private System.Windows.Forms.ToolStripMenuItem PlanMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenPlanMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SavePlanMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SavePlanAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem QuitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolsMenu;
        private System.Windows.Forms.ToolStripMenuItem A2AManagerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AircraftMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem WebsiteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportIssueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.ComponentModel.BackgroundWorker dbLoadWorker;
        private System.Windows.Forms.ToolStripMenuItem KeyManagerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CommandKeyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotkeyHelpMenuItem;
        private System.Windows.Forms.Timer timerLowPriority;
        private System.Windows.Forms.ToolStripMenuItem ConnectMenuItem;
        private System.Windows.Forms.ContextMenuStrip waypointsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addWaypointContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeWaypointContextMenu;
        private System.Windows.Forms.ToolStripMenuItem directToHereContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem holdContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeAltitudeContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSpeedContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeVerticalSpeedContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FuelMenuItem;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ToolStripMenuItem flightPlanMenuItem;
    }
}

