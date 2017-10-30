using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AulaDeMap.Models
{
    public class Disciplina
    {
        public int DisciplinaID { get; set; }
        public string Nome { get; set; }

        public virtual Professor Professor { get; set; }

        public virtual ICollection<Aluno> Alunos { get; set; }

        public Disciplina()
        {
            Alunos = new List<Aluno>();
        }
    }
}