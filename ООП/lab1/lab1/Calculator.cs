using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        public string D;
        public string N1;
        public bool n2;
        private double memoryValue;
        private void button8_Click(object sender, EventArgs e) // +/-
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double currentValue = Convert.ToDouble(textBox1.Text);
                currentValue = -currentValue;
                textBox1.Text = currentValue.ToString();
            }
        }

       

        private void button29_Click(object sender, EventArgs e) // <--
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            textBox1.Text = B.Text +  "+";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            textBox1.Text =  "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // wind
        {
            string allowedCharacters = "0123456789-+*/.,E";
            string input = textBox1.Text;
            // Проверка каждого символа в строке
            foreach (char c in input)
            {
                if (!allowedCharacters.Contains(c.ToString()))
                {
                    // Если символ не является допустимым, удалите его
                    textBox1.Text = textBox1.Text.Replace(c.ToString(), "");
                    MessageBox.Show("Invalid character removed. Please enter a valid expression.");
                    return;
                }
            }
        }
        private void button3_Click_1(object sender, EventArgs e) // + - X /
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            n2 = true;
        }

        private void button2_Click(object sender, EventArgs e) // Num
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
           
            Button B = (Button)sender;
            if(textBox1.Text == "0")
                textBox1.Text =  B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void button30_Click(object sender, EventArgs e) 
        {
            Button B = (Button)sender;
            textBox1.Text = "0";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) // =
        {
            int res;
            int dn1 = Convert.ToInt32(N1);
            int dn2 = Convert.ToInt32(textBox1.Text);
            res = 0;
            if(D == "+")
            {
                res = dn1 + dn2;
            }
            if (D == "-")
            {
                res = dn1 - dn2;
            }
            if (D == "x")
            {
                res = dn1 * dn2;
            }
            if (D == "/")
            {
                res = dn1 / dn2;
            }
            if (D == "%")
            {
                res = dn1 % dn2;
            }
           
            n2 = true;
            textBox1.Text = res.ToString();
        }

       

        private void button10_Click(object sender, EventArgs e) // M save
        {
            if (double.TryParse(textBox1.Text, out double currentValue))
            {
                memoryValue = currentValue;
                MessageBox.Show("Сохранено в памяти.");
            }
            else
            {
                MessageBox.Show("Ошибка.");
            }
        }

        private void button11_Click(object sender, EventArgs e) // M out
        {
                textBox1.Text = memoryValue.ToString();
        }



        private void button13_Click(object sender, EventArgs e)
        {
            double currentValue = Convert.ToDouble(textBox1.Text);
            double percentage = Math.Truncate(currentValue);
            textBox1.Text = percentage.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}   
