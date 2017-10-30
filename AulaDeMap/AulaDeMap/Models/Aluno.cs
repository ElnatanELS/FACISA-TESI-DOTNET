using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AulaDeMap.Models
{
    public class Aluno
    {
        public int AlunoID { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }

        public virtual ICollection<Disciplina> Disciplinas { get; set; }

        public Aluno()
        {
            Disciplinas = new List<Disciplina>();
        }
    }
}