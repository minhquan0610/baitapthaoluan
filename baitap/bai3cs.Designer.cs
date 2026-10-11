namespace baitap
{
    partial class bai3cs
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
            this.btndongy = new System.Windows.Forms.Button();
            this.txtxeploai = new System.Windows.Forms.TextBox();
            this.txthkii = new System.Windows.Forms.TextBox();
            this.txthki = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // btndongy
            // 
            this.btndongy.Location = new System.Drawing.Point(195, 352);
            this.btndongy.Name = "btndongy";
            this.btndongy.Size = new System.Drawing.Size(88, 33);
            this.btndongy.TabIndex = 17;
            this.btndongy.Text = "đồng ý";
            this.btndongy.UseVisualStyleBackColor = true;
            this.btndongy.Click += new System.EventHandler(this.btndongy_Click);
            // 
            // txtxeploai
            // 
            this.txtxeploai.Location = new System.Drawing.Point(304, 265);
            this.txtxeploai.Name = "txtxeploai";
            this.txtxeploai.Size = new System.Drawing.Size(221, 22);
            this.txtxeploai.TabIndex = 16;
            // 
            // txthkii
            // 
            this.txthkii.Location = new System.Drawing.Point(304, 207);
            this.txthkii.Name = "txthkii";
            this.txthkii.Size = new System.Drawing.Size(221, 22);
            this.txthkii.TabIndex = 15;
            // 
            // txthki
            // 
            this.txthki.Location = new System.Drawing.Point(304, 147);
            this.txthki.Name = "txthki";
            this.txthki.Size = new System.Drawing.Size(221, 22);
            this.txthki.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "XẾP LOẠI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "ĐIỂM HỌC KỲ II";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(145, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "ĐIỂM HỌC KỲ I";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "XẾP LOẠI HỌC TẬP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bai3cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btndongy);
            this.Controls.Add(this.txtxeploai);
            this.Controls.Add(this.txthkii);
            this.Controls.Add(this.txthki);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bai3cs";
            this.Text = "bai3cs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btndongy;
        private System.Windows.Forms.TextBox txtxeploai;
        private System.Windows.Forms.TextBox txthkii;
        private System.Windows.Forms.TextBox txthki;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}