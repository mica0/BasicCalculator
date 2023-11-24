using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {

                float num1 = float.Parse(txtNum1.Text.ToString());
                float num2 = float.Parse(txtNum2.Text.ToString());

                float answer;

                if (cbOperators.Text == "+")
                {

                    answer = BasicComputation.Addition(num1, num2);

                    lblAnswer.Text = answer.ToString();

                }
                if (cbOperators.Text == "-")
                {

                    answer = BasicComputation.Subraction(num1, num2);

                    lblAnswer.Text = answer.ToString();

                }
                if (cbOperators.Text == "*")
                {

                    answer = BasicComputation.Multiplication(num1, num2);

                    lblAnswer.Text = answer.ToString();

                }
                if (cbOperators.Text == "/")
                {

                    answer = BasicComputation.Division(num1, num2);

                    lblAnswer.Text = answer.ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        
    }
}

