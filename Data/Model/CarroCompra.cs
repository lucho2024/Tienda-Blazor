using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBlazorApp.Data.Model
{
    public class CarroCompra
    {
        public int pk_cod_carro { get; set; }
        public int fk_usuario { get; set; }
    }
}
