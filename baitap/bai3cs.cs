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
    public partial class bai3cs : Form
    {
        public bai3cs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            double hki, hkii;


            if (double.TryParse(txthki.Text, out hki) && double.TryParse(txthkii.Text, out hkii))
            {

                if (hki >= 0 && hki <= 10 && hkii >= 0 && hkii <= 10)
                {
                    double dtb = (hki + hkii * 2) / 3;

                    string xeploai = "";

                    if (dtb >= 8.0)
                    {
                        xeploai = "Giỏi";
                    }
                    else if (dtb >= 6.5)
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
                    MessageBox.Show("Điểm số các học kỳ phải nằm trong khoảng từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txthki.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập điểm số hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthki.Focus();
                txthki.SelectAll();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txthki.Clear();
            txthkii.Clear();
            txtxeploai.Clear();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
