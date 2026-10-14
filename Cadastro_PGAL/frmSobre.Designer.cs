namespace Cadastro_PGAL
{
    partial class frmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            lblEu = new Label();
            lblAutor = new Label();
            btnOK = new Button();
            SuspendLayout();
            // 
            // lblEu
            // 
            lblEu.AutoSize = true;
            lblEu.BackColor = Color.Transparent;
            lblEu.Font = new Font("Verdana", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEu.ForeColor = Color.White;
            lblEu.Location = new Point(64, 144);
            lblEu.Name = "lblEu";
            lblEu.Size = new Size(1083, 78);
            lblEu.TabIndex = 0;
            lblEu.Text = "Pedro Gabriel Araújo Lorandi";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.BackColor = Color.Transparent;
            lblAutor.Font = new Font("Verdana", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAutor.ForeColor = Color.White;
            lblAutor.Location = new Point(44, 86);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(193, 45);
            lblAutor.TabIndex = 1;
            lblAutor.Text = "feito por:";
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Verdana", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(372, 404);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(401, 168);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // frmSobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1211, 616);
            Controls.Add(btnOK);
            Controls.Add(lblAutor);
            Controls.Add(lblEu);
            DoubleBuffered = true;
            Name = "frmSobre";
            Text = "frmSobre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEu;
        private Label lblAutor;
        private Button btnOK;
    }
}