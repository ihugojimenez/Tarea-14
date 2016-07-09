using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AlmacenBancasDB : DbContext
    {
        public AlmacenBancasDB() : base("name = AlmacenBancas")
        {

        }

        public virtual DbSet<Usuarios> Usuarios { get; set; }

        

    }
}
