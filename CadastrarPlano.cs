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
    public partial class CadastrarPlano : Form
    {
        public CadastrarPlano()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string strConexao = "data source=(local);initial catalog=academia;integrated security=sspi";
            string query = "INSERT INTO Planos (Plano, Descricao, Valor) VALUES (@Plano, @Descricao, @Valor)";

            using (SqlConnection conexao = new SqlConnection(strConexao))
            {
                try
                {
                    conexao.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@Plano", txtPlano.Text);
                        comando.Parameters.AddWithValue("@Descricao", txtDescricaoPlano.Text);
                        comando.Parameters.AddWithValue("@Valor", decimal.Parse(txtValorPlano.Text));

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Plano cadastrado com sucesso!");

                        // Limpa os campos após o cadastro
                        txtPlano.Clear();
                        txtDescricaoPlano.Clear();
                        txtValorPlano.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }
    }
}
