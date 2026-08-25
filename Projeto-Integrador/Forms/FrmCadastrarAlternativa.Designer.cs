namespace Projeto_Integrador.Forms
{
    partial class FrmCadastrarAlternativa
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxAlternativa1 = new TextBox();
            txtBoxAlternativa3 = new TextBox();
            txtBoxAlternativa2 = new TextBox();
            txtBoxAlternativa4 = new TextBox();
            btnCadastrarAlternativas = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblEnunciado
            // 
            lblEnunciado.Anchor = AnchorStyles.Top;
            lblEnunciado.AutoSize = true;
            lblEnunciado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEnunciado.Location = new Point(67, 48);
            lblEnunciado.MaximumSize = new Size(550, 100);
            lblEnunciado.Name = "lblEnunciado";
            lblEnunciado.Size = new Size(136, 28);
            lblEnunciado.TabIndex = 7;
            lblEnunciado.Text = "Alternativa 1";
            lblEnunciado.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(565, 48);
            label1.MaximumSize = new Size(550, 100);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 8;
            label1.Text = "Alternativa 2";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(67, 209);
            label2.MaximumSize = new Size(550, 100);
            label2.Name = "label2";
            label2.Size = new Size(136, 28);
            label2.TabIndex = 9;
            label2.Text = "Alternativa 3";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(565, 209);
            label3.MaximumSize = new Size(550, 100);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 10;
            label3.Text = "Alternativa 4";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtBoxAlternativa1
            // 
            txtBoxAlternativa1.Location = new Point(12, 79);
            txtBoxAlternativa1.Name = "txtBoxAlternativa1";
            txtBoxAlternativa1.Size = new Size(324, 31);
            txtBoxAlternativa1.TabIndex = 11;
            // 
            // txtBoxAlternativa3
            // 
            txtBoxAlternativa3.Location = new Point(12, 240);
            txtBoxAlternativa3.Name = "txtBoxAlternativa3";
            txtBoxAlternativa3.Size = new Size(324, 31);
            txtBoxAlternativa3.TabIndex = 12;
            // 
            // txtBoxAlternativa2
            // 
            txtBoxAlternativa2.Location = new Point(464, 79);
            txtBoxAlternativa2.Name = "txtBoxAlternativa2";
            txtBoxAlternativa2.Size = new Size(324, 31);
            txtBoxAlternativa2.TabIndex = 13;
            // 
            // txtBoxAlternativa4
            // 
            txtBoxAlternativa4.Location = new Point(464, 240);
            txtBoxAlternativa4.Name = "txtBoxAlternativa4";
            txtBoxAlternativa4.Size = new Size(324, 31);
            txtBoxAlternativa4.TabIndex = 14;
            // 
            // btnCadastrarAlternativas
            // 
            btnCadastrarAlternativas.BackColor = Color.FromArgb(64, 64, 64);
            btnCadastrarAlternativas.BackgroundImageLayout = ImageLayout.None;
            btnCadastrarAlternativas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCadastrarAlternativas.ForeColor = Color.White;
            btnCadastrarAlternativas.Location = new Point(338, 387);
            btnCadastrarAlternativas.Name = "btnCadastrarAlternativas";
            btnCadastrarAlternativas.Size = new Size(112, 34);
            btnCadastrarAlternativas.TabIndex = 15;
            btnCadastrarAlternativas.Text = "Cadastrar";
            btnCadastrarAlternativas.UseVisualStyleBackColor = false;
            btnCadastrarAlternativas.Click += btnCadastrarAlternativas_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Alternativa 1", "Alternativa 2", "Alternativa 3", "Alternativa 4" });
            comboBox1.Location = new Point(307, 310);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 16;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(353, 267);
            label4.MaximumSize = new Size(550, 100);
            label4.Name = "label4";
            label4.Size = new Size(82, 28);
            label4.TabIndex = 17;
            label4.Text = "Correta";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmCadastrarAlternativa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(btnCadastrarAlternativas);
            Controls.Add(txtBoxAlternativa4);
            Controls.Add(txtBoxAlternativa2);
            Controls.Add(txtBoxAlternativa3);
            Controls.Add(txtBoxAlternativa1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblEnunciado);
            Name = "FrmCadastrarAlternativa";
            Text = "FrmCadastrarAlternativa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnunciado;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxAlternativa1;
        private TextBox txtBoxAlternativa3;
        private TextBox txtBoxAlternativa2;
        private TextBox txtBoxAlternativa4;
        private Button btnCadastrarAlternativas;
        private ComboBox comboBox1;
        private Label label4;
    }
}