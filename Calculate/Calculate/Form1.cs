using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Num1 = Convert.ToInt32(textBox1.Text);
            int Num2 = Convert.ToInt32(textBox2.Text);
            int result = Num1 + Num2;
            label1.Text = "Result is " + result.ToString();
        }
    }
}
