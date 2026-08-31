namespace Projeto_Integrador.Forms
{
    partial class FrmInventario
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
            dgvInventario = new DataGridView();
            label2 = new Label();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(22, 56);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersWidth = 62;
            dgvInventario.Size = new Size(739, 331);
            dgvInventario.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(352, 15);
            label2.Name = "label2";
            label2.Size = new Size(152, 38);
            label2.TabIndex = 10;
            label2.Text = "Inventário";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(64, 64, 64);
            btnVoltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(611, 398);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(150, 40);
            btnVoltar.TabIndex = 17;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmInventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(label2);
            Controls.Add(dgvInventario);
            Name = "FrmInventario";
            Text = "FrmInventario";
            Load += FrmInventario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInventario;
        private Label label2;
        private Button btnVoltar;
    }
}