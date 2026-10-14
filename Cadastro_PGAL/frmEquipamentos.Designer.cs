namespace Cadastro_PGAL
{
    partial class frmEquipamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipamentos));
            btnVoltar = new Button();
            txtTel = new TextBox();
            lbl = new Label();
            txtEmail = new TextBox();
            lblEmailCliente = new Label();
            txtCpf = new TextBox();
            lblCpfCliente = new Label();
            txtNome = new TextBox();
            lblNomeCliente = new Label();
            btnCadCliente = new Button();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Black;
            btnVoltar.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(119, 49);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtTel
            // 
            txtTel.Font = new Font("Verdana", 18F);
            txtTel.Location = new Point(409, 434);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(441, 37);
            txtTel.TabIndex = 17;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.Transparent;
            lbl.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(396, 393);
            lbl.Name = "lbl";
            lbl.Size = new Size(308, 38);
            lbl.TabIndex = 16;
            lbl.Text = "Senha do cartão";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Verdana", 18F);
            txtEmail.Location = new Point(409, 313);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(441, 37);
            txtEmail.TabIndex = 15;
            // 
            // lblEmailCliente
            // 
            lblEmailCliente.AutoSize = true;
            lblEmailCliente.BackColor = Color.Transparent;
            lblEmailCliente.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailCliente.ForeColor = SystemColors.Window;
            lblEmailCliente.Location = new Point(396, 272);
            lblEmailCliente.Name = "lblEmailCliente";
            lblEmailCliente.Size = new Size(434, 38);
            lblEmailCliente.TabIndex = 14;
            lblEmailCliente.Text = "N° do cartão de crédito";
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Verdana", 18F);
            txtCpf.Location = new Point(409, 189);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(441, 37);
            txtCpf.TabIndex = 13;
            // 
            // lblCpfCliente
            // 
            lblCpfCliente.AutoSize = true;
            lblCpfCliente.BackColor = Color.Transparent;
            lblCpfCliente.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCpfCliente.ForeColor = Color.White;
            lblCpfCliente.Location = new Point(396, 148);
            lblCpfCliente.Name = "lblCpfCliente";
            lblCpfCliente.Size = new Size(84, 38);
            lblCpfCliente.TabIndex = 12;
            lblCpfCliente.Text = "CPF";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Verdana", 18F);
            txtNome.Location = new Point(409, 68);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(441, 37);
            txtNome.TabIndex = 11;
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.BackColor = Color.Transparent;
            lblNomeCliente.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeCliente.ForeColor = Color.White;
            lblNomeCliente.Location = new Point(396, 27);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(121, 38);
            lblNomeCliente.TabIndex = 10;
            lblNomeCliente.Text = "Nome";
            // 
            // btnCadCliente
            // 
            btnCadCliente.Font = new Font("Verdana", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadCliente.Location = new Point(451, 527);
            btnCadCliente.Name = "btnCadCliente";
            btnCadCliente.Size = new Size(375, 77);
            btnCadCliente.TabIndex = 9;
            btnCadCliente.Text = "Cadastrar";
            btnCadCliente.UseVisualStyleBackColor = true;
            // 
            // frmEquipamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1239, 644);
            Controls.Add(txtTel);
            Controls.Add(lbl);
            Controls.Add(txtEmail);
            Controls.Add(lblEmailCliente);
            Controls.Add(txtCpf);
            Controls.Add(lblCpfCliente);
            Controls.Add(txtNome);
            Controls.Add(lblNomeCliente);
            Controls.Add(btnCadCliente);
            Controls.Add(btnVoltar);
            Name = "frmEquipamentos";
            Text = "frmEquipamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private TextBox txtTel;
        private Label lbl;
        private TextBox txtEmail;
        private Label lblEmailCliente;
        private TextBox txtCpf;
        private Label lblCpfCliente;
        private TextBox txtNome;
        private Label lblNomeCliente;
        private Button btnCadCliente;
    }
}