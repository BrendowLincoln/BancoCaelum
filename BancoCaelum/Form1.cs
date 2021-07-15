using System;
using System.Globalization;
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



    public partial class Form1 : Form
    {


        private Conta conta;
        private TotalizadorDeContas totalizador;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.conta = new  ContaCorrente();
            this.totalizador = new TotalizadorDeContas();
            this.totalizador.Adiciona(this.conta);
            MessageBox.Show(totalizador.SaldoTotal.ToString());
            conta.Numero = 1;
            Cliente cliente = new Cliente("Brendow Lincoln");
            conta.Titular = cliente;
            textoTitular.Text = conta.Titular.Nome;
            textoNumero.Text = Convert.ToString(conta.Numero);
            textoSaldo.Text = Convert.ToString(conta.Saldo.ToString("C"));

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
            double valorSaque = String.IsNullOrEmpty(textoValorOperacao.Text) ? 0 : Convert.ToDouble(textoValorOperacao.Text) ;
            if(conta.Sacar(valorSaque))
            {
                MessageBox.Show($"O seu saldo atual é de {conta.Saldo.ToString("C")}");
                textoSaldo.Text = Convert.ToString(conta.Saldo.ToString("C"));
            }
            else
            {
                MessageBox.Show("Valor inválido!");
            }

            textoValorOperacao.Clear();
    

        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            double valorDeposito = String.IsNullOrEmpty(textoValorOperacao.Text) ? 0 : Convert.ToDouble(textoValorOperacao.Text);
            if (conta.Depositar(valorDeposito))
            {
                MessageBox.Show($"O seu saldo atual é de {conta.Saldo.ToString("C")}");
                textoSaldo.Text = Convert.ToString(conta.Saldo.ToString("C"));

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



        /* private void button1_Click(object sender, EventArgs e)
         {


             Cliente user1 = new Cliente();
             Conta conta = new Conta();


             conta.Numero = 1;
             conta.Titular = user1;

             Cliente user2 = new Cliente();
             Conta conta2 = new Conta();

             conta2.Numero = 2;
             conta2.Titular = user2;

             if (conta.Depositar(54.09))
             {
                 MessageBox.Show($"O valor da conta é {conta.Saldo.ToString("C")}");
             }
             else
             {
                 MessageBox.Show("Saldo insuficiente!");
             }

         }

         private void button2_Click(object sender, EventArgs e)
         {


             Cliente user1 = new Cliente();
             Conta conta = new Conta();


             conta.Numero = 1;
             conta.Titular = user1;

             Cliente user2 = new Cliente();
             Conta conta2 = new Conta();

             conta2.Numero = 2;
             conta2.Titular = user2;


             if (conta.Sacar(53.95))
             {
                 MessageBox.Show($"O valor da conta2 é {conta2.Saldo.ToString("C")}");
             }
             else
             {
                 MessageBox.Show("Saldo insuficiente!");
             }

         }

         private void button3_Click(object sender, EventArgs e)
         {
             Cliente user1 = new Cliente();
             Conta conta = new Conta();


             conta.Numero = 1;
             conta.Titular = user1;

             Cliente user2 = new Cliente();
             Conta conta2 = new Conta();

             conta2.Numero = 2;
             conta2.Titular = user2;


             if (conta.Transferir(conta2, 53.95))
             {
                 MessageBox.Show($"O valor da conta2 é {conta2.Saldo.ToString("C")}");
             }
             else
             {
                 MessageBox.Show("Saldo insuficiente!");
             }


         }

         private void button4_Click(object sender, EventArgs e)
         {

             Cliente user1 = new Cliente("Brendow Lincoln")
             {

                 Cpf = "17240515710",
                 Rg = "27966620",
                 Idade = 21

             };
             Conta conta = new Conta();

             conta.Numero = 1;
             conta.Titular = user1;


             conta.Titular = user1;


             MessageBox.Show($"O nome do titular: {conta.Titular.Nome}");

             MessageBox.Show($"O RG do titular: {conta.Titular.Rg}");


             if (conta.Titular.EMaiorDeIdade())
             {
                 MessageBox.Show("E maior de idade!");
             }
             else
             {
                 MessageBox.Show("Nao e maior de idade!");

             }



         }*/



    }
}
