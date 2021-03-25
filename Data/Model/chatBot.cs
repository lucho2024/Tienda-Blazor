using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBlazorApp.Data.Model
{
    public class chatBot
    {
        public int pk_cod_chat { get; set; }
        public int fk_cod_usu { get; set; }

        public string fecha_inicio { get; set; }
        public string fecha_fin { get; set; }

        public bool solucionado { get; set; }
    }
}
