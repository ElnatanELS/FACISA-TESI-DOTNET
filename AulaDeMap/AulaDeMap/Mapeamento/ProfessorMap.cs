using AulaDeMap.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace AulaDeMap.Mapeamento
{
    public class ProfessorMap : EntityTypeConfiguration<Professor>
    {
        public ProfessorMap()
        {
            //defina nome da tabela
            ToTable("Professores");
            // defina chave primaria
            HasKey(x => x.ProfessorID);

            HasRequired(x => x.Endereco).WithRequiredPrincipal(); 
        }
    }
}