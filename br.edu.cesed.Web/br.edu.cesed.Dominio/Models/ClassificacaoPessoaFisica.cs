using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.edu.cesed.Dominio.Models
{
    static class Constants
    {
        public const double rendaMaxUniversitario = 1000.00;
        public const double rendaMaxComun = 3000.00;
    
    }

    class ClassificacaoPessoaFisica : ClientePessoaFisica
    {
        public string ObtemClassificacao()
        {
            string tipo = "";
            if (rendaMensal <= Constants.rendaMaxUniversitario)
            {
                 tipo = "Univertisario";

            }
            if (rendaMensal <= Constants.rendaMaxComun)
            {
                tipo = "Comum";

            }
            else
            {
                tipo = "Ouro";
            }

            return tipo;

        }

        public void ObtemCredito()
        {
            var tipo = ObtemClassificacao();

            if ( tipo == "Univertisario")
            {
                saldo = 900;
            }
            if (tipo == "Comum")
            {
                saldo = 1500;
            } else
            {
                saldo = 15000;
            }

        }

        

    }
}
