namespace Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // inicio da mudança de tela
            ExibirAlunos ExibirAlunos = new ExibirAlunos();
            this.Hide();
            ExibirAlunos.Show();
            ExibirAlunos.FormClosed += (s, args) => this.Show();
            // fim da mudança de tela
        }

        private void btnAlterarAlunos_Click(object sender, EventArgs e)
        {
            // inicio da mudança de tela
            AlterarAlunos AlterarAlunos = new AlterarAlunos();
            this.Hide();
            AlterarAlunos.Show();
            AlterarAlunos.FormClosed += (s, args) => this.Show();
            // fim da mudança de tela
        }

        private void btnCadastrarAlunos_Click(object sender, EventArgs e)
        {
            // inicio da mudança de tela
            Cadastrar Cadastrar = new Cadastrar();
            this.Hide();
            Cadastrar.Show();
            Cadastrar.FormClosed += (s, args) => this.Show();
            // fim da mudança de tela
        }

        private void btnExcluirAlunos_Click(object sender, EventArgs e)
        {
            // inicio da mudança de tela
            Excluir Excluir = new Excluir();
            this.Hide();
            Excluir.Show();
            Excluir.FormClosed += (s, args) => this.Show();
            // fim da mudança de tela
        }

        private void btnCadastrarPlan_Click(object sender, EventArgs e)
        {
            // inicio da mudança de tela
            CadastrarPlano CadastrarPlano = new CadastrarPlano();
            this.Hide();
            CadastrarPlano.Show();
            CadastrarPlano.FormClosed += (s, args) => this.Show();
            // fim da mudança de tela
        }

        private void btnAlterarPlan_Click(object sender, EventArgs e)
        {
            // inicio da mudança de tela
            AlterarPlano AlterarPlano = new AlterarPlano();
            this.Hide();
            AlterarPlano.Show();
            AlterarPlano.FormClosed += (s, args) => this.Show();
            // fim da mudança de tela
        }

        private void btnExibirPlan_Click(object sender, EventArgs e)
        {
            // inicio da mudança de tela
            ExibirPlanos ExibirPlanos = new ExibirPlanos();
            this.Hide();
            ExibirPlanos.Show();
            ExibirPlanos.FormClosed += (s, args) => this.Show();
            // fim da mudança de tela
        }

        private void BtnExcluirPlan_Click(object sender, EventArgs e)
        {
            // inicio da mudança de tela
            ExcluirPlano ExcluirPlano = new ExcluirPlano();
            this.Hide();
            ExcluirPlano.Show();
            ExcluirPlano.FormClosed += (s, args) => this.Show();
            // fim da mudança de tela
        }
    }
}   
