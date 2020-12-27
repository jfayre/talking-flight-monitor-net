namespace tfm
{
    partial class ctlEngines
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
            this.tmrEngines = new System.Windows.Forms.Timer(this.components);
            this.grpEng1Start = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radEng1Grd = new System.Windows.Forms.RadioButton();
            this.radEng1Auto = new System.Windows.Forms.RadioButton();
            this.radEng1Cont = new System.Windows.Forms.RadioButton();
            this.radEng1Flt = new System.Windows.Forms.RadioButton();
            this.grpEng1Fuel = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radEng1CutOff = new System.Windows.Forms.RadioButton();
            this.radEng1Idle = new System.Windows.Forms.RadioButton();
            this.grpEng2Start = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.radEng2Grd = new System.Windows.Forms.RadioButton();
            this.radEng2Auto = new System.Windows.Forms.RadioButton();
            this.radEng2Cont = new System.Windows.Forms.RadioButton();
            this.radEng2Flt = new System.Windows.Forms.RadioButton();
            this.grpEng2Fuel = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.radEng2CutOff = new System.Windows.Forms.RadioButton();
            this.radEng2Idle = new System.Windows.Forms.RadioButton();
            this.grpEng1Start.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.grpEng1Fuel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.grpEng2Start.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.grpEng2Fuel.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrEngines
            // 
            this.tmrEngines.Interval = 500;
            this.tmrEngines.Tick += new System.EventHandler(this.tmrEngines_Tick);
            // 
            // grpEng1Start
            // 
            this.grpEng1Start.AutoSize = true;
            this.grpEng1Start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpEng1Start.Controls.Add(this.flowLayoutPanel1);
            this.grpEng1Start.Location = new System.Drawing.Point(5, 5);
            this.grpEng1Start.Name = "grpEng1Start";
            this.grpEng1Start.Size = new System.Drawing.Size(209, 147);
            this.grpEng1Start.TabIndex = 0;
            this.grpEng1Start.TabStop = false;
            this.grpEng1Start.Text = "groupBox1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radEng1Grd);
            this.flowLayoutPanel1.Controls.Add(this.radEng1Auto);
            this.flowLayoutPanel1.Controls.Add(this.radEng1Cont);
            this.flowLayoutPanel1.Controls.Add(this.radEng1Flt);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // radEng1Grd
            // 
            this.radEng1Grd.AutoSize = true;
            this.radEng1Grd.Location = new System.Drawing.Point(3, 3);
            this.radEng1Grd.Name = "radEng1Grd";
            this.radEng1Grd.Size = new System.Drawing.Size(61, 24);
            this.radEng1Grd.TabIndex = 0;
            this.radEng1Grd.TabStop = true;
            this.radEng1Grd.Text = "Grd";
            this.radEng1Grd.UseVisualStyleBackColor = true;
            this.radEng1Grd.CheckedChanged += new System.EventHandler(this.radEng1Start_CheckedChanged);
            // 
            // radEng1Auto
            // 
            this.radEng1Auto.AutoSize = true;
            this.radEng1Auto.Location = new System.Drawing.Point(70, 3);
            this.radEng1Auto.Name = "radEng1Auto";
            this.radEng1Auto.Size = new System.Drawing.Size(68, 24);
            this.radEng1Auto.TabIndex = 1;
            this.radEng1Auto.TabStop = true;
            this.radEng1Auto.Text = "Auto";
            this.radEng1Auto.UseVisualStyleBackColor = true;
            this.radEng1Auto.CheckedChanged += new System.EventHandler(this.radEng1Start_CheckedChanged);
            // 
            // radEng1Cont
            // 
            this.radEng1Cont.AutoSize = true;
            this.radEng1Cont.Location = new System.Drawing.Point(3, 33);
            this.radEng1Cont.Name = "radEng1Cont";
            this.radEng1Cont.Size = new System.Drawing.Size(68, 24);
            this.radEng1Cont.TabIndex = 2;
            this.radEng1Cont.TabStop = true;
            this.radEng1Cont.Text = "Cont";
            this.radEng1Cont.UseVisualStyleBackColor = true;
            this.radEng1Cont.CheckedChanged += new System.EventHandler(this.radEng1Start_CheckedChanged);
            // 
            // radEng1Flt
            // 
            this.radEng1Flt.AutoSize = true;
            this.radEng1Flt.Location = new System.Drawing.Point(77, 33);
            this.radEng1Flt.Name = "radEng1Flt";
            this.radEng1Flt.Size = new System.Drawing.Size(52, 24);
            this.radEng1Flt.TabIndex = 3;
            this.radEng1Flt.TabStop = true;
            this.radEng1Flt.Text = "Flt";
            this.radEng1Flt.UseVisualStyleBackColor = true;
            this.radEng1Flt.CheckedChanged += new System.EventHandler(this.radEng1Start_CheckedChanged);
            // 
            // grpEng1Fuel
            // 
            this.grpEng1Fuel.AutoSize = true;
            this.grpEng1Fuel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpEng1Fuel.Controls.Add(this.flowLayoutPanel2);
            this.grpEng1Fuel.Location = new System.Drawing.Point(220, 5);
            this.grpEng1Fuel.Name = "grpEng1Fuel";
            this.grpEng1Fuel.Size = new System.Drawing.Size(209, 147);
            this.grpEng1Fuel.TabIndex = 1;
            this.grpEng1Fuel.TabStop = false;
            this.grpEng1Fuel.Text = "Engine 1 fuel";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.radEng1CutOff);
            this.flowLayoutPanel2.Controls.Add(this.radEng1Idle);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // radEng1CutOff
            // 
            this.radEng1CutOff.AutoSize = true;
            this.radEng1CutOff.Location = new System.Drawing.Point(3, 3);
            this.radEng1CutOff.Name = "radEng1CutOff";
            this.radEng1CutOff.Size = new System.Drawing.Size(82, 24);
            this.radEng1CutOff.TabIndex = 0;
            this.radEng1CutOff.TabStop = true;
            this.radEng1CutOff.Text = "Cut off";
            this.radEng1CutOff.UseVisualStyleBackColor = true;
            this.radEng1CutOff.CheckedChanged += new System.EventHandler(this.radEng1Fuel_CheckedChanged);
            // 
            // radEng1Idle
            // 
            this.radEng1Idle.AutoSize = true;
            this.radEng1Idle.Location = new System.Drawing.Point(91, 3);
            this.radEng1Idle.Name = "radEng1Idle";
            this.radEng1Idle.Size = new System.Drawing.Size(60, 24);
            this.radEng1Idle.TabIndex = 1;
            this.radEng1Idle.TabStop = true;
            this.radEng1Idle.Text = "Idle";
            this.radEng1Idle.UseVisualStyleBackColor = true;
            this.radEng1Idle.CheckedChanged += new System.EventHandler(this.radEng1Fuel_CheckedChanged);
            // 
            // grpEng2Start
            // 
            this.grpEng2Start.AutoSize = true;
            this.grpEng2Start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpEng2Start.Controls.Add(this.flowLayoutPanel3);
            this.grpEng2Start.Location = new System.Drawing.Point(5, 160);
            this.grpEng2Start.Name = "grpEng2Start";
            this.grpEng2Start.Size = new System.Drawing.Size(209, 147);
            this.grpEng2Start.TabIndex = 2;
            this.grpEng2Start.TabStop = false;
            this.grpEng2Start.Text = "Engine 2 start";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.radEng2Grd);
            this.flowLayoutPanel3.Controls.Add(this.radEng2Auto);
            this.flowLayoutPanel3.Controls.Add(this.radEng2Cont);
            this.flowLayoutPanel3.Controls.Add(this.radEng2Flt);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // radEng2Grd
            // 
            this.radEng2Grd.AutoSize = true;
            this.radEng2Grd.Location = new System.Drawing.Point(3, 3);
            this.radEng2Grd.Name = "radEng2Grd";
            this.radEng2Grd.Size = new System.Drawing.Size(61, 24);
            this.radEng2Grd.TabIndex = 0;
            this.radEng2Grd.TabStop = true;
            this.radEng2Grd.Text = "Grd";
            this.radEng2Grd.UseVisualStyleBackColor = true;
            this.radEng2Grd.CheckedChanged += new System.EventHandler(this.radEng2Start_CheckedChanged);
            // 
            // radEng2Auto
            // 
            this.radEng2Auto.AutoSize = true;
            this.radEng2Auto.Location = new System.Drawing.Point(70, 3);
            this.radEng2Auto.Name = "radEng2Auto";
            this.radEng2Auto.Size = new System.Drawing.Size(68, 24);
            this.radEng2Auto.TabIndex = 1;
            this.radEng2Auto.TabStop = true;
            this.radEng2Auto.Text = "Auto";
            this.radEng2Auto.UseVisualStyleBackColor = true;
            this.radEng2Auto.CheckedChanged += new System.EventHandler(this.radEng2Start_CheckedChanged);
            // 
            // radEng2Cont
            // 
            this.radEng2Cont.AutoSize = true;
            this.radEng2Cont.Location = new System.Drawing.Point(3, 33);
            this.radEng2Cont.Name = "radEng2Cont";
            this.radEng2Cont.Size = new System.Drawing.Size(68, 24);
            this.radEng2Cont.TabIndex = 2;
            this.radEng2Cont.TabStop = true;
            this.radEng2Cont.Text = "Cont";
            this.radEng2Cont.UseVisualStyleBackColor = true;
            this.radEng2Cont.CheckedChanged += new System.EventHandler(this.radEng2Start_CheckedChanged);
            // 
            // radEng2Flt
            // 
            this.radEng2Flt.AutoSize = true;
            this.radEng2Flt.Location = new System.Drawing.Point(77, 33);
            this.radEng2Flt.Name = "radEng2Flt";
            this.radEng2Flt.Size = new System.Drawing.Size(52, 24);
            this.radEng2Flt.TabIndex = 4;
            this.radEng2Flt.TabStop = true;
            this.radEng2Flt.Text = "Flt";
            this.radEng2Flt.UseVisualStyleBackColor = true;
            this.radEng2Flt.CheckedChanged += new System.EventHandler(this.radEng2Start_CheckedChanged);
            // 
            // grpEng2Fuel
            // 
            this.grpEng2Fuel.AutoSize = true;
            this.grpEng2Fuel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpEng2Fuel.Controls.Add(this.flowLayoutPanel4);
            this.grpEng2Fuel.Location = new System.Drawing.Point(220, 160);
            this.grpEng2Fuel.Name = "grpEng2Fuel";
            this.grpEng2Fuel.Size = new System.Drawing.Size(209, 147);
            this.grpEng2Fuel.TabIndex = 3;
            this.grpEng2Fuel.TabStop = false;
            this.grpEng2Fuel.Text = "Engine 1 fuel";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.radEng2CutOff);
            this.flowLayoutPanel4.Controls.Add(this.radEng2Idle);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // radEng2CutOff
            // 
            this.radEng2CutOff.AutoSize = true;
            this.radEng2CutOff.Location = new System.Drawing.Point(3, 3);
            this.radEng2CutOff.Name = "radEng2CutOff";
            this.radEng2CutOff.Size = new System.Drawing.Size(82, 24);
            this.radEng2CutOff.TabIndex = 0;
            this.radEng2CutOff.TabStop = true;
            this.radEng2CutOff.Text = "Cut off";
            this.radEng2CutOff.UseVisualStyleBackColor = true;
            this.radEng2CutOff.CheckedChanged += new System.EventHandler(this.radEng2Fuel_CheckedChanged);
            // 
            // radEng2Idle
            // 
            this.radEng2Idle.AutoSize = true;
            this.radEng2Idle.Location = new System.Drawing.Point(91, 3);
            this.radEng2Idle.Name = "radEng2Idle";
            this.radEng2Idle.Size = new System.Drawing.Size(60, 24);
            this.radEng2Idle.TabIndex = 1;
            this.radEng2Idle.TabStop = true;
            this.radEng2Idle.Text = "Idle";
            this.radEng2Idle.UseVisualStyleBackColor = true;
            this.radEng2Idle.CheckedChanged += new System.EventHandler(this.radEng2Fuel_CheckedChanged);
            // 
            // ctlEngines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.grpEng2Fuel);
            this.Controls.Add(this.grpEng2Start);
            this.Controls.Add(this.grpEng1Fuel);
            this.Controls.Add(this.grpEng1Start);
            this.Name = "ctlEngines";
            this.Size = new System.Drawing.Size(432, 310);
            this.Load += new System.EventHandler(this.ctlEngines_Load);
            this.grpEng1Start.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.grpEng1Fuel.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.grpEng2Start.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.grpEng2Fuel.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrEngines;
        private System.Windows.Forms.GroupBox grpEng1Start;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radEng1Grd;
        private System.Windows.Forms.RadioButton radEng1Auto;
        private System.Windows.Forms.RadioButton radEng1Cont;
        private System.Windows.Forms.GroupBox grpEng1Fuel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton radEng1CutOff;
        private System.Windows.Forms.RadioButton radEng1Idle;
        private System.Windows.Forms.GroupBox grpEng2Start;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.RadioButton radEng2Grd;
        private System.Windows.Forms.RadioButton radEng2Auto;
        private System.Windows.Forms.RadioButton radEng2Cont;
        private System.Windows.Forms.GroupBox grpEng2Fuel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.RadioButton radEng2CutOff;
        private System.Windows.Forms.RadioButton radEng2Idle;
        private System.Windows.Forms.RadioButton radEng1Flt;
        private System.Windows.Forms.RadioButton radEng2Flt;
    }
}
