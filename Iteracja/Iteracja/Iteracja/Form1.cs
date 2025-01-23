using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iteracja
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabPage1.CanSelect == true)
            {
                MessageBox.Show("AKTYWNY 1");
            }
                string s;
            if (textBox1.Text == "") return;
            int n = Convert.ToInt16(textBox1.Text);
            textBox5.Clear();
            for(int i = 0; i < n; i++)
            {
                s = "Znak nr: " + i.ToString() + "to " + (char)i;
                textBox5.AppendText(s + Environment.NewLine);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s;
            if (textBox2.Text == "") return;
            int n = Convert.ToInt16(textBox2.Text);
            if (n > 256) n = 256;
            textBox6.Clear();
            int i = 0;
            do
            {
                i++;
                s = i.ToString() + " x " + i.ToString() + "=" + (i * i).ToString();
                textBox6.AppendText(s + Environment.NewLine);
            }while(i < n);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s;
            if (textBox3.Text == "" || textBox4.Text == "" || textBox4.Text == "0") return;
            int n = Convert.ToInt16(textBox3.Text);
            if (n > 256) n = 256;
            int b = Convert.ToInt16(textBox4.Text);
            // wstepne wartosci czesci calkowitej i reszty z dzielenia 
            int c = 0;
            int r = 0;
            int i = 0;
            textBox7.Clear();
                s = i.ToString() + " x " + i.ToString() + "=" + (i * i).ToString();
                textBox6.AppendText(s + Environment.NewLine);
             while (i <= n){
                c = i / b;
                r = i % b;
                s = i.ToString() + " / " + b.ToString() + "=" + c.ToString() + "; "+ i.ToString() + "%" 
                    + b.ToString() + "= "+ r.ToString();
                textBox7.AppendText(s + Environment.NewLine);
                i++;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
