namespace Projeto_Integrador.Forms
{
    partial class UcConquista
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitulo = new System.Windows.Forms.Label();
            lblProgresso = new System.Windows.Forms.Label();
            picIcone = new System.Windows.Forms.PictureBox();
            toolTipDescricao = new System.Windows.Forms.ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)picIcone).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblTitulo.Location = new System.Drawing.Point(115, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(56, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título";
            // 
            // lblProgresso
            // 
            lblProgresso.AutoSize = true;
            lblProgresso.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblProgresso.Location = new System.Drawing.Point(115, 45);
            lblProgresso.Name = "lblProgresso";
            lblProgresso.Size = new System.Drawing.Size(39, 20);
            lblProgresso.TabIndex = 1;
            lblProgresso.Text = "0/10";
            // 
            // picIcone
            // 
            picIcone.Location = new System.Drawing.Point(15, 15);
            picIcone.Name = "picIcone";
            picIcone.Size = new System.Drawing.Size(80, 80);
            picIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picIcone.TabIndex = 2;
            picIcone.TabStop = false;
            // 
            // UcConquista
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightGray;
            Controls.Add(picIcone);
            Controls.Add(lblProgresso);
            Controls.Add(lblTitulo);
            Name = "UcConquista";
            Size = new System.Drawing.Size(350, 110);
            ((System.ComponentModel.ISupportInitialize)picIcone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblProgresso;
        private System.Windows.Forms.PictureBox picIcone;
        private System.Windows.Forms.ToolTip toolTipDescricao;
    }
}