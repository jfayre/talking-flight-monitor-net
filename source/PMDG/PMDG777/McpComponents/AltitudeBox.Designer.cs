
namespace tfm.PMDG.PMDG777.McpComponents
{
    partial class AltitudeBox
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.altitudeTextBox = new System.Windows.Forms.TextBox();
            this.altitudeButton = new System.Windows.Forms.Button();
            this.altitudeHoldButton = new System.Windows.Forms.Button();
            this.vNavButton = new System.Windows.Forms.Button();
            this.levelChangeButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.altitudeTextBox);
            this.flowLayoutPanel1.Controls.Add(this.altitudeButton);
            this.flowLayoutPanel1.Controls.Add(this.altitudeHoldButton);
            this.flowLayoutPanel1.Controls.Add(this.vNavButton);
            this.flowLayoutPanel1.Controls.Add(this.levelChangeButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(678, 0);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // altitudeTextBox
            // 
            this.altitudeTextBox.AccessibleName = "Altitude";
            this.altitudeTextBox.Location = new System.Drawing.Point(3, 3);
            this.altitudeTextBox.Name = "altitudeTextBox";
            this.altitudeTextBox.Size = new System.Drawing.Size(100, 40);
            this.altitudeTextBox.TabIndex = 0;
            this.altitudeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.altitudeTextBox_KeyDown);
            // 
            // altitudeButton
            // 
            this.altitudeButton.AccessibleName = "Altitude";
            this.altitudeButton.AutoSize = true;
            this.altitudeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.altitudeButton.Location = new System.Drawing.Point(109, 3);
            this.altitudeButton.Name = "altitudeButton";
            this.altitudeButton.Size = new System.Drawing.Size(116, 43);
            this.altitudeButton.TabIndex = 1;
            this.altitudeButton.Text = "&Altitude";
            this.altitudeButton.UseVisualStyleBackColor = true;
            this.altitudeButton.Click += new System.EventHandler(this.altitudeButton_Click);
            // 
            // altitudeHoldButton
            // 
            this.altitudeHoldButton.AccessibleName = "Altitude hold";
            this.altitudeHoldButton.AutoSize = true;
            this.altitudeHoldButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.altitudeHoldButton.Location = new System.Drawing.Point(231, 3);
            this.altitudeHoldButton.Name = "altitudeHoldButton";
            this.altitudeHoldButton.Size = new System.Drawing.Size(173, 43);
            this.altitudeHoldButton.TabIndex = 2;
            this.altitudeHoldButton.Text = "Altitude &hold";
            this.altitudeHoldButton.UseVisualStyleBackColor = true;
            this.altitudeHoldButton.Click += new System.EventHandler(this.altitudeHoldButton_Click);
            // 
            // vNavButton
            // 
            this.vNavButton.AccessibleName = "VNav";
            this.vNavButton.AutoSize = true;
            this.vNavButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vNavButton.Location = new System.Drawing.Point(410, 3);
            this.vNavButton.Name = "vNavButton";
            this.vNavButton.Size = new System.Drawing.Size(89, 43);
            this.vNavButton.TabIndex = 3;
            this.vNavButton.Text = "&V nav";
            this.vNavButton.UseVisualStyleBackColor = true;
            this.vNavButton.Click += new System.EventHandler(this.vNavButton_Click);
            // 
            // levelChangeButton
            // 
            this.levelChangeButton.AccessibleName = "Level change";
            this.levelChangeButton.AutoSize = true;
            this.levelChangeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.levelChangeButton.Location = new System.Drawing.Point(505, 3);
            this.levelChangeButton.Name = "levelChangeButton";
            this.levelChangeButton.Size = new System.Drawing.Size(169, 43);
            this.levelChangeButton.TabIndex = 4;
            this.levelChangeButton.Text = "&Level change";
            this.levelChangeButton.UseVisualStyleBackColor = true;
            this.levelChangeButton.Click += new System.EventHandler(this.levelChangeButton_Click);
            // 
            // AltitudeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(678, 0);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(700, 70);
            this.Name = "AltitudeBox";
            this.Text = "AltitudeBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AltitudeBox_FormClosing);
            this.Load += new System.EventHandler(this.AltitudeBox_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AltitudeBox_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox altitudeTextBox;
        private System.Windows.Forms.Button altitudeButton;
        private System.Windows.Forms.Button altitudeHoldButton;
        private System.Windows.Forms.Button vNavButton;
        private System.Windows.Forms.Button levelChangeButton;
    }
}