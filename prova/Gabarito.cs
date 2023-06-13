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
            int respostaCorreta = 0;


            for (int i = 0; i < gab.Length; i++)
            {
                if (tx_1.Text == gab['A'].ToString())
                {
                    respostaCorreta =+ 1;
                }
              
            }
            lb_resultado.Text = respostaCorreta.ToString();
        }
    }
}
