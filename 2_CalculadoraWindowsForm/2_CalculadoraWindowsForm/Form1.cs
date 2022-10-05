using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_CalculadoraWindowsForm
{
    public partial class Form1 : Form
    {
        int inicio, ant,x,y;
       int signo;
        Calculadora cal = new Calculadora();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            inicio = 0;
            ant = 0;
            textBox1.Text = inicio.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valorboton;
            valorboton = Convert.ToInt32(((Button)sender).Text);
           inicio = inicio * 10 + valorboton;
            textBox1.Text = inicio.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            inicio = 0;
            y = 0;
            x = 0;
            textBox1.Text = 0.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            x = inicio;
            inicio = 0;
            textBox1.Text ="+";
            signo = 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch (signo)
            {
                case 1:
                    y = cal.suma(x, inicio);
                    textBox1.Text = y.ToString();
                    inicio = y;
                    break;
                case 2:
                    y = cal.restar(x,inicio);
                    textBox1.Text = y.ToString();
                    inicio = y;
                    break;
                case 3:
                    y = cal.multiplicar(x,inicio);
                    textBox1.Text = y.ToString();
                    inicio = y;
                    break;
                case 4:
                    if (inicio==0)
                    {
                        textBox1.Text = "error matematico";
                    }
                    else
                    {
                        y = cal.divide(x,inicio);
                        textBox1.Text = y.ToString();
                        inicio = y;
                    }
                    break;

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            x = inicio;
            inicio = 0;
            textBox1.Text = "-";
            signo = 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            x = inicio;
            inicio = 0;
            textBox1.Text = "*";
            signo = 3;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            x = inicio;
            inicio = 0;
            textBox1.Text = "/";
            signo = 4;
        }


    }
}
