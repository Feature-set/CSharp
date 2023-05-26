using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class HelloLabel : Form
    {
        public HelloLabel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ClickLabel.Text = "변경 됨";
        }

        private void HelloLabel_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            int sum1 = int.Parse(SumNum1.Text);
            int sum2 = Convert.ToInt32(SumNum2.Text);

            int sum = sum1 + sum2;
            SumAnser.Text = sum.ToString();
        }
    }
}
