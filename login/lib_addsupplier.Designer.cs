namespace login
{
    partial class lib_addsupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lib_addsupplier));
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suptype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label23 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Add = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_close = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.p1 = new System.Windows.Forms.Panel();
            this.txtremark = new System.Windows.Forms.TextBox();
            this.txtconum = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsupname = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbsuptype = new System.Windows.Forms.ComboBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.p1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.supname,
            this.suptype,
            this.address,
            this.connumber,
            this.email,
            this.remark});
            this.dgv1.Location = new System.Drawing.Point(28, 377);
            this.dgv1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(1256, 283);
            this.dgv1.TabIndex = 7;
            this.dgv1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_RowHeaderMouseDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // supname
            // 
            this.supname.HeaderText = "Sup Name";
            this.supname.Name = "supname";
            this.supname.Width = 200;
            // 
            // suptype
            // 
            this.suptype.HeaderText = "Sup Type";
            this.suptype.Name = "suptype";
            this.suptype.Width = 200;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.Width = 300;
            // 
            // connumber
            // 
            this.connumber.HeaderText = "Con Number";
            this.connumber.Name = "connumber";
            this.connumber.Width = 200;
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.Width = 200;
            // 
            // remark
            // 
            this.remark.HeaderText = "Remarks";
            this.remark.Name = "remark";
            this.remark.Width = 200;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(456, 12);
            this.label23.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(163, 21);
            this.label23.TabIndex = 1;
            this.label23.Text = "ADD SUPPLIER";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GrayText;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Add,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripSeparator8,
            this.btn_Refresh,
            this.toolStripSeparator7,
            this.btn_close,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(1285, 47);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(85, 702);
            this.toolStrip1.TabIndex = 97;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Add
            // 
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(82, 28);
            this.btn_Add.Tag = "Ctrl+S";
            this.btn_Add.Text = "&Add New";
            this.btn_Add.ToolTipText = "Ctrl+S";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(82, 6);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::login.Properties.Resources.unnamed__1_;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(82, 28);
            this.toolStripButton2.Text = "&Update";
            this.toolStripButton2.ToolTipText = "Ctrl+U";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(82, 6);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::login.Properties.Resources.recycle_bin_hd_png_recycle_bin_png_580;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(82, 28);
            this.toolStripButton1.Text = "&Delete";
            this.toolStripButton1.ToolTipText = "Ctrl+D";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(82, 6);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.Image")));
            this.btn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(82, 28);
            this.btn_Refresh.Text = "&Clear";
            this.btn_Refresh.ToolTipText = "Alt+C";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(82, 6);
            // 
            // btn_close
            // 
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(82, 28);
            this.btn_close.Text = "&Close";
            this.btn_close.ToolTipText = "Alt+X";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(82, 6);
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.p1.Controls.Add(this.label23);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Location = new System.Drawing.Point(0, 0);
            this.p1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(1370, 47);
            this.p1.TabIndex = 96;
            // 
            // txtremark
            // 
            this.txtremark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtremark.Location = new System.Drawing.Point(318, 237);
            this.txtremark.Margin = new System.Windows.Forms.Padding(4);
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(306, 25);
            this.txtremark.TabIndex = 6;
            // 
            // txtconum
            // 
            this.txtconum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtconum.Location = new System.Drawing.Point(318, 158);
            this.txtconum.Margin = new System.Windows.Forms.Padding(4);
            this.txtconum.Name = "txtconum";
            this.txtconum.Size = new System.Drawing.Size(306, 25);
            this.txtconum.TabIndex = 4;
            // 
            // Label6
            // 
            this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Location = new System.Drawing.Point(232, 162);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(79, 18);
            this.Label6.TabIndex = 99;
            this.Label6.Text = "Contact No.";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(269, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 18);
            this.label15.TabIndex = 117;
            this.label15.Text = "Email";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(253, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 115;
            this.label5.Text = "Address";
            // 
            // Label19
            // 
            this.Label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label19.AutoSize = true;
            this.Label19.BackColor = System.Drawing.Color.Transparent;
            this.Label19.Location = new System.Drawing.Point(219, 86);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(92, 18);
            this.Label19.TabIndex = 112;
            this.Label19.Text = "Supplier Type";
            // 
            // txtadd
            // 
            this.txtadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtadd.Location = new System.Drawing.Point(318, 120);
            this.txtadd.Margin = new System.Windows.Forms.Padding(4);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(306, 25);
            this.txtadd.TabIndex = 3;
            // 
            // Label11
            // 
            this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Location = new System.Drawing.Point(250, 240);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(61, 18);
            this.Label11.TabIndex = 111;
            this.Label11.Text = "Remarks";
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Location = new System.Drawing.Point(213, 48);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(98, 18);
            this.Label3.TabIndex = 85;
            this.Label3.Text = "Supplier Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 98;
            this.label2.Text = "Supplier Details";
            // 
            // txtsupname
            // 
            this.txtsupname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsupname.Location = new System.Drawing.Point(318, 44);
            this.txtsupname.Margin = new System.Windows.Forms.Padding(4);
            this.txtsupname.Name = "txtsupname";
            this.txtsupname.Size = new System.Drawing.Size(306, 25);
            this.txtsupname.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.txtsupname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtadd, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Label19, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtconum, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtremark, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Label11, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbsuptype, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtemail, 1, 5);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 83);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1256, 271);
            this.tableLayoutPanel1.TabIndex = 98;
            // 
            // cmbsuptype
            // 
            this.cmbsuptype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbsuptype.FormattingEnabled = true;
            this.cmbsuptype.Items.AddRange(new object[] {
            "Book",
            "Journal and Magazine",
            "Newspaper",
            "others"});
            this.cmbsuptype.Location = new System.Drawing.Point(318, 84);
            this.cmbsuptype.Margin = new System.Windows.Forms.Padding(4);
            this.cmbsuptype.Name = "cmbsuptype";
            this.cmbsuptype.Size = new System.Drawing.Size(306, 26);
            this.cmbsuptype.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtemail.Location = new System.Drawing.Point(318, 196);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(306, 25);
            this.txtemail.TabIndex = 5;
            // 
            // lib_addsupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.p1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "lib_addsupplier";
            this.Text = "lib_addsupplier";
            this.Load += new System.EventHandler(this.lib_addsupplier_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lib_addsupplier_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btn_Refresh;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.ToolStripButton btn_Add;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btn_close;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.TextBox txtremark;
        private System.Windows.Forms.TextBox txtconum;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label Label19;
        private System.Windows.Forms.TextBox txtadd;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsupname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmbsuptype;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn supname;
        private System.Windows.Forms.DataGridViewTextBoxColumn suptype;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn connumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
    }
}