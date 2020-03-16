namespace Bai1
{
    partial class frmBaiToan1
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
            this.lblSoViTri = new System.Windows.Forms.Label();
            this.lblBanTinDuocMaHoa = new System.Windows.Forms.Label();
            this.lblBanTinRo = new System.Windows.Forms.Label();
            this.lblBanTinDuocGiaiMa = new System.Windows.Forms.Label();
            this.txtBanTinRo = new System.Windows.Forms.TextBox();
            this.txtBanTinDuocMaHoa = new System.Windows.Forms.TextBox();
            this.txtBanTinDuocGiaiMa = new System.Windows.Forms.TextBox();
            this.nudSoViTri = new System.Windows.Forms.NumericUpDown();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.btnGiaiMa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoViTri)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSoViTri
            // 
            this.lblSoViTri.AutoSize = true;
            this.lblSoViTri.Location = new System.Drawing.Point(118, 93);
            this.lblSoViTri.Name = "lblSoViTri";
            this.lblSoViTri.Size = new System.Drawing.Size(55, 17);
            this.lblSoViTri.TabIndex = 0;
            this.lblSoViTri.Text = "Số vị trí";
            // 
            // lblBanTinDuocMaHoa
            // 
            this.lblBanTinDuocMaHoa.AutoSize = true;
            this.lblBanTinDuocMaHoa.Location = new System.Drawing.Point(118, 219);
            this.lblBanTinDuocMaHoa.Name = "lblBanTinDuocMaHoa";
            this.lblBanTinDuocMaHoa.Size = new System.Drawing.Size(138, 17);
            this.lblBanTinDuocMaHoa.TabIndex = 1;
            this.lblBanTinDuocMaHoa.Text = "Bản tin được mã hóa";
            // 
            // lblBanTinRo
            // 
            this.lblBanTinRo.AutoSize = true;
            this.lblBanTinRo.Location = new System.Drawing.Point(118, 156);
            this.lblBanTinRo.Name = "lblBanTinRo";
            this.lblBanTinRo.Size = new System.Drawing.Size(69, 17);
            this.lblBanTinRo.TabIndex = 2;
            this.lblBanTinRo.Text = "Bản tin rõ";
            // 
            // lblBanTinDuocGiaiMa
            // 
            this.lblBanTinDuocGiaiMa.AutoSize = true;
            this.lblBanTinDuocGiaiMa.Location = new System.Drawing.Point(118, 279);
            this.lblBanTinDuocGiaiMa.Name = "lblBanTinDuocGiaiMa";
            this.lblBanTinDuocGiaiMa.Size = new System.Drawing.Size(136, 17);
            this.lblBanTinDuocGiaiMa.TabIndex = 3;
            this.lblBanTinDuocGiaiMa.Text = "Bản tin được giải mã";
            // 
            // txtBanTinRo
            // 
            this.txtBanTinRo.Location = new System.Drawing.Point(332, 150);
            this.txtBanTinRo.Name = "txtBanTinRo";
            this.txtBanTinRo.Size = new System.Drawing.Size(283, 22);
            this.txtBanTinRo.TabIndex = 4;
            this.txtBanTinRo.TextChanged += new System.EventHandler(this.txtBanTinRo_TextChanged);
            // 
            // txtBanTinDuocMaHoa
            // 
            this.txtBanTinDuocMaHoa.Location = new System.Drawing.Point(332, 214);
            this.txtBanTinDuocMaHoa.Name = "txtBanTinDuocMaHoa";
            this.txtBanTinDuocMaHoa.Size = new System.Drawing.Size(283, 22);
            this.txtBanTinDuocMaHoa.TabIndex = 5;
            this.txtBanTinDuocMaHoa.TextChanged += new System.EventHandler(this.txtBanTinDuocMaHoa_TextChanged);
            // 
            // txtBanTinDuocGiaiMa
            // 
            this.txtBanTinDuocGiaiMa.Location = new System.Drawing.Point(332, 274);
            this.txtBanTinDuocGiaiMa.Name = "txtBanTinDuocGiaiMa";
            this.txtBanTinDuocGiaiMa.Size = new System.Drawing.Size(283, 22);
            this.txtBanTinDuocGiaiMa.TabIndex = 6;
            // 
            // nudSoViTri
            // 
            this.nudSoViTri.Location = new System.Drawing.Point(332, 87);
            this.nudSoViTri.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudSoViTri.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoViTri.Name = "nudSoViTri";
            this.nudSoViTri.Size = new System.Drawing.Size(234, 22);
            this.nudSoViTri.TabIndex = 7;
            this.nudSoViTri.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Enabled = false;
            this.btnMaHoa.Location = new System.Drawing.Point(332, 330);
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
            this.btnGiaiMa.Location = new System.Drawing.Point(540, 330);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(75, 23);
            this.btnGiaiMa.TabIndex = 9;
            this.btnGiaiMa.Text = "Giải mã";
            this.btnGiaiMa.UseVisualStyleBackColor = true;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // frmBaiToan1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGiaiMa);
            this.Controls.Add(this.btnMaHoa);
            this.Controls.Add(this.nudSoViTri);
            this.Controls.Add(this.txtBanTinDuocGiaiMa);
            this.Controls.Add(this.txtBanTinDuocMaHoa);
            this.Controls.Add(this.txtBanTinRo);
            this.Controls.Add(this.lblBanTinDuocGiaiMa);
            this.Controls.Add(this.lblBanTinRo);
            this.Controls.Add(this.lblBanTinDuocMaHoa);
            this.Controls.Add(this.lblSoViTri);
            this.Name = "frmBaiToan1";
            this.Text = "Bài toán 1";
            this.Load += new System.EventHandler(this.frmBaiToan1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoViTri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoViTri;
        private System.Windows.Forms.Label lblBanTinDuocMaHoa;
        private System.Windows.Forms.Label lblBanTinRo;
        private System.Windows.Forms.Label lblBanTinDuocGiaiMa;
        private System.Windows.Forms.TextBox txtBanTinRo;
        private System.Windows.Forms.TextBox txtBanTinDuocMaHoa;
        private System.Windows.Forms.TextBox txtBanTinDuocGiaiMa;
        private System.Windows.Forms.NumericUpDown nudSoViTri;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.Button btnGiaiMa;
    }
}

