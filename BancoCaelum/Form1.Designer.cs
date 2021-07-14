
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
            this.groupConta.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(168, 27);
            this.textoTitular.Margin = new System.Windows.Forms.Padding(4);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(181, 22);
            this.textoTitular.TabIndex = 0;
            this.textoTitular.TextChanged += new System.EventHandler(this.textoTitular_TextChanged);
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(168, 95);
            this.textoNumero.Margin = new System.Windows.Forms.Padding(4);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(181, 22);
            this.textoNumero.TabIndex = 1;
            this.textoNumero.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(168, 162);
            this.textoSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(181, 22);
            this.textoSaldo.TabIndex = 2;
            this.textoSaldo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // botaoSaca
            // 
            this.botaoSaca.BackColor = System.Drawing.Color.Maroon;
            this.botaoSaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSaca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoSaca.Location = new System.Drawing.Point(212, 315);
            this.botaoSaca.Name = "botaoSaca";
            this.botaoSaca.Size = new System.Drawing.Size(75, 30);
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
            this.botaoDeposito.Location = new System.Drawing.Point(75, 315);
            this.botaoDeposito.Name = "botaoDeposito";
            this.botaoDeposito.Size = new System.Drawing.Size(83, 30);
            this.botaoDeposito.TabIndex = 5;
            this.botaoDeposito.Text = "Depositar";
            this.botaoDeposito.UseVisualStyleBackColor = false;
            this.botaoDeposito.Click += new System.EventHandler(this.botaoDeposito_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titular";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor de depósito";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Saldo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textoValorOperacao
            // 
            this.textoValorOperacao.Location = new System.Drawing.Point(168, 231);
            this.textoValorOperacao.Name = "textoValorOperacao";
            this.textoValorOperacao.Size = new System.Drawing.Size(181, 22);
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
            this.groupConta.Location = new System.Drawing.Point(12, 12);
            this.groupConta.Name = "groupConta";
            this.groupConta.Size = new System.Drawing.Size(416, 402);
            this.groupConta.TabIndex = 11;
            this.groupConta.TabStop = false;
            this.groupConta.Text = "Conta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 439);
            this.Controls.Add(this.groupConta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupConta.ResumeLayout(false);
            this.groupConta.PerformLayout();
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
    }
}