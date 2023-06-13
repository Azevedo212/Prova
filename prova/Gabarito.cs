using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova
{
    public partial class Gabarito : Form
    {
        public Gabarito()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string[] gab = { "A", "B", "D", "E", "C", "A", "A", "D", "E", "B" };
            string[] respostas = { tx1.Text, tx2.Text, tx3.Text, tx4.Text, tx5.Text, tx6.Text, tx7.Text, tx8.Text, tx9.Text, tx10.Text }; 
            int respostaCertas = 0;
           

            for (int i = 0; i < gab.Length; i++)
            {
                for (int j = 0; j < respostas.Length; j++)
                {
                    if (gab[i] == respostas[j])
                    {
                        respostaCertas = respostaCertas + 1;
                    }
                    else if (gab[i] == respostas[j])
                    {
                        respostaCertas = respostaCertas + 1;
                    }
                    else if (gab[i] == respostas[j])
                    {
                        respostaCertas = respostaCertas + 1;
                    }
                    else if (gab[i] == respostas[j])
                    {
                        respostaCertas = respostaCertas + 1;
                    }
                    else if (gab[i] == respostas[j])
                    {
                        respostaCertas = respostaCertas + 1;
                    }
                    else if (gab[i] == respostas[j])
                    {
                        respostaCertas = respostaCertas + 1;
                    }
                    else if (gab[i] == respostas[j])
                    {
                        respostaCertas = respostaCertas + 1;
                    }
                    else if (gab[i] == respostas[j])
                    {
                        respostaCertas = respostaCertas + 1;
                    }
                    else if (gab[i] == respostas[j])
                    {
                        respostaCertas = respostaCertas + 1;
                    }
                    else if (gab[i] == respostas[j])
                    {
                        respostaCertas = respostaCertas + 1;
                    }
                }
            }
            
            lb_resultado.Text = respostaCertas.ToString();
        }

        private void tx1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
