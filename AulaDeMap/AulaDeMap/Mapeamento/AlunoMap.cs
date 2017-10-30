using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using AulaDeMap.Models;

namespace AulaDeMap.Mapeamento
{
    public class AlunoMap : EntityTypeConfiguration<Aluno>
    {
        public AlunoMap()
        {
            //defina nome da tabela
            ToTable("Alunos");
            // defina chave primarias
            HasKey(x => x.AlunoID);

        }

    }
}