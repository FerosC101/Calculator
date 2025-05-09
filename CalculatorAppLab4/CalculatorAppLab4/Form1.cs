using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppLab4
{
    public partial class frmCalculator : Form
    {
        double result = 0;
        String operation = "";
        bool isPerformed = false;
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((txtInput.Text == "0") || (isPerformed))
            {
                txtInput.Clear();
            } 

            isPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ".") 
            {
                if (!txtInput.Text.Contains("."))
                {

                    txtInput.Text += button.Text;
                }

                else
                {
                    txtInput.Text += button.Text;
                } 
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                button_equals.PerformClick();
                operation = button.Text;
                isPerformed = true;
            }
            else 
            {
                operation = button.Text;
                result = Double.Parse(txtInput.Text);
                isPerformed = true;
            }
        }

     

     


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_clear(object sender, EventArgs e)
        {

        }

        private void button_clearentry(object sender, EventArgs e)
        {

        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
