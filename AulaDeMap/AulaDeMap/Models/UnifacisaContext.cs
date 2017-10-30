namespace AulaDeMap.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class UnifacisaContext : DbContext
    {
        public virtual DbSet<Aluno> Aluno { get; set; }

        public virtual DbSet<Professor> Professor { get; set; }
        public virtual DbSet<Disciplina> Disciplina { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }

        public UnifacisaContext()
            : base("name=UnifacisaContext")
        {
        }

       
    }

    
}