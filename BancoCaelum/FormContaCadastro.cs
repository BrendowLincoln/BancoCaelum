using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoCaelum
{
    public partial class FormContaCadastro : Form
    {

        private Form1 formPrincipal;

        public FormContaCadastro(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            this.textoNumeroCadastro.Text = Conta.ProximaConta().ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            Conta novaConta = new ContaCorrente()
            {

                Titular = new Cliente(textoTitularCadastro.Text)

            };

            this.formPrincipal.AdicionaConta(novaConta);

            this.Hide();
            MessageBox.Show($"Nova conta cadastrada com sucesso!");

        }

        private void FormContaCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
