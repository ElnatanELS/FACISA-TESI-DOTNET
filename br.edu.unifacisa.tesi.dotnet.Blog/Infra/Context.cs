using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Infra
{
    public class Context : DbContext
    {
        public Context() : base("databaseBlog")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comentario>  Comentarios { get; set; }

    }
}
