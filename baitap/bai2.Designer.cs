namespace baitap
{
    partial class bai2
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btntinh = new System.Windows.Forms.Button();
            this.txtdientich = new System.Windows.Forms.TextBox();
            this.txtchuvi = new System.Windows.Forms.TextBox();
            this.txtcr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(515, 352);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(88, 33);
            this.btnthoat.TabIndex = 19;
            this.btnthoat.Text = "thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(361, 352);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(91, 33);
            this.btnreset.TabIndex = 18;
            this.btnreset.Text = "làm lại";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(195, 352);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(88, 33);
            this.btntinh.TabIndex = 17;
            this.btntinh.Text = "tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // txtdientich
            // 
            this.txtdientich.Location = new System.Drawing.Point(304, 265);
            this.txtdientich.Name = "txtdientich";
            this.txtdientich.Size = new System.Drawing.Size(221, 22);
            this.txtdientich.TabIndex = 16;
            // 
            // txtchuvi
            // 
            this.txtchuvi.Location = new System.Drawing.Point(304, 222);
            this.txtchuvi.Name = "txtchuvi";
            this.txtchuvi.Size = new System.Drawing.Size(221, 22);
            this.txtchuvi.TabIndex = 15;
            // 
            // txtcr
            // 
            this.txtcr.Location = new System.Drawing.Point(304, 177);
            this.txtcr.Name = "txtcr";
            this.txtcr.Size = new System.Drawing.Size(221, 22);
            this.txtcr.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "diện tích";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "chu vi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(145, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "chiều rộng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "TÍNH CHU VI, DIỆN TÍCH HÌNH CHỮ NHẬT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(145, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "chiều dài";
            // 
            // txtcd
            // 
            this.txtcd.Location = new System.Drawing.Point(304, 134);
            this.txtcd.Name = "txtcd";
            this.txtcd.Size = new System.Drawing.Size(221, 22);
            this.txtcd.TabIndex = 21;
            // 
            // bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txtdientich);
            this.Controls.Add(this.txtchuvi);
            this.Controls.Add(this.txtcr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bai2";
            this.Text = "bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.TextBox txtdientich;
        private System.Windows.Forms.TextBox txtchuvi;
        private System.Windows.Forms.TextBox txtcr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcd;
    }
}