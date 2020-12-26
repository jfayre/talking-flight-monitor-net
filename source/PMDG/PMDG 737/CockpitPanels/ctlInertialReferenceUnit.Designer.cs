namespace tfm
{
    partial class ctlInertialReferenceUnit
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
            this.tmrIRU = new System.Windows.Forms.Timer(this.components);
            this.grpIRUMode = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.grpIRULeft = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radIRULeftOff = new System.Windows.Forms.RadioButton();
            this.radIRULeftAlign = new System.Windows.Forms.RadioButton();
            this.radIRULeftNav = new System.Windows.Forms.RadioButton();
            this.radIRULeftAtt = new System.Windows.Forms.RadioButton();
            this.grpIRURight = new System.Windows.Forms.GroupBox();
            this.radIRURightAtt = new System.Windows.Forms.RadioButton();
            this.radIRURightNav = new System.Windows.Forms.RadioButton();
            this.radIRURightAlign = new System.Windows.Forms.RadioButton();
            this.radIRURightOff = new System.Windows.Forms.RadioButton();
            this.grpIRUDisplay = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.grpDisplayMode = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.radDispTKGS = new System.Windows.Forms.RadioButton();
            this.radDispPPOS = new System.Windows.Forms.RadioButton();
            this.radDispWind = new System.Windows.Forms.RadioButton();
            this.radDispHDGStat = new System.Windows.Forms.RadioButton();
            this.lblLeft = new System.Windows.Forms.Label();
            this.txtDispLeft = new System.Windows.Forms.TextBox();
            this.lblRight = new System.Windows.Forms.Label();
            this.txtDispRight = new System.Windows.Forms.TextBox();
            this.grpIRUMode.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.grpIRULeft.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.grpIRURight.SuspendLayout();
            this.grpIRUDisplay.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.grpDisplayMode.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrIRU
            // 
            this.tmrIRU.Interval = 500;
            this.tmrIRU.Tick += new System.EventHandler(this.tmrIRU_Tick);
            // 
            // grpIRUMode
            // 
            this.grpIRUMode.AutoSize = true;
            this.grpIRUMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpIRUMode.Controls.Add(this.flowLayoutPanel1);
            this.grpIRUMode.Location = new System.Drawing.Point(5, 5);
            this.grpIRUMode.Name = "grpIRUMode";
            this.grpIRUMode.Size = new System.Drawing.Size(430, 162);
            this.grpIRUMode.TabIndex = 0;
            this.grpIRUMode.TabStop = false;
            this.grpIRUMode.Text = "IRU mode";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.grpIRULeft);
            this.flowLayoutPanel1.Controls.Add(this.grpIRURight);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(421, 134);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // grpIRULeft
            // 
            this.grpIRULeft.AutoSize = true;
            this.grpIRULeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpIRULeft.Controls.Add(this.flowLayoutPanel2);
            this.grpIRULeft.Location = new System.Drawing.Point(3, 3);
            this.grpIRULeft.Name = "grpIRULeft";
            this.grpIRULeft.Size = new System.Drawing.Size(209, 128);
            this.grpIRULeft.TabIndex = 0;
            this.grpIRULeft.TabStop = false;
            this.grpIRULeft.Text = "Left IRU";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.radIRULeftOff);
            this.flowLayoutPanel2.Controls.Add(this.radIRULeftAlign);
            this.flowLayoutPanel2.Controls.Add(this.radIRULeftNav);
            this.flowLayoutPanel2.Controls.Add(this.radIRULeftAtt);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // radIRULeftOff
            // 
            this.radIRULeftOff.AutoSize = true;
            this.radIRULeftOff.Location = new System.Drawing.Point(3, 3);
            this.radIRULeftOff.Name = "radIRULeftOff";
            this.radIRULeftOff.Size = new System.Drawing.Size(56, 24);
            this.radIRULeftOff.TabIndex = 1;
            this.radIRULeftOff.TabStop = true;
            this.radIRULeftOff.Text = "Off";
            this.radIRULeftOff.UseVisualStyleBackColor = true;
            this.radIRULeftOff.CheckedChanged += new System.EventHandler(this.radIRULeft_CheckedChanged);
            // 
            // radIRULeftAlign
            // 
            this.radIRULeftAlign.AutoSize = true;
            this.radIRULeftAlign.Location = new System.Drawing.Point(65, 3);
            this.radIRULeftAlign.Name = "radIRULeftAlign";
            this.radIRULeftAlign.Size = new System.Drawing.Size(69, 24);
            this.radIRULeftAlign.TabIndex = 2;
            this.radIRULeftAlign.TabStop = true;
            this.radIRULeftAlign.Text = "Align";
            this.radIRULeftAlign.UseVisualStyleBackColor = true;
            this.radIRULeftAlign.CheckedChanged += new System.EventHandler(this.radIRULeft_CheckedChanged);
            // 
            // radIRULeftNav
            // 
            this.radIRULeftNav.AutoSize = true;
            this.radIRULeftNav.Location = new System.Drawing.Point(3, 33);
            this.radIRULeftNav.Name = "radIRULeftNav";
            this.radIRULeftNav.Size = new System.Drawing.Size(61, 24);
            this.radIRULeftNav.TabIndex = 3;
            this.radIRULeftNav.TabStop = true;
            this.radIRULeftNav.Text = "Nav";
            this.radIRULeftNav.UseVisualStyleBackColor = true;
            this.radIRULeftNav.CheckedChanged += new System.EventHandler(this.radIRULeft_CheckedChanged);
            // 
            // radIRULeftAtt
            // 
            this.radIRULeftAtt.AutoSize = true;
            this.radIRULeftAtt.Location = new System.Drawing.Point(70, 33);
            this.radIRULeftAtt.Name = "radIRULeftAtt";
            this.radIRULeftAtt.Size = new System.Drawing.Size(55, 24);
            this.radIRULeftAtt.TabIndex = 4;
            this.radIRULeftAtt.TabStop = true;
            this.radIRULeftAtt.Text = "Att";
            this.radIRULeftAtt.UseVisualStyleBackColor = true;
            this.radIRULeftAtt.CheckedChanged += new System.EventHandler(this.radIRULeft_CheckedChanged);
            // 
            // grpIRURight
            // 
            this.grpIRURight.Controls.Add(this.radIRURightAtt);
            this.grpIRURight.Controls.Add(this.radIRURightNav);
            this.grpIRURight.Controls.Add(this.radIRURightAlign);
            this.grpIRURight.Controls.Add(this.radIRURightOff);
            this.grpIRURight.Location = new System.Drawing.Point(218, 3);
            this.grpIRURight.Name = "grpIRURight";
            this.grpIRURight.Size = new System.Drawing.Size(200, 100);
            this.grpIRURight.TabIndex = 1;
            this.grpIRURight.TabStop = false;
            this.grpIRURight.Text = "Right IRU";
            // 
            // radIRURightAtt
            // 
            this.radIRURightAtt.AutoSize = true;
            this.radIRURightAtt.Location = new System.Drawing.Point(53, 54);
            this.radIRURightAtt.Name = "radIRURightAtt";
            this.radIRURightAtt.Size = new System.Drawing.Size(55, 24);
            this.radIRURightAtt.TabIndex = 3;
            this.radIRURightAtt.TabStop = true;
            this.radIRURightAtt.Text = "Att";
            this.radIRURightAtt.UseVisualStyleBackColor = true;
            this.radIRURightAtt.CheckedChanged += new System.EventHandler(this.radIRURight_CheckedChanged);
            // 
            // radIRURightNav
            // 
            this.radIRURightNav.AutoSize = true;
            this.radIRURightNav.Location = new System.Drawing.Point(45, 46);
            this.radIRURightNav.Name = "radIRURightNav";
            this.radIRURightNav.Size = new System.Drawing.Size(61, 24);
            this.radIRURightNav.TabIndex = 2;
            this.radIRURightNav.TabStop = true;
            this.radIRURightNav.Text = "Nav";
            this.radIRURightNav.UseVisualStyleBackColor = true;
            this.radIRURightNav.CheckedChanged += new System.EventHandler(this.radIRURight_CheckedChanged);
            // 
            // radIRURightAlign
            // 
            this.radIRURightAlign.AutoSize = true;
            this.radIRURightAlign.Location = new System.Drawing.Point(37, 38);
            this.radIRURightAlign.Name = "radIRURightAlign";
            this.radIRURightAlign.Size = new System.Drawing.Size(69, 24);
            this.radIRURightAlign.TabIndex = 1;
            this.radIRURightAlign.TabStop = true;
            this.radIRURightAlign.Text = "Align";
            this.radIRURightAlign.UseVisualStyleBackColor = true;
            this.radIRURightAlign.CheckedChanged += new System.EventHandler(this.radIRURight_CheckedChanged);
            // 
            // radIRURightOff
            // 
            this.radIRURightOff.AutoSize = true;
            this.radIRURightOff.Location = new System.Drawing.Point(3, 22);
            this.radIRURightOff.Name = "radIRURightOff";
            this.radIRURightOff.Size = new System.Drawing.Size(56, 24);
            this.radIRURightOff.TabIndex = 0;
            this.radIRURightOff.TabStop = true;
            this.radIRURightOff.Text = "Off";
            this.radIRURightOff.UseVisualStyleBackColor = true;
            this.radIRURightOff.CheckedChanged += new System.EventHandler(this.radIRURight_CheckedChanged);
            // 
            // grpIRUDisplay
            // 
            this.grpIRUDisplay.AutoSize = true;
            this.grpIRUDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpIRUDisplay.Controls.Add(this.flowLayoutPanel3);
            this.grpIRUDisplay.Location = new System.Drawing.Point(5, 175);
            this.grpIRUDisplay.Name = "grpIRUDisplay";
            this.grpIRUDisplay.Size = new System.Drawing.Size(709, 130);
            this.grpIRUDisplay.TabIndex = 1;
            this.grpIRUDisplay.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.grpDisplayMode);
            this.flowLayoutPanel3.Controls.Add(this.lblLeft);
            this.flowLayoutPanel3.Controls.Add(this.txtDispLeft);
            this.flowLayoutPanel3.Controls.Add(this.lblRight);
            this.flowLayoutPanel3.Controls.Add(this.txtDispRight);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(700, 83);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // grpDisplayMode
            // 
            this.grpDisplayMode.AutoSize = true;
            this.grpDisplayMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpDisplayMode.Controls.Add(this.flowLayoutPanel4);
            this.grpDisplayMode.Location = new System.Drawing.Point(3, 3);
            this.grpDisplayMode.Name = "grpDisplayMode";
            this.grpDisplayMode.Size = new System.Drawing.Size(382, 77);
            this.grpDisplayMode.TabIndex = 0;
            this.grpDisplayMode.TabStop = false;
            this.grpDisplayMode.Text = "display mode";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.radDispTKGS);
            this.flowLayoutPanel4.Controls.Add(this.radDispPPOS);
            this.flowLayoutPanel4.Controls.Add(this.radDispWind);
            this.flowLayoutPanel4.Controls.Add(this.radDispHDGStat);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(373, 30);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // radDispTKGS
            // 
            this.radDispTKGS.AutoSize = true;
            this.radDispTKGS.Location = new System.Drawing.Point(3, 3);
            this.radDispTKGS.Name = "radDispTKGS";
            this.radDispTKGS.Size = new System.Drawing.Size(89, 24);
            this.radDispTKGS.TabIndex = 0;
            this.radDispTKGS.TabStop = true;
            this.radDispTKGS.Text = "TK / GS";
            this.radDispTKGS.UseVisualStyleBackColor = true;
            // 
            // radDispPPOS
            // 
            this.radDispPPOS.AutoSize = true;
            this.radDispPPOS.Location = new System.Drawing.Point(98, 3);
            this.radDispPPOS.Name = "radDispPPOS";
            this.radDispPPOS.Size = new System.Drawing.Size(77, 24);
            this.radDispPPOS.TabIndex = 1;
            this.radDispPPOS.TabStop = true;
            this.radDispPPOS.Text = "PPOS";
            this.radDispPPOS.UseVisualStyleBackColor = true;
            // 
            // radDispWind
            // 
            this.radDispWind.AutoSize = true;
            this.radDispWind.Location = new System.Drawing.Point(181, 3);
            this.radDispWind.Name = "radDispWind";
            this.radDispWind.Size = new System.Drawing.Size(70, 24);
            this.radDispWind.TabIndex = 2;
            this.radDispWind.TabStop = true;
            this.radDispWind.Text = "Wind";
            this.radDispWind.UseVisualStyleBackColor = true;
            // 
            // radDispHDGStat
            // 
            this.radDispHDGStat.AutoSize = true;
            this.radDispHDGStat.Location = new System.Drawing.Point(257, 3);
            this.radDispHDGStat.Name = "radDispHDGStat";
            this.radDispHDGStat.Size = new System.Drawing.Size(113, 24);
            this.radDispHDGStat.TabIndex = 3;
            this.radDispHDGStat.TabStop = true;
            this.radDispHDGStat.Text = "HDG / Stat";
            this.radDispHDGStat.UseVisualStyleBackColor = true;
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(391, 0);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(37, 20);
            this.lblLeft.TabIndex = 1;
            this.lblLeft.Text = "Left";
            // 
            // txtDispLeft
            // 
            this.txtDispLeft.Location = new System.Drawing.Point(434, 3);
            this.txtDispLeft.Name = "txtDispLeft";
            this.txtDispLeft.Size = new System.Drawing.Size(100, 26);
            this.txtDispLeft.TabIndex = 2;
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(540, 0);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(51, 20);
            this.lblRight.TabIndex = 3;
            this.lblRight.Text = "label2";
            // 
            // txtDispRight
            // 
            this.txtDispRight.Location = new System.Drawing.Point(597, 3);
            this.txtDispRight.Name = "txtDispRight";
            this.txtDispRight.Size = new System.Drawing.Size(100, 26);
            this.txtDispRight.TabIndex = 4;
            // 
            // ctlInertialReferenceUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.grpIRUDisplay);
            this.Controls.Add(this.grpIRUMode);
            this.Name = "ctlInertialReferenceUnit";
            this.Size = new System.Drawing.Size(717, 308);
            this.Load += new System.EventHandler(this.ctlInertialReferenceUnit_Load);
            this.grpIRUMode.ResumeLayout(false);
            this.grpIRUMode.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.grpIRULeft.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.grpIRURight.ResumeLayout(false);
            this.grpIRURight.PerformLayout();
            this.grpIRUDisplay.ResumeLayout(false);
            this.grpIRUDisplay.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.grpDisplayMode.ResumeLayout(false);
            this.grpDisplayMode.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrIRU;
        private System.Windows.Forms.GroupBox grpIRUMode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox grpIRULeft;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton radIRULeftOff;
        private System.Windows.Forms.RadioButton radIRULeftAlign;
        private System.Windows.Forms.RadioButton radIRULeftNav;
        private System.Windows.Forms.RadioButton radIRULeftAtt;
        private System.Windows.Forms.GroupBox grpIRURight;
        private System.Windows.Forms.RadioButton radIRURightAtt;
        private System.Windows.Forms.RadioButton radIRURightNav;
        private System.Windows.Forms.RadioButton radIRURightAlign;
        private System.Windows.Forms.RadioButton radIRURightOff;
        private System.Windows.Forms.GroupBox grpIRUDisplay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.GroupBox grpDisplayMode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.RadioButton radDispTKGS;
        private System.Windows.Forms.RadioButton radDispPPOS;
        private System.Windows.Forms.RadioButton radDispWind;
        private System.Windows.Forms.RadioButton radDispHDGStat;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.TextBox txtDispLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.TextBox txtDispRight;
    }
}
