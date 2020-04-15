namespace login
{
    partial class login_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtu = new System.Windows.Forms.TextBox();
            this.pn2 = new System.Windows.Forms.Panel();
            this.txtp = new System.Windows.Forms.TextBox();
            this.pn3 = new System.Windows.Forms.Panel();
            this.btnl = new System.Windows.Forms.Button();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 290);
            this.panel1.TabIndex = 0;
            // 
            // txtu
            // 
            this.txtu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.txtu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtu.ForeColor = System.Drawing.Color.White;
            this.txtu.Location = new System.Drawing.Point(193, 102);
            this.txtu.Name = "txtu";
            this.txtu.Size = new System.Drawing.Size(189, 15);
            this.txtu.TabIndex = 1;
            this.txtu.Text = "Username";
            // 
            // pn2
            // 
            this.pn2.BackColor = System.Drawing.Color.White;
            this.pn2.ForeColor = System.Drawing.Color.White;
            this.pn2.Location = new System.Drawing.Point(145, 128);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(250, 1);
            this.pn2.TabIndex = 4;
            // 
            // txtp
            // 
            this.txtp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.txtp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtp.ForeColor = System.Drawing.Color.White;
            this.txtp.Location = new System.Drawing.Point(193, 156);
            this.txtp.Name = "txtp";
            this.txtp.PasswordChar = '*';
            this.txtp.Size = new System.Drawing.Size(189, 15);
            this.txtp.TabIndex = 2;
            this.txtp.Text = "Password";
            // 
            // pn3
            // 
            this.pn3.BackColor = System.Drawing.Color.White;
            this.pn3.ForeColor = System.Drawing.Color.White;
            this.pn3.Location = new System.Drawing.Point(145, 177);
            this.pn3.Name = "pn3";
            this.pn3.Size = new System.Drawing.Size(250, 1);
            this.pn3.TabIndex = 7;
            // 
            // btnl
            // 
            this.btnl.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnl.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnl.ForeColor = System.Drawing.Color.Black;
            this.btnl.Location = new System.Drawing.Point(218, 223);
            this.btnl.Name = "btnl";
            this.btnl.Size = new System.Drawing.Size(100, 29);
            this.btnl.TabIndex = 3;
            this.btnl.Text = "LOGIN";
            this.btnl.UseVisualStyleBackColor = false;
            this.btnl.Click += new System.EventHandler(this.btnl_Click);
            // 
            // pb3
            // 
            this.pb3.Image = global::login.Properties.Resources.pwd;
            this.pb3.Location = new System.Drawing.Point(145, 147);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(26, 24);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 5;
            this.pb3.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Image = global::login.Properties.Resources.sss;
            this.pb1.Location = new System.Drawing.Point(218, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(100, 50);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 2;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = global::login.Properties.Resources.user;
            this.pb2.Location = new System.Drawing.Point(145, 98);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(26, 24);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(411, 290);
            this.Controls.Add(this.btnl);
            this.Controls.Add(this.pn3);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.txtu);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_form";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.TextBox txtu;
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.Panel pn3;
        private System.Windows.Forms.Button btnl;
    }
}

