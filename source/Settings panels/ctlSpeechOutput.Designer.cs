namespace tfm
{
    partial class ctlSpeechOutput
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkReadInstrumentation = new System.Windows.Forms.CheckBox();
            this.trkSpeechRate = new System.Windows.Forms.TrackBar();
            this.chkAltitude = new System.Windows.Forms.CheckBox();
            this.chkReadGroundSpeed = new System.Windows.Forms.CheckBox();
            this.chkReadILS = new System.Windows.Forms.CheckBox();
            this.chkReadGPWS = new System.Windows.Forms.CheckBox();
            this.chkFlightFollowing = new System.Windows.Forms.CheckBox();
            this.chkReadSimconnectMessages = new System.Windows.Forms.CheckBox();
            this.chkAutopilot = new System.Windows.Forms.CheckBox();
            this.chkBraille = new System.Windows.Forms.CheckBox();
            this.grpAttitude = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radTones = new System.Windows.Forms.RadioButton();
            this.radSpeech = new System.Windows.Forms.RadioButton();
            this.radBoth = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.grpSpeechSystem = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radScreenReader = new System.Windows.Forms.RadioButton();
            this.radSAPI = new System.Windows.Forms.RadioButton();
            this.radAzureSpeech = new System.Windows.Forms.RadioButton();
            this.grpAzure = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAzureKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.grpFallback = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.radFBScreenReader = new System.Windows.Forms.RadioButton();
            this.radFBSAPI = new System.Windows.Forms.RadioButton();
            this.lblVoice = new System.Windows.Forms.Label();
            this.txtVoice = new System.Windows.Forms.TextBox();
            this.btnVoice = new System.Windows.Forms.Button();
            this.grpVerbosity = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeechRate)).BeginInit();
            this.grpAttitude.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.grpSpeechSystem.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.grpAzure.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.grpFallback.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.grpVerbosity.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkReadInstrumentation
            // 
            this.chkReadInstrumentation.AutoSize = true;
            this.chkReadInstrumentation.Checked = global::tfm.Properties.Settings.Default.ReadInstrumentation;
            this.chkReadInstrumentation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReadInstrumentation.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::tfm.Properties.Settings.Default, "ReadInstrumentation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkReadInstrumentation.Location = new System.Drawing.Point(7, 9);
            this.chkReadInstrumentation.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.chkReadInstrumentation.Name = "chkReadInstrumentation";
            this.chkReadInstrumentation.Size = new System.Drawing.Size(279, 37);
            this.chkReadInstrumentation.TabIndex = 2;
            this.chkReadInstrumentation.Text = "Read instrumentation";
            this.chkReadInstrumentation.UseVisualStyleBackColor = true;
            // 
            // trkSpeechRate
            // 
            this.trkSpeechRate.AccessibleName = "SAPI speech rate";
            this.trkSpeechRate.Location = new System.Drawing.Point(0, 0);
            this.trkSpeechRate.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.trkSpeechRate.Maximum = 20;
            this.trkSpeechRate.Name = "trkSpeechRate";
            this.trkSpeechRate.Size = new System.Drawing.Size(235, 69);
            this.trkSpeechRate.TabIndex = 1;
            this.trkSpeechRate.Value = 10;
            this.trkSpeechRate.Scroll += new System.EventHandler(this.TrkSpeechRate_Scroll);
            // 
            // chkAltitude
            // 
            this.chkAltitude.AutoSize = true;
            this.chkAltitude.Checked = global::tfm.Properties.Settings.Default.AltitudeAnnouncements;
            this.chkAltitude.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAltitude.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::tfm.Properties.Settings.Default, "AltitudeAnnouncements", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAltitude.Location = new System.Drawing.Point(300, 9);
            this.chkAltitude.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.chkAltitude.Name = "chkAltitude";
            this.chkAltitude.Size = new System.Drawing.Size(365, 37);
            this.chkAltitude.TabIndex = 9;
            this.chkAltitude.Text = "Read altitude every 1000 feet";
            this.chkAltitude.UseVisualStyleBackColor = true;
            // 
            // chkReadGroundSpeed
            // 
            this.chkReadGroundSpeed.AutoSize = true;
            this.chkReadGroundSpeed.Checked = global::tfm.Properties.Settings.Default.ReadGroundSpeed;
            this.chkReadGroundSpeed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReadGroundSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::tfm.Properties.Settings.Default, "ReadGroundSpeed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkReadGroundSpeed.Location = new System.Drawing.Point(679, 9);
            this.chkReadGroundSpeed.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.chkReadGroundSpeed.Name = "chkReadGroundSpeed";
            this.chkReadGroundSpeed.Size = new System.Drawing.Size(580, 37);
            this.chkReadGroundSpeed.TabIndex = 12;
            this.chkReadGroundSpeed.Text = "Read ground speed periodically while on ground";
            this.chkReadGroundSpeed.UseVisualStyleBackColor = true;
            // 
            // chkReadILS
            // 
            this.chkReadILS.AutoSize = true;
            this.chkReadILS.Checked = global::tfm.Properties.Settings.Default.ReadILS;
            this.chkReadILS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReadILS.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::tfm.Properties.Settings.Default, "ReadILS", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkReadILS.Location = new System.Drawing.Point(1273, 9);
            this.chkReadILS.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.chkReadILS.Name = "chkReadILS";
            this.chkReadILS.Size = new System.Drawing.Size(425, 37);
            this.chkReadILS.TabIndex = 10;
            this.chkReadILS.Text = "Read ILS information on approach";
            this.chkReadILS.UseVisualStyleBackColor = true;
            // 
            // chkReadGPWS
            // 
            this.chkReadGPWS.AutoSize = true;
            this.chkReadGPWS.Checked = global::tfm.Properties.Settings.Default.ReadGPWS;
            this.chkReadGPWS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReadGPWS.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::tfm.Properties.Settings.Default, "ReadGPWS", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkReadGPWS.Location = new System.Drawing.Point(1712, 9);
            this.chkReadGPWS.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.chkReadGPWS.Name = "chkReadGPWS";
            this.chkReadGPWS.Size = new System.Drawing.Size(698, 37);
            this.chkReadGPWS.TabIndex = 8;
            this.chkReadGPWS.Text = "Ground proximity warning system (GPWS) announcements";
            this.chkReadGPWS.UseVisualStyleBackColor = true;
            // 
            // chkFlightFollowing
            // 
            this.chkFlightFollowing.AutoSize = true;
            this.chkFlightFollowing.Checked = global::tfm.Properties.Settings.Default.FlightFollowing;
            this.chkFlightFollowing.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::tfm.Properties.Settings.Default, "FlightFollowing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkFlightFollowing.Location = new System.Drawing.Point(2424, 9);
            this.chkFlightFollowing.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.chkFlightFollowing.Name = "chkFlightFollowing";
            this.chkFlightFollowing.Size = new System.Drawing.Size(416, 37);
            this.chkFlightFollowing.TabIndex = 6;
            this.chkFlightFollowing.Text = "Read flight following information";
            this.chkFlightFollowing.UseVisualStyleBackColor = true;
            // 
            // chkReadSimconnectMessages
            // 
            this.chkReadSimconnectMessages.AutoSize = true;
            this.chkReadSimconnectMessages.Checked = global::tfm.Properties.Settings.Default.ReadSimconnectMessages;
            this.chkReadSimconnectMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReadSimconnectMessages.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::tfm.Properties.Settings.Default, "ReadSimconnectMessages", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkReadSimconnectMessages.Location = new System.Drawing.Point(3331, 9);
            this.chkReadSimconnectMessages.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.chkReadSimconnectMessages.Name = "chkReadSimconnectMessages";
            this.chkReadSimconnectMessages.Size = new System.Drawing.Size(351, 37);
            this.chkReadSimconnectMessages.TabIndex = 4;
            this.chkReadSimconnectMessages.Text = "Read SimConnect messages";
            this.chkReadSimconnectMessages.UseVisualStyleBackColor = true;
            // 
            // chkAutopilot
            // 
            this.chkAutopilot.AutoSize = true;
            this.chkAutopilot.Checked = global::tfm.Properties.Settings.Default.ReadAutopilot;
            this.chkAutopilot.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::tfm.Properties.Settings.Default, "ReadAutopilot", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAutopilot.Location = new System.Drawing.Point(3696, 9);
            this.chkAutopilot.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.chkAutopilot.Name = "chkAutopilot";
            this.chkAutopilot.Size = new System.Drawing.Size(425, 37);
            this.chkAutopilot.TabIndex = 13;
            this.chkAutopilot.Text = "Read autopilot instrument changes";
            this.chkAutopilot.UseVisualStyleBackColor = true;
            // 
            // chkBraille
            // 
            this.chkBraille.AutoSize = true;
            this.chkBraille.Checked = global::tfm.Properties.Settings.Default.OutputBraille;
            this.chkBraille.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBraille.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::tfm.Properties.Settings.Default, "OutputBraille", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkBraille.Location = new System.Drawing.Point(2854, 9);
            this.chkBraille.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.chkBraille.Name = "chkBraille";
            this.chkBraille.Size = new System.Drawing.Size(463, 37);
            this.chkBraille.TabIndex = 14;
            this.chkBraille.Text = "Output tfm messages to Braile display";
            this.chkBraille.UseVisualStyleBackColor = true;
            // 
            // grpAttitude
            // 
            this.grpAttitude.Controls.Add(this.flowLayoutPanel1);
            this.grpAttitude.Location = new System.Drawing.Point(7, 9);
            this.grpAttitude.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.grpAttitude.Name = "grpAttitude";
            this.grpAttitude.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.grpAttitude.Size = new System.Drawing.Size(235, 35);
            this.grpAttitude.TabIndex = 15;
            this.grpAttitude.TabStop = false;
            this.grpAttitude.Text = "Attitude output mode";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radTones);
            this.flowLayoutPanel1.Controls.Add(this.radSpeech);
            this.flowLayoutPanel1.Controls.Add(this.radBoth);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 42);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(500, 254);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // radTones
            // 
            this.radTones.AutoSize = true;
            this.radTones.Location = new System.Drawing.Point(7, 9);
            this.radTones.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.radTones.Name = "radTones";
            this.radTones.Size = new System.Drawing.Size(105, 37);
            this.radTones.TabIndex = 0;
            this.radTones.TabStop = true;
            this.radTones.Text = "Tones";
            this.radTones.UseVisualStyleBackColor = true;
            this.radTones.CheckedChanged += new System.EventHandler(this.radTones_CheckedChanged);
            // 
            // radSpeech
            // 
            this.radSpeech.AutoSize = true;
            this.radSpeech.Location = new System.Drawing.Point(126, 9);
            this.radSpeech.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.radSpeech.Name = "radSpeech";
            this.radSpeech.Size = new System.Drawing.Size(120, 37);
            this.radSpeech.TabIndex = 1;
            this.radSpeech.TabStop = true;
            this.radSpeech.Text = "Speech";
            this.radSpeech.UseVisualStyleBackColor = true;
            this.radSpeech.CheckedChanged += new System.EventHandler(this.radSpeech_CheckedChanged);
            // 
            // radBoth
            // 
            this.radBoth.AutoSize = true;
            this.radBoth.Location = new System.Drawing.Point(7, 64);
            this.radBoth.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.radBoth.Name = "radBoth";
            this.radBoth.Size = new System.Drawing.Size(238, 37);
            this.radBoth.TabIndex = 2;
            this.radBoth.TabStop = true;
            this.radBoth.Text = "Speech and Tones";
            this.radBoth.UseVisualStyleBackColor = true;
            this.radBoth.CheckedChanged += new System.EventHandler(this.radBoth_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "Output History Size: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AccessibleName = "output history size";
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::tfm.Properties.Settings.Default, "OutputHistoryLength", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown1.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(235, 40);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = global::tfm.Properties.Settings.Default.OutputHistoryLength;
            // 
            // grpSpeechSystem
            // 
            this.grpSpeechSystem.AccessibleName = "speech system";
            this.grpSpeechSystem.AutoSize = true;
            this.grpSpeechSystem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpSpeechSystem.Controls.Add(this.flowLayoutPanel2);
            this.grpSpeechSystem.Controls.Add(this.grpAzure);
            this.grpSpeechSystem.Location = new System.Drawing.Point(254, 5);
            this.grpSpeechSystem.Margin = new System.Windows.Forms.Padding(5);
            this.grpSpeechSystem.Name = "grpSpeechSystem";
            this.grpSpeechSystem.Padding = new System.Windows.Forms.Padding(5);
            this.grpSpeechSystem.Size = new System.Drawing.Size(639, 353);
            this.grpSpeechSystem.TabIndex = 0;
            this.grpSpeechSystem.TabStop = false;
            this.grpSpeechSystem.Text = "Speech System";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.radScreenReader);
            this.flowLayoutPanel2.Controls.Add(this.radSAPI);
            this.flowLayoutPanel2.Controls.Add(this.radAzureSpeech);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 148);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(621, 47);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // radScreenReader
            // 
            this.radScreenReader.AutoSize = true;
            this.radScreenReader.Location = new System.Drawing.Point(5, 5);
            this.radScreenReader.Margin = new System.Windows.Forms.Padding(5);
            this.radScreenReader.Name = "radScreenReader";
            this.radScreenReader.Size = new System.Drawing.Size(200, 37);
            this.radScreenReader.TabIndex = 0;
            this.radScreenReader.TabStop = true;
            this.radScreenReader.Text = "Screen Reader";
            this.radScreenReader.UseVisualStyleBackColor = true;
            this.radScreenReader.CheckedChanged += new System.EventHandler(this.radSpeechSystem_CheckedChanged);
            // 
            // radSAPI
            // 
            this.radSAPI.AutoSize = true;
            this.radSAPI.Location = new System.Drawing.Point(215, 5);
            this.radSAPI.Margin = new System.Windows.Forms.Padding(5);
            this.radSAPI.Name = "radSAPI";
            this.radSAPI.Size = new System.Drawing.Size(99, 37);
            this.radSAPI.TabIndex = 1;
            this.radSAPI.TabStop = true;
            this.radSAPI.Text = "SAPI";
            this.radSAPI.UseVisualStyleBackColor = true;
            this.radSAPI.CheckedChanged += new System.EventHandler(this.radSpeechSystem_CheckedChanged);
            // 
            // radAzureSpeech
            // 
            this.radAzureSpeech.AutoSize = true;
            this.radAzureSpeech.Enabled = false;
            this.radAzureSpeech.Location = new System.Drawing.Point(324, 5);
            this.radAzureSpeech.Margin = new System.Windows.Forms.Padding(5);
            this.radAzureSpeech.Name = "radAzureSpeech";
            this.radAzureSpeech.Size = new System.Drawing.Size(292, 37);
            this.radAzureSpeech.TabIndex = 2;
            this.radAzureSpeech.TabStop = true;
            this.radAzureSpeech.Text = "Azure Speech Services";
            this.radAzureSpeech.UseVisualStyleBackColor = true;
            this.radAzureSpeech.Visible = false;
            this.radAzureSpeech.CheckedChanged += new System.EventHandler(this.radSpeechSystem_CheckedChanged);
            // 
            // grpAzure
            // 
            this.grpAzure.AutoSize = true;
            this.grpAzure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpAzure.Controls.Add(this.flowLayoutPanel4);
            this.grpAzure.Enabled = false;
            this.grpAzure.Location = new System.Drawing.Point(8, 66);
            this.grpAzure.Margin = new System.Windows.Forms.Padding(5);
            this.grpAzure.Name = "grpAzure";
            this.grpAzure.Padding = new System.Windows.Forms.Padding(5);
            this.grpAzure.Size = new System.Drawing.Size(348, 244);
            this.grpAzure.TabIndex = 1;
            this.grpAzure.TabStop = false;
            this.grpAzure.Text = "Azure Settings";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.lblAzureKey);
            this.flowLayoutPanel4.Controls.Add(this.txtKey);
            this.flowLayoutPanel4.Controls.Add(this.lblRegion);
            this.flowLayoutPanel4.Controls.Add(this.txtRegion);
            this.flowLayoutPanel4.Controls.Add(this.grpFallback);
            this.flowLayoutPanel4.Controls.Add(this.lblVoice);
            this.flowLayoutPanel4.Controls.Add(this.txtVoice);
            this.flowLayoutPanel4.Controls.Add(this.btnVoice);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(5, 36);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(333, 165);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // lblAzureKey
            // 
            this.lblAzureKey.AutoSize = true;
            this.lblAzureKey.Location = new System.Drawing.Point(5, 0);
            this.lblAzureKey.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAzureKey.Name = "lblAzureKey";
            this.lblAzureKey.Size = new System.Drawing.Size(142, 33);
            this.lblAzureKey.TabIndex = 0;
            this.lblAzureKey.Text = "Azure key: ";
            // 
            // txtKey
            // 
            this.txtKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::tfm.Properties.Settings.Default, "AzureAPIKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtKey.Location = new System.Drawing.Point(157, 5);
            this.txtKey.Margin = new System.Windows.Forms.Padding(5);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(164, 40);
            this.txtKey.TabIndex = 1;
            this.txtKey.Text = global::tfm.Properties.Settings.Default.AzureAPIKey;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(5, 50);
            this.lblRegion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(100, 33);
            this.lblRegion.TabIndex = 2;
            this.lblRegion.Text = "region: ";
            // 
            // txtRegion
            // 
            this.txtRegion.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::tfm.Properties.Settings.Default, "AzureServiceRegion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRegion.Location = new System.Drawing.Point(115, 55);
            this.txtRegion.Margin = new System.Windows.Forms.Padding(5);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(164, 40);
            this.txtRegion.TabIndex = 3;
            this.txtRegion.Text = global::tfm.Properties.Settings.Default.AzureServiceRegion;
            // 
            // grpFallback
            // 
            this.grpFallback.AutoSize = true;
            this.grpFallback.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpFallback.Controls.Add(this.flowLayoutPanel3);
            this.grpFallback.Location = new System.Drawing.Point(5, 105);
            this.grpFallback.Margin = new System.Windows.Forms.Padding(5);
            this.grpFallback.Name = "grpFallback";
            this.grpFallback.Padding = new System.Windows.Forms.Padding(5);
            this.grpFallback.Size = new System.Drawing.Size(334, 126);
            this.grpFallback.TabIndex = 5;
            this.grpFallback.TabStop = false;
            this.grpFallback.Text = "Fallback";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.radFBScreenReader);
            this.flowLayoutPanel3.Controls.Add(this.radFBSAPI);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(5, 36);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(319, 47);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // radFBScreenReader
            // 
            this.radFBScreenReader.AutoSize = true;
            this.radFBScreenReader.Location = new System.Drawing.Point(5, 5);
            this.radFBScreenReader.Margin = new System.Windows.Forms.Padding(5);
            this.radFBScreenReader.Name = "radFBScreenReader";
            this.radFBScreenReader.Size = new System.Drawing.Size(200, 37);
            this.radFBScreenReader.TabIndex = 0;
            this.radFBScreenReader.TabStop = true;
            this.radFBScreenReader.Text = "Screen Reader";
            this.radFBScreenReader.UseVisualStyleBackColor = true;
            this.radFBScreenReader.CheckedChanged += new System.EventHandler(this.radFallbackSpeech_CheckedChanged);
            // 
            // radFBSAPI
            // 
            this.radFBSAPI.AutoSize = true;
            this.radFBSAPI.Location = new System.Drawing.Point(215, 5);
            this.radFBSAPI.Margin = new System.Windows.Forms.Padding(5);
            this.radFBSAPI.Name = "radFBSAPI";
            this.radFBSAPI.Size = new System.Drawing.Size(99, 37);
            this.radFBSAPI.TabIndex = 1;
            this.radFBSAPI.TabStop = true;
            this.radFBSAPI.Text = "SAPI";
            this.radFBSAPI.UseVisualStyleBackColor = true;
            this.radFBSAPI.CheckedChanged += new System.EventHandler(this.radFallbackSpeech_CheckedChanged);
            // 
            // lblVoice
            // 
            this.lblVoice.AutoSize = true;
            this.lblVoice.Location = new System.Drawing.Point(3, 236);
            this.lblVoice.Name = "lblVoice";
            this.lblVoice.Size = new System.Drawing.Size(165, 33);
            this.lblVoice.TabIndex = 6;
            this.lblVoice.Text = "Current voice";
            // 
            // txtVoice
            // 
            this.txtVoice.Location = new System.Drawing.Point(174, 239);
            this.txtVoice.Name = "txtVoice";
            this.txtVoice.ReadOnly = true;
            this.txtVoice.Size = new System.Drawing.Size(100, 40);
            this.txtVoice.TabIndex = 7;
            // 
            // btnVoice
            // 
            this.btnVoice.AutoSize = true;
            this.btnVoice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVoice.Location = new System.Drawing.Point(5, 287);
            this.btnVoice.Margin = new System.Windows.Forms.Padding(5);
            this.btnVoice.Name = "btnVoice";
            this.btnVoice.Size = new System.Drawing.Size(182, 43);
            this.btnVoice.TabIndex = 8;
            this.btnVoice.Text = "Select Voice...";
            this.btnVoice.UseVisualStyleBackColor = true;
            this.btnVoice.Click += new System.EventHandler(this.btnVoice_Click);
            // 
            // grpVerbosity
            // 
            this.grpVerbosity.Controls.Add(this.flowLayoutPanel5);
            this.grpVerbosity.Location = new System.Drawing.Point(20, 108);
            this.grpVerbosity.Margin = new System.Windows.Forms.Padding(5);
            this.grpVerbosity.Name = "grpVerbosity";
            this.grpVerbosity.Padding = new System.Windows.Forms.Padding(5);
            this.grpVerbosity.Size = new System.Drawing.Size(333, 165);
            this.grpVerbosity.TabIndex = 19;
            this.grpVerbosity.TabStop = false;
            this.grpVerbosity.Text = "groupBox1";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.Controls.Add(this.chkReadInstrumentation);
            this.flowLayoutPanel5.Controls.Add(this.chkAltitude);
            this.flowLayoutPanel5.Controls.Add(this.chkReadGroundSpeed);
            this.flowLayoutPanel5.Controls.Add(this.chkReadILS);
            this.flowLayoutPanel5.Controls.Add(this.chkReadGPWS);
            this.flowLayoutPanel5.Controls.Add(this.chkFlightFollowing);
            this.flowLayoutPanel5.Controls.Add(this.chkBraille);
            this.flowLayoutPanel5.Controls.Add(this.chkReadSimconnectMessages);
            this.flowLayoutPanel5.Controls.Add(this.chkAutopilot);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(8, 9);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(4128, 55);
            this.flowLayoutPanel5.TabIndex = 15;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel6.Controls.Add(this.grpAttitude);
            this.flowLayoutPanel6.Controls.Add(this.grpSpeechSystem);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(898, 363);
            this.flowLayoutPanel6.TabIndex = 0;
            // 
            // ctlSpeechOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpVerbosity);
            this.Controls.Add(this.trkSpeechRate);
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.Name = "ctlSpeechOutput";
            this.Size = new System.Drawing.Size(906, 371);
            this.Load += new System.EventHandler(this.CtlSpeechOutput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeechRate)).EndInit();
            this.grpAttitude.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.grpSpeechSystem.ResumeLayout(false);
            this.grpSpeechSystem.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.grpAzure.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.grpFallback.ResumeLayout(false);
            this.grpFallback.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.grpVerbosity.ResumeLayout(false);
            this.grpVerbosity.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkFlightFollowing;
        private System.Windows.Forms.CheckBox chkReadSimconnectMessages;
        private System.Windows.Forms.CheckBox chkReadInstrumentation;
        private System.Windows.Forms.CheckBox chkReadGroundSpeed;
        private System.Windows.Forms.CheckBox chkReadILS;
        private System.Windows.Forms.CheckBox chkReadGPWS;
        private System.Windows.Forms.CheckBox chkAltitude;
        private System.Windows.Forms.CheckBox chkAutopilot;
        private System.Windows.Forms.TrackBar trkSpeechRate;
        private System.Windows.Forms.CheckBox chkBraille;
        private System.Windows.Forms.GroupBox grpAttitude;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radTones;
        private System.Windows.Forms.RadioButton radSpeech;
        private System.Windows.Forms.RadioButton radBoth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox grpSpeechSystem;
        private System.Windows.Forms.GroupBox grpAzure;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label lblAzureKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.GroupBox grpFallback;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.RadioButton radFBScreenReader;
        private System.Windows.Forms.RadioButton radFBSAPI;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton radScreenReader;
        private System.Windows.Forms.RadioButton radSAPI;
        private System.Windows.Forms.RadioButton radAzureSpeech;
        private System.Windows.Forms.GroupBox grpVerbosity;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label lblVoice;
        private System.Windows.Forms.TextBox txtVoice;
        private System.Windows.Forms.Button btnVoice;
    }
}
