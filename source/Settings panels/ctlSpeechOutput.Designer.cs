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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeechRate)).BeginInit();
            this.grpAttitude.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.grpSpeechSystem.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.grpAzure.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.chkReadInstrumentation, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.trkSpeechRate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkAltitude, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkReadGroundSpeed, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.chkReadILS, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkReadGPWS, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkFlightFollowing, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkReadSimconnectMessages, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkAutopilot, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkBraille, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.grpAttitude, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.grpSpeechSystem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpAzure, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 154);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chkReadInstrumentation
            // 
            this.chkReadInstrumentation.AutoSize = true;
            this.chkReadInstrumentation.Checked = global::tfm.Properties.Settings.Default.ReadInstrumentation;
            this.chkReadInstrumentation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReadInstrumentation.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::tfm.Properties.Settings.Default, "ReadInstrumentation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkReadInstrumentation.Location = new System.Drawing.Point(461, 5);
            this.chkReadInstrumentation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkReadInstrumentation.Name = "chkReadInstrumentation";
            this.chkReadInstrumentation.Size = new System.Drawing.Size(188, 1);
            this.chkReadInstrumentation.TabIndex = 2;
            this.chkReadInstrumentation.Text = "Read instrumentation";
            this.chkReadInstrumentation.UseVisualStyleBackColor = true;
            // 
            // trkSpeechRate
            // 
            this.trkSpeechRate.AccessibleName = "SAPI speech rate";
            this.trkSpeechRate.Location = new System.Drawing.Point(4, 5);
            this.trkSpeechRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trkSpeechRate.Maximum = 20;
            this.trkSpeechRate.Name = "trkSpeechRate";
            this.trkSpeechRate.Size = new System.Drawing.Size(141, 1);
            this.trkSpeechRate.TabIndex = 1;
            this.trkSpeechRate.Value = 10;
            this.trkSpeechRate.Scroll += new System.EventHandler(this.trkSpeechRate_Scroll);
            // 
            // chkAltitude
            // 
            this.chkAltitude.AutoSize = true;
            this.chkAltitude.Checked = global::tfm.Properties.Settings.Default.AltitudeAnnouncements;
            this.chkAltitude.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAltitude.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::tfm.Properties.Settings.Default, "AltitudeAnnouncements", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAltitude.Location = new System.Drawing.Point(752, 5);
            this.chkAltitude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAltitude.Name = "chkAltitude";
            this.chkAltitude.Size = new System.Drawing.Size(243, 21);
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
            this.chkReadGroundSpeed.Location = new System.Drawing.Point(4, 67);
            this.chkReadGroundSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkReadGroundSpeed.Name = "chkReadGroundSpeed";
            this.chkReadGroundSpeed.Size = new System.Drawing.Size(372, 21);
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
            this.chkReadILS.Location = new System.Drawing.Point(461, 5);
            this.chkReadILS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkReadILS.Name = "chkReadILS";
            this.chkReadILS.Size = new System.Drawing.Size(279, 21);
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
            this.chkReadGPWS.Location = new System.Drawing.Point(4, 5);
            this.chkReadGPWS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkReadGPWS.Name = "chkReadGPWS";
            this.chkReadGPWS.Size = new System.Drawing.Size(449, 21);
            this.chkReadGPWS.TabIndex = 8;
            this.chkReadGPWS.Text = "Ground proximity warning system (GPWS) announcements";
            this.chkReadGPWS.UseVisualStyleBackColor = true;
            // 
            // chkFlightFollowing
            // 
            this.chkFlightFollowing.AutoSize = true;
            this.chkFlightFollowing.Checked = global::tfm.Properties.Settings.Default.FlightFollowing;
            this.chkFlightFollowing.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::tfm.Properties.Settings.Default, "FlightFollowing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkFlightFollowing.Location = new System.Drawing.Point(461, 5);
            this.chkFlightFollowing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkFlightFollowing.Name = "chkFlightFollowing";
            this.chkFlightFollowing.Size = new System.Drawing.Size(260, 1);
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
            this.chkReadSimconnectMessages.Location = new System.Drawing.Point(752, 5);
            this.chkReadSimconnectMessages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkReadSimconnectMessages.Name = "chkReadSimconnectMessages";
            this.chkReadSimconnectMessages.Size = new System.Drawing.Size(242, 1);
            this.chkReadSimconnectMessages.TabIndex = 4;
            this.chkReadSimconnectMessages.Text = "Read SimConnect messages";
            this.chkReadSimconnectMessages.UseVisualStyleBackColor = true;
            // 
            // chkAutopilot
            // 
            this.chkAutopilot.AutoSize = true;
            this.chkAutopilot.Checked = global::tfm.Properties.Settings.Default.ReadAutopilot;
            this.chkAutopilot.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::tfm.Properties.Settings.Default, "ReadAutopilot", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAutopilot.Location = new System.Drawing.Point(461, 36);
            this.chkAutopilot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAutopilot.Name = "chkAutopilot";
            this.chkAutopilot.Size = new System.Drawing.Size(283, 21);
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
            this.chkBraille.Location = new System.Drawing.Point(4, 98);
            this.chkBraille.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBraille.Name = "chkBraille";
            this.chkBraille.Size = new System.Drawing.Size(302, 21);
            this.chkBraille.TabIndex = 14;
            this.chkBraille.Text = "Output tfm messages to Braile display";
            this.chkBraille.UseVisualStyleBackColor = true;
            // 
            // grpAttitude
            // 
            this.grpAttitude.Controls.Add(this.flowLayoutPanel1);
            this.grpAttitude.Location = new System.Drawing.Point(461, 98);
            this.grpAttitude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAttitude.Name = "grpAttitude";
            this.grpAttitude.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAttitude.Size = new System.Drawing.Size(141, 21);
            this.grpAttitude.TabIndex = 15;
            this.grpAttitude.TabStop = false;
            this.grpAttitude.Text = "Attitude output mode";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radTones);
            this.flowLayoutPanel1.Controls.Add(this.radSpeech);
            this.flowLayoutPanel1.Controls.Add(this.radBoth);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 25);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 154);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // radTones
            // 
            this.radTones.AutoSize = true;
            this.radTones.Location = new System.Drawing.Point(4, 5);
            this.radTones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radTones.Name = "radTones";
            this.radTones.Size = new System.Drawing.Size(78, 24);
            this.radTones.TabIndex = 0;
            this.radTones.TabStop = true;
            this.radTones.Text = "Tones";
            this.radTones.UseVisualStyleBackColor = true;
            this.radTones.CheckedChanged += new System.EventHandler(this.radTones_CheckedChanged);
            // 
            // radSpeech
            // 
            this.radSpeech.AutoSize = true;
            this.radSpeech.Location = new System.Drawing.Point(90, 5);
            this.radSpeech.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radSpeech.Name = "radSpeech";
            this.radSpeech.Size = new System.Drawing.Size(89, 24);
            this.radSpeech.TabIndex = 1;
            this.radSpeech.TabStop = true;
            this.radSpeech.Text = "Speech";
            this.radSpeech.UseVisualStyleBackColor = true;
            this.radSpeech.CheckedChanged += new System.EventHandler(this.radSpeech_CheckedChanged);
            // 
            // radBoth
            // 
            this.radBoth.AutoSize = true;
            this.radBoth.Location = new System.Drawing.Point(4, 39);
            this.radBoth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radBoth.Name = "radBoth";
            this.radBoth.Size = new System.Drawing.Size(168, 24);
            this.radBoth.TabIndex = 2;
            this.radBoth.TabStop = true;
            this.radBoth.Text = "Speech and Tones";
            this.radBoth.UseVisualStyleBackColor = true;
            this.radBoth.CheckedChanged += new System.EventHandler(this.radBoth_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Output History Size: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AccessibleName = "output history size";
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::tfm.Properties.Settings.Default, "OutputHistoryLength", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown1.Location = new System.Drawing.Point(461, 129);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(141, 26);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = global::tfm.Properties.Settings.Default.OutputHistoryLength;
            // 
            // grpSpeechSystem
            // 
            this.grpSpeechSystem.AccessibleName = "speech system";
            this.grpSpeechSystem.AutoSize = true;
            this.grpSpeechSystem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpSpeechSystem.Controls.Add(this.flowLayoutPanel2);
            this.grpSpeechSystem.Location = new System.Drawing.Point(3, 3);
            this.grpSpeechSystem.Name = "grpSpeechSystem";
            this.grpSpeechSystem.Size = new System.Drawing.Size(441, 1);
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
            this.flowLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // radScreenReader
            // 
            this.radScreenReader.AutoSize = true;
            this.radScreenReader.Location = new System.Drawing.Point(3, 3);
            this.radScreenReader.Name = "radScreenReader";
            this.radScreenReader.Size = new System.Drawing.Size(142, 24);
            this.radScreenReader.TabIndex = 0;
            this.radScreenReader.TabStop = true;
            this.radScreenReader.Text = "Screen Reader";
            this.radScreenReader.UseVisualStyleBackColor = true;
            this.radScreenReader.CheckedChanged += new System.EventHandler(this.radSpeechSystem_CheckedChanged);
            // 
            // radSAPI
            // 
            this.radSAPI.AutoSize = true;
            this.radSAPI.Location = new System.Drawing.Point(3, 33);
            this.radSAPI.Name = "radSAPI";
            this.radSAPI.Size = new System.Drawing.Size(71, 24);
            this.radSAPI.TabIndex = 1;
            this.radSAPI.TabStop = true;
            this.radSAPI.Text = "SAPI";
            this.radSAPI.UseVisualStyleBackColor = true;
            this.radSAPI.CheckedChanged += new System.EventHandler(this.radSpeechSystem_CheckedChanged);
            // 
            // radAzureSpeech
            // 
            this.radAzureSpeech.AutoSize = true;
            this.radAzureSpeech.Location = new System.Drawing.Point(3, 63);
            this.radAzureSpeech.Name = "radAzureSpeech";
            this.radAzureSpeech.Size = new System.Drawing.Size(199, 24);
            this.radAzureSpeech.TabIndex = 2;
            this.radAzureSpeech.TabStop = true;
            this.radAzureSpeech.Text = "Azure Speech Services";
            this.radAzureSpeech.UseVisualStyleBackColor = true;
            this.radAzureSpeech.CheckedChanged += new System.EventHandler(this.radSpeechSystem_CheckedChanged);
            // 
            // grpAzure
            // 
            this.grpAzure.AutoSize = true;
            this.grpAzure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpAzure.Controls.Add(this.flowLayoutPanel3);
            this.grpAzure.Location = new System.Drawing.Point(751, 3);
            this.grpAzure.Name = "grpAzure";
            this.grpAzure.Size = new System.Drawing.Size(240, 1);
            this.grpAzure.TabIndex = 18;
            this.grpAzure.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.lblKey);
            this.flowLayoutPanel3.Controls.Add(this.txtKey);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(3, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(117, 20);
            this.lblKey.TabIndex = 0;
            this.lblKey.Text = "Azure API key: ";
            // 
            // txtKey
            // 
            this.txtKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::tfm.Properties.Settings.Default, "AzureAPIKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtKey.Location = new System.Drawing.Point(3, 23);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 26);
            this.txtKey.TabIndex = 1;
            this.txtKey.Text = global::tfm.Properties.Settings.Default.AzureAPIKey;
            // 
            // ctlSpeechOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctlSpeechOutput";
            this.Size = new System.Drawing.Size(225, 231);
            this.Load += new System.EventHandler(this.ctlSpeechOutput_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
            this.grpAzure.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton radScreenReader;
        private System.Windows.Forms.RadioButton radSAPI;
        private System.Windows.Forms.RadioButton radAzureSpeech;
        private System.Windows.Forms.GroupBox grpAzure;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtKey;
    }
}
