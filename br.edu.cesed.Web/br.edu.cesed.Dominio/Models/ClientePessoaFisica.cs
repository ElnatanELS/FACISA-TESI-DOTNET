using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.edu.cesed.Dominio.Models
{
    class ClientePessoaFisica : Cliente
    {
        public int ClientePessoaFisicaID { get; set; }

        public int cpf { get; set; }

        public double rendaMensal { get; set; }

        public enum Classificacao
        {
            universitario, comum, ouro
        }


    }
}
