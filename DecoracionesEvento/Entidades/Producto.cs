using DecoracionesEvento.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoracionesEvento.Entidades
{
    public class Producto : ReporteBase
    {
        public int ProductoID { get; set; }
        public string Nombre { get; set; }
        public string Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
