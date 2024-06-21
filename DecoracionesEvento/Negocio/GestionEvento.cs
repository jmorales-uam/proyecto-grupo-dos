using DecoracionesEvento.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoracionesEvento.Negocio
{
   public class GestionEvento
    {
        private List<Evento> eventos = new List<Evento>();

        public void CrearEvento(Evento evento)
        { 
            eventos.Add(evento);
        }

        public List<Evento> ObtenerEventos()
        {
            return eventos;
        }
    }
}
