namespace Projeto_Integrador.Forms
{
    partial class FrmEsquecMinhaSenha
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
            label3 = new Label();
            label1 = new Label();
            txtBoxConfirmarSenha = new TextBox();
            label4 = new Label();
            txtBoxSenhaAtual = new TextBox();
            label2 = new Label();
            btnAlterar = new Button();
            SuspendLayout();
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.BackColor = Color.Gray;
            txtBoxSenha.BorderStyle = BorderStyle.FixedSingle;
            txtBoxSenha.Location = new Point(298, 213);
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.Size = new Size(223, 31);
            txtBoxSenha.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(298, 182);
            label3.Name = "label3";
            label3.Size = new Size(69, 28);
            label3.TabIndex = 5;
            label3.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 49);
            label1.Name = "label1";
            label1.Size = new Size(219, 45);
            label1.TabIndex = 7;
            label1.Text = "Alterar senha";
            label1.Click += label1_Click;
            // 
            // txtBoxConfirmarSenha
            // 
            txtBoxConfirmarSenha.BackColor = Color.Gray;
            txtBoxConfirmarSenha.BorderStyle = BorderStyle.FixedSingle;
            txtBoxConfirmarSenha.Location = new Point(298, 277);
            txtBoxConfirmarSenha.Name = "txtBoxConfirmarSenha";
            txtBoxConfirmarSenha.Size = new Size(223, 31);
            txtBoxConfirmarSenha.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(298, 246);
            label4.Name = "label4";
            label4.Size = new Size(168, 28);
            label4.TabIndex = 12;
            label4.Text = "Confirmar senha";
            // 
            // txtBoxSenhaAtual
            // 
            txtBoxSenhaAtual.BackColor = Color.Gray;
            txtBoxSenhaAtual.BorderStyle = BorderStyle.FixedSingle;
            txtBoxSenhaAtual.Location = new Point(298, 148);
            txtBoxSenhaAtual.Name = "txtBoxSenhaAtual";
            txtBoxSenhaAtual.Size = new Size(223, 31);
            txtBoxSenhaAtual.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(298, 117);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 14;
            label2.Text = "Senha atual";
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(64, 64, 64);
            btnAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAlterar.ForeColor = Color.White;
            btnAlterar.Location = new Point(327, 349);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(150, 40);
            btnAlterar.TabIndex = 16;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            // 
            // FrmEsquecMinhaSenha
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAlterar);
            Controls.Add(txtBoxSenhaAtual);
            Controls.Add(label2);
            Controls.Add(txtBoxConfirmarSenha);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtBoxSenha);
            Controls.Add(label3);
            Name = "FrmEsquecMinhaSenha";
            Text = "FrmEsquecMinhaSenha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxSenha;
        private Label label3;
        private Label label1;
        private TextBox txtBoxConfirmarSenha;
        private Label label4;
        private TextBox txtBoxSenhaAtual;
        private Label label2;
        private Button btnAlterar;
    }
}