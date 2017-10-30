using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.edu.cesed.Dominio.Models
{
    class Telefone
    {
        public int TelefoneID { get; set; }

        public int numero { get; set; }

        public enum tipo
        {
            residencial,celular,comercial
        }

    }
}
