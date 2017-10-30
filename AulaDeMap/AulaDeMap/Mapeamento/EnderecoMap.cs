using AulaDeMap.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace AulaDeMap.Mapeamento
{
    public class EnderecoMap : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMap()
        {
            //defina nome da tabela
            ToTable("Enderecos");
            // defina chave primaria
            HasKey(x => x.EnderecoID);
        }

    }
}