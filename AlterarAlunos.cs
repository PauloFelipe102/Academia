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
    public partial class AlterarAlunos : Form
    {
        public AlterarAlunos()
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string strConexao = "data source=(local);initial catalog=academia;integrated security=sspi";
            string query = "UPDATE Alunos SET Nome = @Nome, RG = @RG, CPF = @CPF, DataNascimento = @DataNascimento, CEP = @CEP, Peso = @Peso, Altura = @Altura, Objetivo = @Objetivo, Sexo = @Sexo WHERE CodAluno = @CodAluno";

            // Verifica se os campos Peso, Altura e Data de Nascimento têm valores válidos
            if (decimal.TryParse(txtPesoAluno.Text, out decimal peso) && decimal.TryParse(txtAlturaAluno.Text, out decimal altura) && DateTime.TryParse(txtDataNascAluno.Text, out DateTime dataNasc))
            {
                using (SqlConnection conexao = new SqlConnection(strConexao))
                {
                    try
                    {
                        conexao.Open();
                        using (SqlCommand comando = new SqlCommand(query, conexao))
                        {
                            comando.Parameters.AddWithValue("@Nome", txtNomeAluno.Text);
                            comando.Parameters.AddWithValue("@RG", txtRgAluno.Text);
                            comando.Parameters.AddWithValue("@CPF", txtCpfAluno.Text);
                            comando.Parameters.AddWithValue("@DataNascimento", dataNasc);
                            comando.Parameters.AddWithValue("@CEP", txtCepAluno.Text);
                            comando.Parameters.AddWithValue("@Peso", peso);
                            comando.Parameters.AddWithValue("@Altura", altura);
                            comando.Parameters.AddWithValue("@Objetivo", txtObjetivoAluno.Text);
                            comando.Parameters.AddWithValue("@Sexo", txtSexoAluno.Text);
                            comando.Parameters.AddWithValue("@CodAluno", txtCodAluno.Text);

                            int rowsAffected = comando.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Aluno alterado com sucesso!");
                            }
                            else
                            {
                                MessageBox.Show("Aluno não encontrado.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira valores válidos para Peso, Altura e Data de Nascimento.");
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


