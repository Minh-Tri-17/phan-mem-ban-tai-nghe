
namespace DACS2
{
    partial class FormBanHang
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
            this.dgvBH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXSP = new System.Windows.Forms.Button();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTT = new System.Windows.Forms.Button();
            this.txtMSP = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTSL = new System.Windows.Forms.Button();
            this.cmbCR = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMBH = new System.Windows.Forms.TextBox();
            this.btnCMR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBH)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBH
            // 
            this.dgvBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBH.Location = new System.Drawing.Point(0, 105);
            this.dgvBH.Name = "dgvBH";
            this.dgvBH.Size = new System.Drawing.Size(1041, 377);
            this.dgvBH.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(56)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã bán hàng";
            // 
            // btnXSP
            // 
            this.btnXSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(56)))), ((int)(((byte)(38)))));
            this.btnXSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXSP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.btnXSP.Location = new System.Drawing.Point(733, 15);
            this.btnXSP.Name = "btnXSP";
            this.btnXSP.Size = new System.Drawing.Size(151, 35);
            this.btnXSP.TabIndex = 11;
            this.btnXSP.Text = "XÓA SẢN PHẨM";
            this.btnXSP.UseVisualStyleBackColor = false;
            this.btnXSP.Click += new System.EventHandler(this.btnXSP_Click);
            // 
            // txtTT
            // 
            this.txtTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(56)))), ((int)(((byte)(38)))));
            this.txtTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTT.Enabled = false;
            this.txtTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtTT.Location = new System.Drawing.Point(859, 488);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(149, 26);
            this.txtTT.TabIndex = 13;
            this.txtTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(56)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(788, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tổng tiền";
            // 
            // btnTT
            // 
            this.btnTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(56)))), ((int)(((byte)(38)))));
            this.btnTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.btnTT.Location = new System.Drawing.Point(890, 15);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(151, 35);
            this.btnTT.TabIndex = 15;
            this.btnTT.Text = "THANH TOÁN";
            this.btnTT.UseVisualStyleBackColor = false;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // txtMSP
            // 
            this.txtMSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(56)))), ((int)(((byte)(38)))));
            this.txtMSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMSP.Enabled = false;
            this.txtMSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtMSP.Location = new System.Drawing.Point(451, 15);
            this.txtMSP.Name = "txtMSP";
            this.txtMSP.Size = new System.Drawing.Size(87, 26);
            this.txtMSP.TabIndex = 16;
            this.txtMSP.TextChanged += new System.EventHandler(this.txtMSP_TextChanged);
            // 
            // txtSL
            // 
            this.txtSL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(128)))), ((int)(((byte)(105)))));
            this.txtSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtSL.Location = new System.Drawing.Point(275, 15);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(73, 26);
            this.txtSL.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(56)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(354, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(56)))), ((int)(((byte)(38)))));
            this.label4.Location = new System.Drawing.Point(205, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số lượng";
            // 
            // btnTSL
            // 
            this.btnTSL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(56)))), ((int)(((byte)(38)))));
            this.btnTSL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTSL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTSL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTSL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.btnTSL.Location = new System.Drawing.Point(576, 15);
            this.btnTSL.Name = "btnTSL";
            this.btnTSL.Size = new System.Drawing.Size(151, 35);
            this.btnTSL.TabIndex = 20;
            this.btnTSL.Text = "THÊM SỐ LƯỢNG";
            this.btnTSL.UseVisualStyleBackColor = false;
            this.btnTSL.Click += new System.EventHandler(this.btnTSL_Click);
            // 
            // cmbCR
            // 
            this.cmbCR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(128)))), ((int)(((byte)(105)))));
            this.cmbCR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cmbCR.FormattingEnabled = true;
            this.cmbCR.Location = new System.Drawing.Point(102, 49);
            this.cmbCR.Name = "cmbCR";
            this.cmbCR.Size = new System.Drawing.Size(343, 28);
            this.cmbCR.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(56)))), ((int)(((byte)(38)))));
            this.label5.Location = new System.Drawing.Point(39, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Camera";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.btnCMR);
            this.panel1.Controls.Add(this.txtMBH);
            this.panel1.Controls.Add(this.btnTSL);
            this.panel1.Controls.Add(this.btnTT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbCR);
            this.panel1.Controls.Add(this.btnXSP);
            this.panel1.Controls.Add(this.txtMSP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 99);
            this.panel1.TabIndex = 23;
            // 
            // txtMBH
            // 
            this.txtMBH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(56)))), ((int)(((byte)(38)))));
            this.txtMBH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMBH.Enabled = false;
            this.txtMBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMBH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtMBH.Location = new System.Drawing.Point(102, 15);
            this.txtMBH.Name = "txtMBH";
            this.txtMBH.Size = new System.Drawing.Size(97, 26);
            this.txtMBH.TabIndex = 25;
            // 
            // btnCMR
            // 
            this.btnCMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(56)))), ((int)(((byte)(38)))));
            this.btnCMR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCMR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCMR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCMR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.btnCMR.Location = new System.Drawing.Point(890, 56);
            this.btnCMR.Name = "btnCMR";
            this.btnCMR.Size = new System.Drawing.Size(151, 35);
            this.btnCMR.TabIndex = 26;
            this.btnCMR.Text = "TẮT CAMERA";
            this.btnCMR.UseVisualStyleBackColor = false;
            this.btnCMR.Click += new System.EventHandler(this.btnCMR_Click);
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(221)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1053, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.dgvBH);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Name = "FormBanHang";
            this.Text = "BÁN HÀNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBanHang_FormClosing);
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXSP;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.TextBox txtMSP;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTSL;
        private System.Windows.Forms.ComboBox cmbCR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMBH;
        private System.Windows.Forms.Button btnCMR;
    }
}