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
    public partial class bai5 : Form
    {
        public bai5()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double chiSoMoi, chiSoCu;

            if (double.TryParse(txtchisomoi.Text, out chiSoMoi) && double.TryParse(txtchisocu.Text, out chiSoCu))
            {
                if (chiSoMoi >= chiSoCu)
                {

                    double soKw = chiSoMoi - chiSoCu;
                    txtsokw.Text = soKw.ToString();

                    double donGia = 0;
                    if (rbcanhan.Checked)
                    {
                        donGia = 5000;
                    }
                    else if (rbcoquan.Checked)
                    {
                        donGia = 6000;
                    }

                    double thanhTien = soKw * donGia;
                    double vat = thanhTien * 0.10;
                    double tongCong = thanhTien + vat;

                    txtthanhtien.Text = thanhTien.ToString("N0");
                    txtvat.Text = vat.ToString("N0");
                    txttongcong.Text = tongCong.ToString("N0");
                }
                else
                {
                    MessageBox.Show("Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtchisomoi.Focus();
                    txtchisomoi.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho chỉ số mới và cũ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtchisomoi.Focus();
                txtchisomoi.SelectAll();
            }
        }

        private void btntieptuc_Click(object sender, EventArgs e)
        {
            txttenkhach.Clear();
            txtchisomoi.Clear();
            txtchisocu.Clear();
            txtsokw.Clear();
            txtthanhtien.Clear();
            txtvat.Clear();
            txttongcong.Clear();

            rbcanhan.Checked = true;
            txtchisomoi.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtchisomoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
