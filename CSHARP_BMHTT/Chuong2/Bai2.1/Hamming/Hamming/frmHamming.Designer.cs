namespace Hamming
{
    partial class frmHamming
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
            this.lbl16KySoHex = new System.Windows.Forms.Label();
            this.lblSoThuNhat = new System.Windows.Forms.Label();
            this.lblSoThuHai = new System.Windows.Forms.Label();
            this.lblSoHex = new System.Windows.Forms.Label();
            this.lblSoNhiPhan = new System.Windows.Forms.Label();
            this.lblTrongSoHamming = new System.Windows.Forms.Label();
            this.lblKhoangCach = new System.Windows.Forms.Label();
            this.btnTinhToan = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.picAxorB = new System.Windows.Forms.PictureBox();
            this.txtAHexStr = new System.Windows.Forms.TextBox();
            this.txtABinStr = new System.Windows.Forms.TextBox();
            this.txtBHexStr = new System.Windows.Forms.TextBox();
            this.txtBBinStr = new System.Windows.Forms.TextBox();
            this.txtATrongSo = new System.Windows.Forms.TextBox();
            this.txtBTrongSo = new System.Windows.Forms.TextBox();
            this.txtKhoangCach = new System.Windows.Forms.TextBox();
            this.txtAxorBHexStr = new System.Windows.Forms.TextBox();
            this.txtAxorBBinStr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAxorB)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl16KySoHex
            // 
            this.lbl16KySoHex.AutoSize = true;
            this.lbl16KySoHex.Location = new System.Drawing.Point(103, 66);
            this.lbl16KySoHex.Name = "lbl16KySoHex";
            this.lbl16KySoHex.Size = new System.Drawing.Size(89, 17);
            this.lbl16KySoHex.TabIndex = 0;
            this.lbl16KySoHex.Text = "16 ký số Hex";
            // 
            // lblSoThuNhat
            // 
            this.lblSoThuNhat.AutoSize = true;
            this.lblSoThuNhat.Location = new System.Drawing.Point(103, 113);
            this.lblSoThuNhat.Name = "lblSoThuNhat";
            this.lblSoThuNhat.Size = new System.Drawing.Size(17, 17);
            this.lblSoThuNhat.TabIndex = 1;
            this.lblSoThuNhat.Text = "A";
            // 
            // lblSoThuHai
            // 
            this.lblSoThuHai.AutoSize = true;
            this.lblSoThuHai.Location = new System.Drawing.Point(103, 168);
            this.lblSoThuHai.Name = "lblSoThuHai";
            this.lblSoThuHai.Size = new System.Drawing.Size(17, 17);
            this.lblSoThuHai.TabIndex = 2;
            this.lblSoThuHai.Text = "B";
            // 
            // lblSoHex
            // 
            this.lblSoHex.AutoSize = true;
            this.lblSoHex.Location = new System.Drawing.Point(315, 66);
            this.lblSoHex.Name = "lblSoHex";
            this.lblSoHex.Size = new System.Drawing.Size(109, 17);
            this.lblSoHex.TabIndex = 3;
            this.lblSoHex.Text = "Số Hexadecimal";
            // 
            // lblSoNhiPhan
            // 
            this.lblSoNhiPhan.AutoSize = true;
            this.lblSoNhiPhan.Location = new System.Drawing.Point(523, 66);
            this.lblSoNhiPhan.Name = "lblSoNhiPhan";
            this.lblSoNhiPhan.Size = new System.Drawing.Size(86, 17);
            this.lblSoNhiPhan.TabIndex = 4;
            this.lblSoNhiPhan.Text = "Số Nhị phân";
            // 
            // lblTrongSoHamming
            // 
            this.lblTrongSoHamming.AutoSize = true;
            this.lblTrongSoHamming.Location = new System.Drawing.Point(1094, 66);
            this.lblTrongSoHamming.Name = "lblTrongSoHamming";
            this.lblTrongSoHamming.Size = new System.Drawing.Size(128, 17);
            this.lblTrongSoHamming.TabIndex = 5;
            this.lblTrongSoHamming.Text = "Trọng số Hamming";
            // 
            // lblKhoangCach
            // 
            this.lblKhoangCach.AutoSize = true;
            this.lblKhoangCach.Location = new System.Drawing.Point(1084, 215);
            this.lblKhoangCach.Name = "lblKhoangCach";
            this.lblKhoangCach.Size = new System.Drawing.Size(154, 17);
            this.lblKhoangCach.TabIndex = 6;
            this.lblKhoangCach.Text = "Khoảng cách Hamming";
            // 
            // btnTinhToan
            // 
            this.btnTinhToan.Location = new System.Drawing.Point(345, 307);
            this.btnTinhToan.Name = "btnTinhToan";
            this.btnTinhToan.Size = new System.Drawing.Size(115, 39);
            this.btnTinhToan.TabIndex = 7;
            this.btnTinhToan.Text = "Tính toán";
            this.btnTinhToan.UseVisualStyleBackColor = true;
            this.btnTinhToan.Click += new System.EventHandler(this.btnTinhToan_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(514, 307);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(122, 39);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // picAxorB
            // 
            this.picAxorB.Image = global::Hamming.Properties.Resources.AxorB;
            this.picAxorB.Location = new System.Drawing.Point(106, 243);
            this.picAxorB.Name = "picAxorB";
            this.picAxorB.Size = new System.Drawing.Size(102, 60);
            this.picAxorB.TabIndex = 9;
            this.picAxorB.TabStop = false;
            // 
            // txtAHexStr
            // 
            this.txtAHexStr.Location = new System.Drawing.Point(275, 108);
            this.txtAHexStr.Name = "txtAHexStr";
            this.txtAHexStr.Size = new System.Drawing.Size(185, 22);
            this.txtAHexStr.TabIndex = 10;
            this.txtAHexStr.TextChanged += new System.EventHandler(this.txtHexStr_TextChanged);
            // 
            // txtABinStr
            // 
            this.txtABinStr.Location = new System.Drawing.Point(514, 108);
            this.txtABinStr.Name = "txtABinStr";
            this.txtABinStr.ReadOnly = true;
            this.txtABinStr.Size = new System.Drawing.Size(537, 22);
            this.txtABinStr.TabIndex = 11;
            // 
            // txtBHexStr
            // 
            this.txtBHexStr.Location = new System.Drawing.Point(275, 165);
            this.txtBHexStr.Name = "txtBHexStr";
            this.txtBHexStr.Size = new System.Drawing.Size(185, 22);
            this.txtBHexStr.TabIndex = 12;
            this.txtBHexStr.TextChanged += new System.EventHandler(this.txtHexStr_TextChanged);
            // 
            // txtBBinStr
            // 
            this.txtBBinStr.Location = new System.Drawing.Point(514, 165);
            this.txtBBinStr.Name = "txtBBinStr";
            this.txtBBinStr.ReadOnly = true;
            this.txtBBinStr.Size = new System.Drawing.Size(537, 22);
            this.txtBBinStr.TabIndex = 13;
            // 
            // txtATrongSo
            // 
            this.txtATrongSo.Location = new System.Drawing.Point(1087, 108);
            this.txtATrongSo.Name = "txtATrongSo";
            this.txtATrongSo.ReadOnly = true;
            this.txtATrongSo.Size = new System.Drawing.Size(151, 22);
            this.txtATrongSo.TabIndex = 14;
            // 
            // txtBTrongSo
            // 
            this.txtBTrongSo.Location = new System.Drawing.Point(1087, 165);
            this.txtBTrongSo.Name = "txtBTrongSo";
            this.txtBTrongSo.ReadOnly = true;
            this.txtBTrongSo.Size = new System.Drawing.Size(151, 22);
            this.txtBTrongSo.TabIndex = 15;
            // 
            // txtKhoangCach
            // 
            this.txtKhoangCach.Location = new System.Drawing.Point(1087, 251);
            this.txtKhoangCach.Name = "txtKhoangCach";
            this.txtKhoangCach.Size = new System.Drawing.Size(151, 22);
            this.txtKhoangCach.TabIndex = 16;
            // 
            // txtAxorBHexStr
            // 
            this.txtAxorBHexStr.Location = new System.Drawing.Point(275, 251);
            this.txtAxorBHexStr.Name = "txtAxorBHexStr";
            this.txtAxorBHexStr.Size = new System.Drawing.Size(185, 22);
            this.txtAxorBHexStr.TabIndex = 17;
            // 
            // txtAxorBBinStr
            // 
            this.txtAxorBBinStr.Location = new System.Drawing.Point(514, 251);
            this.txtAxorBBinStr.Name = "txtAxorBBinStr";
            this.txtAxorBBinStr.Size = new System.Drawing.Size(537, 22);
            this.txtAxorBBinStr.TabIndex = 18;
            // 
            // frmHamming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 450);
            this.Controls.Add(this.txtAxorBBinStr);
            this.Controls.Add(this.txtAxorBHexStr);
            this.Controls.Add(this.txtKhoangCach);
            this.Controls.Add(this.txtBTrongSo);
            this.Controls.Add(this.txtATrongSo);
            this.Controls.Add(this.txtBBinStr);
            this.Controls.Add(this.txtBHexStr);
            this.Controls.Add(this.txtABinStr);
            this.Controls.Add(this.txtAHexStr);
            this.Controls.Add(this.picAxorB);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTinhToan);
            this.Controls.Add(this.lblKhoangCach);
            this.Controls.Add(this.lblTrongSoHamming);
            this.Controls.Add(this.lblSoNhiPhan);
            this.Controls.Add(this.lblSoHex);
            this.Controls.Add(this.lblSoThuHai);
            this.Controls.Add(this.lblSoThuNhat);
            this.Controls.Add(this.lbl16KySoHex);
            this.Name = "frmHamming";
            this.Text = "Bài toán Hamming";
            this.Load += new System.EventHandler(this.frmHamming_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAxorB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl16KySoHex;
        private System.Windows.Forms.Label lblSoThuNhat;
        private System.Windows.Forms.Label lblSoThuHai;
        private System.Windows.Forms.Label lblSoHex;
        private System.Windows.Forms.Label lblSoNhiPhan;
        private System.Windows.Forms.Label lblTrongSoHamming;
        private System.Windows.Forms.Label lblKhoangCach;
        private System.Windows.Forms.Button btnTinhToan;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.PictureBox picAxorB;
        private System.Windows.Forms.TextBox txtAHexStr;
        private System.Windows.Forms.TextBox txtABinStr;
        private System.Windows.Forms.TextBox txtBHexStr;
        private System.Windows.Forms.TextBox txtBBinStr;
        private System.Windows.Forms.TextBox txtATrongSo;
        private System.Windows.Forms.TextBox txtBTrongSo;
        private System.Windows.Forms.TextBox txtKhoangCach;
        private System.Windows.Forms.TextBox txtAxorBHexStr;
        private System.Windows.Forms.TextBox txtAxorBBinStr;
    }
}

