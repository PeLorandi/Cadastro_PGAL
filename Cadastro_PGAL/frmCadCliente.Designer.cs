namespace Cadastro_PGAL
{
    partial class frmCadCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCliente));
            btnCadCliente = new Button();
            lblNomeCliente = new Label();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            lblCpfCliente = new Label();
            txtTel = new TextBox();
            lbl = new Label();
            txtEmail = new TextBox();
            lblEmailCliente = new Label();
            btnCadVoltar = new Button();
            SuspendLayout();
            // 
            // btnCadCliente
            // 
            btnCadCliente.Font = new Font("Verdana", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadCliente.Location = new Point(455, 540);
            btnCadCliente.Name = "btnCadCliente";
            btnCadCliente.Size = new Size(375, 77);
            btnCadCliente.TabIndex = 0;
            btnCadCliente.Text = "Cadastrar";
            btnCadCliente.UseVisualStyleBackColor = true;
            btnCadCliente.Click += button1_Click;
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.BackColor = Color.Transparent;
            lblNomeCliente.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeCliente.ForeColor = Color.White;
            lblNomeCliente.Location = new Point(400, 40);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(121, 38);
            lblNomeCliente.TabIndex = 1;
            lblNomeCliente.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Verdana", 18F);
            txtNome.Location = new Point(413, 81);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(441, 37);
            txtNome.TabIndex = 2;
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Verdana", 18F);
            txtCpf.Location = new Point(413, 202);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(441, 37);
            txtCpf.TabIndex = 4;
            // 
            // lblCpfCliente
            // 
            lblCpfCliente.AutoSize = true;
            lblCpfCliente.BackColor = Color.Transparent;
            lblCpfCliente.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCpfCliente.ForeColor = Color.White;
            lblCpfCliente.Location = new Point(400, 161);
            lblCpfCliente.Name = "lblCpfCliente";
            lblCpfCliente.Size = new Size(84, 38);
            lblCpfCliente.TabIndex = 3;
            lblCpfCliente.Text = "CPF";
            // 
            // txtTel
            // 
            txtTel.Font = new Font("Verdana", 18F);
            txtTel.Location = new Point(413, 447);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(441, 37);
            txtTel.TabIndex = 8;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.Transparent;
            lbl.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(400, 406);
            lbl.Name = "lbl";
            lbl.Size = new Size(172, 38);
            lbl.TabIndex = 7;
            lbl.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Verdana", 18F);
            txtEmail.Location = new Point(413, 326);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(441, 37);
            txtEmail.TabIndex = 6;
            // 
            // lblEmailCliente
            // 
            lblEmailCliente.AutoSize = true;
            lblEmailCliente.BackColor = Color.Transparent;
            lblEmailCliente.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailCliente.ForeColor = SystemColors.Window;
            lblEmailCliente.Location = new Point(400, 285);
            lblEmailCliente.Name = "lblEmailCliente";
            lblEmailCliente.Size = new Size(131, 38);
            lblEmailCliente.TabIndex = 5;
            lblEmailCliente.Text = "E-mail";
            // 
            // btnCadVoltar
            // 
            btnCadVoltar.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadVoltar.Location = new Point(12, 24);
            btnCadVoltar.Name = "btnCadVoltar";
            btnCadVoltar.Size = new Size(108, 41);
            btnCadVoltar.TabIndex = 9;
            btnCadVoltar.Text = "Voltar";
            btnCadVoltar.UseVisualStyleBackColor = true;
            btnCadVoltar.Click += btnCadVoltar_Click;
            // 
            // frmCadCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1236, 642);
            Controls.Add(btnCadVoltar);
            Controls.Add(txtTel);
            Controls.Add(lbl);
            Controls.Add(txtEmail);
            Controls.Add(lblEmailCliente);
            Controls.Add(txtCpf);
            Controls.Add(lblCpfCliente);
            Controls.Add(txtNome);
            Controls.Add(lblNomeCliente);
            Controls.Add(btnCadCliente);
            Name = "frmCadCliente";
            Text = "frmCadCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadCliente;
        private Label lblNomeCliente;
        private TextBox txtNome;
        private TextBox txtCpf;
        private Label lblCpfCliente;
        private TextBox txtTel;
        private Label lbl;
        private TextBox txtEmail;
        private Label lblEmailCliente;
        private Button btnCadVoltar;
    }
}