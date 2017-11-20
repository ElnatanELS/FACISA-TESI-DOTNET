﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Post
    {
        public int PostID { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public DateTime DataCastrado { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<Comentario> Comentarios { get; set; }

        public virtual Area Area { get; set; }

        public Post()
        {
            Comentarios = new HashSet<Comentario>();

        }
    }
}
