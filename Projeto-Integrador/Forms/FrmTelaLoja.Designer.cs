namespace Projeto_Integrador.Forms
{
    partial class FrmTelaLoja
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
            lblPontos = new Label();
            dgvLoja = new DataGridView();
            label2 = new Label();
            btnVoltar = new Button();
            btnComprar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLoja).BeginInit();
            SuspendLayout();
            // 
            // lblPontos
            // 
            lblPontos.AutoSize = true;
            lblPontos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPontos.Location = new Point(561, 9);
            lblPontos.Name = "lblPontos";
            lblPontos.Size = new Size(100, 32);
            lblPontos.TabIndex = 6;
            lblPontos.Text = "Pontos:";
            // 
            // dgvLoja
            // 
            dgvLoja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoja.Location = new Point(12, 44);
            dgvLoja.Name = "dgvLoja";
            dgvLoja.RowHeadersWidth = 62;
            dgvLoja.Size = new Size(776, 327);
            dgvLoja.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(366, 3);
            label2.Name = "label2";
            label2.Size = new Size(71, 38);
            label2.TabIndex = 9;
            label2.Text = "Loja";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(64, 64, 64);
            btnVoltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(638, 398);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(150, 40);
            btnVoltar.TabIndex = 15;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.FromArgb(64, 64, 64);
            btnComprar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnComprar.ForeColor = Color.White;
            btnComprar.Location = new Point(482, 398);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(150, 40);
            btnComprar.TabIndex = 16;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // FrmTelaLoja
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnComprar);
            Controls.Add(btnVoltar);
            Controls.Add(label2);
            Controls.Add(dgvLoja);
            Controls.Add(lblPontos);
            Name = "FrmTelaLoja";
            Text = "FrmTelaLoja";
            Load += FrmTelaLoja_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPontos;
        private DataGridView dgvLoja;
        private Label label2;
        private Button btnVoltar;
        private Button btnComprar;
    }
}