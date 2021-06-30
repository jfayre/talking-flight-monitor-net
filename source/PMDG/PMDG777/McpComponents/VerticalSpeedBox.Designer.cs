
namespace tfm.PMDG.PMDG777.McpComponents
{
    partial class VerticalSpeedBox
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
            this.vsFpaTextBox = new System.Windows.Forms.TextBox();
            this.interveneButton = new System.Windows.Forms.Button();
            this.modeButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.vsFpaTextBox);
            this.flowLayoutPanel1.Controls.Add(this.interveneButton);
            this.flowLayoutPanel1.Controls.Add(this.modeButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(334, 49);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // vsFpaTextBox
            // 
            this.vsFpaTextBox.AccessibleName = "Vertical speed";
            this.vsFpaTextBox.Location = new System.Drawing.Point(3, 3);
            this.vsFpaTextBox.Name = "vsFpaTextBox";
            this.vsFpaTextBox.Size = new System.Drawing.Size(100, 40);
            this.vsFpaTextBox.TabIndex = 0;
            this.vsFpaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vsFpaTextBox_KeyDown);
            // 
            // interveneButton
            // 
            this.interveneButton.AccessibleName = "Intervene";
            this.interveneButton.AutoSize = true;
            this.interveneButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.interveneButton.Location = new System.Drawing.Point(109, 3);
            this.interveneButton.Name = "interveneButton";
            this.interveneButton.Size = new System.Drawing.Size(126, 43);
            this.interveneButton.TabIndex = 1;
            this.interveneButton.Text = "&Intervene";
            this.interveneButton.UseVisualStyleBackColor = true;
            this.interveneButton.Click += new System.EventHandler(this.interveneButton_Click);
            // 
            // modeButton
            // 
            this.modeButton.AccessibleName = "mode";
            this.modeButton.AutoSize = true;
            this.modeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modeButton.Location = new System.Drawing.Point(241, 3);
            this.modeButton.Name = "modeButton";
            this.modeButton.Size = new System.Drawing.Size(90, 43);
            this.modeButton.TabIndex = 2;
            this.modeButton.Text = "&Mode";
            this.modeButton.UseVisualStyleBackColor = true;
            this.modeButton.Click += new System.EventHandler(this.modeButton_Click);
            // 
            // VerticalSpeedBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(478, 0);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(500, 70);
            this.Name = "VerticalSpeedBox";
            this.Text = "Vertical speed";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VerticalSpeedBox_FormClosing);
            this.Load += new System.EventHandler(this.VerticalSpeedBox_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VerticalSpeedBox_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox vsFpaTextBox;
        private System.Windows.Forms.Button interveneButton;
        private System.Windows.Forms.Button modeButton;
    }
}