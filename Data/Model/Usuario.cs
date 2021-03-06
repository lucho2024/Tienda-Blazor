using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBlazorApp.Data.Model
{
    public class Usuario
    {
       
        public int pk_cod_usu { get; set; }
        public int fk_cod_tienda { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string pass { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

    }
}
