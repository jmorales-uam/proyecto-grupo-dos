using DecoracionesEvento.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoracionesEvento.Negocio
{
    public class GestionProducto
    {
        private List<Producto> productos = new List<Producto>();

        public void AgregarProductos(Producto producto)
        {
            productos.Add(producto);
        }

        public List<Producto> OtenerProductos()
        {
            return productos;
        }

        public void ActualizarInventario(int productoID, int cantidad)
        {
            var producto = productos.Find(p => p.ProductoID == productoID);
            if (producto != null)
            {
                producto.Cantidad -= cantidad;
            }
        }
    }
}
