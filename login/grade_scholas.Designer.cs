﻿namespace login
{
    partial class add_scholastic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_scholastic));
            this.btn_close = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btn_Add = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.lbltcob = new System.Windows.Forms.Label();
            this.txtgrade = new System.Windows.Forms.TextBox();
            this.lblrc = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Panel();
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmark = new System.Windows.Forms.TextBox();
            this.marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.p1.SuspendLayout();
            this.tlp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(106, 28);
            this.btn_close.Text = "&Close";
            this.btn_close.ToolTipText = "Alt+X";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::login.Properties.Resources.recycle_bin_hd_png_recycle_bin_png_580;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(106, 28);
            this.toolStripButton1.Text = "&Delete";
            this.toolStripButton1.ToolTipText = "Ctrl+D";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::login.Properties.Resources.unnamed__1_;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(106, 28);
            this.toolStripButton2.Text = "&Update";
            this.toolStripButton2.ToolTipText = "Ctrl+U";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(106, 28);
            this.btn_Add.Tag = "Ctrl+S";
            this.btn_Add.Text = "&Add New";
            this.btn_Add.ToolTipText = "Ctrl+S";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(106, 6);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(106, 6);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(106, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(106, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(106, 6);
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
            this.toolStrip1.Location = new System.Drawing.Point(1288, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(109, 499);
            this.toolStrip1.TabIndex = 83;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.Image")));
            this.btn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(106, 28);
            this.btn_Refresh.Text = "&Clear";
            this.btn_Refresh.ToolTipText = "Alt+C";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // dgv3
            // 
            this.dgv3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marks,
            this.grade});
            this.dgv3.Location = new System.Drawing.Point(35, 199);
            this.dgv3.Margin = new System.Windows.Forms.Padding(4);
            this.dgv3.Name = "dgv3";
            this.dgv3.Size = new System.Drawing.Size(1225, 337);
            this.dgv3.TabIndex = 80;
            // 
            // lbltcob
            // 
            this.lbltcob.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbltcob.AutoSize = true;
            this.lbltcob.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltcob.ForeColor = System.Drawing.Color.White;
            this.lbltcob.Location = new System.Drawing.Point(746, 40);
            this.lbltcob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltcob.Name = "lbltcob";
            this.lbltcob.Size = new System.Drawing.Size(58, 23);
            this.lbltcob.TabIndex = 12;
            this.lbltcob.Text = "Grade";
            // 
            // txtgrade
            // 
            this.txtgrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtgrade.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrade.Location = new System.Drawing.Point(812, 37);
            this.txtgrade.Margin = new System.Windows.Forms.Padding(4);
            this.txtgrade.Name = "txtgrade";
            this.txtgrade.Size = new System.Drawing.Size(194, 30);
            this.txtgrade.TabIndex = 2;
            // 
            // lblrc
            // 
            this.lblrc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblrc.AutoSize = true;
            this.lblrc.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrc.Location = new System.Drawing.Point(491, 9);
            this.lblrc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrc.Name = "lblrc";
            this.lblrc.Size = new System.Drawing.Size(553, 27);
            this.lblrc.TabIndex = 54;
            this.lblrc.Text = "GRADING SCALE FOR SCHOLASTIC AREAS";
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.p1.Controls.Add(this.lblrc);
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Location = new System.Drawing.Point(0, 0);
            this.p1.Margin = new System.Windows.Forms.Padding(4);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(1397, 50);
            this.p1.TabIndex = 81;
            // 
            // tlp1
            // 
            this.tlp1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp1.ColumnCount = 6;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.68023F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.68023F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.01871F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.26037F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.68023F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.68023F));
            this.tlp1.Controls.Add(this.txtmark, 0, 0);
            this.tlp1.Controls.Add(this.label1, 0, 0);
            this.tlp1.Controls.Add(this.lbltcob, 3, 0);
            this.tlp1.Controls.Add(this.txtgrade, 4, 0);
            this.tlp1.Location = new System.Drawing.Point(35, 70);
            this.tlp1.Margin = new System.Windows.Forms.Padding(4);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 1;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.06639F));
            this.tlp1.Size = new System.Drawing.Size(1215, 104);
            this.tlp1.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(137, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Marks";
            // 
            // txtmark
            // 
            this.txtmark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmark.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmark.Location = new System.Drawing.Point(206, 37);
            this.txtmark.Margin = new System.Windows.Forms.Padding(4);
            this.txtmark.Name = "txtmark";
            this.txtmark.Size = new System.Drawing.Size(194, 30);
            this.txtmark.TabIndex = 1;
            // 
            // marks
            // 
            this.marks.HeaderText = "Marks";
            this.marks.Name = "marks";
            this.marks.Width = 400;
            // 
            // grade
            // 
            this.grade.FillWeight = 400F;
            this.grade.HeaderText = "Grade";
            this.grade.Name = "grade";
            this.grade.Width = 400;
            // 
            // add_scholastic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1397, 549);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv3);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.tlp1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "add_scholastic";
            this.Text = "add_scholastic";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.add_scholastic_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            this.tlp1.ResumeLayout(false);
            this.tlp1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btn_close;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton btn_Add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Refresh;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.Label lbltcob;
        private System.Windows.Forms.TextBox txtgrade;
        private System.Windows.Forms.Label lblrc;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.DataGridViewTextBoxColumn marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.TextBox txtmark;
        private System.Windows.Forms.Label label1;
    }
}