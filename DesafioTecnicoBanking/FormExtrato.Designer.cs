namespace DesafioTecnicoBanking
{
    partial class FormExtrato
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
            Extrato = new ListBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            botaoVoltar = new Button();
            SuspendLayout();
            // 
            // Extrato
            // 
            Extrato.FormattingEnabled = true;
            Extrato.Location = new Point(12, 58);
            Extrato.Name = "Extrato";
            Extrato.Size = new Size(429, 224);
            Extrato.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 1;
            label1.Text = "Escolha a conta:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(153, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // botaoVoltar
            // 
            botaoVoltar.Location = new Point(23, 304);
            botaoVoltar.Name = "botaoVoltar";
            botaoVoltar.Size = new Size(94, 29);
            botaoVoltar.TabIndex = 3;
            botaoVoltar.Text = "Voltar";
            botaoVoltar.UseVisualStyleBackColor = true;
            botaoVoltar.Click += botaoVoltar_Click;
            // 
            // FormExtrato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botaoVoltar);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(Extrato);
            Name = "FormExtrato";
            Text = "Extrato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Extrato;
        private Label label1;
        private ComboBox comboBox1;
        private Button botaoVoltar;
    }
}