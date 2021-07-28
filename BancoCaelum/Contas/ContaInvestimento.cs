using BancoCaelum.Banco.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCaelum.Banco.Contas
{
    class ContaInvestimento : Conta, ITributavel
    {
        

        public override void Depositar(double valor)
        {
            if (valor != 0 && valor > 0)
            {

                Saldo += valor;
            }

        }

        public override void Sacar(double valor)
        {
            if (valor != 0 && valor <= this.Saldo)
            {

                this.Saldo -= (valor + 0.05);
          

            }

        }
        public double CalcularTributo()
        {
            return this.Saldo * 0.03;
        }
    }
}
