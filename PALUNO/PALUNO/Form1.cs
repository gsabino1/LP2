using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PALUNO
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=sabino-pc;Initial Catalog=LP2;Integrated Security=True");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show ("Erro de banco de dados =/" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros erros =/" + ex.Message);
            }
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAluno frmaluno =new frmAluno();
            frmaluno.Show();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCidade frmcidade = new frmCidade();
            frmcidade.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
