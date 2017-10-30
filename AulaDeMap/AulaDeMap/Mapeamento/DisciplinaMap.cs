using AulaDeMap.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace AulaDeMap.Mapeamento
{
    public class DisciplinaMap : EntityTypeConfiguration<Disciplina>
    {
        public DisciplinaMap()
        {
            //defina nome da tabela
            ToTable("Disciplinas");
            // defina chave primaria
            HasKey(x => x.Alunos);

            HasMany(x => x.Alunos).WithMany(x => x.Disciplinas).Map(
                m =>
                {
                    m.MapLeftKey("DisciplinaID");
                    m.MapRightKey("AlunoID");
                    m.ToTable("disciplinas_alunos");
                }
                ); // muitos para muitos

            HasRequired(x => x.Professor).WithMany(x => x.Disciplinas).
                Map(m => m.MapKey("ProfessorID"));
        }
    }
}