
namespace tfm.PMDG.PMDG777.McpComponents
{
    partial class SpeedBox
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
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.modeButton = new System.Windows.Forms.Button();
            this.speedButton = new System.Windows.Forms.Button();
            this.autoThrottleGroup = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.autoThrottleLButton = new System.Windows.Forms.Button();
            this.autoThrottleRButton = new System.Windows.Forms.Button();
            this.autoThrottleButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.autoThrottleGroup.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.speedTextBox);
            this.flowLayoutPanel1.Controls.Add(this.modeButton);
            this.flowLayoutPanel1.Controls.Add(this.speedButton);
            this.flowLayoutPanel1.Controls.Add(this.autoThrottleGroup);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(615, 95);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // speedTextBox
            // 
            this.speedTextBox.AccessibleName = "Speed";
            this.speedTextBox.Location = new System.Drawing.Point(3, 3);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(100, 40);
            this.speedTextBox.TabIndex = 0;
            this.speedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedTextBox_KeyDown);
            // 
            // modeButton
            // 
            this.modeButton.AccessibleName = "Speed mode";
            this.modeButton.AutoSize = true;
            this.modeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modeButton.Location = new System.Drawing.Point(109, 3);
            this.modeButton.Name = "modeButton";
            this.modeButton.Size = new System.Drawing.Size(85, 43);
            this.modeButton.TabIndex = 1;
            this.modeButton.Text = "&mode";
            this.modeButton.UseVisualStyleBackColor = true;
            this.modeButton.Click += new System.EventHandler(this.modeButton_Click);
            // 
            // speedButton
            // 
            this.speedButton.AccessibleName = "Speed";
            this.speedButton.AutoSize = true;
            this.speedButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.speedButton.Location = new System.Drawing.Point(200, 3);
            this.speedButton.Name = "speedButton";
            this.speedButton.Size = new System.Drawing.Size(88, 43);
            this.speedButton.TabIndex = 2;
            this.speedButton.Text = "&speed";
            this.speedButton.UseVisualStyleBackColor = true;
            this.speedButton.Click += new System.EventHandler(this.speedButton_Click);
            // 
            // autoThrottleGroup
            // 
            this.autoThrottleGroup.AccessibleName = "Autothrottle";
            this.autoThrottleGroup.AutoSize = true;
            this.autoThrottleGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.autoThrottleGroup.Controls.Add(this.flowLayoutPanel2);
            this.autoThrottleGroup.Location = new System.Drawing.Point(294, 3);
            this.autoThrottleGroup.Name = "autoThrottleGroup";
            this.autoThrottleGroup.Size = new System.Drawing.Size(294, 88);
            this.autoThrottleGroup.TabIndex = 3;
            this.autoThrottleGroup.TabStop = false;
            this.autoThrottleGroup.Text = "Autothrottle";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.autoThrottleLButton);
            this.flowLayoutPanel2.Controls.Add(this.autoThrottleRButton);
            this.flowLayoutPanel2.Controls.Add(this.autoThrottleButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 36);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(288, 49);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // autoThrottleLButton
            // 
            this.autoThrottleLButton.AccessibleName = "Left";
            this.autoThrottleLButton.AutoSize = true;
            this.autoThrottleLButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.autoThrottleLButton.Location = new System.Drawing.Point(3, 3);
            this.autoThrottleLButton.Name = "autoThrottleLButton";
            this.autoThrottleLButton.Size = new System.Drawing.Size(39, 43);
            this.autoThrottleLButton.TabIndex = 0;
            this.autoThrottleLButton.Text = "q";
            this.autoThrottleLButton.UseVisualStyleBackColor = true;
            this.autoThrottleLButton.Click += new System.EventHandler(this.autoThrottleLButton_Click);
            // 
            // autoThrottleRButton
            // 
            this.autoThrottleRButton.AccessibleName = "Right";
            this.autoThrottleRButton.AutoSize = true;
            this.autoThrottleRButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.autoThrottleRButton.Location = new System.Drawing.Point(48, 3);
            this.autoThrottleRButton.Name = "autoThrottleRButton";
            this.autoThrottleRButton.Size = new System.Drawing.Size(77, 43);
            this.autoThrottleRButton.TabIndex = 1;
            this.autoThrottleRButton.Text = "&right";
            this.autoThrottleRButton.UseVisualStyleBackColor = true;
            this.autoThrottleRButton.Click += new System.EventHandler(this.autoThrottleRButton_Click);
            // 
            // autoThrottleButton
            // 
            this.autoThrottleButton.AccessibleName = "Autothrottle";
            this.autoThrottleButton.AutoSize = true;
            this.autoThrottleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.autoThrottleButton.Location = new System.Drawing.Point(131, 3);
            this.autoThrottleButton.Name = "autoThrottleButton";
            this.autoThrottleButton.Size = new System.Drawing.Size(154, 43);
            this.autoThrottleButton.TabIndex = 2;
            this.autoThrottleButton.Text = "&autothrottle";
            this.autoThrottleButton.UseVisualStyleBackColor = true;
            this.autoThrottleButton.Click += new System.EventHandler(this.autoThrottleButton_Click);
            // 
            // SpeedBox
            // 
            this.AccessibleName = "Speed box";
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(615, 95);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SpeedBox";
            this.Text = "Speed box";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpeedBox_FormClosing);
            this.Load += new System.EventHandler(this.SpeedBox_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpeedBox_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.autoThrottleGroup.ResumeLayout(false);
            this.autoThrottleGroup.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Button modeButton;
        private System.Windows.Forms.Button speedButton;
        private System.Windows.Forms.GroupBox autoThrottleGroup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button autoThrottleLButton;
        private System.Windows.Forms.Button autoThrottleRButton;
        private System.Windows.Forms.Button autoThrottleButton;
    }
}