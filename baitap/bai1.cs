using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r;
            if (double.TryParse(txtbk.Text, out r))
            {
                if (r > 0)
                {
                    double chuVi = 2 * Math.PI * r;
                    double dienTich = Math.PI * Math.Pow(r, 2);

                    txtchuvi.Text = chuVi.ToString("F2");
                    txtdientich.Text = dienTich.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Bán kính phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbk.Focus();
                    txtbk.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ cho bán kính!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbk.Focus();
                txtbk.SelectAll();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtbk.Clear();
            txtchuvi.Clear();
            txtdientich.Clear();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void bai1_click(object sender, EventArgs e)
        {
            bai1 frm = System.Windows.Forms.Application.OpenForms["bai1"] as bai1;

            if (frm == null)
            {
                frm = new bai1();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void txtdientich_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtchuvi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbk_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
