using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {

   
        public Calculator()
        {
            InitializeComponent();
        }


        double firstnumber = 0;
        double secondnumber = 0;
        

        private void addButton_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(firstnumberTextBox.Text);
            secondnumber = Convert.ToDouble(secondnumberTextBox.Text);
            resultTextBox.Text= (firstnumber + secondnumber).ToString();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(firstnumberTextBox.Text);
            secondnumber = Convert.ToDouble(secondnumberTextBox.Text);
            resultTextBox.Text = (firstnumber - secondnumber).ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(firstnumberTextBox.Text);
            secondnumber = Convert.ToDouble(secondnumberTextBox.Text);
            resultTextBox.Text = (firstnumber * secondnumber).ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(firstnumberTextBox.Text);
            secondnumber = Convert.ToDouble(secondnumberTextBox.Text);
            resultTextBox.Text = (firstnumber / secondnumber).ToString();
        }
       
    }
}
