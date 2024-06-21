using DecoracionesEvento.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoracionesEvento.Negocio
{
    public class GestionServicio
    {
        private List<Servicio> servicios = new List<Servicio>();

        public void AgregarServicio (Servicio servicio)
        {
            servicios.Add(servicio);
        }

        public List<Servicio> ObtenerServicios()
        { 
            return servicios;
        }
    }
}
