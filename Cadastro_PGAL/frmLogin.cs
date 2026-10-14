namespace Cadastro_PGAL
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Verificar se campo txtNome está vazio ou só com espaços
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                //Alerta para o usuário
                MessageBox.Show("BURRO PRA KRL KKKKKKK", "OH SEU BOSTA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //Limpar o campo
                txtNome.Clear();

                //Focar no erro do animal
                txtNome.Focus();

                //Parar a execução
                return;
            }

            if (string.IsNullOrEmpty(txtIdade.Text))
            {
                MessageBox.Show("NÃO SABE SUA IDADE??? SEU LIXO!", "BURRO PRA KRL!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdade.Clear();
                txtIdade.Focus();
                return;
            }

            //Instanciar a tela menu (frmMenu) PASSANDO dados por ela
            frmMenu telaPrincipal = new frmMenu(txtNome.Text);

            //Esconde a tela de login
            this.Hide();

            //Abre a tela principal
            telaPrincipal.ShowDialog();
        }
    }
}
