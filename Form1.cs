//Moshoaliba,K-34316345

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_own
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
         try
            {
                int sInput;
                int sInput1;
                int sInput2;

                sInput = int.Parse(txtInput.Text);
                sInput1 = int.Parse(txtInput2.Text);
                sInput2 = int.Parse(txtInput3.Text);

                int minimum = Math.Min(sInput, sInput1);
                int minimum1 = Math.Min(minimum, sInput2);
                int maximum = Math.Max(sInput, sInput1);
                int maximum1 = Math.Max(maximum, sInput2);

                int mean = (sInput + sInput1 + sInput2) / 4;

                lblOutput.Text = "The MINIMUM value is  " + minimum1 + ".";
                lblOutput2.Text = "The MAXIMUM value is  " + maximum1 + ".";
                lblOutput3.Text = "The MEAN is , " + mean + ", between the three values entered.";

                pbMath.Show();

                lblOutput4.Text = "THANK YOU!!!";
            }
          catch (Exception)
            {
                MessageBox.Show("Please enter in a correct format");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbMath.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            lblOutput2.Text = "";
            lblOutput3.Text = "";
            lblOutput4.Text = "";

            txtInput.Text = "";
            txtInput2.Text = "";
            txtInput3.Text = "";

            pbMath.Hide();
        }
    }
}
