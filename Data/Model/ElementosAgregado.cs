using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBlazorApp.Data.Model
{
    public class ElementosAgregado
    {
        public int fk_cod_carro { get; set; }
        public int fk_cod_producto { get; set; }

        public int cantidad { get; set; }
    }
}
