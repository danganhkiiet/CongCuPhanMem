namespace GUI
{
    partial class frm_suasanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_suasanpham));
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_chon = new System.Windows.Forms.Button();
            this.cbb_nhacungcap = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.txt_gmail = new System.Windows.Forms.TextBox();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txt_cpu = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txt_mau = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txt_ram = new System.Windows.Forms.TextBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.txt_von = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.txt_giaban = new System.Windows.Forms.TextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txt_tensanpham = new System.Windows.Forms.TextBox();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Wheat;
            this.btn_sua.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(465, 294);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(273, 74);
            this.btn_sua.TabIndex = 14;
            this.btn_sua.Text = "Sửa sản phẩm";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Wheat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(465, 400);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(273, 82);
            this.btn_xoa.TabIndex = 15;
            this.btn_xoa.Text = "Xóa thông tin";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_chon);
            this.groupBox5.Controls.Add(this.cbb_nhacungcap);
            this.groupBox5.Location = new System.Drawing.Point(417, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(357, 100);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chọn nhà cung cấp:";
            // 
            // btn_chon
            // 
            this.btn_chon.Location = new System.Drawing.Point(197, 33);
            this.btn_chon.Name = "btn_chon";
            this.btn_chon.Size = new System.Drawing.Size(102, 41);
            this.btn_chon.TabIndex = 4;
            this.btn_chon.Text = "Chọn";
            this.btn_chon.UseVisualStyleBackColor = true;
            // 
            // cbb_nhacungcap
            // 
            this.cbb_nhacungcap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_nhacungcap.FormattingEnabled = true;
            this.cbb_nhacungcap.Location = new System.Drawing.Point(48, 42);
            this.cbb_nhacungcap.Name = "cbb_nhacungcap";
            this.cbb_nhacungcap.Size = new System.Drawing.Size(121, 24);
            this.cbb_nhacungcap.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox16);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox15);
            this.groupBox1.Controls.Add(this.groupBox14);
            this.groupBox1.Controls.Add(this.groupBox13);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 481);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // groupBox16
            // 
            this.groupBox16.BackColor = System.Drawing.Color.OldLace;
            this.groupBox16.Controls.Add(this.txt_gmail);
            this.groupBox16.Controls.Add(this.groupBox23);
            this.groupBox16.Controls.Add(this.groupBox28);
            this.groupBox16.Location = new System.Drawing.Point(596, 21);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(200, 100);
            this.groupBox16.TabIndex = 2;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Gmail:";
            // 
            // txt_gmail
            // 
            this.txt_gmail.Location = new System.Drawing.Point(26, 41);
            this.txt_gmail.Name = "txt_gmail";
            this.txt_gmail.ReadOnly = true;
            this.txt_gmail.Size = new System.Drawing.Size(152, 22);
            this.txt_gmail.TabIndex = 0;
            // 
            // groupBox23
            // 
            this.groupBox23.BackColor = System.Drawing.Color.OldLace;
            this.groupBox23.Controls.Add(this.textBox1);
            this.groupBox23.Location = new System.Drawing.Point(-392, 0);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(186, 100);
            this.groupBox23.TabIndex = 0;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Ngày sinh:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(152, 22);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox28
            // 
            this.groupBox28.BackColor = System.Drawing.Color.OldLace;
            this.groupBox28.Controls.Add(this.textBox2);
            this.groupBox28.Location = new System.Drawing.Point(-200, 0);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(200, 100);
            this.groupBox28.TabIndex = 0;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Số điện thoại:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(152, 22);
            this.textBox2.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.OldLace;
            this.groupBox7.Controls.Add(this.txt_cpu);
            this.groupBox7.Location = new System.Drawing.Point(206, 127);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(187, 100);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "CPU";
            // 
            // txt_cpu
            // 
            this.txt_cpu.Location = new System.Drawing.Point(26, 40);
            this.txt_cpu.Name = "txt_cpu";
            this.txt_cpu.Size = new System.Drawing.Size(152, 22);
            this.txt_cpu.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.OldLace;
            this.groupBox8.Controls.Add(this.txt_mau);
            this.groupBox8.Location = new System.Drawing.Point(6, 348);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(187, 100);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Màu";
            // 
            // txt_mau
            // 
            this.txt_mau.Location = new System.Drawing.Point(26, 40);
            this.txt_mau.Name = "txt_mau";
            this.txt_mau.Size = new System.Drawing.Size(152, 22);
            this.txt_mau.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.OldLace;
            this.groupBox6.Controls.Add(this.txt_ram);
            this.groupBox6.Location = new System.Drawing.Point(6, 242);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(187, 100);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ram";
            // 
            // txt_ram
            // 
            this.txt_ram.Location = new System.Drawing.Point(26, 40);
            this.txt_ram.Name = "txt_ram";
            this.txt_ram.Size = new System.Drawing.Size(152, 22);
            this.txt_ram.TabIndex = 0;
            // 
            // groupBox15
            // 
            this.groupBox15.BackColor = System.Drawing.Color.OldLace;
            this.groupBox15.Controls.Add(this.txt_von);
            this.groupBox15.Location = new System.Drawing.Point(6, 127);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(187, 100);
            this.groupBox15.TabIndex = 3;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Vốn";
            // 
            // txt_von
            // 
            this.txt_von.Location = new System.Drawing.Point(26, 40);
            this.txt_von.Name = "txt_von";
            this.txt_von.Size = new System.Drawing.Size(152, 22);
            this.txt_von.TabIndex = 0;
            this.txt_von.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_von_KeyPress);
            // 
            // groupBox14
            // 
            this.groupBox14.BackColor = System.Drawing.Color.OldLace;
            this.groupBox14.Controls.Add(this.txt_giaban);
            this.groupBox14.Location = new System.Drawing.Point(199, 21);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(186, 100);
            this.groupBox14.TabIndex = 4;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Giá bán:";
            // 
            // txt_giaban
            // 
            this.txt_giaban.Location = new System.Drawing.Point(26, 41);
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.Size = new System.Drawing.Size(152, 22);
            this.txt_giaban.TabIndex = 0;
            this.txt_giaban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_giaban_KeyPress);
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.Color.OldLace;
            this.groupBox13.Controls.Add(this.txt_tensanpham);
            this.groupBox13.Location = new System.Drawing.Point(6, 21);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(187, 100);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Tên sản phẩm:";
            // 
            // txt_tensanpham
            // 
            this.txt_tensanpham.Location = new System.Drawing.Point(26, 41);
            this.txt_tensanpham.Name = "txt_tensanpham";
            this.txt_tensanpham.Size = new System.Drawing.Size(152, 22);
            this.txt_tensanpham.TabIndex = 0;
            // 
            // frm_suasanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_suasanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa sản phẩm";
            this.Load += new System.EventHandler(this.frm_suasanpham_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_chon;
        private System.Windows.Forms.ComboBox cbb_nhacungcap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.TextBox txt_gmail;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TextBox txt_von;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox txt_giaban;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox txt_tensanpham;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txt_cpu;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txt_mau;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txt_ram;
    }
}