using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        
        int o;
        float m;
        public Form1()
        {
            InitializeComponent();
        }
        private void button16_Click(object sender, EventArgs e)
        {

            if (TextBox1.text ==null)
            { textBox1.Text =TextBox1.text+ "0,"; }
            else
            {
                TextBox1.text = TextBox1.text + ",";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }else
            { textBox1.Text = textBox1.Text + "1"; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            { textBox1.Text = textBox1.Text + "2"; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            { textBox1.Text = textBox1.Text + "3"; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            { textBox1.Text = textBox1.Text + "4"; }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            { textBox1.Text = textBox1.Text + "5"; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            { textBox1.Text = textBox1.Text + "6"; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            { textBox1.Text = textBox1.Text + "7"; }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            { textBox1.Text = textBox1.Text + "8"; }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            { textBox1.Text = textBox1.Text + "9"; }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            { textBox1.Text = textBox1.Text + "0"; }
        }

        private void button12_Click(object sender, EventArgs e)
        {
         
          m =float.Parse(textBox1.Text);
          textBox1.Text =null;
          o=1;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            m = float.Parse(textBox1.Text);
            textBox1.Text = null;
            o = 2;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            m = float.Parse(textBox1.Text);
            textBox1.Text = null;
            o = 3;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "0";
            }
            else
            {
                m = float.Parse(textBox1.Text);
                textBox1.Text = null;
                o = 4;
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            m = float.Parse(textBox1.Text);
            textBox1.Text = null;
            double rr = Math.Sqrt(m);
            string r = Convert.ToString(rr);
            textBox1.Text = r;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            m = float.Parse(textBox1.Text);
            textBox1.Text = null;
            double rr = m * 0;
            string r = Convert.ToString(rr);
            textBox1.Text = r;
            }
        private void button5_Click(object sender, EventArgs e)
        {
            if (o == 1)
            {
                float n = float.Parse(textBox1.Text);
                float rr = n + m;
                string r = Convert.ToString(rr);
                textBox1.Text = r;

            }
            if (o == 2)
            {
                float n = float.Parse(textBox1.Text);
                float rr = m-n;
                string r = Convert.ToString(rr);
                textBox1.Text = r;

            }
            if (o == 3)
            {
                float n = float.Parse(textBox1.Text);
                float rr = m*n;
                string r = Convert.ToString(rr);
                textBox1.Text = r;

            }
            if (o == 4)
            {
                float n = float.Parse(textBox1.Text);
                float rr = m/n;
                string r = Convert.ToString(rr);
                textBox1.Text = r;

            }
            
            
            
        }

       

           
       

        
    }
}
