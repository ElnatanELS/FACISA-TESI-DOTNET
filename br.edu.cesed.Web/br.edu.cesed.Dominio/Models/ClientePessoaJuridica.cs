using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.edu.cesed.Dominio.Models
{
    class ClientePessoaJuridica : Cliente
    {
        public int ClientePessoaJuridicaID { get; set; }

        public int Cnpj { get; set; }

        public int QuantidadeDeEmpregados { get; set; }

        public double Faturamento { get; set; }

        public string Site { get; set; }

        public string Categoria { get; set; }

        
        public enum Categorias
        {
            Industria, comercioeserviços
        }

        public enum Classificação
        {
            micro, pequena, media, grande
        }
    }
}
