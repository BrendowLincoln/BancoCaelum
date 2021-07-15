using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCaelum
{
    class ContaPoupanca : Conta 
    {

        public ContaPoupanca(int numero = 0):  base (numero) { }
       

        public override bool Sacar(double valor)
        {

            return base.Sacar(valor + 0.10);

        }

    }
}
