using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BancoCaelum
{



    public partial class Form1 : Form
    {


        private List<Conta> contas;
        private int numeroDeContas = 0;


     

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            this.contas = new List<Conta>();

            this.contas[0] = new Conta();
            this.contas[0].Titular = new Cliente("Brendow Lincoln");
            this.contas[0].Numero = 1;
            this.AdicionaConta(this.contas[0]);

            this.contas[1] = new ContaPoupanca();
            this.contas[1].Titular = new Cliente("Bryan Lincoln");
            this.contas[1].Numero = 2;
            this.AdicionaConta(this.contas[1]);

            this.contas[2] = new ContaCorrente();
            this.contas[2].Titular = new Cliente("Juliana Ribeiro");
            this.contas[2].Numero = 2;
            this.AdicionaConta(this.contas[2]);

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


            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            double valorSaque = String.IsNullOrEmpty(textoValorOperacao.Text) ? 0 : Convert.ToDouble(textoValorOperacao.Text) ;
            if(selecionada.Sacar(valorSaque))
            {
                MessageBox.Show($"Ola, { selecionada.Titular.Nome }! O seu saldo atual é de {selecionada.Saldo.ToString("C")}");
                textoSaldo.Text = Convert.ToString(selecionada.Saldo.ToString("C"));
            }
            else
            {
                MessageBox.Show("Valor inválido!");
            }

            textoValorOperacao.Clear();
    

        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {

            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];


            double valorDeposito = String.IsNullOrEmpty(textoValorOperacao.Text) ? 0 : Convert.ToDouble(textoValorOperacao.Text);
            if (selecionada.Depositar(valorDeposito))
            {
                MessageBox.Show($"Ola, { selecionada.Titular.Nome }! O seu saldo atual é de {selecionada.Saldo.ToString("C")}");
                textoSaldo.Text = Convert.ToString(selecionada.Saldo.ToString("C"));

            }
            else
            {
                MessageBox.Show("Valor inválido!");
            }
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

            int indice = comboContas.SelectedIndex;
            Conta contaSelecionada = this.contas[indice];
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textoTitular.Text = contaSelecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);

        }


        public void AdicionaConta(Conta conta)
        {
            this.contas[this.numeroDeContas] = conta;
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
    }
}
