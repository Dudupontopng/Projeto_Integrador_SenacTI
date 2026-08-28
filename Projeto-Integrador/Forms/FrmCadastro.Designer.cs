namespace Projeto_Integrador.Forms
{
    partial class FrmCadastro
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
            txtBoxSenha = new TextBox();
            txtBoxUsuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBoxConfirmarSenha = new TextBox();
            label4 = new Label();
            txtBoxNome = new TextBox();
            label5 = new Label();
            btnCadastro = new Button();
            datePickerNascimento = new DateTimePicker();
            label6 = new Label();
            lblErrors = new Label();
            SuspendLayout();
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.BackColor = Color.Gray;
            txtBoxSenha.BorderStyle = BorderStyle.FixedSingle;
            txtBoxSenha.Location = new Point(124, 269);
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.Size = new Size(223, 31);
            txtBoxSenha.TabIndex = 9;
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.BackColor = Color.Gray;
            txtBoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtBoxUsuario.Location = new Point(124, 187);
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.Size = new Size(223, 31);
            txtBoxUsuario.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(124, 238);
            label3.Name = "label3";
            label3.Size = new Size(69, 28);
            label3.TabIndex = 7;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(124, 156);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 6;
            label2.Text = "Usuário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 35);
            label1.Name = "label1";
            label1.Size = new Size(153, 45);
            label1.TabIndex = 5;
            label1.Text = "Cadastro";
            // 
            // txtBoxConfirmarSenha
            // 
            txtBoxConfirmarSenha.BackColor = Color.Gray;
            txtBoxConfirmarSenha.BorderStyle = BorderStyle.FixedSingle;
            txtBoxConfirmarSenha.Location = new Point(124, 339);
            txtBoxConfirmarSenha.Name = "txtBoxConfirmarSenha";
            txtBoxConfirmarSenha.Size = new Size(223, 31);
            txtBoxConfirmarSenha.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(124, 308);
            label4.Name = "label4";
            label4.Size = new Size(168, 28);
            label4.TabIndex = 10;
            label4.Text = "Confirmar senha";
            // 
            // txtBoxNome
            // 
            txtBoxNome.BackColor = Color.Gray;
            txtBoxNome.BorderStyle = BorderStyle.FixedSingle;
            txtBoxNome.Location = new Point(124, 109);
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.Size = new Size(223, 31);
            txtBoxNome.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(124, 78);
            label5.Name = "label5";
            label5.Size = new Size(69, 28);
            label5.TabIndex = 12;
            label5.Text = "Nome";
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = Color.FromArgb(64, 64, 64);
            btnCadastro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCadastro.ForeColor = Color.White;
            btnCadastro.Location = new Point(320, 386);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(150, 40);
            btnCadastro.TabIndex = 14;
            btnCadastro.Text = "Cadastre-se";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // datePickerNascimento
            // 
            datePickerNascimento.CalendarMonthBackground = Color.Gray;
            datePickerNascimento.Location = new Point(410, 109);
            datePickerNascimento.Name = "datePickerNascimento";
            datePickerNascimento.Size = new Size(318, 31);
            datePickerNascimento.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(410, 80);
            label6.Name = "label6";
            label6.Size = new Size(201, 28);
            label6.TabIndex = 16;
            label6.Text = "Data de nascimento";
            // 
            // lblErrors
            // 
            lblErrors.AutoSize = true;
            lblErrors.Font = new Font("Segoe UI", 10F);
            lblErrors.ForeColor = Color.Red;
            lblErrors.Location = new Point(394, 213);
            lblErrors.MaximumSize = new Size(360, 160);
            lblErrors.Name = "lblErrors";
            lblErrors.Size = new Size(0, 28);
            lblErrors.TabIndex = 17;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(lblErrors);
            Controls.Add(label6);
            Controls.Add(datePickerNascimento);
            Controls.Add(btnCadastro);
            Controls.Add(txtBoxNome);
            Controls.Add(label5);
            Controls.Add(txtBoxConfirmarSenha);
            Controls.Add(label4);
            Controls.Add(txtBoxSenha);
            Controls.Add(txtBoxUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCadastro";
            Text = "FrmCadastro";
            Load += FrmCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxSenha;
        private TextBox txtBoxUsuario;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBoxConfirmarSenha;
        private Label label4;
        private TextBox txtBoxNome;
        private Label label5;
        private Button btnCadastro;
        private DateTimePicker datePickerNascimento;
        private Label label6;
        private Label lblErrors;
    }
}