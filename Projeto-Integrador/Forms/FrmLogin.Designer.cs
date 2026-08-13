namespace Projeto_Integrador.Forms
{
    partial class FrmLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxUsuario = new TextBox();
            txtBoxSenha = new TextBox();
            button1 = new Button();
            label4 = new Label();
            lblLinkCadastro = new LinkLabel();
            lblErrors = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 32);
            label1.Name = "label1";
            label1.Size = new Size(104, 45);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(287, 116);
            label2.Name = "label2";
            label2.Size = new Size(79, 28);
            label2.TabIndex = 1;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(287, 198);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Location = new Point(287, 147);
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.Size = new Size(223, 31);
            txtBoxUsuario.TabIndex = 3;
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.Location = new Point(287, 229);
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.Size = new Size(223, 31);
            txtBoxSenha.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(344, 307);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 344);
            label4.Name = "label4";
            label4.Size = new Size(178, 25);
            label4.TabIndex = 6;
            label4.Text = "Não tem uma conta?";
            // 
            // lblLinkCadastro
            // 
            lblLinkCadastro.AutoSize = true;
            lblLinkCadastro.Location = new Point(420, 344);
            lblLinkCadastro.Name = "lblLinkCadastro";
            lblLinkCadastro.Size = new Size(105, 25);
            lblLinkCadastro.TabIndex = 7;
            lblLinkCadastro.TabStop = true;
            lblLinkCadastro.Text = "Cadastre-se";
            lblLinkCadastro.LinkClicked += lblLinkCadastro_LinkClicked;
            // 
            // lblErrors
            // 
            lblErrors.AutoSize = true;
            lblErrors.Font = new Font("Segoe UI", 10F);
            lblErrors.ForeColor = Color.Red;
            lblErrors.Location = new Point(50, 307);
            lblErrors.Name = "lblErrors";
            lblErrors.Size = new Size(0, 28);
            lblErrors.TabIndex = 18;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblErrors);
            Controls.Add(lblLinkCadastro);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtBoxSenha);
            Controls.Add(txtBoxUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxUsuario;
        private TextBox txtBoxSenha;
        private Button button1;
        private Label label4;
        private LinkLabel lblLinkCadastro;
        private Label lblErrors;
    }
}