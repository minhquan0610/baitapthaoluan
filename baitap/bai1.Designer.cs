namespace baitap
{
    partial class bai1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbk = new System.Windows.Forms.TextBox();
            this.txtchuvi = new System.Windows.Forms.TextBox();
            this.txtdientich = new System.Windows.Forms.TextBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÍNH CHU VI, DIỆN TÍCH HÌNH TRÒN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(127, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "bán kính";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "chu vi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "diện tích";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtbk
            // 
            this.txtbk.Location = new System.Drawing.Point(286, 108);
            this.txtbk.Name = "txtbk";
            this.txtbk.Size = new System.Drawing.Size(221, 22);
            this.txtbk.TabIndex = 4;
            this.txtbk.TextChanged += new System.EventHandler(this.txtbk_TextChanged);
            // 
            // txtchuvi
            // 
            this.txtchuvi.Location = new System.Drawing.Point(286, 168);
            this.txtchuvi.Name = "txtchuvi";
            this.txtchuvi.Size = new System.Drawing.Size(221, 22);
            this.txtchuvi.TabIndex = 5;
            this.txtchuvi.TextChanged += new System.EventHandler(this.txtchuvi_TextChanged);
            // 
            // txtdientich
            // 
            this.txtdientich.Location = new System.Drawing.Point(286, 226);
            this.txtdientich.Name = "txtdientich";
            this.txtdientich.Size = new System.Drawing.Size(221, 22);
            this.txtdientich.TabIndex = 6;
            this.txtdientich.TextChanged += new System.EventHandler(this.txtdientich_TextChanged);
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(177, 313);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(88, 33);
            this.btntinh.TabIndex = 7;
            this.btntinh.Text = "tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(343, 313);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(91, 33);
            this.btnreset.TabIndex = 8;
            this.btnreset.Text = "làm lại";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(497, 313);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(88, 33);
            this.btnthoat.TabIndex = 9;
            this.btnthoat.Text = "thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txtdientich);
            this.Controls.Add(this.txtchuvi);
            this.Controls.Add(this.txtbk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bai1";
            this.Text = "bai1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbk;
        private System.Windows.Forms.TextBox txtchuvi;
        private System.Windows.Forms.TextBox txtdientich;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnthoat;
    }
}

