using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCaelum.Banco.Contas
{
    class ContaPoupanca : Conta, ITributavel
    {


        public ContaPoupanca()
        {

        }

        public ContaPoupanca(int numero):  base (numero) { }

       

        public override bool Depositar(double valor)
        {
            if (valor != 0 && valor > 0)
            {

                Saldo += valor;
                return true;
            }

            return false;
        }

        public override bool Sacar(double valor)
        {

            if (valor != 0 && (valor + 0.10) <= this.Saldo)
            {

                this.Saldo -= (valor + 0.10);
                return true;

            }
            else
            {
                throw new Exception("Valor do saque maior que o saldo");
            }

            return false;

        }

        public double CalcularTributo()
        {
            return this.Saldo * 0.02;
        }

    }
}
