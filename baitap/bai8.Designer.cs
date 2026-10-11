namespace baitap
{
    partial class bai8
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsoga = new System.Windows.Forms.TextBox();
            this.txtsogb = new System.Windows.Forms.TextBox();
            this.rbuscln = new System.Windows.Forms.RadioButton();
            this.rbbscnn = new System.Windows.Forms.RadioButton();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SỐ NGUYÊN A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "SỐ NGUYÊN B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "KẾT QUẢ";
            // 
            // txtsoga
            // 
            this.txtsoga.Location = new System.Drawing.Point(129, 36);
            this.txtsoga.Name = "txtsoga";
            this.txtsoga.Size = new System.Drawing.Size(192, 22);
            this.txtsoga.TabIndex = 7;
            // 
            // txtsogb
            // 
            this.txtsogb.Location = new System.Drawing.Point(129, 76);
            this.txtsogb.Name = "txtsogb";
            this.txtsogb.Size = new System.Drawing.Size(192, 22);
            this.txtsogb.TabIndex = 8;
            // 
            // rbuscln
            // 
            this.rbuscln.AutoSize = true;
            this.rbuscln.Location = new System.Drawing.Point(27, 35);
            this.rbuscln.Name = "rbuscln";
            this.rbuscln.Size = new System.Drawing.Size(73, 20);
            this.rbuscln.TabIndex = 9;
            this.rbuscln.TabStop = true;
            this.rbuscln.Text = "USCLN";
            this.rbuscln.UseVisualStyleBackColor = true;
            // 
            // rbbscnn
            // 
            this.rbbscnn.AutoSize = true;
            this.rbbscnn.Location = new System.Drawing.Point(27, 81);
            this.rbbscnn.Name = "rbbscnn";
            this.rbbscnn.Size = new System.Drawing.Size(72, 20);
            this.rbbscnn.TabIndex = 10;
            this.rbbscnn.TabStop = true;
            this.rbbscnn.Text = "BSCLN";
            this.rbbscnn.UseVisualStyleBackColor = true;
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(187, 228);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.ReadOnly = true;
            this.txtketqua.Size = new System.Drawing.Size(192, 22);
            this.txtketqua.TabIndex = 11;
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(431, 203);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(119, 23);
            this.btntinh.TabIndex = 12;
            this.btntinh.Text = "TÌM";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(431, 250);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(119, 23);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "THOÁT";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtsoga);
            this.groupBox1.Controls.Add(this.txtsogb);
            this.groupBox1.Location = new System.Drawing.Point(32, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 115);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NHẬP DỮ LIỆU";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.rbuscln);
            this.groupBox2.Controls.Add(this.rbbscnn);
            this.groupBox2.Location = new System.Drawing.Point(431, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 115);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TÙY CHỌN";
            // 
            // bai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.label7);
            this.Name = "bai8";
            this.Text = "bai8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsoga;
        private System.Windows.Forms.TextBox txtsogb;
        private System.Windows.Forms.RadioButton rbuscln;
        private System.Windows.Forms.RadioButton rbbscnn;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}