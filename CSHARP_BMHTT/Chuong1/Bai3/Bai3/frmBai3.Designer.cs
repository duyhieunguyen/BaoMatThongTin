﻿namespace Bai3
{
    partial class frmBai3
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
            this.gbLoaiKhoa = new System.Windows.Forms.GroupBox();
            this.rbChu = new System.Windows.Forms.RadioButton();
            this.rbSo = new System.Windows.Forms.RadioButton();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.gbPhuongPhapMa = new System.Windows.Forms.GroupBox();
            this.rbDuongCheo = new System.Windows.Forms.RadioButton();
            this.rbDongVaCot = new System.Windows.Forms.RadioButton();
            this.lblBanTinRo = new System.Windows.Forms.Label();
            this.lblBanTinDuocMaHoa = new System.Windows.Forms.Label();
            this.lblBanTinDuocGiaiMa = new System.Windows.Forms.Label();
            this.txtBanTinRo = new System.Windows.Forms.TextBox();
            this.txtBanTinDuocMaHoa = new System.Windows.Forms.TextBox();
            this.txtBanTinDuocGiaiMa = new System.Windows.Forms.TextBox();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.btnGiaiMa = new System.Windows.Forms.Button();
            this.gbLoaiKhoa.SuspendLayout();
            this.gbPhuongPhapMa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLoaiKhoa
            // 
            this.gbLoaiKhoa.Controls.Add(this.rbChu);
            this.gbLoaiKhoa.Controls.Add(this.rbSo);
            this.gbLoaiKhoa.Controls.Add(this.txtMaKhoa);
            this.gbLoaiKhoa.Location = new System.Drawing.Point(32, 39);
            this.gbLoaiKhoa.Name = "gbLoaiKhoa";
            this.gbLoaiKhoa.Size = new System.Drawing.Size(723, 64);
            this.gbLoaiKhoa.TabIndex = 0;
            this.gbLoaiKhoa.TabStop = false;
            this.gbLoaiKhoa.Text = "Loại khóa";
            // 
            // rbChu
            // 
            this.rbChu.AutoSize = true;
            this.rbChu.Location = new System.Drawing.Point(191, 27);
            this.rbChu.Name = "rbChu";
            this.rbChu.Size = new System.Drawing.Size(54, 21);
            this.rbChu.TabIndex = 2;
            this.rbChu.Text = "Chữ";
            this.rbChu.UseVisualStyleBackColor = true;
            this.rbChu.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbSo
            // 
            this.rbSo.AutoSize = true;
            this.rbSo.Checked = true;
            this.rbSo.Location = new System.Drawing.Point(26, 27);
            this.rbSo.Name = "rbSo";
            this.rbSo.Size = new System.Drawing.Size(46, 21);
            this.rbSo.TabIndex = 1;
            this.rbSo.TabStop = true;
            this.rbSo.Text = "Số";
            this.rbSo.UseVisualStyleBackColor = true;
            this.rbSo.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(367, 26);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(190, 22);
            this.txtMaKhoa.TabIndex = 0;
            this.txtMaKhoa.TextChanged += new System.EventHandler(this.txtMaKhoa_TextChanged);
            // 
            // gbPhuongPhapMa
            // 
            this.gbPhuongPhapMa.Controls.Add(this.rbDuongCheo);
            this.gbPhuongPhapMa.Controls.Add(this.rbDongVaCot);
            this.gbPhuongPhapMa.Location = new System.Drawing.Point(32, 128);
            this.gbPhuongPhapMa.Name = "gbPhuongPhapMa";
            this.gbPhuongPhapMa.Size = new System.Drawing.Size(723, 64);
            this.gbPhuongPhapMa.TabIndex = 1;
            this.gbPhuongPhapMa.TabStop = false;
            this.gbPhuongPhapMa.Text = "Phương pháp mã";
            // 
            // rbDuongCheo
            // 
            this.rbDuongCheo.AutoSize = true;
            this.rbDuongCheo.Location = new System.Drawing.Point(191, 29);
            this.rbDuongCheo.Name = "rbDuongCheo";
            this.rbDuongCheo.Size = new System.Drawing.Size(141, 21);
            this.rbDuongCheo.TabIndex = 3;
            this.rbDuongCheo.Text = "Theo đường chéo";
            this.rbDuongCheo.UseVisualStyleBackColor = true;
            // 
            // rbDongVaCot
            // 
            this.rbDongVaCot.AutoSize = true;
            this.rbDongVaCot.Checked = true;
            this.rbDongVaCot.Location = new System.Drawing.Point(26, 29);
            this.rbDongVaCot.Name = "rbDongVaCot";
            this.rbDongVaCot.Size = new System.Drawing.Size(105, 21);
            this.rbDongVaCot.TabIndex = 2;
            this.rbDongVaCot.TabStop = true;
            this.rbDongVaCot.Text = "Dòng và cột";
            this.rbDongVaCot.UseVisualStyleBackColor = true;
            // 
            // lblBanTinRo
            // 
            this.lblBanTinRo.AutoSize = true;
            this.lblBanTinRo.Location = new System.Drawing.Point(29, 227);
            this.lblBanTinRo.Name = "lblBanTinRo";
            this.lblBanTinRo.Size = new System.Drawing.Size(69, 17);
            this.lblBanTinRo.TabIndex = 2;
            this.lblBanTinRo.Text = "Bản tin rõ";
            // 
            // lblBanTinDuocMaHoa
            // 
            this.lblBanTinDuocMaHoa.AutoSize = true;
            this.lblBanTinDuocMaHoa.Location = new System.Drawing.Point(29, 276);
            this.lblBanTinDuocMaHoa.Name = "lblBanTinDuocMaHoa";
            this.lblBanTinDuocMaHoa.Size = new System.Drawing.Size(138, 17);
            this.lblBanTinDuocMaHoa.TabIndex = 3;
            this.lblBanTinDuocMaHoa.Text = "Bản tin được mã hóa";
            // 
            // lblBanTinDuocGiaiMa
            // 
            this.lblBanTinDuocGiaiMa.AutoSize = true;
            this.lblBanTinDuocGiaiMa.Location = new System.Drawing.Point(29, 322);
            this.lblBanTinDuocGiaiMa.Name = "lblBanTinDuocGiaiMa";
            this.lblBanTinDuocGiaiMa.Size = new System.Drawing.Size(136, 17);
            this.lblBanTinDuocGiaiMa.TabIndex = 4;
            this.lblBanTinDuocGiaiMa.Text = "Bản tin được giải mã";
            // 
            // txtBanTinRo
            // 
            this.txtBanTinRo.Location = new System.Drawing.Point(223, 222);
            this.txtBanTinRo.Name = "txtBanTinRo";
            this.txtBanTinRo.Size = new System.Drawing.Size(532, 22);
            this.txtBanTinRo.TabIndex = 5;
            this.txtBanTinRo.TextChanged += new System.EventHandler(this.txtBanTinRo_TextChanged);
            // 
            // txtBanTinDuocMaHoa
            // 
            this.txtBanTinDuocMaHoa.Location = new System.Drawing.Point(223, 271);
            this.txtBanTinDuocMaHoa.Name = "txtBanTinDuocMaHoa";
            this.txtBanTinDuocMaHoa.Size = new System.Drawing.Size(532, 22);
            this.txtBanTinDuocMaHoa.TabIndex = 6;
            this.txtBanTinDuocMaHoa.TextChanged += new System.EventHandler(this.txtBanTinDuocMaHoa_TextChanged);
            // 
            // txtBanTinDuocGiaiMa
            // 
            this.txtBanTinDuocGiaiMa.Location = new System.Drawing.Point(223, 317);
            this.txtBanTinDuocGiaiMa.Name = "txtBanTinDuocGiaiMa";
            this.txtBanTinDuocGiaiMa.Size = new System.Drawing.Size(532, 22);
            this.txtBanTinDuocGiaiMa.TabIndex = 7;
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Enabled = false;
            this.btnMaHoa.Location = new System.Drawing.Point(251, 370);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(75, 23);
            this.btnMaHoa.TabIndex = 8;
            this.btnMaHoa.Text = "Mã hóa";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Enabled = false;
            this.btnGiaiMa.Location = new System.Drawing.Point(477, 370);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(75, 23);
            this.btnGiaiMa.TabIndex = 9;
            this.btnGiaiMa.Text = "Giải mã";
            this.btnGiaiMa.UseVisualStyleBackColor = true;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGiaiMa);
            this.Controls.Add(this.btnMaHoa);
            this.Controls.Add(this.txtBanTinDuocGiaiMa);
            this.Controls.Add(this.txtBanTinDuocMaHoa);
            this.Controls.Add(this.txtBanTinRo);
            this.Controls.Add(this.lblBanTinDuocGiaiMa);
            this.Controls.Add(this.lblBanTinDuocMaHoa);
            this.Controls.Add(this.lblBanTinRo);
            this.Controls.Add(this.gbPhuongPhapMa);
            this.Controls.Add(this.gbLoaiKhoa);
            this.Name = "frmBai3";
            this.Text = "Bài toán 3";
            this.gbLoaiKhoa.ResumeLayout(false);
            this.gbLoaiKhoa.PerformLayout();
            this.gbPhuongPhapMa.ResumeLayout(false);
            this.gbPhuongPhapMa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLoaiKhoa;
        private System.Windows.Forms.RadioButton rbChu;
        private System.Windows.Forms.RadioButton rbSo;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.GroupBox gbPhuongPhapMa;
        private System.Windows.Forms.RadioButton rbDuongCheo;
        private System.Windows.Forms.RadioButton rbDongVaCot;
        private System.Windows.Forms.Label lblBanTinRo;
        private System.Windows.Forms.Label lblBanTinDuocMaHoa;
        private System.Windows.Forms.Label lblBanTinDuocGiaiMa;
        private System.Windows.Forms.TextBox txtBanTinRo;
        private System.Windows.Forms.TextBox txtBanTinDuocMaHoa;
        private System.Windows.Forms.TextBox txtBanTinDuocGiaiMa;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.Button btnGiaiMa;
    }
}

