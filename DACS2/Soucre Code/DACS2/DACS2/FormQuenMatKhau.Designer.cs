
namespace DACS2
{
    partial class FormQuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuenMatKhau));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.txtMKM = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.txtTDN = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.buttonCN = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbTieuDe);
            this.panel1.Controls.Add(this.txtMKM);
            this.panel1.Controls.Add(this.txtE);
            this.panel1.Controls.Add(this.txtTDN);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 321);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(120, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 95);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(128)))), ((int)(((byte)(105)))));
            this.lbTieuDe.Location = new System.Drawing.Point(97, 35);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(159, 27);
            this.lbTieuDe.TabIndex = 8;
            this.lbTieuDe.Text = "Quên mật khẩu";
            // 
            // txtMKM
            // 
            this.txtMKM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(128)))), ((int)(((byte)(105)))));
            this.txtMKM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMKM.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtMKM.Location = new System.Drawing.Point(88, 280);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.PasswordChar = '*';
            this.txtMKM.Size = new System.Drawing.Size(182, 29);
            this.txtMKM.TabIndex = 7;
            this.txtMKM.Text = "Mật khẩu mới";
            this.txtMKM.Click += new System.EventHandler(this.txtMKM_Click);
            this.txtMKM.Leave += new System.EventHandler(this.txtMKM_Leave);
            // 
            // txtE
            // 
            this.txtE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(128)))), ((int)(((byte)(105)))));
            this.txtE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtE.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtE.Location = new System.Drawing.Point(88, 245);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(182, 29);
            this.txtE.TabIndex = 5;
            this.txtE.Text = "Email";
            this.txtE.Click += new System.EventHandler(this.txtE_Click);
            this.txtE.Leave += new System.EventHandler(this.txtE_Leave);
            // 
            // txtTDN
            // 
            this.txtTDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(128)))), ((int)(((byte)(105)))));
            this.txtTDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTDN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtTDN.Location = new System.Drawing.Point(88, 175);
            this.txtTDN.Name = "txtTDN";
            this.txtTDN.Size = new System.Drawing.Size(182, 29);
            this.txtTDN.TabIndex = 2;
            this.txtTDN.Text = "Tên đăng nhập";
            this.txtTDN.Click += new System.EventHandler(this.txtTDN_Click);
            this.txtTDN.Leave += new System.EventHandler(this.txtTDN_Leave);
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(128)))), ((int)(((byte)(105)))));
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtSDT.Location = new System.Drawing.Point(88, 210);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(182, 29);
            this.txtSDT.TabIndex = 3;
            this.txtSDT.Text = "Số điện thoại";
            this.txtSDT.Click += new System.EventHandler(this.txtSDT_Click);
            this.txtSDT.Leave += new System.EventHandler(this.txtSDT_Leave);
            // 
            // buttonCN
            // 
            this.buttonCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(56)))), ((int)(((byte)(38)))));
            this.buttonCN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.buttonCN.Location = new System.Drawing.Point(88, 358);
            this.buttonCN.Name = "buttonCN";
            this.buttonCN.Size = new System.Drawing.Size(182, 32);
            this.buttonCN.TabIndex = 6;
            this.buttonCN.Text = "CẬP NHẬT";
            this.buttonCN.UseVisualStyleBackColor = false;
            this.buttonCN.Click += new System.EventHandler(this.buttonCN_Click);
            // 
            // buttonT
            // 
            this.buttonT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(56)))), ((int)(((byte)(38)))));
            this.buttonT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.buttonT.Location = new System.Drawing.Point(88, 411);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(182, 32);
            this.buttonT.TabIndex = 7;
            this.buttonT.Text = "THOÁT";
            this.buttonT.UseVisualStyleBackColor = false;
            this.buttonT.Click += new System.EventHandler(this.buttonT_Click);
            // 
            // FormQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(359, 455);
            this.Controls.Add(this.buttonT);
            this.Controls.Add(this.buttonCN);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quên mật khẩu";
            this.Load += new System.EventHandler(this.FormQuenMatKhau_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.TextBox txtTDN;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button buttonCN;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.TextBox txtMKM;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}