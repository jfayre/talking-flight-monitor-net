namespace tfm
{
    partial class ctlAirSystems
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
            this.tmrAir = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.grpPackLeft = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radPackLeftOff = new System.Windows.Forms.RadioButton();
            this.radPackLeftAuto = new System.Windows.Forms.RadioButton();
            this.radPackLeftHigh = new System.Windows.Forms.RadioButton();
            this.grpPackRight = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.radPackRightOff = new System.Windows.Forms.RadioButton();
            this.radPackRightAuto = new System.Windows.Forms.RadioButton();
            this.radPackRightHigh = new System.Windows.Forms.RadioButton();
            this.chkTrimAir = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.grpRecircFan = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkRecircLeft = new System.Windows.Forms.CheckBox();
            this.chkRecircRight = new System.Windows.Forms.CheckBox();
            this.grpAirBleeds = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkAPUBleed = new System.Windows.Forms.CheckBox();
            this.chkEng1Bleed = new System.Windows.Forms.CheckBox();
            this.chkEng2Bleed = new System.Windows.Forms.CheckBox();
            this.lvLights = new System.Windows.Forms.ListView();
            this.colLight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1.SuspendLayout();
            this.grpPackLeft.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.grpPackRight.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.grpRecircFan.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.grpAirBleeds.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrAir
            // 
            this.tmrAir.Interval = 1000;
            this.tmrAir.Tick += new System.EventHandler(this.tmrAir_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.grpPackLeft);
            this.flowLayoutPanel1.Controls.Add(this.grpPackRight);
            this.flowLayoutPanel1.Controls.Add(this.chkTrimAir);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(821, 175);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // grpPackLeft
            // 
            this.grpPackLeft.Controls.Add(this.flowLayoutPanel2);
            this.grpPackLeft.Location = new System.Drawing.Point(5, 5);
            this.grpPackLeft.Margin = new System.Windows.Forms.Padding(5);
            this.grpPackLeft.Name = "grpPackLeft";
            this.grpPackLeft.Padding = new System.Windows.Forms.Padding(5);
            this.grpPackLeft.Size = new System.Drawing.Size(333, 165);
            this.grpPackLeft.TabIndex = 0;
            this.grpPackLeft.TabStop = false;
            this.grpPackLeft.Text = "Left Pack";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.radPackLeftOff);
            this.flowLayoutPanel2.Controls.Add(this.radPackLeftAuto);
            this.flowLayoutPanel2.Controls.Add(this.radPackLeftHigh);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(333, 165);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // radPackLeftOff
            // 
            this.radPackLeftOff.AutoSize = true;
            this.radPackLeftOff.Location = new System.Drawing.Point(5, 5);
            this.radPackLeftOff.Margin = new System.Windows.Forms.Padding(5);
            this.radPackLeftOff.Name = "radPackLeftOff";
            this.radPackLeftOff.Size = new System.Drawing.Size(77, 37);
            this.radPackLeftOff.TabIndex = 0;
            this.radPackLeftOff.TabStop = true;
            this.radPackLeftOff.Text = "Off";
            this.radPackLeftOff.UseVisualStyleBackColor = true;
            this.radPackLeftOff.CheckedChanged += new System.EventHandler(this.radPacLeft_CheckedChanged);
            // 
            // radPackLeftAuto
            // 
            this.radPackLeftAuto.AutoSize = true;
            this.radPackLeftAuto.Location = new System.Drawing.Point(92, 5);
            this.radPackLeftAuto.Margin = new System.Windows.Forms.Padding(5);
            this.radPackLeftAuto.Name = "radPackLeftAuto";
            this.radPackLeftAuto.Size = new System.Drawing.Size(95, 37);
            this.radPackLeftAuto.TabIndex = 1;
            this.radPackLeftAuto.TabStop = true;
            this.radPackLeftAuto.Text = "Auto";
            this.radPackLeftAuto.UseVisualStyleBackColor = true;
            this.radPackLeftAuto.CheckedChanged += new System.EventHandler(this.radPacLeft_CheckedChanged);
            // 
            // radPackLeftHigh
            // 
            this.radPackLeftHigh.AutoSize = true;
            this.radPackLeftHigh.Location = new System.Drawing.Point(197, 5);
            this.radPackLeftHigh.Margin = new System.Windows.Forms.Padding(5);
            this.radPackLeftHigh.Name = "radPackLeftHigh";
            this.radPackLeftHigh.Size = new System.Drawing.Size(94, 37);
            this.radPackLeftHigh.TabIndex = 2;
            this.radPackLeftHigh.TabStop = true;
            this.radPackLeftHigh.Text = "High";
            this.radPackLeftHigh.UseVisualStyleBackColor = true;
            this.radPackLeftHigh.CheckedChanged += new System.EventHandler(this.radPacLeft_CheckedChanged);
            // 
            // grpPackRight
            // 
            this.grpPackRight.Controls.Add(this.flowLayoutPanel3);
            this.grpPackRight.Location = new System.Drawing.Point(348, 5);
            this.grpPackRight.Margin = new System.Windows.Forms.Padding(5);
            this.grpPackRight.Name = "grpPackRight";
            this.grpPackRight.Padding = new System.Windows.Forms.Padding(5);
            this.grpPackRight.Size = new System.Drawing.Size(333, 165);
            this.grpPackRight.TabIndex = 1;
            this.grpPackRight.TabStop = false;
            this.grpPackRight.Text = "Right Pack";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.radPackRightOff);
            this.flowLayoutPanel3.Controls.Add(this.radPackRightAuto);
            this.flowLayoutPanel3.Controls.Add(this.radPackRightHigh);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(333, 165);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // radPackRightOff
            // 
            this.radPackRightOff.AutoSize = true;
            this.radPackRightOff.Location = new System.Drawing.Point(5, 5);
            this.radPackRightOff.Margin = new System.Windows.Forms.Padding(5);
            this.radPackRightOff.Name = "radPackRightOff";
            this.radPackRightOff.Size = new System.Drawing.Size(77, 37);
            this.radPackRightOff.TabIndex = 0;
            this.radPackRightOff.TabStop = true;
            this.radPackRightOff.Text = "Off";
            this.radPackRightOff.UseVisualStyleBackColor = true;
            this.radPackRightOff.CheckedChanged += new System.EventHandler(this.radPacRight_CheckedChanged);
            // 
            // radPackRightAuto
            // 
            this.radPackRightAuto.AutoSize = true;
            this.radPackRightAuto.Location = new System.Drawing.Point(92, 5);
            this.radPackRightAuto.Margin = new System.Windows.Forms.Padding(5);
            this.radPackRightAuto.Name = "radPackRightAuto";
            this.radPackRightAuto.Size = new System.Drawing.Size(95, 37);
            this.radPackRightAuto.TabIndex = 1;
            this.radPackRightAuto.TabStop = true;
            this.radPackRightAuto.Text = "Auto";
            this.radPackRightAuto.UseVisualStyleBackColor = true;
            this.radPackRightAuto.CheckedChanged += new System.EventHandler(this.radPacRight_CheckedChanged);
            // 
            // radPackRightHigh
            // 
            this.radPackRightHigh.AutoSize = true;
            this.radPackRightHigh.Location = new System.Drawing.Point(197, 5);
            this.radPackRightHigh.Margin = new System.Windows.Forms.Padding(5);
            this.radPackRightHigh.Name = "radPackRightHigh";
            this.radPackRightHigh.Size = new System.Drawing.Size(94, 37);
            this.radPackRightHigh.TabIndex = 2;
            this.radPackRightHigh.TabStop = true;
            this.radPackRightHigh.Text = "High";
            this.radPackRightHigh.UseVisualStyleBackColor = true;
            this.radPackRightHigh.CheckedChanged += new System.EventHandler(this.radPacRight_CheckedChanged);
            // 
            // chkTrimAir
            // 
            this.chkTrimAir.AutoSize = true;
            this.chkTrimAir.Location = new System.Drawing.Point(689, 3);
            this.chkTrimAir.Name = "chkTrimAir";
            this.chkTrimAir.Size = new System.Drawing.Size(129, 37);
            this.chkTrimAir.TabIndex = 2;
            this.chkTrimAir.Text = "Trim air";
            this.chkTrimAir.UseVisualStyleBackColor = true;
            this.chkTrimAir.CheckedChanged += new System.EventHandler(this.chkTrimAir_CheckedChanged);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.grpRecircFan);
            this.flowLayoutPanel4.Controls.Add(this.grpAirBleeds);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(8, 190);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1052, 91);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // grpRecircFan
            // 
            this.grpRecircFan.AutoSize = true;
            this.grpRecircFan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpRecircFan.Controls.Add(this.flowLayoutPanel5);
            this.grpRecircFan.Location = new System.Drawing.Point(3, 3);
            this.grpRecircFan.Name = "grpRecircFan";
            this.grpRecircFan.Size = new System.Drawing.Size(432, 85);
            this.grpRecircFan.TabIndex = 6;
            this.grpRecircFan.TabStop = false;
            this.grpRecircFan.Text = "Recirculation fans";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.Controls.Add(this.chkRecircLeft);
            this.flowLayoutPanel5.Controls.Add(this.chkRecircRight);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(423, 43);
            this.flowLayoutPanel5.TabIndex = 6;
            // 
            // chkRecircLeft
            // 
            this.chkRecircLeft.AutoSize = true;
            this.chkRecircLeft.Location = new System.Drawing.Point(3, 3);
            this.chkRecircLeft.Name = "chkRecircLeft";
            this.chkRecircLeft.Size = new System.Drawing.Size(197, 37);
            this.chkRecircLeft.TabIndex = 5;
            this.chkRecircLeft.Text = "Left recirc fan";
            this.chkRecircLeft.UseVisualStyleBackColor = true;
            this.chkRecircLeft.CheckedChanged += new System.EventHandler(this.chkRecircLeft_CheckedChanged);
            // 
            // chkRecircRight
            // 
            this.chkRecircRight.AutoSize = true;
            this.chkRecircRight.Location = new System.Drawing.Point(206, 3);
            this.chkRecircRight.Name = "chkRecircRight";
            this.chkRecircRight.Size = new System.Drawing.Size(214, 37);
            this.chkRecircRight.TabIndex = 6;
            this.chkRecircRight.Text = "Right recirc fan";
            this.chkRecircRight.UseVisualStyleBackColor = true;
            this.chkRecircRight.CheckedChanged += new System.EventHandler(this.chkRecircRight_CheckedChanged);
            // 
            // grpAirBleeds
            // 
            this.grpAirBleeds.AutoSize = true;
            this.grpAirBleeds.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpAirBleeds.Controls.Add(this.flowLayoutPanel6);
            this.grpAirBleeds.Location = new System.Drawing.Point(441, 3);
            this.grpAirBleeds.Name = "grpAirBleeds";
            this.grpAirBleeds.Size = new System.Drawing.Size(608, 85);
            this.grpAirBleeds.TabIndex = 7;
            this.grpAirBleeds.TabStop = false;
            this.grpAirBleeds.Text = "Bleed Air";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel6.Controls.Add(this.chkAPUBleed);
            this.flowLayoutPanel6.Controls.Add(this.chkEng1Bleed);
            this.flowLayoutPanel6.Controls.Add(this.chkEng2Bleed);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(599, 43);
            this.flowLayoutPanel6.TabIndex = 0;
            // 
            // chkAPUBleed
            // 
            this.chkAPUBleed.AutoSize = true;
            this.chkAPUBleed.Location = new System.Drawing.Point(3, 3);
            this.chkAPUBleed.Name = "chkAPUBleed";
            this.chkAPUBleed.Size = new System.Drawing.Size(167, 37);
            this.chkAPUBleed.TabIndex = 0;
            this.chkAPUBleed.Text = "APU Bleed";
            this.chkAPUBleed.UseVisualStyleBackColor = true;
            this.chkAPUBleed.CheckedChanged += new System.EventHandler(this.chkAPUBleed_CheckedChanged);
            // 
            // chkEng1Bleed
            // 
            this.chkEng1Bleed.AutoSize = true;
            this.chkEng1Bleed.Location = new System.Drawing.Point(176, 3);
            this.chkEng1Bleed.Name = "chkEng1Bleed";
            this.chkEng1Bleed.Size = new System.Drawing.Size(207, 37);
            this.chkEng1Bleed.TabIndex = 1;
            this.chkEng1Bleed.Text = "Engine 1 bleed";
            this.chkEng1Bleed.UseVisualStyleBackColor = true;
            this.chkEng1Bleed.CheckedChanged += new System.EventHandler(this.chkEng1Bleed_CheckedChanged);
            // 
            // chkEng2Bleed
            // 
            this.chkEng2Bleed.AutoSize = true;
            this.chkEng2Bleed.Location = new System.Drawing.Point(389, 3);
            this.chkEng2Bleed.Name = "chkEng2Bleed";
            this.chkEng2Bleed.Size = new System.Drawing.Size(207, 37);
            this.chkEng2Bleed.TabIndex = 2;
            this.chkEng2Bleed.Text = "Engine 2 bleed";
            this.chkEng2Bleed.UseVisualStyleBackColor = true;
            this.chkEng2Bleed.CheckedChanged += new System.EventHandler(this.chkEng2Bleed_CheckedChanged);
            // 
            // lvLights
            // 
            this.lvLights.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLight,
            this.colState});
            this.lvLights.HideSelection = false;
            this.lvLights.Location = new System.Drawing.Point(8, 289);
            this.lvLights.MultiSelect = false;
            this.lvLights.Name = "lvLights";
            this.lvLights.ShowGroups = false;
            this.lvLights.Size = new System.Drawing.Size(121, 97);
            this.lvLights.TabIndex = 9;
            this.lvLights.UseCompatibleStateImageBehavior = false;
            this.lvLights.View = System.Windows.Forms.View.Details;
            // 
            // colLight
            // 
            this.colLight.Text = "Light";
            // 
            // colState
            // 
            this.colState.Text = "State";
            // 
            // ctlAirSystems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.lvLights);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ctlAirSystems";
            this.Size = new System.Drawing.Size(1063, 389);
            this.Load += new System.EventHandler(this.ctlAirSystems_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.grpPackLeft.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.grpPackRight.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.grpRecircFan.ResumeLayout(false);
            this.grpRecircFan.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.grpAirBleeds.ResumeLayout(false);
            this.grpAirBleeds.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrAir;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox grpPackLeft;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton radPackLeftOff;
        private System.Windows.Forms.RadioButton radPackLeftAuto;
        private System.Windows.Forms.RadioButton radPackLeftHigh;
        private System.Windows.Forms.GroupBox grpPackRight;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.RadioButton radPackRightOff;
        private System.Windows.Forms.RadioButton radPackRightAuto;
        private System.Windows.Forms.RadioButton radPackRightHigh;
        private System.Windows.Forms.CheckBox chkTrimAir;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.GroupBox grpRecircFan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.CheckBox chkRecircLeft;
        private System.Windows.Forms.CheckBox chkRecircRight;
        private System.Windows.Forms.GroupBox grpAirBleeds;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.CheckBox chkAPUBleed;
        private System.Windows.Forms.CheckBox chkEng1Bleed;
        private System.Windows.Forms.CheckBox chkEng2Bleed;
        private System.Windows.Forms.ListView lvLights;
        private System.Windows.Forms.ColumnHeader colLight;
        private System.Windows.Forms.ColumnHeader colState;
    }
}
