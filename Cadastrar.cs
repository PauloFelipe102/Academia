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
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeAluno.Text) ||
              string.IsNullOrWhiteSpace(txtRgAluno.Text) ||
              string.IsNullOrWhiteSpace(txtCpfAluno.Text) ||
              string.IsNullOrWhiteSpace(txtDataNascAluno.Text) ||
              string.IsNullOrWhiteSpace(txtCepAluno.Text) ||
              string.IsNullOrWhiteSpace(txtPesoAluno.Text) ||
              string.IsNullOrWhiteSpace(txtAlturaAluno.Text) ||
              string.IsNullOrWhiteSpace(txtObjetivoAluno.Text) ||
              string.IsNullOrWhiteSpace(txtSexoAluno.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            string strConexao = "data source=(local);initial catalog=academia;integrated security=sspi";
            string query = "INSERT INTO Alunos (Nome, RG, CPF, DataNascimento, CEP, Peso, Altura, Objetivo, Sexo) " +
                           "VALUES (@Nome, @RG, @CPF, @DataNascimento, @CEP, @Peso, @Altura, @Objetivo, @Sexo)";

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
                            // Adiciona os parâmetros para o comando SQL
                            comando.Parameters.AddWithValue("@Nome", txtNomeAluno.Text);
                            comando.Parameters.AddWithValue("@RG", txtRgAluno.Text);
                            comando.Parameters.AddWithValue("@CPF", txtCpfAluno.Text);
                            comando.Parameters.AddWithValue("@DataNascimento", dataNasc);
                            comando.Parameters.AddWithValue("@CEP", txtCepAluno.Text);
                            comando.Parameters.AddWithValue("@Peso", peso);
                            comando.Parameters.AddWithValue("@Altura", altura);
                            comando.Parameters.AddWithValue("@Objetivo", txtObjetivoAluno.Text);
                            comando.Parameters.AddWithValue("@Sexo", txtSexoAluno.Text);

                            // Executa o comando no banco de dados
                            int rowsAffected = comando.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Aluno cadastrado com sucesso!");
                                LimparCampos();
                            }
                            else
                            {
                                MessageBox.Show("Erro ao cadastrar o aluno.");
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

        private void LimparCampos()
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

        private void txtObjetivoAluno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


