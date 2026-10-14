namespace Cadastro_PGAL
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblNome = new Label();
            txtIdade = new TextBox();
            txtNome = new TextBox();
            lblIdade = new Label();
            lblCadastro = new Label();
            btnCadastrar = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Verdana", 18F, FontStyle.Bold);
            lblNome.ForeColor = SystemColors.ButtonHighlight;
            lblNome.Location = new Point(20, 175);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(90, 29);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            lblNome.Click += lblNome_Click;
            // 
            // txtIdade
            // 
            txtIdade.Font = new Font("Segoe UI", 15.75F);
            txtIdade.Location = new Point(31, 302);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(498, 35);
            txtIdade.TabIndex = 3;
            txtIdade.TextChanged += txtIdade_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 15.75F);
            txtNome.Location = new Point(31, 207);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(498, 35);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.BackColor = Color.Transparent;
            lblIdade.Font = new Font("Verdana", 18F, FontStyle.Bold);
            lblIdade.ForeColor = SystemColors.ButtonHighlight;
            lblIdade.Location = new Point(20, 271);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(92, 29);
            lblIdade.TabIndex = 4;
            lblIdade.Text = "Idade";
            lblIdade.Click += label1_Click_1;
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.BackColor = Color.Transparent;
            lblCadastro.Font = new Font("Verdana", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCadastro.ForeColor = SystemColors.ButtonHighlight;
            lblCadastro.Location = new Point(140, 55);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(281, 61);
            lblCadastro.TabIndex = 0;
            lblCadastro.Text = "Cadastro";
            lblCadastro.Click += label1_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.ButtonHighlight;
            btnCadastrar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ActiveCaptionText;
            btnCadastrar.Location = new Point(156, 487);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(238, 68);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar-se";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(lblCadastro);
            panel1.Controls.Add(lblIdade);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(txtIdade);
            panel1.Controls.Add(lblNome);
            panel1.Location = new Point(75, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1098, 607);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 661);
            Controls.Add(panel1);
            Name = "frmLogin";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNome;
        private TextBox txtIdade;
        private TextBox txtNome;
        private Label lblIdade;
        private Label lblCadastro;
        private Button btnCadastrar;
        private Panel panel1;
    }
}
