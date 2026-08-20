namespace Projeto_Integrador.Forms
{
    partial class FrmRanking
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
            btnSair = new Button();
            btnPerfil = new Button();
            dgvRanking = new DataGridView();
            lblNumeroPergunta = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRanking).BeginInit();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Gray;
            btnSair.BackgroundImageLayout = ImageLayout.None;
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(676, 394);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(112, 34);
            btnSair.TabIndex = 12;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.FromArgb(64, 64, 64);
            btnPerfil.BackgroundImageLayout = ImageLayout.None;
            btnPerfil.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPerfil.ForeColor = Color.White;
            btnPerfil.Location = new Point(40, 394);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(112, 34);
            btnPerfil.TabIndex = 13;
            btnPerfil.Text = "Ver perfil";
            btnPerfil.UseVisualStyleBackColor = false;
            btnPerfil.Click += btnPerfil_Click;
            // 
            // dgvRanking
            // 
            dgvRanking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRanking.Location = new Point(40, 68);
            dgvRanking.Name = "dgvRanking";
            dgvRanking.RowHeadersWidth = 62;
            dgvRanking.Size = new Size(740, 320);
            dgvRanking.TabIndex = 14;
            dgvRanking.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblNumeroPergunta
            // 
            lblNumeroPergunta.AutoSize = true;
            lblNumeroPergunta.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblNumeroPergunta.Location = new Point(321, 9);
            lblNumeroPergunta.Name = "lblNumeroPergunta";
            lblNumeroPergunta.Size = new Size(185, 48);
            lblNumeroPergunta.TabIndex = 15;
            lblNumeroPergunta.Text = "RANKING";
            lblNumeroPergunta.Click += lblNumeroPergunta_Click;
            // 
            // FrmRanking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNumeroPergunta);
            Controls.Add(dgvRanking);
            Controls.Add(btnPerfil);
            Controls.Add(btnSair);
            Name = "FrmRanking";
            Text = "FrmRanking";
            ((System.ComponentModel.ISupportInitialize)dgvRanking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSair;
        private Button btnPerfil;
        private DataGridView dgvRanking;
        private Label lblNumeroPergunta;
    }
}