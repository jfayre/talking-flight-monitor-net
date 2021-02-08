namespace tfm       
{
    partial class ctlFuel
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
            this.tmrFuel = new System.Windows.Forms.Timer(this.components);
            this.grpLeft = new System.Windows.Forms.GroupBox();
            this.chkAftLeft = new System.Windows.Forms.CheckBox();
            this.chkFwdLeft = new System.Windows.Forms.CheckBox();
            this.grpRight = new System.Windows.Forms.GroupBox();
            this.chkAftRight = new System.Windows.Forms.CheckBox();
            this.chkFwdRight = new System.Windows.Forms.CheckBox();
            this.grpCenter = new System.Windows.Forms.GroupBox();
            this.chkCenterRight = new System.Windows.Forms.CheckBox();
            this.chkCenterLeft = new System.Windows.Forms.CheckBox();
            this.grpAllPumps = new System.Windows.Forms.GroupBox();
            this.btnAllOn = new System.Windows.Forms.Button();
            this.btnAllOff = new System.Windows.Forms.Button();
            this.grpLeft.SuspendLayout();
            this.grpRight.SuspendLayout();
            this.grpCenter.SuspendLayout();
            this.grpAllPumps.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrFuel
            // 
            this.tmrFuel.Interval = 500;
            this.tmrFuel.Tick += new System.EventHandler(this.tmrFuel_Tick);
            // 
            // grpLeft
            // 
            this.grpLeft.AutoSize = true;
            this.grpLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpLeft.Controls.Add(this.chkAftLeft);
            this.grpLeft.Controls.Add(this.chkFwdLeft);
            this.grpLeft.Location = new System.Drawing.Point(5, 75);
            this.grpLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpLeft.Name = "grpLeft";
            this.grpLeft.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpLeft.Size = new System.Drawing.Size(157, 40);
            this.grpLeft.TabIndex = 1;
            this.grpLeft.TabStop = false;
            // 
            // chkAftLeft
            // 
            this.chkAftLeft.AutoSize = true;
            this.chkAftLeft.Location = new System.Drawing.Point(86, 2);
            this.chkAftLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkAftLeft.Name = "chkAftLeft";
            this.chkAftLeft.Size = new System.Drawing.Size(67, 21);
            this.chkAftLeft.TabIndex = 1;
            this.chkAftLeft.Text = "Left Aft";
            this.chkAftLeft.UseVisualStyleBackColor = true;
            this.chkAftLeft.CheckedChanged += new System.EventHandler(this.chkAftLeft_CheckedChanged);
            // 
            // chkFwdLeft
            // 
            this.chkFwdLeft.AutoSize = true;
            this.chkFwdLeft.Location = new System.Drawing.Point(2, 2);
            this.chkFwdLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkFwdLeft.Name = "chkFwdLeft";
            this.chkFwdLeft.Size = new System.Drawing.Size(89, 21);
            this.chkFwdLeft.TabIndex = 0;
            this.chkFwdLeft.Text = "Left forward";
            this.chkFwdLeft.UseVisualStyleBackColor = true;
            this.chkFwdLeft.CheckedChanged += new System.EventHandler(this.chkFwdLeft_CheckedChanged);
            // 
            // grpRight
            // 
            this.grpRight.AutoSize = true;
            this.grpRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpRight.Controls.Add(this.chkAftRight);
            this.grpRight.Controls.Add(this.chkFwdRight);
            this.grpRight.Location = new System.Drawing.Point(359, 75);
            this.grpRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpRight.Name = "grpRight";
            this.grpRight.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpRight.Size = new System.Drawing.Size(172, 40);
            this.grpRight.TabIndex = 3;
            this.grpRight.TabStop = false;
            // 
            // chkAftRight
            // 
            this.chkAftRight.AutoSize = true;
            this.chkAftRight.Location = new System.Drawing.Point(94, 2);
            this.chkAftRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkAftRight.Name = "chkAftRight";
            this.chkAftRight.Size = new System.Drawing.Size(74, 21);
            this.chkAftRight.TabIndex = 2;
            this.chkAftRight.Text = "Right Aft";
            this.chkAftRight.UseVisualStyleBackColor = true;
            this.chkAftRight.CheckedChanged += new System.EventHandler(this.chkAftRight_CheckedChanged);
            // 
            // chkFwdRight
            // 
            this.chkFwdRight.AutoSize = true;
            this.chkFwdRight.Location = new System.Drawing.Point(2, 2);
            this.chkFwdRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkFwdRight.Name = "chkFwdRight";
            this.chkFwdRight.Size = new System.Drawing.Size(99, 21);
            this.chkFwdRight.TabIndex = 1;
            this.chkFwdRight.Text = "Right Forward";
            this.chkFwdRight.UseVisualStyleBackColor = true;
            this.chkFwdRight.CheckedChanged += new System.EventHandler(this.chkFwdRight_CheckedChanged);
            // 
            // grpCenter
            // 
            this.grpCenter.AutoSize = true;
            this.grpCenter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpCenter.Controls.Add(this.chkCenterRight);
            this.grpCenter.Controls.Add(this.chkCenterLeft);
            this.grpCenter.Location = new System.Drawing.Point(165, 75);
            this.grpCenter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCenter.Name = "grpCenter";
            this.grpCenter.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCenter.Size = new System.Drawing.Size(190, 40);
            this.grpCenter.TabIndex = 2;
            this.grpCenter.TabStop = false;
            // 
            // chkCenterRight
            // 
            this.chkCenterRight.AutoSize = true;
            this.chkCenterRight.Location = new System.Drawing.Point(94, 2);
            this.chkCenterRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkCenterRight.Name = "chkCenterRight";
            this.chkCenterRight.Size = new System.Drawing.Size(92, 21);
            this.chkCenterRight.TabIndex = 2;
            this.chkCenterRight.Text = "Center Right";
            this.chkCenterRight.UseVisualStyleBackColor = true;
            this.chkCenterRight.CheckedChanged += new System.EventHandler(this.chkCenterRight_CheckedChanged);
            // 
            // chkCenterLeft
            // 
            this.chkCenterLeft.AutoSize = true;
            this.chkCenterLeft.Location = new System.Drawing.Point(2, 2);
            this.chkCenterLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkCenterLeft.Name = "chkCenterLeft";
            this.chkCenterLeft.Size = new System.Drawing.Size(85, 21);
            this.chkCenterLeft.TabIndex = 1;
            this.chkCenterLeft.Text = "Center Left";
            this.chkCenterLeft.UseVisualStyleBackColor = true;
            this.chkCenterLeft.CheckedChanged += new System.EventHandler(this.chkCenterLeft_CheckedChanged);
            // 
            // grpAllPumps
            // 
            this.grpAllPumps.AutoSize = true;
            this.grpAllPumps.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpAllPumps.Controls.Add(this.btnAllOff);
            this.grpAllPumps.Controls.Add(this.btnAllOn);
            this.grpAllPumps.Location = new System.Drawing.Point(165, 5);
            this.grpAllPumps.Name = "grpAllPumps";
            this.grpAllPumps.Size = new System.Drawing.Size(92, 66);
            this.grpAllPumps.TabIndex = 0;
            this.grpAllPumps.TabStop = false;
            this.grpAllPumps.Text = "groupBox1";
            // 
            // btnAllOn
            // 
            this.btnAllOn.Location = new System.Drawing.Point(3, 16);
            this.btnAllOn.Name = "btnAllOn";
            this.btnAllOn.Size = new System.Drawing.Size(75, 23);
            this.btnAllOn.TabIndex = 0;
            this.btnAllOn.Text = "All pumps on";
            this.btnAllOn.UseVisualStyleBackColor = true;
            this.btnAllOn.Click += new System.EventHandler(this.btnAllOn_Click);
            // 
            // btnAllOff
            // 
            this.btnAllOff.Location = new System.Drawing.Point(11, 24);
            this.btnAllOff.Name = "btnAllOff";
            this.btnAllOff.Size = new System.Drawing.Size(75, 23);
            this.btnAllOff.TabIndex = 1;
            this.btnAllOff.Text = "All pumps off";
            this.btnAllOff.UseVisualStyleBackColor = true;
            this.btnAllOff.Click += new System.EventHandler(this.btnAllOff_Click);
            // 
            // ctlFuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.grpAllPumps);
            this.Controls.Add(this.grpCenter);
            this.Controls.Add(this.grpRight);
            this.Controls.Add(this.grpLeft);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ctlFuel";
            this.Size = new System.Drawing.Size(533, 117);
            this.grpLeft.ResumeLayout(false);
            this.grpLeft.PerformLayout();
            this.grpRight.ResumeLayout(false);
            this.grpRight.PerformLayout();
            this.grpCenter.ResumeLayout(false);
            this.grpCenter.PerformLayout();
            this.grpAllPumps.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrFuel;
        private System.Windows.Forms.GroupBox grpLeft;
        private System.Windows.Forms.CheckBox chkAftLeft;
        private System.Windows.Forms.CheckBox chkFwdLeft;
        private System.Windows.Forms.GroupBox grpRight;
        private System.Windows.Forms.CheckBox chkAftRight;
        private System.Windows.Forms.CheckBox chkFwdRight;
        private System.Windows.Forms.GroupBox grpCenter;
        private System.Windows.Forms.CheckBox chkCenterRight;
        private System.Windows.Forms.CheckBox chkCenterLeft;
        private System.Windows.Forms.GroupBox grpAllPumps;
        private System.Windows.Forms.Button btnAllOff;
        private System.Windows.Forms.Button btnAllOn;
    }
}
