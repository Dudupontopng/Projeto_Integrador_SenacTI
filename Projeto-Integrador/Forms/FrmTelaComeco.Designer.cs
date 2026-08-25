namespace Projeto_Integrador.Forms
{
    partial class FrmTelaComeco
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
            btnIniciar = new Button();
            btnRanking = new Button();
            btnHistorico = new Button();
            btnSair = new Button();
            pictureBox1 = new PictureBox();
            btnPerfil = new Button();
            btnCriarPergunta = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(354, 29);
            label1.Name = "label1";
            label1.Size = new Size(90, 37);
            label1.TabIndex = 1;
            label1.Text = "QUIZ";
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(64, 64, 64);
            btnIniciar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(299, 117);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(200, 70);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "INICIAR";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnRanking
            // 
            btnRanking.BackColor = Color.FromArgb(64, 64, 64);
            btnRanking.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRanking.ForeColor = Color.White;
            btnRanking.Location = new Point(299, 193);
            btnRanking.Name = "btnRanking";
            btnRanking.Size = new Size(200, 70);
            btnRanking.TabIndex = 3;
            btnRanking.Text = "RANKING";
            btnRanking.UseVisualStyleBackColor = false;
            btnRanking.Click += btnRanking_Click;
            // 
            // btnHistorico
            // 
            btnHistorico.BackColor = Color.FromArgb(64, 64, 64);
            btnHistorico.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHistorico.ForeColor = Color.White;
            btnHistorico.Location = new Point(299, 269);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(200, 70);
            btnHistorico.TabIndex = 4;
            btnHistorico.Text = "HISTÓRICO";
            btnHistorico.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Gray;
            btnSair.BackgroundImageLayout = ImageLayout.None;
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(345, 380);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(112, 34);
            btnSair.TabIndex = 6;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.prefil_certo_removebg_preview;
            pictureBox1.Location = new Point(659, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.FromArgb(64, 64, 64);
            btnPerfil.BackgroundImageLayout = ImageLayout.None;
            btnPerfil.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPerfil.ForeColor = Color.White;
            btnPerfil.Location = new Point(668, 104);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(112, 34);
            btnPerfil.TabIndex = 9;
            btnPerfil.Text = "Perfil";
            btnPerfil.UseVisualStyleBackColor = false;
            btnPerfil.Click += btnPerfil_Click;
            // 
            // btnCriarPergunta
            // 
            btnCriarPergunta.BackColor = Color.FromArgb(64, 64, 64);
            btnCriarPergunta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCriarPergunta.ForeColor = Color.White;
            btnCriarPergunta.Location = new Point(299, 117);
            btnCriarPergunta.Name = "btnCriarPergunta";
            btnCriarPergunta.Size = new Size(200, 70);
            btnCriarPergunta.TabIndex = 10;
            btnCriarPergunta.Text = "CRIAR PERGUNTA";
            btnCriarPergunta.UseVisualStyleBackColor = false;
            btnCriarPergunta.Visible = false;
            btnCriarPergunta.Click += btnCriarPergunta_Click;
            // 
            // FrmTelaComeco
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(839, 510);
            Controls.Add(btnCriarPergunta);
            Controls.Add(btnPerfil);
            Controls.Add(pictureBox1);
            Controls.Add(btnSair);
            Controls.Add(btnHistorico);
            Controls.Add(btnRanking);
            Controls.Add(btnIniciar);
            Controls.Add(label1);
            Name = "FrmTelaComeco";
            Text = "FrmTelaComeco";
            Load += FrmTelaComeco_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnIniciar;
        private Button btnRanking;
        private Button btnHistorico;
        private Button btnSair;
        private PictureBox pictureBox1;
        private Button btnPerfil;
        private Button btnCriarPergunta;
    }
}