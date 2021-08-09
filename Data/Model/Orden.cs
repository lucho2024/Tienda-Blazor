using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBlazorApp.Data.Model
{
    public class Orden
    {
        public int pk_cod_order { get; set; }
        public int fk_cod_carro { get; set; }
        public float total_pagar { get; set; }
        public string direccion_envio { get; set; }

        public string pagado { get; set; }
    }
}
