
namespace tfm.PMDG.PMDG777.McpComponents
{
    partial class HeadingBox
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
            this.hdgTrkTextBox = new System.Windows.Forms.TextBox();
            this.interveneButton = new System.Windows.Forms.Button();
            this.hdgHoldButton = new System.Windows.Forms.Button();
            this.modeButton = new System.Windows.Forms.Button();
            this.lNavButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.hdgTrkTextBox);
            this.flowLayoutPanel1.Controls.Add(this.interveneButton);
            this.flowLayoutPanel1.Controls.Add(this.hdgHoldButton);
            this.flowLayoutPanel1.Controls.Add(this.modeButton);
            this.flowLayoutPanel1.Controls.Add(this.lNavButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(596, 49);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // hdgTrkTextBox
            // 
            this.hdgTrkTextBox.Location = new System.Drawing.Point(3, 3);
            this.hdgTrkTextBox.Name = "hdgTrkTextBox";
            this.hdgTrkTextBox.Size = new System.Drawing.Size(100, 40);
            this.hdgTrkTextBox.TabIndex = 0;
            this.hdgTrkTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hdgTrkTextBox_KeyDown);
            // 
            // interveneButton
            // 
            this.interveneButton.AccessibleName = "Heading";
            this.interveneButton.AutoSize = true;
            this.interveneButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.interveneButton.Location = new System.Drawing.Point(109, 3);
            this.interveneButton.Name = "interveneButton";
            this.interveneButton.Size = new System.Drawing.Size(117, 43);
            this.interveneButton.TabIndex = 1;
            this.interveneButton.Text = "&Heading";
            this.interveneButton.UseVisualStyleBackColor = true;
            this.interveneButton.Click += new System.EventHandler(this.interveneButton_Click);
            // 
            // hdgHoldButton
            // 
            this.hdgHoldButton.AccessibleName = "Heading hold";
            this.hdgHoldButton.AutoSize = true;
            this.hdgHoldButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hdgHoldButton.Location = new System.Drawing.Point(232, 3);
            this.hdgHoldButton.Name = "hdgHoldButton";
            this.hdgHoldButton.Size = new System.Drawing.Size(174, 43);
            this.hdgHoldButton.TabIndex = 2;
            this.hdgHoldButton.Text = "Heading h&old";
            this.hdgHoldButton.UseVisualStyleBackColor = true;
            this.hdgHoldButton.Click += new System.EventHandler(this.hdgHoldButton_Click);
            // 
            // modeButton
            // 
            this.modeButton.AutoSize = true;
            this.modeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modeButton.Location = new System.Drawing.Point(412, 3);
            this.modeButton.Name = "modeButton";
            this.modeButton.Size = new System.Drawing.Size(90, 43);
            this.modeButton.TabIndex = 3;
            this.modeButton.Text = "&Mode";
            this.modeButton.UseVisualStyleBackColor = true;
            this.modeButton.Click += new System.EventHandler(this.modeButton_Click);
            // 
            // lNavButton
            // 
            this.lNavButton.AccessibleName = "LNav";
            this.lNavButton.AutoSize = true;
            this.lNavButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lNavButton.Location = new System.Drawing.Point(508, 3);
            this.lNavButton.Name = "lNavButton";
            this.lNavButton.Size = new System.Drawing.Size(85, 43);
            this.lNavButton.TabIndex = 4;
            this.lNavButton.Text = "&LNav";
            this.lNavButton.UseVisualStyleBackColor = true;
            this.lNavButton.Click += new System.EventHandler(this.lNavButton_Click);
            // 
            // HeadingBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(622, 74);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HeadingBox";
            this.Text = "Heading";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HeadingBox_FormClosing);
            this.Load += new System.EventHandler(this.HeadingBox_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HeadingBox_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox hdgTrkTextBox;
        private System.Windows.Forms.Button interveneButton;
        private System.Windows.Forms.Button hdgHoldButton;
        private System.Windows.Forms.Button modeButton;
        private System.Windows.Forms.Button lNavButton;
    }
}