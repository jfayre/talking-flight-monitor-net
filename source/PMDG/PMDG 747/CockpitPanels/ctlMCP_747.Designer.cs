
namespace tfm
{
    partial class ctlMCP_747
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.speedGroup = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.speedIntvButton = new System.Windows.Forms.Button();
            this.cmdSpdButton = new System.Windows.Forms.Button();
            this.iasMachToggleButton = new System.Windows.Forms.Button();
            this.autoThrottleButton = new System.Windows.Forms.Button();
            this.thrustButton = new System.Windows.Forms.Button();
            this.altitudeGroup = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.altitudeTextBox = new System.Windows.Forms.TextBox();
            this.altitudeHoldButton = new System.Windows.Forms.Button();
            this.flChangeButton = new System.Windows.Forms.Button();
            this.altitudeButton = new System.Windows.Forms.Button();
            this.headingGroup = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.headingTextBox = new System.Windows.Forms.TextBox();
            this.headingHoldButton = new System.Windows.Forms.Button();
            this.headingButton = new System.Windows.Forms.Button();
            this.verticalSpeedGroup = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.verticalSpeedTextBox = new System.Windows.Forms.TextBox();
            this.vertSpeedHoldButton = new System.Windows.Forms.Button();
            this.navigationGroup = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.fdlButton = new System.Windows.Forms.Button();
            this.fdrButton = new System.Windows.Forms.Button();
            this.bankLimitButton = new System.Windows.Forms.Button();
            this.disBarButton = new System.Windows.Forms.Button();
            this.apLButton = new System.Windows.Forms.Button();
            this.apCButton = new System.Windows.Forms.Button();
            this.apRButton = new System.Windows.Forms.Button();
            this.lNavButton = new System.Windows.Forms.Button();
            this.vNavButton = new System.Windows.Forms.Button();
            this.locHoldButton = new System.Windows.Forms.Button();
            this.apprButton = new System.Windows.Forms.Button();
            this.panelLightsListBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.speedGroup.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.altitudeGroup.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.headingGroup.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.verticalSpeedGroup.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.navigationGroup.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.speedGroup);
            this.flowLayoutPanel1.Controls.Add(this.altitudeGroup);
            this.flowLayoutPanel1.Controls.Add(this.headingGroup);
            this.flowLayoutPanel1.Controls.Add(this.verticalSpeedGroup);
            this.flowLayoutPanel1.Controls.Add(this.navigationGroup);
            this.flowLayoutPanel1.Controls.Add(this.panelLightsListBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(1100, 700);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1063, 398);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // speedGroup
            // 
            this.speedGroup.AccessibleName = "Speed controls";
            this.speedGroup.AutoSize = true;
            this.speedGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.speedGroup.Controls.Add(this.flowLayoutPanel2);
            this.speedGroup.Location = new System.Drawing.Point(3, 3);
            this.speedGroup.Name = "speedGroup";
            this.speedGroup.Size = new System.Drawing.Size(420, 169);
            this.speedGroup.TabIndex = 0;
            this.speedGroup.TabStop = false;
            this.speedGroup.Text = "Speed";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.speedTextBox);
            this.flowLayoutPanel2.Controls.Add(this.speedIntvButton);
            this.flowLayoutPanel2.Controls.Add(this.cmdSpdButton);
            this.flowLayoutPanel2.Controls.Add(this.iasMachToggleButton);
            this.flowLayoutPanel2.Controls.Add(this.autoThrottleButton);
            this.flowLayoutPanel2.Controls.Add(this.thrustButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(500, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(411, 96);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // speedTextBox
            // 
            this.speedTextBox.AccessibleName = "Speed";
            this.speedTextBox.Location = new System.Drawing.Point(3, 3);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(100, 39);
            this.speedTextBox.TabIndex = 0;
            this.speedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedTextBox_KeyDown);
            // 
            // speedIntvButton
            // 
            this.speedIntvButton.AccessibleName = "Speed intervene";
            this.speedIntvButton.AutoSize = true;
            this.speedIntvButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.speedIntvButton.Location = new System.Drawing.Point(109, 3);
            this.speedIntvButton.Name = "speedIntvButton";
            this.speedIntvButton.Size = new System.Drawing.Size(140, 42);
            this.speedIntvButton.TabIndex = 1;
            this.speedIntvButton.Text = "Speed (I)";
            this.speedIntvButton.UseVisualStyleBackColor = true;
            this.speedIntvButton.Click += new System.EventHandler(this.speedIntvButton_Click);
            // 
            // cmdSpdButton
            // 
            this.cmdSpdButton.AccessibleName = "CMD SPD";
            this.cmdSpdButton.AutoSize = true;
            this.cmdSpdButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdSpdButton.Location = new System.Drawing.Point(255, 3);
            this.cmdSpdButton.Name = "cmdSpdButton";
            this.cmdSpdButton.Size = new System.Drawing.Size(153, 42);
            this.cmdSpdButton.TabIndex = 2;
            this.cmdSpdButton.Text = "CMD SPD";
            this.cmdSpdButton.UseVisualStyleBackColor = true;
            this.cmdSpdButton.Click += new System.EventHandler(this.cmdSpdButton_Click);
            // 
            // iasMachToggleButton
            // 
            this.iasMachToggleButton.AccessibleName = "IAS/MACH toggle";
            this.iasMachToggleButton.AutoSize = true;
            this.iasMachToggleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iasMachToggleButton.Location = new System.Drawing.Point(3, 51);
            this.iasMachToggleButton.Name = "iasMachToggleButton";
            this.iasMachToggleButton.Size = new System.Drawing.Size(149, 42);
            this.iasMachToggleButton.TabIndex = 3;
            this.iasMachToggleButton.Text = "I/M toggle";
            this.iasMachToggleButton.UseVisualStyleBackColor = true;
            this.iasMachToggleButton.Click += new System.EventHandler(this.iasMachToggleButton_Click);
            // 
            // autoThrottleButton
            // 
            this.autoThrottleButton.AccessibleName = "Auto throttle";
            this.autoThrottleButton.AutoSize = true;
            this.autoThrottleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.autoThrottleButton.Location = new System.Drawing.Point(158, 51);
            this.autoThrottleButton.Name = "autoThrottleButton";
            this.autoThrottleButton.Size = new System.Drawing.Size(61, 42);
            this.autoThrottleButton.TabIndex = 4;
            this.autoThrottleButton.Text = "AT";
            this.autoThrottleButton.UseVisualStyleBackColor = true;
            this.autoThrottleButton.Click += new System.EventHandler(this.autoThrottleButton_Click);
            // 
            // thrustButton
            // 
            this.thrustButton.AccessibleName = "Thrust";
            this.thrustButton.AutoSize = true;
            this.thrustButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.thrustButton.Location = new System.Drawing.Point(225, 51);
            this.thrustButton.Name = "thrustButton";
            this.thrustButton.Size = new System.Drawing.Size(67, 42);
            this.thrustButton.TabIndex = 5;
            this.thrustButton.Text = "Thr";
            this.thrustButton.UseVisualStyleBackColor = true;
            this.thrustButton.Click += new System.EventHandler(this.thrustButton_Click);
            // 
            // altitudeGroup
            // 
            this.altitudeGroup.AccessibleName = "Altitude controls";
            this.altitudeGroup.AutoSize = true;
            this.altitudeGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.altitudeGroup.Controls.Add(this.flowLayoutPanel3);
            this.altitudeGroup.Location = new System.Drawing.Point(429, 3);
            this.altitudeGroup.Name = "altitudeGroup";
            this.altitudeGroup.Size = new System.Drawing.Size(416, 121);
            this.altitudeGroup.TabIndex = 1;
            this.altitudeGroup.TabStop = false;
            this.altitudeGroup.Text = "Altitude";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.altitudeTextBox);
            this.flowLayoutPanel3.Controls.Add(this.altitudeHoldButton);
            this.flowLayoutPanel3.Controls.Add(this.flChangeButton);
            this.flowLayoutPanel3.Controls.Add(this.altitudeButton);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(407, 48);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // altitudeTextBox
            // 
            this.altitudeTextBox.AccessibleName = "Altitude";
            this.altitudeTextBox.Location = new System.Drawing.Point(3, 3);
            this.altitudeTextBox.Name = "altitudeTextBox";
            this.altitudeTextBox.Size = new System.Drawing.Size(100, 39);
            this.altitudeTextBox.TabIndex = 0;
            this.altitudeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.altitudeTextBox_KeyDown);
            // 
            // altitudeHoldButton
            // 
            this.altitudeHoldButton.AccessibleName = "Altitude hold";
            this.altitudeHoldButton.AutoSize = true;
            this.altitudeHoldButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.altitudeHoldButton.Location = new System.Drawing.Point(109, 3);
            this.altitudeHoldButton.Name = "altitudeHoldButton";
            this.altitudeHoldButton.Size = new System.Drawing.Size(121, 42);
            this.altitudeHoldButton.TabIndex = 1;
            this.altitudeHoldButton.Text = "Alt hold";
            this.altitudeHoldButton.UseVisualStyleBackColor = true;
            this.altitudeHoldButton.Click += new System.EventHandler(this.altitudeHoldButton_Click);
            // 
            // flChangeButton
            // 
            this.flChangeButton.AccessibleName = "Flight level change";
            this.flChangeButton.AutoSize = true;
            this.flChangeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flChangeButton.Location = new System.Drawing.Point(236, 3);
            this.flChangeButton.Name = "flChangeButton";
            this.flChangeButton.Size = new System.Drawing.Size(85, 42);
            this.flChangeButton.TabIndex = 2;
            this.flChangeButton.Text = "FlCh";
            this.flChangeButton.UseVisualStyleBackColor = true;
            this.flChangeButton.Click += new System.EventHandler(this.flChangeButton_Click);
            // 
            // altitudeButton
            // 
            this.altitudeButton.AccessibleName = "Altitude";
            this.altitudeButton.AutoSize = true;
            this.altitudeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.altitudeButton.Location = new System.Drawing.Point(327, 3);
            this.altitudeButton.Name = "altitudeButton";
            this.altitudeButton.Size = new System.Drawing.Size(77, 42);
            this.altitudeButton.TabIndex = 3;
            this.altitudeButton.Text = "ALT";
            this.altitudeButton.UseVisualStyleBackColor = true;
            this.altitudeButton.Click += new System.EventHandler(this.altitudeButton_Click);
            // 
            // headingGroup
            // 
            this.headingGroup.AccessibleName = "Heading controls";
            this.headingGroup.AutoSize = true;
            this.headingGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.headingGroup.Controls.Add(this.flowLayoutPanel4);
            this.headingGroup.Location = new System.Drawing.Point(851, 3);
            this.headingGroup.Name = "headingGroup";
            this.headingGroup.Size = new System.Drawing.Size(209, 73);
            this.headingGroup.TabIndex = 2;
            this.headingGroup.TabStop = false;
            this.headingGroup.Text = "Heading";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.headingTextBox);
            this.flowLayoutPanel4.Controls.Add(this.headingHoldButton);
            this.flowLayoutPanel4.Controls.Add(this.headingButton);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel4.MaximumSize = new System.Drawing.Size(200, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(200, 0);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // headingTextBox
            // 
            this.headingTextBox.AccessibleName = "Heading";
            this.headingTextBox.Location = new System.Drawing.Point(3, 3);
            this.headingTextBox.Name = "headingTextBox";
            this.headingTextBox.Size = new System.Drawing.Size(50, 39);
            this.headingTextBox.TabIndex = 0;
            this.headingTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.headingTextBox_KeyDown);
            // 
            // headingHoldButton
            // 
            this.headingHoldButton.AccessibleName = "Heading hold";
            this.headingHoldButton.AutoSize = true;
            this.headingHoldButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.headingHoldButton.Location = new System.Drawing.Point(59, 3);
            this.headingHoldButton.Name = "headingHoldButton";
            this.headingHoldButton.Size = new System.Drawing.Size(122, 42);
            this.headingHoldButton.TabIndex = 1;
            this.headingHoldButton.Text = "Hdg (H)";
            this.headingHoldButton.UseVisualStyleBackColor = true;
            this.headingHoldButton.Click += new System.EventHandler(this.headingHoldButton_Click);
            // 
            // headingButton
            // 
            this.headingButton.AccessibleName = "Heading";
            this.headingButton.AutoSize = true;
            this.headingButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.headingButton.Location = new System.Drawing.Point(3, 51);
            this.headingButton.Name = "headingButton";
            this.headingButton.Size = new System.Drawing.Size(77, 42);
            this.headingButton.TabIndex = 2;
            this.headingButton.Text = "Hdg";
            this.headingButton.UseVisualStyleBackColor = true;
            this.headingButton.Click += new System.EventHandler(this.headingButton_Click);
            // 
            // verticalSpeedGroup
            // 
            this.verticalSpeedGroup.AccessibleName = "Vertical speed controls";
            this.verticalSpeedGroup.AutoSize = true;
            this.verticalSpeedGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.verticalSpeedGroup.Controls.Add(this.flowLayoutPanel5);
            this.verticalSpeedGroup.Location = new System.Drawing.Point(3, 178);
            this.verticalSpeedGroup.Name = "verticalSpeedGroup";
            this.verticalSpeedGroup.Size = new System.Drawing.Size(258, 121);
            this.verticalSpeedGroup.TabIndex = 3;
            this.verticalSpeedGroup.TabStop = false;
            this.verticalSpeedGroup.Text = "Vert speed";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.Controls.Add(this.verticalSpeedTextBox);
            this.flowLayoutPanel5.Controls.Add(this.vertSpeedHoldButton);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(249, 48);
            this.flowLayoutPanel5.TabIndex = 0;
            // 
            // verticalSpeedTextBox
            // 
            this.verticalSpeedTextBox.AccessibleName = "Vertical speed";
            this.verticalSpeedTextBox.Location = new System.Drawing.Point(3, 3);
            this.verticalSpeedTextBox.Name = "verticalSpeedTextBox";
            this.verticalSpeedTextBox.Size = new System.Drawing.Size(70, 39);
            this.verticalSpeedTextBox.TabIndex = 0;
            this.verticalSpeedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.verticalSpeedTextBox_KeyDown);
            // 
            // vertSpeedHoldButton
            // 
            this.vertSpeedHoldButton.AccessibleName = "Vertical speed hold";
            this.vertSpeedHoldButton.AutoSize = true;
            this.vertSpeedHoldButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vertSpeedHoldButton.Location = new System.Drawing.Point(79, 3);
            this.vertSpeedHoldButton.Name = "vertSpeedHoldButton";
            this.vertSpeedHoldButton.Size = new System.Drawing.Size(167, 42);
            this.vertSpeedHoldButton.TabIndex = 1;
            this.vertSpeedHoldButton.Text = "Vspeed (H)";
            this.vertSpeedHoldButton.UseVisualStyleBackColor = true;
            this.vertSpeedHoldButton.Click += new System.EventHandler(this.vertSpeedHoldButton_Click);
            // 
            // navigationGroup
            // 
            this.navigationGroup.AccessibleName = "Navigation controls";
            this.navigationGroup.AutoSize = true;
            this.navigationGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.navigationGroup.Controls.Add(this.flowLayoutPanel6);
            this.navigationGroup.Location = new System.Drawing.Point(267, 178);
            this.navigationGroup.Name = "navigationGroup";
            this.navigationGroup.Size = new System.Drawing.Size(593, 217);
            this.navigationGroup.TabIndex = 4;
            this.navigationGroup.TabStop = false;
            this.navigationGroup.Text = "Navigation";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel6.Controls.Add(this.fdlButton);
            this.flowLayoutPanel6.Controls.Add(this.fdrButton);
            this.flowLayoutPanel6.Controls.Add(this.bankLimitButton);
            this.flowLayoutPanel6.Controls.Add(this.disBarButton);
            this.flowLayoutPanel6.Controls.Add(this.apLButton);
            this.flowLayoutPanel6.Controls.Add(this.apCButton);
            this.flowLayoutPanel6.Controls.Add(this.apRButton);
            this.flowLayoutPanel6.Controls.Add(this.lNavButton);
            this.flowLayoutPanel6.Controls.Add(this.vNavButton);
            this.flowLayoutPanel6.Controls.Add(this.locHoldButton);
            this.flowLayoutPanel6.Controls.Add(this.apprButton);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel6.MaximumSize = new System.Drawing.Size(600, 0);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(584, 144);
            this.flowLayoutPanel6.TabIndex = 0;
            // 
            // fdlButton
            // 
            this.fdlButton.AccessibleName = "FD/L";
            this.fdlButton.AutoSize = true;
            this.fdlButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fdlButton.Location = new System.Drawing.Point(3, 3);
            this.fdlButton.Name = "fdlButton";
            this.fdlButton.Size = new System.Drawing.Size(86, 42);
            this.fdlButton.TabIndex = 2;
            this.fdlButton.Text = "FD/L";
            this.fdlButton.UseVisualStyleBackColor = true;
            this.fdlButton.Click += new System.EventHandler(this.fdlButton_Click);
            // 
            // fdrButton
            // 
            this.fdrButton.AccessibleName = "FD/R";
            this.fdrButton.AutoSize = true;
            this.fdrButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fdrButton.Location = new System.Drawing.Point(95, 3);
            this.fdrButton.Name = "fdrButton";
            this.fdrButton.Size = new System.Drawing.Size(90, 42);
            this.fdrButton.TabIndex = 3;
            this.fdrButton.Text = "FD/R";
            this.fdrButton.UseVisualStyleBackColor = true;
            this.fdrButton.Click += new System.EventHandler(this.fdrButton_Click);
            // 
            // bankLimitButton
            // 
            this.bankLimitButton.AccessibleName = "Bank limit selector";
            this.bankLimitButton.AutoSize = true;
            this.bankLimitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bankLimitButton.Location = new System.Drawing.Point(191, 3);
            this.bankLimitButton.Name = "bankLimitButton";
            this.bankLimitButton.Size = new System.Drawing.Size(164, 42);
            this.bankLimitButton.TabIndex = 4;
            this.bankLimitButton.Text = "BnkLim sel";
            this.bankLimitButton.UseVisualStyleBackColor = true;
            this.bankLimitButton.Click += new System.EventHandler(this.bankLimitButton_Click);
            // 
            // disBarButton
            // 
            this.disBarButton.AccessibleName = "Disengage bar";
            this.disBarButton.AutoSize = true;
            this.disBarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.disBarButton.Location = new System.Drawing.Point(361, 3);
            this.disBarButton.Name = "disBarButton";
            this.disBarButton.Size = new System.Drawing.Size(210, 42);
            this.disBarButton.TabIndex = 5;
            this.disBarButton.Text = "Disengage bar";
            this.disBarButton.UseVisualStyleBackColor = true;
            this.disBarButton.Click += new System.EventHandler(this.disBarButton_Click);
            // 
            // apLButton
            // 
            this.apLButton.AccessibleName = "AP/L";
            this.apLButton.AutoSize = true;
            this.apLButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.apLButton.Location = new System.Drawing.Point(3, 51);
            this.apLButton.Name = "apLButton";
            this.apLButton.Size = new System.Drawing.Size(87, 42);
            this.apLButton.TabIndex = 6;
            this.apLButton.Text = "AP/L";
            this.apLButton.UseVisualStyleBackColor = true;
            this.apLButton.Click += new System.EventHandler(this.apLButton_Click);
            // 
            // apCButton
            // 
            this.apCButton.AccessibleName = "AP/C";
            this.apCButton.AutoSize = true;
            this.apCButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.apCButton.Location = new System.Drawing.Point(96, 51);
            this.apCButton.Name = "apCButton";
            this.apCButton.Size = new System.Drawing.Size(91, 42);
            this.apCButton.TabIndex = 7;
            this.apCButton.Text = "AP/C";
            this.apCButton.UseVisualStyleBackColor = true;
            this.apCButton.Click += new System.EventHandler(this.apCButton_Click);
            // 
            // apRButton
            // 
            this.apRButton.AccessibleName = "AP/R";
            this.apRButton.AutoSize = true;
            this.apRButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.apRButton.Location = new System.Drawing.Point(193, 51);
            this.apRButton.Name = "apRButton";
            this.apRButton.Size = new System.Drawing.Size(91, 42);
            this.apRButton.TabIndex = 8;
            this.apRButton.Text = "AP/R";
            this.apRButton.UseVisualStyleBackColor = true;
            this.apRButton.Click += new System.EventHandler(this.apRButton_Click);
            // 
            // lNavButton
            // 
            this.lNavButton.AccessibleName = "L Nav";
            this.lNavButton.AutoSize = true;
            this.lNavButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lNavButton.Location = new System.Drawing.Point(290, 51);
            this.lNavButton.Name = "lNavButton";
            this.lNavButton.Size = new System.Drawing.Size(78, 42);
            this.lNavButton.TabIndex = 9;
            this.lNavButton.Text = "lnav";
            this.lNavButton.UseVisualStyleBackColor = true;
            this.lNavButton.Click += new System.EventHandler(this.lNavButton_Click);
            // 
            // vNavButton
            // 
            this.vNavButton.AccessibleName = "V Nav";
            this.vNavButton.AutoSize = true;
            this.vNavButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vNavButton.Location = new System.Drawing.Point(374, 51);
            this.vNavButton.Name = "vNavButton";
            this.vNavButton.Size = new System.Drawing.Size(85, 42);
            this.vNavButton.TabIndex = 10;
            this.vNavButton.Text = "vnav";
            this.vNavButton.UseVisualStyleBackColor = true;
            this.vNavButton.Click += new System.EventHandler(this.vNavButton_Click);
            // 
            // locHoldButton
            // 
            this.locHoldButton.AccessibleName = "Localizer hold";
            this.locHoldButton.AutoSize = true;
            this.locHoldButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.locHoldButton.Location = new System.Drawing.Point(465, 51);
            this.locHoldButton.Name = "locHoldButton";
            this.locHoldButton.Size = new System.Drawing.Size(116, 42);
            this.locHoldButton.TabIndex = 11;
            this.locHoldButton.Text = "Loc (H)";
            this.locHoldButton.UseVisualStyleBackColor = true;
            this.locHoldButton.Click += new System.EventHandler(this.locHoldButton_Click);
            // 
            // apprButton
            // 
            this.apprButton.AccessibleName = "Approach mode";
            this.apprButton.AutoSize = true;
            this.apprButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.apprButton.Location = new System.Drawing.Point(3, 99);
            this.apprButton.Name = "apprButton";
            this.apprButton.Size = new System.Drawing.Size(85, 42);
            this.apprButton.TabIndex = 12;
            this.apprButton.Text = "Appr";
            this.apprButton.UseVisualStyleBackColor = true;
            this.apprButton.Click += new System.EventHandler(this.apprButton_Click);
            // 
            // panelLightsListBox
            // 
            this.panelLightsListBox.AccessibleName = "Panel lights";
            this.panelLightsListBox.FormattingEnabled = true;
            this.panelLightsListBox.ItemHeight = 32;
            this.panelLightsListBox.Location = new System.Drawing.Point(866, 178);
            this.panelLightsListBox.Name = "panelLightsListBox";
            this.panelLightsListBox.Size = new System.Drawing.Size(120, 68);
            this.panelLightsListBox.TabIndex = 5;
            // 
            // ctlMCP_747
            // 
            this.AccessibleName = "PMDG 747 MCP panel";
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.Name = "ctlMCP_747";
            this.Size = new System.Drawing.Size(1066, 401);
            this.Load += new System.EventHandler(this.ctlMCP_747_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.speedGroup.ResumeLayout(false);
            this.speedGroup.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.altitudeGroup.ResumeLayout(false);
            this.altitudeGroup.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.headingGroup.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.verticalSpeedGroup.ResumeLayout(false);
            this.verticalSpeedGroup.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.navigationGroup.ResumeLayout(false);
            this.navigationGroup.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox speedGroup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Button speedIntvButton;
        private System.Windows.Forms.Button cmdSpdButton;
        private System.Windows.Forms.Button iasMachToggleButton;
        private System.Windows.Forms.Button autoThrottleButton;
        private System.Windows.Forms.Button thrustButton;
        private System.Windows.Forms.GroupBox altitudeGroup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox altitudeTextBox;
        private System.Windows.Forms.Button altitudeHoldButton;
        private System.Windows.Forms.Button flChangeButton;
        private System.Windows.Forms.Button altitudeButton;
        private System.Windows.Forms.GroupBox headingGroup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TextBox headingTextBox;
        private System.Windows.Forms.Button headingHoldButton;
        private System.Windows.Forms.Button headingButton;
        private System.Windows.Forms.GroupBox verticalSpeedGroup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.TextBox verticalSpeedTextBox;
        private System.Windows.Forms.Button vertSpeedHoldButton;
        private System.Windows.Forms.GroupBox navigationGroup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Button fdlButton;
        private System.Windows.Forms.Button fdrButton;
        private System.Windows.Forms.Button bankLimitButton;
        private System.Windows.Forms.Button disBarButton;
        private System.Windows.Forms.Button apLButton;
        private System.Windows.Forms.Button apCButton;
        private System.Windows.Forms.Button apRButton;
        private System.Windows.Forms.Button lNavButton;
        private System.Windows.Forms.Button vNavButton;
        private System.Windows.Forms.Button locHoldButton;
        private System.Windows.Forms.Button apprButton;
        private System.Windows.Forms.ListBox panelLightsListBox;
    }
}
