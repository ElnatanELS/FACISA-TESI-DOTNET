using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.edu.cesed.Dominio.Models
{
    class ClassificacaoPessoaJuridica : ClientePessoaJuridica
    {
        public string ObtemCategoria()
        {
            var tipo = "";
            if (Categorias.Industria == 0)
            {
                tipo = Categorias.Industria.ToString(); 

            } else
            {
                tipo = Categorias.comercioeserviços.ToString();
            }

            return tipo;
        }
        public string ObtemClassificacao()
        {
            var tipo = "";
            var qtdEmpregados = QuantidadeDeEmpregados;
            var cat = ObtemCategoria();
            if (cat == "Industria")
            {

            }
        }
    }
}
