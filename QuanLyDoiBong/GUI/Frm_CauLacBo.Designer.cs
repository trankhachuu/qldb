namespace QuanLyDoiBong.GUI
{
    partial class Frm_CauLacBo
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maclb = new System.Windows.Forms.TextBox();
            this.txt_tenclb = new System.Windows.Forms.TextBox();
            this.dtg_CauLacBo = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CauLacBo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Câu Lạc Bộ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Câu Lạc Bộ";
            // 
            // txt_maclb
            // 
            this.txt_maclb.Location = new System.Drawing.Point(228, 32);
            this.txt_maclb.Name = "txt_maclb";
            this.txt_maclb.Size = new System.Drawing.Size(176, 20);
            this.txt_maclb.TabIndex = 3;
            // 
            // txt_tenclb
            // 
            this.txt_tenclb.Location = new System.Drawing.Point(228, 78);
            this.txt_tenclb.Name = "txt_tenclb";
            this.txt_tenclb.Size = new System.Drawing.Size(176, 20);
            this.txt_tenclb.TabIndex = 4;
            // 
            // dtg_CauLacBo
            // 
            this.dtg_CauLacBo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_CauLacBo.Location = new System.Drawing.Point(74, 171);
            this.dtg_CauLacBo.Name = "dtg_CauLacBo";
            this.dtg_CauLacBo.Size = new System.Drawing.Size(470, 150);
            this.dtg_CauLacBo.TabIndex = 5;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(92, 123);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(350, 123);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(206, 123);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(496, 123);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // Frm_CauLacBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 375);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dtg_CauLacBo);
            this.Controls.Add(this.txt_tenclb);
            this.Controls.Add(this.txt_maclb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Frm_CauLacBo";
            this.Text = "Frm_CauLacBo";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CauLacBo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_maclb;
        public System.Windows.Forms.TextBox txt_tenclb;
        public System.Windows.Forms.DataGridView dtg_CauLacBo;
        public System.Windows.Forms.Button btn_them;
        public System.Windows.Forms.Button btn_xoa;
        public System.Windows.Forms.Button btn_sua;
        public System.Windows.Forms.Button btn_thoat;
    }
}