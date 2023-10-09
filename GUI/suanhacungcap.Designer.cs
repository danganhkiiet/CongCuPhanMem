namespace GUI
{
    partial class frm_suanhacungcap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_suanhacungcap));
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_mail = new System.Windows.Forms.Label();
            this.txt_mailncc = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.txt_gmail = new System.Windows.Forms.TextBox();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.lbsdt = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.txt_diachincc = new System.Windows.Forms.TextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txt_tenncc = new System.Windows.Forms.TextBox();
            this.msg = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Wheat;
            this.btn_sua.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(417, 127);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(129, 122);
            this.btn_sua.TabIndex = 21;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Wheat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(417, 12);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(129, 109);
            this.btn_xoa.TabIndex = 22;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox16);
            this.groupBox1.Controls.Add(this.groupBox15);
            this.groupBox1.Controls.Add(this.groupBox14);
            this.groupBox1.Controls.Add(this.groupBox13);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 237);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.OldLace;
            this.groupBox2.Controls.Add(this.lb_mail);
            this.groupBox2.Controls.Add(this.txt_mailncc);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(199, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mail:";
            // 
            // lb_mail
            // 
            this.lb_mail.AutoSize = true;
            this.lb_mail.Location = new System.Drawing.Point(91, 68);
            this.lb_mail.Name = "lb_mail";
            this.lb_mail.Size = new System.Drawing.Size(84, 16);
            this.lb_mail.TabIndex = 4;
            this.lb_mail.Text = "Chưa hợp lệ!!";
            this.lb_mail.Visible = false;
            // 
            // txt_mailncc
            // 
            this.txt_mailncc.Location = new System.Drawing.Point(23, 43);
            this.txt_mailncc.Name = "txt_mailncc";
            this.txt_mailncc.Size = new System.Drawing.Size(152, 22);
            this.txt_mailncc.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.OldLace;
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Location = new System.Drawing.Point(-392, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ngày sinh:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(26, 41);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(152, 22);
            this.textBox4.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.OldLace;
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Location = new System.Drawing.Point(-200, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Số điện thoại:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(26, 41);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(152, 22);
            this.textBox5.TabIndex = 0;
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
            // groupBox15
            // 
            this.groupBox15.BackColor = System.Drawing.Color.OldLace;
            this.groupBox15.Controls.Add(this.lbsdt);
            this.groupBox15.Controls.Add(this.txt_sdt);
            this.groupBox15.Location = new System.Drawing.Point(6, 127);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(187, 100);
            this.groupBox15.TabIndex = 3;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Số điện thoại";
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Location = new System.Drawing.Point(94, 65);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(84, 16);
            this.lbsdt.TabIndex = 4;
            this.lbsdt.Text = "Chưa hợp lệ!!";
            this.lbsdt.Visible = false;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(26, 40);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(152, 22);
            this.txt_sdt.TabIndex = 0;
            this.txt_sdt.TextChanged += new System.EventHandler(this.txt_sdt_TextChanged);
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdt_KeyPress);
            // 
            // groupBox14
            // 
            this.groupBox14.BackColor = System.Drawing.Color.OldLace;
            this.groupBox14.Controls.Add(this.txt_diachincc);
            this.groupBox14.Location = new System.Drawing.Point(199, 21);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(186, 100);
            this.groupBox14.TabIndex = 4;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Địa chỉ:";
            // 
            // txt_diachincc
            // 
            this.txt_diachincc.Location = new System.Drawing.Point(26, 41);
            this.txt_diachincc.Name = "txt_diachincc";
            this.txt_diachincc.Size = new System.Drawing.Size(152, 22);
            this.txt_diachincc.TabIndex = 0;
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.Color.OldLace;
            this.groupBox13.Controls.Add(this.txt_tenncc);
            this.groupBox13.Location = new System.Drawing.Point(6, 21);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(187, 100);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Tên nhà cung cấp:";
            // 
            // txt_tenncc
            // 
            this.txt_tenncc.Location = new System.Drawing.Point(26, 41);
            this.txt_tenncc.Name = "txt_tenncc";
            this.txt_tenncc.Size = new System.Drawing.Size(152, 22);
            this.txt_tenncc.TabIndex = 0;
            // 
            // msg
            // 
            this.msg.Active = false;
            this.msg.AutoPopDelay = 500;
            this.msg.InitialDelay = 500;
            this.msg.ReshowDelay = 100;
            // 
            // frm_suanhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(553, 266);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_suanhacungcap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa nhà cung cấp:";
            this.msg.SetToolTip(this, "Vui lòng điền đúng thông tin");
            this.Load += new System.EventHandler(this.frm_suanhacungcap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_mailncc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.TextBox txt_gmail;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox txt_diachincc;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox txt_tenncc;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.Label lb_mail;
        private System.Windows.Forms.ToolTip msg;
    }
}