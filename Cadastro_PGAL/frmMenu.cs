using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_PGAL
{
    public partial class frmMenu : Form
    {
        //Construtor customizado que exige o nome do usuário
        public frmMenu(string nomeUser)
        {
            //Obrigatóriamente, desenhando a interface
            InitializeComponent();

            //Atualização do Label com o nome recebido
            lblOla.Text = "Bem vindo(a), " + nomeUser;
        }
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Encerrar completamente o projeto
            Application.Exit();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void lblPainel_Click(object sender, EventArgs e)
        {

        }

        private void trocaDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mata todo o processo
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            this.Hide();
            sobre.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            this.Close();
            cliente.ShowDialog();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void equipamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEquipamentos equipamentos = new frmEquipamentos();
            this.Hide();
            equipamentos.ShowDialog();
        }
    }
}
