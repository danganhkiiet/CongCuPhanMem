namespace GUI
{
    partial class frm_donhangdatao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_donhangdatao));
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.dtg_donhangdatao = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tennhanvien = new System.Windows.Forms.TextBox();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_donhangdatao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.dtg_donhangdatao);
            this.groupBox19.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox19.Location = new System.Drawing.Point(12, 51);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(782, 279);
            this.groupBox19.TabIndex = 4;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Danh sách đơn hàng đã tạo:";
            // 
            // dtg_donhangdatao
            // 
            this.dtg_donhangdatao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_donhangdatao.Location = new System.Drawing.Point(6, 26);
            this.dtg_donhangdatao.Name = "dtg_donhangdatao";
            this.dtg_donhangdatao.RowHeadersWidth = 51;
            this.dtg_donhangdatao.RowTemplate.Height = 24;
            this.dtg_donhangdatao.Size = new System.Drawing.Size(770, 238);
            this.dtg_donhangdatao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đơn hàng đã tạo của nhân viên: ";
            // 
            // txt_tennhanvien
            // 
            this.txt_tennhanvien.Location = new System.Drawing.Point(279, 8);
            this.txt_tennhanvien.Name = "txt_tennhanvien";
            this.txt_tennhanvien.Size = new System.Drawing.Size(151, 22);
            this.txt_tennhanvien.TabIndex = 6;
            // 
            // frm_donhangdatao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(800, 333);
            this.Controls.Add(this.txt_tennhanvien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox19);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_donhangdatao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đơn hàng đã tạo của nhân viên";
            this.Load += new System.EventHandler(this.frm_donhangdatao_Load);
            this.groupBox19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_donhangdatao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.DataGridView dtg_donhangdatao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tennhanvien;
    }
}