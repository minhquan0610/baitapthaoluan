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
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double dai, rong;
    if (double.TryParse(txtcd.Text, out dai) && double.TryParse(txtcr.Text, out rong))
    {
        if (dai > 0 && rong > 0)
        {
            double chuVi = 2 * (dai + rong);
            double dienTich = dai * rong;

            txtchuvi.Text = chuVi.ToString("F2");
            txtdientich.Text = dienTich.ToString("F2");
        }
        else
        {
            MessageBox.Show("Chiều dài và chiều rộng phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtcd.Focus();
        }
    }
    else
    {
        MessageBox.Show("Vui lòng nhập số hợp lệ cho chiều dài và chiều rộng!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtcd.Focus();
        txtcd.SelectAll();
    }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtcd.Clear();
            txtcr.Clear();
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
    }
}
