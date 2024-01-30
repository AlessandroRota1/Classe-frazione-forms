using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_frazione_forms
{
    
    public partial class Form1 : Form
    {
        class frazione
        {
            private double numeratore;
            private double denominatore;
            public double Numeratore
            {
                get => numeratore;
                set => numeratore = value;
            }
            public double Denominatore
            {
                get => denominatore;
                set => denominatore = value;
            }
            public string semplificafrazione()
            {
                double resto = 0;
                if (numeratore % denominatore == 0)
                {
                    for (double i = numeratore; i < denominatore; i++)
                    {
                        if (i % denominatore == 0)
                        {

                        }
                    }
                    //while (denominatore != 0)
                    //{
                    //    resto = numeratore % denominatore;
                    //    numeratore = denominatore;
                    //    denominatore = resto;
                    //}
                    //numeratore = numeratore % resto;
                    //denominatore = denominatore % resto;
                }
                return (numeratore + "/" + denominatore);
            }
            public double somma()
            {
                return numeratore + denominatore;
            }
            public double sottrai()
            {
                return numeratore - denominatore;
            }
            public double moltiplica()
            {
                return numeratore * denominatore;
            }
            public double dividi()
            {
                return numeratore / denominatore;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void D_Click(object sender, EventArgs e)
        {
            frazione semplif = new frazione();
            Ris.Text = semplif.semplificafrazione();
        }

        private void Somma_Click(object sender, EventArgs e)
        {
            frazione semplif = new frazione();
            semplif.Numeratore = double.Parse(textBox1.Text);
            semplif.Denominatore = double.Parse(textBox2.Text);
            Ris.Text = semplif.somma().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frazione semplif = new frazione();
            semplif.Numeratore = double.Parse(textBox1.Text);
            semplif.Denominatore = double.Parse(textBox2.Text);
            Ris.Text = semplif.sottrai().ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frazione semplif = new frazione();
            semplif.Numeratore = double.Parse(textBox1.Text);
            semplif.Denominatore = double.Parse(textBox2.Text);
            Ris.Text = semplif.moltiplica().ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frazione semplif = new frazione();
            semplif.Numeratore = double.Parse(textBox1.Text);
            semplif.Denominatore = double.Parse(textBox2.Text);
            Ris.Text = semplif.dividi().ToString();
        }
    }
}
