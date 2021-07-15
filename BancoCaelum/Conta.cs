using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCaelum
{
    public class Conta
    {
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; private set;  }
        public string Tipo { get; set; }


        public Conta()
        {
            Saldo = 100.0;
        }

        public Conta(int numero)
        {
            this.Numero = numero;
        }

        public virtual bool Sacar(double valor)
        {

            if (valor != 0 && valor <= this.Saldo)
            {

                Saldo -= valor;
                return true;

            }

            return false;


        }

        public bool Depositar(double valor)
        {

            if (valor != 0 && valor > 0)
            {

                Saldo += valor;
                return true;
            }

            return false;

        }


        public bool Transferir(Conta favorecido, double valor)
        {

            if(Saldo >= valor || Saldo != 0.00)
            {

                this.Sacar(valor);
                favorecido.Depositar(valor);

                return true;

            }
            
            
            return false;


        }

        


    }
}
