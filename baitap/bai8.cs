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
    public partial class bai8 : Form
    {
        public bai8()
        {
            InitializeComponent();
        }
        private int TinhUSCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private long TinhBSCNN(int a, int b)
        {
            if (a == 0 || b == 0) return 0;
            int uscln = TinhUSCLN(a, b);
            return Math.Abs((long)a * b) / uscln;
        }
        private void btntinh_Click(object sender, EventArgs e)
        {
            int a, b;

            if (int.TryParse(txtsoga.Text, out a) && int.TryParse(txtsogb.Text, out b))
            {
                if (a == 0 && b == 0)
                {
                    MessageBox.Show("Cả hai số a và b không thể đồng thời bằng 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtsoga.Focus();
                    return;
                }

                if (rbuscln.Checked)
                {
                    int uscln = TinhUSCLN(a, b);
                    txtketqua.Text = uscln.ToString();
                }
                else if (rbbscnn.Checked)
                {
                    long bscnn = TinhBSCNN(a, b);
                    txtketqua.Text = bscnn.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tùy chọn USCLN hoặc BSCNN!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho a và b!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsoga.Focus();
                txtsoga.SelectAll();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
