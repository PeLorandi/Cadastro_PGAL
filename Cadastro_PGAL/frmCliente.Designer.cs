namespace Cadastro_PGAL
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            btnCadCliente = new Button();
            btnTabela = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // btnCadCliente
            // 
            btnCadCliente.BackColor = Color.Transparent;
            btnCadCliente.FlatStyle = FlatStyle.Flat;
            btnCadCliente.Font = new Font("Verdana", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadCliente.ForeColor = Color.White;
            btnCadCliente.Location = new Point(36, 127);
            btnCadCliente.Name = "btnCadCliente";
            btnCadCliente.Size = new Size(686, 127);
            btnCadCliente.TabIndex = 0;
            btnCadCliente.Text = "Cadastrar cliente";
            btnCadCliente.UseVisualStyleBackColor = false;
            btnCadCliente.Click += btnCadCliente_Click;
            // 
            // btnTabela
            // 
            btnTabela.BackColor = Color.Transparent;
            btnTabela.FlatStyle = FlatStyle.Flat;
            btnTabela.Font = new Font("Verdana", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTabela.ForeColor = Color.White;
            btnTabela.Location = new Point(334, 385);
            btnTabela.Name = "btnTabela";
            btnTabela.Size = new Size(841, 130);
            btnTabela.TabIndex = 1;
            btnTabela.Text = "Ver tabela de clientes";
            btnTabela.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.FlatStyle = FlatStyle.Popup;
            btnVoltar.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(0, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(129, 37);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1203, 613);
            Controls.Add(btnVoltar);
            Controls.Add(btnTabela);
            Controls.Add(btnCadCliente);
            Name = "frmCliente";
            Text = "frmCliente";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadCliente;
        private Button btnTabela;
        private Button btnVoltar;
    }
}