using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoracionesEvento.Bases
{
    public abstract class ReporteBase
    {
        public int Id { get; set; }
        public string Eventos { get; set; }
        public string Servicios { get; set; }
        public string Productos { get; set; }
    }
}
