using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCaelum.Banco.Usuarios
{
    public class Cliente
    {

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }
        public string StatusLegal { get; set; }


        public Cliente(string nome = "Sem nome")
        {
            this.Nome = nome;
            this.StatusLegal = "Emancipado";
        }

        public bool EMaiorDeIdade()
        {


            if (this.Idade >= 18)
            {
                return true;
            }

            return false;
        }
       
        public bool PodeAbrirConta
        {
            get
            {
                var maiorDeIdade = this.Idade >= 18;
                var emancipado = this.StatusLegal.ToLower().Contains("emancipado");
                var possuiCpf = !string.IsNullOrEmpty(this.Cpf);

                return (maiorDeIdade || emancipado) && possuiCpf;

            }

        }

    }
}
