using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1.Tables
{
    public class Productos
    {
        public int PRODUCTOID { get; set; }
        public int PROVEEDORID { get; set; }
        public int CATEGORIAID { get; set; }
        public String DESCRIPCION { get; set; }
        public int PRECIOUNIT { get; set; }
        public int EXISTENCIA { get; set; }
    }
}
