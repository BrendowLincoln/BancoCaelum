
namespace BancoCaelum
{
    partial class FormContaCadastro
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
            this.label2 = new System.Windows.Forms.Label();
            this.textoTitularCadastro = new System.Windows.Forms.TextBox();
            this.botaoCadastro = new System.Windows.Forms.Button();
            this.labelNumero = new System.Windows.Forms.Label();
            this.textoNumeroCadastro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titular";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textoTitularCadastro
            // 
            this.textoTitularCadastro.Location = new System.Drawing.Point(151, 97);
            this.textoTitularCadastro.Name = "textoTitularCadastro";
            this.textoTitularCadastro.Size = new System.Drawing.Size(145, 20);
            this.textoTitularCadastro.TabIndex = 3;
            // 
            // botaoCadastro
            // 
            this.botaoCadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botaoCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCadastro.Location = new System.Drawing.Point(221, 135);
            this.botaoCadastro.Name = "botaoCadastro";
            this.botaoCadastro.Size = new System.Drawing.Size(75, 23);
            this.botaoCadastro.TabIndex = 4;
            this.botaoCadastro.Text = "Cadastrar";
            this.botaoCadastro.UseVisualStyleBackColor = false;
            this.botaoCadastro.Click += new System.EventHandler(this.botaoCadastro_Click);
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(74, 54);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(44, 13);
            this.labelNumero.TabIndex = 0;
            this.labelNumero.Text = "Numero";
            // 
            // textoNumeroCadastro
            // 
            this.textoNumeroCadastro.Location = new System.Drawing.Point(151, 54);
            this.textoNumeroCadastro.Name = "textoNumeroCadastro";
            this.textoNumeroCadastro.Size = new System.Drawing.Size(145, 20);
            this.textoNumeroCadastro.TabIndex = 2;
            // 
            // FormContaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 226);
            this.Controls.Add(this.botaoCadastro);
            this.Controls.Add(this.textoTitularCadastro);
            this.Controls.Add(this.textoNumeroCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNumero);
            this.Name = "FormContaCadastro";
            this.Text = "FormContaCadastro";
            this.Load += new System.EventHandler(this.FormContaCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoTitularCadastro;
        private System.Windows.Forms.Button botaoCadastro;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.TextBox textoNumeroCadastro;
    }
}