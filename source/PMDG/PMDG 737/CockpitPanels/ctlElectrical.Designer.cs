namespace tfm
{
    partial class ctlElectrical
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
            this.components = new System.ComponentModel.Container();
            this.tmrElectrical = new System.Windows.Forms.Timer(this.components);
            this.chkBattery = new System.Windows.Forms.CheckBox();
            this.chkCabUtil = new System.Windows.Forms.CheckBox();
            this.grpStandby = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radStandbyBat = new System.Windows.Forms.RadioButton();
            this.radStandbyOff = new System.Windows.Forms.RadioButton();
            this.radStandbyAuto = new System.Windows.Forms.RadioButton();
            this.chkPassSeat = new System.Windows.Forms.CheckBox();
            this.grpGroundPower = new System.Windows.Forms.GroupBox();
            this.btnGroundPowerOff = new System.Windows.Forms.Button();
            this.btnGroundPowerOn = new System.Windows.Forms.Button();
            this.grpAPUGen = new System.Windows.Forms.GroupBox();
            this.btnAPU2Off = new System.Windows.Forms.Button();
            this.btnAPU2On = new System.Windows.Forms.Button();
            this.btnAPU1Off = new System.Windows.Forms.Button();
            this.btnAPU1On = new System.Windows.Forms.Button();
            this.grpEngineGenerators = new System.Windows.Forms.GroupBox();
            this.btnGen2Off = new System.Windows.Forms.Button();
            this.btnGen2On = new System.Windows.Forms.Button();
            this.btnGen1Off = new System.Windows.Forms.Button();
            this.btnGen1On = new System.Windows.Forms.Button();
            this.grpMeter = new System.Windows.Forms.GroupBox();
            this.grpDCSource = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.radDCStandby = new System.Windows.Forms.RadioButton();
            this.radDCBatBus = new System.Windows.Forms.RadioButton();
            this.radDCBattery = new System.Windows.Forms.RadioButton();
            this.radDCAuxBat = new System.Windows.Forms.RadioButton();
            this.radDCTR1 = new System.Windows.Forms.RadioButton();
            this.radDCTR2 = new System.Windows.Forms.RadioButton();
            this.radDCTR3 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDCVolts = new System.Windows.Forms.Label();
            this.txtDCVolts = new System.Windows.Forms.TextBox();
            this.lblDCAmps = new System.Windows.Forms.Label();
            this.txtDCAmps = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtACVolts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtACAmps = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtACFrequency = new System.Windows.Forms.TextBox();
            this.grpACSource = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.radACStandby = new System.Windows.Forms.RadioButton();
            this.radACGroundPower = new System.Windows.Forms.RadioButton();
            this.radACGen1 = new System.Windows.Forms.RadioButton();
            this.radACAPUGen = new System.Windows.Forms.RadioButton();
            this.radACGen2 = new System.Windows.Forms.RadioButton();
            this.radACInverter = new System.Windows.Forms.RadioButton();
            this.grpAPU = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAPUStart = new System.Windows.Forms.Button();
            this.btnAPUShutdown = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAPUEGT = new System.Windows.Forms.TextBox();
            this.grpStandby.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.grpGroundPower.SuspendLayout();
            this.grpAPUGen.SuspendLayout();
            this.grpEngineGenerators.SuspendLayout();
            this.grpMeter.SuspendLayout();
            this.grpDCSource.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.grpACSource.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.grpAPU.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrElectrical
            // 
            this.tmrElectrical.Interval = 500;
            this.tmrElectrical.Tick += new System.EventHandler(this.tmrElectrical_Tick);
            // 
            // chkBattery
            // 
            this.chkBattery.AutoSize = true;
            this.chkBattery.Location = new System.Drawing.Point(5, 5);
            this.chkBattery.Name = "chkBattery";
            this.chkBattery.Size = new System.Drawing.Size(86, 24);
            this.chkBattery.TabIndex = 0;
            this.chkBattery.Text = "Battery";
            this.chkBattery.UseVisualStyleBackColor = true;
            this.chkBattery.CheckedChanged += new System.EventHandler(this.chkBattery_CheckedChanged);
            // 
            // chkCabUtil
            // 
            this.chkCabUtil.AutoSize = true;
            this.chkCabUtil.Location = new System.Drawing.Point(335, 5);
            this.chkCabUtil.Name = "chkCabUtil";
            this.chkCabUtil.Size = new System.Drawing.Size(118, 24);
            this.chkCabUtil.TabIndex = 2;
            this.chkCabUtil.Text = "Cabin Utility";
            this.chkCabUtil.UseVisualStyleBackColor = true;
            this.chkCabUtil.CheckedChanged += new System.EventHandler(this.chkCabUtil_CheckedChanged);
            // 
            // grpStandby
            // 
            this.grpStandby.AutoSize = true;
            this.grpStandby.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpStandby.Controls.Add(this.flowLayoutPanel1);
            this.grpStandby.Location = new System.Drawing.Point(97, 5);
            this.grpStandby.Name = "grpStandby";
            this.grpStandby.Size = new System.Drawing.Size(234, 58);
            this.grpStandby.TabIndex = 1;
            this.grpStandby.TabStop = false;
            this.grpStandby.Text = "Standby Power";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.radStandbyBat);
            this.flowLayoutPanel1.Controls.Add(this.radStandbyOff);
            this.flowLayoutPanel1.Controls.Add(this.radStandbyAuto);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(225, 30);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // radStandbyBat
            // 
            this.radStandbyBat.AutoSize = true;
            this.radStandbyBat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radStandbyBat.Location = new System.Drawing.Point(3, 3);
            this.radStandbyBat.Name = "radStandbyBat";
            this.radStandbyBat.Size = new System.Drawing.Size(83, 24);
            this.radStandbyBat.TabIndex = 0;
            this.radStandbyBat.TabStop = true;
            this.radStandbyBat.Text = "Battery";
            this.radStandbyBat.UseVisualStyleBackColor = true;
            this.radStandbyBat.CheckedChanged += new System.EventHandler(this.RadStandby_CheckChanged);
            // 
            // radStandbyOff
            // 
            this.radStandbyOff.AutoSize = true;
            this.radStandbyOff.Location = new System.Drawing.Point(92, 3);
            this.radStandbyOff.Name = "radStandbyOff";
            this.radStandbyOff.Size = new System.Drawing.Size(56, 24);
            this.radStandbyOff.TabIndex = 1;
            this.radStandbyOff.TabStop = true;
            this.radStandbyOff.Text = "Off";
            this.radStandbyOff.UseVisualStyleBackColor = true;
            this.radStandbyOff.CheckedChanged += new System.EventHandler(this.RadStandby_CheckChanged);
            // 
            // radStandbyAuto
            // 
            this.radStandbyAuto.AutoSize = true;
            this.radStandbyAuto.Location = new System.Drawing.Point(154, 3);
            this.radStandbyAuto.Name = "radStandbyAuto";
            this.radStandbyAuto.Size = new System.Drawing.Size(68, 24);
            this.radStandbyAuto.TabIndex = 2;
            this.radStandbyAuto.TabStop = true;
            this.radStandbyAuto.Text = "Auto";
            this.radStandbyAuto.UseVisualStyleBackColor = true;
            this.radStandbyAuto.CheckedChanged += new System.EventHandler(this.RadStandby_CheckChanged);
            // 
            // chkPassSeat
            // 
            this.chkPassSeat.AutoSize = true;
            this.chkPassSeat.Location = new System.Drawing.Point(460, 5);
            this.chkPassSeat.Name = "chkPassSeat";
            this.chkPassSeat.Size = new System.Drawing.Size(197, 24);
            this.chkPassSeat.TabIndex = 3;
            this.chkPassSeat.Text = "Passenger Seat Power";
            this.chkPassSeat.UseVisualStyleBackColor = true;
            // 
            // grpGroundPower
            // 
            this.grpGroundPower.AutoSize = true;
            this.grpGroundPower.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpGroundPower.Controls.Add(this.btnGroundPowerOff);
            this.grpGroundPower.Controls.Add(this.btnGroundPowerOn);
            this.grpGroundPower.Location = new System.Drawing.Point(5, 100);
            this.grpGroundPower.Name = "grpGroundPower";
            this.grpGroundPower.Size = new System.Drawing.Size(164, 51);
            this.grpGroundPower.TabIndex = 4;
            this.grpGroundPower.TabStop = false;
            this.grpGroundPower.Text = "ground power";
            // 
            // btnGroundPowerOff
            // 
            this.btnGroundPowerOff.Location = new System.Drawing.Point(83, 3);
            this.btnGroundPowerOff.Name = "btnGroundPowerOff";
            this.btnGroundPowerOff.Size = new System.Drawing.Size(75, 23);
            this.btnGroundPowerOff.TabIndex = 1;
            this.btnGroundPowerOff.Text = "Off";
            this.btnGroundPowerOff.UseVisualStyleBackColor = true;
            this.btnGroundPowerOff.Click += new System.EventHandler(this.btnGroundPowerOff_Click);
            // 
            // btnGroundPowerOn
            // 
            this.btnGroundPowerOn.Location = new System.Drawing.Point(3, 3);
            this.btnGroundPowerOn.Name = "btnGroundPowerOn";
            this.btnGroundPowerOn.Size = new System.Drawing.Size(75, 23);
            this.btnGroundPowerOn.TabIndex = 0;
            this.btnGroundPowerOn.Text = "On";
            this.btnGroundPowerOn.UseVisualStyleBackColor = true;
            this.btnGroundPowerOn.Click += new System.EventHandler(this.btnGroundPowerOn_Click);
            // 
            // grpAPUGen
            // 
            this.grpAPUGen.AutoSize = true;
            this.grpAPUGen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpAPUGen.Controls.Add(this.btnAPU2Off);
            this.grpAPUGen.Controls.Add(this.btnAPU2On);
            this.grpAPUGen.Controls.Add(this.btnAPU1Off);
            this.grpAPUGen.Controls.Add(this.btnAPU1On);
            this.grpAPUGen.Location = new System.Drawing.Point(175, 100);
            this.grpAPUGen.Name = "grpAPUGen";
            this.grpAPUGen.Size = new System.Drawing.Size(164, 78);
            this.grpAPUGen.TabIndex = 5;
            this.grpAPUGen.TabStop = false;
            this.grpAPUGen.Text = "APU Generators";
            // 
            // btnAPU2Off
            // 
            this.btnAPU2Off.Location = new System.Drawing.Point(83, 30);
            this.btnAPU2Off.Name = "btnAPU2Off";
            this.btnAPU2Off.Size = new System.Drawing.Size(75, 23);
            this.btnAPU2Off.TabIndex = 3;
            this.btnAPU2Off.Text = "APU Generator 2 Off";
            this.btnAPU2Off.UseVisualStyleBackColor = true;
            this.btnAPU2Off.Click += new System.EventHandler(this.btnAPU2Off_Click);
            // 
            // btnAPU2On
            // 
            this.btnAPU2On.Location = new System.Drawing.Point(3, 30);
            this.btnAPU2On.Name = "btnAPU2On";
            this.btnAPU2On.Size = new System.Drawing.Size(75, 23);
            this.btnAPU2On.TabIndex = 2;
            this.btnAPU2On.Text = "APU Generator 2 On";
            this.btnAPU2On.UseVisualStyleBackColor = true;
            this.btnAPU2On.Click += new System.EventHandler(this.btnAPU2On_Click);
            // 
            // btnAPU1Off
            // 
            this.btnAPU1Off.Location = new System.Drawing.Point(83, 3);
            this.btnAPU1Off.Name = "btnAPU1Off";
            this.btnAPU1Off.Size = new System.Drawing.Size(75, 23);
            this.btnAPU1Off.TabIndex = 1;
            this.btnAPU1Off.Text = "Apu Generator 1 Off";
            this.btnAPU1Off.UseVisualStyleBackColor = true;
            this.btnAPU1Off.Click += new System.EventHandler(this.btnAPU1Off_Click);
            // 
            // btnAPU1On
            // 
            this.btnAPU1On.Location = new System.Drawing.Point(3, 3);
            this.btnAPU1On.Name = "btnAPU1On";
            this.btnAPU1On.Size = new System.Drawing.Size(75, 23);
            this.btnAPU1On.TabIndex = 0;
            this.btnAPU1On.Text = "APU Generator 1 On";
            this.btnAPU1On.UseVisualStyleBackColor = true;
            this.btnAPU1On.Click += new System.EventHandler(this.btnAPU1On_Click);
            // 
            // grpEngineGenerators
            // 
            this.grpEngineGenerators.AutoSize = true;
            this.grpEngineGenerators.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpEngineGenerators.Controls.Add(this.btnGen2Off);
            this.grpEngineGenerators.Controls.Add(this.btnGen2On);
            this.grpEngineGenerators.Controls.Add(this.btnGen1Off);
            this.grpEngineGenerators.Controls.Add(this.btnGen1On);
            this.grpEngineGenerators.Location = new System.Drawing.Point(345, 100);
            this.grpEngineGenerators.Name = "grpEngineGenerators";
            this.grpEngineGenerators.Size = new System.Drawing.Size(164, 78);
            this.grpEngineGenerators.TabIndex = 6;
            this.grpEngineGenerators.TabStop = false;
            this.grpEngineGenerators.Text = "Engine Generators";
            // 
            // btnGen2Off
            // 
            this.btnGen2Off.Location = new System.Drawing.Point(83, 30);
            this.btnGen2Off.Name = "btnGen2Off";
            this.btnGen2Off.Size = new System.Drawing.Size(75, 23);
            this.btnGen2Off.TabIndex = 3;
            this.btnGen2Off.Text = "Eng 2 Gen Off";
            this.btnGen2Off.UseVisualStyleBackColor = true;
            this.btnGen2Off.Click += new System.EventHandler(this.btnGen2Off_Click);
            // 
            // btnGen2On
            // 
            this.btnGen2On.Location = new System.Drawing.Point(3, 30);
            this.btnGen2On.Name = "btnGen2On";
            this.btnGen2On.Size = new System.Drawing.Size(75, 23);
            this.btnGen2On.TabIndex = 2;
            this.btnGen2On.Text = "Eng 2 Gen On";
            this.btnGen2On.UseVisualStyleBackColor = true;
            this.btnGen2On.Click += new System.EventHandler(this.btnGen2On_Click);
            // 
            // btnGen1Off
            // 
            this.btnGen1Off.Location = new System.Drawing.Point(83, 3);
            this.btnGen1Off.Name = "btnGen1Off";
            this.btnGen1Off.Size = new System.Drawing.Size(75, 23);
            this.btnGen1Off.TabIndex = 1;
            this.btnGen1Off.Text = "Eng 1 Gen Off";
            this.btnGen1Off.UseVisualStyleBackColor = true;
            this.btnGen1Off.Click += new System.EventHandler(this.btnGen1Off_Click);
            // 
            // btnGen1On
            // 
            this.btnGen1On.Location = new System.Drawing.Point(3, 3);
            this.btnGen1On.Name = "btnGen1On";
            this.btnGen1On.Size = new System.Drawing.Size(75, 23);
            this.btnGen1On.TabIndex = 0;
            this.btnGen1On.Text = "Eng 1 gen on";
            this.btnGen1On.UseVisualStyleBackColor = true;
            this.btnGen1On.Click += new System.EventHandler(this.btnGen1On_Click);
            // 
            // grpMeter
            // 
            this.grpMeter.AutoSize = true;
            this.grpMeter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpMeter.Controls.Add(this.flowLayoutPanel4);
            this.grpMeter.Controls.Add(this.grpDCSource);
            this.grpMeter.Controls.Add(this.flowLayoutPanel2);
            this.grpMeter.Location = new System.Drawing.Point(5, 515);
            this.grpMeter.Name = "grpMeter";
            this.grpMeter.Size = new System.Drawing.Size(808, 282);
            this.grpMeter.TabIndex = 7;
            this.grpMeter.TabStop = false;
            this.grpMeter.Text = "Electrical Metering";
            // 
            // grpDCSource
            // 
            this.grpDCSource.AutoSize = true;
            this.grpDCSource.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpDCSource.Controls.Add(this.flowLayoutPanel3);
            this.grpDCSource.Location = new System.Drawing.Point(3, 110);
            this.grpDCSource.Name = "grpDCSource";
            this.grpDCSource.Size = new System.Drawing.Size(209, 147);
            this.grpDCSource.TabIndex = 1;
            this.grpDCSource.TabStop = false;
            this.grpDCSource.Text = "DC Source";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.radDCStandby);
            this.flowLayoutPanel3.Controls.Add(this.radDCBatBus);
            this.flowLayoutPanel3.Controls.Add(this.radDCBattery);
            this.flowLayoutPanel3.Controls.Add(this.radDCAuxBat);
            this.flowLayoutPanel3.Controls.Add(this.radDCTR1);
            this.flowLayoutPanel3.Controls.Add(this.radDCTR2);
            this.flowLayoutPanel3.Controls.Add(this.radDCTR3);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // radDCStandby
            // 
            this.radDCStandby.AutoSize = true;
            this.radDCStandby.Location = new System.Drawing.Point(3, 3);
            this.radDCStandby.Name = "radDCStandby";
            this.radDCStandby.Size = new System.Drawing.Size(93, 24);
            this.radDCStandby.TabIndex = 0;
            this.radDCStandby.TabStop = true;
            this.radDCStandby.Text = "Standby";
            this.radDCStandby.UseVisualStyleBackColor = true;
            this.radDCStandby.CheckedChanged += new System.EventHandler(this.radDCSource_CheckChanged);
            // 
            // radDCBatBus
            // 
            this.radDCBatBus.AutoSize = true;
            this.radDCBatBus.Location = new System.Drawing.Point(3, 33);
            this.radDCBatBus.Name = "radDCBatBus";
            this.radDCBatBus.Size = new System.Drawing.Size(117, 24);
            this.radDCBatBus.TabIndex = 1;
            this.radDCBatBus.TabStop = true;
            this.radDCBatBus.Text = "Battery Bus";
            this.radDCBatBus.UseVisualStyleBackColor = true;
            this.radDCBatBus.CheckedChanged += new System.EventHandler(this.radDCSource_CheckChanged);
            // 
            // radDCBattery
            // 
            this.radDCBattery.AutoSize = true;
            this.radDCBattery.Location = new System.Drawing.Point(3, 63);
            this.radDCBattery.Name = "radDCBattery";
            this.radDCBattery.Size = new System.Drawing.Size(85, 24);
            this.radDCBattery.TabIndex = 2;
            this.radDCBattery.TabStop = true;
            this.radDCBattery.Text = "Battery";
            this.radDCBattery.UseVisualStyleBackColor = true;
            this.radDCBattery.CheckedChanged += new System.EventHandler(this.radDCSource_CheckChanged);
            // 
            // radDCAuxBat
            // 
            this.radDCAuxBat.AutoSize = true;
            this.radDCAuxBat.Location = new System.Drawing.Point(94, 63);
            this.radDCAuxBat.Name = "radDCAuxBat";
            this.radDCAuxBat.Size = new System.Drawing.Size(90, 24);
            this.radDCAuxBat.TabIndex = 3;
            this.radDCAuxBat.TabStop = true;
            this.radDCAuxBat.Text = "Aux Bat";
            this.radDCAuxBat.UseVisualStyleBackColor = true;
            this.radDCAuxBat.CheckedChanged += new System.EventHandler(this.radDCSource_CheckChanged);
            // 
            // radDCTR1
            // 
            this.radDCTR1.AutoSize = true;
            this.radDCTR1.Location = new System.Drawing.Point(3, 93);
            this.radDCTR1.Name = "radDCTR1";
            this.radDCTR1.Size = new System.Drawing.Size(68, 24);
            this.radDCTR1.TabIndex = 4;
            this.radDCTR1.TabStop = true;
            this.radDCTR1.Text = "TR 1";
            this.radDCTR1.UseVisualStyleBackColor = true;
            this.radDCTR1.CheckedChanged += new System.EventHandler(this.radDCSource_CheckChanged);
            // 
            // radDCTR2
            // 
            this.radDCTR2.AutoSize = true;
            this.radDCTR2.Location = new System.Drawing.Point(77, 93);
            this.radDCTR2.Name = "radDCTR2";
            this.radDCTR2.Size = new System.Drawing.Size(68, 24);
            this.radDCTR2.TabIndex = 5;
            this.radDCTR2.TabStop = true;
            this.radDCTR2.Text = "TR 2";
            this.radDCTR2.UseVisualStyleBackColor = true;
            this.radDCTR2.CheckedChanged += new System.EventHandler(this.radDCSource_CheckChanged);
            // 
            // radDCTR3
            // 
            this.radDCTR3.AutoSize = true;
            this.radDCTR3.Location = new System.Drawing.Point(3, 123);
            this.radDCTR3.Name = "radDCTR3";
            this.radDCTR3.Size = new System.Drawing.Size(68, 24);
            this.radDCTR3.TabIndex = 6;
            this.radDCTR3.TabStop = true;
            this.radDCTR3.Text = "TR 3";
            this.radDCTR3.UseVisualStyleBackColor = true;
            this.radDCTR3.CheckedChanged += new System.EventHandler(this.radDCSource_CheckChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblDCVolts);
            this.flowLayoutPanel2.Controls.Add(this.txtDCVolts);
            this.flowLayoutPanel2.Controls.Add(this.lblDCAmps);
            this.flowLayoutPanel2.Controls.Add(this.txtDCAmps);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // lblDCVolts
            // 
            this.lblDCVolts.AutoSize = true;
            this.lblDCVolts.Location = new System.Drawing.Point(3, 0);
            this.lblDCVolts.Name = "lblDCVolts";
            this.lblDCVolts.Size = new System.Drawing.Size(72, 20);
            this.lblDCVolts.TabIndex = 2;
            this.lblDCVolts.Text = "DC Volts";
            // 
            // txtDCVolts
            // 
            this.txtDCVolts.Location = new System.Drawing.Point(81, 3);
            this.txtDCVolts.Name = "txtDCVolts";
            this.txtDCVolts.ReadOnly = true;
            this.txtDCVolts.Size = new System.Drawing.Size(100, 26);
            this.txtDCVolts.TabIndex = 3;
            // 
            // lblDCAmps
            // 
            this.lblDCAmps.AutoSize = true;
            this.lblDCAmps.Location = new System.Drawing.Point(3, 32);
            this.lblDCAmps.Name = "lblDCAmps";
            this.lblDCAmps.Size = new System.Drawing.Size(77, 20);
            this.lblDCAmps.TabIndex = 4;
            this.lblDCAmps.Text = "DC Amps";
            // 
            // txtDCAmps
            // 
            this.txtDCAmps.Location = new System.Drawing.Point(86, 35);
            this.txtDCAmps.Name = "txtDCAmps";
            this.txtDCAmps.ReadOnly = true;
            this.txtDCAmps.Size = new System.Drawing.Size(100, 26);
            this.txtDCAmps.TabIndex = 5;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Controls.Add(this.txtACVolts);
            this.flowLayoutPanel4.Controls.Add(this.label2);
            this.flowLayoutPanel4.Controls.Add(this.txtACAmps);
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.txtACFrequency);
            this.flowLayoutPanel4.Controls.Add(this.grpACSource);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 110);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(799, 106);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "AC Volts";
            // 
            // txtACVolts
            // 
            this.txtACVolts.Location = new System.Drawing.Point(80, 3);
            this.txtACVolts.Name = "txtACVolts";
            this.txtACVolts.Size = new System.Drawing.Size(100, 26);
            this.txtACVolts.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "AC Amps";
            // 
            // txtACAmps
            // 
            this.txtACAmps.Location = new System.Drawing.Point(268, 3);
            this.txtACAmps.Name = "txtACAmps";
            this.txtACAmps.Size = new System.Drawing.Size(100, 26);
            this.txtACAmps.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "AC Frequency";
            // 
            // txtACFrequency
            // 
            this.txtACFrequency.Location = new System.Drawing.Point(490, 3);
            this.txtACFrequency.Name = "txtACFrequency";
            this.txtACFrequency.Size = new System.Drawing.Size(100, 26);
            this.txtACFrequency.TabIndex = 5;
            // 
            // grpACSource
            // 
            this.grpACSource.Controls.Add(this.flowLayoutPanel5);
            this.grpACSource.Location = new System.Drawing.Point(596, 3);
            this.grpACSource.Name = "grpACSource";
            this.grpACSource.Size = new System.Drawing.Size(200, 100);
            this.grpACSource.TabIndex = 6;
            this.grpACSource.TabStop = false;
            this.grpACSource.Text = "AC Source";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.radACStandby);
            this.flowLayoutPanel5.Controls.Add(this.radACGroundPower);
            this.flowLayoutPanel5.Controls.Add(this.radACGen1);
            this.flowLayoutPanel5.Controls.Add(this.radACAPUGen);
            this.flowLayoutPanel5.Controls.Add(this.radACGen2);
            this.flowLayoutPanel5.Controls.Add(this.radACInverter);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel5.TabIndex = 0;
            // 
            // radACStandby
            // 
            this.radACStandby.AutoSize = true;
            this.radACStandby.Location = new System.Drawing.Point(3, 3);
            this.radACStandby.Name = "radACStandby";
            this.radACStandby.Size = new System.Drawing.Size(93, 24);
            this.radACStandby.TabIndex = 0;
            this.radACStandby.TabStop = true;
            this.radACStandby.Text = "Standby";
            this.radACStandby.UseVisualStyleBackColor = true;
            this.radACStandby.CheckedChanged += new System.EventHandler(this.radACSource_CheckChanged);
            // 
            // radACGroundPower
            // 
            this.radACGroundPower.AutoSize = true;
            this.radACGroundPower.Location = new System.Drawing.Point(3, 33);
            this.radACGroundPower.Name = "radACGroundPower";
            this.radACGroundPower.Size = new System.Drawing.Size(136, 24);
            this.radACGroundPower.TabIndex = 1;
            this.radACGroundPower.TabStop = true;
            this.radACGroundPower.Text = "Ground Power";
            this.radACGroundPower.UseVisualStyleBackColor = true;
            this.radACGroundPower.CheckedChanged += new System.EventHandler(this.radACSource_CheckChanged);
            // 
            // radACGen1
            // 
            this.radACGen1.AutoSize = true;
            this.radACGen1.Location = new System.Drawing.Point(3, 63);
            this.radACGen1.Name = "radACGen1";
            this.radACGen1.Size = new System.Drawing.Size(78, 24);
            this.radACGen1.TabIndex = 2;
            this.radACGen1.TabStop = true;
            this.radACGen1.Text = "Gen 1";
            this.radACGen1.UseVisualStyleBackColor = true;
            this.radACGen1.CheckedChanged += new System.EventHandler(this.radACSource_CheckChanged);
            // 
            // radACAPUGen
            // 
            this.radACAPUGen.AutoSize = true;
            this.radACAPUGen.Location = new System.Drawing.Point(87, 63);
            this.radACAPUGen.Name = "radACAPUGen";
            this.radACAPUGen.Size = new System.Drawing.Size(102, 24);
            this.radACAPUGen.TabIndex = 3;
            this.radACAPUGen.TabStop = true;
            this.radACAPUGen.Text = "APU Gen";
            this.radACAPUGen.UseVisualStyleBackColor = true;
            this.radACAPUGen.CheckedChanged += new System.EventHandler(this.radACSource_CheckChanged);
            // 
            // radACGen2
            // 
            this.radACGen2.AutoSize = true;
            this.radACGen2.Location = new System.Drawing.Point(3, 93);
            this.radACGen2.Name = "radACGen2";
            this.radACGen2.Size = new System.Drawing.Size(126, 24);
            this.radACGen2.TabIndex = 4;
            this.radACGen2.TabStop = true;
            this.radACGen2.Text = "radioButton5";
            this.radACGen2.UseVisualStyleBackColor = true;
            this.radACGen2.CheckedChanged += new System.EventHandler(this.radACSource_CheckChanged);
            // 
            // radACInverter
            // 
            this.radACInverter.AutoSize = true;
            this.radACInverter.Location = new System.Drawing.Point(3, 123);
            this.radACInverter.Name = "radACInverter";
            this.radACInverter.Size = new System.Drawing.Size(88, 24);
            this.radACInverter.TabIndex = 5;
            this.radACInverter.TabStop = true;
            this.radACInverter.Text = "Inverter";
            this.radACInverter.UseVisualStyleBackColor = true;
            this.radACInverter.CheckedChanged += new System.EventHandler(this.radACSource_CheckChanged);
            // 
            // grpAPU
            // 
            this.grpAPU.AutoSize = true;
            this.grpAPU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpAPU.Controls.Add(this.flowLayoutPanel6);
            this.grpAPU.Location = new System.Drawing.Point(515, 100);
            this.grpAPU.Name = "grpAPU";
            this.grpAPU.Size = new System.Drawing.Size(209, 147);
            this.grpAPU.TabIndex = 8;
            this.grpAPU.TabStop = false;
            this.grpAPU.Text = "APU";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.btnAPUStart);
            this.flowLayoutPanel6.Controls.Add(this.btnAPUShutdown);
            this.flowLayoutPanel6.Controls.Add(this.label4);
            this.flowLayoutPanel6.Controls.Add(this.txtAPUEGT);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel6.TabIndex = 0;
            // 
            // btnAPUStart
            // 
            this.btnAPUStart.Location = new System.Drawing.Point(3, 3);
            this.btnAPUStart.Name = "btnAPUStart";
            this.btnAPUStart.Size = new System.Drawing.Size(75, 23);
            this.btnAPUStart.TabIndex = 0;
            this.btnAPUStart.Text = "Start APU";
            this.btnAPUStart.UseVisualStyleBackColor = true;
            this.btnAPUStart.Click += new System.EventHandler(this.btnAPUStart_Click);
            // 
            // btnAPUShutdown
            // 
            this.btnAPUShutdown.Location = new System.Drawing.Point(84, 3);
            this.btnAPUShutdown.Name = "btnAPUShutdown";
            this.btnAPUShutdown.Size = new System.Drawing.Size(75, 23);
            this.btnAPUShutdown.TabIndex = 1;
            this.btnAPUShutdown.Text = "Shut down APU";
            this.btnAPUShutdown.UseVisualStyleBackColor = true;
            this.btnAPUShutdown.Click += new System.EventHandler(this.btnAPUShutdown_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "APU EGT";
            // 
            // txtAPUEGT
            // 
            this.txtAPUEGT.Location = new System.Drawing.Point(88, 32);
            this.txtAPUEGT.Name = "txtAPUEGT";
            this.txtAPUEGT.Size = new System.Drawing.Size(100, 26);
            this.txtAPUEGT.TabIndex = 3;
            // 
            // ctlElectrical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.grpAPU);
            this.Controls.Add(this.grpMeter);
            this.Controls.Add(this.grpEngineGenerators);
            this.Controls.Add(this.grpAPUGen);
            this.Controls.Add(this.grpGroundPower);
            this.Controls.Add(this.chkPassSeat);
            this.Controls.Add(this.grpStandby);
            this.Controls.Add(this.chkCabUtil);
            this.Controls.Add(this.chkBattery);
            this.Name = "ctlElectrical";
            this.Size = new System.Drawing.Size(816, 800);
            this.Load += new System.EventHandler(this.ctlElectrical_Load);
            this.grpStandby.ResumeLayout(false);
            this.grpStandby.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.grpGroundPower.ResumeLayout(false);
            this.grpAPUGen.ResumeLayout(false);
            this.grpEngineGenerators.ResumeLayout(false);
            this.grpMeter.ResumeLayout(false);
            this.grpMeter.PerformLayout();
            this.grpDCSource.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.grpACSource.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.grpAPU.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrElectrical;
        private System.Windows.Forms.CheckBox chkBattery;
        private System.Windows.Forms.CheckBox chkCabUtil;
        private System.Windows.Forms.GroupBox grpStandby;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radStandbyBat;
        private System.Windows.Forms.RadioButton radStandbyOff;
        private System.Windows.Forms.RadioButton radStandbyAuto;
        private System.Windows.Forms.CheckBox chkPassSeat;
        private System.Windows.Forms.GroupBox grpGroundPower;
        private System.Windows.Forms.Button btnGroundPowerOff;
        private System.Windows.Forms.Button btnGroundPowerOn;
        private System.Windows.Forms.GroupBox grpAPUGen;
        private System.Windows.Forms.Button btnAPU1Off;
        private System.Windows.Forms.Button btnAPU1On;
        private System.Windows.Forms.Button btnAPU2Off;
        private System.Windows.Forms.Button btnAPU2On;
        private System.Windows.Forms.GroupBox grpEngineGenerators;
        private System.Windows.Forms.Button btnGen2Off;
        private System.Windows.Forms.Button btnGen2On;
        private System.Windows.Forms.Button btnGen1Off;
        private System.Windows.Forms.Button btnGen1On;
        private System.Windows.Forms.GroupBox grpMeter;
        private System.Windows.Forms.GroupBox grpDCSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.RadioButton radDCStandby;
        private System.Windows.Forms.RadioButton radDCBatBus;
        private System.Windows.Forms.RadioButton radDCBattery;
        private System.Windows.Forms.RadioButton radDCAuxBat;
        private System.Windows.Forms.RadioButton radDCTR1;
        private System.Windows.Forms.RadioButton radDCTR2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblDCVolts;
        private System.Windows.Forms.TextBox txtDCVolts;
        private System.Windows.Forms.Label lblDCAmps;
        private System.Windows.Forms.TextBox txtDCAmps;
        private System.Windows.Forms.RadioButton radDCTR3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtACVolts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtACAmps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtACFrequency;
        private System.Windows.Forms.GroupBox grpACSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.RadioButton radACStandby;
        private System.Windows.Forms.RadioButton radACGroundPower;
        private System.Windows.Forms.RadioButton radACGen1;
        private System.Windows.Forms.RadioButton radACAPUGen;
        private System.Windows.Forms.RadioButton radACGen2;
        private System.Windows.Forms.RadioButton radACInverter;
        private System.Windows.Forms.GroupBox grpAPU;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Button btnAPUStart;
        private System.Windows.Forms.Button btnAPUShutdown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAPUEGT;
    }
}
