namespace tfm
{
    partial class frmFuelManager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFuel = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFuelEntry = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBlockWeight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lvFuel = new System.Windows.Forms.ListView();
            this.colTank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCapacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colpercent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlTankEntry = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTankWeight = new System.Windows.Forms.Label();
            this.txtTankWeight = new System.Windows.Forms.TextBox();
            this.btnSetFuelTank = new System.Windows.Forms.Button();
            this.tabPayload = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lvPayload = new System.Windows.Forms.ListView();
            this.colStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPayloadWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblStation = new System.Windows.Forms.Label();
            this.txtStationWeight = new System.Windows.Forms.TextBox();
            this.btnSetStation = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabFuel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.pnlFuelEntry.SuspendLayout();
            this.pnlTankEntry.SuspendLayout();
            this.tabPayload.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tabControl1);
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFuel);
            this.tabControl1.Controls.Add(this.tabPayload);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 3;
            // 
            // tabFuel
            // 
            this.tabFuel.AccessibleName = "";
            this.tabFuel.Controls.Add(this.flowLayoutPanel2);
            this.tabFuel.Location = new System.Drawing.Point(4, 22);
            this.tabFuel.Name = "tabFuel";
            this.tabFuel.Padding = new System.Windows.Forms.Padding(3);
            this.tabFuel.Size = new System.Drawing.Size(192, 74);
            this.tabFuel.TabIndex = 0;
            this.tabFuel.Text = "Fuel";
            this.tabFuel.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pnlFuelEntry);
            this.flowLayoutPanel2.Controls.Add(this.lvFuel);
            this.flowLayoutPanel2.Controls.Add(this.pnlTankEntry);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // pnlFuelEntry
            // 
            this.pnlFuelEntry.Controls.Add(this.label1);
            this.pnlFuelEntry.Controls.Add(this.txtBlockWeight);
            this.pnlFuelEntry.Controls.Add(this.btnCalculate);
            this.pnlFuelEntry.Location = new System.Drawing.Point(3, 3);
            this.pnlFuelEntry.Name = "pnlFuelEntry";
            this.pnlFuelEntry.Size = new System.Drawing.Size(200, 100);
            this.pnlFuelEntry.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Block fuel:";
            // 
            // txtBlockWeight
            // 
            this.txtBlockWeight.Location = new System.Drawing.Point(66, 3);
            this.txtBlockWeight.Name = "txtBlockWeight";
            this.txtBlockWeight.Size = new System.Drawing.Size(100, 20);
            this.txtBlockWeight.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(3, 29);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "C&alculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lvFuel
            // 
            this.lvFuel.AccessibleName = "Fuel tanks";
            this.lvFuel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTank,
            this.colWeight,
            this.colCapacity,
            this.colpercent});
            this.lvFuel.HideSelection = false;
            this.lvFuel.Location = new System.Drawing.Point(209, 3);
            this.lvFuel.Name = "lvFuel";
            this.lvFuel.Size = new System.Drawing.Size(400, 120);
            this.lvFuel.TabIndex = 3;
            this.lvFuel.UseCompatibleStateImageBehavior = false;
            this.lvFuel.View = System.Windows.Forms.View.Details;
            this.lvFuel.SelectedIndexChanged += new System.EventHandler(this.LvFuel_SelectedIndexChanged);
            // 
            // colTank
            // 
            this.colTank.Text = "Tank";
            // 
            // colWeight
            // 
            this.colWeight.Text = "Weight";
            // 
            // colCapacity
            // 
            this.colCapacity.Text = "Capacity";
            // 
            // colpercent
            // 
            this.colpercent.Text = "Percentage";
            // 
            // pnlTankEntry
            // 
            this.pnlTankEntry.Controls.Add(this.lblTankWeight);
            this.pnlTankEntry.Controls.Add(this.txtTankWeight);
            this.pnlTankEntry.Controls.Add(this.btnSetFuelTank);
            this.pnlTankEntry.Location = new System.Drawing.Point(615, 3);
            this.pnlTankEntry.Name = "pnlTankEntry";
            this.pnlTankEntry.Size = new System.Drawing.Size(200, 100);
            this.pnlTankEntry.TabIndex = 4;
            // 
            // lblTankWeight
            // 
            this.lblTankWeight.AutoSize = true;
            this.lblTankWeight.Location = new System.Drawing.Point(3, 0);
            this.lblTankWeight.Name = "lblTankWeight";
            this.lblTankWeight.Size = new System.Drawing.Size(35, 13);
            this.lblTankWeight.TabIndex = 0;
            this.lblTankWeight.Text = "label2";
            // 
            // txtTankWeight
            // 
            this.txtTankWeight.Location = new System.Drawing.Point(44, 3);
            this.txtTankWeight.Name = "txtTankWeight";
            this.txtTankWeight.Size = new System.Drawing.Size(100, 20);
            this.txtTankWeight.TabIndex = 1;
            // 
            // btnSetFuelTank
            // 
            this.btnSetFuelTank.Location = new System.Drawing.Point(3, 29);
            this.btnSetFuelTank.Name = "btnSetFuelTank";
            this.btnSetFuelTank.Size = new System.Drawing.Size(75, 23);
            this.btnSetFuelTank.TabIndex = 2;
            this.btnSetFuelTank.Text = "Set Fuel Tank";
            this.btnSetFuelTank.UseVisualStyleBackColor = true;
            this.btnSetFuelTank.Click += new System.EventHandler(this.BtnSetFuelTank_Click);
            // 
            // tabPayload
            // 
            this.tabPayload.Controls.Add(this.flowLayoutPanel3);
            this.tabPayload.Location = new System.Drawing.Point(4, 22);
            this.tabPayload.Name = "tabPayload";
            this.tabPayload.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayload.Size = new System.Drawing.Size(192, 74);
            this.tabPayload.TabIndex = 1;
            this.tabPayload.Text = "Payload";
            this.tabPayload.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.lvPayload);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // lvPayload
            // 
            this.lvPayload.AccessibleName = "Payload stations";
            this.lvPayload.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStation,
            this.colPayloadWeight});
            this.lvPayload.HideSelection = false;
            this.lvPayload.Location = new System.Drawing.Point(3, 3);
            this.lvPayload.MultiSelect = false;
            this.lvPayload.Name = "lvPayload";
            this.lvPayload.Size = new System.Drawing.Size(121, 97);
            this.lvPayload.TabIndex = 0;
            this.lvPayload.UseCompatibleStateImageBehavior = false;
            this.lvPayload.View = System.Windows.Forms.View.Details;
            this.lvPayload.SelectedIndexChanged += new System.EventHandler(this.lvPayload_SelectedIndexChanged);
            // 
            // colStation
            // 
            this.colStation.Text = "Station";
            // 
            // colPayloadWeight
            // 
            this.colPayloadWeight.Text = "Weight";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.lblStation);
            this.flowLayoutPanel4.Controls.Add(this.txtStationWeight);
            this.flowLayoutPanel4.Controls.Add(this.btnSetStation);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(130, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(3, 0);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(35, 13);
            this.lblStation.TabIndex = 0;
            this.lblStation.Text = "label2";
            // 
            // txtStationWeight
            // 
            this.txtStationWeight.Location = new System.Drawing.Point(44, 3);
            this.txtStationWeight.Name = "txtStationWeight";
            this.txtStationWeight.Size = new System.Drawing.Size(100, 20);
            this.txtStationWeight.TabIndex = 1;
            // 
            // btnSetStation
            // 
            this.btnSetStation.Location = new System.Drawing.Point(3, 29);
            this.btnSetStation.Name = "btnSetStation";
            this.btnSetStation.Size = new System.Drawing.Size(75, 23);
            this.btnSetStation.TabIndex = 2;
            this.btnSetStation.Text = "Set Payload Station";
            this.btnSetStation.UseVisualStyleBackColor = true;
            this.btnSetStation.Click += new System.EventHandler(this.btnSetStation_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(3, 109);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmFuelManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmFuelManager";
            this.Text = "Fuel and Payload Manager";
            this.Load += new System.EventHandler(this.frmFuelManager_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabFuel.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.pnlFuelEntry.ResumeLayout(false);
            this.pnlFuelEntry.PerformLayout();
            this.pnlTankEntry.ResumeLayout(false);
            this.pnlTankEntry.PerformLayout();
            this.tabPayload.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFuel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel pnlFuelEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBlockWeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListView lvFuel;
        private System.Windows.Forms.ColumnHeader colTank;
        private System.Windows.Forms.ColumnHeader colWeight;
        private System.Windows.Forms.ColumnHeader colCapacity;
        private System.Windows.Forms.ColumnHeader colpercent;
        private System.Windows.Forms.FlowLayoutPanel pnlTankEntry;
        private System.Windows.Forms.TabPage tabPayload;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ListView lvPayload;
        private System.Windows.Forms.ColumnHeader colStation;
        private System.Windows.Forms.ColumnHeader colPayloadWeight;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.TextBox txtStationWeight;
        private System.Windows.Forms.Button btnSetStation;
        private System.Windows.Forms.Label lblTankWeight;
        private System.Windows.Forms.TextBox txtTankWeight;
        private System.Windows.Forms.Button btnSetFuelTank;
        private System.Windows.Forms.Button btnClose;
    }
}