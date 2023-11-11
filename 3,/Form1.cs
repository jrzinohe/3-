using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_
{
    public partial class Form1 : Form
    {
        float f_num, total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton sumar numeros 
            textBox2.Text = total .ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //boton añadir 
            listBox1 .Items.Add( textBox1.Text);
            //aqui es donde pasamos el parametro 
            f_num = float.Parse(textBox1.Text);
            total += f_num;
            textBox1.Text = ""; 
            textBox1.Focus();
        }
    }
}
