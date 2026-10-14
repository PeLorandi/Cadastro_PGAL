namespace Cadastro_PGAL
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            lblPainel = new Label();
            btnClientes = new Button();
            btnEstoque = new Button();
            btnSuporte = new Button();
            btnSair = new Button();
            lblOla = new Label();
            menuStrip1 = new MenuStrip();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            trocaDeUsuárioToolStripMenuItem = new ToolStripMenuItem();
            sairDoSistemaToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            equipamentosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPainel
            // 
            lblPainel.AutoSize = true;
            lblPainel.BackColor = Color.Transparent;
            lblPainel.Font = new Font("Verdana", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPainel.ForeColor = SystemColors.ButtonHighlight;
            lblPainel.Location = new Point(39, 63);
            lblPainel.Name = "lblPainel";
            lblPainel.Size = new Size(548, 61);
            lblPainel.TabIndex = 0;
            lblPainel.Text = "Painel de Controle";
            lblPainel.Click += lblPainel_Click;
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientes.Location = new Point(121, 286);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(357, 46);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += button1_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEstoque.Location = new Point(121, 351);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(357, 46);
            btnEstoque.TabIndex = 2;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = true;
            // 
            // btnSuporte
            // 
            btnSuporte.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSuporte.Location = new Point(121, 414);
            btnSuporte.Name = "btnSuporte";
            btnSuporte.Size = new Size(357, 46);
            btnSuporte.TabIndex = 3;
            btnSuporte.Text = "Suporte";
            btnSuporte.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(121, 477);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(357, 46);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // lblOla
            // 
            lblOla.AutoSize = true;
            lblOla.BackColor = Color.Transparent;
            lblOla.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOla.ForeColor = SystemColors.ButtonHighlight;
            lblOla.Location = new Point(121, 152);
            lblOla.Name = "lblOla";
            lblOla.Size = new Size(0, 38);
            lblOla.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sistemaToolStripMenuItem, cadastroToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1229, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { trocaDeUsuárioToolStripMenuItem, sairDoSistemaToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(60, 20);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // trocaDeUsuárioToolStripMenuItem
            // 
            trocaDeUsuárioToolStripMenuItem.Name = "trocaDeUsuárioToolStripMenuItem";
            trocaDeUsuárioToolStripMenuItem.Size = new Size(164, 22);
            trocaDeUsuárioToolStripMenuItem.Text = "Troca de usuário ";
            trocaDeUsuárioToolStripMenuItem.Click += trocaDeUsuárioToolStripMenuItem_Click;
            // 
            // sairDoSistemaToolStripMenuItem
            // 
            sairDoSistemaToolStripMenuItem.Name = "sairDoSistemaToolStripMenuItem";
            sairDoSistemaToolStripMenuItem.Size = new Size(164, 22);
            sairDoSistemaToolStripMenuItem.Text = "Sair do sistema";
            sairDoSistemaToolStripMenuItem.Click += sairDoSistemaToolStripMenuItem_Click;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { equipamentosToolStripMenuItem, clientesToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // equipamentosToolStripMenuItem
            // 
            equipamentosToolStripMenuItem.Name = "equipamentosToolStripMenuItem";
            equipamentosToolStripMenuItem.Size = new Size(180, 22);
            equipamentosToolStripMenuItem.Text = "Equipamentos";
            equipamentosToolStripMenuItem.Click += equipamentosToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            ajudaToolStripMenuItem.Click += ajudaToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(104, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1229, 589);
            Controls.Add(lblOla);
            Controls.Add(btnSair);
            Controls.Add(btnSuporte);
            Controls.Add(btnEstoque);
            Controls.Add(btnClientes);
            Controls.Add(lblPainel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "frmMenu";
            FormClosed += frmMenu_FormClosed;
            Load += frmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPainel;
        private Button btnClientes;
        private Button btnEstoque;
        private Button btnSuporte;
        private Button btnSair;
        private Label lblOla;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem trocaDeUsuárioToolStripMenuItem;
        private ToolStripMenuItem sairDoSistemaToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem equipamentosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
    }
}