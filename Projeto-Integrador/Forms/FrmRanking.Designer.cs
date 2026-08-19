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
            btnVerPerfil = new Button();
            dataGridView1 = new DataGridView();
            lblNumeroPergunta = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // btnVerPerfil
            // 
            btnVerPerfil.BackColor = Color.FromArgb(64, 64, 64);
            btnVerPerfil.BackgroundImageLayout = ImageLayout.None;
            btnVerPerfil.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVerPerfil.ForeColor = Color.White;
            btnVerPerfil.Location = new Point(40, 394);
            btnVerPerfil.Name = "btnVerPerfil";
            btnVerPerfil.Size = new Size(112, 34);
            btnVerPerfil.TabIndex = 13;
            btnVerPerfil.Text = "Ver perfil";
            btnVerPerfil.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(740, 320);
            dataGridView1.TabIndex = 14;
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
            Controls.Add(dataGridView1);
            Controls.Add(btnVerPerfil);
            Controls.Add(btnSair);
            Name = "FrmRanking";
            Text = "FrmRanking";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSair;
        private Button btnVerPerfil;
        private DataGridView dataGridView1;
        private Label lblNumeroPergunta;
    }
}