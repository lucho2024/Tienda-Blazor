using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBlazorApp.Data.Model
{
    public class Producto
    {
        public int pk_cod_producto { get; set; }
        public int fk_cod_tienda { get; set; }
        public int fk_cod_categoria { get; set; }
        public string nombre { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public float precio { get; set; }
        public float precioDescuento { get; set; }
        public string imagen { get; set; }

    }
}
