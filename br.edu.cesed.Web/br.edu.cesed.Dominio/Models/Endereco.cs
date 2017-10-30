using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.edu.cesed.Dominio.Models
{
    class Endereco
    {
        public int EnderecoID { get; set; }

        public string logradouro { get; set; }

        public string bairro { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }

        public int cep { get; set; }

        public int numero { get; set; }


    }
}
