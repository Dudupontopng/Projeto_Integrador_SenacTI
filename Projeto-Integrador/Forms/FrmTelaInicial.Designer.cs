namespace Projeto_Integrador
{
    partial class FrmTelaInicial
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
            label1 = new Label();
            btnLogin = new Button();
            btnCadastro = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 42);
            label1.Name = "label1";
            label1.Size = new Size(329, 37);
            label1.TabIndex = 0;
            label1.Text = "Tela Inicial do Quiz";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(133, 227);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 70);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = SystemColors.ButtonFace;
            btnCadastro.ForeColor = SystemColors.ActiveCaptionText;
            btnCadastro.Location = new Point(464, 227);
            btnCadastro.Margin = new Padding(10);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(200, 70);
            btnCadastro.TabIndex = 2;
            btnCadastro.Text = "CADASTRO";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += this.btnCadastro_Click;
            // 
            // FrmTelaInicial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastro);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Name = "FrmTelaInicial";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogin;
        private Button btnCadastro;
    }
}
