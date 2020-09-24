//Author : Derek Worth
//Date   : 09/21/2020
//Program: Create a program that sums up the numbers to 200, including a halfway total (100).

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sum200
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declaring integer variables
            int sum = 0;
            int topValue;

            topValue = Convert.ToInt32(txtTopValue.Text);

            // creating the For loop to run throught the summation of numbers
            for (int i = 0; i <= topValue; i++)
            {
                sum += i; //shorthand for sum = sum + i
                if (i == topValue/2) txtHalfway.Text = Convert.ToString(sum);
            }
            //Printing the sum to the textBox and converting it so it will display
            txtTotalSum.Text = Convert.ToString(sum);
        }
    }
}
