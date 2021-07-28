using BancoCaelum.Banco.Contas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BancoCaelum
{



    public partial class Form1 : Form
    {


        private Dictionary<string, Conta> contas;
        private int numeroDeContas = 0;


     

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            this.contas = new Dictionary<string, Conta>();

           

        }

       
        private void textoTitular_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoSaca_Click(object sender, EventArgs e)
        { 


            string value = comboContas.Text;
            Conta selecionada = this.contas[value];

            double valorSaque = String.IsNullOrEmpty(textoValorOperacao.Text) ? 0 : Convert.ToDouble(textoValorOperacao.Text) ;
            try
            {
                selecionada.Sacar(valorSaque);
                MessageBox.Show($"Ola, { selecionada.Titular.Nome }! O seu saldo atual é de {selecionada.Saldo.ToString("C")}");
                textoSaldo.Text = Convert.ToString(selecionada.Saldo.ToString("C"));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Saldo insuficiente!");
            }

            textoValorOperacao.Clear();
    

        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {

            string value = comboContas.Text;
            Conta selecionada = this.contas[value];


            double valorDeposito = String.IsNullOrEmpty(textoValorOperacao.Text) ? 0 : Convert.ToDouble(textoValorOperacao.Text);
            selecionada.Depositar(valorDeposito);
            MessageBox.Show($"Ola, { selecionada.Titular.Nome }! O seu saldo atual é de {selecionada.Saldo.ToString("C")}");
            textoSaldo.Text = Convert.ToString(selecionada.Saldo.ToString("C"));
            textoValorOperacao.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textoValorOperacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {

            string value = comboContas.Text;
            Conta contaSelecionada = this.contas[value];
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textoTitular.Text = contaSelecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);

        }


        public void AdicionaConta(Conta conta)
        {
            this.contas.Add(conta.Titular.Nome, conta);
            this.numeroDeContas++;
            comboContas.Items.Add(conta.Titular.Nome);  
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {

            FormContaCadastro formCadastro = new FormContaCadastro(this);
            formCadastro.ShowDialog();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void botaoImpostos_Click(object sender, EventArgs e)
        {

            ContaCorrente conta = new ContaCorrente();

            conta.Depositar(200.0);
            MessageBox.Show($"Imposto da conta corrente = {conta.CalcularTributo()}");

            ITributavel t = conta;
            MessageBox.Show($"Imposto da conta pela interface = {t.CalcularTributo()}");

            SeguroDeVida sv = new SeguroDeVida();
            MessageBox.Show($"Imposto do seguro {sv.CalcularTributo()}");

            t = sv;
            MessageBox.Show($"Imposto do seguro pela interface {sv.CalcularTributo()}");

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            string nomeTitular = textoBuscaTitular.Text;

            Conta conta = contas[nomeTitular];

            textoTitular.Text = conta.Titular.Nome;
            textoNumero.Text = conta.Numero.ToString();
            textoSaldo.Text = conta.Saldo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRelatorio form = new FormRelatorio(this.contas);
            form.ShowDialog();

        }
    }
}
