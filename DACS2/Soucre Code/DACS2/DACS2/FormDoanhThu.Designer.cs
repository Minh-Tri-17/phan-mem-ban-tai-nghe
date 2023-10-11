
namespace DACS2
{
    partial class FormDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtGN = new System.Windows.Forms.TextBox();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.btnL = new System.Windows.Forms.Button();
            this.cbxN = new System.Windows.Forms.ComboBox();
            this.btnLBD = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNNT = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxT = new System.Windows.Forms.ComboBox();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbLBD = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDT = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBody.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDT)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLN
            // 
            this.txtLN.BackColor = System.Drawing.Color.White;
            this.txtLN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLN.ForeColor = System.Drawing.Color.Red;
            this.txtLN.Location = new System.Drawing.Point(246, 126);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(202, 27);
            this.txtLN.TabIndex = 45;
            // 
            // txtGN
            // 
            this.txtGN.BackColor = System.Drawing.Color.White;
            this.txtGN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGN.ForeColor = System.Drawing.Color.Red;
            this.txtGN.Location = new System.Drawing.Point(246, 65);
            this.txtGN.Name = "txtGN";
            this.txtGN.Size = new System.Drawing.Size(202, 27);
            this.txtGN.TabIndex = 44;
            // 
            // txtTT
            // 
            this.txtTT.BackColor = System.Drawing.Color.White;
            this.txtTT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTT.ForeColor = System.Drawing.Color.Red;
            this.txtTT.Location = new System.Drawing.Point(255, 11);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(193, 27);
            this.txtTT.TabIndex = 43;
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(171)))), ((int)(((byte)(152)))));
            this.btnL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.ForeColor = System.Drawing.Color.White;
            this.btnL.Location = new System.Drawing.Point(136, 441);
            this.btnL.Margin = new System.Windows.Forms.Padding(4);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(186, 41);
            this.btnL.TabIndex = 41;
            this.btnL.Text = "LỌC DỮ LIỆU";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // cbxN
            // 
            this.cbxN.BackColor = System.Drawing.Color.White;
            this.cbxN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cbxN.FormattingEnabled = true;
            this.cbxN.Location = new System.Drawing.Point(286, 286);
            this.cbxN.Margin = new System.Windows.Forms.Padding(4);
            this.cbxN.Name = "cbxN";
            this.cbxN.Size = new System.Drawing.Size(155, 30);
            this.cbxN.TabIndex = 39;
            // 
            // btnLBD
            // 
            this.btnLBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(171)))), ((int)(((byte)(152)))));
            this.btnLBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLBD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLBD.ForeColor = System.Drawing.Color.White;
            this.btnLBD.Location = new System.Drawing.Point(342, 441);
            this.btnLBD.Margin = new System.Windows.Forms.Padding(4);
            this.btnLBD.Name = "btnLBD";
            this.btnLBD.Size = new System.Drawing.Size(186, 41);
            this.btnLBD.TabIndex = 38;
            this.btnLBD.Text = "BIỂU ĐỒ THÁNG";
            this.btnLBD.UseVisualStyleBackColor = false;
            this.btnLBD.Click += new System.EventHandler(this.btnLBD_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 376);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 35);
            this.label6.TabIndex = 36;
            this.label6.Text = "Doanh Thu:";
            // 
            // txtTDT
            // 
            this.txtTDT.BackColor = System.Drawing.Color.White;
            this.txtTDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTDT.Enabled = false;
            this.txtTDT.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDT.ForeColor = System.Drawing.Color.Black;
            this.txtTDT.Location = new System.Drawing.Point(176, 372);
            this.txtTDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtTDT.Name = "txtTDT";
            this.txtTDT.Size = new System.Drawing.Size(265, 39);
            this.txtTDT.TabIndex = 37;
            this.txtTDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ngày:";
            // 
            // cbxNNT
            // 
            this.cbxNNT.BackColor = System.Drawing.Color.White;
            this.cbxNNT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxNNT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNNT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cbxNNT.FormattingEnabled = true;
            this.cbxNNT.Location = new System.Drawing.Point(98, 210);
            this.cbxNNT.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNNT.Name = "cbxNNT";
            this.cbxNNT.Size = new System.Drawing.Size(343, 30);
            this.cbxNNT.TabIndex = 34;
            this.cbxNNT.Click += new System.EventHandler(this.cbxNNT_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(5, 252);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 26);
            this.label11.TabIndex = 33;
            this.label11.Text = "Tháng:";
            // 
            // cbxT
            // 
            this.cbxT.BackColor = System.Drawing.Color.White;
            this.cbxT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cbxT.FormattingEnabled = true;
            this.cbxT.Location = new System.Drawing.Point(98, 248);
            this.cbxT.Margin = new System.Windows.Forms.Padding(4);
            this.cbxT.Name = "cbxT";
            this.cbxT.Size = new System.Drawing.Size(343, 30);
            this.cbxT.TabIndex = 32;
            this.cbxT.Click += new System.EventHandler(this.cbxT_Click);
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Controls.Add(this.panel4);
            this.panelBody.Controls.Add(this.panel3);
            this.panelBody.Controls.Add(this.dgvDT);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 72);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1362, 853);
            this.panelBody.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.chart1);
            this.panel4.Controls.Add(this.btnLBD);
            this.panel4.Controls.Add(this.lbLBD);
            this.panel4.Location = new System.Drawing.Point(494, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(849, 504);
            this.panel4.TabIndex = 48;
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Gainsboro;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 43);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(139)))))};
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "DoanhThu";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(835, 377);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "BIỂU ĐỒ";
            this.chart1.Titles.Add(title1);
            // 
            // lbLBD
            // 
            this.lbLBD.AutoSize = true;
            this.lbLBD.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLBD.ForeColor = System.Drawing.Color.Black;
            this.lbLBD.Location = new System.Drawing.Point(291, 3);
            this.lbLBD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLBD.Name = "lbLBD";
            this.lbLBD.Size = new System.Drawing.Size(386, 37);
            this.lbLBD.TabIndex = 39;
            this.lbLBD.Text = "BIỂU ĐỒ THEO THÁNG";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtTDT);
            this.panel3.Controls.Add(this.cbxNNT);
            this.panel3.Controls.Add(this.cbxT);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnL);
            this.panel3.Controls.Add(this.cbxN);
            this.panel3.Location = new System.Drawing.Point(12, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 504);
            this.panel3.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtLN);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTT);
            this.panel2.Controls.Add(this.txtGN);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 172);
            this.panel2.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 26);
            this.label5.TabIndex = 45;
            this.label5.Text = "TỔNG LỢI NHUẬN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 26);
            this.label4.TabIndex = 44;
            this.label4.Text = "TỔNG GIÁ NHẬP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "TỔNG DOANH THU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 290);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 26);
            this.label2.TabIndex = 40;
            this.label2.Text = "Biểu Đồ Theo Từng Năm:";
            // 
            // dgvDT
            // 
            this.dgvDT.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDT.Location = new System.Drawing.Point(12, 516);
            this.dgvDT.Name = "dgvDT";
            this.dgvDT.RowHeadersWidth = 51;
            this.dgvDT.Size = new System.Drawing.Size(1331, 299);
            this.dgvDT.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 72);
            this.panel1.TabIndex = 0;
            // 
            // FormDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 925);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormDoanhThu";
            this.Text = "Doanh Thu";
            this.Load += new System.EventHandler(this.FormDoanhThu_Load);
            this.panelBody.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.DataGridView dgvDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNNT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTDT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnLBD;
        private System.Windows.Forms.Label lbLBD;
        private System.Windows.Forms.ComboBox cbxN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxT;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.TextBox txtGN;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}