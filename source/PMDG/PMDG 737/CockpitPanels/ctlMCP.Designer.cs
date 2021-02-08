namespace tfm
{
    partial class ctlMCP
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
            this.tmrMCP = new System.Windows.Forms.Timer(this.components);
            this.chkFlightDirectorLeft = new System.Windows.Forms.CheckBox();
            this.grpCourse = new System.Windows.Forms.GroupBox();
            this.txtCourseR = new System.Windows.Forms.TextBox();
            this.lblCourseR = new System.Windows.Forms.Label();
            this.txtCourseL = new System.Windows.Forms.TextBox();
            this.lblCourseL = new System.Windows.Forms.Label();
            this.grpSpeed = new System.Windows.Forms.GroupBox();
            this.btnSpeedINTV = new System.Windows.Forms.Button();
            this.btnSpeed = new System.Windows.Forms.Button();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.btnN1 = new System.Windows.Forms.Button();
            this.chkATArm = new System.Windows.Forms.CheckBox();
            this.chkFlightDirectorRight = new System.Windows.Forms.CheckBox();
            this.grpAltitude = new System.Windows.Forms.GroupBox();
            this.btnVspeed = new System.Windows.Forms.Button();
            this.btnVNav = new System.Windows.Forms.Button();
            this.lblVspeed = new System.Windows.Forms.Label();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.txtVSpd = new System.Windows.Forms.TextBox();
            this.btnAltHold = new System.Windows.Forms.Button();
            this.btnAltIntv = new System.Windows.Forms.Button();
            this.btnLvlChg = new System.Windows.Forms.Button();
            this.txtAltitude = new System.Windows.Forms.TextBox();
            this.grpHeading = new System.Windows.Forms.GroupBox();
            this.btnLNav = new System.Windows.Forms.Button();
            this.btnHdgSel = new System.Windows.Forms.Button();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.grpModes = new System.Windows.Forms.GroupBox();
            this.btnCWSB = new System.Windows.Forms.Button();
            this.btnCWSA = new System.Windows.Forms.Button();
            this.btnCmdB = new System.Windows.Forms.Button();
            this.btnCmdA = new System.Windows.Forms.Button();
            this.btnApproach = new System.Windows.Forms.Button();
            this.btnVorLock = new System.Windows.Forms.Button();
            this.grpCourse.SuspendLayout();
            this.grpSpeed.SuspendLayout();
            this.grpAltitude.SuspendLayout();
            this.grpHeading.SuspendLayout();
            this.grpModes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrMCP
            // 
            this.tmrMCP.Interval = 300;
            this.tmrMCP.Tick += new System.EventHandler(this.tmrMCP_Tick);
            // 
            // chkFlightDirectorLeft
            // 
            this.chkFlightDirectorLeft.AutoSize = true;
            this.chkFlightDirectorLeft.Location = new System.Drawing.Point(655, 8);
            this.chkFlightDirectorLeft.Margin = new System.Windows.Forms.Padding(5);
            this.chkFlightDirectorLeft.Name = "chkFlightDirectorLeft";
            this.chkFlightDirectorLeft.Size = new System.Drawing.Size(129, 37);
            this.chkFlightDirectorLeft.TabIndex = 4;
            this.chkFlightDirectorLeft.Text = "Left FD";
            this.chkFlightDirectorLeft.UseVisualStyleBackColor = true;
            this.chkFlightDirectorLeft.CheckedChanged += new System.EventHandler(this.chkFlightDirectorLeft_CheckedChanged);
            // 
            // grpCourse
            // 
            this.grpCourse.AutoSize = true;
            this.grpCourse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpCourse.Controls.Add(this.txtCourseR);
            this.grpCourse.Controls.Add(this.lblCourseR);
            this.grpCourse.Controls.Add(this.txtCourseL);
            this.grpCourse.Controls.Add(this.lblCourseL);
            this.grpCourse.Location = new System.Drawing.Point(8, 8);
            this.grpCourse.Margin = new System.Windows.Forms.Padding(5);
            this.grpCourse.Name = "grpCourse";
            this.grpCourse.Padding = new System.Windows.Forms.Padding(5);
            this.grpCourse.Size = new System.Drawing.Size(657, 91);
            this.grpCourse.TabIndex = 2;
            this.grpCourse.TabStop = false;
            this.grpCourse.Text = "Nav Course";
            // 
            // txtCourseR
            // 
            this.txtCourseR.Location = new System.Drawing.Point(483, 8);
            this.txtCourseR.Margin = new System.Windows.Forms.Padding(5);
            this.txtCourseR.Name = "txtCourseR";
            this.txtCourseR.Size = new System.Drawing.Size(164, 40);
            this.txtCourseR.TabIndex = 6;
            // 
            // lblCourseR
            // 
            this.lblCourseR.AutoSize = true;
            this.lblCourseR.Location = new System.Drawing.Point(332, 8);
            this.lblCourseR.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCourseR.Name = "lblCourseR";
            this.lblCourseR.Size = new System.Drawing.Size(156, 33);
            this.lblCourseR.TabIndex = 5;
            this.lblCourseR.Text = "Right course";
            // 
            // txtCourseL
            // 
            this.txtCourseL.Location = new System.Drawing.Point(162, 7);
            this.txtCourseL.Margin = new System.Windows.Forms.Padding(5);
            this.txtCourseL.Name = "txtCourseL";
            this.txtCourseL.Size = new System.Drawing.Size(164, 40);
            this.txtCourseL.TabIndex = 4;
            // 
            // lblCourseL
            // 
            this.lblCourseL.AutoSize = true;
            this.lblCourseL.Location = new System.Drawing.Point(8, 8);
            this.lblCourseL.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCourseL.Name = "lblCourseL";
            this.lblCourseL.Size = new System.Drawing.Size(139, 33);
            this.lblCourseL.TabIndex = 3;
            this.lblCourseL.Text = "Left course";
            // 
            // grpSpeed
            // 
            this.grpSpeed.AutoSize = true;
            this.grpSpeed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpSpeed.Controls.Add(this.btnSpeedINTV);
            this.grpSpeed.Controls.Add(this.btnSpeed);
            this.grpSpeed.Controls.Add(this.txtSpeed);
            this.grpSpeed.Controls.Add(this.btnN1);
            this.grpSpeed.Controls.Add(this.chkATArm);
            this.grpSpeed.Location = new System.Drawing.Point(8, 101);
            this.grpSpeed.Margin = new System.Windows.Forms.Padding(5);
            this.grpSpeed.Name = "grpSpeed";
            this.grpSpeed.Padding = new System.Windows.Forms.Padding(5);
            this.grpSpeed.Size = new System.Drawing.Size(743, 91);
            this.grpSpeed.TabIndex = 6;
            this.grpSpeed.TabStop = false;
            this.grpSpeed.Text = "Throttle";
            // 
            // btnSpeedINTV
            // 
            this.btnSpeedINTV.Location = new System.Drawing.Point(608, 8);
            this.btnSpeedINTV.Margin = new System.Windows.Forms.Padding(5);
            this.btnSpeedINTV.Name = "btnSpeedINTV";
            this.btnSpeedINTV.Size = new System.Drawing.Size(125, 38);
            this.btnSpeedINTV.TabIndex = 51;
            this.btnSpeedINTV.Text = "Speed INTV";
            this.btnSpeedINTV.UseVisualStyleBackColor = true;
            this.btnSpeedINTV.Click += new System.EventHandler(this.btnSpeedINTV_Click);
            // 
            // btnSpeed
            // 
            this.btnSpeed.Location = new System.Drawing.Point(473, 8);
            this.btnSpeed.Margin = new System.Windows.Forms.Padding(5);
            this.btnSpeed.Name = "btnSpeed";
            this.btnSpeed.Size = new System.Drawing.Size(125, 38);
            this.btnSpeed.TabIndex = 50;
            this.btnSpeed.Text = "Spd";
            this.btnSpeed.UseVisualStyleBackColor = true;
            this.btnSpeed.Click += new System.EventHandler(this.btnSpeed_Click);
            // 
            // txtSpeed
            // 
            this.txtSpeed.AccessibleName = "Speed";
            this.txtSpeed.Location = new System.Drawing.Point(297, 8);
            this.txtSpeed.Margin = new System.Windows.Forms.Padding(5);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.ReadOnly = true;
            this.txtSpeed.Size = new System.Drawing.Size(164, 40);
            this.txtSpeed.TabIndex = 31;
            this.txtSpeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSpeed_KeyDown);
            // 
            // btnN1
            // 
            this.btnN1.AccessibleName = "N1";
            this.btnN1.Location = new System.Drawing.Point(162, 8);
            this.btnN1.Margin = new System.Windows.Forms.Padding(5);
            this.btnN1.Name = "btnN1";
            this.btnN1.Size = new System.Drawing.Size(125, 38);
            this.btnN1.TabIndex = 30;
            this.btnN1.Text = "N1 Switch";
            this.btnN1.UseVisualStyleBackColor = true;
            this.btnN1.Click += new System.EventHandler(this.btnN1_Click);
            // 
            // chkATArm
            // 
            this.chkATArm.AutoSize = true;
            this.chkATArm.Location = new System.Drawing.Point(8, 8);
            this.chkATArm.Margin = new System.Windows.Forms.Padding(5);
            this.chkATArm.Name = "chkATArm";
            this.chkATArm.Size = new System.Drawing.Size(125, 37);
            this.chkATArm.TabIndex = 9;
            this.chkATArm.Text = "AT Arm";
            this.chkATArm.UseVisualStyleBackColor = true;
            this.chkATArm.CheckedChanged += new System.EventHandler(this.chkATArm_CheckedChanged);
            // 
            // chkFlightDirectorRight
            // 
            this.chkFlightDirectorRight.AutoSize = true;
            this.chkFlightDirectorRight.Location = new System.Drawing.Point(825, 8);
            this.chkFlightDirectorRight.Margin = new System.Windows.Forms.Padding(5);
            this.chkFlightDirectorRight.Name = "chkFlightDirectorRight";
            this.chkFlightDirectorRight.Size = new System.Drawing.Size(146, 37);
            this.chkFlightDirectorRight.TabIndex = 5;
            this.chkFlightDirectorRight.Text = "Right FD";
            this.chkFlightDirectorRight.UseVisualStyleBackColor = true;
            this.chkFlightDirectorRight.CheckedChanged += new System.EventHandler(this.chkFlightDirectorRight_CheckedChanged);
            // 
            // grpAltitude
            // 
            this.grpAltitude.AutoSize = true;
            this.grpAltitude.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpAltitude.Controls.Add(this.btnVspeed);
            this.grpAltitude.Controls.Add(this.btnVNav);
            this.grpAltitude.Controls.Add(this.lblVspeed);
            this.grpAltitude.Controls.Add(this.lblAltitude);
            this.grpAltitude.Controls.Add(this.txtVSpd);
            this.grpAltitude.Controls.Add(this.btnAltHold);
            this.grpAltitude.Controls.Add(this.btnAltIntv);
            this.grpAltitude.Controls.Add(this.btnLvlChg);
            this.grpAltitude.Controls.Add(this.txtAltitude);
            this.grpAltitude.Location = new System.Drawing.Point(8, 200);
            this.grpAltitude.Margin = new System.Windows.Forms.Padding(5);
            this.grpAltitude.Name = "grpAltitude";
            this.grpAltitude.Padding = new System.Windows.Forms.Padding(5);
            this.grpAltitude.Size = new System.Drawing.Size(1143, 91);
            this.grpAltitude.TabIndex = 7;
            this.grpAltitude.TabStop = false;
            this.grpAltitude.Text = "Altitude";
            // 
            // btnVspeed
            // 
            this.btnVspeed.Location = new System.Drawing.Point(875, 8);
            this.btnVspeed.Margin = new System.Windows.Forms.Padding(5);
            this.btnVspeed.Name = "btnVspeed";
            this.btnVspeed.Size = new System.Drawing.Size(125, 38);
            this.btnVspeed.TabIndex = 7;
            this.btnVspeed.Text = "VS";
            this.btnVspeed.UseVisualStyleBackColor = true;
            this.btnVspeed.Click += new System.EventHandler(this.btnVs_Click);
            // 
            // btnVNav
            // 
            this.btnVNav.AccessibleName = "V Nav";
            this.btnVNav.Location = new System.Drawing.Point(1008, 8);
            this.btnVNav.Margin = new System.Windows.Forms.Padding(5);
            this.btnVNav.Name = "btnVNav";
            this.btnVNav.Size = new System.Drawing.Size(125, 38);
            this.btnVNav.TabIndex = 8;
            this.btnVNav.Text = "V Nav";
            this.btnVNav.UseVisualStyleBackColor = true;
            this.btnVNav.Click += new System.EventHandler(this.btnVNav_Click);
            // 
            // lblVspeed
            // 
            this.lblVspeed.AutoSize = true;
            this.lblVspeed.Location = new System.Drawing.Point(575, 8);
            this.lblVspeed.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVspeed.Name = "lblVspeed";
            this.lblVspeed.Size = new System.Drawing.Size(109, 33);
            this.lblVspeed.TabIndex = 5;
            this.lblVspeed.Text = "V Speed";
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Location = new System.Drawing.Point(8, 8);
            this.lblAltitude.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(106, 33);
            this.lblAltitude.TabIndex = 0;
            this.lblAltitude.Text = "Altitude";
            // 
            // txtVSpd
            // 
            this.txtVSpd.AccessibleName = "Vertical Speed";
            this.txtVSpd.Location = new System.Drawing.Point(702, 8);
            this.txtVSpd.Margin = new System.Windows.Forms.Padding(5);
            this.txtVSpd.Name = "txtVSpd";
            this.txtVSpd.ReadOnly = true;
            this.txtVSpd.Size = new System.Drawing.Size(164, 40);
            this.txtVSpd.TabIndex = 6;
            this.txtVSpd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVSpd_KeyDown);
            // 
            // btnAltHold
            // 
            this.btnAltHold.Location = new System.Drawing.Point(443, 8);
            this.btnAltHold.Margin = new System.Windows.Forms.Padding(5);
            this.btnAltHold.Name = "btnAltHold";
            this.btnAltHold.Size = new System.Drawing.Size(125, 38);
            this.btnAltHold.TabIndex = 4;
            this.btnAltHold.Text = "Alt Hold";
            this.btnAltHold.UseVisualStyleBackColor = true;
            this.btnAltHold.Click += new System.EventHandler(this.btnAltHold_Click);
            // 
            // btnAltIntv
            // 
            this.btnAltIntv.Location = new System.Drawing.Point(313, 8);
            this.btnAltIntv.Margin = new System.Windows.Forms.Padding(5);
            this.btnAltIntv.Name = "btnAltIntv";
            this.btnAltIntv.Size = new System.Drawing.Size(125, 38);
            this.btnAltIntv.TabIndex = 3;
            this.btnAltIntv.Text = "Alt INTV";
            this.btnAltIntv.UseVisualStyleBackColor = true;
            this.btnAltIntv.Click += new System.EventHandler(this.btnAltIntv_Click);
            // 
            // btnLvlChg
            // 
            this.btnLvlChg.Location = new System.Drawing.Point(183, 8);
            this.btnLvlChg.Margin = new System.Windows.Forms.Padding(5);
            this.btnLvlChg.Name = "btnLvlChg";
            this.btnLvlChg.Size = new System.Drawing.Size(125, 38);
            this.btnLvlChg.TabIndex = 2;
            this.btnLvlChg.Text = "Lvl Chg";
            this.btnLvlChg.UseVisualStyleBackColor = true;
            this.btnLvlChg.Click += new System.EventHandler(this.btnLvlChg_Click);
            // 
            // txtAltitude
            // 
            this.txtAltitude.AccessibleName = "Altitude";
            this.txtAltitude.Location = new System.Drawing.Point(8, 8);
            this.txtAltitude.Margin = new System.Windows.Forms.Padding(5);
            this.txtAltitude.Name = "txtAltitude";
            this.txtAltitude.Size = new System.Drawing.Size(164, 40);
            this.txtAltitude.TabIndex = 1;
            this.txtAltitude.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAltitude_KeyDown);
            // 
            // grpHeading
            // 
            this.grpHeading.AutoSize = true;
            this.grpHeading.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpHeading.Controls.Add(this.btnLNav);
            this.grpHeading.Controls.Add(this.btnHdgSel);
            this.grpHeading.Controls.Add(this.txtHeading);
            this.grpHeading.Location = new System.Drawing.Point(8, 300);
            this.grpHeading.Margin = new System.Windows.Forms.Padding(5);
            this.grpHeading.Name = "grpHeading";
            this.grpHeading.Padding = new System.Windows.Forms.Padding(5);
            this.grpHeading.Size = new System.Drawing.Size(443, 91);
            this.grpHeading.TabIndex = 8;
            this.grpHeading.TabStop = false;
            this.grpHeading.Text = "Heading";
            // 
            // btnLNav
            // 
            this.btnLNav.Location = new System.Drawing.Point(308, 8);
            this.btnLNav.Margin = new System.Windows.Forms.Padding(5);
            this.btnLNav.Name = "btnLNav";
            this.btnLNav.Size = new System.Drawing.Size(125, 38);
            this.btnLNav.TabIndex = 42;
            this.btnLNav.Text = "L-Nav";
            this.btnLNav.UseVisualStyleBackColor = true;
            this.btnLNav.Click += new System.EventHandler(this.btnLNav_Click);
            // 
            // btnHdgSel
            // 
            this.btnHdgSel.Location = new System.Drawing.Point(180, 8);
            this.btnHdgSel.Margin = new System.Windows.Forms.Padding(5);
            this.btnHdgSel.Name = "btnHdgSel";
            this.btnHdgSel.Size = new System.Drawing.Size(125, 38);
            this.btnHdgSel.TabIndex = 41;
            this.btnHdgSel.Text = "Heading select";
            this.btnHdgSel.UseVisualStyleBackColor = true;
            this.btnHdgSel.Click += new System.EventHandler(this.btnHdgSel_Click);
            // 
            // txtHeading
            // 
            this.txtHeading.AccessibleName = "Heading";
            this.txtHeading.Location = new System.Drawing.Point(8, 8);
            this.txtHeading.Margin = new System.Windows.Forms.Padding(5);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.ReadOnly = true;
            this.txtHeading.Size = new System.Drawing.Size(164, 40);
            this.txtHeading.TabIndex = 40;
            this.txtHeading.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHeading_KeyDown);
            // 
            // grpModes
            // 
            this.grpModes.AutoSize = true;
            this.grpModes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpModes.Controls.Add(this.btnCWSB);
            this.grpModes.Controls.Add(this.btnCWSA);
            this.grpModes.Controls.Add(this.btnCmdB);
            this.grpModes.Controls.Add(this.btnCmdA);
            this.grpModes.Controls.Add(this.btnApproach);
            this.grpModes.Controls.Add(this.btnVorLock);
            this.grpModes.Location = new System.Drawing.Point(8, 400);
            this.grpModes.Name = "grpModes";
            this.grpModes.Size = new System.Drawing.Size(933, 87);
            this.grpModes.TabIndex = 48;
            this.grpModes.TabStop = false;
            this.grpModes.Text = "Autopilot modes";
            // 
            // btnCWSB
            // 
            this.btnCWSB.Location = new System.Drawing.Point(800, 7);
            this.btnCWSB.Margin = new System.Windows.Forms.Padding(5);
            this.btnCWSB.Name = "btnCWSB";
            this.btnCWSB.Size = new System.Drawing.Size(125, 38);
            this.btnCWSB.TabIndex = 48;
            this.btnCWSB.Text = "CWS B";
            this.btnCWSB.UseVisualStyleBackColor = true;
            this.btnCWSB.Click += new System.EventHandler(this.btnCWSB_Click);
            // 
            // btnCWSA
            // 
            this.btnCWSA.Location = new System.Drawing.Point(600, 8);
            this.btnCWSA.Margin = new System.Windows.Forms.Padding(5);
            this.btnCWSA.Name = "btnCWSA";
            this.btnCWSA.Size = new System.Drawing.Size(125, 38);
            this.btnCWSA.TabIndex = 47;
            this.btnCWSA.Text = "CWS A";
            this.btnCWSA.UseVisualStyleBackColor = true;
            this.btnCWSA.Click += new System.EventHandler(this.btnCWSA_Click);
            // 
            // btnCmdB
            // 
            this.btnCmdB.Location = new System.Drawing.Point(401, 8);
            this.btnCmdB.Margin = new System.Windows.Forms.Padding(5);
            this.btnCmdB.Name = "btnCmdB";
            this.btnCmdB.Size = new System.Drawing.Size(125, 38);
            this.btnCmdB.TabIndex = 46;
            this.btnCmdB.Text = "Cmd B";
            this.btnCmdB.UseVisualStyleBackColor = true;
            this.btnCmdB.Click += new System.EventHandler(this.btnCmdB_Click);
            // 
            // btnCmdA
            // 
            this.btnCmdA.Location = new System.Drawing.Point(270, 8);
            this.btnCmdA.Margin = new System.Windows.Forms.Padding(5);
            this.btnCmdA.Name = "btnCmdA";
            this.btnCmdA.Size = new System.Drawing.Size(125, 38);
            this.btnCmdA.TabIndex = 45;
            this.btnCmdA.Text = "CMD A";
            this.btnCmdA.UseVisualStyleBackColor = true;
            this.btnCmdA.Click += new System.EventHandler(this.btnCmdA_Click);
            // 
            // btnApproach
            // 
            this.btnApproach.Location = new System.Drawing.Point(140, 8);
            this.btnApproach.Margin = new System.Windows.Forms.Padding(5);
            this.btnApproach.Name = "btnApproach";
            this.btnApproach.Size = new System.Drawing.Size(125, 38);
            this.btnApproach.TabIndex = 44;
            this.btnApproach.Text = "Approach";
            this.btnApproach.UseVisualStyleBackColor = true;
            this.btnApproach.Click += new System.EventHandler(this.btnApproach_Click);
            // 
            // btnVorLock
            // 
            this.btnVorLock.Location = new System.Drawing.Point(8, 8);
            this.btnVorLock.Margin = new System.Windows.Forms.Padding(5);
            this.btnVorLock.Name = "btnVorLock";
            this.btnVorLock.Size = new System.Drawing.Size(125, 38);
            this.btnVorLock.TabIndex = 43;
            this.btnVorLock.Text = "VOR Lock";
            this.btnVorLock.UseVisualStyleBackColor = true;
            this.btnVorLock.Click += new System.EventHandler(this.btnVorLock_Click);
            // 
            // ctlMCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.grpModes);
            this.Controls.Add(this.grpHeading);
            this.Controls.Add(this.grpAltitude);
            this.Controls.Add(this.grpSpeed);
            this.Controls.Add(this.grpCourse);
            this.Controls.Add(this.chkFlightDirectorRight);
            this.Controls.Add(this.chkFlightDirectorLeft);
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ctlMCP";
            this.Size = new System.Drawing.Size(1156, 490);
            this.Load += new System.EventHandler(this.ctlMCP_Load);
            this.grpCourse.ResumeLayout(false);
            this.grpCourse.PerformLayout();
            this.grpSpeed.ResumeLayout(false);
            this.grpSpeed.PerformLayout();
            this.grpAltitude.ResumeLayout(false);
            this.grpAltitude.PerformLayout();
            this.grpHeading.ResumeLayout(false);
            this.grpHeading.PerformLayout();
            this.grpModes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrMCP;
        private System.Windows.Forms.CheckBox chkFlightDirectorLeft;
        private System.Windows.Forms.GroupBox grpCourse;
        private System.Windows.Forms.TextBox txtCourseR;
        private System.Windows.Forms.Label lblCourseR;
        private System.Windows.Forms.TextBox txtCourseL;
        private System.Windows.Forms.Label lblCourseL;
        private System.Windows.Forms.GroupBox grpSpeed;
        private System.Windows.Forms.Button btnSpeedINTV;
        private System.Windows.Forms.Button btnSpeed;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Button btnN1;
        private System.Windows.Forms.CheckBox chkATArm;
        private System.Windows.Forms.CheckBox chkFlightDirectorRight;
        private System.Windows.Forms.GroupBox grpAltitude;
        private System.Windows.Forms.Button btnAltIntv;
        private System.Windows.Forms.Button btnLvlChg;
        private System.Windows.Forms.TextBox txtAltitude;
        private System.Windows.Forms.Button btnAltHold;
        private System.Windows.Forms.Label lblVspeed;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.TextBox txtVSpd;
        private System.Windows.Forms.Button btnVspeed;
        private System.Windows.Forms.Button btnVNav;
        private System.Windows.Forms.GroupBox grpHeading;
        private System.Windows.Forms.Button btnLNav;
        private System.Windows.Forms.Button btnHdgSel;
        private System.Windows.Forms.TextBox txtHeading;
        private System.Windows.Forms.GroupBox grpModes;
        private System.Windows.Forms.Button btnCWSB;
        private System.Windows.Forms.Button btnCWSA;
        private System.Windows.Forms.Button btnCmdB;
        private System.Windows.Forms.Button btnCmdA;
        private System.Windows.Forms.Button btnApproach;
        private System.Windows.Forms.Button btnVorLock;
    }
}
