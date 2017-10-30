
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AulaDeMap.Models
{
    public class Endereco
    {
        public int EnderecoID { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public virtual Professor  Professor { get; set; }
    }
}