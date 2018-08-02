using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, sum;

            n1 = Convert.ToInt32(txtFirstNumber.Text);
            n2 = Convert.ToInt32(txtSecondNumber.Text);

            sum = n1 + n2;

            lblResult.Text = sum.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int n1, n2, sum;

            n1 = Convert.ToInt32(txtFirstNumber.Text);
            n2 = Convert.ToInt32(txtSecondNumber.Text);

            sum = n1 - n2;

            lblResult.Text = sum.ToString();
        }        
    }
}
