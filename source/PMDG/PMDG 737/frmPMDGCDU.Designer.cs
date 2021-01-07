namespace tfm
{
    partial class frmPMDGCDU
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
            this.txtCDU = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cduGrid = new System.Windows.Forms.DataGridView();
            this.leftColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnN1Limit = new System.Windows.Forms.Button();
            this.btnExec = new System.Windows.Forms.Button();
            this.btnProg = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.btnDepArr = new System.Windows.Forms.Button();
            this.btnLegs = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnDes = new System.Windows.Forms.Button();
            this.btnCrz = new System.Windows.Forms.Button();
            this.btnClb = new System.Windows.Forms.Button();
            this.btnRte = new System.Windows.Forms.Button();
            this.btnInitRef = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cduGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.txtCDU);
            this.flowLayoutPanel1.Controls.Add(this.btnRefresh);
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Controls.Add(this.cduGrid);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(969, 172);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txtCDU
            // 
            this.txtCDU.Location = new System.Drawing.Point(5, 5);
            this.txtCDU.Margin = new System.Windows.Forms.Padding(5);
            this.txtCDU.Multiline = true;
            this.txtCDU.Name = "txtCDU";
            this.txtCDU.ReadOnly = true;
            this.txtCDU.Size = new System.Drawing.Size(497, 162);
            this.txtCDU.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(512, 5);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(125, 38);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(645, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear Scratchpad";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cduGrid
            // 
            this.cduGrid.AccessibleName = "PMDG 737 CDU";
            this.cduGrid.AllowUserToAddRows = false;
            this.cduGrid.AllowUserToDeleteRows = false;
            this.cduGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cduGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leftColumn,
            this.rightColumn});
            this.cduGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cduGrid.Location = new System.Drawing.Point(726, 3);
            this.cduGrid.Name = "cduGrid";
            this.cduGrid.ReadOnly = true;
            this.cduGrid.Size = new System.Drawing.Size(240, 150);
            this.cduGrid.TabIndex = 3;
            this.cduGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.cduGrid_CellEnter);
            // 
            // leftColumn
            // 
            this.leftColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.leftColumn.HeaderText = "";
            this.leftColumn.Name = "leftColumn";
            this.leftColumn.ReadOnly = true;
            this.leftColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.leftColumn.Width = 5;
            // 
            // rightColumn
            // 
            this.rightColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rightColumn.HeaderText = "";
            this.rightColumn.Name = "rightColumn";
            this.rightColumn.ReadOnly = true;
            this.rightColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rightColumn.Width = 5;
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(5, 175);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(100, 29);
            this.txtEntry.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(111, 175);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(5, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 147);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnNext, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnPrev, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnFix, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnN1Limit, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnExec, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnProg, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnHold, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDepArr, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLegs, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMenu, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCrz, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClb, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRte, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInitRef, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 116);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(165, 90);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next Page";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(84, 90);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 13;
            this.btnPrev.Text = "Prev Page";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(3, 90);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(75, 23);
            this.btnFix.TabIndex = 12;
            this.btnFix.Text = "&Fix";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnN1Limit
            // 
            this.btnN1Limit.Location = new System.Drawing.Point(246, 61);
            this.btnN1Limit.Name = "btnN1Limit";
            this.btnN1Limit.Size = new System.Drawing.Size(75, 23);
            this.btnN1Limit.TabIndex = 11;
            this.btnN1Limit.Text = "&N1 Limit";
            this.btnN1Limit.UseVisualStyleBackColor = true;
            this.btnN1Limit.Click += new System.EventHandler(this.btnN1Limit_Click);
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(165, 61);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(75, 23);
            this.btnExec.TabIndex = 10;
            this.btnExec.Text = "&Exec";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click_1);
            // 
            // btnProg
            // 
            this.btnProg.Location = new System.Drawing.Point(84, 61);
            this.btnProg.Name = "btnProg";
            this.btnProg.Size = new System.Drawing.Size(75, 23);
            this.btnProg.TabIndex = 9;
            this.btnProg.Text = "&Prog";
            this.btnProg.UseVisualStyleBackColor = true;
            this.btnProg.Click += new System.EventHandler(this.btnProg_Click);
            // 
            // btnHold
            // 
            this.btnHold.Location = new System.Drawing.Point(3, 61);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(75, 23);
            this.btnHold.TabIndex = 8;
            this.btnHold.Text = "&Hold";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnDepArr
            // 
            this.btnDepArr.Location = new System.Drawing.Point(246, 32);
            this.btnDepArr.Name = "btnDepArr";
            this.btnDepArr.Size = new System.Drawing.Size(75, 23);
            this.btnDepArr.TabIndex = 7;
            this.btnDepArr.Text = "&Dep Arr";
            this.btnDepArr.UseVisualStyleBackColor = true;
            this.btnDepArr.Click += new System.EventHandler(this.btnDepArr_Click);
            // 
            // btnLegs
            // 
            this.btnLegs.Location = new System.Drawing.Point(165, 32);
            this.btnLegs.Name = "btnLegs";
            this.btnLegs.Size = new System.Drawing.Size(75, 23);
            this.btnLegs.TabIndex = 6;
            this.btnLegs.Text = "Le&gs";
            this.btnLegs.UseVisualStyleBackColor = true;
            this.btnLegs.Click += new System.EventHandler(this.btnLegs_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(84, 32);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "&Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnDes
            // 
            this.btnDes.Location = new System.Drawing.Point(3, 32);
            this.btnDes.Name = "btnDes";
            this.btnDes.Size = new System.Drawing.Size(75, 23);
            this.btnDes.TabIndex = 4;
            this.btnDes.UseVisualStyleBackColor = true;
            this.btnDes.Click += new System.EventHandler(this.btnDes_Click);
            // 
            // btnCrz
            // 
            this.btnCrz.Location = new System.Drawing.Point(246, 3);
            this.btnCrz.Name = "btnCrz";
            this.btnCrz.Size = new System.Drawing.Size(75, 23);
            this.btnCrz.TabIndex = 3;
            this.btnCrz.Text = "CR&Z";
            this.btnCrz.UseVisualStyleBackColor = true;
            this.btnCrz.Click += new System.EventHandler(this.btnCrz_Click);
            // 
            // btnClb
            // 
            this.btnClb.Location = new System.Drawing.Point(165, 3);
            this.btnClb.Name = "btnClb";
            this.btnClb.Size = new System.Drawing.Size(75, 23);
            this.btnClb.TabIndex = 2;
            this.btnClb.Text = "&CLB";
            this.btnClb.UseVisualStyleBackColor = true;
            this.btnClb.Click += new System.EventHandler(this.btnClb_Click);
            // 
            // btnRte
            // 
            this.btnRte.Location = new System.Drawing.Point(84, 3);
            this.btnRte.Name = "btnRte";
            this.btnRte.Size = new System.Drawing.Size(75, 23);
            this.btnRte.TabIndex = 1;
            this.btnRte.Text = "&RTE";
            this.btnRte.UseVisualStyleBackColor = true;
            this.btnRte.Click += new System.EventHandler(this.btnRte_Click);
            // 
            // btnInitRef
            // 
            this.btnInitRef.Location = new System.Drawing.Point(3, 3);
            this.btnInitRef.Name = "btnInitRef";
            this.btnInitRef.Size = new System.Drawing.Size(75, 23);
            this.btnInitRef.TabIndex = 0;
            this.btnInitRef.Text = "INIT REF";
            this.btnInitRef.UseVisualStyleBackColor = true;
            this.btnInitRef.Click += new System.EventHandler(this.btnInitRef_Click);
            // 
            // frmPMDGCDU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1333, 743);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPMDGCDU";
            this.Text = "737 CDU";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CDUForm_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cduGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtCDU;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnN1Limit;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Button btnProg;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button btnDepArr;
        private System.Windows.Forms.Button btnLegs;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnDes;
        private System.Windows.Forms.Button btnCrz;
        private System.Windows.Forms.Button btnClb;
        private System.Windows.Forms.Button btnRte;
        private System.Windows.Forms.Button btnInitRef;
        private System.Windows.Forms.DataGridView cduGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightColumn;
    }
}

