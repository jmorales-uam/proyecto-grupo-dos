using DecoracionesEvento.Bases;
using DecoracionesEvento.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoracionesEvento.Negocio
{
    public class GestionReporte : ReporteBase
    {
        List<ReporteBase> Productos { get; set; } = new List<ReporteBase>();

        public void AgregarProducto(ReporteBase productos)
        {
            Productos.Add(productos);
        }

        public void AgregarProductos(List<ReporteBase> productos)
        {
            Productos.AddRange(productos);
        }

        public ReporteBase BuscarProductoPorID(int id)
        {
            return Productos.Find(p => p.Id == id);
        }

        public ReporteBase BuscarProductoPorNombre(string salon)
        {
            return Productos.Find(p => p.Eventos.Contains(salon));
        }

        public void EliminarProducto(int id)
        {
            Productos.RemoveAll(x => x.Id == id);
        }
        public void GenerarReporteInventario(string ruta, List<Producto> productos)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    #region Encabezado
                    var worksheet = workbook.Worksheets.Add("Reporte de Inventario");
                    var encabezado = worksheet.Row(1); 
                    worksheet.Cell(1, 1).Value = "ProductoID";
                    worksheet.Cell(1, 2).Value = "Nombre";
                    worksheet.Cell(1, 3).Value = "Cantidad";
                    worksheet.Cell(1, 4).Value = "Precio";
                    var rangoEncabezado = worksheet.Range("A1:D1");
                    rangoEncabezado.Style.Font.Bold = true;
                    rangoEncabezado.Style.Fill.BackgroundColor = XLColor.Blue;
                    rangoEncabezado.Style.Font.FontColor = XLColor.White;
                    #endregion
                    #region llenado de datos
                    int row = 2;
                    foreach (var producto in productos)
                    {
                        worksheet.Cell(row, 1).Value = producto.ProductoID;
                        worksheet.Cell(row, 2).Value = producto.Nombre;
                        worksheet.Cell(row, 3).Value = producto.Cantidad;
                        worksheet.Cell(row, 4).Value = producto.Precio;
                        row++;
                    }
                    #endregion
                    #region Guardado
                    workbook.SaveAs(ruta);
                    #endregion
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error al guardar el archivo excel: {ex.Message}");
            }
        }

        public List<ReporteBase> ListarReservas()
        {
            return Productos;
        }

        public void ModificarReservas(ReporteBase reserva)
        {
            var reservasAModificar = Productos.Find(p => p.Id == reserva.Id);
            if (reservasAModificar != null)
            {
                reservasAModificar.Productos = reserva.Productos;
                reservasAModificar.Servicios = reserva.Servicios;
                reservasAModificar.Eventos = reserva.Eventos;
            }
        }
    }
    }


    
