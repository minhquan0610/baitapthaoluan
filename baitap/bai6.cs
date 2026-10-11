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
    public partial class bai6 : Form
    {
        public bai6()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double csharp, truyenthong, nguonmo, quantrimang;

            if (double.TryParse(txtcsharp.Text, out csharp) &&
                double.TryParse(txttruyenthong.Text, out truyenthong) &&
                double.TryParse(txtnguonmo.Text, out nguonmo) &&
                double.TryParse(txtquantrimang.Text, out quantrimang))
            {
                if (csharp >= 0 && csharp <= 10 &&
                    truyenthong >= 0 && truyenthong <= 10 &&
                    nguonmo >= 0 && nguonmo <= 10 &&
                    quantrimang >= 0 && quantrimang <= 10)
                {
                    double dtb = (csharp + truyenthong + nguonmo + quantrimang) / 4.0;
                    txtdtb.Text = dtb.ToString("F2");

                    string xeploai = "";

                    if (dtb >= 8.0)
                    {
                        xeploai = "Giỏi";
                    }
                    else if (dtb >= 7.0)
                    {
                        xeploai = "Khá";
                    }
                    else if (dtb >= 5.0)
                    {
                        xeploai = "Trung bình";
                    }
                    else
                    {
                        xeploai = "Yếu";
                    }

                    txtxeploai.Text = xeploai;
                }
                else
                {
                    MessageBox.Show("Điểm số các môn phải nằm trong khoảng từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập điểm số hợp lệ cho tất cả các môn!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntieptuc_Click(object sender, EventArgs e)
        {
            txtmasv.Clear();
            txthoten.Clear();
            txtcsharp.Clear();
            txttruyenthong.Clear();
            txtnguonmo.Clear();
            txtquantrimang.Clear();
            txtdtb.Clear();
            txtxeploai.Clear();
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
