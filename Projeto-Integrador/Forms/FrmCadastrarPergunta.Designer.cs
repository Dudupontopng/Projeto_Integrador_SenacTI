namespace Projeto_Integrador.Forms
{
    partial class FrmCadastrarPergunta
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
            txtBoxEnunciado = new TextBox();
            label2 = new Label();
            rbMultiplaEscolha = new RadioButton();
            rbVerdadeiroFalso = new RadioButton();
            rbIniciante = new RadioButton();
            rbFacil = new RadioButton();
            rbIntermediario = new RadioButton();
            rbAvancado = new RadioButton();
            label5 = new Label();
            cbTema = new ComboBox();
            label6 = new Label();
            txtBoxPontuacao = new TextBox();
            btnCadastrarPergunta = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(225, 20);
            label1.Name = "label1";
            label1.Size = new Size(350, 37);
            label1.TabIndex = 2;
            label1.Text = "Cadastrar Pergunta";
            // 
            // txtBoxEnunciado
            // 
            txtBoxEnunciado.Location = new Point(61, 92);
            txtBoxEnunciado.Name = "txtBoxEnunciado";
            txtBoxEnunciado.Size = new Size(697, 31);
            txtBoxEnunciado.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(319, 57);
            label2.Name = "label2";
            label2.Size = new Size(134, 32);
            label2.TabIndex = 4;
            label2.Text = "Enunciado";
            // 
            // rbMultiplaEscolha
            // 
            rbMultiplaEscolha.AutoSize = true;
            rbMultiplaEscolha.Location = new Point(22, 26);
            rbMultiplaEscolha.Name = "rbMultiplaEscolha";
            rbMultiplaEscolha.Size = new Size(165, 29);
            rbMultiplaEscolha.TabIndex = 8;
            rbMultiplaEscolha.TabStop = true;
            rbMultiplaEscolha.Text = "Multipla escolha";
            rbMultiplaEscolha.UseVisualStyleBackColor = true;
            // 
            // rbVerdadeiroFalso
            // 
            rbVerdadeiroFalso.AutoSize = true;
            rbVerdadeiroFalso.Location = new Point(257, 26);
            rbVerdadeiroFalso.Name = "rbVerdadeiroFalso";
            rbVerdadeiroFalso.Size = new Size(170, 29);
            rbVerdadeiroFalso.TabIndex = 9;
            rbVerdadeiroFalso.TabStop = true;
            rbVerdadeiroFalso.Text = "Verdadeiro/Falso";
            rbVerdadeiroFalso.UseVisualStyleBackColor = true;
            // 
            // rbIniciante
            // 
            rbIniciante.AutoSize = true;
            rbIniciante.Location = new Point(23, 30);
            rbIniciante.Name = "rbIniciante";
            rbIniciante.Size = new Size(102, 29);
            rbIniciante.TabIndex = 10;
            rbIniciante.TabStop = true;
            rbIniciante.Text = "Iniciante";
            rbIniciante.UseVisualStyleBackColor = true;
            // 
            // rbFacil
            // 
            rbFacil.AutoSize = true;
            rbFacil.Location = new Point(182, 36);
            rbFacil.Name = "rbFacil";
            rbFacil.Size = new Size(70, 29);
            rbFacil.TabIndex = 11;
            rbFacil.TabStop = true;
            rbFacil.Text = "Fácil";
            rbFacil.UseVisualStyleBackColor = true;
            // 
            // rbIntermediario
            // 
            rbIntermediario.AutoSize = true;
            rbIntermediario.Location = new Point(312, 33);
            rbIntermediario.Name = "rbIntermediario";
            rbIntermediario.Size = new Size(143, 29);
            rbIntermediario.TabIndex = 12;
            rbIntermediario.TabStop = true;
            rbIntermediario.Text = "Intermediario";
            rbIntermediario.UseVisualStyleBackColor = true;
            // 
            // rbAvancado
            // 
            rbAvancado.AutoSize = true;
            rbAvancado.Location = new Point(472, 30);
            rbAvancado.Name = "rbAvancado";
            rbAvancado.Size = new Size(116, 29);
            rbAvancado.TabIndex = 13;
            rbAvancado.TabStop = true;
            rbAvancado.Text = "Avançado";
            rbAvancado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(354, 260);
            label5.Name = "label5";
            label5.Size = new Size(74, 32);
            label5.TabIndex = 14;
            label5.Text = "Tema";
            // 
            // cbTema
            // 
            cbTema.FormattingEnabled = true;
            cbTema.Items.AddRange(new object[] { "Hardware", "Programação", "Redes", "Segurança Digital", "Sistemas Operacionais", "Ferramentas de produtividade" });
            cbTema.Location = new Point(301, 295);
            cbTema.Name = "cbTema";
            cbTema.Size = new Size(182, 33);
            cbTema.TabIndex = 15;
            cbTema.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(318, 331);
            label6.Name = "label6";
            label6.Size = new Size(135, 32);
            label6.TabIndex = 16;
            label6.Text = "Pontuação";
            // 
            // txtBoxPontuacao
            // 
            txtBoxPontuacao.Location = new Point(319, 366);
            txtBoxPontuacao.Name = "txtBoxPontuacao";
            txtBoxPontuacao.Size = new Size(154, 31);
            txtBoxPontuacao.TabIndex = 17;
            txtBoxPontuacao.KeyPress += txtBoxPontuacao_KeyPress;
            // 
            // btnCadastrarPergunta
            // 
            btnCadastrarPergunta.BackColor = Color.FromArgb(64, 64, 64);
            btnCadastrarPergunta.BackgroundImageLayout = ImageLayout.None;
            btnCadastrarPergunta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCadastrarPergunta.ForeColor = Color.White;
            btnCadastrarPergunta.Location = new Point(332, 403);
            btnCadastrarPergunta.Name = "btnCadastrarPergunta";
            btnCadastrarPergunta.Size = new Size(112, 34);
            btnCadastrarPergunta.TabIndex = 18;
            btnCadastrarPergunta.Text = "Proxima";
            btnCadastrarPergunta.UseVisualStyleBackColor = false;
            btnCadastrarPergunta.Click += btnCadastrarPergunta_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbMultiplaEscolha);
            groupBox1.Controls.Add(rbVerdadeiroFalso);
            groupBox1.Location = new Point(181, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 61);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbIniciante);
            groupBox2.Controls.Add(rbFacil);
            groupBox2.Controls.Add(rbIntermediario);
            groupBox2.Controls.Add(rbAvancado);
            groupBox2.Location = new Point(87, 196);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(605, 65);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nível";
            // 
            // FrmCadastrarPergunta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrarPergunta);
            Controls.Add(txtBoxPontuacao);
            Controls.Add(label6);
            Controls.Add(cbTema);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txtBoxEnunciado);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "FrmCadastrarPergunta";
            Text = "FrmCadastrarPergunta";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxEnunciado;
        private TextBox textBox1;
        private Label label2;
        private RadioButton rbMultiplaEscolha;
        private RadioButton rbVerdadeiroFalso;
        private Label label3;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton rbAvancado;
        private Label label5;
        private ComboBox cbTema;
        private Label label6;
        private TextBox txtBoxPontuacao;
        private Button btnCadastrarPergunta;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rbIntermediario;
        private RadioButton rbFacil;
        private RadioButton rbIniciante;
    }
}