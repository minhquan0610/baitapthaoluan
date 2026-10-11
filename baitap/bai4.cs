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
    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            double chiSoDau, chiSoCuoi;


            if (double.TryParse(txtchisodau.Text, out chiSoDau) && double.TryParse(txtchisocuoi.Text, out chiSoCuoi))
            {

                if (chiSoCuoi >= chiSoDau)
                {
                    double kw = chiSoCuoi - chiSoDau;
                    double thanhTien = 0;

                    if (kw <= 100)
                    {
                        thanhTien = kw * 500;
                    }
                    else if (kw <= 250)
                    {
                        thanhTien = 100 * 500 + (kw - 100) * 600;
                    }
                    else if (kw <= 300)
                    {
                        thanhTien = 100 * 500 + 150 * 600 + (kw - 250) * 800;
                    }
                    else
                    {
                        thanhTien = 100 * 500 + 150 * 600 + 50 * 800 + (kw - 300) * 1000;
                    }

                    txtsotien.Text = thanhTien.ToString("N0");
                }
                else
                {
                    MessageBox.Show("Chỉ số cuối phải lớn hơn hoặc bằng chỉ số đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtchisocuoi.Focus();
                    txtchisocuoi.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho chỉ số đầu và cuối!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtchisodau.Focus();
                txtchisodau.SelectAll();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtchisodau.Clear();
            txtchisocuoi.Clear();
            txtsotien.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
