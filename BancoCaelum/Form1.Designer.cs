
namespace BancoCaelum
{
    partial class Form1
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
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.botaoSaca = new System.Windows.Forms.Button();
            this.botaoDeposito = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textoValorOperacao = new System.Windows.Forms.TextBox();
            this.groupConta = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.botaoNovaConta = new System.Windows.Forms.Button();
            this.botaoImpostos = new System.Windows.Forms.Button();
            this.groupConta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(136, 29);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(137, 20);
            this.textoTitular.TabIndex = 0;
            this.textoTitular.TextChanged += new System.EventHandler(this.textoTitular_TextChanged);
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(136, 61);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(137, 20);
            this.textoNumero.TabIndex = 1;
            this.textoNumero.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(136, 89);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(137, 20);
            this.textoSaldo.TabIndex = 2;
            this.textoSaldo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // botaoSaca
            // 
            this.botaoSaca.BackColor = System.Drawing.Color.Maroon;
            this.botaoSaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSaca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoSaca.Location = new System.Drawing.Point(216, 153);
            this.botaoSaca.Margin = new System.Windows.Forms.Padding(2);
            this.botaoSaca.Name = "botaoSaca";
            this.botaoSaca.Size = new System.Drawing.Size(56, 24);
            this.botaoSaca.TabIndex = 3;
            this.botaoSaca.Text = "Sacar";
            this.botaoSaca.UseVisualStyleBackColor = false;
            this.botaoSaca.Click += new System.EventHandler(this.botaoSaca_Click);
            // 
            // botaoDeposito
            // 
            this.botaoDeposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.botaoDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoDeposito.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botaoDeposito.Location = new System.Drawing.Point(138, 153);
            this.botaoDeposito.Margin = new System.Windows.Forms.Padding(2);
            this.botaoDeposito.Name = "botaoDeposito";
            this.botaoDeposito.Size = new System.Drawing.Size(62, 24);
            this.botaoDeposito.TabIndex = 5;
            this.botaoDeposito.Text = "Depositar";
            this.botaoDeposito.UseVisualStyleBackColor = false;
            this.botaoDeposito.Click += new System.EventHandler(this.botaoDeposito_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titular";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor de depósito";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Saldo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textoValorOperacao
            // 
            this.textoValorOperacao.Location = new System.Drawing.Point(136, 113);
            this.textoValorOperacao.Margin = new System.Windows.Forms.Padding(2);
            this.textoValorOperacao.Name = "textoValorOperacao";
            this.textoValorOperacao.Size = new System.Drawing.Size(137, 20);
            this.textoValorOperacao.TabIndex = 10;
            this.textoValorOperacao.TextChanged += new System.EventHandler(this.textoValorOperacao_TextChanged);
            // 
            // groupConta
            // 
            this.groupConta.Controls.Add(this.textoValorOperacao);
            this.groupConta.Controls.Add(this.label4);
            this.groupConta.Controls.Add(this.label3);
            this.groupConta.Controls.Add(this.label2);
            this.groupConta.Controls.Add(this.label1);
            this.groupConta.Controls.Add(this.botaoDeposito);
            this.groupConta.Controls.Add(this.botaoSaca);
            this.groupConta.Controls.Add(this.textoSaldo);
            this.groupConta.Controls.Add(this.textoNumero);
            this.groupConta.Controls.Add(this.textoTitular);
            this.groupConta.Location = new System.Drawing.Point(9, 144);
            this.groupConta.Margin = new System.Windows.Forms.Padding(2);
            this.groupConta.Name = "groupConta";
            this.groupConta.Padding = new System.Windows.Forms.Padding(2);
            this.groupConta.Size = new System.Drawing.Size(312, 193);
            this.groupConta.TabIndex = 11;
            this.groupConta.TabStop = false;
            this.groupConta.Text = "Conta";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Busca Conta";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboContas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(9, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(312, 102);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca Conta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Escolha a conta";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(138, 46);
            this.comboContas.Margin = new System.Windows.Forms.Padding(2);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(135, 21);
            this.comboContas.TabIndex = 15;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // botaoNovaConta
            // 
            this.botaoNovaConta.BackColor = System.Drawing.Color.White;
            this.botaoNovaConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoNovaConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.botaoNovaConta.ForeColor = System.Drawing.Color.Black;
            this.botaoNovaConta.Location = new System.Drawing.Point(9, 359);
            this.botaoNovaConta.Margin = new System.Windows.Forms.Padding(2);
            this.botaoNovaConta.Name = "botaoNovaConta";
            this.botaoNovaConta.Size = new System.Drawing.Size(84, 23);
            this.botaoNovaConta.TabIndex = 16;
            this.botaoNovaConta.Text = "Nova Conta";
            this.botaoNovaConta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botaoNovaConta.UseVisualStyleBackColor = false;
            this.botaoNovaConta.Click += new System.EventHandler(this.botaoNovaConta_Click);
            // 
            // botaoImpostos
            // 
            this.botaoImpostos.BackColor = System.Drawing.Color.Teal;
            this.botaoImpostos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoImpostos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoImpostos.ForeColor = System.Drawing.Color.White;
            this.botaoImpostos.Location = new System.Drawing.Point(215, 359);
            this.botaoImpostos.Name = "botaoImpostos";
            this.botaoImpostos.Size = new System.Drawing.Size(106, 23);
            this.botaoImpostos.TabIndex = 17;
            this.botaoImpostos.Text = "Calcular Impostos";
            this.botaoImpostos.UseVisualStyleBackColor = false;
            this.botaoImpostos.Click += new System.EventHandler(this.botaoImpostos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(386, 396);
            this.Controls.Add(this.botaoImpostos);
            this.Controls.Add(this.botaoNovaConta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupConta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupConta.ResumeLayout(false);
            this.groupConta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.Button botaoSaca;
        private System.Windows.Forms.Button botaoDeposito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textoValorOperacao;
        private System.Windows.Forms.GroupBox groupConta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Button botaoNovaConta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button botaoImpostos;
    }
}