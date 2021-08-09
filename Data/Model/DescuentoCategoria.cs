using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBlazorApp.Data.Model
{
    public class DescuentoCategoria
    {
        public int pk_cod_descuento_ca { get; set; }
        public int fk_cod_categoria { get; set; }

        public float porcentaje { get; set; }
    }
}
