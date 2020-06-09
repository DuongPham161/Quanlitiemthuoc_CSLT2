namespace QuanLyTiemThuocFinalVersion.View.HoaDonBan
{
    partial class FormBaoCaoNhanVien
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
            this.lbQuy = new System.Windows.Forms.Label();
            this.lbNam = new System.Windows.Forms.Label();
            this.cbxQuy = new System.Windows.Forms.ComboBox();
            this.dtpNam = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQuy
            // 
            this.lbQuy.AutoSize = true;
            this.lbQuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuy.Location = new System.Drawing.Point(111, 45);
            this.lbQuy.Name = "lbQuy";
            this.lbQuy.Size = new System.Drawing.Size(56, 29);
            this.lbQuy.TabIndex = 0;
            this.lbQuy.Text = "Quý";
            // 
            // lbNam
            // 
            this.lbNam.AutoSize = true;
            this.lbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNam.Location = new System.Drawing.Point(291, 44);
            this.lbNam.Name = "lbNam";
            this.lbNam.Size = new System.Drawing.Size(64, 29);
            this.lbNam.TabIndex = 1;
            this.lbNam.Text = "Năm";
            // 
            // cbxQuy
            // 
            this.cbxQuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuy.FormattingEnabled = true;
            this.cbxQuy.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxQuy.Location = new System.Drawing.Point(184, 45);
            this.cbxQuy.Name = "cbxQuy";
            this.cbxQuy.Size = new System.Drawing.Size(86, 28);
            this.cbxQuy.TabIndex = 2;
            // 
            // dtpNam
            // 
            this.dtpNam.CustomFormat = "yyyy";
            this.dtpNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNam.Location = new System.Drawing.Point(372, 46);
            this.dtpNam.Name = "dtpNam";
            this.dtpNam.Size = new System.Drawing.Size(108, 26);
            this.dtpNam.TabIndex = 3;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(508, 41);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(158, 40);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(31, 119);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 62;
            this.dgvNhanVien.RowTemplate.Height = 28;
            this.dgvNhanVien.Size = new System.Drawing.Size(880, 375);
            this.dgvNhanVien.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Báo Cáo Nhân Viên Bán Hàng";
            // 
            // FormBaoCaoNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dtpNam);
            this.Controls.Add(this.cbxQuy);
            this.Controls.Add(this.lbNam);
            this.Controls.Add(this.lbQuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBaoCaoNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQuy;
        private System.Windows.Forms.Label lbNam;
        private System.Windows.Forms.ComboBox cbxQuy;
        private System.Windows.Forms.DateTimePicker dtpNam;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label label1;
    }
}