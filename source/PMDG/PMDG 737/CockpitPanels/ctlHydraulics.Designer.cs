namespace tfm
{
    partial class ctlHydraulics
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
            this.tmrHydraulics = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkElec1 = new System.Windows.Forms.CheckBox();
            this.chkElec2 = new System.Windows.Forms.CheckBox();
            this.chkEng1 = new System.Windows.Forms.CheckBox();
            this.chkEng2 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrHydraulics
            // 
            this.tmrHydraulics.Interval = 500;
            this.tmrHydraulics.Tick += new System.EventHandler(this.tmrHydraulics_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.chkElec1);
            this.flowLayoutPanel1.Controls.Add(this.chkElec2);
            this.flowLayoutPanel1.Controls.Add(this.chkEng1);
            this.flowLayoutPanel1.Controls.Add(this.chkEng2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(344, 27);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // chkElec1
            // 
            this.chkElec1.AutoSize = true;
            this.chkElec1.Location = new System.Drawing.Point(3, 3);
            this.chkElec1.Name = "chkElec1";
            this.chkElec1.Size = new System.Drawing.Size(85, 21);
            this.chkElec1.TabIndex = 0;
            this.chkElec1.Text = "Electrical 1";
            this.chkElec1.UseVisualStyleBackColor = true;
            this.chkElec1.CheckedChanged += new System.EventHandler(this.chkElec1_CheckedChanged);
            // 
            // chkElec2
            // 
            this.chkElec2.AutoSize = true;
            this.chkElec2.Location = new System.Drawing.Point(94, 3);
            this.chkElec2.Name = "chkElec2";
            this.chkElec2.Size = new System.Drawing.Size(85, 21);
            this.chkElec2.TabIndex = 1;
            this.chkElec2.Text = "Electrical 2";
            this.chkElec2.UseVisualStyleBackColor = true;
            this.chkElec2.CheckedChanged += new System.EventHandler(this.chkElec2_CheckedChanged);
            // 
            // chkEng1
            // 
            this.chkEng1.AutoSize = true;
            this.chkEng1.Location = new System.Drawing.Point(185, 3);
            this.chkEng1.Name = "chkEng1";
            this.chkEng1.Size = new System.Drawing.Size(75, 21);
            this.chkEng1.TabIndex = 2;
            this.chkEng1.Text = "Engine 1";
            this.chkEng1.UseVisualStyleBackColor = true;
            this.chkEng1.CheckedChanged += new System.EventHandler(this.chkEng1_CheckedChanged);
            // 
            // chkEng2
            // 
            this.chkEng2.AutoSize = true;
            this.chkEng2.Location = new System.Drawing.Point(266, 3);
            this.chkEng2.Name = "chkEng2";
            this.chkEng2.Size = new System.Drawing.Size(75, 21);
            this.chkEng2.TabIndex = 3;
            this.chkEng2.Text = "Engine 2";
            this.chkEng2.UseVisualStyleBackColor = true;
            this.chkEng2.CheckedChanged += new System.EventHandler(this.chkEng2_CheckedChanged);
            // 
            // ctlHydraulics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ctlHydraulics";
            this.Size = new System.Drawing.Size(100, 97);
            this.Load += new System.EventHandler(this.ctlHydraulics_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrHydraulics;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox chkElec1;
        private System.Windows.Forms.CheckBox chkElec2;
        private System.Windows.Forms.CheckBox chkEng1;
        private System.Windows.Forms.CheckBox chkEng2;
    }
}
