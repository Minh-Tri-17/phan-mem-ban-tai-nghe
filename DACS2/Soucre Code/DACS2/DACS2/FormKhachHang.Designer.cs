﻿
namespace DACS2
{
    partial class FormKhachHang
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btxS = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnX = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnT = new System.Windows.Forms.Button();
            this.txtTKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxL = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1281, 283);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.txtMKH);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btxS);
            this.panel2.Controls.Add(this.btnL);
            this.panel2.Controls.Add(this.txtDC);
            this.panel2.Controls.Add(this.txtSDT);
            this.panel2.Controls.Add(this.btnX);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnT);
            this.panel2.Controls.Add(this.txtTKH);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbxL);
            this.panel2.Location = new System.Drawing.Point(12, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1235, 219);
            this.panel2.TabIndex = 31;
            // 
            // txtMKH
            // 
            this.txtMKH.BackColor = System.Drawing.Color.Silver;
            this.txtMKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMKH.Enabled = false;
            this.txtMKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKH.ForeColor = System.Drawing.Color.White;
            this.txtMKH.Location = new System.Drawing.Point(208, 6);
            this.txtMKH.Margin = new System.Windows.Forms.Padding(5);
            this.txtMKH.Name = "txtMKH";
            this.txtMKH.Size = new System.Drawing.Size(119, 30);
            this.txtMKH.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(410, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa Chỉ:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mã Khách Hàng:";
            // 
            // btxS
            // 
            this.btxS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(171)))), ((int)(((byte)(152)))));
            this.btxS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btxS.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxS.ForeColor = System.Drawing.Color.White;
            this.btxS.Location = new System.Drawing.Point(527, 158);
            this.btxS.Margin = new System.Windows.Forms.Padding(4);
            this.btxS.Name = "btxS";
            this.btxS.Size = new System.Drawing.Size(186, 52);
            this.btxS.TabIndex = 13;
            this.btxS.Text = "SỬA";
            this.btxS.UseVisualStyleBackColor = false;
            this.btxS.Click += new System.EventHandler(this.btxS_Click);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(171)))), ((int)(((byte)(152)))));
            this.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.ForeColor = System.Drawing.Color.White;
            this.btnL.Location = new System.Drawing.Point(923, 29);
            this.btnL.Margin = new System.Windows.Forms.Padding(4);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(285, 36);
            this.btnL.TabIndex = 23;
            this.btnL.Text = "CHỌN LOẠI TÀI KHOẢN";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // txtDC
            // 
            this.txtDC.BackColor = System.Drawing.Color.White;
            this.txtDC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDC.ForeColor = System.Drawing.Color.Black;
            this.txtDC.Location = new System.Drawing.Point(615, 75);
            this.txtDC.Margin = new System.Windows.Forms.Padding(5);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(273, 30);
            this.txtDC.TabIndex = 8;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.White;
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.Location = new System.Drawing.Point(208, 76);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(5);
            this.txtSDT.MaxLength = 10;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(192, 30);
            this.txtSDT.TabIndex = 27;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(171)))), ((int)(((byte)(152)))));
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(1035, 158);
            this.btnX.Margin = new System.Windows.Forms.Padding(4);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(186, 52);
            this.btnX.TabIndex = 12;
            this.btnX.Text = "XÓA";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 26);
            this.label6.TabIndex = 26;
            this.label6.Text = "Số Điện Thoại:";
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(171)))), ((int)(((byte)(152)))));
            this.btnT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.ForeColor = System.Drawing.Color.White;
            this.btnT.Location = new System.Drawing.Point(6, 158);
            this.btnT.Margin = new System.Windows.Forms.Padding(4);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(186, 52);
            this.btnT.TabIndex = 11;
            this.btnT.Text = "THÊM";
            this.btnT.UseVisualStyleBackColor = false;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // txtTKH
            // 
            this.txtTKH.BackColor = System.Drawing.Color.White;
            this.txtTKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTKH.ForeColor = System.Drawing.Color.Black;
            this.txtTKH.Location = new System.Drawing.Point(615, 5);
            this.txtTKH.Margin = new System.Windows.Forms.Padding(5);
            this.txtTKH.Name = "txtTKH";
            this.txtTKH.Size = new System.Drawing.Size(273, 30);
            this.txtTKH.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(410, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Khách Hàng:";
            // 
            // cbxL
            // 
            this.cbxL.BackColor = System.Drawing.Color.White;
            this.cbxL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxL.ForeColor = System.Drawing.Color.Black;
            this.cbxL.FormattingEnabled = true;
            this.cbxL.Location = new System.Drawing.Point(923, 74);
            this.cbxL.Margin = new System.Windows.Forms.Padding(5);
            this.cbxL.Name = "cbxL";
            this.cbxL.Size = new System.Drawing.Size(285, 30);
            this.cbxL.TabIndex = 9;
            this.cbxL.Click += new System.EventHandler(this.cbxL_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 35);
            this.label5.TabIndex = 30;
            this.label5.Text = "Khách Hàng";
            // 
            // dgvKH
            // 
            this.dgvKH.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Location = new System.Drawing.Point(12, 291);
            this.dgvKH.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.Size = new System.Drawing.Size(1235, 341);
            this.dgvKH.TabIndex = 30;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1281, 658);
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btxS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.ComboBox cbxL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
    }
}