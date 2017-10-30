using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AulaDeMap.Models
{
    public class Professor
    {
        public int ProfessorID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public virtual Endereco Endereco { get; set; }

        public virtual ICollection<Disciplina> Disciplinas { get; set; }

        public Professor()
        {
            Disciplinas = new List<Disciplina>();
        }
    }
}