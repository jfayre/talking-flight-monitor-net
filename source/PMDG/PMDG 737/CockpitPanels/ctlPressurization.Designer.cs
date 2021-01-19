using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tfm
{
    public partial class ctlPressurization
    {
        

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrPressurization = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCrzAlt = new System.Windows.Forms.TextBox();
            this.btnSetCrzAlt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLandAlt = new System.Windows.Forms.TextBox();
            this.btnSetLandingAlt = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrPressurization
            // 
            this.tmrPressurization.Interval = 1000;
            this.tmrPressurization.Tick += new System.EventHandler(this.tmrPressurization_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtCrzAlt);
            this.flowLayoutPanel1.Controls.Add(this.btnSetCrzAlt);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txtLandAlt);
            this.flowLayoutPanel1.Controls.Add(this.btnSetLandingAlt);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(900, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "cruise alt";
            // 
            // txtCrzAlt
            // 
            this.txtCrzAlt.HideSelection = false;
            this.txtCrzAlt.Location = new System.Drawing.Point(131, 5);
            this.txtCrzAlt.Margin = new System.Windows.Forms.Padding(5);
            this.txtCrzAlt.Name = "txtCrzAlt";
            this.txtCrzAlt.Size = new System.Drawing.Size(164, 40);
            this.txtCrzAlt.TabIndex = 1;
            this.txtCrzAlt.Text = "test";
            this.txtCrzAlt.Enter += new System.EventHandler(this.txtCrzAlt_Enter);
            // 
            // btnSetCrzAlt
            // 
            this.btnSetCrzAlt.Location = new System.Drawing.Point(305, 5);
            this.btnSetCrzAlt.Margin = new System.Windows.Forms.Padding(5);
            this.btnSetCrzAlt.Name = "btnSetCrzAlt";
            this.btnSetCrzAlt.Size = new System.Drawing.Size(125, 38);
            this.btnSetCrzAlt.TabIndex = 2;
            this.btnSetCrzAlt.Text = "Set Crz Alt";
            this.btnSetCrzAlt.UseVisualStyleBackColor = true;
            this.btnSetCrzAlt.Click += new System.EventHandler(this.btnSetCrzAlt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Landing Alt";
            // 
            // txtLandAlt
            // 
            this.txtLandAlt.HideSelection = false;
            this.txtLandAlt.Location = new System.Drawing.Point(596, 5);
            this.txtLandAlt.Margin = new System.Windows.Forms.Padding(5);
            this.txtLandAlt.Name = "txtLandAlt";
            this.txtLandAlt.Size = new System.Drawing.Size(164, 40);
            this.txtLandAlt.TabIndex = 4;
            // 
            // btnSetLandingAlt
            // 
            this.btnSetLandingAlt.Location = new System.Drawing.Point(770, 5);
            this.btnSetLandingAlt.Margin = new System.Windows.Forms.Padding(5);
            this.btnSetLandingAlt.Name = "btnSetLandingAlt";
            this.btnSetLandingAlt.Size = new System.Drawing.Size(125, 38);
            this.btnSetLandingAlt.TabIndex = 5;
            this.btnSetLandingAlt.Text = "Set Landing Alt";
            this.btnSetLandingAlt.UseVisualStyleBackColor = true;
            this.btnSetLandingAlt.Click += new System.EventHandler(this.btnSetLandingAlt_Click);
            // 
            // ctlPressurization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ctlPressurization";
            this.Size = new System.Drawing.Size(913, 63);
            this.Load += new System.EventHandler(this.ctlPressurization_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Timer tmrPressurization;
        private IContainer components;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox txtCrzAlt;
        private Button btnSetCrzAlt;
        private Label label2;
        private TextBox txtLandAlt;
        private Button btnSetLandingAlt;
    }
}

