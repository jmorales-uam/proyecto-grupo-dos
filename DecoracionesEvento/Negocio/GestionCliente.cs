using DecoracionesEvento.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoracionesEvento.Negocio
{
    public class GestionCliente
    {
        private List<Cliente> clientes = new List<Cliente>();

        public void AgregarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public Cliente ObtenerCliente (int clienteID)
        {
            return clientes.Find(c => c.ClienteID == clienteID);
        }
    }
}
