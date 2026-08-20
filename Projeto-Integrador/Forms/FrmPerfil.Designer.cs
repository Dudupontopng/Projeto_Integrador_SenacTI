namespace Projeto_Integrador.Forms
{
    partial class FrmPerfil
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
            lblNick = new Label();
            lblNivelProgresso = new Label();
            lblPontuacaoTotal = new Label();
            lblAcertos = new Label();
            lblPerguntasRespondidas = new Label();
            lblTemaDominante = new Label();
            btnLogin = new Button();
            lnkConquistas = new LinkLabel();
            lnkHistorico = new LinkLabel();
            SuspendLayout();
            // 
            // lblNick
            // 
            lblNick.AutoSize = true;
            lblNick.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNick.Location = new Point(335, 72);
            lblNick.Name = "lblNick";
            lblNick.Size = new Size(87, 45);
            lblNick.TabIndex = 1;
            lblNick.Text = "Nick";
            lblNick.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNivelProgresso
            // 
            lblNivelProgresso.AutoSize = true;
            lblNivelProgresso.Font = new Font("Segoe UI", 12F);
            lblNivelProgresso.Location = new Point(279, 117);
            lblNivelProgresso.Name = "lblNivelProgresso";
            lblNivelProgresso.Size = new Size(201, 32);
            lblNivelProgresso.TabIndex = 2;
            lblNivelProgresso.Text = "Nível e progresso";
            lblNivelProgresso.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPontuacaoTotal
            // 
            lblPontuacaoTotal.AutoSize = true;
            lblPontuacaoTotal.Font = new Font("Segoe UI", 11F);
            lblPontuacaoTotal.Location = new Point(82, 205);
            lblPontuacaoTotal.Name = "lblPontuacaoTotal";
            lblPontuacaoTotal.Size = new Size(167, 30);
            lblPontuacaoTotal.TabIndex = 3;
            lblPontuacaoTotal.Text = "Pontuação total:";
            lblPontuacaoTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAcertos
            // 
            lblAcertos.AutoSize = true;
            lblAcertos.Font = new Font("Segoe UI", 11F);
            lblAcertos.Location = new Point(82, 244);
            lblAcertos.Name = "lblAcertos";
            lblAcertos.Size = new Size(205, 30);
            lblAcertos.TabIndex = 4;
            lblAcertos.Text = "Número de acertos:";
            lblAcertos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPerguntasRespondidas
            // 
            lblPerguntasRespondidas.AutoSize = true;
            lblPerguntasRespondidas.Font = new Font("Segoe UI", 11F);
            lblPerguntasRespondidas.Location = new Point(82, 283);
            lblPerguntasRespondidas.Name = "lblPerguntasRespondidas";
            lblPerguntasRespondidas.Size = new Size(237, 30);
            lblPerguntasRespondidas.TabIndex = 5;
            lblPerguntasRespondidas.Text = "Perguntas respondidas:";
            lblPerguntasRespondidas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTemaDominante
            // 
            lblTemaDominante.AutoSize = true;
            lblTemaDominante.Font = new Font("Segoe UI", 11F);
            lblTemaDominante.Location = new Point(82, 324);
            lblTemaDominante.Name = "lblTemaDominante";
            lblTemaDominante.Size = new Size(180, 30);
            lblTemaDominante.TabIndex = 6;
            lblTemaDominante.Text = "Tema dominante:";
            lblTemaDominante.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(64, 64, 64);
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(533, 367);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(234, 58);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Voltar ao menu Principal";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnkConquistas
            // 
            lnkConquistas.AutoSize = true;
            lnkConquistas.Location = new Point(677, 9);
            lnkConquistas.Name = "lnkConquistas";
            lnkConquistas.Size = new Size(100, 25);
            lnkConquistas.TabIndex = 8;
            lnkConquistas.TabStop = true;
            lnkConquistas.Text = "Conquistas";
            lnkConquistas.LinkClicked += lnkConquistas_LinkClicked;
            // 
            // lnkHistorico
            // 
            lnkHistorico.AutoSize = true;
            lnkHistorico.Location = new Point(694, 34);
            lnkHistorico.Name = "lnkHistorico";
            lnkHistorico.Size = new Size(83, 25);
            lnkHistorico.TabIndex = 9;
            lnkHistorico.TabStop = true;
            lnkHistorico.Text = "Histórico";
            lnkHistorico.LinkClicked += lnkHistorico_LinkClicked;
            // 
            // FrmPerfil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lnkHistorico);
            Controls.Add(lnkConquistas);
            Controls.Add(btnLogin);
            Controls.Add(lblTemaDominante);
            Controls.Add(lblPerguntasRespondidas);
            Controls.Add(lblAcertos);
            Controls.Add(lblPontuacaoTotal);
            Controls.Add(lblNivelProgresso);
            Controls.Add(lblNick);
            Name = "FrmPerfil";
            Text = "FrmPerfil";
            Load += FrmPerfil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNick;
        private Label lblNivelProgresso;
        private Label lblPontuacaoTotal;
        private Label lblAcertos;
        private Label lblPerguntasRespondidas;
        private Label lblTemaDominante;
        private Button btnLogin;
        private LinkLabel lnkConquistas;
        private LinkLabel lnkHistorico;
    }
}