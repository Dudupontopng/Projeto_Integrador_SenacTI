namespace Projeto_Integrador.Forms
{
    partial class FrmPerguntaAlternativas
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
            lblEnunciado = new Label();
            lblNumeroPergunta = new Label();
            btnProximo = new Button();
            btnAlternativa1 = new Button();
            btnAlternativa2 = new Button();
            btnAlternativa3 = new Button();
            btnAlternativa4 = new Button();
            lblPontosPergunta = new Label();
            SuspendLayout();
            // 
            // lblEnunciado
            // 
            lblEnunciado.AutoSize = true;
            lblEnunciado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEnunciado.Location = new Point(212, 64);
            lblEnunciado.MaximumSize = new Size(360, 360);
            lblEnunciado.Name = "lblEnunciado";
            lblEnunciado.Size = new Size(110, 28);
            lblEnunciado.TabIndex = 6;
            lblEnunciado.Text = "Enunciado";
            // 
            // lblNumeroPergunta
            // 
            lblNumeroPergunta.AutoSize = true;
            lblNumeroPergunta.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblNumeroPergunta.Location = new Point(249, 4);
            lblNumeroPergunta.Name = "lblNumeroPergunta";
            lblNumeroPergunta.Size = new Size(311, 48);
            lblNumeroPergunta.TabIndex = 7;
            lblNumeroPergunta.Text = "NumeroPergunta";
            // 
            // btnProximo
            // 
            btnProximo.BackColor = Color.FromArgb(64, 64, 64);
            btnProximo.BackgroundImageLayout = ImageLayout.None;
            btnProximo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnProximo.ForeColor = Color.White;
            btnProximo.Location = new Point(633, 404);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(112, 34);
            btnProximo.TabIndex = 8;
            btnProximo.Text = "Proximo";
            btnProximo.UseVisualStyleBackColor = false;
            btnProximo.Click += btnProximo_Click_1;
            // 
            // btnAlternativa1
            // 
            btnAlternativa1.BackColor = Color.FromArgb(64, 64, 64);
            btnAlternativa1.BackgroundImageLayout = ImageLayout.None;
            btnAlternativa1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAlternativa1.ForeColor = Color.White;
            btnAlternativa1.Location = new Point(70, 149);
            btnAlternativa1.Name = "btnAlternativa1";
            btnAlternativa1.Size = new Size(272, 105);
            btnAlternativa1.TabIndex = 9;
            btnAlternativa1.Text = "Alternativa1";
            btnAlternativa1.UseVisualStyleBackColor = false;
            btnAlternativa1.Click += btnAlternativa1_Click;
            // 
            // btnAlternativa2
            // 
            btnAlternativa2.BackColor = Color.FromArgb(64, 64, 64);
            btnAlternativa2.BackgroundImageLayout = ImageLayout.None;
            btnAlternativa2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAlternativa2.ForeColor = Color.White;
            btnAlternativa2.Location = new Point(443, 149);
            btnAlternativa2.Name = "btnAlternativa2";
            btnAlternativa2.Size = new Size(272, 105);
            btnAlternativa2.TabIndex = 10;
            btnAlternativa2.Text = "Alternativa2";
            btnAlternativa2.UseVisualStyleBackColor = false;
            btnAlternativa2.Click += btnAlternativa2_Click;
            // 
            // btnAlternativa3
            // 
            btnAlternativa3.BackColor = Color.FromArgb(64, 64, 64);
            btnAlternativa3.BackgroundImageLayout = ImageLayout.None;
            btnAlternativa3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAlternativa3.ForeColor = Color.White;
            btnAlternativa3.Location = new Point(70, 283);
            btnAlternativa3.Name = "btnAlternativa3";
            btnAlternativa3.Size = new Size(272, 105);
            btnAlternativa3.TabIndex = 11;
            btnAlternativa3.Text = "Alternativa3";
            btnAlternativa3.UseVisualStyleBackColor = false;
            btnAlternativa3.Click += btnAlternativa3_Click;
            // 
            // btnAlternativa4
            // 
            btnAlternativa4.BackColor = Color.FromArgb(64, 64, 64);
            btnAlternativa4.BackgroundImageLayout = ImageLayout.None;
            btnAlternativa4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAlternativa4.ForeColor = Color.White;
            btnAlternativa4.Location = new Point(443, 283);
            btnAlternativa4.Name = "btnAlternativa4";
            btnAlternativa4.Size = new Size(272, 105);
            btnAlternativa4.TabIndex = 12;
            btnAlternativa4.Text = "Alternativa4";
            btnAlternativa4.UseVisualStyleBackColor = false;
            btnAlternativa4.Click += btnAlternativa4_Click;
            // 
            // lblPontosPergunta
            // 
            lblPontosPergunta.AutoSize = true;
            lblPontosPergunta.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblPontosPergunta.Location = new Point(12, 4);
            lblPontosPergunta.Name = "lblPontosPergunta";
            lblPontosPergunta.Size = new Size(290, 48);
            lblPontosPergunta.TabIndex = 13;
            lblPontosPergunta.Text = "PontosPergunta";
            // 
            // FrmPerguntaAlternativas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 450);
            Controls.Add(lblPontosPergunta);
            Controls.Add(btnAlternativa4);
            Controls.Add(btnAlternativa3);
            Controls.Add(btnAlternativa2);
            Controls.Add(btnAlternativa1);
            Controls.Add(btnProximo);
            Controls.Add(lblNumeroPergunta);
            Controls.Add(lblEnunciado);
            Name = "FrmPerguntaAlternativas";
            Text = "FrmPerguntaAlternativas";
            Load += FrmPerguntaAlternativas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnunciado;
        private Label lblNumeroPergunta;
        private Button btnProximo;
        private Button btnAlternativa1;
        private Button btnAlternativa2;
        private Button btnAlternativa3;
        private Button btnAlternativa4;
        private Label lblPontosPergunta;
    }
}