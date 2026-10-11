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
    public partial class bai7 : Form
    {
        public bai7()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            int soLuong;
            double donGia;


            if (int.TryParse(txtsoluong.Text, out soLuong) && double.TryParse(txtdongia.Text, out donGia))
            {

                if (soLuong > 0 && donGia > 0)
                {

                    double thanhTien = soLuong * donGia;


                    double vat = thanhTien * 0.10;


                    double phanTramGiamGia = rbcanhan.Checked ? 0.03 : 0.05;
                    double giamGia = thanhTien * phanTramGiamGia;


                    double tongCong = (thanhTien + vat) - giamGia;


                    txtthanhtien.Text = thanhTien.ToString("N0");
                    txtvat.Text = vat.ToString("N0");
                    txtgiamgia.Text = giamGia.ToString("N0");
                    txttongcong.Text = tongCong.ToString("N0");
                }
                else
                {
                    MessageBox.Show("Số lượng và đơn giá phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtsoluong.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho số lượng và đơn giá!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsoluong.Focus();
                txtsoluong.SelectAll();
            }
        }

        private void btntiep_Click(object sender, EventArgs e)
        {
            txttenkhach.Clear();
            txtdiachi.Clear();
            txtsoluong.Clear();
            txtdongia.Clear();
            txtthanhtien.Clear();
            txtvat.Clear();
            txtgiamgia.Clear();
            txttongcong.Clear();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
