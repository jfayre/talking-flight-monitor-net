
namespace tfm
{
    partial class ctlAntiIce
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
            this.grpWindowHeat = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkLeftSide = new System.Windows.Forms.CheckBox();
            this.chkLeftForward = new System.Windows.Forms.CheckBox();
            this.chkRightForward = new System.Windows.Forms.CheckBox();
            this.chkRightSide = new System.Windows.Forms.CheckBox();
            this.grpProbeHeat = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkProbeHeatLeft = new System.Windows.Forms.CheckBox();
            this.chkProbeHeatRight = new System.Windows.Forms.CheckBox();
            this.tmrAntiIce = new System.Windows.Forms.Timer(this.components);
            this.grpWindowHeat.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.grpProbeHeat.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpWindowHeat
            // 
            this.grpWindowHeat.AutoSize = true;
            this.grpWindowHeat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpWindowHeat.Controls.Add(this.flowLayoutPanel1);
            this.grpWindowHeat.Location = new System.Drawing.Point(8, 8);
            this.grpWindowHeat.Margin = new System.Windows.Forms.Padding(5);
            this.grpWindowHeat.Name = "grpWindowHeat";
            this.grpWindowHeat.Padding = new System.Windows.Forms.Padding(5);
            this.grpWindowHeat.Size = new System.Drawing.Size(348, 213);
            this.grpWindowHeat.TabIndex = 0;
            this.grpWindowHeat.TabStop = false;
            this.grpWindowHeat.Text = "Window Heat";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chkLeftSide);
            this.flowLayoutPanel1.Controls.Add(this.chkLeftForward);
            this.flowLayoutPanel1.Controls.Add(this.chkRightForward);
            this.flowLayoutPanel1.Controls.Add(this.chkRightSide);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(333, 165);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // chkLeftSide
            // 
            this.chkLeftSide.AutoSize = true;
            this.chkLeftSide.Location = new System.Drawing.Point(5, 5);
            this.chkLeftSide.Margin = new System.Windows.Forms.Padding(5);
            this.chkLeftSide.Name = "chkLeftSide";
            this.chkLeftSide.Size = new System.Drawing.Size(143, 37);
            this.chkLeftSide.TabIndex = 0;
            this.chkLeftSide.Text = "Left Side";
            this.chkLeftSide.UseVisualStyleBackColor = true;
            this.chkLeftSide.CheckedChanged += new System.EventHandler(this.chkLeftSide_CheckedChanged);
            // 
            // chkLeftForward
            // 
            this.chkLeftForward.AutoSize = true;
            this.chkLeftForward.Location = new System.Drawing.Point(5, 52);
            this.chkLeftForward.Margin = new System.Windows.Forms.Padding(5);
            this.chkLeftForward.Name = "chkLeftForward";
            this.chkLeftForward.Size = new System.Drawing.Size(186, 37);
            this.chkLeftForward.TabIndex = 1;
            this.chkLeftForward.Text = "Left Forward";
            this.chkLeftForward.UseVisualStyleBackColor = true;
            this.chkLeftForward.CheckedChanged += new System.EventHandler(this.chkLeftForward_CheckedChanged);
            // 
            // chkRightForward
            // 
            this.chkRightForward.AutoSize = true;
            this.chkRightForward.Location = new System.Drawing.Point(5, 99);
            this.chkRightForward.Margin = new System.Windows.Forms.Padding(5);
            this.chkRightForward.Name = "chkRightForward";
            this.chkRightForward.Size = new System.Drawing.Size(196, 37);
            this.chkRightForward.TabIndex = 2;
            this.chkRightForward.Text = "Right forward";
            this.chkRightForward.UseVisualStyleBackColor = true;
            this.chkRightForward.CheckedChanged += new System.EventHandler(this.chkRightForward_CheckedChanged);
            // 
            // chkRightSide
            // 
            this.chkRightSide.AutoSize = true;
            this.chkRightSide.Location = new System.Drawing.Point(5, 146);
            this.chkRightSide.Margin = new System.Windows.Forms.Padding(5);
            this.chkRightSide.Name = "chkRightSide";
            this.chkRightSide.Size = new System.Drawing.Size(155, 37);
            this.chkRightSide.TabIndex = 3;
            this.chkRightSide.Text = "Right side";
            this.chkRightSide.UseVisualStyleBackColor = true;
            this.chkRightSide.CheckedChanged += new System.EventHandler(this.chkRightSide_CheckedChanged);
            // 
            // grpProbeHeat
            // 
            this.grpProbeHeat.AutoSize = true;
            this.grpProbeHeat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpProbeHeat.Controls.Add(this.flowLayoutPanel2);
            this.grpProbeHeat.Location = new System.Drawing.Point(362, 5);
            this.grpProbeHeat.Name = "grpProbeHeat";
            this.grpProbeHeat.Size = new System.Drawing.Size(209, 142);
            this.grpProbeHeat.TabIndex = 1;
            this.grpProbeHeat.TabStop = false;
            this.grpProbeHeat.Text = "groupBox1";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.chkProbeHeatLeft);
            this.flowLayoutPanel2.Controls.Add(this.chkProbeHeatRight);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // chkProbeHeatLeft
            // 
            this.chkProbeHeatLeft.AutoSize = true;
            this.chkProbeHeatLeft.Location = new System.Drawing.Point(3, 3);
            this.chkProbeHeatLeft.Name = "chkProbeHeatLeft";
            this.chkProbeHeatLeft.Size = new System.Drawing.Size(209, 37);
            this.chkProbeHeatLeft.TabIndex = 0;
            this.chkProbeHeatLeft.Text = "Left probe heat";
            this.chkProbeHeatLeft.UseVisualStyleBackColor = true;
            this.chkProbeHeatLeft.CheckedChanged += new System.EventHandler(this.chkProbeHeatLeft_CheckedChanged);
            // 
            // chkProbeHeatRight
            // 
            this.chkProbeHeatRight.AutoSize = true;
            this.chkProbeHeatRight.Location = new System.Drawing.Point(3, 46);
            this.chkProbeHeatRight.Name = "chkProbeHeatRight";
            this.chkProbeHeatRight.Size = new System.Drawing.Size(226, 37);
            this.chkProbeHeatRight.TabIndex = 1;
            this.chkProbeHeatRight.Text = "Right probe heat";
            this.chkProbeHeatRight.UseVisualStyleBackColor = true;
            this.chkProbeHeatRight.CheckedChanged += new System.EventHandler(this.chkProbeHeatRight_CheckedChanged);
            // 
            // tmrAntiIce
            // 
            this.tmrAntiIce.Interval = 1000;
            this.tmrAntiIce.Tick += new System.EventHandler(this.tmrAntiIce_Tick);
            // 
            // ctlAntiIce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.grpProbeHeat);
            this.Controls.Add(this.grpWindowHeat);
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ctlAntiIce";
            this.Size = new System.Drawing.Size(574, 226);
            this.Load += new System.EventHandler(this.ctlAntiIce_Load);
            this.grpWindowHeat.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.grpProbeHeat.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpWindowHeat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox chkLeftSide;
        private System.Windows.Forms.CheckBox chkLeftForward;
        private System.Windows.Forms.CheckBox chkRightForward;
        private System.Windows.Forms.CheckBox chkRightSide;
        private System.Windows.Forms.GroupBox grpProbeHeat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox chkProbeHeatLeft;
        private System.Windows.Forms.CheckBox chkProbeHeatRight;
        private System.Windows.Forms.Timer tmrAntiIce;
    }
}
