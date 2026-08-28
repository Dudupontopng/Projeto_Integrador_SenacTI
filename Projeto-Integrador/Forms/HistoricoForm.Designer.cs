namespace Projeto_Integrador.Forms
{
    partial class HistoricoForm
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
            dgvHistorico = new DataGridView();
            btnCadastro = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorico
            // 
            dgvHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorico.Location = new Point(41, 30);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.ReadOnly = true;
            dgvHistorico.RowHeadersWidth = 62;
            dgvHistorico.Size = new Size(709, 347);
            dgvHistorico.TabIndex = 0;
            dgvHistorico.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = Color.FromArgb(64, 64, 64);
            btnCadastro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCadastro.ForeColor = Color.White;
            btnCadastro.Location = new Point(593, 398);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(157, 40);
            btnCadastro.TabIndex = 15;
            btnCadastro.Text = "Voltar ao Menu";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // HistoricoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastro);
            Controls.Add(dgvHistorico);
            Name = "HistoricoForm";
            Text = "HistoricoForm";
            Load += HistoricoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHistorico;
        private Button btnCadastro;
    }
}