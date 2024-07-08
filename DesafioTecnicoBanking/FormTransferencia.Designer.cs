namespace DesafioTecnicoBanking
{
    partial class FormTransferencia
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
            botaoCancelar = new Button();
            botaoTransferir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboRemetente = new ComboBox();
            comboDestino = new ComboBox();
            textoValor = new TextBox();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // botaoCancelar
            // 
            botaoCancelar.Location = new Point(164, 177);
            botaoCancelar.Name = "botaoCancelar";
            botaoCancelar.Size = new Size(94, 29);
            botaoCancelar.TabIndex = 0;
            botaoCancelar.Text = "Cancelar";
            botaoCancelar.UseVisualStyleBackColor = true;
            botaoCancelar.Click += botaoCancelar_Click;
            // 
            // botaoTransferir
            // 
            botaoTransferir.Location = new Point(41, 177);
            botaoTransferir.Name = "botaoTransferir";
            botaoTransferir.Size = new Size(94, 29);
            botaoTransferir.TabIndex = 1;
            botaoTransferir.Text = "Transferir";
            botaoTransferir.UseVisualStyleBackColor = true;
            botaoTransferir.Click += botaoTransferir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 32);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 2;
            label1.Text = "Remetente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 73);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "Destino";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 118);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 4;
            label3.Text = "Valor";
            // 
            // comboRemetente
            // 
            comboRemetente.FormattingEnabled = true;
            comboRemetente.Location = new Point(133, 29);
            comboRemetente.Name = "comboRemetente";
            comboRemetente.Size = new Size(151, 28);
            comboRemetente.TabIndex = 5;
            // 
            // comboDestino
            // 
            comboDestino.FormattingEnabled = true;
            comboDestino.Location = new Point(133, 70);
            comboDestino.Name = "comboDestino";
            comboDestino.Size = new Size(151, 28);
            comboDestino.TabIndex = 6;
            // 
            // textoValor
            // 
            textoValor.Location = new Point(133, 115);
            textoValor.Name = "textoValor";
            textoValor.Size = new Size(125, 27);
            textoValor.TabIndex = 7;
            textoValor.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 242);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transferência";
            // 
            // FormTransferencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 318);
            Controls.Add(textoValor);
            Controls.Add(comboDestino);
            Controls.Add(comboRemetente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(botaoTransferir);
            Controls.Add(botaoCancelar);
            Controls.Add(groupBox1);
            Name = "FormTransferencia";
            Text = "Transferencia";
            Load += FormTransferencia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botaoCancelar;
        private Button botaoTransferir;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboRemetente;
        private ComboBox comboDestino;
        private TextBox textoValor;
        private GroupBox groupBox1;
    }
}