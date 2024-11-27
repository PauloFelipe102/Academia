using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class ExibirPlanos : Form
    {
        public ExibirPlanos()
        {
            InitializeComponent();
        }

        private void ExibirPlanos_Load(object sender, EventArgs e)
        {

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            string strConexao = "data source=(local);initial catalog=Academia;integrated security=sspi";
            string query = "SELECT Plano, Descricao, Valor FROM Planos WHERE CodPlano = @CodPlano";

            using (SqlConnection conexao = new SqlConnection(strConexao))
            {
                try
                {
                    conexao.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@CodPlano", int.Parse(txtCodPlano.Text));

                        SqlDataReader leitor = comando.ExecuteReader();

                        if (leitor.Read())
                        {
                            txtPlano.Text = leitor["Plano"].ToString();
                            txtDescricaoPlano.Text = leitor["Descricao"].ToString();
                            txtValorPlano.Text = leitor["Valor"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Plano não encontrado!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPlano.Clear();
            txtDescricaoPlano.Clear();
            txtValorPlano.Clear();
          
        }
    }
}


