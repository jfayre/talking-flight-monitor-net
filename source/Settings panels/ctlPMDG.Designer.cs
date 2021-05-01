
namespace tfm
{
    partial class ctlPMDG
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radCDUKeysDefault = new System.Windows.Forms.RadioButton();
            this.radCDUKeysAlternate = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CDU Soft Key mode";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radCDUKeysDefault);
            this.flowLayoutPanel1.Controls.Add(this.radCDUKeysAlternate);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // radCDUKeysDefault
            // 
            this.radCDUKeysDefault.AutoSize = true;
            this.radCDUKeysDefault.Location = new System.Drawing.Point(3, 3);
            this.radCDUKeysDefault.Name = "radCDUKeysDefault";
            this.radCDUKeysDefault.Size = new System.Drawing.Size(394, 24);
            this.radCDUKeysDefault.TabIndex = 0;
            this.radCDUKeysDefault.TabStop = true;
            this.radCDUKeysDefault.Text = "Default (Ctrl+1-6 for left keys, Alt+1-6 for right keys)";
            this.radCDUKeysDefault.UseVisualStyleBackColor = true;
            this.radCDUKeysDefault.CheckedChanged += new System.EventHandler(this.radCDUKeys_CheckedChanged);
            // 
            // radCDUKeysAlternate
            // 
            this.radCDUKeysAlternate.AutoSize = true;
            this.radCDUKeysAlternate.Location = new System.Drawing.Point(3, 33);
            this.radCDUKeysAlternate.Name = "radCDUKeysAlternate";
            this.radCDUKeysAlternate.Size = new System.Drawing.Size(395, 24);
            this.radCDUKeysAlternate.TabIndex = 1;
            this.radCDUKeysAlternate.TabStop = true;
            this.radCDUKeysAlternate.Text = "Alternate (F1-F6 for left keys, F7-F12 for right keys)";
            this.radCDUKeysAlternate.UseVisualStyleBackColor = true;
            this.radCDUKeysAlternate.CheckedChanged += new System.EventHandler(this.radCDUKeys_CheckedChanged);
            // 
            // ctlPMDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctlPMDG";
            this.Size = new System.Drawing.Size(208, 108);
            this.Load += new System.EventHandler(this.ctlPMDG_Load);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radCDUKeysDefault;
        private System.Windows.Forms.RadioButton radCDUKeysAlternate;
    }
}