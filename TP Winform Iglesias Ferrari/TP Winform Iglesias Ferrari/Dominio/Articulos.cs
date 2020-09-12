using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulos
    {
        private int ID;
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Imagen;

        public System.Data.SqlTypes.SqlMoney Precio;

    }



}
