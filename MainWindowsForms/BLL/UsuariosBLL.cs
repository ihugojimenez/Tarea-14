using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class UsuariosBLL
    {

        public static bool Insertar(Usuarios usuario)
        {
            bool hecho = false;
            try
            {
                using (var db = new AlmacenBancasDB())
                {
                    db.Usuarios.Add(usuario);
                    db.SaveChanges();
                    hecho = true;
                    db.Dispose();
                 }

            }catch(Exception ex)
            {
                throw ex;
            }

            return hecho;
        }


    }
}
