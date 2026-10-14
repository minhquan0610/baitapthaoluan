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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bai1 f = new bai1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bai2 f = new bai2();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bai3cs f = new bai3cs();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bai4 f = new bai4();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bai5 f = new bai5();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bai6 f = new bai6();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bai7 f = new bai7();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bai8 f = new bai8();
            f.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
