using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator1234
{
    public partial class Form1 : Form
    {
        Double result = 0;
        string Perform_operator = "";
        bool isOperationwork = false;
        public Form1()
            
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1_result.Text == "0")||(isOperationwork))
                textBox1_result.Clear();

            Button button = (Button)sender;
            if (button.Text == ("."))
            {
                if (!textBox1_result.Text.Contains("."))
                {
                    textBox1_result.Text = textBox1_result.Text + button.Text;
                }
            }
            else

                textBox1_result.Text = textBox1_result.Text + button.Text;
                
            
                isOperationwork = false;
            
        }
        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Perform_operator = button.Text;
            result = Double.Parse(textBox1_result.Text);
            label1.Text = result + " " + Perform_operator;
            isOperationwork = true;
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button12_Click(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {


        }

        private void Button11_Click(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Button17_Click(object sender, EventArgs e)
        {
            switch(Perform_operator)
            {
                case "+":
                    textBox1_result.Text = (result + Double.Parse(textBox1_result.Text)).ToString();
                    break;
                case "-":
                    textBox1_result.Text = (result - Double.Parse(textBox1_result.Text)).ToString();
                    break;
                case "*":
                    textBox1_result.Text = (result * Double.Parse(textBox1_result.Text)).ToString();
                    break;
                case "/":
                    textBox1_result.Text = (result / Double.Parse(textBox1_result.Text)).ToString();
                    break;
                default:
                    break;






            }

                
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            textBox1_result.Text = "0";
            result = 0;
            

        }
    }
}
