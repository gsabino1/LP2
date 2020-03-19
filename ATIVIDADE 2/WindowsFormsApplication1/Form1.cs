using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbMasc.Checked = true;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double pesoI,dAltura,dPeso;
            string altura, peso;

            if (string.Equals(txtAltura.Text,"") | string.Equals(txtPeso.Text,""))
            {
                MessageBox.Show("Os campos Altura e Peso são obrigatórios.");
            }

            else
            {
                altura = txtAltura.Text.Replace('.',',');
                peso = txtPeso.Text.Replace('.', ',');
                dAltura = Convert.ToDouble(altura);
                dPeso = Convert.ToDouble(peso);

                if (rdbMasc.Checked==true)
                {
                    
                    pesoI = Convert.ToDouble(altura) * 72.7 - 58;
                    txtPesoIdeal.Text = Convert.ToString(pesoI);
                }
                else
                {
                    pesoI = Convert.ToDouble(altura) * 62.1 - 44.7;
                    txtPesoIdeal.Text = Convert.ToString(pesoI);
                }

                if (pesoI > Convert.ToDouble(peso))
                {
                    txtSitu.Text = "Coma bastante massas e doces";
                }
                if (pesoI < Convert.ToDouble(peso))
                {
                    txtSitu.Text = "Regime Obrigatório Já";
                }
                if (pesoI == Convert.ToDouble(peso))
                {
                    txtSitu.Text = "Você está no peso ideal";
                }
            }
        }
    }
}
