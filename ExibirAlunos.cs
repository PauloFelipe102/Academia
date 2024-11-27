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
    public partial class ExibirAlunos : Form
    {
        public ExibirAlunos()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            string strConexao = "data source=(local);initial catalog=academia;integrated security=sspi";
            string query = "SELECT * FROM Alunos WHERE CodAluno = @CodAluno";

            using (SqlConnection conexao = new SqlConnection(strConexao))
            {
                try
                {
                    conexao.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@CodAluno", txtCodAluno.Text);
                        SqlDataReader reader = comando.ExecuteReader();

                        if (reader.Read())
                        {
                            txtNomeAluno.Text = reader["Nome"].ToString();
                            txtRgAluno.Text = reader["RG"].ToString();
                            txtCpfAluno.Text = reader["CPF"].ToString();
                            txtDataNascAluno.Text = Convert.ToDateTime(reader["DataNascimento"]).ToString("dd/MM/yyyy");
                            txtCepAluno.Text = reader["CEP"].ToString();
                            txtPesoAluno.Text = reader["Peso"].ToString();
                            txtAlturaAluno.Text = reader["Altura"].ToString();
                            txtObjetivoAluno.Text = reader["Objetivo"].ToString();
                            txtSexoAluno.Text = reader["Sexo"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Aluno não encontrado!");
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
            txtNomeAluno.Clear();
            txtRgAluno.Clear();
            txtCpfAluno.Clear();
            txtDataNascAluno.Clear();
            txtCepAluno.Clear();
            txtPesoAluno.Clear();
            txtAlturaAluno.Clear();
            txtObjetivoAluno.Clear();
            txtSexoAluno.Clear();
        }
    }
}
