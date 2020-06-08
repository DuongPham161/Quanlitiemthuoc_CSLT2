namespace QuanLyTiemThuocFinalVersion.View.NhanVien
{
    partial class FormThongKeNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMonthFrom = new System.Windows.Forms.ComboBox();
            this.cbxMonthTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dgvThongKeNhanVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê nhân viên";
            // 
            // cbxMonthFrom
            // 
            this.cbxMonthFrom.FormattingEnabled = true;
            this.cbxMonthFrom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxMonthFrom.Location = new System.Drawing.Point(18, 168);
            this.cbxMonthFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxMonthFrom.Name = "cbxMonthFrom";
            this.cbxMonthFrom.Size = new System.Drawing.Size(79, 28);
            this.cbxMonthFrom.TabIndex = 1;
            this.cbxMonthFrom.Leave += new System.EventHandler(this.cbxMonthFrom_Leave);
            // 
            // cbxMonthTo
            // 
            this.cbxMonthTo.FormattingEnabled = true;
            this.cbxMonthTo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxMonthTo.Location = new System.Drawing.Point(18, 269);
            this.cbxMonthTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxMonthTo.Name = "cbxMonthTo";
            this.cbxMonthTo.Size = new System.Drawing.Size(85, 28);
            this.cbxMonthTo.TabIndex = 2;
            this.cbxMonthTo.Leave += new System.EventHandler(this.cbxMonthTo_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đến Tháng";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(18, 340);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(87, 92);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // dgvThongKeNhanVien
            // 
            this.dgvThongKeNhanVien.AllowUserToAddRows = false;
            this.dgvThongKeNhanVien.AllowUserToDeleteRows = false;
            this.dgvThongKeNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeNhanVien.Location = new System.Drawing.Point(146, 62);
            this.dgvThongKeNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvThongKeNhanVien.Name = "dgvThongKeNhanVien";
            this.dgvThongKeNhanVien.RowHeadersWidth = 62;
            this.dgvThongKeNhanVien.Size = new System.Drawing.Size(1112, 689);
            this.dgvThongKeNhanVien.TabIndex = 6;
            // 
            // FormThongKeNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 769);
            this.Controls.Add(this.dgvThongKeNhanVien);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxMonthTo);
            this.Controls.Add(this.cbxMonthFrom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormThongKeNhanVien";
            this.Text = "FormThongKeNhanVien";
            this.Load += new System.EventHandler(this.FormThongKeNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMonthFrom;
        private System.Windows.Forms.ComboBox cbxMonthTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DataGridView dgvThongKeNhanVien;
    }
}