using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        public string nombreusuario { get; set; }
        public string Contraseña { get; set; }
        public string nombre { get; set; }
        public string apellido  { get; set; }

        public Usuarios()
        {

        }

        public Usuarios(string nombreusuario, string Contraseña, string nombre, string apellido)
        {
            this.apellido = apellido;
            this.Contraseña = Contraseña;
            this.nombre = nombre;
            this.nombreusuario = nombreusuario;
        }

    }
}
