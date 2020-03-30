using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangulos
{
    public partial class Form1 : Form
    {
        public bool aCorreto, bCorreto, cCorreto;
        public double valorA, valorB, valorC;

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            cCorreto = Double.TryParse(txtC.Text, out valorC);
            if (!cCorreto)
                MessageBox.Show("Nescessárior atribuir valor numérico ao lado.");
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            bCorreto = Double.TryParse(txtB.Text, out valorB);
            if (!bCorreto)
                MessageBox.Show("Nescessárior atribuir valor numérico ao lado.");
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            aCorreto = Double.TryParse(txtA.Text, out valorA);
            if (!aCorreto)
                MessageBox.Show("Nescessárior atribuir valor numérico ao lado.");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnValida_Click(object sender, EventArgs e)
        {
            if (aCorreto && bCorreto && cCorreto)
            {
                if (valorB-valorC<valorA && valorA<valorB+valorC &&
                    valorA-valorC<valorB && valorB<valorA+valorC &&
                    valorA-valorB<valorC && valorC<valorA+valorB)
                {
                    if (valorA==valorB && valorA==valorC)
                    {
                        txtRes.Text="Trinangulo equiltero";
                    }    
                    else if (valorA==valorB || valorA==valorC || valorB==valorC)
                    {
                        txtRes.Text = "Trinangulo isóceles";
                    }
                    else
                    {
                        txtRes.Text = "Trinangulo escaleno";
                    }
                }
                else
                {
                    txtRes.Text = "Triangulo impossível";
                }

            }
        }
    }
}
