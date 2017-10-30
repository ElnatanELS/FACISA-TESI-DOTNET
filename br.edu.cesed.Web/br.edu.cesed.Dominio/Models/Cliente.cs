using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.edu.cesed.Dominio.Models
{
    class Cliente
    {
        public int clienteId { get; set; }
        public string nome { get; set; }

        public string email { get; set; }


        public List<int> listTelefone { get; set; }

        public string endereço { get; set; }

        public double saldo { get; set; }

        public double credito { get; set; }






    }
}
