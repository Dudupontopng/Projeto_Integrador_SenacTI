namespace Projeto_Integrador.Forms
{
    partial class FrmGabarito
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
            dgvGabarito = new DataGridView();
            btnMenuInicial = new Button();
            lblPontuacaoFinal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGabarito).BeginInit();
            SuspendLayout();
            // 
            // dgvGabarito
            // 
            dgvGabarito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGabarito.Location = new Point(38, 26);
            dgvGabarito.Name = "dgvGabarito";
            dgvGabarito.RowHeadersWidth = 62;
            dgvGabarito.Size = new Size(720, 355);
            dgvGabarito.TabIndex = 0;
            // 
            // btnMenuInicial
            // 
            btnMenuInicial.BackColor = Color.FromArgb(64, 64, 64);
            btnMenuInicial.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMenuInicial.ForeColor = Color.White;
            btnMenuInicial.Location = new Point(601, 398);
            btnMenuInicial.Name = "btnMenuInicial";
            btnMenuInicial.Size = new Size(157, 40);
            btnMenuInicial.TabIndex = 16;
            btnMenuInicial.Text = "Voltar ao Menu";
            btnMenuInicial.UseVisualStyleBackColor = false;
            btnMenuInicial.Click += btnMenuInicial_Click;
            // 
            // lblPontuacaoFinal
            // 
            lblPontuacaoFinal.AutoSize = true;
            lblPontuacaoFinal.Location = new Point(49, 398);
            lblPontuacaoFinal.Name = "lblPontuacaoFinal";
            lblPontuacaoFinal.Size = new Size(0, 25);
            lblPontuacaoFinal.TabIndex = 17;
            // 
            // FrmGabarito
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPontuacaoFinal);
            Controls.Add(btnMenuInicial);
            Controls.Add(dgvGabarito);
            Name = "FrmGabarito";
            Text = "FrmGabarito";
            Load += FrmGabarito_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGabarito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGabarito;
        private Button btnMenuInicial;
        private Label lblPontuacaoFinal;
    }
}