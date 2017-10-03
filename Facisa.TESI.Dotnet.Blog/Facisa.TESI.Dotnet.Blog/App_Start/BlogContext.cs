using Facisa.TESI.Dotnet.Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Facisa.TESI.Dotnet.Blog.App_Start
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Post {get; set; }

   
    }
}