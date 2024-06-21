using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoracionesEvento.Entidades
{
    public class Evento
    {
        public int EventoID { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteID { get; set; }
        public List<int> ServiciosIDs { get; set; }
        public List<int> ProductosIDs { get; set; }
    }
}
